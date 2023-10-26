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
    public partial class ItemsForm : Form
    {
        DataAccess db = new DataAccess();
        Users User = new Users();   

        public ItemsForm(Users user)
        {
            User = user;
            InitializeComponent();

            ResetTextBoxes();
        }


        void ResetTextBoxes()
        {

            NomeTextBox.Text = "";
            PrezzoTextBox.Text = "";
            CategoriaDropDown.SelectedItem = null;

            var items = db.GetAllItems();
            ItemGridView.DataSource = items;
        }
        bool ValidateItemsAdd()
        {

            bool output = true;

            if (NomeTextBox.Text.Length == 0)
            {
                return false;
            }
            if (PrezzoTextBox.Text.Length == 0 || double.TryParse(PrezzoTextBox.Text, out double numero2) != true)
            {
                MessageBox.Show("Prezzo non è un numero");
                return false;
            }
            if (CategoriaDropDown.SelectedItem == null)
            {
                MessageBox.Show("non hai selezionato una categoria");
                return false;
            }
            else
            {
                return output;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UtentiButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            UsersForm frm = new UsersForm(User);
            frm.Show();
        }

        private void MenuOrdineButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserOrderForm frm = new UserOrderForm(User);
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
            if (ValidateItemsAdd())
            {
                Items item = new Items();
                item.Nome = NomeTextBox.Text;
                item.Prezzo = double.Parse(PrezzoTextBox.Text);
                item.Categoria = CategoriaDropDown.SelectedItem.ToString();
                db.InsertItem(item);

                ResetTextBoxes();
            }
        }

        private void ModificaButton_Click(object sender, EventArgs e)
        {
            int numeroId = int.Parse(ItemGridView.SelectedRows[0].Cells[0].Value.ToString());
            Items item = db.GetItemFromId(numeroId);
            if (item != null)
            {

                item.Nome = NomeTextBox.Text;
                item.Prezzo = double.Parse(PrezzoTextBox.Text);
                item.Categoria = CategoriaDropDown.SelectedItem.ToString();
                db.EditItemsTable(item);
            }
            ResetTextBoxes();
        }

        private void CancellaButton_Click(object sender, EventArgs e)
        {
            int numeroId = int.Parse(ItemGridView.SelectedRows[0].Cells[0].Value.ToString());
            Items item = db.GetItemFromId(numeroId);
            db.DeleteFromItemsTable(item);

            ResetTextBoxes();
        }

        private void ItemGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            NomeTextBox.Text = ItemGridView.SelectedRows[0].Cells[1].Value.ToString();
            PrezzoTextBox.Text = ItemGridView.SelectedRows[0].Cells[2].Value.ToString();
            CategoriaDropDown.SelectedItem = ItemGridView.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void ItemGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            NomeTextBox.Text = ItemGridView.SelectedRows[0].Cells[1].Value.ToString();
            PrezzoTextBox.Text = ItemGridView.SelectedRows[0].Cells[2].Value.ToString();
            CategoriaDropDown.SelectedItem = ItemGridView.SelectedRows[0].Cells[3].Value.ToString();
        }
    }
}
