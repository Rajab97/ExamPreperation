using ExamPreperation.Models.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreperation.Repositories.Abstracts
{
    public interface IQuestionAnswerRepository
    {
        IEnumerable<QuestionAnswer> GetAll();
        IEnumerable<QuestionAnswer> GetQuestionAnswers(int questionId);
        void Delete(int answerId);
        void Add(QuestionAnswer quesetionAnswer);
    }
}
