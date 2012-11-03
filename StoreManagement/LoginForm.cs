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
        OracleDatabaseController odbc;
        private const int LOGIN = 0, CREATE = 1, DELETE = 2, MODIFY = 3, SELECTID = 4, SELECTUN = 5;
        private int mode;

        private void renderForm()
        {
            if (mode == LOGIN)
            {
                grp_create.Visible = false;
                grpBox_login.Visible = true;
            }
            else if (mode == CREATE || mode == MODIFY)
            {
                grpBox_login.Visible = false;
                grp_create.Visible = true;
                txt_staff_id.ReadOnly = true;
                txt_create_username.ReadOnly = false;
                txt_password1.ReadOnly = false;
                txt_password2.ReadOnly = false;
                txt_fname.ReadOnly = false;
                txt_lname.ReadOnly = false;
                txt_phone.ReadOnly = false;
                txt_email.ReadOnly = false;
                chk_administrator.Enabled = true;
            }
            else if (mode == DELETE)
            {
                grpBox_login.Visible = false;
                grp_create.Visible = true;
                txt_staff_id.ReadOnly = true;
                txt_create_username.ReadOnly = true;
                txt_password1.ReadOnly = true;
                txt_password2.ReadOnly = true;
                txt_fname.ReadOnly = true;
                txt_lname.ReadOnly = true;
                txt_phone.ReadOnly = true;
                txt_email.ReadOnly = true;
                chk_administrator.Enabled = false;
            }
            else if (mode == SELECTID)
            {
                grpBox_login.Visible = false;
                grp_create.Visible = true;
                txt_staff_id.ReadOnly = false;
                txt_create_username.ReadOnly = true;
                txt_password1.ReadOnly = true;
                txt_password2.ReadOnly = true;
                txt_fname.ReadOnly = true;
                txt_lname.ReadOnly = true;
                txt_phone.ReadOnly = true;
                txt_email.ReadOnly = true;
                chk_administrator.Enabled = false;
            }
            else if (mode == SELECTUN)
            {
                grpBox_login.Visible = false;
                grp_create.Visible = true;
                txt_staff_id.ReadOnly = true;
                txt_create_username.ReadOnly = false;
                txt_password1.ReadOnly = true;
                txt_password2.ReadOnly = true;
                txt_fname.ReadOnly = true;
                txt_lname.ReadOnly = true;
                txt_phone.ReadOnly = true;
                txt_email.ReadOnly = true;
                chk_administrator.Enabled = false;
            }
        }

        public form_login()
        {
            InitializeComponent();
        }

        //This function is used to hash the password
        //for security purposes, by generating MD5 hash
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
            odbc = new OracleDatabaseController();
            mode = LOGIN;
            renderForm();
        }

        private Boolean checkPasswords()
        {
            if (txt_password1.Text == txt_password2.Text)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private Boolean validateForm()
        {
            if (txt_create_username.Text == "" ||
                txt_password1.Text == "" ||
                txt_password2.Text == "" ||
                txt_fname.Text == "" ||
                txt_lname.Text == "" ||
                txt_email.Text == "" ||
                txt_phone.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private Boolean putToBufferID()
        {
            int num;
            if (int.TryParse(txt_staff_id.Text, out num))
            {
                StaffBuffer.Id = int.Parse(txt_staff_id.Text);
                return true;
            }
            else
            {
                return false;
            }
        }

        private Boolean putToBufferUsername()
        {
            if (txt_create_username.Text != "")
            {
                StaffBuffer.username = txt_create_username.Text;
                return true;
            }
            else
            {
                return false;
            }
        }

        private Boolean putToBuffer()
        {
            if (!validateForm())
            {
                MessageBox.Show("All the fields in the form are mandatory", "ERROR!");
                return false;
            }
            StaffBuffer.Id = int.Parse(txt_staff_id.Text);
            StaffBuffer.username = txt_create_username.Text;
            if (checkPasswords())
            {
                StaffBuffer.passwordHash = CalculateMD5Hash(txt_password1.Text);
            }
            else
            {
               MessageBox.Show("Passwords you have entered do not match", "ERROR!");
               return false;
            }
            StaffBuffer.firstname = txt_fname.Text;
            StaffBuffer.lastname = txt_lname.Text;
            StaffBuffer.phone = txt_phone.Text;
            StaffBuffer.email = txt_email.Text;
            return true;
        }

        private void getFromBuffer()
        {
            txt_staff_id.Text = (StaffBuffer.Id).ToString();
            txt_create_username.Text = StaffBuffer.username;
            txt_password1.Text = txt_password2.Text = "";
            txt_fname.Text = StaffBuffer.firstname;
            txt_lname.Text= StaffBuffer.lastname;
            txt_phone.Text = StaffBuffer.phone;
            txt_email.Text = StaffBuffer.email;
            Console.WriteLine("\n\n getFromBuffer() called!! \n\n");
        }

        //Login button click event listener
        private void login_btn_login_Click(object sender, EventArgs e)
        {
            Console.WriteLine(login_txt_username.Text);
            //convert password to MD5 hash for security reasons
            Console.WriteLine(CalculateMD5Hash(login_txt_password.Text));
            //calls check login which returns true if the user is allowed to login
            //and returns false if the username and password does not match any records
            if(odbc.checkLogin(login_txt_username.Text,CalculateMD5Hash(login_txt_password.Text)))
            {
                MessageBox.Show("You are now logged in!");
            }
            else
            {
                MessageBox.Show("Login Failed!");
            }
        }
        private void performDBOperation()
        {
            if (mode == CREATE || mode == MODIFY)
            {
                putToBuffer();
                odbc.insertUser();
            }
            else if (mode == DELETE)
            {
                odbc.deleteUser();
            }
            else if (mode == SELECTID)
            {
                putToBufferID();
                odbc.selectUserID();
            }
            else if (mode == SELECTUN)
            {
                putToBufferUsername();
                odbc.selectUserUN();
            }
            getFromBuffer();
            renderForm();
        }
        private void login_btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            performDBOperation();
        }
        
        //Go back from the Create new account to Login on clicking the button
        //[Cancel]
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            mode = LOGIN;
            renderForm();
        }

        //Open the Create new account form on a user clicking the button
        //[Create New]
        private void login_btn_create_new_Click(object sender, EventArgs e)
        {
            mode = CREATE;
            renderForm();
        }

        //Enable user to select a particular user by the staff_id on clicking
        //Operation > Select > By ID
        private void byIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = SELECTID;
            renderForm();
        }

        //Enable user to select a particular user by Username on clicking
        //Operation > Select > By Username
        private void byUsernameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = SELECTUN;
            renderForm();
        }

        //Enable user to add a new account when he clicks on
        //Operation > Add
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = CREATE;
            renderForm();
        }

        //Enable user to delete the selected user account when he clicks on
        //Operation > Delete
        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mode = DELETE;
            renderForm();
        }

        //Enable user to modify the selected user account when he clicks on
        //Operation > Modify
        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = MODIFY;
            renderForm();
        }

        //open the Create group in SELECT mode when the user clicks on
        //View > User Accounts
        private void userAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = SELECTUN;
            renderForm();
        }

        //Perform the logout operation and exit to the login screen when user clicks on
        //File > Logout
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = LOGIN;
            renderForm();
        }

        //exit the whole program whne the user clicks
        //File > Exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}