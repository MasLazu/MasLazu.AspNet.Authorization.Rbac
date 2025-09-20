using FluentValidation;
using MasLazu.AspNet.Authorization.Rbac.Abstraction.Interfaces;
using MasLazu.AspNet.Authorization.Rbac.Abstraction.Models;
using MasLazu.AspNet.Framework.Application.Interfaces;
using MasLazu.AspNet.Framework.Application.Services;
using MasLazu.AspNet.Authorization.Rbac.Domain.Entities;

namespace MasLazu.AspNet.Authorization.Rbac.Services;

public class UserRoleService : CrudService<UserRole, UserRoleDto, CreateUserRoleRequest, UpdateUserRoleRequest>, IUserRoleService
{
    public UserRoleService(
        IRepository<UserRole> repository,
        IReadRepository<UserRole> readRepository,
        IUnitOfWork unitOfWork,
        IEntityPropertyMap<UserRole> propertyMap,
        IPaginationValidator<UserRole> paginationValidator,
        ICursorPaginationValidator<UserRole> cursorPaginationValidator,
        IValidator<CreateUserRoleRequest>? createValidator = null,
        IValidator<UpdateUserRoleRequest>? updateValidator = null)
        : base(repository, readRepository, unitOfWork, propertyMap, paginationValidator, cursorPaginationValidator, createValidator, updateValidator)
    {
    }
}
