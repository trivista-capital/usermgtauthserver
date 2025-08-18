using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Logging;
using Serilog;
using Trivister.API.Filters;
using Trivister.API.ServiceCollection;
using Trivister.ApplicationServices.Extentions;
using Trivister.ApplicationServices.Features.Account;
using Trivister.ApplicationServices.Features.OTP_Management;
using Trivister.ApplicationServices.Features.Role;
using Trivister.ApplicationServices.Features.User;
using Trivister.DataStore.Extensions;
using Trivister.Infrastructure;

Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateBootstrapLogger();
Log.Information("Starting up");
try
{
    var builder = WebApplication.CreateBuilder(args);
    
    var env = builder.Environment.EnvironmentName;
    Log.Information("Environment is: {Environment}", env);

    builder.Services.ConfigureOptions(builder.Configuration);
    //builder.BootstrapAppConfig();
    //builder.Services.AddAzureAppConfiguration();
    //builder.BootstrapAppInsight(builder.Services);
    IdentityModelEventSource.ShowPII = true;
    builder.Services.AddControllers();
    var connectionString = builder.Configuration.GetConnectionString("TrivistaDbConnection");
    builder.ConfigureSerilog();
    builder.Services.ConfigureCors();
    builder.Services.AddHttpContextAccessor();
    builder.Services.AddAccessTokenManagement();
    builder.Services.ConfigureInfrastructure(builder.Configuration);
    builder.Services.InjectPersistence(connectionString!);
    builder.Services.InjectApplicationServices(builder.Configuration);
    builder.AddSendGrid();

    //This is used in the case of api
    JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Clear();
    builder.Services.ConfigurePolicies();
    builder.Services.ConfigureAuthentication(builder.Configuration);
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.ConfigureSwagger();
    builder.Services.ConfigureAuthorization();


    var app = builder.Build();
    app.MigrateDatabase();
    app.MapSwagger();
    if (builder.Environment.IsLocal() || builder.Environment.IsDevelopment() || builder.Environment.IsStaging()|| app.Environment.IsProduction())
    {
        app.UseSwagger();
        app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Trivister Roles / Permission API"));
    }
    
    if (app.Environment.IsDevelopment() || builder.Environment.IsStaging() || builder.Environment.IsProduction())
    {
        //app.UseAzureAppConfiguration();
    }
    app.UseSwagger();
    
    //app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Trivister Roles / Permission API"));
    
    app.UseCustomExceptionHandler();
    
    app.UseCors("AllowSpecificOrigins");

    app.MapGet("/", () => "Hello World!");
    
    #region Authentication
    app.GenerateTokenEndpoint();
    app.LoginEndpoint();
    app.RegisterUserEndpoint();
    app.ForgotPasswordEndpoint();
    app.ChangePasswordEndpoint();
    app.GeneratePasswordResetTokenEndpoint();
    app.ResendEmailConfirmationLinkEndpoint();
    app.WelcomeTriggerEndpoint();
    app.MapGet("/logout",  () =>
    {
        // await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        // await HttpContext.SignOutAsync(OpenIdConnectDefaults.AuthenticationScheme);
    }).WithName("Logout")
        .WithTags("Authentication");
    #endregion

    #region User Management
    app.GetUsersEndpoint();
    app.GetUserEndpoint();
    app.DeleteUserEndpoint();
    app.EditUserEndpoint();
    #endregion

    #region Roles
    app.CreateRoleEndpoint();
    app.EditRoleEndpoint();
    app.AssignPermissionsToRoleEndpoint();
    app.GetRoleEndpoint();
    app.GetRolesEndpoint();
    app.GetPermissionEndpoint();
    #endregion
    
    #region OTP
    app.ValidateOTPEndpoint();
    app.GenerateOTPEndpoint();
    #endregion

    app.UseAuthentication();
    
    app.UseAuthorization();

    app.MapControllers();
    
    app.Run();
}
catch (Exception ex) when (ex.GetType().Name is not "StopTheHostException")
{
    Log.Fatal(ex, "Unhandled exception");
}
finally
{
    Log.Information("Shut down complete");
    Log.CloseAndFlush();
}