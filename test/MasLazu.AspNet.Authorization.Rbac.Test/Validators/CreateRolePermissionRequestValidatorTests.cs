using Xunit;
using FluentValidation.TestHelper;
using MasLazu.AspNet.Authorization.Rbac.Validators;
using MasLazu.AspNet.Authorization.Rbac.Abstraction.Models;

namespace MasLazu.AspNet.Authorization.Rbac.Test.Validators;

public class CreateRolePermissionRequestValidatorTests
{
    private readonly CreateRolePermissionRequestValidator _validator = new();

    [Fact]
    public void ValidRequest_NoErrors()
    {
        var request = new CreateRolePermissionRequest(Guid.NewGuid(), Guid.NewGuid());

        TestValidationResult<CreateRolePermissionRequest> result = _validator.TestValidate(request);

        result.ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void PermissionId_Empty_Invalid()
    {
        var request = new CreateRolePermissionRequest(Guid.Empty, Guid.NewGuid());

        TestValidationResult<CreateRolePermissionRequest> result = _validator.TestValidate(request);

        result.ShouldHaveValidationErrorFor(x => x.PermissionId);
    }
}
