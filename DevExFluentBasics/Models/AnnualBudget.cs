using System.ComponentModel.DataAnnotations;

namespace DevExFluentBasics.Models
{
    public class AnnualBudget
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name="Annual Budget Year")]
        public string Name { get; set; }  // Annual Budget name, e.g., 2025 Budget

        public virtual ICollection<Department> Departments { get; set; }
    }
}

 
