# Atomicrops ThunderKit Template
A template for making Atomicrops mods using ThunderKit.

## Prerequisites
* Install Unity 2018.4.27. This can be found here: https://unity3d.com/get-unity/download/archive

## How to set up
1. Download the repo, either by using git clone or downloading as .zip and extracting.
2. Open the repo with Unity 2018.4.27, and wait until the thunderkit settings menu pops up. Click the "Locate Game" button (If you don't enter an executable/path, a file explorer dialog will pop up to select it).
3. Once the game is done being located, go to the toolbar at the top, navigate to Tools>ThunderKit>Packages. Under LocalThunderstoreSource, select BepInExPack and click install in the top right.
4. Select the Rebuild And Launch Pipeline asset in the root Assets folder, and in the inspector click Execute. 

## Usage
To make your own mod, simply edit plugin.cs and, if necessary, add additional scripts (**All scripts must be in a folder with a properly configured asmdef!!!**)to modify whatever you want in the game. Many mods can be extremely simple, because most of the game's state is stored in singleton scriptableobjects, accessible via "SingletonScriptableObject<T\>.I" under the SharedLib namespace. For example, you can modify the default gun to be squirrels with the line "ConfigGame.I.Guns.DefaultGun = ConfigGame.I.Guns.SquirrelGun;". This will prevent that gun from being upgraded, however, without a harmony patch of some form on the appropriate method.

To configure an asmdef properly, check override references and add the references that the template asmdef has. You may optionally copy the constraints from the template asmdef as well.
  
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
