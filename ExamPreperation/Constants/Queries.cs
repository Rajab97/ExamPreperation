using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreperation.Constants
{
    public static class Queries
    {
        public static class UserQueries
        {
            public const string Insert = "INSERT INTO [Users]([UserName],[Password],[Role]) values(@userName,@password,@role)";
            public const string Select = "SELECT * FROM [Users] ORDER BY [UserName]";
            public const string Delete = "DELETE FROM [Users] WHERE [Id] = @id";
        }

        public static class ExamQueries
        {
            public const string Insert = "INSERT INTO Exams([Name],[PassingScore]) VALUES (@name,@passingScore)";
            public const string Select = "SELECT [Id],[Name],[PassingScore] FROM Exams ORDER BY [Name]";
            public const string Delete = "DELETE FROM Exams WHERE [Id] = @id";
        }
        public static class ExamQuestionQueries
        {
            public const string Insert = "INSERT INTO ExamQuestions([Name],[Score],[ExamId]) VALUES (@name,@score,@examId)";
            public const string Select = @"SELECT eq.[Id],eq.[Name],[Score],[ExamId],e.[Name] as 'ExamName' FROM ExamQuestions eq
                                            LEFT JOIN Exams e on eq.ExamId = e.Id
                                            ORDER BY [ExamId],[Name]";
            public const string Delete = "DELETE FROM ExamQuestions WHERE [Id] = @id";
            public const string SelectExamQuestions = "SELECT [Id],[Name],[Score],[ExamId] FROM ExamQuestions WHERE ExamId = @examId";
        }

        public static class QuestionAnswersQueries
        {
            public const string Insert = "INSERT INTO QuestionAnswers([Name],[IsCorrectAnswer],[QuestionId]) VALUES (@name,@isCorrectAnswer,@questionId)";
            public const string SelectAll = "SELECT [Id],[Name],[IsCorrectAnswer],[QuestionId] FROM [dbo].[QuestionAnswers] ORDER BY [Name]";
            public const string SelectQuestionAnswers = "SELECT [Id],[Name],[IsCorrectAnswer],[QuestionId] FROM [dbo].[QuestionAnswers] WHERE [QuestionId] = @questionId ORDER BY [Name]";
            public const string Delete = "DELETE FROM [dbo].[QuestionAnswers] WHERE [Id] = @id";
        }
    }
}
