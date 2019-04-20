using FinalProject.EFLayer.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DataLayer.Repositories
{
    public class GroupRepository
    {

        public List<Group> GetListOfGroup()
        {
            using (var context = new FinalProjectDBEntities1())
            {
                var groups = context.Groups
                    .Include("Course")
                    .Include("Students")
                    .Include("Teachers")
                    .ToList();

                return groups;
            }
        }

        public Group GetGroupById(int Id)
        {
            using (var context = new FinalProjectDBEntities1())
            {
                return context.Groups.Find(Id);
            }
        }

        public void AddGroup(Group group)
        {
            using (var context = new FinalProjectDBEntities1())
            {
                context.Groups.Add(group);
            }
        }

        public void DeleteGroup(int Id)
        {
            using (var context = new FinalProjectDBEntities1())
            {
                Group group = context.Groups.Find(Id);

                context.Groups.Remove(group);
            }
        }
    }
}
