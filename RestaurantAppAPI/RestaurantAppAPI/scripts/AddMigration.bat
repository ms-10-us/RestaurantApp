@echo OFF
set "scriptname=%~1"

goto :scriptNameCheck
:promptUser
set /p "scriptName=Enter script Name: "
:scriptNameCheck

if "%scriptName%" == "" goto :promptUser

dotnet ef migrations ^
    add "%scriptName%" ^
    --project ..\RestaurantAppAPI ^
    --startup-project ..\RestaurantAppAPI ^
    --output-dir Generated/Migrations ^
    --context RestaurantAppDB