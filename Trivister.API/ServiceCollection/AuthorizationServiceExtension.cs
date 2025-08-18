using Trivister.API.Authorization;

namespace Trivister.API.ServiceCollection;

public static class AuthorizationServiceExtension
{
    public static void ConfigureAuthorization(this IServiceCollection service)
    {
        service.AddAuthorization(authOptions =>
        {
            //authOptions.AddPolicy("UserCanAddRole", AuthorizationPolicies.CanCreateRole());
            authOptions.AddPolicy("UserCanAddRole", policyBuilder =>
            {
                policyBuilder.RequireAuthenticatedUser();
                policyBuilder.AddRequirements(new MustHavePermissionToEditRoleRequirement());
            });
        });
    }
}