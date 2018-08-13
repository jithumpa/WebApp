using System.ComponentModel.DataAnnotations;

namespace WebApp.Web.ViewModels.Login
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}