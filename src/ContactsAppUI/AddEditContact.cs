﻿using ContactsApp;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ContactsAppUI
{
    public partial class AddEditContact : Form
    {
        public Contact Contact { get; set; } = new Contact();

        public AddEditContact()
        {
            InitializeComponent();
        }

        private void AddEditContact_Load(object sender, EventArgs e)
        {
            SurnameTextBox.Text = Contact.Surname;
            NametextBox.Text = Contact.Name;
            BirthdateTimePicker.Value = Contact.BirthDate;
            PhoneTextBox.Text = Contact.GetNumber();
            EmailTextBox.Text = Contact.Email;
            VkTextBox.Text = Contact.IdVkontakte;
        }

        

        private void AddEditOkButton_Click(object sender, EventArgs e)
        {
            var textboxList = inputPanel.Controls.OfType<TextBox>();
            var isFilled = textboxList.Any(textBox => textBox.Text == "");
            if (!isFilled)
            {
                var errorLabels = inputPanel.Controls.OfType<Label>();
                var isEmrty = errorLabels.Any(label => label.Text != "");
                if (!isEmrty)
                {
                    this.DialogResult = DialogResult.OK;
                }
            }
            else
            {
                MessageBox.Show("fill all inputs");
            }
        }


        private void BirthdateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            BirthdateTimePickerLabel.Text = "";
            try
            {
                Contact.BirthDate = BirthdateTimePicker.Value;
            }
            catch (ArgumentException exception)
            {
                BirthdateTimePickerLabel.Text = exception.Message;
            }
        }

        private void SurnameTextBox_TextChanged(object sender, EventArgs e)
        {
            SurnameWarninglabel.Text = "";

            try 
            {
                Contact.Surname = SurnameTextBox.Text;
            }
            catch (ArgumentException exception)
            {
                SurnameWarninglabel.Text = exception.Message;
            }
        }

        private void NametextBox_TextChanged(object sender, EventArgs e)
        {
            NameWarningLabel.Text = "";
            try
            {
                Contact.Name = NametextBox.Text;
            }
            catch(ArgumentException exception)
            {
                NameWarningLabel.Text = exception.Message;
            }
        }

        private void PhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            var phoneLength = 11;
            var errorText = PhoneMaskedTextBoxLabel.Text;
            var phoneText = PhoneTextBox.Text;
            errorText = "";
            if (phoneText.Length != phoneLength)
            {
                errorText =String.Join(
                    " ", 
                    "Length of number ",
                    PhoneTextBox.Text.Length,
                    "it must be ",
                    phoneLength);
            }
            else
            {
                try
                {
                    var contactNumber = Contact.PhoneNumber;
                    contactNumber.CountryCode = phoneText.Substring(0, 1);
                    contactNumber.CityCode = phoneText.Substring(1, 3);
                    contactNumber.SubscriberCode = phoneText.Substring(4);

                }
                catch (ArgumentException exception)
                {
                    errorText = exception.Message;
                }
            }
        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            EmailTextBoxLabel.Text = "";
            try
            {
                Contact.Email = EmailTextBox.Text;
            }
            catch (ArgumentException exception)
            {
                EmailTextBoxLabel.Text = exception.Message;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            VkTextBoxLabel.Text = "";
            try
            {
                Contact.IdVkontakte = VkTextBox.Text;
            }
            catch (ArgumentException exception)
            {
                VkTextBoxLabel.Text = exception.Message;
            }
        }

        private void AddEditCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
