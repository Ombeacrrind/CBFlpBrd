@echo off

SET source="C:\Users\Shwam\Documents\Visual Studio 2010\Projects\FlappyBird"
SET destination="C:\Users\Shwam\Documents\GitHub\CBFlpBrd"

REM xcopy %source%\FlappyBird.sln %destination%\FlappyBird.sln /Y
REM xcopy %source%\version.txt %destination%\version.txt /Y

xcopy %source% %destination% /K /S /E /Y /R /I /D /EXCLUDE:gitignore

pause