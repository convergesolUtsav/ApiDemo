using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.Domain.Entities
{
    public  class QuestionAns
    {
        [Key]
        public int QuestionAnsId { get; set; }
        public int ExamId { get; set; }
        [ForeignKey("ExamId")]
        public Exam exam { get; set; }
        public string Question { get; set; }
        public int Answer { get; set; }
        public string  Option1 { get; set; }
        public string Option2 { get; set; }
        public string  Option3 { get; set; }
        public string Option4 { get; set; }
        public ICollection<ExamResults> ExamResults { get; set; }
    }
}
