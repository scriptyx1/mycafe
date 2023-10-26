using mycafe.DataBaseData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mycafe
{
    public partial class UsersForm : Form
    {
        DataAccess db = new DataAccess();
        Users User = new Users();


        public UsersForm(Users user)
        {
            InitializeComponent();
            User = user;
        }

        void PopulateGV()
        {
            List<Users> allusers = db.GetAllUsers();
            UsersGridView.DataSource = allusers;
        }

        void ResetTextBoxes()
        {
            UsernameTextBox.Text = "";
            PhoneTextBox.Text = "";
            PasswordTextBox.Text = "";
        }

        bool ValidateUsersAdd()
        {
            bool output = true;
            if (UsernameTextBox.Text.Length == 0)
            {
                return false;
            }
            if (PhoneTextBox.Text.Length == 0)
            {
                return false;
            }
            if (PasswordTextBox.Text.Length == 0)
            {
                return false;
            }
            else
            {
                return output;
            }
        }

        void RefreshTextBoxes()
        {
            ResetTextBoxes();

            UsernameTextBox.Text = UsersGridView.SelectedRows[0].Cells[1].Value.ToString();
            PhoneTextBox.Text = UsersGridView.SelectedRows[0].Cells[2].Value.ToString();
            PasswordTextBox.Text = UsersGridView.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void quitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuOrdineButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserOrderForm frm = new UserOrderForm(User);
            frm.Show();
        }

        private void ArticoliButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ItemsForm frm = new ItemsForm(User);
            frm.Show();
        }

        private void LogoutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginForm frm = new LoginForm();
            frm.Show();
        }

        private void AggiungiButton_Click(object sender, EventArgs e)
        {
            if (ValidateUsersAdd())
            {
                Users user = new Users();
                user.Username = UsernameTextBox.Text;
                user.Phone = PhoneTextBox.Text;
                user.Password = PasswordTextBox.Text;
                db.InsertPerson(user);

                ResetTextBoxes();

                PopulateGV();
            }
            else
            {
                MessageBox.Show("uno dei campi non contiene tutti i dati");
            }
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            PopulateGV();
        }



        private void CancellaButton_Click(object sender, EventArgs e)
        {

            db.DeleteFromUsersTable(UsersGridView.SelectedRows[0].Cells[1].Value.ToString());
            PopulateGV();
        }

        private void ModificaButton_Click(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text == "" || PasswordTextBox.Text == "" || PhoneTextBox.Text == "")
            {
                MessageBox.Show("non tutti i campi contengono un valore");
            }
            else
            {
                int selectedUserId = Convert.ToInt32(UsersGridView.SelectedRows[0].Cells[0].Value);
                Users user = db.GetUserById(selectedUserId);
                if (user != null)
                {
                    user.Username = UsernameTextBox.Text;
                    user.Phone = PhoneTextBox.Text;
                    user.Password = PasswordTextBox.Text;
                    db.EditUsersTable(user);
                    PopulateGV();
                }


                //non riesci a far si che il modifica tiri fuori l'id della persona per far si che la stored procedure usi quell'id
            }
        }

        private void UsersGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RefreshTextBoxes();
        }
        private void UsersGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RefreshTextBoxes();
        }
    }
}


