using Microsoft.AspNetCore.Mvc;
using OnionEmailApp.Domain.Interfaces;
using System.Threading.Tasks;

namespace OnionEmailApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IEmailRepository _emailRepository;
       /* public IActionResult Compose()
        {
            return View(); // This will return the Compose.cshtml view
        }
       */
        public EmailController(IEmailRepository emailRepository)
        {
            _emailRepository = emailRepository;
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAllEmails()
        {
            var emails = await _emailRepository.GetAllEmailsAsync();
            return Ok(emails);
        }
    }
}
