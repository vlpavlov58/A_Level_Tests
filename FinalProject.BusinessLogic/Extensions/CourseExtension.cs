using System.Linq;
using FinalProject.BusinessLogic.Dto;
using FinalProject.DataLayer.DataModels;


namespace FinalProject.BusinessLogic.Extensions
{
    public static class CourseExtension
    {
        public static CourseDto ToCourseDto(this Course course)
        {
            if (course == null)
                return null;

            var courseDto = new CourseDto
            {
                Name = course.Name,
                GroupsList = course.Groups.Select(x => GroupExtension.ToGroupDto(x)).ToList(),
                ModulesList = course.Modules.Select(x => ModuleExtension.ToModuleDto(x)).ToList(),
                TeachersList = course.Teachers.Select(x => TeacherExtension.ToTeacherDto(x)).ToList()
            };

            return courseDto;
        }
    }
}
