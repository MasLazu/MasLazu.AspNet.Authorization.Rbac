# MasLazu.AspNet.Authorization.Rbac.Domain

This project contains the domain entities for Role-Based Access Control (RBAC) in ASP.NET applications. It defines the core business objects that represent roles, permissions, and user-role relationships.

## Overview

The domain layer encapsulates the business logic and data structures. It includes:

- **Entities**: Core classes like `Role`, `RolePermission`, and `UserRole` that inherit from `BaseEntity` for common properties (Id, timestamps).

These entities are used across the application for data persistence and business operations.

## Key Components

### Entities

- `Role`: Represents a role with Name and Description.
- `RolePermission`: Links roles to permissions via PermissionId and RoleId.
- `UserRole`: Assigns users to roles via RoleId and UserId.

All entities include audit fields like CreatedAt and UpdatedAt.

## Usage

Reference this project in your data access and service layers. The entities are configured in the EF Core layer for database mapping.

## Dependencies

- .NET 9.0
- MasLazu.AspNet.Framework.Domain (for BaseEntity)

## Building and Testing

Run `dotnet build` to compile the project. Tests are available in the corresponding test project.
