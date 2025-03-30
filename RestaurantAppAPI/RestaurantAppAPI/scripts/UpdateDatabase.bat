@echo OFF

dotnet ef database update ^
    --connection "Data Source=MAZENSABER;Initial Catalog=RestaurantAppDB;Integrated Security=True; TrustServerCertificate=True" 
    