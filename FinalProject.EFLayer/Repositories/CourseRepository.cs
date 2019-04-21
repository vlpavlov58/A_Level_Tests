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
        private List<Course> corses = new List<Course>();
        public List<Course> GetListOfCourses()
        {
            var context = new FinalProjectDBEntities1();           
            //using (var context = new FinalProjectDBEntities1())
            //{
           corses = context.Courses
                    .Include("Teachers")
                    .Include("Groups")
                    .Include("Modules")
                    .ToList();
            for (int i = 0; i < corses.Count-1; i++)
            {
                if (corses[i].IsDeleted == true)
                {
                    continue;
                }                   
                else
                {
                    courseList.Add(corses[i]);
                }
                    

            }
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
                course.IsDeleted = false;
                courseList.Add(course);
                context.Courses.Add(course);                
                corses.Add(course);               
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

    }
}
