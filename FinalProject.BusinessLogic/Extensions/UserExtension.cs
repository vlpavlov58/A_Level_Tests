﻿using System.Linq;
using FinalProject.BusinessLogic.Dto;
using FinalProject.DataLayer.DataModels;

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
                AdminsList = user.Admins.Select(x => x.ToAdminDto()).ToList(),
                StudentsList = user.Students.Select(x => x.ToStudentDto()).ToList(),
                TeachersList = user.Teachers.Select(x => x.ToTeacherDto()).ToList()
            };

            return userDto;
        }
    }
}
