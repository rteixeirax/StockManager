# Stock Manager

**Language:** `C# winForms`

### After download or clone the project:
1) Run `rebuild solution` to install all dependencies.
2) In the **Package Manager Console**, select the **StockManager.Database** as the Default project and run `Update-Database` to create the `StockManagerDB.sqlite` file in `/StockManager` folder.
3) Include the `StockManagerDB.sqlite` into the project.
4) Right click on the `StockManagerDB.sqlite` and go to properties then, change the
**Copy to Output Directory** to `Copy if newer`. With this changes, your DB file will be copied to project `/bin/debug` directory on the run, if it is newer.

From now on, your application will save the data in the `/bin/debug/StockManagerDB.sqlite`. The `StockManagerDB.sqlite` outside the `/bin/debug` will remain with the initial values only.

**Note:** The database will have a default user with the credentials, **username:** `Admin` and **password:** `admin`.

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
