using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace Trivister.API.ServiceCollection;

public static class AuthenticationServiceExtension
{
    //This is used in the case of a web app (asp.net mvc)
    // builder.Services.AddAuthentication(options =>
    // {
    //     options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    //     options.DefaultChallengeScheme = OpenIdConnectDefaults.AuthenticationScheme;
    // }).AddCookie(CookieAuthenticationDefaults.AuthenticationScheme)
    //     .AddOpenIdConnect(options =>
    //     {
    //         options.SignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    //         options.Authority = "https://localhost:5001/";
    //         options.ClientId = "UserManagementApi";
    //         options.ClientSecret = "secret";
    //         options.ResponseType = "code";
    //         options.CallbackPath = new PathString("/signin-oidc");
    //         options.SaveTokens = true;
    //         options.Scope.Add("roles");
    //         options.ClaimActions.MapJsonKey("role", "role");
    //     });
    
    public static void ConfigureAuthentication(this IServiceCollection service, IConfiguration configuration)
    {
        service.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
                options.Authority = configuration.GetSection("IdentityOptions").GetSection("IdentityUrl").Value;
                options.Audience = "travisterApi";
                options.RequireHttpsMetadata = false;
                options.TokenValidationParameters = new()
                {
                    NameClaimType = "given_name",
                    RoleClaimType = "role",
                    ValidTypes = new[]{ "at+jwt" }
                };

            });
    }
}