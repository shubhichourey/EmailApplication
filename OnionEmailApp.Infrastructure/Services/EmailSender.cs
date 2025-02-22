//using System.Net;
//using System.Net.Mail;
//using System.Threading.Tasks;
//using OnionEmailApp.Application.Interfaces;

//namespace OnionEmailApp.Infrastructure.Services
//{
//    public class EmailSender : IEmailSender
//    {
//        public async Task SendEmailAsync(string recipient, string subject, string body)
//        {
//            using (var client = new SmtpClient("smtp.gmail.com", 587))
//            {
//                client.Credentials = new NetworkCredential("your-email@gmail.com", "your-app-password");
//                client.EnableSsl = true;

//                var mailMessage = new MailMessage("your-email@gmail.com", recipient, subject, body);
//                await client.SendMailAsync(mailMessage);
//            }
//        }
//    }
//}

using System.Net.Mail;
using System.Threading.Tasks;
using OnionEmailApp.Application.Interfaces;

namespace OnionEmailApp.Infrastructure.Services
{
    public class EmailSender : IEmailSender
    {
        public async Task<bool> SendEmailAsync(string recipient, string subject, string body)
        {
            try
            {
                using var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new System.Net.NetworkCredential("your-email@gmail.com", "your-password"),
                    EnableSsl = true
                };

                var mailMessage = new MailMessage
                {
                    From = new MailAddress("your-email@gmail.com"),
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = true
                };
                mailMessage.To.Add(recipient);

                await smtpClient.SendMailAsync(mailMessage);
                return true;  // ✅ Return true if successful
            }
            catch
            {
                return false; // ❌ Return false if failed
            }
        }
    }
}

