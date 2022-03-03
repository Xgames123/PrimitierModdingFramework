$DEBUG_BIN_PATH = 'PrimitierModdingFramework\PrimitierModdingFramework\bin\Debug';
$MOD_DEBUG_BIN_PATH = 'PrimitierModdingFramework\DemoMod\bin\Debug\';
$PRIMITIER_PATH = 'E:\Games\Steam\steamapps\common\Primitier';
$ModsFolder =  $PRIMITIER_PATH+"\Mods"

Write-Output 'Clearing old dll,xml,pdb files from mod debug dir';
Remove-Item ($MOD_DEBUG_BIN_PATH+"\PrimitierModdingFrameworkV0.2.dll") -Force;
Remove-Item ($MOD_DEBUG_BIN_PATH+"\PrimitierModdingFrameworkV0.2.xml") -Force;
Remove-Item ($MOD_DEBUG_BIN_PATH+"\PrimitierModdingFrameworkV0.2.pdb") -Force;

Write-Output 'Transferring new dll,xml,pdb generated files to mods';
Copy-Item -Path ($DEBUG_BIN_PATH+"\PrimitierModdingFrameworkV0.2.dll") -Destination $MOD_DEBUG_BIN_PATH;
Copy-Item -Path ($DEBUG_BIN_PATH+"\PrimitierModdingFrameworkV0.2.xml") -Destination $MOD_DEBUG_BIN_PATH;
Copy-Item -Path ($DEBUG_BIN_PATH+"\PrimitierModdingFrameworkV0.2.pdb") -Destination $MOD_DEBUG_BIN_PATH;

Write-Output 'Clearing old dll,xml,pdb files from steamapp mod dir';
Remove-Item ($ModsFolder+"\PrimitierModdingFrameworkV0.2.dll") -Force;
Remove-Item ($ModsFolder+"\PrimitierModdingFrameworkV0.2.xml") -Force;
Remove-Item ($ModsFolder+"\PrimitierModdingFrameworkV0.2.pdb") -Force;

Write-Output 'Transferring new dll,xml,pdb generated files to steamapp mod dir';
Copy-Item -Path ($DEBUG_BIN_PATH+"\PrimitierModdingFrameworkV0.2.dll") -Destination $ModsFolder;
Copy-Item -Path ($DEBUG_BIN_PATH+"\PrimitierModdingFrameworkV0.2.xml") -Destination $ModsFolder;
Copy-Item -Path ($DEBUG_BIN_PATH+"\PrimitierModdingFrameworkV0.2.pdb") -Destination $ModsFolder;

Write-Output '=== Finished Moving Files ===';
#Write-Output 'Starting Primitier';
#Start-Process ($PRIMITIER_PATH+"\Primitier.exe") -ArgumentList '--melonloader.debug';

Write-Output 'Starting Primitier';
Start-Process ($PRIMITIER_PATH+"\Primitier.exe") -ArgumentList '--melonloader.debug';

Write-Output '=== Finished ===';