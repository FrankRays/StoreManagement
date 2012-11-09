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
        List<string> list;
        public AddProductsToOrder()
        {
            InitializeComponent();
            list = new List<string>();
            odbc = new OracleDatabaseController();
        }

        private void AddProductsToOrder_Load(object sender, EventArgs e)
        {
            txt_order_id.Text = OrdersBuffer.id.ToString();
            cmb_product_name.Items.Clear();
            loadAllProducts();
        }

        private void loadAllProducts()
        {
            cmb_product_name.Items.Clear();
            list = odbc.getComboBoxProducts();
            for (int i = 0; i < list.Count; i++)
            {
                cmb_product_name.Items.Add(new cmbxItem(list[i]));
            }
            odbc.loadPrice();
            dataGrid_addToProducts = odbc.getDataSet("ORDER_" + OrdersBuffer.id.ToString(), dataGrid_addToProducts);
            list = odbc.getStringListForColumnFromTable("PRODUCTS", "PRODUCT_NAME");
        }

        private void putToBuffer()
        {
            AddProductsBuffer.productName = cmb_product_name.Text;
            AddProductsBuffer.productQuantity = int.Parse(txt_quantity.Text);
        }

        private void getFromBuffer()
        {
            cmb_product_name.Text = AddProductsBuffer.productName;
            txt_quantity.Text = AddProductsBuffer.productQuantity.ToString();
        }

        private void btn_accept_Click(object sender, EventArgs e)
        {
            putToBuffer();
            odbc.addToTheGrid();
            AddProductsToOrder_Load(sender,e);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
