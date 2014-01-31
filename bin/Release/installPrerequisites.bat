@echo off
echo Validating and installing c++ redistributables
Prerequisites\vcredist_x862012.exe /install /passive   
Prerequisites\vcredist_x86_2010.exe /q  

REG QUERY "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\NET Framework Setup\NDP" /s|FIND " Version"|FIND "4.5." >nul||  goto :NetNotInstalled
echo .NET 4.5 is already installed- skipping install

goto :finish

:NetNotInstalled
echo Installing .net 4.5
Prerequisites\dotNetFx45_Full_setup.exe /passive /showfinalerror /promptrestart

:finish
echo 
echo Finished install
pause