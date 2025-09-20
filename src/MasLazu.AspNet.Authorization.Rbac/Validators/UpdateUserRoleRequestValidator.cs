using FluentValidation;
using MasLazu.AspNet.Authorization.Rbac.Abstraction.Models;

namespace MasLazu.AspNet.Authorization.Rbac.Validators;

public class UpdateUserRoleRequestValidator : AbstractValidator<UpdateUserRoleRequest>
{
    public UpdateUserRoleRequestValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty();
    }
}
