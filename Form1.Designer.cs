namespace Менеджер_контактів
{
    partial class ContactManager
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactManager));
            bAddContact = new Button();
            bDeleteContact = new Button();
            bSorting = new Button();
            bExit = new Button();
            rtbContacts = new RichTextBox();
            SuspendLayout();
            // 
            // bAddContact
            // 
            bAddContact.Location = new Point(12, 12);
            bAddContact.Name = "bAddContact";
            bAddContact.Size = new Size(199, 52);
            bAddContact.TabIndex = 0;
            bAddContact.Text = "Добавити";
            bAddContact.UseVisualStyleBackColor = true;
            bAddContact.Click += Add;
            // 
            // bDeleteContact
            // 
            bDeleteContact.Location = new Point(217, 12);
            bDeleteContact.Name = "bDeleteContact";
            bDeleteContact.Size = new Size(192, 52);
            bDeleteContact.TabIndex = 1;
            bDeleteContact.Text = "Видалити";
            bDeleteContact.UseVisualStyleBackColor = true;
            bDeleteContact.Click += bDeleteContact_Click;
            // 
            // bSorting
            // 
            bSorting.Location = new Point(12, 668);
            bSorting.Name = "bSorting";
            bSorting.Size = new Size(281, 52);
            bSorting.TabIndex = 3;
            bSorting.Text = "Оновити";
            bSorting.UseVisualStyleBackColor = true;
            bSorting.Click += bSorting_Click;
            // 
            // bExit
            // 
            bExit.Location = new Point(299, 668);
            bExit.Name = "bExit";
            bExit.Size = new Size(110, 52);
            bExit.TabIndex = 4;
            bExit.Text = "Закрити";
            bExit.UseVisualStyleBackColor = true;
            bExit.Click += bExit_Click;
            // 
            // rtbContacts
            // 
            rtbContacts.Location = new Point(12, 70);
            rtbContacts.Name = "rtbContacts";
            rtbContacts.Size = new Size(397, 592);
            rtbContacts.TabIndex = 5;
            rtbContacts.Text = "";
            // 
            // ContactManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 732);
            Controls.Add(rtbContacts);
            Controls.Add(bExit);
            Controls.Add(bSorting);
            Controls.Add(bDeleteContact);
            Controls.Add(bAddContact);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ContactManager";
            Text = "Менеджер контактів";
            ResumeLayout(false);
        }

        #endregion

        private Button bAddContact;
        private Button bDeleteContact;
        private Button bSorting;
        private Button bExit;
        private RichTextBox rtbContacts;
    }
}
