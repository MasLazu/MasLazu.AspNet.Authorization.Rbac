using FluentValidation;
using MasLazu.AspNet.Authorization.Rbac.Abstraction.Interfaces;
using MasLazu.AspNet.Authorization.Rbac.Abstraction.Models;
using MasLazu.AspNet.Framework.Application.Interfaces;
using MasLazu.AspNet.Framework.Application.Services;
using MasLazu.AspNet.Authorization.Rbac.Domain.Entities;

namespace MasLazu.AspNet.Authorization.Rbac.Services;

public class RoleService : CrudService<Role, RoleDto, CreateRoleRequest, UpdateRoleRequest>, IRoleService
{
    public RoleService(
        IRepository<Role> repository,
        IReadRepository<Role> readRepository,
        IUnitOfWork unitOfWork,
        IEntityPropertyMap<Role> propertyMap,
        IPaginationValidator<Role> paginationValidator,
        ICursorPaginationValidator<Role> cursorPaginationValidator,
        IValidator<CreateRoleRequest>? createValidator = null,
        IValidator<UpdateRoleRequest>? updateValidator = null)
        : base(repository, readRepository, unitOfWork, propertyMap, paginationValidator, cursorPaginationValidator, createValidator, updateValidator)
    {
    }
}
