using Xunit;
using Microsoft.Extensions.DependencyInjection;
using MasLazu.AspNet.Authorization.Rbac.Extensions;

namespace MasLazu.AspNet.Authorization.Rbac.Test.Extensions;

public class AuthorizationRbacApplicationValidatorExtensionTests
{
    [Fact]
    public void AddAuthorizationRbacApplicationValidators_AddsServices()
    {
        var services = new ServiceCollection();

        IServiceCollection result = services.AddAuthorizationRbacApplicationValidators();

        Assert.NotNull(result);
        Assert.Equal(services, result);
    }
}
