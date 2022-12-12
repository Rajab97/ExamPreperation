using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreperation.Models.Entites
{
    public class QuestionAnswer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsCorrectAnswer { get; set; }
        public int QuestionId { get; set; }
    }
}
