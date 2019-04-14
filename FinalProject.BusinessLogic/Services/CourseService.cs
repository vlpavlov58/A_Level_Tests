using FinalProject.BusinessLogic.Dto;
using FinalProject.DataLayer.Repositories;
using System.Collections.Generic;
using System.Linq;
using FinalProject.BusinessLogic.Extensions;


namespace FinalProject.BusinessLogic.Services
{
    public interface ICourseService
    {
        List<CourseDto> GetCourseList();

        CourseDto GetById(int Id);
       
    }
    public class CourseService : ICourseService
    {
        CourseRepository courseRepository = new CourseRepository();

        public CourseDto GetById(int Id)
        {

           var course = courseRepository.GetCourseById(Id);

            return course.ToCourseDto();

        }

        public List<CourseDto> GetCourseList()
        {            

            var courseList = courseRepository.GetListOfCourses();

            return courseList.Select(x => x.ToCourseDto()).ToList();
        }
                
    }
}
