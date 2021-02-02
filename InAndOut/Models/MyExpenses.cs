using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace InAndOut.Models
{
    public class MyExpenses : BaseEntity
    {
        [DisplayName("Expense")]
        [Required(ErrorMessage = "Please enter a Expense Name")]
        public string ExpenseName { get; set; }
        [DisplayName("Amount")]
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a number greater than 0")]
        public int ExpenseCost { get; set; }
    }
}