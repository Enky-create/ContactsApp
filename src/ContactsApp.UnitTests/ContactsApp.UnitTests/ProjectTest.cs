using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp.UnitTests
{
    [TestFixture]
    class ProjectTest
    {
        /// <summary>
        /// Экземпляр проекта
        /// </summary>
        private readonly Project _contacts = new Project();

        /// <summary>
        /// Экземпляр заметки
        /// </summary>
        private readonly Contact _contact = new Contact();

        [Test(Description = "Проверка на добавление контакта в список")]
        public void Project_NotNull()
        {
            _contacts.Сontacts.Add(_contact);

            Assert.NotNull(_contact);
        }
    }
}
