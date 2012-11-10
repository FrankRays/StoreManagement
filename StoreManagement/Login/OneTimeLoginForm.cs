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
using System.Security.Cryptography;

namespace StoreManagement
{
    public partial class OneTimeLoginForm : Form
    {
        OracleDatabaseController odbc;

        public OneTimeLoginForm()
        {
            InitializeComponent();
            odbc = new OracleDatabaseController();
        }

        //This function is used to hash the password
        //for security purposes, by generating MD5 hash
        private string CalculateMD5Hash(string input)
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

        private void admin_btn_login_Click(object sender, EventArgs e)
        {
            if (odbc.checkLoginAdmin(admin_txt_username.Text,CalculateMD5Hash(admin_txt_password.Text)))
            {
                StaffBuffer.admin = true;
                this.Dispose();
            }
            else
            {
                StaffBuffer.admin = false;
                MessageBox.Show("Invalid admin login.", "FAILURE!");
                this.Dispose();
            }
        }

        private void admin_btn_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
