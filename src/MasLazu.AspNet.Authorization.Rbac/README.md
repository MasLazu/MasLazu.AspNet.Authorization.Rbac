# MasLazu.AspNet.Authorization.Rbac

This is the main project for Role-Based Access Control (RBAC) in ASP.NET applications. It provides the core services, extensions, utilities, and validators to implement RBAC functionality.

## Overview

The main layer orchestrates the RBAC system by:

- **Services**: Implements the business logic for roles, permissions, and user assignments.
- **Extensions**: Provides dependency injection setup for services, utilities, and validators.
- **Utils**: Includes property mappers for sorting and filtering.
- **Validators**: Ensures data integrity with FluentValidation rules.

This project ties together the abstraction, domain, and infrastructure layers.

## Key Components

### Services

- `RoleService`: Handles role CRUD operations.
- `RolePermissionService`: Manages role-permission links.
- `UserRoleService`: Manages user-role assignments.

### Extensions

- `AuthorizationRbacApplicationExtension`: Registers all RBAC services.
- `AuthorizationRbacApplicationServiceExtension`: Registers service implementations.
- `AuthorizationRbacApplicationUtilExtension`: Registers utility mappers.
- `AuthorizationRbacApplicationValidatorExtension`: Registers validators.

### Utils

- `RoleEntityPropertyMap`: Maps properties for Role entities.
- `RolePermissionEntityPropertyMap`: Maps properties for RolePermission entities.
- `UserRoleEntityPropertyMap`: Maps properties for UserRole entities.

### Validators

- Request validators for create/update operations on roles, permissions, and user roles.

## Usage

Add this project to your ASP.NET application and call `services.AddAuthorizationRbacApplication()` in your DI setup. This will register all necessary services and dependencies.

## Dependencies

- .NET 9.0
- MasLazu.AspNet.Framework (for base services and utilities)
- FluentValidation
- Microsoft.Extensions.DependencyInjection

## Building and Testing

Run `dotnet build` to compile the project. Tests are available in the corresponding test project.
