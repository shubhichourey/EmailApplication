//using System.Threading.Tasks;

//namespace OnionEmailApp.Application.Interfaces
//{
//    public interface IEmailService
//    {
//        Task<bool> SendEmailToAllAsync(string subject, string message);
//    }
//}


using System.Threading.Tasks;

namespace OnionEmailApp.Application.Interfaces
{
    public interface IEmailService
    {
        Task SendEmailAsync(string recipient, string subject, string body);

        Task SendEmailToAllAsync( string subject, string body);
    }
}
