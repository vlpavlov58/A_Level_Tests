﻿using FinalProject.DataLayer.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BusinessLogic.Dto
{
    public class ThemeDto
    {
        public string Name { get; set; }

        public List<QuestionDto> QuestionList { get; set;}

    }
}
