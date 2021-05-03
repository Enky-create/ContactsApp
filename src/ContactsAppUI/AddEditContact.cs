using ContactsApp;
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
            PhoneTextBox.Text = Contact.PhoneNumber.CountryCode + Contact.PhoneNumber.CityCode
                + Contact.PhoneNumber.SubscriberCode;
            EmailTextBox.Text = Contact.Email;
            VkTextBox.Text = Contact.IdVkontakte;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void AddEditOkButton_Click(object sender, EventArgs e)
        {
            var isFilled = panel1.Controls.OfType<TextBox>().Any(textBox => textBox.Text == "");
            if (isFilled)
            {
                MessageBox.Show("Заполните все поля");
            }
            else
            {
                if(!(panel1.Controls.OfType<Label>().Any(label => label.Text == "")))
                {
                    MessageBox.Show("Исправьте поля");
                }
                
            }
        }


        private void BirthdateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            BirthdateTimePickerLabel.Text = "";
            try
            {
                Contact.BirthDate = BirthdateTimePicker.Value;
            }
            catch (ArgumentException evt)
            {
                BirthdateTimePickerLabel.Text = evt.Message;
            }
        }

        private void SurnameTextBox_TextChanged(object sender, EventArgs e)
        {
            SurnameWarninglabel.Text = "";

            try {
                Contact.Surname = SurnameTextBox.Text;
            }
            catch (ArgumentException evt)
            {
                SurnameWarninglabel.Text = evt.Message;
            }
        }

        private void NametextBox_TextChanged(object sender, EventArgs e)
        {
            NameWarningLabel.Text = "";
            try
            {
                Contact.Name = NametextBox.Text;
            }
            catch(ArgumentException evt)
            {
                NameWarningLabel.Text = evt.Message;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void PhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            var phoneLength = 11;
            PhoneMaskedTextBoxLabel.Text = "";
            if (PhoneTextBox.Text.Length != phoneLength)
            {
                PhoneMaskedTextBoxLabel.Text = "Длина номера " + PhoneTextBox.Text.Length
                    + "а должна быть "
                    + phoneLength;
            }
            else
            {
                try
                {
                    Contact.PhoneNumber.CountryCode = PhoneTextBox.Text.Substring(0, 1);
                    Contact.PhoneNumber.CityCode = PhoneTextBox.Text.Substring(1, 3);
                    Contact.PhoneNumber.SubscriberCode = PhoneTextBox.Text.Substring(4);

                }
                catch (ArgumentException evt)
                {
                    PhoneMaskedTextBoxLabel.Text = evt.Message;
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
            catch (ArgumentException evt)
            {
                EmailTextBoxLabel.Text = evt.Message;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            VkTextBoxLabel.Text = "";
            try
            {
                Contact.IdVkontakte = VkTextBox.Text;
            }
            catch (ArgumentException evt)
            {
                VkTextBoxLabel.Text = evt.Message;
            }
        }
    }
}
