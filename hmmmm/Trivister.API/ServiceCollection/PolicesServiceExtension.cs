using Microsoft.AspNetCore.Authorization;
using Trivister.API.Authorization;

namespace Trivister.API.ServiceCollection;

public static class PolicesServiceExtension
{
    public static void ConfigurePolicies(this IServiceCollection service)
    {
        service.AddScoped<IAuthorizationHandler, MustHavePermissionToEditRoleRequirementHandler>();
    }
}