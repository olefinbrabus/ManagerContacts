using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Менеджер_контактів
{
    public partial class DeleteForm : Form
    {
        private CsvFileManager _Manager;
        public DeleteForm()
        {
            InitializeComponent();

            _Manager = CsvFileManager.GetInstance();
            InitializeToDeleteComponent();
        }

        private void InitializeToDeleteComponent()
        {
            clbToDelete.Items.Clear();
            List<string> contacts = _Manager.Read();
            if (contacts.Count != 1)
            {
                contacts.RemoveAt(0);
                clbToDelete.Items.AddRange(contacts.ToArray());
            }
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            var checkedIndices = clbToDelete.CheckedIndices;

            foreach (int i in checkedIndices)
            {
                _Manager.DeleteRow(i+1);
            }

            InitializeToDeleteComponent();
        }
        private void bExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
