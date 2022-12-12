using ExamPreperation.Models.DTOs;
using ExamPreperation.Models.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreperation.Repositories.Abstracts
{
    public interface IExamQuestionRepository
    {
        IEnumerable<ExamQuestion> GetExamQuestions(int examId);
        IEnumerable<ExamQuestionDTO> GetAll();
        void Delete(int examQuestionId);
        int Add(ExamQuestion examQuestion);
    }
}
