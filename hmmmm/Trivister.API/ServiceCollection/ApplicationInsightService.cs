using Microsoft.ApplicationInsights.Channel;
using Microsoft.ApplicationInsights.DataContracts;
using Microsoft.ApplicationInsights.Extensibility;
using Microsoft.Extensions.Logging.ApplicationInsights;
using Microsoft.Extensions.Options;
using Serilog;
using Serilog.Events;
using Trivister.ApplicationServices.Common.Options;

namespace Trivister.API.ServiceCollection;

public static class ApplicationInsightService
{
    public static void BootstrapAppInsight(this WebApplicationBuilder builder, IServiceCollection services)
    {
        // if (!builder.Environment.IsLocal())
        // {
        //     var serviceProvider = services.BuildServiceProvider().GetService<IOptions<AzureAppInsightOption>>(); 
        //     var azureAppInsightConnectionString = serviceProvider.Value.ConnectionString;
        //     
        //     builder.Services.AddApplicationInsightsTelemetry(options =>
        //         options.ConnectionString = azureAppInsightConnectionString);
        //     
        //     builder.Logging.AddFilter<ApplicationInsightsLoggerProvider>("", LogLevel.Trace);
        //     builder.Logging.AddFilter<ApplicationInsightsLoggerProvider>("Trivister.API", LogLevel.Trace);
        //     builder.Logging.AddFilter<ApplicationInsightsLoggerProvider>("", LogLevel.Error);
        //     builder.Logging.AddFilter<ApplicationInsightsLoggerProvider>("Trivister.API", LogLevel.Error);
        //     builder.Logging.AddFilter<ApplicationInsightsLoggerProvider>("", LogLevel.Warning);
        //     builder.Logging.AddFilter<ApplicationInsightsLoggerProvider>("Trivister.API", LogLevel.Information);
        //     builder.Logging.AddFilter<ApplicationInsightsLoggerProvider>("Microsoft", LogLevel.Information);
        //     
        //     services.AddSingleton<ITelemetryInitializer, ApplicationInsightTelemetryInitializer>();
        // }
    }
}

public class ApplicationInsightTelemetryInitializer: ITelemetryInitializer
{
    private const string EnvironmentPropertyName = "Environment";
    private const string EnvironmentCategoryPropertyName = "EnvironmentCategory";
    private const string ApplicationPropertyName = "Application";
    
    private readonly AzureAppInsightOption _appInsightOption;
    public ApplicationInsightTelemetryInitializer(IOptions<AzureAppInsightOption> options)
    {
        _appInsightOption = options.Value;
    }
    
    public void Initialize(ITelemetry telemetry)
    {
        var requestTelemetry = telemetry as RequestTelemetry;

        if (requestTelemetry == null) return;
        
        requestTelemetry.Properties.Add(EnvironmentPropertyName, _appInsightOption.Environment);
            
        requestTelemetry.Properties.Add(ApplicationPropertyName, _appInsightOption.Application);
            
        requestTelemetry.Properties.Add(EnvironmentCategoryPropertyName, _appInsightOption.EnvironmentCategory);

        if (string.IsNullOrEmpty(telemetry.Context.Cloud.RoleName))
        {
            telemetry.Context.Cloud.RoleInstance = "Trivista Role Management";
        }
    }
    
}