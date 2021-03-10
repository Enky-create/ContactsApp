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
            PhoneNumber phone = new PhoneNumber("7", "952", "8975112");
            DateTime birthDate = new DateTime(1998, 10, 23);
            Contact contact1 = new Contact(phone, "Вадим", "Комков", birthDate, "email", "12222");
            Contact contact2 = (Contact)contact1.Clone();

            Contact contact3 = new Contact(phone, "Вадим", "Комков");
            Contact contact4 = (Contact)contact3.Clone();
            contact3.PhoneNumber.CityCode="956";

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            
           
        }
    }
}
