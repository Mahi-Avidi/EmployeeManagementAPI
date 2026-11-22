# Employee Management API

## Project Overview
The Employee Management API is a RESTful Web API developed using C# and ASP.NET Core Web API. It allows users to manage employee records through standard CRUD operations.

The project uses Entity Framework Core for database operations and SQL Server for storing employee information.

## Technologies Used
- C#
- ASP.NET Core Web API
- Entity Framework Core
- SQL Server
- Swagger / OpenAPI

## Features
- Create new employee records.
- Retrieve all employees.
- Retrieve employee details.
- Update existing employee information.
- Delete employee records.
- Validate incoming request data.
- Handle API responses using appropriate HTTP status codes.
- Integrate SQL Server using Entity Framework Core.

## API Operations

| HTTP Method | Operation |
|---|---|
| GET | Retrieve employee records |
| POST | Create an employee |
| PUT | Update employee details |
| DELETE | Delete an employee |

## Database
SQL Server is used to store employee information. Entity Framework Core manages database connectivity and data operations.

## How to Run the Project
1. Clone this repository.
2. Open the solution in Visual Studio.
3. Configure your SQL Server connection string using .NET User Secrets.
4. Apply Entity Framework Core migrations if required.
5. Build and run the project.
6. Open the Swagger URL displayed by the application to test the API endpoints.

## Testing
Tested CRUD operations using Swagger:
- GET
- POST
- PUT
- DELETE

## Developer
Mahi-Avidi
