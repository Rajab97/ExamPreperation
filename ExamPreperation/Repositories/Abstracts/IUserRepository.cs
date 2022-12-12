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
        IEnumerable<User> GetAll();
        void SeedDefaultData();
        void Add(User user);
        void Delete(int userId);
    }
}
