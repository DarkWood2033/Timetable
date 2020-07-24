using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimetableStudent.Core.Entities
{
    public class ItemTimetable
    {
        public string DayOfWeek { get; set; }

        public Lesson[] Lessons { get; set; }
    }
}
