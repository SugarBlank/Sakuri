using Sakuri.Models;
using System.Linq;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;

namespace Sakuri.Server
{
    public interface IDataAccessProvider
    {
        void AddUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int id);
        User GetUserRecord(int id);
        List<User> GetAllUsers();
    }
}
