using System.Diagnostics;
using UnityEngine;

public class CommandLineTool{

    public static void Command(string cmd, string arguments)
    {
        var p = new Process();
        p.StartInfo.UseShellExecute = false;
        p.StartInfo.RedirectStandardOutput = true;
        p.StartInfo.RedirectStandardError = true;
        p.StartInfo.FileName = cmd;
        p.StartInfo.Arguments = arguments;
        p.StartInfo.CreateNoWindow = true;
        p.Start();

        string output = p.StandardOutput.ReadToEnd();
        string error = p.StandardError.ReadToEnd();

        p.WaitForExit();

        if (!string.IsNullOrEmpty(output))
        {
            UnityEngine.Debug.Log(output);
        }
        if (!string.IsNullOrEmpty(error))
        {
            UnityEngine.Debug.LogError(error);
        }
    }
}
