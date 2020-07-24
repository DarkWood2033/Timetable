using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimetableStudent.Core.Repositories.Group
{
    public interface GroupRepository
    {
        Entities.Group[] getAll();

        Entities.Group getById(int id);

        Entities.Group getByName(string name);
    }
}
