using Xunit;
using FluentValidation.TestHelper;
using MasLazu.AspNet.Authorization.Rbac.Validators;
using MasLazu.AspNet.Authorization.Rbac.Abstraction.Models;

namespace MasLazu.AspNet.Authorization.Rbac.Test.Validators;

public class UpdateRoleRequestValidatorTests
{
    private readonly UpdateRoleRequestValidator _validator = new();

    [Fact]
    public void Id_NotEmpty_Valid()
    {
        var request = new UpdateRoleRequest(Guid.NewGuid(), "Name", "Description");

        TestValidationResult<UpdateRoleRequest> result = _validator.TestValidate(request);

        result.ShouldNotHaveValidationErrorFor(x => x.Id);
    }

    [Fact]
    public void Name_Null_Valid()
    {
        var request = new UpdateRoleRequest(Guid.NewGuid(), null, "Description");

        TestValidationResult<UpdateRoleRequest> result = _validator.TestValidate(request);

        result.ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void Name_TooLong_Invalid()
    {
        string longName = new string('A', 101);
        var request = new UpdateRoleRequest(Guid.NewGuid(), longName, "Description");

        TestValidationResult<UpdateRoleRequest> result = _validator.TestValidate(request);

        result.ShouldHaveValidationErrorFor(x => x.Name);
    }

    [Fact]
    public void Description_Null_Valid()
    {
        var request = new UpdateRoleRequest(Guid.NewGuid(), "Name", null);

        TestValidationResult<UpdateRoleRequest> result = _validator.TestValidate(request);

        result.ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void Description_TooLong_Invalid()
    {
        string longDescription = new string('A', 501);
        var request = new UpdateRoleRequest(Guid.NewGuid(), "Name", longDescription);

        TestValidationResult<UpdateRoleRequest> result = _validator.TestValidate(request);

        result.ShouldHaveValidationErrorFor(x => x.Description);
    }
}