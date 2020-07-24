using System;
using System.Windows.Forms;
using TimetableStudent.Core.Repositories.Group;
using TimetableStudent.Core.Repositories.Student;
using SimpleInjector;
using TimetableStudent.Core.Services.Auth;
using TimetableStudent.Core.Repositories.Timetable;

namespace TimetableStudent
{
    static class Program
    {
        public static Container AppContainer;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Bootstrap();
            Application.Run(AppContainer.GetInstance<SearhStudentForm>());
        }

        private static void Bootstrap()
        {
            AppContainer = new Container();

            // Register repositories
            AppContainer.Register<GroupRepository, FileGroupRepository>(Lifestyle.Singleton);
            AppContainer.Register<StudentRepository, FileStudentRepository>(Lifestyle.Singleton);
            AppContainer.Register<TimeTableRepository, FileTimetableRepository>(Lifestyle.Singleton);

            // Register services
            AppContainer.Register<Auth>(Lifestyle.Singleton);

            // Register forms
            AppContainer.Register<SearhStudentForm>(Lifestyle.Singleton);
            AppContainer.Register<TimetableForm>(Lifestyle.Singleton);

            AppContainer.Verify();
        }
    }
}
