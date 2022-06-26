# Creating mods
Note: A helpful resource for making mods is [MelonLoaderDocs](https://melonwiki.xyz/#/)

**Note: if any of this documentation is wrong or contains spelling errors please create an issue or let me know on discord**


## Try building the Demo mod
1) Clone the repo.

2) Install [Primitier mod manager](https://github.com/Xgames123/PrimitierModManager/releases). or [MelonLoader](https://github.com/LavaGang/MelonLoader). For melonLoader you can use a automated install.

3) Install [PMFTool](./PMFTool/InstallPMFTool.md)

4) Try building the demoMod project.

5) Try running the demoMod by running ```PMFTool run```
    - If it doesn't work run ```PMFTool update-dlls```
    - If that doesn't work run primitier so that melonloader can generate the dlls and run ```PMFTool update-dlls``` again

6) If you need help feel free to start a issue on GitHub or ask on Discord


## Setup a project Using the template
1) install the project template by running ```dotnet new --install XGames105.PMF.Templates```

2) install PMFTool by running ```dotnet tool install XGames105.PMF.PMFTool --global```

2) Create a new project in your ide and select the 'Empty PMF mod' project template
3) build your project
4) open cmd or powershell in the directory of .csproj file and run ```PMFTool run```

5) If you need help feel free to start a issue on GitHub. or ask on discord

## Setup a project without using the template
1) clone the repo
2) copy PMFTemplates/templates/TemplateMod to a new location
3) edit TemplateMod.csproj
4) build
5) open cmd or powershell in the directory of TemplateMod.csproj and run ```PMFTool run```

6) If you need help feel free to start a issue on GitHub. or ask on discord


## Package a mod for Primiter mod manager
1) open cmd or powershell in the directory of the .csproj file
2) run ```PMFTool pack --format Pmfm``` you can change the format to zip if you want compatibility with raw melonLoader


## Table of content

* [PMFTool](./PMFTool/PMFTool.md)

* [MSBuild package](./PMF.Msbuild.md)

* [Custom substances and materials](./CustomSubstancesAndMaterials.md)

* [Custom objects like Drones, Slimes, Engines, ...](./CreatingCustomObjects.md)

* [ICubeBehaviors](./ICubeBehaviors.md)

* [Dumping](./Dumping.md)

* [PMFSystems](./PMFSystems.md)

* [Mod.json](./Mod.json.md)