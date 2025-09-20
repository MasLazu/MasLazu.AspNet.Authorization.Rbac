using Xunit;
using FluentValidation.TestHelper;
using MasLazu.AspNet.Authorization.Rbac.Validators;
using MasLazu.AspNet.Authorization.Rbac.Abstraction.Models;

namespace MasLazu.AspNet.Authorization.Rbac.Test.Validators;

public class CreateUserRoleRequestValidatorTests
{
    private readonly CreateUserRoleRequestValidator _validator = new();

    [Fact]
    public void ValidRequest_NoErrors()
    {
        var request = new CreateUserRoleRequest(Guid.NewGuid(), Guid.NewGuid());

        TestValidationResult<CreateUserRoleRequest> result = _validator.TestValidate(request);

        result.ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void RoleId_Empty_Invalid()
    {
        var request = new CreateUserRoleRequest(Guid.Empty, Guid.NewGuid());

        TestValidationResult<CreateUserRoleRequest> result = _validator.TestValidate(request);

        result.ShouldHaveValidationErrorFor(x => x.RoleId);
    }
}
