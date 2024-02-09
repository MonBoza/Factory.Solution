# Dr.Sillystringz's Factory

## An Mvc web application to manage a factories engineers, machines and licenses

### By Monica Barboza

## Technologies Used

* C#
* .NET 6
* ASP.NET Core MVC
* Entity Framework Core
* Bootstrap
* MySQL

## Description

## Setup/Installation Requirements

* Clone this repo from

```bash
https://github.com/MonBoza/Factory.Solution
```

* In the production sub directory (named `Factory`) create a file named `appsettings.json` and add the following code to it:

 ```bash
    {
      "ConnectionStrings": {
          "DefaultConnection": "Server=localhost;Port=3306;database=[DATABASE_NAME];uid=[USERNAME];pwd=[PASSWORD];"
      }
    }
   ```

  Make sure to update the string with your own values for [DATABASE-NAME],[USERNAME] and [PASSWORD], without square brackets. You can name the database whatever you like.

* In the terminal run the commands

```bash
dotnet tool install --global dotnet-ef --version 6.0.0
```

followed by:

```bash
dotnet add package Microsoft.EntityFrameworkCore.Design -v 6.0.0
```

 to download the tools dotnet-ef that will create migrations and update your database.

* To create a data migration for the database, initialize with

```bash
dotnet ef migrations add Initial
```

in your terminal. This should create a Migrations folder in the production subdirectory of your project.

* To add subsequent migrations run the command

```bash
dotnet ef migrations add [AddExamplePriority]
```

 You can name the migration whatever you like, however it is common to start with a verb and use upper camel case. Remember to remove the square brackets!

* Run the following command to update the database.

```bash
dotnet ef database update
```

* If you would like to remove a migration from the database, run

```bash
dotnet ef migrations remove
```

* Run the command `dotnet watch run` to compile and run the application in development mode with a watcher. Optionally, you can run `dotnet build` to compile without running the app. 

* Open the browser to https://localhost:5001 to use the application.

## Known Bugs

* _Any known issues_
* _should go here_

## License

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

Email: (mailto:<MonBoza@gmail.com>)

Copyright (c) February 9, 2024 Monica Barboza
