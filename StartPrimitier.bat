@echo off
start "Primitier" "D:\Program Files (x86)\Steam\steamapps\common\Primitier\Primitier.exe"
timeout /t 2 /nobreak >nul
for /F "tokens=2" %%K in ('
   tasklist /FI "WINDOWTITLE eq Primitier" /FO LIST ^| findstr /B "PID:"
') do (
	echo %%K
	RemoteDLLInjector\RemoteDLLInjector64.exe %%K "x64\Debug\PrimitierModdingFramework.dll"
)

