<p align="center">
  <img src="https://raw.githubusercontent.com/pardeike/Harmony/master/HarmonyLogo.png" alt="Harmony" width="180" /><br>
  <a href="https://www.nuget.org/packages/Bannerlord.Lib.Harmony" alt="NuGet Bannerlord.Lib.Harmony">
    <img src="https://img.shields.io/nuget/v/Bannerlord.Lib.Harmony.svg?label=NuGet%20Bannerlord.Lib.Harmony&colorB=blue" />
  </a>
</p>

### About

This is a fork of Lib.Harmony with the following features:
* We removed MonoMod.Common from Harmony - there's a difference in how Harmony exposes MonoMod.Common on .NET Framework and .NET (Core):
  * In .NET Framework it's integrated (statically linked) within Harmony.  
  * In .NET (Core) it's exposed as a separate dependency.  
For consistence sake and compatibility reasons, we need to have a consistent behaviour, removed MonoMod.Common and redirected the integrated types via TypeForwardedTo.  
* We also reduced the targets to net472, netcoreapp3.1 and netstandard2.0 to target only game supported runtimes.  
* We replaced MonoMod.Common with MonoMod.Utils and MonoMod.RuntimeDetours.

This fork is _**fully**_ backwards compatible with the original **Lib.Harmony**!
  
Check the original repo for more info!

## Harmony Origin Notes
* The name of `0Harmony.dll` was chosen due to RimWorld's assembly load order. It's alphabetical
* MonoMod.Common was merged into Harmony via ILMerge because of RimWorld. It load assemblies as byte[], preventing the load of sub-dependencies
* MonoMod.Common is a fork of MonoMod.Utils and MonoMod.RuntimeDetours
