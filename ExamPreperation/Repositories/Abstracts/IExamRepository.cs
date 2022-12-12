using ExamPreperation.Models.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreperation.Repositories.Abstracts
{
    public interface IExamRepository
    {
        IEnumerable<Exam> GetAll();
        void SeedDefaultData();
        void Add(Exam exam);
        void Delete(int examId);
    }
}
