## Steps to publish a new release so I don't forget
1) merge main into dev
2) Check version number in PMF.Shared.targets
3) Check PackageReference version numbers in all projects 
4) Check PackageReference version numbers in template project

4) build all nuget packages
5) merge dev into main
6) upload nuget packages to nuget
7) publish github release