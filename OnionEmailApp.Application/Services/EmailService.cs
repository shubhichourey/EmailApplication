//using System.Net;
//using System.Net.Mail;
//using System.Threading.Tasks;
//using OnionEmailApp.Application.Interfaces;

//namespace OnionEmailApp.Application.Services  


////namespace OnionEmailApp.Infrastructure.Services
//{
//    public class EmailSender : IEmailSender
//    {
//        public async Task SendEmailAsync(string recipient, string subject, string body)
//        {
//            var smtpClient = new SmtpClient("smtp.gmail.com")
//            {
//                Port = 587,
//                Credentials = new NetworkCredential("your-email@gmail.com", "your-email-password"),
//                EnableSsl = true
//            };

//            var mailMessage = new MailMessage
//            {
//                From = new MailAddress("your-email@gmail.com"),
//                Subject = subject,
//                Body = body,
//                IsBodyHtml = true
//            };

//            mailMessage.To.Add(recipient);

//            await smtpClient.SendMailAsync(mailMessage);
//        }
//    }
//}

using System.Threading.Tasks;
using OnionEmailApp.Application.Interfaces;
using OnionEmailApp.Domain.Interfaces;

namespace OnionEmailApp.Application.Services
{
    public class EmailService : IEmailService
    {
        private readonly IEmailRepository _emailRepository;
        private readonly IEmailSender _emailSender;

        public EmailService(IEmailRepository emailRepository, IEmailSender emailSender)
        {
            _emailRepository = emailRepository;
            _emailSender = emailSender;
        }

        public async Task SendEmailAsync(string recipient, string subject, string body)
        {
            bool result = await _emailSender.SendEmailAsync(recipient, subject, body);
        }
        //new added code
        public async Task SendEmailToAllAsync(string subject, string body)
        {
            var recipients = await _emailRepository.GetAllEmailsAsync();

            foreach (var recipient in recipients)
            {
                await _emailSender.SendEmailAsync(recipient, subject, body);
            }
        }
    }
}

