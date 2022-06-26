# PMF.MsBuild
This package integrates pmf with msbuild

## Using PMF.Msbuild
1) Delete the Properties folder
1) Open your ProjectName.csproj file in a text editor
2) Delete everything in that file
3) add this
```xml
<?xml version="1.0" encoding="utf-8"?>
<Project Sdk="Microsoft.NET.Sdk">

	<PropertyGroup>
		<TargetFramework>net472</TargetFramework>
        <AssemblyName>TemplateMod</AssemblyName>

        <!--Change this to the namespace of your Mod class-->
		<RootNamespace>TemplateMod</RootNamespace>

		
		<Title>Template Mod</Title>
		<Version>1.0.0</Version>
		<Authors></Authors>
		<Description></Description>
		
		<!--Use this to set the namespace.classname of your entry point class (Mod.cs)-->
		<!--<EntryPointClass></EntryPointClass>-->
	</PropertyGroup>

	<ItemGroup>
	  <PackageReference Include="XGames105.PMF" Version="0.4.1" />
	  <PackageReference Include="XGames105.PMF.Msbuild" Version="0.4.1" />
	</ItemGroup>

	
</Project>
```


## Custom properties
This are the custom properties added by PMF.Msbuild you can use them like this
```xml
<PropertyGroup>
    <PropertyName>value</PropertyName>
</PropertyGroup>
```

(Make sure you define these before the PackageReference)

### ProxyDllsFolder
Path of the dlls folder.
Make sure you also change this in .pmftoolconfig

default: '../Dlls'

### EntryPointClass
Namespace.ClassName of your entry point class (The one that inherits from PrimitierMod)

default: RootNamespace.Mod

### UsePMFTool
If set to true use pmftool to update the dlls before building the project

default: true

### AutoGenerateModJson
If set to true auto generate the [Mod.json](./Mod.json.md) file by using the properties Title, Version, Authors, Description

default: true

### AddMelonAttributes
If true add the melonloader attributes to the assembly. It uses EntryPointClass for the entry point

default: true