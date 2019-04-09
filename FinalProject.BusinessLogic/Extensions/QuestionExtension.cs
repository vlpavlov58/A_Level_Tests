using System.Linq;
using FinalProject.BusinessLogic.Dto;
using FinalProject.EFLayer.DataModels;

namespace FinalProject.BusinessLogic.Extensions
{
    public static class QuestionExtension
    {
        public static QuestionDto ToQuestionDto(this Question question)
        {
            if (question == null)
                return null;

            var questionDto = new QuestionDto
            {
                Text = question.Text,
                TextAnswersList = question.TextAnswers
                                                     .Select(x => TextAnswerExtension.ToTextAnswerDto(x))
                                                     .ToList(),
                MultichoiceAnswersList = question.MultichoiceAnswers
                                                     .Select(x => MultichoiseAnswerExtension.ToMultichoiceAnswerDto(x))
                                                     .ToList()
            };

            return questionDto;
        }
    }
}
