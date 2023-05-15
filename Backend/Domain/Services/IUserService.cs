using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    /// <summary>
    /// Abstracts operationsof User to Application layer.
    /// </summary>
    public interface IUserService
    {
        public void CreateUser(User user);
        public bool UpdateUser(User user);
        public bool DeleteUser(int id);
        public User GetUser(int id);
        public IEnumerable<User> GetAllUsers();
    }
}
