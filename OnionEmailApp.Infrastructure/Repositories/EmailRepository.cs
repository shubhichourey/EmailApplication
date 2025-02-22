//using System.Collections.Generic;
//using System.Threading.Tasks;
//using Microsoft.EntityFrameworkCore;
//using OnionEmailApp.Domain.Entities;
//using OnionEmailApp.Domain.Interfaces;
//using OnionEmailApp.Infrastructure.Persistence; // Ensure correct reference

//namespace OnionEmailApp.Infrastructure.Repositories
//{
//    public class EmailRepository : IEmailRepository
//    {
//        private readonly AppDbContext _context;

//        public EmailRepository(AppDbContext context)
//        {
//            _context = context;
//        }

//        public async Task AddEmailAsync(Email email)
//        {
//            await _context.Emails.AddAsync(email);
//            await _context.SaveChangesAsync();
//        }

//        // ✅ Implement the missing method
//        public async Task<List<Email>> GetAllEmailsAsync()
//        {
//            return await _context.Emails.ToListAsync();
//        }
//    }
//}


using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnionEmailApp.Domain.Entities;
using OnionEmailApp.Domain.Interfaces;
using OnionEmailApp.Infrastructure.Persistence;

namespace OnionEmailApp.Infrastructure.Repositories
{
    public class EmailRepository : IEmailRepository
    {
        private readonly AppDbContext _context;

        public EmailRepository(AppDbContext context)
        {
            _context = context;
        }

        public Task AddEmailAsync(Email email)
        {
            throw new NotImplementedException();
        }

        // ✅ Implement the missing method
               public async Task<List<Email>> GetAllEmailsAsync()
               {
                   return await _context.Emails.ToListAsync();
               }

        Task<List<string>> IEmailRepository.GetAllEmailsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
