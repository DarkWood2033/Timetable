using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimetableStudent.Core.Repositories.Group;

namespace TimetableStudent.Core.Entities
{
    public class Student
    {
        public int Id { set; get; }

        public string Name { set; get; }

        public int _group_id { set; get; }

        public Entities.Group Group()
        {
            return Program.AppContainer.GetInstance<GroupRepository>().getById(this._group_id);
        }
    }
}
