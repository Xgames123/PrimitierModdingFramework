$PRIMITIER_PATH = "D:\Program Files (x86)\Steam\steamapps\common\Primitier"

$ModBinPath = "bin/Debug"

Copy-Item -Path "$($ModBinPath)\*" -Destination $PRIMITIER_PATH -Recurse

Start-Process "$($PRIMITIER_PATH)\Primitier.exe" -ArgumentList "--melonloader.debug"