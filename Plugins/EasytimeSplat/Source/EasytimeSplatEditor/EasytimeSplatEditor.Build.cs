/*
  Copyright (c) 2025 Easytime Technology Co., Ltd. See LICENSE.md.
*/

using System.IO;
using UnrealBuildTool;

public class EasytimeSplatEditor : ModuleRules
{
	public EasytimeSplatEditor(ReadOnlyTargetRules Target) : base(Target)
	{
		bUsePrecompiled = true;
		PrivateDefinitions.Add("SPLAT_EXPORT_API=__declspec(dllimport)");
		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				"AssetDefinition",
				"AssetRegistry",
				"Core",
				"CoreUObject",
				"Engine",
				"FileUtilities",
				"GeometryCore",
				"EasytimeSplatRuntime",
				"EasytimeSplatThirdParty",
				"ImageWrapper",
				"Json",
				"Kismet",
				"KismetCompiler",
				"UnrealEd",
				"RenderCore",
				"RHI"
			}
		);
	}
}


