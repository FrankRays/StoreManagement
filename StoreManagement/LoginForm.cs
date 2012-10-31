using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace StoreManagement
{
    public partial class form_login : Form
    {
        public form_login()
        {
            InitializeComponent();
        }

        public string CalculateMD5Hash(string input)
        {
            // calculate MD5 hash from input
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            // convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }

        private void form_login_Load(object sender, EventArgs e)
        {

        }

        private void login_btn_login_Click(object sender, EventArgs e)
        {
            Console.WriteLine(login_txt_username.Text);
            Console.WriteLine(CalculateMD5Hash(login_txt_password.Text));
        }

    }
}
