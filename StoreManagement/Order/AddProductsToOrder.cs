using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StoreManagement
{
    public partial class AddProductsToOrder : Form
    {
        OracleDatabaseController odbc;
        public AddProductsToOrder()
        {
            InitializeComponent();
            odbc = new OracleDatabaseController();
        }

        private void AddProductsToOrder_Load(object sender, EventArgs e)
        {
            txt_order_id.Text = OrdersBuffer.id.ToString();
            cmb_product_name.Items.Clear();

        }

        private void loadAllProducts()
        {

        }
    }
}
