using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimetableStudent.Core.Entities;

namespace TimetableStudent.Core.Services.Auth
{
    public class Auth
    {
        private Student Student { get; set; }

        public Student User { get { return this.Student; } }

        public void SignIn(Student student) 
        {
            this.Student = student;
        }

        public void Logout() 
        {
            this.Student = null;
        }
    }
}
