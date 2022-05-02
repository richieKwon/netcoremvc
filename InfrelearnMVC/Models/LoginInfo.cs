using System.ComponentModel.DataAnnotations;

namespace InfrelearnMVC.Models
{
    public class LoginInfo
    {
        [Required(ErrorMessage = "Type down ID!")]
        [MinLength(6, ErrorMessage = "The length of your ID must be more than 6")]
        [Display(Name = "UserId")] 
        public string UserId { get; set; }
        
        [Required(ErrorMessage = "Type down PW!")]
        [MinLength(6, ErrorMessage = "The length of your PW must be more than 6")]
        [Display(Name = "Password")] 
        public string Password { get; set; }
    }
}   