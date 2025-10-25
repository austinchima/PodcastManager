# SQL Server Configuration Guide

## Prerequisites
- SQL Server installed locally
- SQL Server Management Studio (SSMS) or Azure Data Studio
- Administrative access to your local SQL Server instance

## Completed Project Setup
- Project is configured for .NET 8
- Database context is established in the Razor Pages project

## Individual Setup Tasks

### 1. Local Database Setup
1. Open SQL Server Management Studio (SSMS)
2. Connect to your local SQL Server instance
3. Create a new database named `PodcastManagerDB`
1. 
### 2. Configure Connection String
1. Open your `appsettings.json`
2. Add your personal connection string: { "ConnectionStrings": { "DefaultConnection": "Server=.;Database=PodcastManagerDB;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True" } }
Note: Adjust the Server name if your local instance uses a different name.

### 3. Apply Database Migrations
1. Open Package Manager Console in Visual Studio
2. Run the following commands: 
   ```
   Add-Migration InitialCreate
   Update-Database
   ```

### 4. Verify Setup
1. Check that the database was created in SSMS
2. Verify all tables are properly created
3. Test the application's database connection

## Troubleshooting
- If you encounter connection errors, verify your SQL Server service is running
- Ensure you have Windows Authentication enabled
- Check that your SQL Server instance name matches your connection string

## Need Help?
If you encounter any issues during setup, please reach out to me.
