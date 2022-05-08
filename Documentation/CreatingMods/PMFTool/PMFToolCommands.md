# Commands


## ``` PMFTool run ```
This command is used to run a mod to test it.

It copies the mod files from the (Debug/Release can be specified by --mode) to the mods directory of primitier and starts primitier


If --novr is specified it creates a flycam that you can control using your keyboard and mouse


## ``` PMFTool pack ```
Generates a mod package that can be shared and installed by other people.

you can change the format using --format

### Available formats
* zip: for a mod that can work on raw MelonLoader but is really large
* pmfm: for a mod that can be installed using PrimitierModManager and is really small

## ```PMFTool update-dlls```
Copies the latest proxy dlls to the folder specified by path or .pmftoolconfig.
Used to update mods made for older versions of primitier