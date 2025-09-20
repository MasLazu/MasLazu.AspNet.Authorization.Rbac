using FluentValidation;
using MasLazu.AspNet.Authorization.Rbac.Abstraction.Models;

namespace MasLazu.AspNet.Authorization.Rbac.Validators;

public class UpdateRolePermissionRequestValidator : AbstractValidator<UpdateRolePermissionRequest>
{
    public UpdateRolePermissionRequestValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty();
    }
}
