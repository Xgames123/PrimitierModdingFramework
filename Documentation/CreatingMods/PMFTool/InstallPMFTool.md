# Install PMF tool

1) go to the latest release of pmf and download ```XGames105.PMFTool.1.0.0.nupkg ```

2) run ``` dotnet tool install XGames105.PMFTool --global --add-source path/to/the/DIRECTORY/where/XGames105.PMFTool.1.0.0.nupkg/is``` Note: --add-source is the path to the directory where XGames105.PMFTool.1.0.0.nupkg is not XGames105.PMFTool.1.0.0.nupkg itself Note: --global is optional if that is not set PMFTool will only be installed for the current project

3) got to the user directory (C:/User/YourName) and create a file called ```.pmftoolconfig``` and add this 
```ini
; configuration file from pmf tool

; REQUIRED change this to the full path of Primitier.exe
PrimitierPath=

; OPTIONAL relative path to the working directory to pull the files from when packing a mod in debug mode
;DebugBinPath=/bin/Debug
; OPTIONAL relative path to the working directory to pull the files from when packing a mod in release mode
;ReleaseBinPath=/bin/Release
```

4) change PrimitierPath to the full path to the primitier exe



### Get the install directory of Primitier.
* Go to steam and click the gear icon on the Primitier page
![Gear](../../GearIcon.png)

* Click on properties and than on local files and than on browse.