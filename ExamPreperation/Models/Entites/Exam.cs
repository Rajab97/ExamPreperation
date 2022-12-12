using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreperation.Models.Entites
{
    public class Exam
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PassingScore { get; set; }
    }
}
