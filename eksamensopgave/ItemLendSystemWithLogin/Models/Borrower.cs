using System.ComponentModel.DataAnnotations;
using System.Drawing.Drawing2D;

namespace ItemLendSystemWithLogin.Models
{
    public class Borrower
    {
        [Key]
        public int BID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Mobile { get; set; }

        [Required]
        public string Email { get; set; }

        public virtual ICollection<Lend>? Lends { get; set; }
    }
}

