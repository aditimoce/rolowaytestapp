using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RolowayTestApp.Models
{
    public class Income
    {
        public int IncomeID { get; set; }

        [Display(Name = "Income Category")]
        [DataType(DataType.Text)]
        public string IncomeCategory { get; set; }

        [Display(Name = "Income Amount")]
        [DataType(DataType.Currency)]
        public double IncomeAmount { get; set; }

        [Display(Name = "Income Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime IncomeTime { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}