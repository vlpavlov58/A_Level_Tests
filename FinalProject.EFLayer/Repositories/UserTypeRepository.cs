using FinalProject.DataLayer.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DataLayer.Repositories
{
    public class UserTypeRepository
    {
        public IEnumerable<UserType> GetListOfUserType()
        {
            using (var context = new FinalProjectDBEntities())
            {
                return context.UserTypes.ToList();
            }
        }

        public void AddUserType(UserType userType)
        {
            using (var context = new FinalProjectDBEntities())
            {
                context.UserTypes.Add(userType);
            }
        }

        public void DeleteUserType(int Id)
        {
            using (var context = new FinalProjectDBEntities())
            {
                UserType userType = context.UserTypes.Find(Id);
                context.UserTypes.Remove(userType);
            }
        }

        public UserType GetUserTypeById(int Id)
        {
            using (var context = new FinalProjectDBEntities())
            {
                return context.UserTypes.Find(Id);
            }
        }
    }
}

