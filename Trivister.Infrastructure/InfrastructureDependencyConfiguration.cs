using Duende.IdentityServer.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Trivister.ApplicationServices.Abstractions;
using Trivister.ApplicationServices.Common.Options;
using Trivister.Common.Options;
using Trivister.Infrastructure.Http;
using Trivister.Infrastructure.IdentityConfig;
using Trivister.Infrastructure.MailService;

namespace Trivister.Infrastructure;

public static class InfrastructureDependencyConfiguration
{
    public static IServiceCollection ConfigureInfrastructure(this IServiceCollection builder, IConfiguration configuration)
    {
        builder.AddScoped<IProfileService, ProfileService>();
        builder.AddIdentityServer(options =>
            {
                // https://docs.duendesoftware.com/identityserver/v6/fundamentals/resources/api_scopes#authorization-based-on-scopes
                options.EmitStaticAudienceClaim = true;
            })
            .AddProfileService<ProfileService>()
            .AddInMemoryIdentityResources(Config.IdentityResources)
            .AddInMemoryApiScopes(Config.ApiScopes)
            .AddInMemoryApiResources(Config.ApiResources)
            .AddInMemoryClients(Config.Clients)
            .AddResourceOwnerValidator<ResourceOwnerPasswordValidator>();
        builder.Configure<IdentityOptions>(configuration.GetSection("IdentityOptions"));
        builder.AddHttpClient<IGetTokenClient, GetTokenClient>((provider, client) =>
        {
            var serviceProvider = provider.GetService<IOptions<IdentityOptions>>();
            client.BaseAddress = configuration.GetServiceUri("trivister-idp");
            //client.BaseAddress = new Uri(serviceProvider!.Value.IdentityUrl);
        });
        builder.AddScoped<ICustomerClient, CustomerClient>();
        
        builder.AddHttpClient<ICustomerClient, CustomerClient>((provider, client) =>
        {
            client.BaseAddress = new Uri(configuration.GetSection("LoanAppBaseAddress").Value);
        }).ConfigurePrimaryHttpMessageHandler(() => new SocketsHttpHandler()
        {
            PooledConnectionLifetime = TimeSpan.FromMinutes(15)
        }).SetHandlerLifetime(Timeout.InfiniteTimeSpan);
        
        // builder.AddHttpClient<IMailManager, MailManager>((provider, client) =>
        // {
        //     var serviceProvider = provider.GetService<IOptions<MailOptions>>();
        //     client.BaseAddress = new Uri(serviceProvider.Value.BaseAddress);
        // }).ConfigurePrimaryHttpMessageHandler(() => new SocketsHttpHandler()
        // {
        //     PooledConnectionLifetime = TimeSpan.FromMinutes(15)
        // }).SetHandlerLifetime(Timeout.InfiniteTimeSpan);
        
        builder.AddHttpClient<IMailManager, MailManager>((provider, client) =>
        {
            var serviceProvider = provider.GetService<IConfiguration>();
            string baseAddy = serviceProvider.GetSection("TrivistaMailServiceBaseAddress").Value;
            client.BaseAddress = new Uri(baseAddy);
        }).ConfigurePrimaryHttpMessageHandler(() => new SocketsHttpHandler()
        {
            PooledConnectionLifetime = TimeSpan.FromMinutes(15)
        }).SetHandlerLifetime(Timeout.InfiniteTimeSpan);
        
        return builder;
    }
}