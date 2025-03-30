@echo OFF

dotnet ef dbcontext scaffold "Data Source=MAZENSABER;Initial Catalog=RestaurantAppDB;Integrated Security=True; TrustServerCertificate=True" ^
    Microsoft.EntityFrameworkCore.SqlServer ^
        --force ^
        --output-dir Generated ^
        --context RestaurantAppDB