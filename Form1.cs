using System.Text;

namespace Менеджер_контактів
{
    public partial class ContactManager : Form
    {
        private CsvFileManager? _Manager;

        public ContactManager()
        {
            InitializeComponent();
            _Manager = CsvFileManager.GetInstance();
            Update();

        }

        private void Add(object sender, EventArgs e)
        {
            AddAccount account = new AddAccount();

            account.ShowDialog();
            Update();

        }

        private void Update()
        {
            rtbContacts.Text = string.Join(Environment.NewLine, _Manager.Read());
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bDeleteContact_Click(object sender, EventArgs e)
        {
            DeleteForm deleteForm = new DeleteForm();

            deleteForm.ShowDialog();
            Update();
        }

        private void bSorting_Click(object sender, EventArgs e)
        {
            Update();
        }
    }
}
