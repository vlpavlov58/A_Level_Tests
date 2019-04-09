using FinalProject.BusinessLogic.Dto;
using FinalProject.EFLayer.DataModels;
using System.Linq;

namespace FinalProject.BusinessLogic.Extensions
{
    public static class ModuleExtension
    {

        public static ModuleDto ToModuleDto(this Module module)
        {
            if (module == null)
                return null;

            var moduleDto = new ModuleDto
            {
                QuantityLessons = module.QuantityLessons.Value,
                QuestionList = module.Questions.Select(x => QuestionExtension.ToQuestionDto(x)).ToList(),
                ThemeList = module.Themes.Select(x => ThemeExtension.ToThemeDto(x)).ToList()
            };
            return moduleDto;
        } 
         
    }
}
