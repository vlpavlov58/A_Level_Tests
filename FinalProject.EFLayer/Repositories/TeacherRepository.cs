using FinalProject.EFLayer.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.EFLayer.Repositories
{
    public class TeacherRepository
    {
        public IEnumerable<Teacher> GetListOfTeachers()
        {
            using (var context = new FinalProjectDBEntities())
            {
                return context.Teachers.ToList();
            }
        }

        public void AddTeacher(Teacher teacher)
        {
            using (var context = new FinalProjectDBEntities())
            {
                context.Teachers.Add(teacher);
            }
        }

        public void DeleteTeacher(int Id)
        {
            using (var context = new FinalProjectDBEntities())
            {
                Teacher teacher = context.Teachers.Find(Id);
                context.Teachers.Remove(teacher);
            }
        }

        public Teacher GetTeacheryId(int Id)
        {
            using (var context = new FinalProjectDBEntities())
            {
                return context.Teachers.Find(Id);
            }
        }
    }
}
