# Creating custom objects
With custom objects I mean Drones, Slimes, Engines, ...

1) First start by creating the cubes you need like this.
```cs
const float treeThicness = 0.4f;
const float stemHeight = 2f;
const float leafSize = 1f;
const float leafHeight = 2f;

var stem = CubeGenerator.GenerateCube(new Vector3(pos.x, pos.y+(stemHeight/2), pos.z), new Vector3(treeThicness, stemHeight, treeThicness), Substance.Wood);
var leaf = CubeGenerator.GenerateCube(pos+new Vector3(0, stemHeight + leafHeight/2, 0), new Vector3(leafSize, leafHeight, leafSize), CustomSubstanceSystem.GetSubstanceByName("SUB_CUSTOM"));
```

2) Add a ICubeBehavior to the object [or create a custom one](./ICubeBehaviors.md). like this 
```cs
    leaf.AddComponent<CubeBehaviorOrComponent>();
```
   

3) Than attach the objects together using there CubeConnectors.
    ```cs
    stem.GetComponent<CubeConnector>().anchor = CubeConnector.Anchor.Temporary;
    stem.GetComponent<CubeConnector>().Connect(leaf.GetComponent<CubeConnector>());

    ```
    Anchor describes how the objects get connected.
    ### Anchor types

    * Free (Player can disconnect the connected objects by pressing trigger and it not attached to the ground)
    * Temporary (Player can disconnect the connected objects by pressing trigger and is attached to the ground)
    * Permanent (Player can not disconnect the connected objects by pressing trigger and is attached to the ground)