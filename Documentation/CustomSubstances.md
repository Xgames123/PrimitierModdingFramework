# Custom substances
NOTE: Custom substances will be more flexible in the future.

## Creating a custom substance
* Before you can start creating custom substances you have to call ``` PMFSystem.EnableSystem<CustomSubstanceSystem>(); ``` This will enable the CustomSubstanceSystem. [See PMFSystems](./PMFSystems.md)
* Next call ```CustomSubstanceSystem.CreateCustomSubstance()``` and pass in the base substance to start from.
* Modify the values of the substance. NOTE: don't forget to change displayNameKey to a custom name.
 

## Spawning a custom substance
Call ```CustomSubstanceSystem.GetSubstanceByName("YOUR_SUBSTANCE")``` to get the Substance enum for your custom substance. you can pass it into ```CubeGenerator.GenerateCube``` to generate the substance


## Substance values descriptions
SubstanceParameters.Param has a couple of misleading names.
* stiffness: this is the damage the object does to another object.
* strength: this is the health of the object.
