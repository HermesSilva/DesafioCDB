dotnet build ResgateCDB.sln
if errorlevel 1 goto error

rem start https://localhost:33002/Swagger/index.html
rem if errorlevel 1 goto error

.\ResgateCDB.Server\bin\Debug\net8.0\ResgateCDB.Server.exe
if errorlevel 1 goto error

goto fim
:error
@echo HOUVE ERRO, OBSERVE E CORRIJA
pause
:fim