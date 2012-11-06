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
        public Order()
        {
            InitializeComponent();
//            cmb_mode_of_payment.Items.Add();
//            cmb_mode_of_payment.GetItemText();
//            cmb_mode_of_payment.Equals();
        }

        private void btn_accept_Click(object sender, EventArgs e)
        {
            string tmp = cmb_mode_of_payment.ToString();
            Console.WriteLine(tmp);
        }
    }
    public class cmbx : object
    {
        string name;
        public cmbx(string name)
        {
            this.name = name;
        }
        public override string ToString()
        {
            return name;
        }
    }
}
