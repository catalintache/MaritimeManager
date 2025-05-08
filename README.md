# MaritimeManager

**MaritimeManager** is a web application for managing maritime data: ships, voyages, ports, and countries.  
It provides a dashboard with voyage statistics by month.  
The project follows **Clean Architecture** principles.

---

## Table of Contents

- [Features](#features)
- [Technology Stack](#technology-stack)
- [Project Structure](#project-structure)
- [Prerequisites](#prerequisites)
- [Setup](#setup)
  - [Database](#database)
  - [Backend](#backend)
  - [Frontend](#frontend)
- [Testing](#testing)
- [CI/CD](#cicd)
- [Contributing](#contributing)
- [License](#license)

---

## Features

- CRUD operations for countries, ports, ships, and voyages  
- RESTful API with Swagger documentation  
- Angular dashboard with bar charts (ngx-charts)  
- Clean Architecture with separation of concerns  
- Unit and integration tests  
- Continuous Integration via GitHub Actions

---

## Technology Stack

### Backend

- ASP.NET Core 8  
- Entity Framework Core (SQL Server)  
- AutoMapper  
- Repository Pattern  
- Swagger (Swashbuckle)

### Frontend

- Angular 17  
- ngx-charts  
- RxJS

### Database

- Microsoft SQL Server (T-SQL)

### Testing

- xUnit, Moq (unit tests)  
- Microsoft.AspNetCore.Mvc.Testing (integration tests)  
- Jasmine & Karma (Angular tests)

### CI/CD

- GitHub Actions

---

## Project Structure

```
360TraineeSolution/
├── database/              # T-SQL scripts
│   └── init.sql           # Create database and tables
├── src/
│   ├── MyApp.Domain/          # Domain entities and interfaces
│   ├── MyApp.Application/     # DTOs and service interfaces
│   ├── MyApp.Infrastructure/  # EF Core DbContext, repositories, mappings
│   ├── MyApp.WebAPI/          # API controllers and startup configuration
│   └── MyApp.Tests/           # Unit and integration tests
└── angular-client/           # Angular application
    ├── src/app/              # Modules, services, components
    └── package.json          # Dependencies and scripts
```

---

## Prerequisites

- .NET SDK 8.0+  
- Node.js 18.x+  
- Angular CLI 17.x+  
- SQL Server  
- Git 2.x+

---

## Setup

### Database

Run the T-SQL script to create the database and tables:

```bash
sqlcmd -i database/init.sql
```

---

### Backend

Navigate to the `src` folder and install EF Core tools:

```bash
cd src
dotnet tool install --global dotnet-ef
```

Add and apply migrations:

```bash
dotnet ef migrations add Init --project MyApp.Infrastructure --startup-project MyApp.WebAPI
dotnet ef database update --project MyApp.Infrastructure --startup-project MyApp.WebAPI
```

Configure the connection string in `src/MyApp.WebAPI/appsettings.json`.

Start the API:

```bash
cd MyApp.WebAPI
dotnet run
```

Access Swagger at: [https://localhost:5001/swagger](https://localhost:5001/swagger)

---

### Frontend

Change directory to the Angular client and install dependencies:

```bash
cd angular-client
npm ci
```

Update API base URL in `src/environments/environment.ts` if needed.

Launch the development server:

```bash
npm start
```

Open the app at: [http://localhost:4200](http://localhost:4200)

---

## Testing

### Backend unit tests:

```bash
cd src/MyApp.Tests
dotnet test
```

### Frontend unit tests:

```bash
cd angular-client
npm test
```

---

## CI/CD

The GitHub Actions workflow (`.github/workflows/ci.yml`) runs on every push or pull request and includes:

- **build-backend**: restore, build, and test .NET projects  
- **build-frontend**: install dependencies and build Angular application

---

## Contributing

1. Fork the repository  
2. Create a branch:  
   ```bash
   git checkout -b feature/your-feature
   ```
3. Commit your changes:  
   ```bash
   git commit -m "feat: description of your changes"
   ```
4. Push to the branch:  
   ```bash
   git push origin feature/your-feature
   ```
5. Open a pull request against `main`

---

## License

This project is licensed under the **MIT License**. See the [LICENSE](LICENSE) file for details.
