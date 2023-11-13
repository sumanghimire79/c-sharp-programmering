using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static ILS.Models.ItemCategories;

namespace ILS.Models
{
    public class Item
    {
        [Key]
        public int IID { get; set; }
       
        [Required]
        public string? Name { get; set; }
        [Required]
        public double UnitPrice { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Minimum 3 and Maximum 30 characters")]
        public string? Description { get; set; }
        [Required]
        public ItemCategory? Category { get; set; }
        public virtual ICollection<Lend>? Lends { get; set; }

       
    }
}

