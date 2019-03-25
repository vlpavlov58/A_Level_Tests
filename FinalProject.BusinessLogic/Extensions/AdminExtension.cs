using FinalProject.BusinessLogic.Dto;
using FinalProject.DataLayer.DataModels;

namespace FinalProject.BusinessLogic.Extensions
{
    public static class AdminExtension
    {
        public static AdminDto ToAdminDto(this Admin admin)
        {
            if (admin == null)
                return null;

            var adminDto = new AdminDto();

            return adminDto;
        }
    }
}
