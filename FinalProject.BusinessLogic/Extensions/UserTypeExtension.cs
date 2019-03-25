using System.Linq;
using FinalProject.BusinessLogic.Dto;
using FinalProject.DataLayer.DataModels;

namespace FinalProject.BusinessLogic.Extensions
{
    public static class UserTypeExtension
    {
        public static UserTypeDto ToUserTypeDto(this UserType userType)
        {
            if (userType == null)
                return null;

            var userTypeDto = new UserTypeDto
            {
                Name = userType.Name,
                UsersList = userType.Users.Select(x => UserExtension.ToUserDto(x)).ToList()
            };

            return userTypeDto;
        }
    }
}
