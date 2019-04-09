using System.Linq;
using FinalProject.BusinessLogic.Dto;
using FinalProject.EFLayer.DataModels;

namespace FinalProject.BusinessLogic.Extensions
{
    public static class UserExtension
    {
        public static UserDto ToUserDto(this User user)
        {
            if (user == null)
                return null;

            var userDto = new UserDto
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Login = user.Login,
                Password = user.Password,
                AdminsList = user.Admins.Select(x => AdminExtension.ToAdminDto(x)).ToList(),
                StudentsList = user.Students.Select(x => StudentExtension.ToStudentDto(x)).ToList(),
                TeachersList = user.Teachers.Select(x => TeacherExtension.ToTeacherDto(x)).ToList()
            };

            return userDto;
        }
    }
}
