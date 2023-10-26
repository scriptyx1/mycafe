using mycafe.DataBaseData;
using mycafe.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mycafe
{
    public partial class UserOrderForm : Form
    {
        //TODO se non ricordo male c'era un problema con il resoconto dell'ordine finale, l'id utente era diverso da quello reale o addiritura era zero, controllare
        DataAccess db = new DataAccess();
        List<Items> items = new List<Items>();
        Order order = new Order();
        Users User = new Users();


        public UserOrderForm(Users user)
        {
            InitializeComponent();

            PopolaItemBasedOnCategoria();

            User = user;
            ClienteLabel.Text = User.Username;
        }

        void PopolaItemBasedOnCategoria()
        {

            var items = db.GetAllItems();
            List<Items> Cibi = new List<Items>();
            List<Items> Bevande = new List<Items>();
            foreach (Items item in items)
            {

                if (item.Categoria == "Cibi")
                {
                    Cibi.Add(item);


                }
                else if (item.Categoria == "Bevande")
                {
                    Bevande.Add(item);


                }
            }
            if (CategoriaDropDown.Text == "Cibi")
            {
                ItemGridView.DataSource = Cibi;
                ItemGridView.Columns.RemoveAt(4);
            }
            else if (CategoriaDropDown.Text == "Bevande")
            {
                ItemGridView.DataSource = Bevande;
                ItemGridView.Columns.RemoveAt(4);
            }

            RiepilogoGridView.DataSource = null;
            RiepilogoGridView.DataSource = order.Articoli;
        }

        void PrezzoTotale()
        {
            double prezzoTotale = 0;
            foreach (var item in order.Articoli)
            {
                double prezzoSingolo = item.Prezzo * item.Quantità;
                prezzoTotale = prezzoTotale + prezzoSingolo;
            }
            PrezzoTotaleLabel.Text = prezzoTotale.ToString();
        }

        Items PopulateItemObjForOrder(int id, string nome, double prezzo, string categoria, int quantità)
        {
            Items item = new Items();
            item.Id = id;
            item.Nome = nome;
            item.Prezzo = prezzo;
            item.Categoria = categoria;
            item.Quantità = quantità;
            return item;
        }

        private void ItemPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LogoutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginForm frm = new LoginForm();
            frm.Show();
        }

        private void QuitItemLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ArticoliButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ItemsForm frm = new ItemsForm(User);
            frm.Show();
        }

        private void UtentiButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            UsersForm frm = new UsersForm(User);
            frm.Show();
        }

        private void AggiungiCarrelloButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ItemGridView.SelectedRows[0].Cells[0].Value);
            string nome = ItemGridView.SelectedRows[0].Cells[1].Value.ToString();
            double prezzo = Convert.ToDouble(ItemGridView.SelectedRows[0].Cells[2].Value);
            string categoria = ItemGridView.SelectedRows[0].Cells[3].Value.ToString();

            if (QuantityTextBox.Text == "0")
            {
                MessageBox.Show("per favore inserisci la quantità");
            }
            else if (int.TryParse(ItemGridView.SelectedRows[0].Cells[0].Value.ToString(), out int numero) == false)
            {
                MessageBox.Show("devi selezionare almeno un oggetto per aggiungerlo al carrello!");
            }
            else
            {
                int quantità = Convert.ToInt32(QuantityTextBox.Text);
                items.Add(PopulateItemObjForOrder(id, nome, prezzo, categoria, quantità));
                order.Articoli = items;
                PopolaItemBasedOnCategoria();
                PrezzoTotale();

                QuantityTextBox.Text = "0";

            }

        }

        private void QuantityButton_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(QuantityTextBox.Text);
            int totale = quantity + 1;
            QuantityTextBox.Text = totale.ToString();
        }

        private void CategoriaDropDown_DropDown(object sender, EventArgs e)
        {

        }

        private void CategoriaDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopolaItemBasedOnCategoria();
        }

        private void OrdinaButton_Click(object sender, EventArgs e)
        {
            
            order.DateTime = DateTime.Now;
            order.user = User;
            db.CreaOrdine(order);
            OrdersList frm = new OrdersList();
            frm.Show();
            
        }
    }
}
