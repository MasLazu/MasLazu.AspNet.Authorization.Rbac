using Xunit;
using FluentValidation.TestHelper;
using MasLazu.AspNet.Authorization.Rbac.Validators;
using MasLazu.AspNet.Authorization.Rbac.Abstraction.Models;

namespace MasLazu.AspNet.Authorization.Rbac.Test.Validators;

public class CreateRoleRequestValidatorTests
{
    private readonly CreateRoleRequestValidator _validator = new();

    [Fact]
    public void Name_NotEmpty_Valid()
    {
        var request = new CreateRoleRequest("Admin", "Description");

        TestValidationResult<CreateRoleRequest> result = _validator.TestValidate(request);

        result.ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void Name_TooLong_Invalid()
    {
        string longName = new string('A', 101);
        var request = new CreateRoleRequest(longName, "Description");

        TestValidationResult<CreateRoleRequest> result = _validator.TestValidate(request);

        result.ShouldHaveValidationErrorFor(x => x.Name);
    }

    [Fact]
    public void Description_Null_Valid()
    {
        var request = new CreateRoleRequest("Admin", null);

        TestValidationResult<CreateRoleRequest> result = _validator.TestValidate(request);

        result.ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void Description_TooLong_Invalid()
    {
        string longDescription = new string('A', 501);
        var request = new CreateRoleRequest("Admin", longDescription);

        TestValidationResult<CreateRoleRequest> result = _validator.TestValidate(request);

        result.ShouldHaveValidationErrorFor(x => x.Description);
    }

    [Fact]
    public void Description_Empty_Valid()
    {
        var request = new CreateRoleRequest("Admin", "");

        TestValidationResult<CreateRoleRequest> result = _validator.TestValidate(request);

        result.ShouldNotHaveAnyValidationErrors();
    }
}
