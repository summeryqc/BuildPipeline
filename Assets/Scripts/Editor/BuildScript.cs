using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class BuildScript
{
    [MenuItem("Custom Utilities/Build StandaloneLinux64")]
    static void PerformBuild()
    {
        string[] defaultScene = { "Assets/Scenes/SampleScene.Unity" };
        /* BuildPipeline
		   	Lets you programmatically build players or AssetBundles which can be loaded from the web.
		   	Static Properties:
		   		isBuildingPlayer	Is a player currently being built?
		   	Static Methods:
		   		BuildAssetBundle	Builds an asset bundle.
				BuildAssetBundleExplicitAssetNames	Builds an asset bundle, with custom names for the assets.
				BuildAssetBundles	Build all AssetBundles specified in the editor.
				BuildPlayer	Builds a player.
				GetCRCForAssetBundle	Extract the crc checksum for the given AssetBundle.
				GetHashForAssetBundle	Extract the hash for the given AssetBundle.
				GetPlaybackEngineDirectory	Returns the path of a player directory. For ex., Editor\Data\PlaybackEngines\AndroidPlayer.In some cases the player directory path can be affected by BuildOptions.Development.
				IsBuildTargetSupported	Returns true if the specified build target is currently available in the Editor.
		*/
        BuildPipeline.BuildPlayer(defaultScene, "./Build/game",
            BuildTarget.StandaloneLinux64, BuildOptions.None);
    }

    // [MenuItem("Custom Utilities/Build AssetBundle StandaloneLinux64")]
    // static void PerformAssetBundleBuild()
    // {
    //     BuildPipeline.BuildAssetBundles("../AssetBundles/", BuildAssetBundleOptions.ChunkBasedCompression,
    //         BuildTarget.StandaloneLinux64);
    // }
}