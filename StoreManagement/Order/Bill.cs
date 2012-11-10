/*
 *  This project is a simlpe implmentation of store management database
 *  Copyright (C) 2012  Tanay Virkant Prabhu Desai
 *
 *  This program is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *   You should have received a copy of the GNU General Public License
 *  along with this program.  If not, see <http://www.gnu.org/licenses/>.
 * 
 */
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

    public partial class OracleDatabaseController
    {
        int totalPrice;
        public int loadTotalPrice()
        {
            totalPrice = 0;
            select("*", "ORDER_" + OrdersBuffer.id.ToString());
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
}
