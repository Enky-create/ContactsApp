﻿
namespace ContactsAppUI
{
    partial class ContactForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactForm));
            this.inputPanel = new System.Windows.Forms.Panel();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.VkTextBoxLabel = new System.Windows.Forms.Label();
            this.EmailTextBoxLabel = new System.Windows.Forms.Label();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.PhoneMaskedTextBoxLabel = new System.Windows.Forms.Label();
            this.BirthdateTimePickerLabel = new System.Windows.Forms.Label();
            this.NameWarningLabel = new System.Windows.Forms.Label();
            this.SurnameWarninglabel = new System.Windows.Forms.Label();
            this.VkTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.BirthdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inputPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputPanel
            // 
            this.inputPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputPanel.Controls.Add(this.TypeComboBox);
            this.inputPanel.Controls.Add(this.VkTextBoxLabel);
            this.inputPanel.Controls.Add(this.EmailTextBoxLabel);
            this.inputPanel.Controls.Add(this.PhoneTextBox);
            this.inputPanel.Controls.Add(this.PhoneMaskedTextBoxLabel);
            this.inputPanel.Controls.Add(this.BirthdateTimePickerLabel);
            this.inputPanel.Controls.Add(this.NameWarningLabel);
            this.inputPanel.Controls.Add(this.SurnameWarninglabel);
            this.inputPanel.Controls.Add(this.VkTextBox);
            this.inputPanel.Controls.Add(this.EmailTextBox);
            this.inputPanel.Controls.Add(this.NametextBox);
            this.inputPanel.Controls.Add(this.SurnameTextBox);
            this.inputPanel.Controls.Add(this.BirthdateTimePicker);
            this.inputPanel.Location = new System.Drawing.Point(64, 9);
            this.inputPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new System.Drawing.Size(301, 258);
            this.inputPanel.TabIndex = 0;
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Items.AddRange(new object[] {
            "Mobile",
            "Home"});
            this.TypeComboBox.Location = new System.Drawing.Point(83, 128);
            this.TypeComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(102, 21);
            this.TypeComboBox.TabIndex = 22;
            this.TypeComboBox.SelectedIndexChanged += new System.EventHandler(this.TypeComboBox_SelectedIndexChanged);
            // 
            // VkTextBoxLabel
            // 
            this.VkTextBoxLabel.AutoSize = true;
            this.VkTextBoxLabel.ForeColor = System.Drawing.Color.Maroon;
            this.VkTextBoxLabel.Location = new System.Drawing.Point(4, 234);
            this.VkTextBoxLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.VkTextBoxLabel.Name = "VkTextBoxLabel";
            this.VkTextBoxLabel.Size = new System.Drawing.Size(0, 13);
            this.VkTextBoxLabel.TabIndex = 21;
            // 
            // EmailTextBoxLabel
            // 
            this.EmailTextBoxLabel.AutoSize = true;
            this.EmailTextBoxLabel.ForeColor = System.Drawing.Color.Maroon;
            this.EmailTextBoxLabel.Location = new System.Drawing.Point(4, 192);
            this.EmailTextBoxLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EmailTextBoxLabel.Name = "EmailTextBoxLabel";
            this.EmailTextBoxLabel.Size = new System.Drawing.Size(0, 13);
            this.EmailTextBoxLabel.TabIndex = 20;
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(4, 128);
            this.PhoneTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(76, 20);
            this.PhoneTextBox.TabIndex = 19;
            this.PhoneTextBox.TextChanged += new System.EventHandler(this.PhoneTextBox_TextChanged);
            // 
            // PhoneMaskedTextBoxLabel
            // 
            this.PhoneMaskedTextBoxLabel.AutoSize = true;
            this.PhoneMaskedTextBoxLabel.ForeColor = System.Drawing.Color.Maroon;
            this.PhoneMaskedTextBoxLabel.Location = new System.Drawing.Point(2, 147);
            this.PhoneMaskedTextBoxLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PhoneMaskedTextBoxLabel.Name = "PhoneMaskedTextBoxLabel";
            this.PhoneMaskedTextBoxLabel.Size = new System.Drawing.Size(0, 13);
            this.PhoneMaskedTextBoxLabel.TabIndex = 18;
            // 
            // BirthdateTimePickerLabel
            // 
            this.BirthdateTimePickerLabel.AutoSize = true;
            this.BirthdateTimePickerLabel.ForeColor = System.Drawing.Color.Maroon;
            this.BirthdateTimePickerLabel.Location = new System.Drawing.Point(2, 100);
            this.BirthdateTimePickerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BirthdateTimePickerLabel.Name = "BirthdateTimePickerLabel";
            this.BirthdateTimePickerLabel.Size = new System.Drawing.Size(0, 13);
            this.BirthdateTimePickerLabel.TabIndex = 17;
            // 
            // NameWarningLabel
            // 
            this.NameWarningLabel.AutoSize = true;
            this.NameWarningLabel.ForeColor = System.Drawing.Color.Maroon;
            this.NameWarningLabel.Location = new System.Drawing.Point(2, 57);
            this.NameWarningLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameWarningLabel.Name = "NameWarningLabel";
            this.NameWarningLabel.Size = new System.Drawing.Size(0, 13);
            this.NameWarningLabel.TabIndex = 16;
            // 
            // SurnameWarninglabel
            // 
            this.SurnameWarninglabel.AutoSize = true;
            this.SurnameWarninglabel.ForeColor = System.Drawing.Color.Maroon;
            this.SurnameWarninglabel.Location = new System.Drawing.Point(2, 20);
            this.SurnameWarninglabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SurnameWarninglabel.Name = "SurnameWarninglabel";
            this.SurnameWarninglabel.Size = new System.Drawing.Size(0, 13);
            this.SurnameWarninglabel.TabIndex = 15;
            // 
            // VkTextBox
            // 
            this.VkTextBox.Location = new System.Drawing.Point(4, 213);
            this.VkTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.VkTextBox.Name = "VkTextBox";
            this.VkTextBox.Size = new System.Drawing.Size(290, 20);
            this.VkTextBox.TabIndex = 14;
            this.VkTextBox.TextChanged += new System.EventHandler(this.VkTextBox_TextChanged);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(4, 171);
            this.EmailTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(290, 20);
            this.EmailTextBox.TabIndex = 13;
            this.EmailTextBox.TextChanged += new System.EventHandler(this.EmailTextBox_TextChanged);
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(4, 37);
            this.NametextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(290, 20);
            this.NametextBox.TabIndex = 12;
            this.NametextBox.TextChanged += new System.EventHandler(this.NametextBox_TextChanged);
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(4, 0);
            this.SurnameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(290, 20);
            this.SurnameTextBox.TabIndex = 3;
            this.SurnameTextBox.TextChanged += new System.EventHandler(this.SurnameTextBox_TextChanged);
            // 
            // BirthdateTimePicker
            // 
            this.BirthdateTimePicker.Location = new System.Drawing.Point(4, 80);
            this.BirthdateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BirthdateTimePicker.Name = "BirthdateTimePicker";
            this.BirthdateTimePicker.Size = new System.Drawing.Size(151, 20);
            this.BirthdateTimePicker.TabIndex = 4;
            this.BirthdateTimePicker.ValueChanged += new System.EventHandler(this.BirthdateTimePicker_ValueChanged);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CancelButton.Location = new System.Drawing.Point(282, 271);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(74, 28);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OkButton.Location = new System.Drawing.Point(199, 271);
            this.OkButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(79, 28);
            this.OkButton.TabIndex = 2;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(7, 9);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(56, 258);
            this.panel2.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 216);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "vk.com:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 174);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "E-mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Phone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Birthday:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Surname:";
            // 
            // AddEditContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 314);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.inputPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(391, 353);
            this.MinimumSize = new System.Drawing.Size(391, 353);
            this.Name = "AddEditContact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Edit Contact";
            this.Load += new System.EventHandler(this.ContactForm_Load);
            this.inputPanel.ResumeLayout(false);
            this.inputPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel inputPanel;
        private System.Windows.Forms.DateTimePicker BirthdateTimePicker;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.TextBox VkTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.Label SurnameWarninglabel;
        private System.Windows.Forms.Label NameWarningLabel;
        private System.Windows.Forms.Label BirthdateTimePickerLabel;
        private System.Windows.Forms.Label PhoneMaskedTextBoxLabel;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.Label EmailTextBoxLabel;
        private System.Windows.Forms.Label VkTextBoxLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TypeComboBox;
    }
}