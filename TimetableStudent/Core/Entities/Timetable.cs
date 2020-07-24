using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimetableStudent.Core.Entities
{
    public class Timetable
    {
        public int Id { get; set; }

        public int _group_id { get; set; }

        public ItemTimetable[] Items { get; set; }
    }
}
