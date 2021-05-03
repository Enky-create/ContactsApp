using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsApp;
namespace ContactsAppUI
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*PhoneNumber phone = new PhoneNumber("7", "952", "8975112");
            DateTime birthDate = new DateTime(1998, 10, 23);
            Contact contact1 = new Contact(phone, "вадим", "Комков", birthDate, "email", "12222");
            Contact contact2 = (Contact)contact1.Clone();

            Contact contact3 = new Contact(phone, "Вадим", "Комков");
            Contact contact4 = (Contact)contact3.Clone();
            contact3.PhoneNumber.CityCode="956";

            var project = new Project();
            project.Сontacts.Add(contact1);
            project.Сontacts.Add(contact2);
            project.Сontacts.Add(contact3);
            project.Сontacts.Add(contact4);

            ProjectManager.Save(project, ProjectManager.Path);

            var project2 = ProjectManager.Load(ProjectManager.Path);

            Console.WriteLine(project2.Сontacts[0].Name);
            Console.WriteLine(ProjectManager.Path);
            Console.Read();*/

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

            
           
        }
    }
}
