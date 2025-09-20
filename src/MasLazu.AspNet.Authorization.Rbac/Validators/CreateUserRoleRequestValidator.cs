using FluentValidation;
using MasLazu.AspNet.Authorization.Rbac.Abstraction.Models;

namespace MasLazu.AspNet.Authorization.Rbac.Validators;

public class CreateUserRoleRequestValidator : AbstractValidator<CreateUserRoleRequest>
{
    public CreateUserRoleRequestValidator()
    {
        RuleFor(x => x.RoleId)
            .NotEmpty();

        RuleFor(x => x.UserId)
            .NotEmpty();
    }
}
