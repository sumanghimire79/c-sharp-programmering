using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ItemLendSystemWithLogin.Models
{
    public class Lend
    {
        [Key]
        public int LID { get; set; }
        [ForeignKey("Item")]
        public int IID { get; set; }
        [ForeignKey("Borrower")]
        public int BID { get; set; }
        public int Quantity { get; set; }
        [DataType(DataType.Date)]
        public DateTime LendingDate { get; set; }
        [CheckValidLendPeriod]
        public int LendingDays { get; set; }
        public string? Note { get; set; }
        public virtual Item? Item { get; set; }
        public virtual Borrower? Borrower { get; set; }
    }
}