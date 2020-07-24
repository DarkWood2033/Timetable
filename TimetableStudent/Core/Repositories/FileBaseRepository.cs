using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimetableStudent.Core.Repositories
{
    class JsonContainer<Entity>
    {
        public List<Entity> Items { get; set; }
    }

    public abstract class FileBaseRepository<Entity>
    {
        protected abstract string table { get; }

        protected List<Entity> Items { get; set; }

        private string Path
        {
            get { return "..\\..\\Database\\" + this.table + ".json"; }
        }

        public FileBaseRepository() 
        {
            if (!File.Exists(this.Path))
            {
                throw new Exception("Таблица " + this.Path + " не найдена!");
            }

            JsonContainer<Entity> data = JsonConvert.DeserializeObject<JsonContainer<Entity>>(
                File.ReadAllText(this.Path, Encoding.GetEncoding(1251))
            );
            Items = data.Items;
        }
    }
}
