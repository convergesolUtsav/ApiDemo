using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.Domain.Entities
{
    public class ExamResults
    {
        [Key]
        public int ExamResultId { get; set; }
        public int StudentId { get; set; }
        [ForeignKey("StudentId")]
        public Student students { get; set; }
        public int? ExamId { get; set; }
        [ForeignKey("ExamId")]
        public Exam Exam { get; set; }

    }
}
