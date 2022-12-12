using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreperation.Models.DTOs
{
   public  class ExamQuestionDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }
        public int ExamId { get; set; }
        public string ExamName { get; set; }
    }
}
