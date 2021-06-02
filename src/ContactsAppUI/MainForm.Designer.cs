
namespace ContactsAppUI
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.RemoveContactButton = new System.Windows.Forms.Button();
            this.EditContactButton = new System.Windows.Forms.Button();
            this.AddContactButton = new System.Windows.Forms.Button();
            this.ContactListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FindTextBox = new System.Windows.Forms.TextBox();
            this.Birthdaypanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BirthdayLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.VkBox = new System.Windows.Forms.TextBox();
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.PhonetextBox = new System.Windows.Forms.TextBox();
            this.BirthdaydateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.Birthdaypanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1280, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddContactToolStripMenuItem,
            this.EditContactToolStripMenuItem,
            this.RemoveContactToolStripMenuItem});
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(49, 26);
            this.EditToolStripMenuItem.Text = "Edit";
            // 
            // AddContactToolStripMenuItem
            // 
            this.AddContactToolStripMenuItem.Name = "AddContactToolStripMenuItem";
            this.AddContactToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.AddContactToolStripMenuItem.Text = "Add Contact";
            this.AddContactToolStripMenuItem.Click += new System.EventHandler(this.AddContactToolStripMenuItem_Click);
            // 
            // EditContactToolStripMenuItem
            // 
            this.EditContactToolStripMenuItem.Name = "EditContactToolStripMenuItem";
            this.EditContactToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.EditContactToolStripMenuItem.Text = "Edit Contact";
            this.EditContactToolStripMenuItem.Click += new System.EventHandler(this.EditContactToolStripMenuItem_Click);
            // 
            // RemoveContactToolStripMenuItem
            // 
            this.RemoveContactToolStripMenuItem.Name = "RemoveContactToolStripMenuItem";
            this.RemoveContactToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.RemoveContactToolStripMenuItem.Text = "Remove Contact";
            this.RemoveContactToolStripMenuItem.Click += new System.EventHandler(this.RemoveContactToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(55, 26);
            this.HelpToolStripMenuItem.Text = "Help";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.AboutToolStripMenuItem.Text = "About";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 30);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.RemoveContactButton);
            this.splitContainer1.Panel1.Controls.Add(this.EditContactButton);
            this.splitContainer1.Panel1.Controls.Add(this.AddContactButton);
            this.splitContainer1.Panel1.Controls.Add(this.ContactListBox);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.FindTextBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Birthdaypanel);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.VkBox);
            this.splitContainer1.Panel2.Controls.Add(this.EmailtextBox);
            this.splitContainer1.Panel2.Controls.Add(this.PhonetextBox);
            this.splitContainer1.Panel2.Controls.Add(this.BirthdaydateTimePicker);
            this.splitContainer1.Panel2.Controls.Add(this.NametextBox);
            this.splitContainer1.Panel2.Controls.Add(this.SurnameTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(1280, 642);
            this.splitContainer1.SplitterDistance = 380;
            this.splitContainer1.TabIndex = 1;
            // 
            // RemoveContactButton
            // 
            this.RemoveContactButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveContactButton.FlatAppearance.BorderSize = 0;
            this.RemoveContactButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveContactButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveContactButton.ForeColor = System.Drawing.Color.Red;
            this.RemoveContactButton.Location = new System.Drawing.Point(137, 584);
            this.RemoveContactButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RemoveContactButton.Name = "RemoveContactButton";
            this.RemoveContactButton.Size = new System.Drawing.Size(59, 48);
            this.RemoveContactButton.TabIndex = 5;
            this.RemoveContactButton.Text = "-";
            this.RemoveContactButton.UseVisualStyleBackColor = true;
            this.RemoveContactButton.Click += new System.EventHandler(this.RemoveContactButton_Click);
            // 
            // EditContactButton
            // 
            this.EditContactButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditContactButton.FlatAppearance.BorderSize = 0;
            this.EditContactButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditContactButton.Image = ((System.Drawing.Image)(resources.GetObject("EditContactButton.Image")));
            this.EditContactButton.Location = new System.Drawing.Point(75, 584);
            this.EditContactButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditContactButton.Name = "EditContactButton";
            this.EditContactButton.Size = new System.Drawing.Size(57, 48);
            this.EditContactButton.TabIndex = 4;
            this.EditContactButton.UseVisualStyleBackColor = true;
            this.EditContactButton.Click += new System.EventHandler(this.EditContactButton_Click);
            // 
            // AddContactButton
            // 
            this.AddContactButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddContactButton.BackColor = System.Drawing.SystemColors.Menu;
            this.AddContactButton.FlatAppearance.BorderSize = 0;
            this.AddContactButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddContactButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddContactButton.ForeColor = System.Drawing.Color.Lime;
            this.AddContactButton.Location = new System.Drawing.Point(15, 584);
            this.AddContactButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddContactButton.Name = "AddContactButton";
            this.AddContactButton.Size = new System.Drawing.Size(53, 48);
            this.AddContactButton.TabIndex = 3;
            this.AddContactButton.Text = "+";
            this.AddContactButton.UseVisualStyleBackColor = false;
            this.AddContactButton.Click += new System.EventHandler(this.AddContactButton_Click);
            // 
            // ContactListBox
            // 
            this.ContactListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ContactListBox.FormattingEnabled = true;
            this.ContactListBox.IntegralHeight = false;
            this.ContactListBox.ItemHeight = 16;
            this.ContactListBox.Location = new System.Drawing.Point(15, 37);
            this.ContactListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ContactListBox.Name = "ContactListBox";
            this.ContactListBox.Size = new System.Drawing.Size(335, 524);
            this.ContactListBox.TabIndex = 2;
            this.ContactListBox.SelectedIndexChanged += new System.EventHandler(this.ContactListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Find:";
            // 
            // FindTextBox
            // 
            this.FindTextBox.Location = new System.Drawing.Point(59, 7);
            this.FindTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.FindTextBox.Name = "FindTextBox";
            this.FindTextBox.Size = new System.Drawing.Size(291, 22);
            this.FindTextBox.TabIndex = 0;
            this.FindTextBox.TextChanged += new System.EventHandler(this.FindTextBox_TextChanged);
            // 
            // Birthdaypanel
            // 
            this.Birthdaypanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Birthdaypanel.Controls.Add(this.panel1);
            this.Birthdaypanel.Controls.Add(this.BirthdayLabel);
            this.Birthdaypanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Birthdaypanel.Location = new System.Drawing.Point(0, 519);
            this.Birthdaypanel.Margin = new System.Windows.Forms.Padding(4);
            this.Birthdaypanel.Name = "Birthdaypanel";
            this.Birthdaypanel.Size = new System.Drawing.Size(896, 123);
            this.Birthdaypanel.TabIndex = 12;
            this.Birthdaypanel.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(24, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(80, 80);
            this.panel1.TabIndex = 1;
            // 
            // BirthdayLabel
            // 
            this.BirthdayLabel.AutoSize = true;
            this.BirthdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BirthdayLabel.Location = new System.Drawing.Point(148, 21);
            this.BirthdayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BirthdayLabel.Name = "BirthdayLabel";
            this.BirthdayLabel.Size = new System.Drawing.Size(174, 25);
            this.BirthdayLabel.TabIndex = 0;
            this.BirthdayLabel.Text = "Today birthday at: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "vk.com:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "E-mail:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Phone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Birthday:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Surname:";
            // 
            // VkBox
            // 
            this.VkBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VkBox.Enabled = false;
            this.VkBox.Location = new System.Drawing.Point(91, 153);
            this.VkBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VkBox.Name = "VkBox";
            this.VkBox.Size = new System.Drawing.Size(790, 22);
            this.VkBox.TabIndex = 5;
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailtextBox.Enabled = false;
            this.EmailtextBox.Location = new System.Drawing.Point(91, 124);
            this.EmailtextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(790, 22);
            this.EmailtextBox.TabIndex = 4;
            // 
            // PhonetextBox
            // 
            this.PhonetextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PhonetextBox.Enabled = false;
            this.PhonetextBox.Location = new System.Drawing.Point(91, 95);
            this.PhonetextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PhonetextBox.Name = "PhonetextBox";
            this.PhonetextBox.Size = new System.Drawing.Size(790, 22);
            this.PhonetextBox.TabIndex = 3;
            // 
            // BirthdaydateTimePicker
            // 
            this.BirthdaydateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BirthdaydateTimePicker.Enabled = false;
            this.BirthdaydateTimePicker.Location = new System.Drawing.Point(91, 66);
            this.BirthdaydateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BirthdaydateTimePicker.MinimumSize = new System.Drawing.Size(298, 22);
            this.BirthdaydateTimePicker.Name = "BirthdaydateTimePicker";
            this.BirthdaydateTimePicker.Size = new System.Drawing.Size(341, 22);
            this.BirthdaydateTimePicker.TabIndex = 2;
            // 
            // NametextBox
            // 
            this.NametextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NametextBox.Enabled = false;
            this.NametextBox.Location = new System.Drawing.Point(91, 37);
            this.NametextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(790, 22);
            this.NametextBox.TabIndex = 1;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SurnameTextBox.Enabled = false;
            this.SurnameTextBox.Location = new System.Drawing.Point(91, 7);
            this.SurnameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(790, 22);
            this.SurnameTextBox.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 672);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1150, 633);
            this.Name = "MainForm";
            this.Text = "ContactsApp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.Birthdaypanel.ResumeLayout(false);
            this.Birthdaypanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button RemoveContactButton;
        private System.Windows.Forms.Button EditContactButton;
        private System.Windows.Forms.Button AddContactButton;
        private System.Windows.Forms.ListBox ContactListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FindTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox VkBox;
        private System.Windows.Forms.TextBox EmailtextBox;
        private System.Windows.Forms.TextBox PhonetextBox;
        private System.Windows.Forms.DateTimePicker BirthdaydateTimePicker;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel Birthdaypanel;
        private System.Windows.Forms.Label BirthdayLabel;
        private System.Windows.Forms.Panel panel1;
    }
}

