# Custom substances and materials


## Creating a custom material
* call ```CustomSubstanceSystem.CreateCustomMaterial("Leaf");``` and pass in the name of the material to start from
* Modify the values of the material. NOTE: don't forget to change name to a custom name.

* To load the material in the game call ```CustomSubstanceSystem.LoadCustomMaterial(yourCustomMat);```



## Creating a custom substance
1) Before you can start creating custom substances you have to call ``` PMFSystem.EnableSystem<CustomSubstanceSystem>(); ``` This will enable the CustomSubstanceSystem. [See PMFSystems](./PMFSystems.md)

2) Next call ```CustomSubstanceSystem.CreateCustomSubstance()``` and pass in the base substance to start from.

3) Modify the values of the substance. NOTE: don't forget to change displayNameKey to a custom name.

    To change the material of your custom substance change the material property to the name of your custom material

4) To load your custom substance in the game call ```CustomSubstanceSystem.LoadCustomSubstance(yourCustomSubstance);```

## CustomSubstanceSettings
This are extra settings for your custom substances
* OnSubstanceInitialize If you set this lambda you can do stuff when the substance initializes like adding components or [ICubeBehaviors](./ICubeBehaviors.md)
* EnName is the name of the substance in English
* JpName is the name of the substance in Japanese

## Spawning a custom substance
Call ```CustomSubstanceSystem.GetSubstanceByName("YOUR_SUBSTANCE")``` to get the Substance enum for your custom substance. you can pass it into ```CubeGenerator.GenerateCube``` to generate the substance


## Substance values descriptions
**If any of this is wrong please create an issue**

SubstanceParameters.Param has a couple of misleading names.
* stiffness: this is the damage the object does to another object. (Maybe this is wrong I haven't tested it allot)
* strength: this is the health of the object.
* density: Mass through =m/v relationship (This value goes from 0 to 1)


## Custom substance builders
Custom substance builders are not required to create custom substances but it can help to organize your substances into differed classes
1) Create a class that inherits form CustomSubstanceBuilder
2) override OnBuild and add the code to create the custom substance
```cs
    public class DecayThingBuilder : CustomSubstanceBuilder
    {
        public override void OnBuild()
        {
            //Code to create the custom substance
        }
    }
```
3) add ``` PMFHelper.AutoInject(System.Reflection.Assembly.GetExecutingAssembly()); ``` to OnApplicationStart
```cs
public override void OnApplicationStart()
{
    base.OnApplicationStart();
    PMFSystem.EnableSystem<PMFHelper>();

    PMFHelper.AutoInject(System.Reflection.Assembly.GetExecutingAssembly());
    
}
```
