using FluentValidation;
using MasLazu.AspNet.Authorization.Rbac.Abstraction.Models;

namespace MasLazu.AspNet.Authorization.Rbac.Validators;

public class CreateRolePermissionRequestValidator : AbstractValidator<CreateRolePermissionRequest>
{
    public CreateRolePermissionRequestValidator()
    {
        RuleFor(x => x.PermissionId)
            .NotEmpty();

        RuleFor(x => x.RoleId)
            .NotEmpty();
    }
}
