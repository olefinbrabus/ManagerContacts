using System.Text.RegularExpressions;

namespace Менеджер_контактів
{
    public partial class AddAccount : Form
    {
        private CsvFileManager _Manager;

        public AddAccount()
        {
            InitializeComponent();
            _Manager = CsvFileManager.GetInstance();
        }

        private void bSend_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" && tbMainPhone.Text == "")
            {
                MessageBox.Show("В обов'язкових полях нічого немає.\nСпробуйте ще. ");
            }
            else if (ValidationForm())
            {
                string[] form =
                {
                    tbName.Text, tbSurname.Text, tbMainPhone.Text, tbSecondPhone.Text
                };

                _Manager.AddRow(form);
                bExit_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Поля не правильні.\nСпробуйте ще. ");
            }
        }

        private bool ValidationForm()
        {
            return AverageValidaton(tbName.Text) &&
                    AverageValidaton(tbSurname.Text) &&
                    IsValidPhoneNumber(tbMainPhone.Text) &&
                    IsValidPhoneNumber(tbMainPhone.Text);
        }

        private static bool AverageValidaton(string text) => text == "" || text.All(char.IsLetter);

        static bool IsValidPhoneNumber(string phoneNumber)
        {
            string pattern = @"^\(?\d{3}\)?[-.\s]?\d{3}[-.\s]?\d{4}$";
            return Regex.IsMatch(phoneNumber, pattern) || phoneNumber == "";
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
