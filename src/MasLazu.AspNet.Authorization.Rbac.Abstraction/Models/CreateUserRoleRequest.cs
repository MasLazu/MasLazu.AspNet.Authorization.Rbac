namespace MasLazu.AspNet.Authorization.Rbac.Abstraction.Models;

public record CreateUserRoleRequest(
    Guid RoleId,
    Guid UserId
);
