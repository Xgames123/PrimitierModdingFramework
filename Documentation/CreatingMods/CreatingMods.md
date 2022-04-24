# Creating mods
Note: A helpful resource for making mods is [MelonLoaderDocs](https://melonwiki.xyz/#/)

**Note: if any of this documentation is wrong or contains spelling errors please create an issue**

## Try building the Demo mod
1) Clone the repo.

2) Install [Primitier mod manager](https://github.com/Xgames123/PrimitierModManager/releases). or MelonLoader [MelonLoader](https://github.com/LavaGang/MelonLoader). For melonLoader you can use a automated install.

3) Install [PMFTool](./PMFTool/InstallPMFTool.md)

4) Try building the demoMod project.

5) Try running the demoMod by running ```PMFTool run```
    - If it doesn't work run ```PMFTool update-dlls```
    - If that doesn't work run primitier so that melonloader can generate the dlls and run ```PMFTool update-dlls``` again

6) If you need help feel free to start a issue on GitHub


## Setup a project Using the template
1) download ```XGames105.PMF.Templates.0.3.0.nupkg``` from the latest release

2) Install the template by running ```dotnet new --install C:/full/path/to/XGames105.PMF.Templates.0.3.0.nupkg```
    
    Note: --install should end with XGames105.PMF.Templates.0.3.0.nupkg

    Note: To uninstall the templates run ```dotnet new --uninstall XGames105.PMF.Templates```

2) Create a new project and select the 'Empty PMF mod'
5) run ```PMFTool update-dlls```
6) to run use ```PMFTool run```

7) If you need help feel free to start a issue on GitHub.

## Setup a project without using the template
1) Copy the DemoProject
2) In AssemblyInfo.cs change the the values in the buildInfo class
3) In Mod.json change the values to your own
4) Rename DemoMod.cs to your own mods name

5) run ```PMFTool update-dlls```
6) to run use ```PMFTool run```

7) If you need help feel free to start a issue on GitHub.


## Package a mod for Primiter mod manager
* run ```PMFTool pack --format Pmfm``` you can change the format to zip if you want compatibility with raw melonLoader



## Documentation

* [PMFTool](./PMFTool/PMFTool.md)

* [Custom substances and materials](./CustomSubstancesAndMaterials.md)

* [Custom objects like Drones, Slimes, Engines, ...](./CreatingCustomObjects.md)

* [ICubeBehaviors](./ICubeBehaviors.md)

* [Dumping](./Dumping.md)

* [PMFSystems](./PMFSystems.md)

* [Mod.json](./Mod.json.md)