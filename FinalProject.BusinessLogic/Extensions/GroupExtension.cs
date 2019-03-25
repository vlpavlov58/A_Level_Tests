using System.Linq;
using FinalProject.BusinessLogic.Dto;
using FinalProject.DataLayer.DataModels;

namespace FinalProject.BusinessLogic.Extensions
{
    public static class GroupExtension
    {
        public static GroupDto ToGroupDto(this Group group)
        {
            if (group == null)
                return null;

            var groupDto = new GroupDto
            {
                Name = group.Name,
                BeginingDate = group.BeginigDate.Value,
                StudentsList = group.Students.Select(x => StudentExtension.ToStudentDto(x)).ToList(),
                TeachersList = group.Teachers.Select(x => TeacherExtension.ToTeacherDto(x)).ToList()
            };

            return groupDto;
        }
    }
}
