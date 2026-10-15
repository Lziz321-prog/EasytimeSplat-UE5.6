/*
  Copyright (c) 2025 Easytime Technology Co., Ltd. See LICENSE.md.
*/

using System.IO;
using UnrealBuildTool;

public class EasytimeSplatThirdParty : ModuleRules
{
	public EasytimeSplatThirdParty(ReadOnlyTargetRules Target) : base(Target)
	{
		bUsePrecompiled = true;
		PrivateDefinitions.Add("SPLAT_EXPORT_API=__declspec(dllexport)");
        PrivateDependencyModuleNames.Add("Core");
	}
}


