<p align="center">
  <img src="https://raw.githubusercontent.com/pardeike/Harmony/master/HarmonyLogo.png" alt="Harmony" width="180" /><br>
  <a href="https://www.nuget.org/packages/Bannerlord.Lib.Harmony" alt="NuGet Bannerlord.Lib.Harmony">
  <img src="https://img.shields.io/nuget/v/Bannerlord.Lib.Harmony.svg?label=NuGet%20Bannerlord.Lib.Harmony&colorB=blue" />
  </a>
</p>

### About

This is a light fork of Lib.Harmony with integrated MonoMod.Common. There's a difference in how Harmony exposes MonoMod.Common on .NET Framework and .NET (Core).  
In .NET Framework it's integrated (linked) within Harmony.  
In .NET (Core) it's exposed as a separate dependency.  
For consistence sake and compatibility reasons, we need to have a consistent behaviour, thus we forked Lib.Harmony and made it link the dependency on.NET (Core).  
  
Check the original for more info!
