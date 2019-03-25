using FinalProject.BusinessLogic.Dto;
using FinalProject.DataLayer.Repositories;
using System.Collections.Generic;
using System.Linq;
using FinalProject.BusinessLogic.Extensions;


namespace FinalProject.BusinessLogic.Services
{
    internal interface IQuestionService
    {
        List<QuestionDto> GetQuestionList();
    }
    internal class QuestionSerice : IQuestionService
    {
        public List<QuestionDto> GetQuestionList()
        {
            var questionRepository = new QuestionRepository();

            var questionList = questionRepository.GetListOfQuestion();

            return questionList.Select(x => QuestionExtension.ToQuestionDto(x)).ToList();
        }
    }
}
