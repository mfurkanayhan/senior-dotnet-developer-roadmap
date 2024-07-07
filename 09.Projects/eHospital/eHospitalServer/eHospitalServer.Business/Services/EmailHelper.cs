using GenericEmailService;

namespace eHospitalServer.Business.Services;
public static class EmailHelper
{
    public static async Task<string> SendEmailAsync(string email, string subject, string body)
    {
        EmailConfigurations emailConfigurations = new(
            "smtp.gmail.com",
            "Your Password",
            587,
            false,
            true
            );

        EmailModel<Stream> emailModel = new(
            emailConfigurations,
            "Your Email",
            new List<string> { email },
            subject,
            body,
            null
        );

        string emailSendResponse = await EmailService.SendEmailWithMailKitAsync(emailModel);

        return emailSendResponse;
    }
}
