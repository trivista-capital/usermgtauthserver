namespace Trivister.API.ServiceCollection;

public static class AzureAppConfigService
{
    public static WebApplicationBuilder BootstrapAppConfig(this WebApplicationBuilder builder)
    {
        //builder.Services.Configure<AzureAppConfigOption>(builder.Configuration.GetSection("AzureAppConfigOption"));
        if (builder.Environment.IsDevelopment() || builder.Environment.IsStaging() || builder.Environment.IsProduction())
        {
            //var serviceProvider = builder.Services.BuildServiceProvider().GetRequiredService<IOptions<AzureAppConfigOption>>();
            var azureAppConfigConnectionString = "Endpoint=https://borroweaserolemgtappconfiguration.azconfig.io;Id=HCzz;Secret=6f/CG0HSRZNziyjQaXrjKwKzSm1oxh2K9Py/VJFSKw8=";
            builder.Configuration.AddAzureAppConfiguration(options =>
            {
                options.Connect(azureAppConfigConnectionString).ConfigureRefresh((refreshOptions) =>
                {
                    // indicates that all configuration should be refreshed when the given key has changed.
                    refreshOptions.Register(key: "sentinel", refreshAll: true);
                    refreshOptions.SetCacheExpiration(TimeSpan.FromSeconds(5));
                }).UseFeatureFlags();
            });
        }

        return builder;
    }
}