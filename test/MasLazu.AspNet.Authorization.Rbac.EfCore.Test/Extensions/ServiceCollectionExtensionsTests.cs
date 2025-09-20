using Xunit;
using Microsoft.Extensions.DependencyInjection;
using MasLazu.AspNet.Authorization.Rbac.EfCore.Extensions;

namespace MasLazu.AspNet.Authorization.Rbac.EfCore.Test.Extensions;

public class ServiceCollectionExtensionsTests
{
    [Fact]
    public void AddAuthorizationRbacEntityFrameworkCore_ReturnsServiceCollection()
    {
        var services = new ServiceCollection();

        IServiceCollection result = services.AddAuthorizationRbacEntityFrameworkCore();

        Assert.NotNull(result);
        Assert.Equal(services, result);
    }
}
