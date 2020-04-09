# Stock Manager

**Language:** `C# winForms`

### After download or clone the project:
1) Run `rebuild solution` to install all dependencies.
2) In the **Package Manager Console**, select the **StockManager.Storage** as the Default project and run `Update-Database` to create the `App.db.sqlite` file in `/StockManager` folder.

👉 *The database will have a default user with the credentials, **username:** `Admin` and **password:** `admin`.*

**Notes:**

If the file `App.db.sqlite` isn't in the project **StockManager**

*  Include it into the project.
*  Right click on it and go to properties.
*  Change the **Copy to Output Directory** to `Copy if newer`. With this changes, your DB file will be copied to project `/bin/debug` directory on the run, if it is newer.
*  Change the code that has been added to the file **StockManager.csproj** to be the following:

    ````
    <None Include="App.db.sqlite" Condition="Exists('.\App.db.sqlite')">
      <CopyToOutputDirectory>PreserveNewest</CopyToOutputDirectory>
    </None>
    ````

👉 *From now on, your application will save the data in the `/bin/debug/App.db.sqlite`. The `App.db.sqlite` outside the `/bin/debug` will remain with the initial values only.*

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
