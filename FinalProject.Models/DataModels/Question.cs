using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models.DataModels
{
    public class Question
    {
        public int Id { get; set; }

        public int TypeId { get; set; }

        public int ModuleId { get; set; }

        public int ThemeId { get; set; }

        public string Text { get; set; }
    }
}
