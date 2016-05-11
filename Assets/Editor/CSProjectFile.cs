public class CSProjectFile
{
    public static string CSProjectTypeGuid = @"FAE04EC0-301F-11D3-BF4B-00C04F79EFBC";
    public static string CSProjectTypeGuidEx = @"E097FAD1-6243-4DAD-9C02-E9B9EFC3FFC1";

    public string AssemblyName;
    public string Guid;
    public string ProjectPath;
    public string[] SrcList;

    public CSProjectFile(string assemblyName, string guid, string projectPath, string[] srcList)
    {
        AssemblyName = assemblyName;
        Guid = guid;
        ProjectPath = projectPath;
        SrcList = srcList;
    }
}
