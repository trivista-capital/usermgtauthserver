using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Trivister.ApplicationServices.Abstractions;
using Trivister.ApplicationServices.Common.Pagination;
using Trivister.Common.Model;
using Trivister.Core.Entities;

namespace Trivister.ApplicationServices.Features.User;

public static class GetUsersController
{
    public static void GetUsersEndpoint(this WebApplication app)
    {
        app.MapGet("getUsers", async (IMediator mediator, [FromQuery]int pageNumber, [FromQuery]int itemsPerPage) =>
        {
            var users = await mediator.Send(new GetUsersQuery(pageNumber, itemsPerPage));
            return Results.Ok(users);
        }).WithName("GetUsers")
            .Produces<ErrorResult<List<GetUsersDto>>>(StatusCodes.Status200OK)
            .Produces<ErrorResult<List<GetUsersDto>>>(StatusCodes.Status404NotFound)
            .WithTags("User Management")
            .RequireCors("AllowSpecificOrigins");
    }
}

public record GetUsersDto(Guid Id, string? FirstName, string? MiddleName, string? LastName, string? Address, int RoleId, string Email, string Gender)
{
    public string? RoleName { get; set; }
    public static Expression<Func<ApplicationUser, GetUsersDto>> Projection
    {
        get
        {
            return x => new GetUsersDto(x.Id, x.FirstName, x.MiddleName, x.LastName, x.Address, x.RoleId, x.Email, "");
        }
    }

    // public static explicit operator ToGetUsersDto(ApplicationUser user)
    // {
    //     return new GetUsersDto(user.Id, user.FirstName, user.MiddleName, user.LastName, user.Address, user.RoleId);
    // }
}

public sealed record GetUsersQuery(int PageNumber = 1, int ItemsPerPage = 10) : IRequest<ErrorResult<PaginationInfo<GetUsersDto>>>;

public sealed class GetUsersQueryHandler : IRequestHandler<GetUsersQuery, ErrorResult<PaginationInfo<GetUsersDto>>>
{
    private readonly IIdentityService _identityService;
    public GetUsersQueryHandler(IIdentityService identityService)
    {
        _identityService = identityService;
    }
    
    public async Task<ErrorResult<PaginationInfo<GetUsersDto>>> Handle(GetUsersQuery request, CancellationToken cancellationToken)
    {
        var userIds = await _identityService.GetUserNotInRoleAsync("Customer");
        var usersFromDb = _identityService.GetUserByIdQueryAble(userIds);
        
        var pagedResult = PaginationData.Paginate(usersFromDb, request.PageNumber, request.ItemsPerPage);
        
        var users = usersFromDb.Select(x => new GetUsersDto(x.Id, x.FirstName, x.MiddleName, x.LastName, x.Address,
                                    x.RoleId, x.Email, "")).ToList();

        for (int i = 0; i < users.Count(); i ++)
        {
            var role = await _identityService.GetUsersRole(users[i].Id);
            users[i].RoleName = role?.Name;
        }

        return ErrorResult.Ok(new PaginationInfo<GetUsersDto>(users, 
            pagedResult.CurrentPage, 
            pagedResult.PageSize, 
            pagedResult.TotalItems, 
            pagedResult.TotalPages));
    }
}