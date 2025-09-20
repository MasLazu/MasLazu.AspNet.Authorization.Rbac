using Microsoft.EntityFrameworkCore;
using MasLazu.AspNet.Framework.EntityFrameworkCore.Data;
using MasLazu.AspNet.Authorization.Rbac.Domain.Entities;

namespace MasLazu.AspNet.Authorization.Rbac.EfCore.Data;

public class AuthorizationRbacDbContext : BaseDbContext
{
    public AuthorizationRbacDbContext(DbContextOptions<AuthorizationRbacDbContext> options) : base(options)
    {
    }

    public DbSet<Role> Roles { get; set; }
    public DbSet<UserRole> UserRoles { get; set; }
    public DbSet<RolePermission> RolePermissions { get; set; }
}
