using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeProject.Models
{
    public class ExpenseCategory
    {
        [Key]
        [Display(Name ="Category Id")]
        public string CategoryId { get; set; }

        [Required]
        [Display(Name = "Expense Categories")]
        [Column(TypeName = "varchar(50)")]
        public string ExpenseCategories { get; set; }
    }
}
