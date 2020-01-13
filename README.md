# Stock Manager

**Language:** `C# winForms`

### After download or clone the project:
* Run `rebuild solution` to install all dependencies.

  **Note:** The database is created on the first run into the `/bin/debug/` directory with the name `StockManagerDB.sqlite`. The default user with the credentials, **username:** `Admin` and **password:** `admin` is created with the database.

## Helpful commands to run in the Package Manager Console
* **Create a migration:** <br/>
  `Add-Migration MIGRATION_NAME`

* **Update the DB with the last changes:** <br/>
  `Update-Database`

* **Undo the last migration:** <br/>
  `Remove-Migration`

## Nuget packages
* [Microsoft.EntityFrameworkCore.Sqlite](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Sqlite)
* [Microsoft.EntityFrameworkCore.Tool](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Tools)
* [BCrypt.Net-Core](https://www.nuget.org/packages/BCrypt.Net-Core)
