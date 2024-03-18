namespace Менеджер_контактів
{
    partial class AddAccount
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
            label1 = new Label();
            label2 = new Label();
            tbName = new TextBox();
            tbSurname = new TextBox();
            label3 = new Label();
            tbMainPhone = new TextBox();
            label4 = new Label();
            tbSecondPhone = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            bSend = new Button();
            bExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(188, 37);
            label1.TabIndex = 0;
            label1.Text = "Введіть данні:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 72);
            label2.Name = "label2";
            label2.Size = new Size(37, 21);
            label2.TabIndex = 1;
            label2.Text = "Ім'я";
            // 
            // tbName
            // 
            tbName.Location = new Point(12, 96);
            tbName.Name = "tbName";
            tbName.Size = new Size(242, 23);
            tbName.TabIndex = 2;
            // 
            // tbSurname
            // 
            tbSurname.Location = new Point(12, 146);
            tbSurname.Name = "tbSurname";
            tbSurname.Size = new Size(242, 23);
            tbSurname.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(12, 122);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 3;
            label3.Text = "Прізвище";
            // 
            // tbMainPhone
            // 
            tbMainPhone.Location = new Point(12, 196);
            tbMainPhone.Name = "tbMainPhone";
            tbMainPhone.Size = new Size(242, 23);
            tbMainPhone.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(12, 172);
            label4.Name = "label4";
            label4.Size = new Size(153, 21);
            label4.TabIndex = 5;
            label4.Text = "Мобільний телефон";
            // 
            // tbSecondPhone
            // 
            tbSecondPhone.Location = new Point(12, 246);
            tbSecondPhone.Name = "tbSecondPhone";
            tbSecondPhone.Size = new Size(242, 23);
            tbSecondPhone.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(12, 222);
            label5.Name = "label5";
            label5.Size = new Size(137, 21);
            label5.TabIndex = 7;
            label5.Text = "Робочий телефон";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(260, 96);
            label6.Name = "label6";
            label6.Size = new Size(12, 15);
            label6.TabIndex = 9;
            label6.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(260, 196);
            label7.Name = "label7";
            label7.Size = new Size(12, 15);
            label7.TabIndex = 10;
            label7.Text = "*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 272);
            label8.Name = "label8";
            label8.Size = new Size(118, 15);
            label8.TabIndex = 11;
            label8.Text = "* - Обов`язкові поля";
            // 
            // bSend
            // 
            bSend.Location = new Point(12, 323);
            bSend.Name = "bSend";
            bSend.Size = new Size(137, 52);
            bSend.TabIndex = 12;
            bSend.Text = "Добавити";
            bSend.UseVisualStyleBackColor = true;
            bSend.Click += bSend_Click;
            // 
            // bExit
            // 
            bExit.Location = new Point(155, 323);
            bExit.Name = "bExit";
            bExit.Size = new Size(117, 52);
            bExit.TabIndex = 13;
            bExit.Text = "Відминити";
            bExit.UseVisualStyleBackColor = true;
            bExit.Click += bExit_Click;
            // 
            // AddAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(283, 388);
            Controls.Add(bExit);
            Controls.Add(bSend);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(tbSecondPhone);
            Controls.Add(label5);
            Controls.Add(tbMainPhone);
            Controls.Add(label4);
            Controls.Add(tbSurname);
            Controls.Add(label3);
            Controls.Add(tbName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddAccount";
            Text = "Створення нового контакта";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbName;
        private TextBox tbSurname;
        private Label label3;
        private TextBox tbMainPhone;
        private Label label4;
        private TextBox tbSecondPhone;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button bSend;
        private Button bExit;
    }
}