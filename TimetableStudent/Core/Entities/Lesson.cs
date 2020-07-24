using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimetableStudent.Core.Entities
{
    public class Lesson
    {
        public string Name { get; set; }

        public string Time { get; set; }

        public string LectureHall { get; set; }

        public string Discipline { get; set; }

        public string Teacher { get; set; }
    }
}
