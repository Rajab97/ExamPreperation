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
            public const string InsertUser = "INSERT INTO [Users]([UserName],[Password],[Role]) values(@userName,@password,@role)";
            public const string SelectUsers = "SELECT * FROM [Users] ORDER BY [UserName]";
            public const string DeleteUsers = "DELETE FROM [Users] WHERE [Id] = @id";
        }
    }
}
