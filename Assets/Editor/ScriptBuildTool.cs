using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using UnityEditor;
using UnityEngine;

public class ScriptBuildTool
{

    [MenuItem("Build/Generate Script Project")]
    public static void GenerateProjectFiles()
    {
        List<CSProjectFile> csProjectList = new List<CSProjectFile>();
        List<string> scriptSrcList = new List<string>();
        scriptSrcList.Add(@".\**\*.cs");
        CSProjectFile scriptProj = new CSProjectFile("Scripts", "87044393-6696-4D07-3815-2463D890CDAE", "Scripts/Scripts.csproj", scriptSrcList.ToArray());
        GenerateCSProject(scriptProj);

// TODO Assembly-CSharp自己生成，不用依赖Unity
//        List<string> engineSrcList = new List<string>();
//        engineSrcList.Add(@"..\Assets\Core\**\*.cs");
//        engineSrcList.Add(@"..\Assets\Extensions\**\*.cs");
//        CSProjectFile engineProj = new CSProjectFile("Assembly-CSharp", "6AC29F59-D154-4BB0-86C5-1CFA1A3F2473", "Scripts/Source.CSharp.csproj", engineSrcList.ToArray());
//        GenerateCSProject(engineProj);
        csProjectList.Add(scriptProj);
        GenerateScriptSlnFile(csProjectList.ToArray());
    }

    public static void GenerateCSProject(CSProjectFile csproj)
    {
        var doc = new XmlDocument();
        doc.AppendChild(doc.CreateXmlDeclaration("1.0", "utf-8", null));
        var project = doc.CreateElement("Project");
        project.SetAttribute("ToolsVersion", "4.0");
        project.SetAttribute("DefaultTargets", "Build");
        project.SetAttribute("xmlns", "http://schemas.microsoft.com/developer/msbuild/2003");
        var propertyGroup = doc.CreateElement("PropertyGroup");
        var configuration = doc.CreateElement("Configuration");
        configuration.SetAttribute("Condition", " '$(Configuration)' == '' ");
        configuration.InnerText = "Debug";
        propertyGroup.AppendChild(configuration);
        var platform = doc.CreateElement("Platform");
        platform.SetAttribute("Condition", " '$(Platform)' == '' ");
        platform.InnerText = "AnyCPU";
        propertyGroup.AppendChild(platform);
        var productVersion = doc.CreateElement("ProductVersion");
        productVersion.InnerText = "10.0.20506";
        propertyGroup.AppendChild(productVersion);
        var schemaVersion = doc.CreateElement("SchemaVersion");
        schemaVersion.InnerText = "2.0";
        propertyGroup.AppendChild(schemaVersion);
        var projectGuid = doc.CreateElement("ProjectGuid");
        projectGuid.InnerText = "{" + csproj.Guid + "}";
        propertyGroup.AppendChild(projectGuid);
        var outputType = doc.CreateElement("OutputType");
        outputType.InnerText = "Library";
        propertyGroup.AppendChild(outputType);
        var assemblyName = doc.CreateElement("AssemblyName");
        assemblyName.InnerText = csproj.AssemblyName;
        propertyGroup.AppendChild(assemblyName);
        var fileAlignment = doc.CreateElement("FileAlignment");
        fileAlignment.InnerText = "512";
        propertyGroup.AppendChild(fileAlignment);
        var projectTypeGuids = doc.CreateElement("ProjectTypeGuids");
        projectTypeGuids.InnerText = "{" + CSProjectFile.CSProjectTypeGuidEx + "};{" + CSProjectFile.CSProjectTypeGuid + "}";
        propertyGroup.AppendChild(projectTypeGuids);
        var targetFrameworkIdentifier = doc.CreateElement("TargetFrameworkIdentifier");
        targetFrameworkIdentifier.InnerText = ".NETFramework";
        var targetFrameworkVersion = doc.CreateElement("TargetFrameworkVersion");
        targetFrameworkVersion.InnerText = "v3.5";
        project.AppendChild(propertyGroup);
        project.AppendChild(GeneratePlatformPropertyGroup(doc, "Debug"));
        project.AppendChild(GeneratePlatformPropertyGroup(doc, "Release"));
        project.AppendChild(GenReferenceItemGroup(doc));
        var itemGroup = doc.CreateElement("ItemGroup");
        foreach (var src in csproj.SrcList)
        {
            var compile = doc.CreateElement("Compile");
            compile.SetAttribute("Include", src);
            itemGroup.AppendChild(compile);
        }
        project.AppendChild(itemGroup);
        var import = doc.CreateElement("Import");
        import.SetAttribute("Project", @"$(MSBuildToolsPath)\Microsoft.CSharp.targets");
        project.AppendChild(import);
        var target = doc.CreateElement("Target");
        target.SetAttribute("Name", "AfterBuild");
        var copy = doc.CreateElement("Copy");
        copy.SetAttribute("SourceFiles", @"$(OutputPath)Scripts.dll");
        copy.SetAttribute("DestinationFolder", @"..\StreamingAssets");
        copy.SetAttribute("ContinueOnError", "false");
        target.AppendChild(copy);
        project.AppendChild(target);
        doc.AppendChild(project);
        doc.Save(csproj.ProjectPath);
    }

    public static void GenerateScriptSlnFile(CSProjectFile[] csProjects)
    {
        FileStream fs = new FileStream("Scripts/Scripts.sln", FileMode.Create, FileAccess.Write, FileShare.ReadWrite);

        StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.ASCII);

        string sectionString = "";
        foreach (var csProject in csProjects)
        {
            sectionString +=  "{" + csProject.Guid + "}.Debug|Any CPU.ActiveCfg = Debug|Any CPU" +
                               Environment.NewLine + "\t" + "\t" +
                               "{" + csProject.Guid + "}.Debug|Any CPU.Build.0 = Debug|Any CPU" +
                               Environment.NewLine + "\t" + "\t" +
                               "{" + csProject.Guid + "}.Release|Any CPU.ActiveCfg = Release|Any CPU" +
                               Environment.NewLine + "\t" + "\t" +
                               "{" + csProject.Guid + "}.Release|Any CPU.Build.0 = Release|Any CPU";
        }


        sw.Write("Microsoft Visual Studio Solution File, Format Version 12.00" +
           Environment.NewLine + "# Visual Studio 14" +
           Environment.NewLine + "VisualStudioVersion = 14.0.25123.0" +
           Environment.NewLine + "MinimumVisualStudioVersion = 10.0.40219.1" +
           Environment.NewLine + "Project(" + "\"{" + CSProjectFile.CSProjectTypeGuid + "}\"" + ") = " + "\"Scripts\"" + ", " + "\"Scripts.csproj\"" + ", " + "\"{87044393-6696-4D07-3815-2463D890CDAE}\"" +
           Environment.NewLine + "EndProject" +
           Environment.NewLine + "Global" +
           Environment.NewLine + "\t" + "GlobalSection(SolutionConfigurationPlatforms) = preSolution" +
           Environment.NewLine + "\t" + "\t" + "Debug|Any CPU = Debug|Any CPU" +
           Environment.NewLine + "\t" + "\t" + "Release|Any CPU = Release|Any CPU" +
           Environment.NewLine + "\t" + "EndGlobalSection" +
           Environment.NewLine + "\t" + "GlobalSection(ProjectConfigurationPlatforms) = postSolution" +
           Environment.NewLine + "\t" + "\t" + sectionString +
           Environment.NewLine + "\t" + "EndGlobalSection" +
           Environment.NewLine + "\t" + "GlobalSection(SolutionProperties) = preSolution" +
           Environment.NewLine + "\t" + "\t" + "HideSolutionNode = FALSE" +
           Environment.NewLine + "\t" + "EndGlobalSection" +
           Environment.NewLine + "EndGlobal" + Environment.NewLine);
        sw.Flush();
        sw.Close(); fs.Close();
    }

    private static XmlElement GeneratePlatformPropertyGroup(XmlDocument doc, string mode)
    {
        XmlElement propertyGroup = doc.CreateElement("PropertyGroup");
        propertyGroup.SetAttribute("Condition", " '$(Configuration)|$(Platform)' == '" + mode + "|AnyCPU' ");
        var debugType = doc.CreateElement("DebugType");
        debugType.InnerText = "pdbonly";
        propertyGroup.AppendChild(debugType);
        var optimize = doc.CreateElement("Optimize");
        optimize.InnerText = "false";
        propertyGroup.AppendChild(optimize);
        var outputPath = doc.CreateElement("OutputPath");
        outputPath.InnerText = string.Format(@"bin\{0}\", mode);
        propertyGroup.AppendChild(outputPath);
        var intermediateOutputPath = doc.CreateElement("IntermediateOutputPath");
        intermediateOutputPath.InnerText = string.Format(@"obj\{0}\", mode);
        propertyGroup.AppendChild(intermediateOutputPath);
        var errorRepoert = doc.CreateElement("ErrorReport");
        errorRepoert.InnerText = "prompt";
        propertyGroup.AppendChild(errorRepoert);
        var warningLevel = doc.CreateElement("WarningLevel");
        warningLevel.InnerText = "4";
        propertyGroup.AppendChild(warningLevel);
        string defineStr =
            "TRACE;UNITY_5_3_OR_NEWER;UNITY_5_3_4;UNITY_5_3;UNITY_5;ENABLE_NEW_BUGREPORTER;ENABLE_AUDIO;ENABLE_CACHING;ENABLE_CLOTH;ENABLE_DUCK_TYPING;ENABLE_FRAME_DEBUGGER;ENABLE_GENERICS;ENABLE_HOME_SCREEN;ENABLE_IMAGEEFFECTS;ENABLE_LIGHT_PROBES_LEGACY;ENABLE_MICROPHONE;ENABLE_MULTIPLE_DISPLAYS;ENABLE_PHYSICS;ENABLE_PLUGIN_INSPECTOR;ENABLE_SHADOWS;ENABLE_SINGLE_INSTANCE_BUILD_SETTING;ENABLE_SPRITERENDERER_FLIPPING;ENABLE_SPRITES;ENABLE_SPRITE_POLYGON;ENABLE_TERRAIN;ENABLE_RAKNET;ENABLE_UNET;ENABLE_UNITYEVENTS;ENABLE_VR;ENABLE_WEBCAM;ENABLE_WWW;ENABLE_CLOUD_SERVICES;ENABLE_CLOUD_SERVICES_ADS;ENABLE_CLOUD_HUB;ENABLE_CLOUD_PROJECT_ID;ENABLE_CLOUD_SERVICES_PURCHASING;ENABLE_CLOUD_SERVICES_ANALYTICS;ENABLE_CLOUD_SERVICES_UNET;ENABLE_CLOUD_SERVICES_BUILD;ENABLE_CLOUD_LICENSE;ENABLE_EDITOR_METRICS;ENABLE_EDITOR_METRICS_CACHING;INCLUDE_DYNAMIC_GI;INCLUDE_GI;INCLUDE_IL2CPP;INCLUDE_DIRECTX12;PLATFORM_SUPPORTS_MONO;RENDER_SOFTWARE_CURSOR;ENABLE_LOCALIZATION;ENABLE_ANDROID_ATLAS_ETC1_COMPRESSION;ENABLE_EDITOR_TESTS_RUNNER;UNITY_STANDALONE_WIN;UNITY_STANDALONE;ENABLE_SUBSTANCE;ENABLE_TEXTUREID_MAP;ENABLE_RUNTIME_GI;ENABLE_MOVIES;ENABLE_NETWORK;ENABLE_CRUNCH_TEXTURE_COMPRESSION;ENABLE_LOG_MIXED_STACKTRACE;ENABLE_UNITYWEBREQUEST;ENABLE_EVENT_QUEUE;ENABLE_CLUSTERINPUT;ENABLE_WEBSOCKET_HOST;ENABLE_MONO;ENABLE_PROFILER;DEBUG;TRACE;UNITY_ASSERTIONS;UNITY_EDITOR;UNITY_EDITOR_64;UNITY_EDITOR_WIN;UNITY_TEAM_LICENSE;UNITY_PRO_LICENSE";
        var defineConstants = doc.CreateElement("DefineConstants");
        defineConstants.InnerText = string.Format("{0};{1}", mode.ToUpper(), defineStr);
        propertyGroup.AppendChild(defineConstants);
        var allowUnsafeBlocks = doc.CreateElement("AllowUnsafeBlocks");
        allowUnsafeBlocks.InnerText = "false";
        propertyGroup.AppendChild(allowUnsafeBlocks);
        return propertyGroup;
    }

    public static XmlElement GenReferenceItemGroup(XmlDocument doc)
    {
        var itemGroup = doc.CreateElement("ItemGroup");
        itemGroup.AppendChild(GenerateReference(doc, "mscorlib"));
        itemGroup.AppendChild(GenerateReference(doc, "System"));
        itemGroup.AppendChild(GenerateReference(doc, "System.XML"));
        itemGroup.AppendChild(GenerateReference(doc, "System.Core"));
        itemGroup.AppendChild(GenerateReference(doc, "System.Runtime.Serialization"));
        itemGroup.AppendChild(GenerateReference(doc, "System.Xml.Linq"));
        itemGroup.AppendChild(GenerateReference(doc, "UnityEngine", Path.Combine(GetManagedFolder(), "UnityEngine.dll")));
        itemGroup.AppendChild(GenerateReference(doc, "UnityEditor", Path.Combine(GetManagedFolder(), "UnityEditor.dll")));
        itemGroup.AppendChild(GenerateReference(doc, "UnityEngine.UI", Path.Combine(GetFrameWorksFolder(), @"UnityExtensions\Unity\GUISystem\UnityEngine.UI.dll")));
        itemGroup.AppendChild(GenerateReference(doc, "Assembly-CSharp", @"..\Library\Assembly-CSharp\Assembly-CSharp.dll"));
        return itemGroup;
    }

    public static XmlElement GenerateReference(XmlDocument doc, string library, string hintPath = null)
    {
        var reference = doc.CreateElement("Reference");
        reference.SetAttribute("Include", library);
        if (hintPath != null)
        {
            var hintPathNode = doc.CreateElement("HintPath");
            hintPathNode.InnerText = hintPath;
            reference.AppendChild(hintPathNode);
        }
        return reference;
    }

    public static string GetFrameWorksFolder()
    {
        var editorAppPath = EditorApplication.applicationPath;
        if (Application.platform == RuntimePlatform.WindowsEditor)
            return Path.Combine(Path.GetDirectoryName(editorAppPath), "Data");
        else if (Application.platform == RuntimePlatform.OSXEditor)
            return Path.Combine(editorAppPath, Path.Combine("Contents", "Frameworks"));
        else // Linux...?
            return Path.Combine(Path.GetDirectoryName(editorAppPath), "Data");
    }

    public static string GetManagedFolder()
    {
        return Path.Combine(GetFrameWorksFolder(), "Managed");
    }
}
