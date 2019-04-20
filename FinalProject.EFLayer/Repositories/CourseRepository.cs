using FinalProject.EFLayer.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DataLayer.Repositories
{
    public class CourseRepository
    {

        public List<Course> GetListOfCourses()
        {
            var context = new FinalProjectDBEntities1();

            //using (var context = new FinalProjectDBEntities1())
            //{
                var corses = context.Courses
                    .Include("Teachers")
                    .Include("Groups")
                    .Include("Modules")
                    .ToList();
                return corses;
           // }
        }

        public Course GetCourseById(int Id)
        {
            using (var context = new FinalProjectDBEntities1())
            {
                return context.Courses.Find(Id);
            }
        }

        public void AddCourse(Course course)
        {
            using (var context = new FinalProjectDBEntities1())
            {
                context.Courses.Add(course);
            }
        }

        public void DeleteCourse(int Id)
        {
            using (var context = new FinalProjectDBEntities1())
            {
                Course course = context.Courses.Find(Id);
                context.Courses.Remove(course);

            }
        }

    }
}
