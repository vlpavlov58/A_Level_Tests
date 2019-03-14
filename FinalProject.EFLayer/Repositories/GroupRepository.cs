using FinalProject.EFLayer.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.EFLayer.Repositories
{
    public class GroupRepository
    {

        public IEnumerable<Group> GetListOfGroup()
        {
            using (var context = new FinalProjectDBEntities())
            {
                return context.Groups.ToList();
            }

        }

        public Group GetGroupById(int Id)
        {
            using (var context = new FinalProjectDBEntities())
            {
                return context.Groups.Find(Id);
            }
        }

        public void AddGroup(Group group)
        {
            using (var context = new FinalProjectDBEntities())
            {
                context.Groups.Add(group);
            }
        }

        public void DeleteGroup(int Id)
        {
            using (var context = new FinalProjectDBEntities())
            {
                Group group = context.Groups.Find(Id);

                context.Groups.Remove(group);
            }
        }
    }
}
