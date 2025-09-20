using FluentValidation;
using MasLazu.AspNet.Authorization.Rbac.Abstraction.Interfaces;
using MasLazu.AspNet.Authorization.Rbac.Abstraction.Models;
using MasLazu.AspNet.Framework.Application.Interfaces;
using MasLazu.AspNet.Framework.Application.Services;
using MasLazu.AspNet.Authorization.Rbac.Domain.Entities;

namespace MasLazu.AspNet.Authorization.Rbac.Services;

public class RolePermissionService : CrudService<RolePermission, RolePermissionDto, CreateRolePermissionRequest, UpdateRolePermissionRequest>, IRolePermissionService
{
    public RolePermissionService(
        IRepository<RolePermission> repository,
        IReadRepository<RolePermission> readRepository,
        IUnitOfWork unitOfWork,
        IEntityPropertyMap<RolePermission> propertyMap,
        IPaginationValidator<RolePermission> paginationValidator,
        ICursorPaginationValidator<RolePermission> cursorPaginationValidator,
        IValidator<CreateRolePermissionRequest>? createValidator = null,
        IValidator<UpdateRolePermissionRequest>? updateValidator = null)
        : base(repository, readRepository, unitOfWork, propertyMap, paginationValidator, cursorPaginationValidator, createValidator, updateValidator)
    {
    }
}
