using MasLazu.AspNet.Framework.Application.Models;

namespace MasLazu.AspNet.Authorization.Rbac.Abstraction.Models;

public record UserRoleDto(
    Guid Id,
    Guid RoleId,
    Guid UserId,
    DateTimeOffset CreatedAt,
    DateTimeOffset? UpdatedAt
) : BaseDto(Id, CreatedAt, UpdatedAt);
