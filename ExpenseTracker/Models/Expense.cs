using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeProject.Models
{
    public class Expense
    {
        [Key]
        [Display(Name ="Expense Id")]
        public string ExpenseId { get; set; }

        public string CategoryId { get; set; }

        [NotMapped]
        [ForeignKey("CategoryId")]
        [Display(Name = "Expense Category")]
        [Column(TypeName = "varchar(50)")]
        public virtual ExpenseCategory ExpenseCategories { get; set; }

        [Required]
        

        //public List<ExpenseCategory> ExpenseCategories { get; set; }

        //public string ExpenseCategory { get; set; }

        [Display(Name = "Date of Expense")]
        public DateTime DateOfExpense { get; set; }

        [Required]
        public int Amount { get; set; }

        public string UserId { get; set; }

        [NotMapped]
        [ForeignKey("UserId")]
        public virtual User Users { get; set; }

    }
}
