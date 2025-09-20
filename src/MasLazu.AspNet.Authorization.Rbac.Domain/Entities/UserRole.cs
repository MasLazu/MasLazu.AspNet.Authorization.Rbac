using System;
using MasLazu.AspNet.Framework.Domain.Entities;

namespace MasLazu.AspNet.Authorization.Rbac.Domain.Entities;

public class UserRole : BaseEntity
{
    public Guid RoleId { get; set; }
    public Guid UserId { get; set; }

    public Role? Role { get; set; }
}
