namespace Trivister.ApplicationServices.Abstractions;

public interface IMailManager
{
    Task BuildSignUpMessage(string otp, string to, string name);
    Task BuildForgotPasswordMessage(string customerName, string message, string to);
    Task BuildResetPasswordMessage(string confirmationLink, string to);
    Task BuildPasswordSuccessfullyResetMessage(string to, string name);
    Task BuildWelcomeMessage(string name, string to);
    Task BuildAdminUserInvitationMessage(string to, string adminName);
    Task BuildMessageToAdminOnCustomerRegistrationMessage(string to, string adminName, string customerFullName,
        string customerEmail, string customerPhone, string dateOfRegistration);
}