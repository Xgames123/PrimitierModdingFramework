# Creating Custom ICubeBehaviors
1) Create a class that inherits from MonoBehavior

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
    public class MyCustomCubeBehavior : MonoBehavior
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

5) Add this to OnApplicationStart 
    ```cs
    ClassInjector.RegisterTypeInIl2CppWithInterfaces<MyCustomCubeBehavior>(typeof(ICubeBehavior));
    ```