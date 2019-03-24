using FinalProject.EFLayer.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BusinessLogic.Dto
{
    public class QuestionDto
    {
        public string Text { get; set; }

        public List<MultichoiceAnswer> multichoiceAnswersList { get; set; }

        public List<TextAnswer> textAnswersList { get; set; }

    }
}
