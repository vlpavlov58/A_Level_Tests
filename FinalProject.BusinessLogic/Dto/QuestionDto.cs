using FinalProject.DataLayer.DataModels;
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

        public List<MultichoiceAnswerDto> MultichoiceAnswersList { get; set; }

        public List<TextAnswerDto> TextAnswersList { get; set; }

    }
}
