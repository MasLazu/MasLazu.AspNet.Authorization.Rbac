using MasLazu.AspNet.Framework.Application.Models;

namespace MasLazu.AspNet.Authorization.Rbac.Abstraction.Models;

public record UpdateRoleRequest(
    Guid Id,
    string? Name,
    string? Description
) : BaseUpdateRequest(Id);
