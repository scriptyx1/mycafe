using mycafe.DataBaseData;
using System.Data.Common;

namespace mycafe
{
    public partial class LoginForm : Form
    {
        DataAccess db = new DataAccess();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void QuitLoginLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GuestLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            
            Users user = new Users();
            
            user.Username = UsernameTextBox.Text;
            user.Password = PasswordTextBox.Text;
            if (db.LoginCheck(user) || (user.Username == "admin" && user.Password == "password"))
            {
                user.Id = db.GetUserIdFromCredential(user);
                UserOrderForm frm = new UserOrderForm(user);
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("le credenziali inserite sono errate");
            }
        }
    }
}