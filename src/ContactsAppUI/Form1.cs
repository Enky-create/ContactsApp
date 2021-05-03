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
        
        private void RemoveContact ()
        {
            if (ContactListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Не выбран контакт");
            }
            else
            {
                _project.Сontacts.Remove(_project.Сontacts[ContactListBox.SelectedIndex]);
                ProjectManager.Save(_project, ProjectManager.Path);
                ClearAndFillList(_project.Сontacts);
            }
        }
        private void EditContact ()
        {
            if (ContactListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Не выбран контакт");
            }
            else
            {
                var editedContact = (Contact)(_project.Сontacts[ContactListBox.SelectedIndex].Clone());
                AddEditContact addEditContact = new AddEditContact();

                addEditContact.Contact = editedContact;


                DialogResult result = addEditContact.ShowDialog();
                if (result == DialogResult.OK)
                {
                    _project.Сontacts.Remove(_project.Сontacts[ContactListBox.SelectedIndex]);
                    _project.Сontacts.Add(editedContact);
                    ProjectManager.Save(_project, ProjectManager.Path);
                    ClearAndFillList(_project.Сontacts);
                }
            }
        }
        private void AddContact ()
        {
            var newContact = new Contact();

            AddEditContact addEditContact = new AddEditContact { Contact = newContact };
            DialogResult result = addEditContact.ShowDialog();
            if (result == DialogResult.OK)
            {
                _project.Сontacts.Add(newContact);
                ProjectManager.Save(_project, ProjectManager.Path);
                ClearAndFillList(_project.Сontacts);
            }
        }
        private void ClearAndFillList(List<Contact> Сontacts)
        {
            ContactListBox.Items.Clear();
            _project.Сontacts.Sort(delegate (Contact x, Contact y)
            {
                if (x.Surname == null && y.Surname == null) return 0;
                else if (x.Surname == null) return -1;
                else if (y.Surname == null) return 1;
                else return x.Surname.CompareTo(y.Surname);
            });

            for (int i = 0; i < _project.Сontacts.Count; i++)
            {
                ContactListBox.Items.Insert(i, _project.Сontacts[i].Surname);
            }
            if(ContactListBox.SelectedIndex != -1)
            {
                ContactListBox.SelectedIndex = 0;
            }
            
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
            AddContact();
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

        private void EditContactButton_Click(object sender, EventArgs e)
        {
            EditContact();
        }

        private void RemoveContactButton_Click(object sender, EventArgs e)
        {
            RemoveContact();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ProjectManager.Save(_project, ProjectManager.Path);
        }

        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {
            ContactListBox.Items.Clear();
            for (int i = 0; i < _project.Сontacts.Count; i++)
            {
                if (_project.Сontacts[i].Surname.Contains(FindTextBox.Text))
                {
                    ContactListBox.Items.Add(_project.Сontacts[i].Surname);
                }
            }
            if (ContactListBox.SelectedIndex != -1)
            {
                ContactListBox.SelectedIndex = 0;
            }
        }

        private void AddContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddContact();
        }

        private void EditContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditContact();
        }

        private void RemoveContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveContact();
        }
    }
}
