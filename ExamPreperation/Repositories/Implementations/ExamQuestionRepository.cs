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
    public class ExamQuestionRepository : IExamQuestionRepository
    {
        private readonly string connectionString;
        public ExamQuestionRepository()
        {
            connectionString = ConfigurationManager.AppSettings[AppConfigKeys.ConnectionString];
        }

        public IEnumerable<ExamQuestion> GetExamQuestions(int examId)
        {
            try
            {
                List<ExamQuestion> examQuestions = new List<ExamQuestion>();
                using (SqlConnection connection =
                new SqlConnection(connectionString))
                {
                    // Create the Command and Parameter objects.
                    SqlCommand command = new SqlCommand(Queries.ExamQuestionQueries.SelectExamQuestions, connection);
                    command.Parameters.AddWithValue("@examId",examId);
                    // Open the connection in a try/catch block.
                    // Create and execute the DataReader, writing the result
                    // set to the console window.
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var user = new ExamQuestion()
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Score = reader.GetInt32(2),
                            ExamId = reader.GetInt32(3)
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
                throw new ApplicationException("Error occured while reading exams", ex);
            }
        }

        public IEnumerable<ExamQuestionDTO> GetAll()
        {
            try
            {
                List<ExamQuestionDTO> examQuestions = new List<ExamQuestionDTO>();
                using (SqlConnection connection =
                new SqlConnection(connectionString))
                {
                    // Create the Command and Parameter objects.
                    SqlCommand command = new SqlCommand(Queries.ExamQuestionQueries.Select, connection);

                    // Open the connection in a try/catch block.
                    // Create and execute the DataReader, writing the result
                    // set to the console window.
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var user = new ExamQuestionDTO()
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Score = reader.GetInt32(2),
                            ExamId = reader.GetInt32(3),
                            ExamName = reader.GetString(4)
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
                throw new ApplicationException("Error occured while reading exams", ex);
            }
        }
        public void Delete(int examQuestionId)
        {
            try
            {
                var examQuestions = GetAll();
                if (!examQuestions.Any(m => m.Id == examQuestionId))
                    throw new ApplicationException("Exam question not found");

                using (SqlConnection connection =
                new SqlConnection(connectionString))
                {
                    // Create the Command and Parameter objects.
                    SqlCommand command = new SqlCommand(Queries.ExamQuestionQueries.Delete, connection);
                    command.Parameters.AddWithValue("@id", examQuestionId);
                    // Open the connection in a try/catch block.
                    // Create and execute the DataReader, writing the result
                    // set to the console window.
                    connection.Open();
                    var count = command.ExecuteNonQuery();
                    if (count < 1)
                        throw new ApplicationException("Error happended while deleting exam question");
                }
            }
            catch (ApplicationException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error occured while delete exam question", ex);
            }
        }
        public int Add(ExamQuestion examQuestion)
        {
            try
            {
                var examQuestions = GetAll();
                if (examQuestions.Any(m => m.Name == examQuestion.Name && m.ExamId == examQuestion.ExamId))
                    throw new ApplicationException("Exam question with same name already exist");

                using (SqlConnection connection =
                new SqlConnection(connectionString))
                {
                    // Create the Command and Parameter objects.
                    SqlCommand command = new SqlCommand(Queries.ExamQuestionQueries.Insert, connection);
                    SqlCommand prKeyCommand = new SqlCommand("SELECT @@IDENTITY", connection);
                    command.Parameters.AddWithValue("@name", examQuestion.Name);
                    command.Parameters.AddWithValue("@score", examQuestion.Score);
                    command.Parameters.AddWithValue("@examId", examQuestion.ExamId);

                    // Open the connection in a try/catch block.
                    // Create and execute the DataReader, writing the result
                    // set to the console window.
                    connection.Open();
                    command.ExecuteNonQuery();
                    var id = Convert.ToInt32(prKeyCommand.ExecuteScalar());
                    if (id < 1)
                        throw new ApplicationException("Error happended while saving exam question");
                    return id;
                }
            }
            catch (ApplicationException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error occured while save exam question", ex);
            }
        }
    }
}
