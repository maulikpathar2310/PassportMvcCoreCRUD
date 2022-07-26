using Microsoft.AspNetCore.Identity.UI.Services;
using System.Net;
using System.Net.Mail;

namespace PassportMvcCoreCRUD.Services
{
    public class EmailSender : IEmailSender
    {
        public EmailSender()
        {

        }

        //return Task.CompletedTask;
        //SmtpClient client = new SmtpClient
        //{
        //    Port = 587,
        //    Host = "smtp.gmail.com", //or another email sender provider
        //    EnableSsl = true,
        //    DeliveryMethod = SmtpDeliveryMethod.Network,
        //    UseDefaultCredentials = false,
        //    Credentials = new NetworkCredential("your email sender", "password")
        //};

        //return client.SendMailAsync("your email sender", email, subject, htmlMessage);            



        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            string fromMail = "maulikpathar2310@gmail.com";
            string fromPassword = "maulik2310";

            MailMessage message = new MailMessage();
            message.From = new MailAddress(fromMail);
            message.Subject = subject;
            message.To.Add(new MailAddress(email));
            message.Body = "<html><body> " + htmlMessage + " </body></html>";
            message.IsBodyHtml = true;

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(fromMail, fromPassword),
                EnableSsl = true,
            };
            smtpClient.Send(message);
        }
    }
}
