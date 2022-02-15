# ObjectCollectedException
An object may be collected even if it's referenced from managed domain. Attempting to use that object afterwards will result in ObjectCollectedException.

## How to fix?
To fix ObjectCollectedException you need to reference the object from the IL2CPP side.
You can do this by creating a static Il2CppReferenceArray or Il2CppStructArray of size 1

Example:
```cs
  private static Il2CppReferenceArray<Texture2D> s_garbageCollectionBlock = new Il2CppReferenceArray<Texture2D>(1);


    public override void OnSceneWasLoaded(int buildIndex, string sceneName)
    {
        s_garbageCollectionBlock[0] = new Texture2D(100, 100)

        var texture = s_garbageCollectionBlock[0]

        mat.mainTexture = texture; //The texture is reference in s_garbageCollectionBlock in il2cpp
    }


```
Wrong:
```cs

    public override void OnSceneWasLoaded(int buildIndex, string sceneName)
    {
       var texture = new Texture2D(100, 100)

        mat.mainTexture = texture; //This will throw ObjectCollectedException
    }


```