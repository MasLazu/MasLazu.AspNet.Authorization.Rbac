using Xunit;
using Microsoft.Extensions.DependencyInjection;
using MasLazu.AspNet.Authorization.Rbac.Endpoint.Extensions;

namespace MasLazu.AspNet.Authorization.Rbac.Endpoint.Test.Extensions;

public class ServiceCollectionExtensionsTests
{
    [Fact]
    public void AddAuthorizationRbacEndpoints_AddsServices()
    {
        var services = new ServiceCollection();

        IServiceCollection result = services.AddAuthorizationRbacEndpoints();

        Assert.NotNull(result);
        Assert.Equal(services, result);
    }
}
