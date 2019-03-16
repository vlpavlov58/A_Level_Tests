using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models.DataModels
{
    public class Module
    {
        public int Id { get; set; }

        public int CourseId { get; set; }

        public int QuatityLessons { get; set; }

        public int ThemeId { get; set; }
    }
}
