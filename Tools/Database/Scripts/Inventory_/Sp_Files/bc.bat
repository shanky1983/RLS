
echo off 
setLocal EnableDelayedExpansion 
for /f "tokens=* delims= " %%a in ('dir *.sql /b/a-d') do (
set name=%%~na 
set xt=%%~xa
set last4=!name:~-4!
echo %%a 

)
 bc.bat >> test.txt 

#pause