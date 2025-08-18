using System.Data.Entity;
using Microsoft.AspNetCore.Authorization;
using Trivister.ApplicationServices.Abstractions;

namespace Trivister.API.Authorization;


/// <summary>
/// 
/// </summary>
public sealed class MustHavePermissionToEditRoleRequirement: IAuthorizationRequirement
{
    /// <summary>
    /// 
    /// </summary>
    public MustHavePermissionToEditRoleRequirement()
    {
            
    }
}



/// <summary>
/// 
/// </summary>
public class MustHavePermissionToEditRoleRequirementHandler: AuthorizationHandler<MustHavePermissionToEditRoleRequirement>
{
    private readonly IGlobalTSDbContext _dbContext;
    private readonly IHttpContextAccessor _contextAccessor;
    /// <summary>
    /// 
    /// </summary>
    /// <param name="dbContext"></param>
    /// <param name="identityService"></param>
    /// <param name="contextAccessor"></param>
    public MustHavePermissionToEditRoleRequirementHandler(IGlobalTSDbContext dbContext, IHttpContextAccessor contextAccessor)
    {
        _dbContext = dbContext;
        _contextAccessor = contextAccessor;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="context"></param>
    /// <param name="requirement"></param>
    protected override async Task HandleRequirementAsync(AuthorizationHandlerContext context, MustHavePermissionToEditRoleRequirement requirement)
    {
        var userId = _contextAccessor?.HttpContext?.User?.Claims?.FirstOrDefault(x => x.Type == "sub").Value;
        if (string.IsNullOrEmpty(userId) || userId == Guid.Empty.ToString())
        {
            context.Fail();
            return;
        }
        var role = await _dbContext!.UsersRole!.Where(x => x.UserId == Guid.Parse(userId)).Select(x => x).FirstOrDefaultAsync(new CancellationToken());
        if (role == null)
        {
            context.Fail();
            return;
        }
        var permissions = await _dbContext.RolesPermissions.Where(x => x.RoleId == role.RoleId).ToListAsync();
        if (!permissions.Any())
        {
            context.Fail();
            return;
        }
        if (permissions.Any(x=>x.Permission.Name == "CanEditRole"))
        {
            context.Succeed(requirement);
            return;
        }
    }
}