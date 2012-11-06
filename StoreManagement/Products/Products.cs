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
    public partial class Products : Form
    {
        //OracleDatabaseController for database operations
        //using this Products form
        OracleDatabaseController odbc;

        //the following constants specify the different modes of the form
        //the variable mode stores one of this mode
        private const int ADD = 0, SELECT = 1, MODIFY = 2, DELETE = 3;
        private int mode;

        public Products()
        {
            InitializeComponent();

            //instantiate OracleDatabaseController object
            odbc = new OracleDatabaseController();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            //Form flushed so that it is prepared to enter new entries
            flushForm();

            //load the combo box data items from the database into the buffer
            odbc.getAllSupplierRows();
            odbc.getAllProductCategoryRows();

            //select add as starting button and 
            //accordingly select the add radio box
            rad_add.Select();
            mode = ADD;
            renderForm();

            //for loop to fetch all the items read from the database
            //the items to be stored as items in the combo boxes
            //these are fetched from two different databases
            //i.e. Supplier names from supplier database
            //Catagory Names from catagory database
            for (int i = 0; i < ProductsBuffer.supplier_names.Count; i++)
            {
                cmb_supplier_name.Items.Add(new cmbxItem(ProductsBuffer.supplier_names[i]));
            }
            for (int i = 0; i < ProductsBuffer.product_categories.Count; i++)
            {
                cmb_product_category.Items.Add(new cmbxItem(ProductsBuffer.product_categories[i]));
            }
        }

        //clears all the data that is currently present on the form
        private void flushForm()
        {
            txt_product_id.Text =
            txt_product_name.Text =
            txt_retail_cost.Text =
            txt_wholesale_cost.Text = "";
        }

        //gets all the attributes from the form and put it onto the buffer
        private void putToBuffer()
        {
            int num1, num2;
            ProductsBuffer.id =  int.Parse(txt_product_id.Text);
            ProductsBuffer.product_name = txt_product_name.Text;
            ProductsBuffer.active_supplier_name = cmb_supplier_name.Text;
            ProductsBuffer.active_product_catagory = cmb_product_category.Text;
            if (int.TryParse(txt_wholesale_cost.Text,out num1) || int.TryParse(txt_retail_cost.Text,out num2))
            {
                ProductsBuffer.wholesale_cost = int.Parse(txt_wholesale_cost.Text);
                ProductsBuffer.retail_cost = int.Parse(txt_retail_cost.Text);
            }
        }

        //gets all the attributes from the buffer and puts it onto the form
        private void getFromBuffer()
        {
            txt_product_id.Text = ProductsBuffer.id.ToString();
            txt_product_name.Text = ProductsBuffer.product_name;
            cmb_supplier_name.Text = ProductsBuffer.active_supplier_name;
            cmb_product_category.Text = ProductsBuffer.active_product_catagory;
            txt_wholesale_cost.Text = ProductsBuffer.wholesale_cost.ToString();
            txt_retail_cost.Text = ProductsBuffer.retail_cost.ToString();
        }

        //private void generate product ID
        private void generateID()
        {
            odbc.getNextMaxProductId();
            Console.WriteLine(ProductsBuffer.id.ToString());
            txt_product_id.Text = ProductsBuffer.id.ToString();
        }

        //changes the appearance of the 
        //form to add more records
        private void renderAdd()
        {
            //set ID to read only set all other text boxes editable
            txt_product_id.ReadOnly = true;
            generateID();
            txt_product_name.ReadOnly =
            txt_retail_cost.ReadOnly =
            txt_wholesale_cost.ReadOnly = false;
            cmb_supplier_name.Enabled =
            cmb_product_category.Enabled = true;
        }

        //changes the appearance of the form
        //to select a particular record base on the id
        private void renderSelect()
        {
            txt_product_id.ReadOnly = false;
            txt_product_name.ReadOnly =
            txt_retail_cost.ReadOnly =
            txt_wholesale_cost.ReadOnly = true;
            cmb_supplier_name.Enabled =
            cmb_product_category.Enabled = false;
        }

        //changes the appearance of the form
        //to enable the user to modify the form
        private void renderModify()
        {
            txt_product_id.ReadOnly = true;
            txt_product_name.ReadOnly =
            txt_retail_cost.ReadOnly =
            txt_wholesale_cost.ReadOnly = false;
            cmb_supplier_name.Enabled =
            cmb_product_category.Enabled = true;
        }

        //changes the appearance of the form 
        //to enable the user to delete a record
        private void renderDelete()
        {
            txt_product_id.ReadOnly = 
            txt_product_name.ReadOnly =
            txt_retail_cost.ReadOnly =
            txt_wholesale_cost.ReadOnly = true;
            cmb_supplier_name.Enabled =
            cmb_product_category.Enabled = false;
        }

        private void renderForm()
        {
            if (mode == ADD)
            {
                flushForm();
                renderAdd();
            }
            else if (mode == SELECT)
            {
                flushForm();
                renderSelect();
            }
            else if (mode == MODIFY)
            {
                getFromBuffer();
                renderModify();
            }
            else if (mode == DELETE)
            {
                getFromBuffer();
                renderDelete();
            }
        }

        //shows a message depending on the success of the
        //currently performed database operation
        private void showSuccessMessage(Boolean status, string type)
        {
            MessageBox.Show("The operation was " + (status ? "" : "not") + " successfully performed on the database." +
                (status ? "" : "\n.Some problem occured with the database"), "Database " + (status ? "success" : "failure"));
        }

        private void perform_database_operation()
        {
            if (mode == ADD)
            {
                putToBuffer();
                if (odbc.addProduct())
                    showSuccessMessage(true,"add");
                else
                    showSuccessMessage(false,"add");
            }
            else if (mode == SELECT)
            {
                putToBuffer();
                if (odbc.selectProduct())
                    showSuccessMessage(true, "select");
                else
                    showSuccessMessage(false, "select");
                getFromBuffer();
            }
            else if (mode == MODIFY)
            {
                putToBuffer();
                if (odbc.modifyProduct())
                    showSuccessMessage(true, "modify");
                else
                    showSuccessMessage(false, "modify");
            }
            else if (mode == DELETE)
            {
                putToBuffer();
                if (odbc.deleteProduct())
                    showSuccessMessage(true, "delete");
                else
                    showSuccessMessage(false, "delete");
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            //deletes the form from the memory
            this.Dispose();
        }

        private void rad_add_CheckedChanged(object sender, EventArgs e)
        {
            mode = ADD;
            renderForm();
        }

        private void rad_select_CheckedChanged(object sender, EventArgs e)
        {
            mode = SELECT;
            renderForm();
        }

        private void rad_modify_CheckedChanged(object sender, EventArgs e)
        {
            mode = MODIFY;
            renderForm();
        }

        private void rad_delete_CheckedChanged(object sender, EventArgs e)
        {
            mode = DELETE;
            renderForm();
        }

        private void btn_accept_Click(object sender, EventArgs e)
        {
            perform_database_operation();
        }
    }
}
