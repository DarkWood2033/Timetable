using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimetableStudent.Core.Repositories.Timetable
{
    public interface TimeTableRepository
    {
        Entities.Timetable getById(int id);
    }
}
