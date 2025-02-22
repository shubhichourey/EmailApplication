using System.Net.Mail;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using OnionEmailApp.Models;

namespace OnionEmailApp.Controllers
{
    [Route("Email")]
    public class EmailController : Controller
    {
        [Route("Compose")]
        public IActionResult Compose()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SendEmail(EmailModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("Compose", model); // Return the form if validation fails
            }

            try
            {
                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("shubhi010503@gmail.com", "iaym tjvg xzlu snre"),
                    EnableSsl = true,
                };

                var mailMessage = new MailMessage
                {
                    From = new MailAddress("shubhi010503@gmail.com"),
                    Subject = model.Subject,
                    Body = model.Message,
                    IsBodyHtml = true,
                };

                // Add recipient(s) from your database (replace with actual logic)
                mailMessage.To.Add("samiksha24yadav@gmail.com");
                mailMessage.To.Add("shubhichourey010@gmail.com");
                mailMessage.To.Add("gauravgautam0105@gmail.com");


                await smtpClient.SendMailAsync(mailMessage);

                ViewBag.Message = "Email sent successfully!";
                return View("Compose"); // Show the compose form again
            }
            catch (System.Exception ex)
            {
                ViewBag.Error = "Failed to send email: " + ex.Message;
                return View("Compose");
            }
        }

    }
}

