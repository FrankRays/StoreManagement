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
    public partial class Suppliers : Form
    {
        private const int ADD = 0, SELECT = 1, MODIFY = 2, DELETE = 3;
        private int mode;

        OracleDatabaseController odbc;

        public Suppliers()
        {
            InitializeComponent();
            odbc = new OracleDatabaseController();
            mode = ADD;
            rad_add.Checked = true;
        }

        private void flushForm()
        {
            txt_supplier_email.Text =
                txt_supplier_name.Text =
                txt_supplier_phone.Text = "";
        }

        private void renderAdd()
        {
            txt_supplier_name.ReadOnly = 
                txt_supplier_email.ReadOnly =
                txt_supplier_phone.ReadOnly = false;
        }

        private void renderSelect()
        {
            txt_supplier_name.ReadOnly = false;
            txt_supplier_email.ReadOnly = 
                txt_supplier_phone.ReadOnly = true;
        }

        private void renderModify()
        {
            txt_supplier_name.ReadOnly =  true;
            txt_supplier_email.ReadOnly =
                txt_supplier_phone.ReadOnly = false;
        }

        private void renderDelete()
        {
            txt_supplier_name.ReadOnly =
            txt_supplier_email.ReadOnly =
                txt_supplier_phone.ReadOnly = true;
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

        private void getFromBuffer()
        {
            txt_supplier_email.Text = SuppliersBuffer.email;
            txt_supplier_name.Text = SuppliersBuffer.name;
            txt_supplier_phone.Text = SuppliersBuffer.phone;
        }

        private void putToBuffer()
        {
           SuppliersBuffer.email = txt_supplier_email.Text;
           SuppliersBuffer.name = txt_supplier_name.Text;
           SuppliersBuffer.phone = txt_supplier_phone.Text;
        }

        //shows a message depending on the success of the
        //currently performed database operation
        private void showSuccessMessage(Boolean status, string type)
        {
            MessageBox.Show("The operation " + type + " was " + (status ? "" : "not") + " successfully performed on the database." +
                (status ? "" : "\nSome problem occured with the database."), "Database " + (status ? "success" : "failure"));
        }

        private void performDBOperation()
        {
            if (mode == ADD)
            {
                putToBuffer();
                if (odbc.addSupplier())
                    showSuccessMessage(true, "add");
                else
                    showSuccessMessage(false, "add");
            }
            else if (mode == SELECT)
            {
                putToBuffer();
                if (odbc.selectSupplier())
                { }
                else
                    showSuccessMessage(false, "select");
                getFromBuffer();
            }
            else if (mode == MODIFY)
            {
                putToBuffer();
                if (odbc.modifySupplier())
                { }
                else
                    showSuccessMessage(false, "modify");
            }
            else if (mode == DELETE)
            {
                putToBuffer();
                if (odbc.deleteSupplier())
                    showSuccessMessage(true, "delete");
                else
                    showSuccessMessage(false, "delete");
            }
        }

        private void btn_accept_Click(object sender, EventArgs e)
        {
            performDBOperation();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
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
    }
}
