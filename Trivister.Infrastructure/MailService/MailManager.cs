using System.Diagnostics;
using System.Text;
using ElasticEmail.Api;
using ElasticEmail.Client;
using ElasticEmail.Model;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Trivister.ApplicationServices.Abstractions;
using Trivister.ApplicationServices.Common.Helper;
using Trivister.ApplicationServices.Common.Options;
using Trivister.ApplicationServices.Dto;

namespace Trivister.Infrastructure.MailService;

public sealed class MailManager: IMailManager
{
    private static MailOptions _mailOptions;
    private readonly HttpClient _client;
    private readonly ILogger<MailManager> _logger;

    public MailManager(IOptions<MailOptions> mailOptions, HttpClient client, ILogger<MailManager> logger)
    {
        _client = client;
        _logger = logger;
        _mailOptions = mailOptions.Value;
    }
    
    public async Task BuildSignUpMessage(string otp, string to, string name)
    {
        _logger.LogInformation("Inside the BuildSignUpMessage method");
        try
        {
            // MailObject mObject = new()
            // {
            //     To = to,
            //     From = _mailOptions.From,
            //     CharSet = "utf-8",
            //     BodyAmp = "est",
            //     IsTransactional = true,
            //     Sender = _mailOptions.From,
            //     Subject = _mailOptions.OTPMailSubject
            // };
            
            var builder = new MailBuilder();
             var mailObject = builder.WithToEmail(to)
                 .WithFromEmail(_mailOptions.From)
                 .WithOTPSubject(_mailOptions.OTPMailSubject)
                 .WithSignUpMessageMessage(name, otp)
                 .BuildOtpMailDto(); 
            _logger.LogInformation("Finished building signup message method");
            _logger.LogInformation("Calling the SendEmailAsync with parameters: {@Parameters}", mailObject);
            await SendEmailAsync(mailObject);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occured while building mail message");
        }
    }
    
    public async Task BuildPasswordSuccessfullyResetMessage(string to, string name)
    {
        var builder = new MailBuilder();
        var mailObject = builder.WithToEmail(to)
            .WithFromEmail(_mailOptions.From)
            .WithOTPSubject(_mailOptions.OTPMailSubject)
            .WithPasswordSuccessfullyResetMessage(name)
            .BuildOtpMailDto(); 
        await SendEmailAsync(mailObject);
    }

    public async Task BuildForgotPasswordMessage(string customerName, string message, string to)
    {
        var builder = new MailBuilder();
        var mailObject = builder.WithToEmail(to)
            .WithFromEmail(_mailOptions.From)
            .WithOTPSubject(_mailOptions.PasswordResetSubject)
            .WithForgotPasswordMessage(customerName, message)
            .BuildOtpMailDto(); 
        await SendEmailAsync(mailObject);
    }

    public async Task BuildResetPasswordMessage(string confirmationLink, string to)
    {
        var builder = new MailBuilder();
        var mailObject = builder.WithToEmail(to)
            .WithFromEmail(_mailOptions.From)
            .WithOTPSubject(_mailOptions.PasswordResetSubject)
            .WithForgotPasswordMessage(confirmationLink, to)
            .BuildOtpMailDto(); 
        await SendEmailAsync(mailObject);
    }
    
    public async Task BuildWelcomeMessage(string name, string to)
    {
        var builder = new MailBuilder();
        var mailObject = builder.WithToEmail(to)
            .WithFromEmail(_mailOptions.From)
            .WithOTPSubject(_mailOptions.WelcomeMessageSubject)
            .WithWelcomeMessage(name)
            .BuildOtpMailDto(); 
        await SendEmailAsync(mailObject);
    }
    
    public async Task BuildAdminUserInvitationMessage(string to, string adminName)
    {
        var builder = new MailBuilder();
        var mailObject = builder.WithToEmail(to)
            .WithFromEmail(_mailOptions.From)
            .WithOTPSubject(_mailOptions.AdminWelcomeSubject)
            .WithAdminUserInvitationMessage(adminName)
            .BuildOtpMailDto(); 
        await SendEmailAsync(mailObject);
    }

    public async Task BuildMessageToAdminOnCustomerRegistrationMessage(string to, string adminName, string customerFullName,
        string customerEmail, string customerPhone, string dateOfRegistration)
    {
        var builder = new MailBuilder();
        var mailObject = builder.WithToEmail(to)
            .WithFromEmail(_mailOptions.From)
            .WithOTPSubject(_mailOptions.AdminNotificatinOfCustomerRegistrationSubject)
            .WithMessageToAdminOnCustomerRegistrationMessage(adminName,  customerFullName, customerEmail,  customerPhone, dateOfRegistration)
            .BuildOtpMailDto(); 
        await SendEmailAsync(mailObject);
    }

    private void SendEmail(MailObject dto)
    {
        try
        {
            Configuration config = new Configuration();
            // Configure API key authorization: apikey
            config.ApiKey.Add("X-ElasticEmail-ApiKey", _mailOptions.APIKey);
            var apiInstance = new EmailsApi(config);
            var to = new List<string> { dto.To };
            var recipients = new TransactionalRecipient(to: to);
            EmailTransactionalMessageData emailData = new EmailTransactionalMessageData(recipients: recipients)
            {
                Content = new EmailContent
                {
                    Body = new List<BodyPart>()
                }
            };
            BodyPart htmlBodyPart = new BodyPart
            {
                ContentType = BodyContentType.HTML,
                Charset = "utf-8",
                Content = dto.BodyAmp
            };
            BodyPart plainTextBodyPart = new BodyPart
            {
                ContentType = BodyContentType.PlainText,
                Charset = "utf-8",
                Content = dto.BodyAmp
            };
            emailData.Content.Body.Add(htmlBodyPart);
            emailData.Content.Body.Add(plainTextBodyPart);
            emailData.Content.From = dto.From;
            emailData.Content.Subject = dto.Subject;
            
            // Send Bulk Emails
            _logger.LogInformation("Sending email");
            var result = apiInstance.EmailsTransactionalPost(emailData);
            _logger.LogInformation("Sent mail with {@MessageId}", result.MessageID);
        }
        catch (ApiException  ex)
        {
            _logger.LogError(ex, "Exception when calling EmailsApi.EmailsPost: {@Message}",  ex.Message);
            _logger.LogInformation("Status Code: {@StatusCode} ", ex.ErrorCode);
            _logger.LogInformation(ex.StackTrace);
        }
    }
    
    private async Task SendEmailAsync(MailObject model)
    {
        _logger.LogInformation("Entered the SendEmailAsync method");
        try
        {
            _logger.LogInformation("Sending email");
            var content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            _logger.LogInformation("Mail info sent is: {Info}", model);
            var result = await _client.PostAsync("/sendMail", content);
            if (result.IsSuccessStatusCode)
            {
                var con = result.Content.ReadAsStringAsync();
                _logger.LogInformation("Mail sending was successful");
            }
            var response = result.Content.ReadAsStringAsync();
            _logger.LogInformation("Mail sending was not successful with message: {Message}", response);
        }
        catch (ApiException  ex)
        {
            _logger.LogError(ex, "Exception when calling EmailsApi.EmailsPost: {@Message}",  ex.Message);
            _logger.LogInformation("Status Code: {@StatusCode} ", ex.ErrorCode);
            _logger.LogInformation(ex.StackTrace);
        }
    }
}