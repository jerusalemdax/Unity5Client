using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
using UnityEditor.Callbacks;
#endif
using System.IO;
using System.Collections;

public class AndroidPostProcess {

	#if UNITY_EDITOR
	[PostProcessBuild(999)]
	public static void OnPostProcessBuild( BuildTarget target, string pathToBuiltProject )
	{
		
		if (target != BuildTarget.Android) {
			Debug.Log("Target is not Android. AndroidPostProcess will not run");
			return;
		}
		
		string unityVersion = Application.unityVersion;
		Debug.Log ("Build Android project in Unity " + unityVersion);
		if (unityVersion.StartsWith ("5.")) {
			// do nothing
		} else { // 4.x
			BuildInUnity4(pathToBuiltProject);
		}
	}
	#endif

	private static void BuildInUnity4(string pathToBuiltProject){
		Debug.Log ("Check the *.jar path in the project ...");

		string assetsPath = Application.dataPath;

		checkPlugins (Path.Combine(assetsPath, "Plugins"));
	}

	private static bool checkPlugins(string pluginsPath){

		string androidLibPath = Path.Combine (pluginsPath, "Android");
		if (!Directory.Exists (androidLibPath)) {
			UnityEngine.Debug.LogError("Please copy the files in the 'BuglyPlugins/Android' into 'Assets/Plugins/Android' in Unity " + Application.unityVersion);
			return false;
		} else {
			string jarPath = Path.Combine(androidLibPath, "buglyagent.jar");
			string jarPath2 = Path.Combine(androidLibPath, "libs/buglyagent.jar");

			if(!File.Exists(jarPath) && !File.Exists(jarPath2)) {
				UnityEngine.Debug.LogError("Please copy the files in the 'BuglyPlugins/Android' into 'Assets/Plugins/Android' in Unity " + Application.unityVersion);
				return false;
			}
		}

		return true;
	}

}
