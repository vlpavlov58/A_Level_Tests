using FinalProject.BusinessLogic.Dto;
using FinalProject.EFLayer.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                questionList = module.Questions.Select(x => ToQuestionDto(x)).ToList(),                
                
            };

            return moduleDto;

        }

        public static QuestionDto ToQuestionDto(this Question question)
        {
            if (question == null)
                return null;

            var questionDto = new QuestionDto
            {
                Text = question.Text,
                textAnswersList = 
            };
        }



    }
}
