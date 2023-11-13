using System.ComponentModel.DataAnnotations;

namespace ILS.Models
{
    public class ContactForm
    {
        [Key]
        public int CFID { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        [StringLength(300, MinimumLength = 2, ErrorMessage = "Minimum 2 and Maximum 300 characters")]
        public string? Message { get; set; }
    }
}
