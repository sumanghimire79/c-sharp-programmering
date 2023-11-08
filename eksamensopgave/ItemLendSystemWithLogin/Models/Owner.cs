using System.ComponentModel.DataAnnotations;

namespace ItemLendSystemWithLogin.Models
{
    public class Owner
    {
        [Key]
        public int OID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        public string? Mobile { get; set; }
        public virtual ICollection<Item>? Items { get; set; }
    }
}