using FinalProject.DataLayer.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DataLayer.Repositories
{
    public class UserRepository
    {
        public IEnumerable<User> GetAll()
        {
            using (var ctx = new FinalProjectDBEntities())
            {
                return ctx.Users.ToList();
            }
        }
    }
}
