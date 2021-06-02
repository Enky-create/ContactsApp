using ContactsApp;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ContactsAppUI
{
    public partial class MainForm : Form
    {
        private  Project  _project = ProjectManager.Load(ProjectManager.Path);
        
        private void CleanTextboxes()
        {
            SurnameTextBox.Text = "";
            NametextBox.Text = "";
            BirthdaydateTimePicker.Value = DateTime.Now;
            PhonetextBox.Text = "";
            EmailtextBox.Text = "";
            VkBox.Text = "";
        }
        private void ShowContact(Contact contact)
        {
            SurnameTextBox.Text = contact.Surname;
            NametextBox.Text = contact.Name;
            BirthdaydateTimePicker.Value = contact.BirthDate;
            PhonetextBox.Text = contact.GetNumber();
            EmailtextBox.Text = contact.Email;
            VkBox.Text = contact.IdVkontakte;
        }
        private void CheckBirthday(List<Contact> contacts)
        {
            var birthDayContacts = new List<Contact>();
            DateTime date = DateTime.Now.Date;
            foreach (Contact contact in contacts)
            {
                if (contact.BirthDate.Date == date)
                {
                    birthDayContacts.Add(contact);
                }
            }
            if (birthDayContacts.Count > 0)
            {
                Birthdaypanel.Visible = true;
                BirthdayLabel.Text = "Today birthday ";
                foreach (Contact contact in birthDayContacts)
                {
                    BirthdayLabel.Text = BirthdayLabel.Text + contact.Surname + " ";
                }
            }

        }
        private void RemoveContact()
        {
            var selectedItem = ContactListBox.SelectedIndex;
            var contacts = _project.Сontacts;
            if (selectedItem == -1)
            {
                MessageBox.Show("Chose contact");
            }
            else
            {
                contacts.Remove(contacts[selectedItem]);
                ProjectManager.Save(_project, ProjectManager.Path);
                ClearAndFillList(contacts);
                CleanTextboxes();
            }
        }
        private void EditContact()
        {
            var selectedItem = ContactListBox.SelectedIndex;
            var contacts = _project.Сontacts;
            if (selectedItem == -1)
            {
                MessageBox.Show("Chose contact");
            }
            else
            {
                var selectedContact = contacts[selectedItem];
                var editedContact = (Contact)(selectedContact.Clone());
                AddEditContact addEditContact = new AddEditContact();
                addEditContact.Contact = editedContact;
                DialogResult result = addEditContact.ShowDialog();
                if (result == DialogResult.OK)
                {
                    _project.Сontacts.Remove(contacts[selectedItem]);
                    _project.Сontacts.Add(editedContact);
                    ProjectManager.Save(_project, ProjectManager.Path);
                    ClearAndFillList(contacts);
                    CheckBirthday(contacts);
                    ShowContact(editedContact);
                }
            }
        }
        private void AddContact()
        {
            var contacts = _project.Сontacts;
            var newContact = new Contact();
            AddEditContact addEditContact = new AddEditContact { Contact = newContact };
            DialogResult result = addEditContact.ShowDialog();
            if (result == DialogResult.OK)
            {
                contacts.Add(newContact);
                ProjectManager.Save(_project, ProjectManager.Path);
                ClearAndFillList(contacts);
                CheckBirthday(contacts);
                ShowContact(newContact);
            }
        }
        private void ClearAndFillList(List<Contact> Сontacts)
        {
            var selectedItem = ContactListBox.SelectedIndex;
            var contacts = _project.Сontacts;
            ContactListBox.Items.Clear();
            SurnameComparer comparor = new SurnameComparer();
            contacts.Sort(comparor);
            for (int i = 0; i < contacts.Count; i++)
            {
                ContactListBox.Items.Insert(i, contacts[i]);
            }
            ContactListBox.DisplayMember = "Surname";
            if (selectedItem != -1)
            {
                selectedItem = 0;
            }

        }

        public MainForm()
        {
            InitializeComponent();
            var contacts = _project.Сontacts;
            if (contacts.Count != 0)
            {
                ClearAndFillList(contacts);
                CheckBirthday(contacts);
            }
        }

        private void AddContactButton_Click(object sender, EventArgs e)
        {
            AddContact();
        }

        private void ContactListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedContact = ContactListBox.SelectedIndex;
            if (selectedContact != -1)
            {
                var contact = (Contact)ContactListBox.SelectedItem;
                ShowContact(contact);
            }
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
            var contacts = _project.Сontacts;
            var selectedContact = ContactListBox.SelectedIndex;
            var enteredText = FindTextBox.Text.ToLower();
            ContactListBox.Items.Clear();
            for (int i = 0; i < contacts.Count; i++)
            {
                var surname = contacts[i].Surname.ToLower();
                var name = contacts[i].Name.ToLower();
                if (surname.Contains(enteredText) || 
                    name.Contains(enteredText))
                {
                    ContactListBox.Items.Add(contacts[i]);
                }
            }
            ContactListBox.DisplayMember = "Surname";
            if (selectedContact == -1)
            {
                selectedContact = 0;
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
