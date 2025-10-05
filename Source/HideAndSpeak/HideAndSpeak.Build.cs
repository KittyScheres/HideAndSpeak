// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class HideAndSpeak : ModuleRules
{
	public HideAndSpeak(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"HideAndSpeak",
			"HideAndSpeak/Variant_Platforming",
			"HideAndSpeak/Variant_Platforming/Animation",
			"HideAndSpeak/Variant_Combat",
			"HideAndSpeak/Variant_Combat/AI",
			"HideAndSpeak/Variant_Combat/Animation",
			"HideAndSpeak/Variant_Combat/Gameplay",
			"HideAndSpeak/Variant_Combat/Interfaces",
			"HideAndSpeak/Variant_Combat/UI",
			"HideAndSpeak/Variant_SideScrolling",
			"HideAndSpeak/Variant_SideScrolling/AI",
			"HideAndSpeak/Variant_SideScrolling/Gameplay",
			"HideAndSpeak/Variant_SideScrolling/Interfaces",
			"HideAndSpeak/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
