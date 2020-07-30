using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RolowayTestApp.Models
{
    

    public class Expense
    {
        public int ExpenseID { get; set; }

        [Display(Name = "Expense Category")]
        [DataType(DataType.Text)]
        public string ExpenseCategory { get; set; }

        [Display(Name = "Expense Amount")]
        [DataType(DataType.Currency)]
        public double ExpenseAmount { get; set; }

        [Display(Name = "Expense Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ExpenseDate { get; set; }

        public virtual ApplicationUser User { get; set; }

    }
}