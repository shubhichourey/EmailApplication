using System.Collections.Generic;
using System.Threading.Tasks;
using OnionEmailApp.Domain.Entities;

namespace OnionEmailApp.Domain.Interfaces
{
    public interface IEmailRepository
    {
        Task AddEmailAsync(Email email);  // Add Email
      
       // Task<List<Email>> GetAllEmailsAsync();  // ✅ Add this method

        Task<List<string>> GetAllEmailsAsync();
    }
}
