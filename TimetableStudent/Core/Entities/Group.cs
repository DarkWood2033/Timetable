using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimetableStudent.Core.Repositories.Student;
using TimetableStudent.Core.Repositories.Timetable;

namespace TimetableStudent.Core.Entities
{
    public class Group
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Student[] Students() 
        {
            return Program.AppContainer.GetInstance<StudentRepository>().getByGroup(this.Id);
        }

        public Timetable Timetable()
        {
            return Program.AppContainer.GetInstance<TimeTableRepository>().getById(this.Id);
        }
    }
}
