# Atomicrops ThunderKit Template
A template for making Atomicrops mods using ThunderKit.

## Prerequisites
* Install bepinex to to your game folder by following the instructions here (Atomicrops is **32-bit**): https://docs.bepinex.dev/articles/user_guide/installation/index.html

*The game will most likely crash when running for the first time. This is normal. It is also possible for it to not. It is recommended to restart after the initial run regardless.*

* Install Unity 2018.4.27. This can be found here: https://unity3d.com/get-unity/download/archive

## How to set up
1. Download the repo, either by using git clone or downloading as .zip and extracting.
2. Open the repo, and wait until the thunderkit settings menu pops up. Enter atomicrops.exe and the path of the folder that contains atomicrops.exe into the appropriate fields, and then click the "Locate Game" button.
3. Once the game is done being located, go to the toolbar at the top, navigate to Tools>ThunderKit>Packages. Under LocalThunderstoreSource, select BepInEx Pack and click install in the top right.
4. Select the Pipeline asset in the root Assets folder, and in the inspector click Execute. 

## Usage
After following these steps, under the root folder of the unity project, there should be a ThunderKit folder. Under there, there should be a Staging folder. In that folder will be a .dll, a readme, an icon, a manifest, and a .zip. The .zip is a publish-ready zip archive for ThunderStore. If you move the .dll to the BepInEx/plugins folder in your atomicrops directory, when you launch the game there should be a LogInfo message in the console/log from the mod. 

To make your own mod, simply edit plugin.cs and, if necessary, add additional scripts to modify whatever you want in the game. Many mods can be extremely simple, because most of the game's state is stored in singleton scriptableobjects, accessible via "SingletonScriptableObject<T\>.I" under the SharedLib namespace. For example, you can modify the default gun to be squirrels with the line "ConfigGame.I.Guns.DefaultGun = ConfigGame.I.Guns.SquirrelGun;". This will prevent that gun from being upgraded, however, without a harmony patch of some form on the appropriate method.
  
## Recommended Tools:
* dnSpy (.Net Decompilation): https://github.com/dnSpy/dnSpy

You can use dnSpy on Assembly-CSharp.dll under Atomicrops/Atomicrops_Data/Managed/ to view the disassembly of the game's code. This allows you to get a more-or-less clear picture of what's going on, with some weirdness from the decompiler attempting to interpret IL code as C# (or directly as IL, or VB, or F# if you really felt like it). 

* GameImporter: Tools>ThunderKit>Packages>ThunderKit Extensions>GameImporter

After installation you can run GameImporter under the Tools menu, and it will populate the assets folder with all of the assets of the game, allowing you to study them and see how the game works. Hint: much of the game is defined using singleton scriptableobjects and definition (suffix "Def") scriptable objects. 
  
*It is recommended to backup the shaders folder, as they have a tendency to randomly break which will make all visual assets turn bright purple.*
  
## Recommended documentation:
* ThunderKit: Accessible via Tools\>ThunderKit\>Documentation
* BepInEx: https://docs.bepinex.dev/master/articles/user_guide/installation/index.html
* HarmonyX: https://github.com/BepInEx/HarmonyX/wiki
* Harmony: https://harmony.pardeike.net/articles/intro.html

## Coming Soon:
* Example mods
* Discord
* Thunderstore hosting
