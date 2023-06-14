using System.ComponentModel.DataAnnotations;

namespace ExaminationSystem.Models
{
    public class SigninVM
    {
        [Required(ErrorMessage = "EmailId Or UserNam Is Required")]
        public string EmailOrUserName { get; set; }
        [Required(ErrorMessage = "Password Is Required")]
        public string Password { get; set; }

        public bool RememberMe { get; set; }

    }
}
