# MasLazu.AspNet.Authorization.Rbac.Abstraction

This project contains the abstraction layer for Role-Based Access Control (RBAC) in ASP.NET applications. It defines the core interfaces, models, and contracts that other layers (such as Domain, Services, and Endpoints) implement or depend on.

## Overview

The abstraction layer provides:

- **Interfaces**: Define the contracts for services like `IRoleService`, `IRolePermissionService`, and `IUserRoleService`.
- **Models**: Data transfer objects (DTOs) and request/response models for roles, permissions, and user-role assignments.

This ensures loose coupling and allows for different implementations (e.g., in-memory, database-backed) while maintaining a consistent API.

## Key Components

### Interfaces

- `IRoleService`: Manages roles (CRUD operations).
- `IRolePermissionService`: Manages role-permission associations.
- `IUserRoleService`: Manages user-role assignments.

### Models

- `RoleDto`: Represents a role with properties like Id, Name, Description.
- `RolePermissionDto`: Represents a role-permission link.
- `UserRoleDto`: Represents a user-role assignment.
- Request models: `CreateRoleRequest`, `UpdateRoleRequest`, etc., for API operations.

## Usage

Reference this project in your implementation layers to ensure compliance with the defined contracts. For example, your service layer should implement the interfaces here, and your endpoints should use the models for data transfer.

## Dependencies

- .NET 9.0
- MasLazu.AspNet.Framework (for base interfaces and models)

## Building and Testing

Run `dotnet build` to compile the project. Tests are available in the corresponding test project.
