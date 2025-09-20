using MasLazu.AspNet.Framework.Application.Models;

namespace MasLazu.AspNet.Authorization.Rbac.Abstraction.Models;

public record UpdateUserRoleRequest(
    Guid Id,
    Guid? RoleId,
    Guid? UserId
) : BaseUpdateRequest(Id);
