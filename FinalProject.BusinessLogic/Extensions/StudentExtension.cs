using System.Linq;
using FinalProject.BusinessLogic.Dto;
using FinalProject.EFLayer.DataModels;

namespace FinalProject.BusinessLogic.Extensions
{
    public static class StudentExtension
    {
        public static StudentDto ToStudentDto(this Student student)
        {
            if (student == null)
                return null;

            var studentDto = new StudentDto
            {
                TestPassingList = student.TestPassings.Select(x => TestPassingExtension.ToTestPassingDto(x)).ToList(),
                GroupsList = student.Groups.Select(x => GroupExtension.ToGroupDto(x)).ToList()
            };

            return studentDto;
        }
    }
}
