using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

namespace ILS.Models
{
    public class Lend
    {

        [Key]
        public int LID { get; set; }
        [ForeignKey("Item")]
        public int IID { get; set; }

        [DataType(DataType.Date)]
        public DateTime LendingDate { get; set; }
        [CheckValidLendPeriod]
        public int LendingDays { get; set; }
        public double TotalAmount { get; set; }
        public string? Note { get; set; }
        public virtual Item? Item { get; set; }
       
      



    }
}