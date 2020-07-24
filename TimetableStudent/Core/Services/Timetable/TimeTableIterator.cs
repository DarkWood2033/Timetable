using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimetableStudent.Core.Entities;

namespace TimetableStudent.Core.Services.Timetable
{
    public class TimeTableIterator
    {
        private int Step {
            get;
            set;
        }
        private Entities.Timetable Timetable { get; set; }

        public TimeTableIterator(Entities.Timetable timetable) 
        {
            Timetable = timetable;
            Step = 0;
        }

        public void next() 
        {
            if (Step + 1 < Timetable.Items.Length)
            {
                Step++;
            }
        }

        public void previous() 
        {
            if (0 < Step) 
            {
                Step--;
            }
        }

        public ItemTimetable get() 
        {
            return Timetable.Items[Step];
        }
    }
}
