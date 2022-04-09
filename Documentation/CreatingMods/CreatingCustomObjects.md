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

2) Add a ICubeBehavior to the object.
    ### Creating a custom ICubeBehavior
    1) Create a class that inherits from MonoBehavior
    
    2) Add a constructor that takes in an IntPtr and passes it to the base constructor 
        ```cs
        public MyCustomCubeBehavior(System.IntPtr ptr) : base(ptr)
        {

        }
        ```
    3) add these methods to your class
        ```cs
        public void OnFragmentInitialized(CubeBase fragmentCubeBase)
        {
            
        }
        public void OnCollideWithCube(CubeBase colCubeBase) 
        {
            
        }
        ```
    4) Add this to OnApplicationStart 
        ```cs
        ClassInjector.RegisterTypeInIl2CppWithInterfaces<MyCustomCubeBehavior>(typeof(ICubeBehavior));
        ```

3) Than attach the objects together using there CubeConnectors.
    ```cs
    stem.GetComponent<CubeConnector>().anchor = CubeConnector.Anchor.Temporary;
    stem.GetComponent<CubeConnector>().Connect(leaf.GetComponent<CubeConnector>());

    ```
**TODO: explain what anchor does**

