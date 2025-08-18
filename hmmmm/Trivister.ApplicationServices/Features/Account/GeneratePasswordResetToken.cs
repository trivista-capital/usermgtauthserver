using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Trivister.ApplicationServices.Abstractions;
using Trivister.ApplicationServices.Common.Options;
using Trivister.ApplicationServices.Features.Account.EventHandlers;
using Trivister.ApplicationServices.Features.OTP_Management;
using Trivister.Common.Model;
using Trivister.Common.Options;
using Trivister.Core.Entities;

namespace Trivister.ApplicationServices.Features.Account;

public static class GeneratePasswordResetTokenController
{
    public static void GeneratePasswordResetTokenEndpoint(this WebApplication app)
    {
        app.MapPost("/generatePasswordResetToken",
            async ([FromBody] GeneratePasswordResetTokenCommand body, IMediator mediator) =>
            {
                var result = await mediator.Send(body);
                return Results.Ok(result);
            }).WithName("GeneratePasswordResetToken")
            .WithTags("Authentication")
            .RequireCors("AllowSpecificOrigins");
    }
}

public record GeneratePasswordResetTokenCommand(string Email) : IRequest<ErrorResult>;

public class GeneratePasswordResetTokenCommandValidation : AbstractValidator<GeneratePasswordResetTokenCommand>
{
    public GeneratePasswordResetTokenCommandValidation()
    {
        RuleFor(x => x.Email).NotNull().NotEmpty().NotEqual("string").WithMessage("Email can not be empty");
    }   
}

public class GeneratePasswordResetTokenCommandHandler : IRequestHandler<GeneratePasswordResetTokenCommand, ErrorResult>
{
    private readonly IIdentityService _identityService;
    private readonly IConfiguration _configuration;
    private readonly ILogger<GeneratePasswordResetTokenCommandHandler> _logger;
    private readonly MailOptions _mailOptions;
    private readonly IPublisher _publisher;
    private readonly IMediator _mediator;
    public GeneratePasswordResetTokenCommandHandler(IIdentityService identityService, IPublisher publisher, IConfiguration configuration, 
        ILogger<GeneratePasswordResetTokenCommandHandler> logger, IOptions<MailOptions> mailOptions, IMediator mediator)
    {
        _identityService = identityService;
        _publisher = publisher;
        _configuration = configuration;
        _logger = logger;
        _mediator = mediator;
        _mailOptions = mailOptions.Value;
    }
    
    public async Task<ErrorResult> Handle(GeneratePasswordResetTokenCommand request, CancellationToken cancellationToken)
    {
            _logger.LogInformation("Entered the GeneratePasswordResetTokenCommandHandler");
            var user = await this._identityService.GetUserByEmail(request.Email);
            if (user?.Value == null)
            {
              ErrorResult.Fail<string>("User not found");
            }

            var otpResult = await _mediator.Send(new OTPCommand(Email: request.Email), cancellationToken);

            await _publisher.Publish(new GeneratePasswordResetTokenEvent()
            { 
                CustomerName = $"{user!.Value!.FirstName} {user!.Value!.MiddleName} {user!.Value!.LastName}",
                Email = request.Email,
                OTP = otpResult.Value
            }, cancellationToken);
            _logger.LogInformation("Published the SendEmailMessage event");
            return ErrorResult.Ok();
    }
}