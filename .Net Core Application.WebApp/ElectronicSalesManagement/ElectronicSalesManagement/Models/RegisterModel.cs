using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicSalesManagement.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Please enter your account name!")]
        [Display(Name = "USERNAME")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter your password!")]
        [DataType(DataType.Password)]
        [Display(Name = "PASSWORD")]
        [StringLength(100, ErrorMessage = "{0} must be at least {2} characters long and maximum {1} characters long.", MinimumLength = 6)]
        //[Compare("password", ErrorMessage = "Mật khẩu và mật khẩu xác nhận không khớp.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password is required")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password and Confirmation Password must match.")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Please enter your email!")]
        public string Email { get; set; }

        public string Status { get; set; }
        public string DateActive { get; set; }
    }
}
