using FinalProject.BusinessLogic.Dto;
using FinalProject.EFLayer.DataModels;

namespace FinalProject.BusinessLogic.Extensions
{
    public static class TestPassingExtension
    {
        public static TestPassingDto ToTestPassingDto(this TestPassing testPassing)
        {
            if (testPassing == null)
                return null;

            var testPassingDto = new TestPassingDto
            {
                Date = testPassing.Date.Value
            };

            return testPassingDto;
        }
    }
}
