$DEBUG_BIN_PATH = 'PrimitierModdingFramework\PrimitierModdingFramework\bin\Debug';
$MOD_DEBUG_BIN_PATH = 'PrimitierModdingFramework\DemoMod\bin\Debug\';
$PRIMITIER_PATH = 'E:\Games\Steam\steamapps\common\Primitier';
$MOD_FOLDER =  $PRIMITIER_PATH+"\Mods"
$BUILD_PATH = "\PrimitierModdingFrameworkV0.3.dll";

Write-Output '=== Starting ===';

Write-Output 'Clearing old dll,xml,pdb files from mod debug dir';
Remove-Item ($MOD_DEBUG_BIN_PATH+$BUILD_PATH) -Force;

Write-Output 'Transferring new dll,xml,pdb generated files to mods';
Copy-Item -Path ($DEBUG_BIN_PATH+$BUILD_PATH) -Destination $MOD_DEBUG_BIN_PATH;

Write-Output '=== Finished ===';