using System.IO;
using UnityEditor;
using UnityEngine;

public static class Setup
{
    [MenuItem("Tools/Setup/Create Default Folders")]
    public static void CreateDefaultFolders()
    {
        Folders.CreateDefault("_Ttttanks",
            "Animation", "Art", "Materials", "Prefabs", "Scripts", "Settings");
    }
}

public static class Folders
{
    public static void CreateDefault(string root, params string[] folders)
    {
        var fullPath = Path.Combine(Application.dataPath, root);

        foreach (var folder in folders)
        {
            var folderPath = Path.Combine(fullPath, folder);

            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);
        }
    }
}