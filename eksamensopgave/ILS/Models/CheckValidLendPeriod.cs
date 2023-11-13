using System.ComponentModel.DataAnnotations;

namespace ILS.Models
{
    public class CheckValidLendPeriod:ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            int day = (int)value;
            if (day < 1)
            {
                ErrorMessage = "No item can be lended less than 1 day !!!";
                return false;
            }
            else if (day > 7)
            {
                ErrorMessage = "No item can be lended more than a week, consider buying your self !!!";
                return false;

            }
            else
            {
                return true;
            }
        }
    }
}
