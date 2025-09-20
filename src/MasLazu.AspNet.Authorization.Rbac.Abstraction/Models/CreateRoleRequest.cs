namespace MasLazu.AspNet.Authorization.Rbac.Abstraction.Models;

public record CreateRoleRequest(
    string Name,
    string? Description
);
