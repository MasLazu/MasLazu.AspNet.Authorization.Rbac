using MasLazu.AspNet.Framework.Application.Models;

namespace MasLazu.AspNet.Authorization.Rbac.Abstraction.Models;

public record UpdateRolePermissionRequest(
    Guid Id,
    Guid? PermissionId,
    Guid? RoleId
) : BaseUpdateRequest(Id);
