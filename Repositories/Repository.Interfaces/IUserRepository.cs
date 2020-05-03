using BookStore.Data.Entities;
using System.Collections.Generic;
using System.Linq;

namespace BookStore.Repositories.Repository.Interfaces
{
    public interface IUserRepository
    {
        void AddUser(User user);
        void EditUser(User user);
        void DeleteUser(int userId);

        IEnumerable<User> GetUsers();
        IQueryable<User> GetUsersQueryable();

        User GetUserById(int userId);
    }
}
