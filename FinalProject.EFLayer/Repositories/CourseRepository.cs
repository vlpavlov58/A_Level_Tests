using FinalProject.DataLayer.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DataLayer.Repositories
{
    public class CourseRepository
    {

        public IEnumerable<Course> GetListOfCourses()
        {
            using (var context = new FinalProjectDBEntities())
            {
                return context.Courses.ToList();
            }
        }

        public Course GetCourseById(int Id)
        {
            using (var context = new FinalProjectDBEntities())
            {
                return context.Courses.Find(Id);
            }
        }

        public void AddCourse(Course course)
        {
            using (var context = new FinalProjectDBEntities())
            {
                context.Courses.Add(course);
            }
        }

        public void DeleteCourse(int Id)
        {
            using (var context = new FinalProjectDBEntities())
            {
                Course course = context.Courses.Find(Id);
                context.Courses.Remove(course);

            }
        }

    }
}
