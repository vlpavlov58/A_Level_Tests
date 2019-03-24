using FinalProject.DataLayer.DataModels;
using System.Collections.Generic;
using System.Linq;

namespace FinalProject.DataLayer.Repositories
{
    public class AdminRepository
    { 
        public IEnumerable<Admin> GetListOfAdmin()
        {
            using (var context = new FinalProjectDBEntities())
            {
                return context.Admins.ToList();
            }
        }

        public void AddAdmin(Admin admin)
        {
            using (var context = new FinalProjectDBEntities())
            {
                context.Admins.Add(admin);
            }
        }

        public void DeleteAdmin(int Id)
        {
            using (var context = new FinalProjectDBEntities())
            {
                Admin admin = context.Admins.Find(Id);
                context.Admins.Remove(admin);
            }
        }

        public Admin GetAdminById(int Id)
        {
            using (var context = new FinalProjectDBEntities())
            {
                return context.Admins.Find(Id);
            }
        }
    }
}
