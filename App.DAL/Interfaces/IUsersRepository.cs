using App.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DAL.Interfaces
{
    public interface IUsersRepository
    {
        public List<User> GetAllUsers();
        public User GetUserById(Guid id);
        public Guid CreateUser(User user);
        public Guid UpdateUser(Guid id, User user);
        public List<User> DeleteUser(Guid id);

    }
}
