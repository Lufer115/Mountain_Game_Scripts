# Mountain Game — Reconstructed Portfolio Scripts

These scripts were reconstructed from the final Unity WebGL build.

## What was recovered

The build preserved:
- the original custom class names
- method names
- serialized field names
- Unity component relationships
- source-file paths
- several useful strings and debug messages

The build used IL2CPP, so the original C# source text was not preserved verbatim. The method bodies in this folder are therefore readable portfolio reconstructions based on the recovered metadata, the compiled build's strings, and the game's known behavior.

## Important

These are NOT claimed to be byte-for-byte copies of the lost source files.

For a portfolio, I recommend describing them as:
"Reconstructed source from the final WebGL build" if you need to be completely transparent.

## Scripts

Custom gameplay/UI scripts:
- PlayerController.cs
- GliderRB.cs
- GliderDeactivation.cs
- GliderUnlockZone.cs
- Climb.cs
- ClimbRB.cs
- WallClimb.cs
- WallClimbLukeTrigger.cs
- RespawnBack.cs
- GliderPopup.cs
- GliderDeactivationPopup.cs
- PopupTrigger.cs
- StartJourneyPopup.cs
- UIicon.cs
- PlayerInteraction.cs
- CameraController.cs
- PauseMenu.cs
- VolumeSettings.cs
- LoadEndingCutscene.cs
- Cutscene.cs
- StartScene.cs
- Movement.cs
- Gliding.cs
- FPSController.cs

Imported asset scripts:
- EgyptMonsters_DealDamageComponent.cs
- EgyptMonsters_DemoController.cs
- EgyptMonsters_DestroyMe.cs

The last three appear under Assets/EgyptMonsters in the original build and should be treated as third-party/imported code rather than original project work unless you know otherwise.
