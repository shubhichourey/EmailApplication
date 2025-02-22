using System.ComponentModel.DataAnnotations;

namespace OnionEmailApp.Models
{
    public class EmailModel
    {
        [Required]
        public string Subject { get; set; }

        [Required]
        public string Message { get; set; }
    }
}


