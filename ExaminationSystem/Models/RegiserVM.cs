using System.ComponentModel.DataAnnotations;

namespace ExaminationSystem.Models
{
    public class RegiserVM
    {
        [Required(ErrorMessage = "UserName Is Required")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Email Is Required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Phone Number Is Required")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Password Is Required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Confirm Password Is Required")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}
