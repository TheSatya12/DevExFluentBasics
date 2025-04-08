using System.ComponentModel.DataAnnotations;

namespace DevExFluentBasics.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Department Name")]
        public string Name { get; set; }

        public decimal Budget { get; set; }
        public decimal Expense { get; set; }
        public decimal Remaining => Budget - Expense;
        public string Month { get; set; }   

        public int AnnualBudgetId { get; set; }
        public virtual AnnualBudget AnnualBudget { get; set; }
    }
}
