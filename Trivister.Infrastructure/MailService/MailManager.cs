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
using FluentEmail.Core;
using FluentEmail.Core.Models;
using SendGrid.Helpers.Errors.Model;

namespace Trivister.Infrastructure.MailService;

public sealed class MailManager: IMailManager
{
    private static MailOptions _mailOptions;
    private static SendGridOption _sndGridOptions;
    private readonly HttpClient _client;
    private readonly ILogger<MailManager> _logger;
    private readonly IFluentEmail _fluentEmail;

    public MailManager(
        IOptions<MailOptions> mailOptions,
        IOptions<SendGridOption> sndGridOptions,
        HttpClient client, 
        ILogger<MailManager> logger, 
        IFluentEmail fluentEmail)
    {
        _client = client;
        _logger = logger;
        _mailOptions = mailOptions.Value;
        _sndGridOptions = sndGridOptions.Value;
        _fluentEmail = fluentEmail;
    }

    public async Task BuildSignUpMessage(string otp, string to, string name)
    {
        _logger.LogInformation("Inside the BuildSignUpMessage method");
        try
        {
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
    
    public async Task BuildAdminUserInvitationMessage(string to, string adminName, string password)
    {
        var builder = new MailBuilder();
        var mailObject = builder.WithToEmail(to)
            .WithFromEmail(_mailOptions.From)
            .WithOTPSubject(_mailOptions.AdminWelcomeSubject)
            .WithAdminUserInvitationMessage(adminName, password)
            .BuildOtpMailDto(); 
        await SendEmailAsync(mailObject);
    }

    public async Task BuildMessageToAdminOnCustomerRegistrationMessage(string adminEmail, string adminName, string customerFullName,
        string customerEmail, string customerPhone, string dateOfRegistration)
    {
        var builder = new MailBuilder();
        var mailObject = builder.WithToEmail(adminEmail)
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
    
    //private async Task SendEmailAsync(MailObject model)
    //{
    //    _logger.LogInformation("Entered the SendEmailAsync method");
    //    try
    //    {
    //        _logger.LogInformation("Sending email");
    //        var content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
    //        _logger.LogInformation("Mail info sent is: {Info}", model);
    //        var result = await _client.PostAsync("/sendMail", content);
    //        if (result.IsSuccessStatusCode)
    //        {
    //            var con = result.Content.ReadAsStringAsync();
    //            _logger.LogInformation("Mail sending was successful");
    //        }
    //        var response = result.Content.ReadAsStringAsync();
    //        _logger.LogInformation("Mail sending was not successful with message: {Message}", response);
    //    }
    //    catch (ApiException  ex)
    //    {
    //        _logger.LogError(ex, "Exception when calling EmailsApi.EmailsPost: {@Message}",  ex.Message);
    //        _logger.LogInformation("Status Code: {@StatusCode} ", ex.ErrorCode);
    //        _logger.LogInformation(ex.StackTrace);
    //    }
    //}

    public async Task SendEmailAsync(MailObject model)
    {
        try
        {
            var fluentEmail = _fluentEmail.SetFrom(_sndGridOptions.DefaultFromEmail).Subject(model.Subject).To(model.To);

            var response = await fluentEmail.Tag(Guid.NewGuid().ToString()).UsingTemplate(model.BodyAmp, model).SendAsync();


            if (response.Successful)
            {
                await Task.CompletedTask;
                return;
            }

            _logger.LogInformation("Mail sending was not successful with message: {Message}", response);
            await Task.CompletedTask;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occured while sending mail");
            var errorResponse = JsonConvert.DeserializeObject<SendGridErrorResponse>(ex.Message);
            switch (errorResponse!.ErrorHttpStatusCode)
            {
                case 401:
                    _logger.LogError(ex, errorResponse.SendGridErrorMessage);
                    break;
                case 400:
                    _logger.LogError(ex, errorResponse.SendGridErrorMessage);
                    break;
                case 429:
                    _logger.LogError(ex, errorResponse.SendGridErrorMessage);
                    break;
                case 500:
                    _logger.LogError(ex, errorResponse.SendGridErrorMessage);
                    break;
            }
        }

        await Task.CompletedTask;
    }

    //private IEnumerable<FluentEmail.Core.Models.Attachment> AttachFiles(ICollection<MailAttachmentRequest> attachments)
    //{
    //    if (!attachments.Any()) return Enumerable.Empty<FluentEmail.Core.Models.Attachment>();

    //    return (from attachment in attachments
    //            let file = FileHelper.ConvertToMailFile(attachment.Base64)
    //            let byteArray = FileHelper.ConvertToByte(attachment.Base64)
    //            select new FluentEmail.Core.Models.Attachment
    //            {
    //                Filename = attachment.Name,
    //                Data = FileHelper.GetMemoryStream(byteArray),
    //                ContentType = attachment.Extension,
    //                IsInline = true
    //            }).ToList();
    //}
}