namespace Менеджер_контактів
{
    partial class DeleteForm
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
            bExit = new Button();
            bDelete = new Button();
            clbToDelete = new CheckedListBox();
            SuspendLayout();
            // 
            // bExit
            // 
            bExit.Location = new Point(202, 554);
            bExit.Name = "bExit";
            bExit.Size = new Size(163, 52);
            bExit.TabIndex = 15;
            bExit.Text = "Відминити";
            bExit.UseVisualStyleBackColor = true;
            bExit.Click += bExit_Click;
            // 
            // bDelete
            // 
            bDelete.Location = new Point(12, 554);
            bDelete.Name = "bDelete";
            bDelete.Size = new Size(184, 52);
            bDelete.TabIndex = 14;
            bDelete.Text = "Видалити";
            bDelete.UseVisualStyleBackColor = true;
            bDelete.Click += bDelete_Click;
            // 
            // clbToDelete
            // 
            clbToDelete.FormattingEnabled = true;
            clbToDelete.Location = new Point(12, 12);
            clbToDelete.Name = "clbToDelete";
            clbToDelete.Size = new Size(353, 526);
            clbToDelete.TabIndex = 16;
            // 
            // DeleteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 618);
            Controls.Add(clbToDelete);
            Controls.Add(bExit);
            Controls.Add(bDelete);
            Name = "DeleteForm";
            Text = "DeleteForm";
            ResumeLayout(false);
        }

        #endregion

        private Button bExit;
        private Button bDelete;
        private CheckedListBox clbToDelete;
    }
}