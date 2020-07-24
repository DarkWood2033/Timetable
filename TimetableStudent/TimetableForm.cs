using System;
using System.Windows.Forms;
using TimetableStudent.Core.Entities;
using TimetableStudent.Core.Services.Auth;
using TimetableStudent.Core.Services.Timetable;

namespace TimetableStudent
{
    public partial class TimetableForm : Form
    {
        private readonly Auth Auth;
        private Timetable Timetable{ get; set; }
        private TimeTableIterator Iterator { get; set; }

        public TimetableForm(Auth auth)
        {
            this.Auth = auth;

            InitializeComponent();
        }

        private void TimetableForm_Load(object sender, EventArgs e)
        {
            this.Timetable = this.Auth.User.Group().Timetable();
            Iterator = new TimeTableIterator(Timetable);

            this.RenderTable();
        }

        private void FillTable(Lesson[] lessons) 
        {
            GridTable.Rows.Clear();
            for (int i = 0; i < lessons.Length; i++)
            {
                GridTable.Rows.Add(
                    i + 1,
                    lessons[i].Time,
                    lessons[i].Name,
                    lessons[i].LectureHall,
                    lessons[i].Discipline,
                    lessons[i].Teacher
                );
            }
        }

        private void RenderTable() 
        {
            ItemTimetable itemTimetable = Iterator.get();
            DayOfWeek.Text = itemTimetable.DayOfWeek;
            this.FillTable(itemTimetable.Lessons);
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Iterator.next();
            this.RenderTable();
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            Iterator.previous();
            this.RenderTable();
        }
    }
}
