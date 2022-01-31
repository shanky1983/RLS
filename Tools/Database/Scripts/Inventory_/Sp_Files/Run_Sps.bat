@echo off
setlocal
 
Set /P _SName=Please enter Server Name:
Set /P _UName=Please enter User Name:
Set /P _Pwd=Please enter Password:
Set /P _Db=Please enter DataBase Name:
del output.txt
SET SQLCMD=sqlcmd -S  %_SName%  -d %_Db% -U %_UName% -P %_Pwd%
for %%d in (*.sql) do %SQLCMD% -i%%d   >>output.txt
endlocal
