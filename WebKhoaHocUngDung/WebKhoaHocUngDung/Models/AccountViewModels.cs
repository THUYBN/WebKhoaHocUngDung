using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebKhoaHocUngDung.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Remember this browser?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    public class CreateUser
    {
        [Required(ErrorMessage = "Không được để trống")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Không được để trống")]
        [StringLength(100, ErrorMessage = "{0} phải dài tối thiểu 6 kí tự và phải có chữ cái thường, in hoa, số và 1 kí tự đặc biệt", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "Xác nhận mật khẩu và mật khẩu không trùng khớp")]
        public string ConfirmPassword { get; set; }
    }

    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Không được để trống")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Không được để trống")]
        [StringLength(100, ErrorMessage = "{0} phải dài tối thiểu 6 kí tự và phải có chữ cái thường, in hoa, số và 1 kí tự đặc biệt", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "Xác nhận mật khẩu và mật khẩu không trùng khớp")]
        public string ConfirmPassword { get; set; }
        public int MaHS { get; set; }

        [Required(ErrorMessage = "Không được để trống")]
        [StringLength(50)]
        public string HoTen { get; set; }

        [Required(ErrorMessage = "Không được để trống")]
        [DataType(DataType.Date)]
        public DateTime? NgaySinh { get; set; }

        [Required(ErrorMessage = "Không được để trống")]
        [StringLength(3)]
        public string GioiTinh { get; set; }

        [Required(ErrorMessage = "Không được để trống")]
        public int? Khoi { get; set; }

        [Required(ErrorMessage = "Không được để trống")]
        [StringLength(10)]
        public string SDT { get; set; }

        [Required(ErrorMessage = "Không được để trống")]
        [StringLength(10)]
        public string SDTPH { get; set; }

        [Required(ErrorMessage = "Không được để trống")]
        [StringLength(50)]
        public string DiaChi { get; set; }
        
        public DateTime? NgayVaoHoc { get; set; }

        public bool? TinhTrang { get; set; }
    }

    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
