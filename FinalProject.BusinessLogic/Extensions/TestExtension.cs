using System.Linq;
using FinalProject.BusinessLogic.Dto;
using FinalProject.EFLayer.DataModels;

namespace FinalProject.BusinessLogic.Extensions
{
    public static class TestExtension
    {
        public static TestDto ToTestDto(this Test test)
        {
            if (test == null)
                return null;

            var testDto = new TestDto
            {
                ModulesList = test.Modules.Select(x => ModuleExtension.ToModuleDto(x)).ToList(),
                QuestionsList = test.Questions.Select(x => QuestionExtension.ToQuestionDto(x)).ToList(),
                TestPassingsList = test.TestPassings.Select(x => TestPassingExtension.ToTestPassingDto(x)).ToList()
            };

            return testDto;
        }
    }
}
