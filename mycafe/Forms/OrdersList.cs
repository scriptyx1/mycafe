using mycafe.DataBaseData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mycafe.Forms
{
    public partial class OrdersList : Form
    {
        DataAccess db = new DataAccess();
        public OrdersList()
        {
            InitializeComponent();
            PopulateOrderList();
        }

        void PopulateOrderList()
        {
            var output = db.GetAllOrders();
            ListOrdiniGridView.DataSource = output;
        }
        private void ListOrdiniGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
