using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.Domain.Entities
{
    public class Student
    {
        [Key]
        public int StudentId {  get; set; }
        [Required]
        public string StudentName { get; set; }
        [Required]
        public string  UserName { get; set; }
        [Required]
        public string UserEmail { get; set; }
        [Required]
        public string  Password { get; set; }
        [Required]
        public string PhoneNumber { get; set; }



    }
}
