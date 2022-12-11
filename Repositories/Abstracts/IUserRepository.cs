using ExamPreperation.Models.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreperation.Repositories.Abstracts
{
    public interface IUserRepository
    {
        IEnumerable<User> GetUsers();
        void SeedDefaultData();
        void AddUser(User user);
        void DeleteUser(int userId);
    }
}
