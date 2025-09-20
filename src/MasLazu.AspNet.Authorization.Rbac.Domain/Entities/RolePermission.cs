using System;
using MasLazu.AspNet.Framework.Domain.Entities;

namespace MasLazu.AspNet.Authorization.Rbac.Domain.Entities;

public class RolePermission : BaseEntity
{
    public Guid PermissionId { get; set; }
    public Guid RoleId { get; set; }

    public Role? Role { get; set; }
}
