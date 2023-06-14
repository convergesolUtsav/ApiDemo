using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.Domain.Entities
{
    public class Exam
    {
        [Key]
        public int ExamId { get; set; }
        [Required]
        public string Title { get; set;}
        public string Description { get; set;}
        public DateTime StartTime { get; set; }
        public ICollection<ExamResults> ExamResults { get; set; }
        public ICollection<QuestionAns> QuestionAns { get; set; }   

    }

}
