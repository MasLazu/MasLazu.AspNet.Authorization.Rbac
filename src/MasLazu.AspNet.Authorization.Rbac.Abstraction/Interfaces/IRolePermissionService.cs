using MasLazu.AspNet.Framework.Application.Interfaces;
using MasLazu.AspNet.Authorization.Rbac.Abstraction.Models;

namespace MasLazu.AspNet.Authorization.Rbac.Abstraction.Interfaces;

public interface IRolePermissionService : ICrudService<RolePermissionDto, CreateRolePermissionRequest, UpdateRolePermissionRequest>
{
}
