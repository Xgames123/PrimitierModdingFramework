# Install PMF tool with primitier mod manager
This is the easiest option

1) Install [primitier mod manager](https://github.com/Xgames123/PrimitierModManager)

2) run ``` dotnet tool install XGames105.PMF.PMFTool --global```

3) done


# Install PMF tool with raw melonloader

1) Install latest version of MelonLoader on Primitier. (You can use automated install)

2) Get the install directory of Primitier.
    1) Go to steam and click the gear icon on the Primitier page
    ![Gear](../../GearIcon.png)

    2) Click on properties and than on local files and than on browse.

    3) copy that path to your clipboard for later

3) go to the user directory (C:/User/YourName) and create a file called ```.pmftoolconfig``` and add this 
```ini
; configuration file from pmf tool

; REQUIRED change this to the full path of Primitier.exe
PrimitierPath=

```
4) past the path you copied after PrimitierPath= and add Primitier.exe at the end



