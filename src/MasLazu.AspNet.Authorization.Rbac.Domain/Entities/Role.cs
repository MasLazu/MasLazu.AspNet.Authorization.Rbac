using System;
using MasLazu.AspNet.Framework.Domain.Entities;

namespace MasLazu.AspNet.Authorization.Rbac.Domain.Entities;

public class Role : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
}
