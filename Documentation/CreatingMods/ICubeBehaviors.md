# Creating Custom ICubeBehaviors
1) Create a class that inherits from MonoBehavior and ICustomCubeBehaviour

2) Add a constructor that takes in an IntPtr and passes it to the base constructor 
    ```cs
    public MyCustomCubeBehavior(System.IntPtr ptr) : base(ptr)
    {

    }
    ```
3) Add these methods to your class
    ```cs
    public void OnFragmentInitialized(CubeBase fragmentCubeBase)
    {
        
    }
    public void OnCollideWithCube(CubeBase colCubeBase) 
    {
        
    }
    ```

4) At the end the class should look like this
```cs
    public class MyCustomCubeBehavior : MonoBehaviour, ICustomCubeBehaviour
    {
        public MyCustomCubeBehavior(System.IntPtr ptr) : base(ptr){}

        public void OnFragmentInitialized(CubeBase fragmentCubeBase)
        {
            
        }
        public void OnCollideWithCube(CubeBase colCubeBase) 
        {
            
        }
    }
  
```

5) Add this to OnApplicationStart if you haven't already (make sure you add this after ```PMFSystem.EnableSystem<PMFHelper>();```)
    ```cs
    PMFHelper.AutoInject(System.Reflection.Assembly.GetExecutingAssembly());
    ```
