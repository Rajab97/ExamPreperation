using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreperation.Models.Entites
{
    public class ExamQuestion
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }
        public int ExamId { get; set; }
    }
}
