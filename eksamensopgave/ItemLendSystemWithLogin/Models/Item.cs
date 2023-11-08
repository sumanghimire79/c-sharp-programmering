using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ItemLendSystemWithLogin.Models
{
    public class Item
    {

        public enum ItemCategory
        {
            Tools,
            Kitchen,
            Tents,
            Others
        }

        [Key]
        public int IID { get; set; }

        [ForeignKey("Owner")]
        public int OID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public double UnitPrice { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Minimum 3 and Maximum 30 characters")]
        public string Description { get; set; }
        [Required]
        public ItemCategory? Category { get; set; }

        public virtual Owner? Owner { get; set; }
        public virtual ICollection<Lend>? Lends { get; set; }
    }
}