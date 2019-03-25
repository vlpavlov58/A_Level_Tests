using System.Linq;
using FinalProject.BusinessLogic.Dto;
using FinalProject.DataLayer.DataModels;

namespace FinalProject.BusinessLogic.Extensions
{
    public static class TeacherExtension
    {
        public static TeacherDto ToTeacherDto(this Teacher teacher)
        {
            if (teacher == null)
                return null;

            var teacherDto = new TeacherDto
            {
                TestPassingList = teacher.TestPassings.Select(x => TestPassingExtension.ToTestPassingDto(x)).ToList(),
                CoursesList = teacher.Courses.Select(x => CourseExtension.ToCourseDto(x)).ToList(),
                GroupsList = teacher.Groups.Select(x => GroupExtension.ToGroupDto(x)).ToList()
            };

            return teacherDto;
        }
    }
}
