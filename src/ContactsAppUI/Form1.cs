using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsApp;

namespace ContactsAppUI
{
    public partial class MainForm : Form
    {
        private Project _project = ProjectManager.Load(ProjectManager.Path);

        private void ClearAndFillList(List<Contact> Сontacts)
        {
            ContactListBox.Items.Clear();
            for (int i = 0; i < _project.Сontacts.Count; i++)
            {
                ContactListBox.Items.Insert(i, _project.Сontacts[i].Surname);
            }

            ContactListBox.SelectedIndex = 0;
        }

        public MainForm()
        {
            InitializeComponent();
            if(_project.Сontacts.Count != 0)
            {
                ClearAndFillList(_project.Сontacts);
            }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddContactButton_Click(object sender, EventArgs e)
        {
            var newContact = new Contact();
            
            AddEditContact addEditContact = new AddEditContact { Contact = newContact };
            addEditContact.ShowDialog();
        }

        private void ContactListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var contact = _project.Сontacts[ContactListBox.SelectedIndex];
            SurnameTextBox.Text = contact.Surname;
            NametextBox.Text = contact.Name;
            BirthdaydateTimePicker.Value = contact.BirthDate;
            PhonetextBox.Text = "+" + contact.PhoneNumber.CountryCode + " "
                + "("
                + contact.PhoneNumber.CityCode
                + ")" + " " + contact.PhoneNumber.SubscriberCode;
            EmailtextBox.Text = contact.Email;
            VkBox.Text = contact.IdVkontakte;
        }
    }
}
