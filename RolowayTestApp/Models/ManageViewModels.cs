using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

namespace RolowayTestApp.Models
{

    public class IndexViewModel
    {
        public bool HasPassword { get; set; }
        public IList<UserLoginInfo> Logins { get; set; }
        public string PhoneNumber { get; set; }
        public bool TwoFactor { get; set; }
        public bool BrowserRemembered { get; set; }

    }

    public class AddExpenseViewModel
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

    public class AddIncomeViewModel
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


    public class SetPasswordViewModel
    {
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    public class ChangePasswordViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Current password")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    
}