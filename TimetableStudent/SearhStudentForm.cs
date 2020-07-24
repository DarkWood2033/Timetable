using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimetableStudent.Core.Repositories.Group;
using TimetableStudent.Core.Entities;
using TimetableStudent.Core.Repositories.Student;
using TimetableStudent.Core.Services.Auth;
using TimetableStudent.Core.Repositories.Timetable;

namespace TimetableStudent
{
    public partial class SearhStudentForm : Form
    {
        private const string SELECT_GROUP = "Пожалуйста, выберите группу";
        private const string NOT_FOUND_STUDENT = "Не существует студент с таким именем";

        private readonly GroupRepository GroupRepository;
        private readonly StudentRepository StudentRepository;
        private readonly Auth Auth;
        public SearhStudentForm(
            GroupRepository groupRepository, 
            StudentRepository studentRepository,
            Auth auth
        ){
            this.GroupRepository = groupRepository;
            this.StudentRepository = studentRepository;
            this.Auth = auth;

            InitializeComponent();

            foreach (Group group in this.GroupRepository.getAll())
            {
                GroupSelect.Items.Insert(group.Id - 1, group.Name);
            }
        }

        private void SearhTimetable_Click(object sender, EventArgs e)
        {
            if (GroupSelect.SelectedItem != null)
            {
                Group group = this.GroupRepository.getByName((string)GroupSelect.SelectedItem);
                Student[] studentsOfGroup = group.Students();

                string nameStudent = NameStudentInput.Text;
                bool isFound = false;

                foreach (Student student in studentsOfGroup)
                {
                    if (student.Name == nameStudent)
                    {
                        isFound = true;
                        this.Auth.SignIn(student);
                        new TimetableForm(this.Auth).Show();
                        break;
                    }
                }

                if (!isFound) 
                {
                    MessageBox.Show(SearhStudentForm.NOT_FOUND_STUDENT);
                }
            }
            else 
            {
                MessageBox.Show(SearhStudentForm.SELECT_GROUP);
            }
        }

        private void NameStudentInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void GroupSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SearhStudentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
