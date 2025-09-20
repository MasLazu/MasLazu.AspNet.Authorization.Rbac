# MasLazu.AspNet.Authorization.Rbac.EfCore

This project provides the Entity Framework Core implementation for Role-Based Access Control (RBAC) data persistence. It includes the DbContext, entity configurations, and extensions for database integration.

## Overview

The EF Core layer handles:

- **Data Context**: `AuthorizationRbacDbContext` for database operations.
- **Configurations**: Entity type configurations for roles, permissions, and user roles.
- **Extensions**: Dependency injection setup (currently minimal).

It configures relationships, indexes, and constraints for optimal performance.

## Key Components

### Data

- `AuthorizationRbacDbContext`: Inherits from `BaseDbContext`, includes DbSets for Roles, UserRoles, RolePermissions.

### Configurations

- `RoleConfiguration`: Sets up Role entity with keys, properties, and unique index on Name.
- `RolePermissionConfiguration`: Configures RolePermission with foreign keys and composite unique index.
- `UserRoleConfiguration`: Configures UserRole with foreign keys and composite unique index.

### Extensions

- `ServiceCollectionExtensions`: Placeholder for future EF Core registrations.

## Usage

Add this project to your data layer and configure the DbContext in your application. Use migrations to create/update the database schema.

## Dependencies

- .NET 9.0
- Microsoft.EntityFrameworkCore
- MasLazu.AspNet.Framework.EntityFrameworkCore (for BaseDbContext)

## Building and Testing

Run `dotnet build` to compile the project. Tests are available in the corresponding test project.
