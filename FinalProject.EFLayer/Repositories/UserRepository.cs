using FinalProject.EFLayer.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.EFLayer.Repositories
{
    public class UserRepository
    {
        public IEnumerable<User> GetListOfUsers()
        {
            using (var context = new FinalProjectDBEntities())
            {
                return context.Users.ToList();
            }
        }

        public void AddUser(User user)
        {
            using (var context = new FinalProjectDBEntities())
            {
                context.Users.Add(user);
            }
        }

        public void DeleteUser(int Id)
        {
            using (var context = new FinalProjectDBEntities())
            {
                User user = context.Users.Find(Id);
                context.Users.Remove(user);
            }
        }

        public User GetUserById(int Id)
        {
            using (var context = new FinalProjectDBEntities())
            {
                return context.Users.Find(Id);
            }
        }
    }
}
