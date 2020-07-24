using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimetableStudent.Core.Repositories.Timetable
{
    public class FileTimetableRepository : FileBaseRepository<Entities.Timetable>, TimeTableRepository
    {
        protected override string table => "timetables";

        public Entities.Timetable getById(int id)
        {
            return Items.Find((item) => item.Id == id);
        }
    }
}
