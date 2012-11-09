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
    public partial class OracleDatabaseController
    {
        int totalPrice;
        public int loadTotalPrice()
        {
            totalPrice = 0;
            select("*", "ORDER_"+OrdersBuffer.id.ToString());
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    totalPrice += int.Parse(reader["PRICE"].ToString());
                }
            }
            connection.Close();
            return totalPrice;
        }
    }
    public partial class Bill : Form
    {
        OracleDatabaseController odbc;
        List<int> prices = new List<int>();

        public Bill()
        {
            InitializeComponent();
            odbc = new OracleDatabaseController();
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            OrdersBuffer.id = int.Parse(txt_select.Text);
            odbc.selectOrder();
            data_grid_view_bill = odbc.getDataSet("ORDER_"+OrdersBuffer.id.ToString(), data_grid_view_bill);
            txt_customer_firstname.Text = OrdersBuffer.first_name;
            txt_customer_lastname.Text = OrdersBuffer.last_name;
            txt_total_cost.Text = odbc.loadTotalPrice().ToString();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        
    }
}
