using Xunit;
using FluentValidation.TestHelper;
using MasLazu.AspNet.Authorization.Rbac.Validators;
using MasLazu.AspNet.Authorization.Rbac.Abstraction.Models;

namespace MasLazu.AspNet.Authorization.Rbac.Test.Validators;

public class UpdateRolePermissionRequestValidatorTests
{
    private readonly UpdateRolePermissionRequestValidator _validator = new();

    [Fact]
    public void Id_NotEmpty_Valid()
    {
        var request = new UpdateRolePermissionRequest(Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid());

        TestValidationResult<UpdateRolePermissionRequest> result = _validator.TestValidate(request);

        result.ShouldNotHaveValidationErrorFor(x => x.Id);
    }

    [Fact]
    public void Id_Empty_Invalid()
    {
        var request = new UpdateRolePermissionRequest(Guid.Empty, Guid.NewGuid(), Guid.NewGuid());

        TestValidationResult<UpdateRolePermissionRequest> result = _validator.TestValidate(request);

        result.ShouldHaveValidationErrorFor(x => x.Id);
    }
}
