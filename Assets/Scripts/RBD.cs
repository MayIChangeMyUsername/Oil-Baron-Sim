using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class RBPackageExporter : UnityEditor.EditorWindow
{
    private static string companyPath = "Assets/RedBlueGames";
    private static string packageExtension = ".unitypackage";
    private static string testPackageSuffix = "WithTests";
    private List<RBAsset> redBlueAssets;

    private bool includeTests;

    [MenuItem("Assets/RBPackage Exporter")]
    private static void ExportRBScriptsWithTests()
    {
        EditorWindow.GetWindow<RBPackageExporter>(false, "RBPackage Exporter", true);
    }

    private static List<string> GetTestDirectories(string[] directories)
    {
        var testDirectories = new List<string>();
        foreach (var directory in directories)
        {
            if (IsDirectoryAChildOfAnyOfThese(directory, testDirectories))
            {
                testDirectories.Add(directory);
                continue;
            }

            if (IsTestDirectory(directory))
            {
                testDirectories.Add(directory);
            }
        }

        return testDirectories;
    }

    private static bool IsDirectoryAChildOfAnyOfThese(string path, List<string> possibleParentDirectories)
    {
        foreach (var possibleParentDirectory in possibleParentDirectories)
        {
            if (path.Contains(possibleParentDirectory))
            {
                return true;
            }
        }

        return false;
    }

    private static bool IsTestDirectory(string path)
    {
        return System.IO.Path.GetFileName(path) == "Tests";
    }

    private void OnEnable()
    {
        this.redBlueAssets = new List<RBAsset>();
        this.FindAssetsInCompanyFolder();
    }

    private void FindAssetsInCompanyFolder()
    {
        foreach (var subdirectory in System.IO.Directory.GetDirectories(companyPath))
        {
            var splitSubdirectory = subdirectory.Split(System.IO.Path.DirectorySeparatorChar);
            string folderName = splitSubdirectory[splitSubdirectory.Length - 1];
            this.redBlueAssets.Add(new RBAsset()
            {
                AssetName = folderName,
                IsSelected = false
            });
        }
    }

    private void OnGUI()
    {
        EditorGUILayout.HelpBox(
            "This tool Allows quick export of specific RedBlueGames custom assets. It also allows optional export of Tests folders.",
            MessageType.None);
        EditorGUILayout.LabelField("Asset Packages to export:", EditorStyles.boldLabel);
        EditorGUILayout.BeginVertical();
        for (int i = 0; i < this.redBlueAssets.Count; i++)
        {
            this.redBlueAssets[i].IsSelected = EditorGUILayout.Toggle(
                this.redBlueAssets[i].AssetName,
                this.redBlueAssets[i].IsSelected);
        }

        EditorGUILayout.EndVertical();

        bool atLeastOnePackageSelected = false;
        foreach (var assetPackage in this.redBlueAssets)
        {
            if (assetPackage.IsSelected)
            {
                atLeastOnePackageSelected = true;
                break;
            }
        }

        EditorGUILayout.Separator();
        this.includeTests = EditorGUILayout.Toggle("Include Tests", this.includeTests);

        EditorGUI.BeginDisabledGroup(!atLeastOnePackageSelected);
        if (GUILayout.Button("Export"))
        {
            this.ExportAllPackages(this.includeTests);
        }

        EditorGUI.EndDisabledGroup();

        if (!atLeastOnePackageSelected)
        {
            EditorGUILayout.HelpBox(
                "No packages selected to export. Select at least one asset Package.",
                MessageType.Warning);
        }
    }

    private void ExportAllPackages(bool includeTests)
    {
        foreach (var asset in this.redBlueAssets)
        {
            if (asset.IsSelected)
            {
                this.ExportRBScripts(asset, includeTests);
            }
        }
    }

    private void ExportRBScripts(RBAsset assetToExport, bool includeTests)
    {
        var subDirectories = System.IO.Directory.GetDirectories(companyPath, "*", System.IO.SearchOption.AllDirectories);
        var directoriesToExport = new List<string>(subDirectories);

        var testDirectories = GetTestDirectories(subDirectories);
        if (!includeTests)
        {
            foreach (var testDirectory in testDirectories)
            {
                directoriesToExport.Remove(testDirectory);
            }
        }

        foreach (var asset in this.redBlueAssets)
        {
            if (assetToExport.AssetName != asset.AssetName)
            {
                string assetPath = companyPath + System.IO.Path.DirectorySeparatorChar + asset.AssetName;
                directoriesToExport.Remove(assetPath);

                var subdirectoriesOfAsset = System.IO.Directory.GetDirectories(assetPath, "*", System.IO.SearchOption.AllDirectories);
                foreach (var subdirectory in subdirectoriesOfAsset)
                {
                    directoriesToExport.Remove(subdirectory);
                }
            }
        }

        var allAssetPaths = new List<string>();
        foreach (var directory in directoriesToExport)
        {
            var filesInDirectory = System.IO.Directory.GetFiles(directory);
            allAssetPaths.AddRange(filesInDirectory);
        }

        if (allAssetPaths.Count == 0)
        {
            Debug.Log("No assets to export. Will not export asset package: " + assetToExport.AssetName);
            return;
        }

        string filename = string.Concat(assetToExport.AssetName, includeTests ? testPackageSuffix : string.Empty, packageExtension);
        AssetDatabase.ExportPackage(
            allAssetPaths.ToArray(),
            filename,
            ExportPackageOptions.IncludeDependencies | ExportPackageOptions.Interactive);
    }

    private class RBAsset
    {
        public string AssetName { get; set; }

        public bool IsSelected { get; set; }
    }
}