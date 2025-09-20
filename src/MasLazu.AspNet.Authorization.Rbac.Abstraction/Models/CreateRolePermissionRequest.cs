namespace MasLazu.AspNet.Authorization.Rbac.Abstraction.Models;

public record CreateRolePermissionRequest(
    Guid PermissionId,
    Guid RoleId
);
