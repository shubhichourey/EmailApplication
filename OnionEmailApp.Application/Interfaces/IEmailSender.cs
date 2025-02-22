using System.Threading.Tasks;

namespace OnionEmailApp.Application.Interfaces
{
    public interface IEmailSender
    {
        Task<bool> SendEmailAsync(string recipient, string subject, string body);
    }
}
