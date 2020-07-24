using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimetableStudent.Core.Repositories.Student
{
    public interface StudentRepository
    {
        Entities.Student[] getAll();

        Entities.Student getByName(string name);

        Entities.Student[] getByGroup(int group_id);
    }
}
