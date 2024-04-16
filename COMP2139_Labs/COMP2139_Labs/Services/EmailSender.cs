using SendGrid.Helpers.Mail;
using SendGrid;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Identity.Client;

public class EmailSender : IEmailSender
{

    private readonly string _sendGridKey;

    public EmailSender(IConfiguration configuration)
    {
        _sendGridKey = configuration["SendGrid:ApiKey"];
    }

    public async Task SendEmailAsync(string email, string subject, string htmlMessage)
    {
        var client = new SendGridClient(_sendGridKey);
        var from = new EmailAddress("nisarg.bhatti@georgebrown.ca", "ProjectCollabrator");
        var to = new EmailAddress(email);
        var msg = MailHelper.CreateSingleEmail(from, to, subject, "", htmlMessage);
        await client.SendEmailAsync(msg);

    }


}