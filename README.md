# .net Core Console App with Poastgres

This is a short tutorial project that instructs you how to use the code first approach in ef core

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes. See deployment for notes on how to deploy the project on a live system.

### Prerequisites

What things you need to install the software and how to install them

```
Install visual studio 2019 and postgres

```
```
Create a database in postgres and update the connection string in the 
context with you username and password and database name

```
```
Build the project
```
```
Once your database is connected run the following commands within your project folder

* dotnet ef migrations add tutorial
* dotnet ef database update

```

## Testing your code

You will see that the code is added to the program.cs file which will allow you to run different instructions to the database

## Authors

* **Jed Fletcher**
