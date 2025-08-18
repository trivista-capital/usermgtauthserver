namespace Trivister.API.ServiceCollection;

public static class CorsServiceExtension
{
    public static void ConfigureCors(this IServiceCollection service)
    {
        service.AddCors(options =>
        {
            options.AddPolicy(name: "AllowSpecificOrigins",
                policy  =>
                {
                    policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
                });
        });
    }
}