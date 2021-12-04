using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeProject.Models
{
    public class User
    {
        [Key]
        [Display(Name = "User Id")]
        public string UserId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Phone No")]
        public int PhoneNo { get; set; }

        public string CategoryId { get; set; }

        [NotMapped]
        [ForeignKey("CategoryId")]
        public virtual ExpenseCategory ExpenseCategories { get; set; }

        public string ExpenseId { get; set; }

        [NotMapped]
        [ForeignKey("ExpenseId")]
        public virtual Expense Expenses { get; set; }
    }
}
