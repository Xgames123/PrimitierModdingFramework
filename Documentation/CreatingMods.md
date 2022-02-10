# Creating mods
Note: A helpful resource for making mods is [MelonLoaderDocs](https://melonwiki.xyz/#/)

## Try building the Demo mod
* Clone the repo.
* Install MelonLoader. you can use a automated install.
* Try building the demoMod project.
* Open 'RunInDebug.ps1' and change $PRIMITIER_PATH= to the [install directory of Primitier](#get-the-install-directory-of-primitier.)
* Than run 'RunInDebug.ps1' or copy the files form the bin/Debug folder to the mods folder in the [install directory of Primitier](#get-the-install-directory-of-primitier.)
* Run Primitier
* If you need help feel free to start a issue on GitHub


## Setup a project
* Creating a .NET Framework 4.7.2. or lower project.
* Add PrimtierModdingFramework.dll as a reference.

* Go to the [Primitier install directory](#get-the-install-directory-of-primitier.)/MelonLoader and add MelonLoader.dll as a reference and than go to [Primitier install directory](#get-the-install-directory-of-primitier.)/MelonLoader/Managed and add the dlls that you need

* In the AssemblyInfo.cs file add ```
[assembly: MelonInfo(typeof(DemoMod.DemoMod), "Description of your mod", "1.0.0", "you name")]
[assembly: MelonGame("PrimitierDev", "Primitier")  ```

* Copy 'RunInDebug.ps1' from the demo mod or copy the files form the bin/Debug folder to the mods folder in the [install directory of Primitier](#get-the-install-directory-of-primitier.)

* If you need help feel free to start a issue on GitHub.


## Package a mod for Primiter mod manager
* Create a .zip file and add the files for your mod to it. NOTE: You don't have to add the generated dlls from MelonLoader because they will copied by Primiter mod manager
* Add a Mod.json file to your .zip file. [see Mod.json](/Mod.json.md)
* Add a Icon.png (This is optional)
* Rename the .zip file to .pmfm (This is optional)


### Get the install directory of Primitier.
* Go to steam and click the gear icon on the Primitier page
![Gear](GearIcon.png)

* Click on properties and than on local files and than on browse.

## Creating custom substances
[Custom substances](./CustomSubstances.md)

## Dumping the state of the game
[Duming](./Dumping.md)

## PMFSystems
[PMFSystems](./PMFSystems.md)