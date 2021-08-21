﻿using ContactsApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ContactsAppUI
{
    public partial class MainForm : Form
    {
        private  Project  _project = ProjectManager.Load(ProjectManager.Path);
     
        /// <summary>
        /// Удаляет контакт
        /// </summary>
        private void RemoveContact()
        {
            var selectedItem = ContactListBox.SelectedIndex;
            var contacts = _project.Сontacts;
            if (selectedItem == -1)
            {
                MessageBox.Show("Choose contact");
            }
            else
            {
                contacts.Remove(contacts[selectedItem]);
                ProjectManager.Save(_project, ProjectManager.Path);
                UpdateList(contacts);
                CleanTextboxes();
            }
        }

        /// <summary>
        /// Редактирует контакт
        /// </summary>
        private void EditContact()
        {
            var selectedItem = ContactListBox.SelectedIndex;
            var contacts = _project.Сontacts;
            if (selectedItem == -1)
            {
                MessageBox.Show("Choose contact");
            }
            else
            {
                var selectedContact = (Contact)ContactListBox.SelectedItem;
                var editedContact = (Contact)(selectedContact.Clone());
                ContactForm сontactForm = new ContactForm();
                сontactForm.Contact = editedContact;
                DialogResult result = сontactForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    _project.Сontacts.Remove(selectedContact);
                    _project.Сontacts.Add(editedContact);
                    ProjectManager.Save(_project, ProjectManager.Path);
                    UpdateList(contacts);
                    CheckBirthday(contacts);
                    ShowContact(editedContact);
                }
            }
        }

        /// <summary>
        /// Добавляет контакт
        /// </summary>
        private void AddContact()
        {
            var contacts = _project.Сontacts;
            var newContact = new Contact();
            ContactForm addEditContact = new ContactForm { Contact = newContact };
            DialogResult result = addEditContact.ShowDialog();
            if (result == DialogResult.OK)
            {
                contacts.Add(newContact);
                ProjectManager.Save(_project, ProjectManager.Path);
                UpdateList(contacts);
                CheckBirthday(contacts);
                ShowContact(newContact);
            }
        }

        /// <summary>
        /// Обновляет список
        /// </summary>
        /// <param name="Сontacts"></param>
        private void UpdateList(List<Contact> Сontacts)
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
        /// <summary>
        /// Очищает все текстовые поля
        /// </summary>
        private void CleanTextboxes()
        {
            SurnameTextBox.Text = "";
            NametextBox.Text = "";
            BirthdaydateTimePicker.Value = DateTime.Now;
            PhonetextBox.Text = "";
            EmailtextBox.Text = "";
            VkBox.Text = "";
            TypeComboBox.SelectedIndex = 0;
        }
        /// <summary>
        /// Показывает контакт на правой панели MainForm, а также отмечает его в списке контактов 
        /// </summary>
        /// <param name="contact"></param>
        private void ShowContact(Contact contact)
        {
            SurnameTextBox.Text = contact.Surname;
            NametextBox.Text = contact.Name;
            BirthdaydateTimePicker.Value = contact.BirthDate;
            PhonetextBox.Text = contact.GetNumber();
            EmailtextBox.Text = contact.Email;
            VkBox.Text = contact.IdVkontakte;
            TypeComboBox.SelectedIndex = (int)contact.PhoneNumber.Type;
            for (int i = 0; i < ContactListBox.Items.Count; i++)
            {
                if (ContactListBox.Items[i] == contact)
                {
                    ContactListBox.SelectedIndex = i;
                }
            }
        }

        /// <summary>
        /// Проверяет и отрисовывает контакты у которых день рождения совпадает с Datetime.Now
        /// </summary>
        /// <param name="contacts"></param>
        private void CheckBirthday(List<Contact> contacts)
        {
            var birthDayContacts = new List<Contact>();
            var date = DateTime.Now.Date;
            foreach (Contact contact in contacts)
            {
                var birthDate = contact.BirthDate.Date;
                if (birthDate.Day == date.Day && birthDate.Month == date.Month)
                {
                    birthDayContacts.Add(contact);
                }
            }
            if (birthDayContacts.Count > 0)
            {
                Birthdaypanel.Visible = true;
                BirthdayLabel.Text = "Today birthday :";
                var surnames = birthDayContacts.Select(contact => contact.Surname).ToList();
                foreach (Contact contact in birthDayContacts)
                {
                    BirthdayLabel.Text = BirthdayLabel.Text + contact.Surname + " ";
                }
            }
            else
            {
                Birthdaypanel.Visible = false;
            }

        }
        /// <summary>
        /// Инициализирует MainForm
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            TypeComboBox.SelectedIndex = 0;
            var contacts = _project.Сontacts;
            if (contacts.Count != 0)
            {
                UpdateList(contacts);
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
            var contacts = _project.Сontacts;
            RemoveContact();
            CheckBirthday(contacts);
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
            CleanTextboxes();
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
            var contacts = _project.Сontacts;
            RemoveContact();
            CheckBirthday(contacts);
        }
    }
}
