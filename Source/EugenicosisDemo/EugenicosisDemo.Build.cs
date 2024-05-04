// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class EugenicosisDemo : ModuleRules
{
	public EugenicosisDemo(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { 
			"Core", 
			"CoreUObject",
			"Slate",
			"SlateCore",
			"Engine", 
			"InputCore",
            "EnhancedInput",
			"UMG"});
	}
}
