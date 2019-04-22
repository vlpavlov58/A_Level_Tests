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
        private List<Course> courseList = new List<Course>();
        private List<Course> coursesEF;
        public List<Course> GetListOfCourses()
        {
            var context = new FinalProjectDBEntities1();           
            //using (var context = new FinalProjectDBEntities1())
            //{
           coursesEF = context.Courses
                    .Include("Teachers")
                    .Include("Groups")
                    .Include("Modules")
                    .ToList();
                ListInitialization();
                return courseList;
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
                context.SaveChanges(); 
            }
        }

        public void DeleteCourse(int? Id)
        {
            using (var context = new FinalProjectDBEntities1())
            {
                Course course = context.Courses.Find(Id);
                course.IsDeleted = true;              
                context.SaveChanges();
                courseList.Remove(course);
            }
        }


        private void ListInitialization()
        {           
            foreach (var item in coursesEF)
            {
                if (item.IsDeleted == true)
                    continue;
                else
                    courseList.Add(item);
            }

        }
    }
}
