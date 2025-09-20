# MasLazu.AspNet.Authorization.Rbac.Endpoint

This project contains the API endpoints for Role-Based Access Control (RBAC) in ASP.NET applications using FastEndpoints. It defines the RESTful endpoints for managing roles, permissions, and user assignments.

## Overview

The endpoint layer provides:

- **Endpoint Groups**: Organize endpoints by resource (e.g., Roles, RolePermissions, UserRoles).
- **Endpoints**: Individual API endpoints for CRUD operations.
- **Extensions**: Dependency injection setup for registering endpoints.

Endpoints are built with FastEndpoints for high performance and type safety.

## Key Components

### Endpoint Groups

- `RolesEndpointGroup`: Groups role-related endpoints under `/roles`.
- `RolePermissionsEndpointGroup`: Groups role-permission endpoints.
- `UserRolesEndpointGroup`: Groups user-role endpoints.

### Endpoints

- Roles: Create, Read, Update, Delete, List with pagination.
- RolePermissions: Similar CRUD operations.
- UserRoles: Similar CRUD operations.

### Extensions

- `ServiceCollectionExtensions`: Registers all endpoints as singletons.

## Usage

Reference this project in your API layer and call `services.AddAuthorizationRbacEndpoints()` to register the endpoints. Ensure FastEndpoints is configured in your application.

## Dependencies

- .NET 9.0
- FastEndpoints
- MasLazu.AspNet.Framework.Endpoint (for base endpoint classes)

## Building and Testing

Run `dotnet build` to compile the project. Tests are available in the corresponding test project.
