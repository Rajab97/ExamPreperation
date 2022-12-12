using ExamPreperation.Constants;
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
    public class ExamRepository : IExamRepository
    {
        private readonly string connectionString;
        public ExamRepository()
        {
            connectionString = ConfigurationManager.AppSettings[AppConfigKeys.ConnectionString];
        }

        public IEnumerable<Exam> GetAll()
        {
            try
            {
                List<Exam> exams = new List<Exam>();
                using (SqlConnection connection =
                new SqlConnection(connectionString))
                {
                    // Create the Command and Parameter objects.
                    SqlCommand command = new SqlCommand(Queries.ExamQueries.Select, connection);

                    // Open the connection in a try/catch block.
                    // Create and execute the DataReader, writing the result
                    // set to the console window.
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var user = new Exam()
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            PassingScore = reader.GetInt32(2)
                        };
                        exams.Add(user);
                    }
                    reader.Close();
                }
                return exams;
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
        public void SeedDefaultData()
        {
            try
            {
                var users = GetAll();
                if (!users.Any())
                {
                    var finalExam = new Exam()
                    {
                        Name = "Final Exam",
                        PassingScore = 51
                    };

                    Add(finalExam);
                }

            }
            catch (ApplicationException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error occured while adding default exam", ex);
            }
        }
        public void Delete(int examId)
        {
            try
            {
                var exams = GetAll();
                if (!exams.Any(m => m.Id == examId))
                    throw new ApplicationException("Exam not found");

                using (SqlConnection connection =
                new SqlConnection(connectionString))
                {
                    // Create the Command and Parameter objects.
                    SqlCommand command = new SqlCommand(Queries.ExamQueries.Delete, connection);
                    command.Parameters.AddWithValue("@id", examId);
                    // Open the connection in a try/catch block.
                    // Create and execute the DataReader, writing the result
                    // set to the console window.
                    connection.Open();
                    var count = command.ExecuteNonQuery();
                    if (count < 1)
                        throw new ApplicationException("Error happended while deleting exam");
                }
            }
            catch (ApplicationException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error occured while delete exam", ex);
            }
        }
        public void Add(Exam exam)
        {
            try
            {
                var exams = GetAll();
                if (exams.Any(m => m.Name == exam.Name))
                    throw new ApplicationException("Exam with same username already exist");

                using (SqlConnection connection =
                new SqlConnection(connectionString))
                {
                    // Create the Command and Parameter objects.
                    SqlCommand command = new SqlCommand(Queries.ExamQueries.Insert, connection);
                    command.Parameters.AddWithValue("@name", exam.Name);
                    command.Parameters.AddWithValue("@passingScore", exam.PassingScore);
                    // Open the connection in a try/catch block.
                    // Create and execute the DataReader, writing the result
                    // set to the console window.
                    connection.Open();
                    var count = command.ExecuteNonQuery();
                    if (count < 1)
                        throw new ApplicationException("Error happended while saving exam");
                }
            }
            catch (ApplicationException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error occured while save exam", ex);
            }
        }
    }
}
