# Creating mods
Note: A helpful resource for making mods is [MelonLoaderDocs](https://melonwiki.xyz/#/)

## Try building the Demo mod
* Clone the repo.
* Install [MelonLoader](https://github.com/LavaGang/MelonLoader). you can use a automated install. or install [Primitier mod manager](https://github.com/Xgames123/PrimitierModManager/releases)
* Install [PMFTool](./PMFTool/InstallPMFTool.md)

* Try building the demoMod project.

* Try running the demoMod by running ```PMFTool run```
    - If it doesn't work run ```PMFTool update-dlls```
    - If that doesn't work run primitier so that melonloader can generate the dlls and run ```PMFTool update-dlls``` again

* If you need help feel free to start a issue on GitHub


## Setup a project
* Copy the DemoProject
* In AssemblyInfo.cs change the the values in the buildInfo class
* In Mod.json change the values to your own
* Rename DemoMod.cs to your own mods name

* run ```PMFTool update-dlls```
* to run use ```PMFTool run``` Note: PMFTool doesn't build your project so you have to build it first before you call ```PMFTool run```

* If you need help feel free to start a issue on GitHub.


## Package a mod for Primiter mod manager
* run ```PMFTool pack --format Pmfm``` you can change the format to zip if you want compatibility with raw melonLoader



## Documentation

* [PMFTool](./PMFTool/PMFTool.md)

* [Custom substances and materials](./CustomSubstancesAndMaterials.md)

* [Custom objects like Drones, Slimes, Engines, ...](./CreatingCustomObjects.md)

* [Dumping](./Dumping.md)

* [PMFSystems](./PMFSystems.md)

* [Mod.json](./Mod.json.md)