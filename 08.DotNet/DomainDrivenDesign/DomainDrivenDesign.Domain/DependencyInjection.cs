using FluentEmail.MailKitSmtp;
using Microsoft.Extensions.DependencyInjection;

namespace DomainDrivenDesign.Domain;

public static class DependencyInjection
{
    public static IServiceCollection AddDomain(this IServiceCollection services)
    {
        services
            .AddFluentEmail("mfurkana067@gmail.com")
            .AddMailKitSender(new SmtpClientOptions()
            {
                Server = "localhost",
                Port = 2525,
            });
        return services;
    }
}
