using Xunit;
using Microsoft.Extensions.DependencyInjection;
using MasLazu.AspNet.Authorization.Rbac.Extensions;

namespace MasLazu.AspNet.Authorization.Rbac.Test.Extensions;

public class AuthorizationRbacApplicationExtensionTests
{
    [Fact]
    public void AddAuthorizationRbacApplication_AddsServices()
    {
        var services = new ServiceCollection();

        IServiceCollection result = services.AddAuthorizationRbacApplication();

        Assert.NotNull(result);
        Assert.Equal(services, result);
    }
}
