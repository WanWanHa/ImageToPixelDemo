// Copyright (c) 2023, Hong Gu <guhong.usa@gmail.com>. All Rights Reserved.

using UnrealBuildTool;

public class ImageOperatorDemo : ModuleRules
{
	public ImageOperatorDemo(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
	
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "ImageOperator" });

		PrivateDependencyModuleNames.AddRange(new string[] {  });
	}
}
