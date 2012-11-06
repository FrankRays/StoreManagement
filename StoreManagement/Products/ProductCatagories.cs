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
            
            //select add mode as the default mode
            //and set the radio button accordingly
            mode = ADD;
            rad_add.Select();

            //initialize the oracle database controller
            odbc = new OracleDatabaseController();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            //delete this form from the memory once cancel is clicked
            this.Dispose();
        }

        private void getFromBuffer()
        {
            //get all the form details from the buffer
            txt_category_name.Text = ProductCategoryBuffer.getProductCatagory();
        }

        private void putToBuffer()
        {
            //put all the form detaild to the buffer
            ProductCategoryBuffer.setProductCatagory(txt_category_name.Text);
        }

        private Boolean validForm()
        {
            //check if the catagory name textbox string is empty
            //if yes indalid form else valid
            if (txt_category_name.Text == "")
                return false;
            else
                return true;
        }
        private void performDBOperation()
        {
            //check if the details in the form are vaild
            if (!validForm())
            {
                MessageBox.Show("All the fields are mandatory.", "Operation Fail!");
                return;
            }

            //depending on the modes ADD, SELECT, DELETE perform the
            //operations by calling the methods from the ProductsDBController
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

        //when Accept button is clicked perform the
        //database operation base on the selected mode
        private void btn_accept_Click(object sender, EventArgs e)
        {
            performDBOperation();
        }

        //when any of the three radio buttons are clicked the mode is changed to
        //the respective mode which the radio button corresponds
        //the following three functions handle these events

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
