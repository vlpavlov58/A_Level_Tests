using System.Collections.Generic;

namespace FinalProject.BusinessLogic.Dto
{
    public class ModuleDto
    {
        public int QuantityLessons { get; set; }        

        public List<QuestionDto> questionList { get; set; }

        public List<ThemeDto> themeList { get; set; }
    }
}
