# MasLazu.AspNet.Authorization.Rbac

A comprehensive Role-Based Access Control (RBAC) library for ASP.NET applications, built with .NET 9.0. This solution provides a modular, extensible framework for managing roles, permissions, and user assignments.

## Architecture

The project follows Clean Architecture principles with the following layers:

- **Abstraction**: Defines interfaces and models.
- **Domain**: Contains business entities.
- **Main**: Implements services, validators, and utilities.
- **EfCore**: Provides Entity Framework Core data access.
- **Endpoint**: Offers FastEndpoints-based API endpoints.

## Features

- Full CRUD operations for roles, permissions, and user-role assignments.
- FluentValidation for request validation.
- Entity Framework Core for data persistence.
- FastEndpoints for high-performance APIs.
- Comprehensive test coverage with xUnit.
- Dependency injection ready.

## Getting Started

1. Clone the repository.
2. Restore packages: `dotnet restore`.
3. Build the solution: `dotnet build`.
4. Run tests: `dotnet test`.

## Usage

### In your ASP.NET Application

```csharp
// In Program.cs or Startup.cs
builder.Services.AddAuthorizationRbacApplication();
builder.Services.AddAuthorizationRbacEndpoints();
builder.Services.AddAuthorizationRbacEntityFrameworkCore();

// Configure DbContext
builder.Services.AddDbContext<AuthorizationRbacDbContext>(options =>
    options.UseSqlServer(connectionString));
```

### API Endpoints

- `GET /roles` - List roles
- `POST /roles` - Create role
- `GET /roles/{id}` - Get role by ID
- `PUT /roles/{id}` - Update role
- `DELETE /roles/{id}` - Delete role

Similar endpoints for role-permissions and user-roles.

## Dependencies

- .NET 9.0
- Entity Framework Core 9.0
- FastEndpoints 7.0
- FluentValidation
- xUnit for testing

## Project Structure

```
src/
├── MasLazu.AspNet.Authorization.Rbac.Abstraction/
├── MasLazu.AspNet.Authorization.Rbac.Domain/
├── MasLazu.AspNet.Authorization.Rbac/
├── MasLazu.AspNet.Authorization.Rbac.EfCore/
└── MasLazu.AspNet.Authorization.Rbac.Endpoint/

test/
├── MasLazu.AspNet.Authorization.Rbac.Abstraction.Test/
├── MasLazu.AspNet.Authorization.Rbac.Domain.Test/
├── MasLazu.AspNet.Authorization.Rbac.Test/
├── MasLazu.AspNet.Authorization.Rbac.EfCore.Test/
└── MasLazu.AspNet.Authorization.Rbac.Endpoint.Test/

MasLazu.AspNet.Authorization.Rbac.sln
```

## Contributing

Contributions are welcome. Please ensure tests pass and follow the existing code style.

## License

This project is licensed under the MIT License.
