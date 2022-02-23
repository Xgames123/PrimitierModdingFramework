$DEBUG_BIN_PATH = 'PrimitierModdingFramework\PrimitierModdingFramework\bin\Debug';
$MOD_DEBUG_BIN_PATH = 'PrimitierModdingFramework\DemoMod\bin\Debug\';


Write-Output 'Clearing old dll,xml,pdb files from mod debug dir';
Remove-Item ($MOD_DEBUG_BIN_PATH+"\PrimitierModdingFrameworkV0.2.dll") -Force;
Remove-Item ($MOD_DEBUG_BIN_PATH+"\PrimitierModdingFrameworkV0.2.xml") -Force;
Remove-Item ($MOD_DEBUG_BIN_PATH+"\PrimitierModdingFrameworkV0.2.pdb") -Force;

Write-Output 'Transferring new dll,xml,pdb generated files';
Copy-Item -Path ($DEBUG_BIN_PATH+"\PrimitierModdingFrameworkV0.2.dll") -Destination $MOD_DEBUG_BIN_PATH;
Copy-Item -Path ($DEBUG_BIN_PATH+"\PrimitierModdingFrameworkV0.2.xml") -Destination $MOD_DEBUG_BIN_PATH;
Copy-Item -Path ($DEBUG_BIN_PATH+"\PrimitierModdingFrameworkV0.2.pdb") -Destination $MOD_DEBUG_BIN_PATH;

#Write-Output 'Starting Primitier';
#Start-Process ($PRIMITIER_PATH+"\Primitier.exe") -ArgumentList '--melonloader.debug';



Write-Output '=== Finished ===';