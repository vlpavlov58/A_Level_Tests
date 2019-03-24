using FinalProject.BusinessLogic.Dto;
using FinalProject.DataLayer.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BusinessLogic.Extensions
{
    public static class ProjectExtension
    {


        public static ModuleDto ToModuleDto(this Module module)
        {

            if (module == null)
                return null;

            var moduleDto = new ModuleDto
            {
                QuantityLessons = module.QuantityLessons.Value,
                QuestionList = module.Questions.Select(x => ToQuestionDto(x)).ToList(),
                ThemeList = module.Themes.Select(x => ToThemeDto(x)).ToList()
            };

            return moduleDto;

        }

        public static ThemeDto ToThemeDto(this Theme theme)
        {
            if (theme == null)
                return null;

            var themeDto = new ThemeDto
            {
                Name = theme.Name,
                QuestionList = theme.Questions.Select(x => ToQuestionDto(x)).ToList()
            };

            return themeDto;
        }

        public static QuestionDto ToQuestionDto(this Question question)
        {
            if (question == null)
                return null;

            var questionDto = new QuestionDto
            {
                Text = question.Text,
                TextAnswersList = question.TextAnswers
                                                     .Select(x => ToTextAnswerDto(x))
                                                     .ToList(),
                MultichoiceAnswersList = question.MultichoiceAnswers
                                                     .Select(x => ToMultichoiceAnswerDto(x))
                                                     .ToList()
            };

            return questionDto;
        }

        public static TextAnswerDto ToTextAnswerDto(this TextAnswer textAnswer)
        {
            if (textAnswer == null)
                return null;

            var textAnswerDto = new TextAnswerDto
            {
                Textbox = textAnswer.Textbox,
                IsCorrect = textAnswer.IsCorrect.Value
            };

            return textAnswerDto;
        }


        public static MultichoiceAnswerDto ToMultichoiceAnswerDto (this MultichoiceAnswer multichoice)
        {
            if (multichoice == null)
                return null;

            var multichoiceDto = new MultichoiceAnswerDto
            {
                AnswerText = multichoice.AnswerText,
                IsCorrect = multichoice.IsCorrect.Value,
            };

            return multichoiceDto;
        }
    }
}
