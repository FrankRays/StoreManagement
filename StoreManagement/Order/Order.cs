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
    public partial class Order : Form
    {
        private const int ADD = 0, SELECT = 1, MODIFY = 2, DELETE = 3;
        private int mode;

        OracleDatabaseController odbc;

        AddProductsToOrder apto;

        public Order()
        {
            InitializeComponent();

            dtp_date_of_dispatch.Format = DateTimePickerFormat.Custom;
            dtp_date_of_dispatch.CustomFormat = "dd-MMM-yyyy";

            dtp_date_of_order.Format = DateTimePickerFormat.Custom;
            dtp_date_of_order.CustomFormat = "dd-MMM-yyyy";

            odbc = new OracleDatabaseController();

            mode = ADD;
            rad_add.Checked = true;
        }

        private void flushForm()
        {
            txt_order_id.Text =
                txt_customer_first_name.Text =
                txt_customer_last_name.Text = "";
            cmb_mode_of_payment.Text = "";
            dtp_date_of_dispatch.Text =
                dtp_date_of_order.Text = "";
        }

        private void getFromBuffer()
        {
            txt_order_id.Text = OrdersBuffer.id.ToString();
            txt_customer_first_name.Text = OrdersBuffer.first_name;
            txt_customer_last_name.Text = OrdersBuffer.last_name;
            cmb_mode_of_payment.Text = OrdersBuffer.mode_of_payment;
            dtp_date_of_dispatch.Text = OrdersBuffer.date_of_dispatch;
            dtp_date_of_order.Text = OrdersBuffer.date_of_order;
        }

        private void putToBuffer()
        {
            OrdersBuffer.id = int.Parse(txt_order_id.Text) ;
            OrdersBuffer.first_name = txt_customer_first_name.Text;
            OrdersBuffer.last_name = txt_customer_last_name.Text;
            OrdersBuffer.mode_of_payment = cmb_mode_of_payment.Text;
            OrdersBuffer.date_of_dispatch = dtp_date_of_order.Text;
            OrdersBuffer.date_of_order = dtp_date_of_order.Text;
        }

        private void renderAdd()
        {
            txt_order_id.ReadOnly = true;
            txt_customer_first_name.ReadOnly =
                txt_customer_last_name.ReadOnly = false;
            cmb_mode_of_payment.Enabled =
                dtp_date_of_dispatch.Enabled =
                dtp_date_of_order.Enabled = true;
        }

        private void renderSelect()
        {
            txt_order_id.ReadOnly = false;
            txt_customer_first_name.ReadOnly =
                txt_customer_last_name.ReadOnly = true;
            cmb_mode_of_payment.Enabled =
                dtp_date_of_dispatch.Enabled =
                dtp_date_of_order.Enabled = false;
        }

        private void renderModify()
        {
            txt_order_id.ReadOnly = true;
            txt_customer_first_name.ReadOnly =
                txt_customer_last_name.ReadOnly = false;
            cmb_mode_of_payment.Enabled =
                dtp_date_of_dispatch.Enabled =
                dtp_date_of_order.Enabled = true;
        }

        private void renderDelete()
        {
            txt_order_id.ReadOnly = true;
            txt_customer_first_name.ReadOnly =
                txt_customer_last_name.ReadOnly = true;
            cmb_mode_of_payment.Enabled =
                dtp_date_of_dispatch.Enabled =
                dtp_date_of_order.Enabled = false;
        }

        protected void renderForm()
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
            MessageBox.Show("The operation " + type + " was " + (status ? "" : "not") + " successfully performed on the database." +
                (status ? "" : "\nSome problem occured with the database."), "Database " + (status ? "success" : "failure"));
        }

        private void performDBOperation()
        {
            if (mode == ADD)
            {
                putToBuffer();
                if (odbc.addOrder())
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

        private void btn_add_products_Click(object sender, EventArgs e)
        {
            if (apto.IsDisposed)
            {
                apto.Show();
            }
            else
            {
                apto = new AddProductsToOrder();
                apto.Show();
            }
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
