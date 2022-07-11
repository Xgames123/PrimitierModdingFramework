# Creating mods
Note: A helpful resource for making mods is [MelonLoaderDocs](https://melonwiki.xyz/#/)

**Note: if any of this documentation is wrong or contains spelling errors please create an issue or let me know on discord**


## Setup a project Using the template
Here is a [getting started video](https://youtu.be/U6nOnpO1fb4)

1) [install PMFTool](./PMFTool/InstallPMFTool.md)

2) install the project template by running ```dotnet new --install XGames105.PMF.Templates```

3) Create a new project in your ide and select the 'Empty PMF mod' project template
4) build your project
5) open cmd or powershell in the directory of .csproj file and run ```PMFTool run```

6) If you need help feel free to start a issue on GitHub. or ask on discord

## Setup a project without using the template
1) clone the repo
2) copy PMFTemplates/templates/TemplateMod to a new location
3) edit TemplateMod.csproj
4) build (if you get build errors try building again)
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

* [ICustomSavable](./ICustomSavable.md)

* [Dumping](./Dumping.md)

* [PMFSystems](./PMFSystems.md)

* [Mod.json](./Mod.json.md)
