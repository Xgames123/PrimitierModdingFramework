## Steps to publish a new release (so I don't forget)
1) merge main into dev
2) Check version number in PMF.Shared.targets
3) Check PackageReference version numbers in PrimitierModdingFramework and DemoMod
4) Check PackageReference version numbers in template project

5) build all nuget packages
6) merge dev into main
7) upload nuget packages to nuget
8) publish github release