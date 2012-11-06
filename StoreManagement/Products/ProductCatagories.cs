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
    public partial class ProductCatagories : Form
    {
        //Different modes of the form
        private const int ADD = 0, SELECT = 1, DELETE = 2;
        private int mode;

        //database abstraction layer for oracle DBMS
        OracleDatabaseController odbc;

        public ProductCatagories()
        {
            InitializeComponent();
            mode = ADD;
            odbc = new OracleDatabaseController();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void getFromBuffer()
        {
            txt_category_name.Text = ProductCategoryBuffer.getProductCatagory();
        }

        private void putToBuffer()
        {
            ProductCategoryBuffer.setProductCatagory(txt_category_name.Text);
        }

        private void performDBOperation()
        {
            if(mode == ADD)
            {
                putToBuffer();
                if (odbc.addProductCategory())
                {
                    MessageBox.Show("Record Successfully written to the database.", "DATABASE SUCCESS!");
                }
                else
                {
                    MessageBox.Show("Could not write to database. Either the value you have entered exists,\n or something is wrong with the database.", "DATABASE ERROR!");
                }
            }
            else if(mode == SELECT)
            {
                putToBuffer();
                if (odbc.selectProductCategory())
                {
                    MessageBox.Show("Record Found in the Database.", "DATABASE SUCCESS!");
                }
                else
                {
                    MessageBox.Show("Could not find, either the record does not exist in the database,\n or something is wrong with the database", "DATABASE ERROR!");
                }
            }
            else if(mode == DELETE)
            {
                putToBuffer();
                if (odbc.deleteProductCategory())
                {
                    MessageBox.Show("Record Successfully deleted from the database.", "DATABASE SUCCESS!");
                }
                else
                {
                    MessageBox.Show("Could not delete, either the record does not exist in the database,\n or something is wrong with the database", "DATABASE ERROR!");
                }
            }
        }

        private void btn_accept_Click(object sender, EventArgs e)
        {
            performDBOperation();
        }

        private void rad_add_CheckedChanged(object sender, EventArgs e)
        {
            mode = ADD;
        }

        private void rad_select_CheckedChanged(object sender, EventArgs e)
        {
            mode = SELECT;
        }

        private void rad_delete_CheckedChanged(object sender, EventArgs e)
        {
            mode = DELETE;
        }
    }
}
