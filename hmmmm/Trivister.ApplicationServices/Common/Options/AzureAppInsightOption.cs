namespace Trivister.ApplicationServices.Common.Options;

public class AzureAppInsightOption
{
    public string ConnectionString { get; set; }
    
    public string Environment { get; set; } = default!;
    
    public string Application { get; set; } = default!;
    
    public string EnvironmentCategory { get; set; } = default!;
}