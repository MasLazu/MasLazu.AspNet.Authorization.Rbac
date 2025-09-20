using MasLazu.AspNet.Framework.Application.Models;

namespace MasLazu.AspNet.Authorization.Rbac.Abstraction.Models;

public record RoleDto(
    Guid Id,
    string Name,
    string? Description,
    DateTimeOffset CreatedAt,
    DateTimeOffset? UpdatedAt
) : BaseDto(Id, CreatedAt, UpdatedAt);
