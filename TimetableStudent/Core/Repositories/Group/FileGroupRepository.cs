using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimetableStudent.Core.Repositories.Group
{
    public class FileGroupRepository : FileBaseRepository<Entities.Group>, GroupRepository
    {
        protected override string table => "groups";

        public Entities.Group[] getAll()
        {
            return Items.ToArray();
        }

        public Entities.Group getById(int id)
        {
            return Items.Find((item) => item.Id == id);
        }

        public Entities.Group getByName(string name) 
        {
            return Items.Find((item) => item.Name == name);
        }
    }
}
