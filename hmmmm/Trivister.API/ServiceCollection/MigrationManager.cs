using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Trivister.ApplicationServices.Abstractions;
using Trivister.Core.Entities;
using Trivister.DataStore.Context;

namespace Trivister.API.ServiceCollection;

public static class MigrationManager
{
    public static WebApplication MigrateDatabase(this WebApplication webapp)
    {
        using var scope = webapp.Services.CreateScope();
        using var appContext = scope.ServiceProvider.GetRequiredService<IdpDbContext>();
        var identityService = scope.ServiceProvider.GetRequiredService<IIdentityService>();
        try
        {
            appContext.Database.Migrate();
            var doesUserExist =
                appContext.Users.FirstOrDefaultAsync(x => x.Email.ToLower() == "femi.ibitolu@gmail.com".ToLower()).GetAwaiter().GetResult();
            if (doesUserExist == null)
            {
                var userId = Guid.Parse("363b37a0-c306-4472-a405-4b576334cca0");

                var result = identityService.CreateUserAsync(userId, "Babafemi", "Ibitolu", "femi.ibitolu@gmail.com", "Password@123");

                identityService.AddUserToRole(result.Result.user, "SUPERADMIN").GetAwaiter().GetResult();
            }

        }
        catch (Exception ex)
        {
            // Log errors or do anything you think it's needed
            // throw;
        }

        return webapp;
    }
}