using ExamPreperation.Constants;
using ExamPreperation.Helpers;
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
    public class UserRepository : IUserRepository
    {
        private readonly string connectionString;
        public UserRepository()
        {
            connectionString = ConfigurationManager.AppSettings[AppConfigKeys.ConnectionString];
        }

        public IEnumerable<User> GetUsers()
        {
            try
            {
                List<User> users = new List<User>();
                using (SqlConnection connection =
                new SqlConnection(connectionString))
                {
                    // Create the Command and Parameter objects.
                    SqlCommand command = new SqlCommand(Queries.UserQueries.SelectUsers, connection);

                    // Open the connection in a try/catch block.
                    // Create and execute the DataReader, writing the result
                    // set to the console window.
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var user = new User()
                        {
                            Id = reader.GetInt32(0),
                            UserName = reader.GetString(1),
                            Password = reader.GetString(2),
                            Role = reader.GetString(3),
                        };
                        users.Add(user);
                    }
                    reader.Close();
                }
                return users;
            }
            catch (ApplicationException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error occured while reading users",ex);
            }
        } 
        public void SeedDefaultData()
        {
            try
            {
                var users = GetUsers();
                if (!users.Any())
                {
                    var adminUser = new User()
                    {
                        Password = HashHelper.Hash(ConfigurationManager.AppSettings[AppConfigKeys.AdminPassword]),
                        UserName = ConfigurationManager.AppSettings[AppConfigKeys.AdminUserName],
                        Role = Roles.Admin
                    };
                    var user = new User()
                    {
                        Password = HashHelper.Hash(ConfigurationManager.AppSettings[AppConfigKeys.UserPassword]),
                        UserName = ConfigurationManager.AppSettings[AppConfigKeys.UserUserName],
                        Role = Roles.User
                    };

                    AddUser(adminUser);
                    AddUser(user);
                }
               
            }
            catch (ApplicationException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error occured while adding default users", ex);
            }
        }
        public void DeleteUser(int userId)
        {
            try
            {
                var users = GetUsers();
                if (!users.Any(m => m.Id == userId))
                    throw new ApplicationException("User not found");

                using (SqlConnection connection =
                new SqlConnection(connectionString))
                {
                    // Create the Command and Parameter objects.
                    SqlCommand command = new SqlCommand(Queries.UserQueries.DeleteUsers, connection);
                    command.Parameters.AddWithValue("@id", userId);
                    // Open the connection in a try/catch block.
                    // Create and execute the DataReader, writing the result
                    // set to the console window.
                    connection.Open();
                    var count = command.ExecuteNonQuery();
                    if (count < 1)
                        throw new ApplicationException("Error happended while deleting user");
                }
            }
            catch (ApplicationException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error occured while delete user", ex);
            }
        }
        public void AddUser(User user)
        {
            try
            {
                var users = GetUsers();
                if (users.Any(m=>m.UserName == user.UserName))
                    throw new ApplicationException("User with same username already exist");

                using (SqlConnection connection =
                new SqlConnection(connectionString))
                {
                    // Create the Command and Parameter objects.
                    SqlCommand command = new SqlCommand(Queries.UserQueries.InsertUser, connection);
                    command.Parameters.AddWithValue("@userName",user.UserName);
                    command.Parameters.AddWithValue("@password",user.Password);
                    command.Parameters.AddWithValue("@role",user.Role);
                    // Open the connection in a try/catch block.
                    // Create and execute the DataReader, writing the result
                    // set to the console window.
                    connection.Open();
                    var count = command.ExecuteNonQuery();
                    if (count < 1)
                        throw new ApplicationException("Error happended while saving user");
                }
            }
            catch (ApplicationException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error occured while save user", ex);
            }
        }
    }
}
