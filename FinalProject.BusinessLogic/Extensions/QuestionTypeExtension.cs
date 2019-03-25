using System.Linq;
using FinalProject.BusinessLogic.Dto;
using FinalProject.DataLayer.DataModels;


namespace FinalProject.BusinessLogic.Extensions
{
    public static class QuestionTypeExtension
    {
        public static QuestionTypeDto ToQuestionTypeDto(this QuestionType questionType)
        {
            if (questionType == null)
                return null;

            var questionTypeDto = new QuestionTypeDto
            {
                Type = questionType.Type,
                QuestionsList = questionType.Questions.Select(x => QuestionExtension.ToQuestionDto(x)).ToList()
            };

            return questionTypeDto;
        }
    }
}
