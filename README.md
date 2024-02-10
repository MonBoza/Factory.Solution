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

Welcome to Dr.Sillystringz's Factory Management System - a cutting-edge MVC web application designed to elevate the management of engineers, machines, and licenses within your factory. This tool empowers users with the ability to effortlessly add, update, and delete engineers, while also providing the capability to specify the machines each engineer is licensed to repair. The same powerful functionality extends to machine management, creating a seamless and efficient process for overseeing factory operations.

## Setup/Installation Requirements

This Project assumes you have MySql Server and Workbench  installed if you do not have them installed follow along with these lessons at
[Learn how to program](https://full-time.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql).

1. Open terminal or command prompt.
2. Clone the repository by running the following command to your desktop:

    ```bash
    git clone https://github.com/MonBoza/Factory.Solution.git
     ```

3. Open the project in your favorite code editor.

4. Within the production directory `Factory`, create new file called `appsettings.json`

5. Make sure appsettings.json is added to the .gitignore file and it is added to the repository before pushing with your personal information.

6. Within `appsettings.json`, put in the following code replacing the `uid` and the `pwd` values with your own username and password for MySQL.

    ```bash
    {
      "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=monica_barboza;uid=[YOUR-USER-HERE];pwd=[YOUR-PASSWORD-HERE];"
      }
    }
    ```

7. To download the tools dotnet-ef that will create migrations and update your database run the following commands in your terminal.

    ```bash
    dotnet tool install --global dotnet-ef --version 6.0.0
    ```

    followed by:

    ```bash
    dotnet add package Microsoft.EntityFrameworkCore.Design -v 6.0.0
    ```

8. To create a data migration for the database, initialize with

  ```bash
  dotnet ef migrations add Initial
  ```

in your terminal. This should create a Migrations folder in the production subdirectory of your project.

9. To add subsequent migrations run the command

  ```bash
  dotnet ef migrations add AddExamplePriority
  ```

 You can name the migration whatever you like, however it is common to start with a verb and use upper camel case.

10. Run the following command to update the database.

  ```bash
  dotnet ef database update
  ```

11. If you would like to remove a migration from the database, run

  ```bash
  dotnet ef migrations remove
  ```

12. Run the command `dotnet watch run` to compile and run the application in development mode with a watcher. Optionally, you can run `dotnet build` to compile without running the app.

13. Open the browser to https://localhost:5001 to use the application.

## Known Bugs

* No known bugs
  * If you come across any bug contact the author

## License

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

Email: (mailto:<MonBoza@gmail.com>)

Copyright (c) February 9, 2024 Monica Barboza
