using System.Linq;
using FinalProject.BusinessLogic.Dto;
using FinalProject.EFLayer.DataModels;

namespace FinalProject.BusinessLogic.Extensions
{
    public static class ThemeExtension
    {

        public static ThemeDto ToThemeDto(this Theme theme)
        {
            if (theme == null)
                return null;

            var themeDto = new ThemeDto
            {
                Name = theme.Name,
                QuestionList = theme.Questions.Select(x => QuestionExtension.ToQuestionDto(x)).ToList()
            };

            return themeDto;
        }
    }
}
