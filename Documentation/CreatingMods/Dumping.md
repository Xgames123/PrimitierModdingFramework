# Dumping the state of the game
PMF has some tools to dump the state of the game. located in the namespace PrimitierModdingFramework.Debugging
In the repo is a folder called Dumps that has some demo dumps
**WARNING: ValueTypes (float's, bool's, int's) are broken in dumps.**

## HierarchyXmlDumper
HierarchyXmlDumper is a class for dumping the hierarchy of the game.
To dump the scene call HierarchyXmlDumper.DumpSceneToFile()


### A ComponentDumper
A ComponentDumper is used to change the generated xml tag of the TargetComponent.

### HierarchyXmlDumper.DefaultDumperList
PMF Includes a default ComponentDumpersList for basic classes like Transform, MeshFilter, MeshRenderer, ...

## ResourceXmlDumper
ResourceXmlDumper is a class used for dumping the resources used by Primitier. Call ResourceXmlDumper.DumpAll() to dump the materials, substances and other resources