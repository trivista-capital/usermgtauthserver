using Microsoft.AspNetCore.Mvc;
using Trivister.ApplicationServices.Common.Options;
using Trivister.Common.Model;

namespace Trivister.API.ServiceCollection;

public static class OptionsConfiguration
{
    public static void ConfigureOptions(this IServiceCollection services, IConfiguration config)
    {
        services.Configure<OTPConfiguration>(config.GetSection("OTPConfiguration"));
        services.Configure<MailOptions>(config.GetSection("MailOptions"));
        services.Configure<ApiBehaviorOptions>(option =>
        {
            option.InvalidModelStateResponseFactory = ErrorResult.GenerateErrorResponse;
        });
    }
}