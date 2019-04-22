using FinalProject.EFLayer.DataModels;
using System.Collections.Generic;
using System.Linq;

namespace FinalProject.DataLayer.Repositories
{
    public class UserRepository
    {
        public IEnumerable<User> GetListOfUsers()
        {
            using (var context = new FinalProjectDBEntities1())
            {
                return context.Users.ToList();
            }
        }

        public void AddUser(User user)
        {
            using (var context = new FinalProjectDBEntities1())
            {
                context.Users.Add(user);
            }
        }

        public void DeleteUser(int Id)
        {
            using (var context = new FinalProjectDBEntities1())
            {
                User user = context.Users.Find(Id);
                context.Users.Remove(user);
            }
        }

        public User GetUserById(int Id)
        {
            using (var context = new FinalProjectDBEntities1())
            {
                return context.Users.Find(Id);
            }
        }
    }
}
