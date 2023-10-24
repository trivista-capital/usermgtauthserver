using Trivister.IDP;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Serilog;
using Serilog.Events;
using Trivister.ApplicationServices.Common.Options;
using Trivister.ApplicationServices.Extentions;
using Trivister.Common.Model;
using Trivister.DataStore.Extensions;
using Trivister.Infrastructure;

Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .CreateBootstrapLogger();

Log.Information("Starting up");

try
{
    var builder = WebApplication.CreateBuilder(args);

    var env = builder.Environment.EnvironmentName;

    // if (!builder.Environment.IsDevelopment())
    // {
    //     var azureAppConfigConnectionString = "Endpoint=https://borroweaserolemgtappconfiguration.azconfig.io;Id=HCzz;Secret=6f/CG0HSRZNziyjQaXrjKwKzSm1oxh2K9Py/VJFSKw8=";
    //     builder.Configuration.AddAzureAppConfiguration(options =>
    //     {
    //         options.Connect(azureAppConfigConnectionString).ConfigureRefresh((refreshOptions) =>
    //         {
    //             // indicates that all configuration should be refreshed when the given key has changed.
    //             refreshOptions.Register(key: "sentinel", refreshAll: true);
    //             refreshOptions.SetCacheExpiration(TimeSpan.FromSeconds(5));
    //         }).UseFeatureFlags();
    //     });
    // }
    //builder.Services.AddAzureAppConfiguration();
    // var serviceProvider = builder.Services.BuildServiceProvider().GetService<IOptions<AzureAppInsightOption>>(); 
    // var azureAppInsightConnectionString = serviceProvider.Value.ConnectionString;
    // builder.Services.AddApplicationInsightsTelemetry(options =>
    //     options.ConnectionString = azureAppInsightConnectionString);
    var connectionString = builder.Configuration.GetConnectionString("TrivistaDbConnection");
    builder.Services.AddHttpContextAccessor();
    builder.Services.InjectApplicationServices(builder.Configuration);
    builder.Services.InjectPersistence(connectionString!);
    builder.Services.ConfigureInfrastructure(builder.Configuration);
    builder.Services.Configure<ApiBehaviorOptions>(option =>
    {
        option.InvalidModelStateResponseFactory = ErrorResult.GenerateErrorResponse;
    });
    builder.Host.UseSerilog((ctx, lc) => lc
        .WriteTo.Console(outputTemplate: "[{Timestamp:HH:mm:ss} {Level}] {SourceContext}{NewLine}{Message:lj}{NewLine}{Exception}{NewLine}")
        .MinimumLevel.Debug()
        .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
        .MinimumLevel.Override("System", LogEventLevel.Warning)
        .MinimumLevel.Override("Microsoft.AspNetCore.Authentication", LogEventLevel.Information)
        .Enrich.FromLogContext()
        .WriteTo.File("logs\\LogFile.txt")
        .Enrich.FromLogContext()
        .ReadFrom.Configuration(ctx.Configuration), preserveStaticLogger: true);

    var app = builder
        .ConfigureServices()
        .ConfigurePipeline();
    if (!app.Environment.IsDevelopment())
    {
        //app.UseAzureAppConfiguration();
    }
    
    app.Run();
}
catch (Exception ex)
{
    Log.Fatal(ex, "Unhandled exception");
}
finally
{
    Log.Information("Shut down complete");
    Log.CloseAndFlush();
}