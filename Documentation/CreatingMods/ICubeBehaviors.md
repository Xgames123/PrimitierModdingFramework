# Creating Custom ICubeBehaviors
1) Create a class that inherits from MonoBehavior and ICustomCubeBehaviour

2) Add a constructor that takes in an IntPtr and passes it to the base constructor 
    ```cs
    public MyCustomCubeBehavior(System.IntPtr ptr) : base(ptr)
    {

    }
    ```



3) Add this to OnApplicationStart if you haven't already (make sure you add this after ```PMFSystem.EnableSystem<PMFHelper>();```)
    ```cs
    PMFHelper.AutoInject(System.Reflection.Assembly.GetExecutingAssembly());
    ```

4) (Optional) You can attach method too events from CubeBase
In older versions the OnFragmentInitialized and OnCollideWithCube were part of ICustomCubeBehaviour but now they have to be created manually

5) Use the custom cube behaviour on a substance
    ```cs
    CustomSubstanceSystem.LoadCustomSubstance(customSubstance, new CustomSubstanceSettings()
    {
        AddCustomCubeBehaviour = (CubeBase cubeBase) =>
        {
            return cubeBase.gameObject.AddComponent<Decay>();
        }
    });
    ```

## List of CubeBase events
To use this events you have to do a GetComponent\<CubeBase>(); in your start method like this
```cs
private void Start()
{
    var cubeBase = GetComponent<CubeBase>();
    cubeBase.CollideEvent.AddListener((System.Action<CubeBase, bool>)OnCollideWithCube);
}

private void OnCollideWithCube(CubeBase colCubeBase, bool isEnoughDamage)
{

}
```
### CubeBase.CollideEvent
Method looks like this
```cs
private void OnCollideWithCube(CubeBase colCubeBase, bool isEnoughDamage)
{

}
```
### CubeBase.DamageEvent
Method looks like this
```cs
private void OnReceiveDamage(float amount, Vector3 colPoint)
{

}
```

### CubeBase.FragmentInitializeEvent
Method looks like this
```cs
private void OnFragmentInitialized(CubeBase fragmentCubeBase)
{
   
}
```

### CubeBase.SplitEvent
Method looks like this

This one has no params so the cast to System.Action doesn't need the <>
```cs
private void OnSplit()
{

}
```