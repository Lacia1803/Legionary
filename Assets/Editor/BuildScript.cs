using System.IO;
using UnityEditor;

public static class BuildScript
{
    static string[] GetScenes()
    {
        return new string[] {
            "Assets/All scenes/Main Menu.unity",
            "Assets/All scenes/Intro Video.unity",
            "Assets/All scenes/Level 1.unity",
            "Assets/All scenes/Level 2.unity",
            "Assets/All scenes/Level 3.unity",
            "Assets/All scenes/Game Over screen.unity",
            "Assets/All scenes/Win Screen.unity"
        };
    }

    public static void BuildWindows()
    {
        string path = Path.Combine(Directory.GetCurrentDirectory(), "Builds", "Windows", "Legionary.exe");
        Directory.CreateDirectory(Path.GetDirectoryName(path));
        BuildPlayerOptions opts = new BuildPlayerOptions();
        opts.scenes = GetScenes();
        opts.locationPathName = path;
        opts.target = BuildTarget.StandaloneWindows64;
        opts.options = BuildOptions.None;
        BuildPipeline.BuildPlayer(opts);
    }

    public static void BuildMac()
    {
        string path = Path.Combine(Directory.GetCurrentDirectory(), "Builds", "Mac", "Legionary.app");
        Directory.CreateDirectory(Path.GetDirectoryName(path));
        BuildPlayerOptions opts = new BuildPlayerOptions();
        opts.scenes = GetScenes();
        opts.locationPathName = path;
        opts.target = BuildTarget.StandaloneOSX;
        opts.options = BuildOptions.None;
        BuildPipeline.BuildPlayer(opts);
    }

    // CLI examples (run locally):
    // Windows (PowerShell):
    // "C:\Program Files\Unity\Hub\Editor\2023.1.9f1\Editor\Unity.exe" -quit -batchmode -projectPath "D:/Unity-2D-Platformer-master/Unity-2D-Platformer-master" -executeMethod BuildScript.BuildWindows -logFile build_windows.log
    // macOS (bash):
    // /Applications/Unity/Hub/Editor/2023.1.9f1/Unity.app/Contents/MacOS/Unity -quit -batchmode -projectPath "/path/to/project" -executeMethod BuildScript.BuildMac -logFile build_mac.log
}
