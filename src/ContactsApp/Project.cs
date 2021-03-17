using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
    /// <summary>
    /// Хранит список контактов
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Список контактов
        /// </summary>
        public List<Contact> Сontacts { get; set; } = new List<Contact>();
    }
}
