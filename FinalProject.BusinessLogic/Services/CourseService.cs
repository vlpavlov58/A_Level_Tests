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
    }
    public class CourseService : ICourseService
    {
        public List<CourseDto> GetCourseList()
        {
            var courseRepository = new CourseRepository();

            var courseList = courseRepository.GetListOfCourses();

            return courseList.Select(x => x.ToCourseDto()).ToList();
        }
    }
}
