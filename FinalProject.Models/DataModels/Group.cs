using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models.DataModels
{
    public class Group
    {
        public int Id { get; set; }

        public int CourseId { get; set; }

        public int TeacherId { get; set; }

        public string Name { get; set; }

        public DateTime BegingDate { get; set; }
    }
}
