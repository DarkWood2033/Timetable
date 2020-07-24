using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimetableStudent.Core.Repositories.Student
{
    public class FileStudentRepository : FileBaseRepository<Entities.Student>, StudentRepository
    {
        protected override string table => "students";

        public Entities.Student[] getAll() 
        {
            return Items.ToArray();
        }

        public Entities.Student[] getByGroup(int group_id)
        {
            return Items.FindAll((item) => item._group_id == group_id).ToArray();
        }

        public Entities.Student getByName(string name)
        {
            return Items.Find((item) => item.Name == name);
        }
    }
}
