using ExamPreperation.Constants;
using ExamPreperation.Models.DTOs;
using ExamPreperation.Models.Entites;
using ExamPreperation.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreperation.Repositories.Implementations
{
    public class QuestionAnswerRepository : IQuestionAnswerRepository
    {
        private readonly string connectionString;
        public QuestionAnswerRepository()
        {
            connectionString = ConfigurationManager.AppSettings[AppConfigKeys.ConnectionString];
        }
        public IEnumerable<QuestionAnswer> GetAll()
        {
            try
            {
                List<QuestionAnswer> examQuestions = new List<QuestionAnswer>();
                using (SqlConnection connection =
                new SqlConnection(connectionString))
                {
                    // Create the Command and Parameter objects.
                    SqlCommand command = new SqlCommand(Queries.QuestionAnswersQueries.SelectAll, connection);
                    // Open the connection in a try/catch block.
                    // Create and execute the DataReader, writing the result
                    // set to the console window.
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var user = new QuestionAnswer()
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            IsCorrectAnswer = reader.GetBoolean(2),
                            QuestionId = reader.GetInt32(3),
                        };
                        examQuestions.Add(user);
                    }
                    reader.Close();
                }
                return examQuestions;
            }
            catch (ApplicationException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error occured while reading question answers", ex);
            }
        }
        public IEnumerable<QuestionAnswer> GetQuestionAnswers(int questionId)
        {
            try
            {
                List<QuestionAnswer> examQuestions = new List<QuestionAnswer>();
                using (SqlConnection connection =
                new SqlConnection(connectionString))
                {
                    // Create the Command and Parameter objects.
                    SqlCommand command = new SqlCommand(Queries.QuestionAnswersQueries.SelectQuestionAnswers, connection);
                    command.Parameters.AddWithValue("@questionId",questionId);
                    // Open the connection in a try/catch block.
                    // Create and execute the DataReader, writing the result
                    // set to the console window.
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var user = new QuestionAnswer()
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            IsCorrectAnswer = reader.GetBoolean(2),
                            QuestionId = reader.GetInt32(3),
                        };
                        examQuestions.Add(user);
                    }
                    reader.Close();
                }
                return examQuestions;
            }
            catch (ApplicationException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error occured while reading question answers", ex);
            }
        }
        public void Delete(int answerId)
        {
            try
            {
                var questionanswers = GetAll();
                if (!questionanswers.Any(m => m.Id == answerId))
                    throw new ApplicationException("Question answer not found");

                using (SqlConnection connection =
                new SqlConnection(connectionString))
                {
                    // Create the Command and Parameter objects.
                    SqlCommand command = new SqlCommand(Queries.QuestionAnswersQueries.Delete, connection);
                    command.Parameters.AddWithValue("@id", answerId);
                    // Open the connection in a try/catch block.
                    // Create and execute the DataReader, writing the result
                    // set to the console window.
                    connection.Open();
                    var count = command.ExecuteNonQuery();
                    if (count < 1)
                        throw new ApplicationException("Error happended while deleting question answer");
                }
            }
            catch (ApplicationException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error occured while delete question answer", ex);
            }
        }
        public void Add(QuestionAnswer quesetionAnswer)
        {
            try
            {
                var examQuestions = GetAll();
                if (examQuestions.Any(m => m.Name == quesetionAnswer.Name && m.QuestionId == quesetionAnswer.QuestionId))
                    throw new ApplicationException("Question answer with same name already exist");

                using (SqlConnection connection =
                new SqlConnection(connectionString))
                {
                    // Create the Command and Parameter objects.
                    SqlCommand command = new SqlCommand(Queries.QuestionAnswersQueries.Insert, connection);
                    command.Parameters.AddWithValue("@name", quesetionAnswer.Name);
                    command.Parameters.AddWithValue("@isCorrectAnswer", quesetionAnswer.IsCorrectAnswer);
                    command.Parameters.AddWithValue("@questionId", quesetionAnswer.QuestionId);
                    // Open the connection in a try/catch block.
                    // Create and execute the DataReader, writing the result
                    // set to the console window.
                    connection.Open();
                    var count = command.ExecuteNonQuery();
                    if (count < 1)
                        throw new ApplicationException("Error happended while saving question answers");
                }
            }
            catch (ApplicationException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error occured while save question answer", ex);
            }
        }
    }
}
