﻿using System;
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
        //Craete an object of the OracleDatabaseController which has all the
        //database operation definations to be used from this form
        private OracleDatabaseController odbc;

        private OneTimeLoginForm otlf;

        //The following constants defines a int value for each mode the form is
        //these constants are then assigned to the variable mode which stores the current mode
        private const int LOGIN = 0, CREATE = 1, DELETE = 2, MODIFY = 3, SELECTID = 4, SELECTUN = 5, MAINMENU = 6, MODIFYMAINMENU = 7;
        private int mode;

        public form_login()
        {
            InitializeComponent();
            
            mode = LOGIN;
        }

        private void form_login_Load(object sender, EventArgs e)
        {
            odbc = new OracleDatabaseController();
            otlf = new OneTimeLoginForm();
            renderForm();
        }

        //repositions the groupbox to the center of the form
        private void grpBoxCenter(GroupBox grp)
        {
            grp.Location = new Point((this.Width - grp.Width) / 2, (this.Height - grp.Height) / 2);
        }

        //set objects from the menu strip under operations to all true
        private void setAllOperationsTrue()
        {
            menu_strip_delete.Enabled =
            menu_strip_select.Enabled =
            menu_strip_select_id.Enabled =
            menu_strip_select_username.Enabled =
            menu_strip_add.Enabled =
            menu_strip_modify.Enabled = true;
        }

        private void renderLogin()
        {
            //select the login groupbox and make it visible
            grp_create.Visible = false;
            grp_main_menu.Visible = false;
            grp_login.Visible = true;

            //place the login groupbox in the center
            grpBoxCenter(grp_login);

            //modify the accesibility of the menuabar buttons
            //suitable for login process
            menu_strip_add.Enabled = true;
            menu_strip_modify.Enabled = false;
            menu_strip_delete.Enabled = false;
            menu_strip_select.Enabled = false;
            menu_strip_select_id.Enabled = false;
            menu_strip_select_username.Enabled = false;
        }

        private void renderCreate()
        {
            //set all menu operations visible for the user
            setAllOperationsTrue();

            //show only the create groupbox
            grp_login.Visible = false;
            grp_create.Visible = true;
            grp_main_menu.Visible = false;

            //set the groupbox and button text to "create"
            grp_create.Text = "Create";
            btn_create.Text = "Create";

            //center the groupbox
            grpBoxCenter(grp_create);
            
            //set the text boxes visible depending on the
            //requirements of create mode
            txt_staff_id.ReadOnly = true;
            txt_create_username.ReadOnly = false;
            txt_password1.ReadOnly = false;
            txt_password2.ReadOnly = false;
            txt_fname.ReadOnly = false;
            txt_lname.ReadOnly = false;
            txt_phone.ReadOnly = false;
            txt_email.ReadOnly = false;

            //make the administrator checkbox visible
            chk_administrator.Enabled = true;
        }

        private void renderModify()
        {
            //set all menu operations visible for the user
            setAllOperationsTrue();

            //show only the create groupbox
            grp_login.Visible = false;
            grp_create.Visible = true;
            grp_main_menu.Visible = false;

            //set the groupbox and button text to "modify"
            grp_create.Text = "Modify";
            btn_create.Text = "Modify";

            //center the groupbox
            grpBoxCenter(grp_create);

            //set the text boxes visible depending on the
            //requirements of modify mode
            txt_staff_id.ReadOnly = true;
            txt_create_username.ReadOnly = false;
            txt_password1.ReadOnly = false;
            txt_password2.ReadOnly = false;
            txt_fname.ReadOnly = false;
            txt_lname.ReadOnly = false;
            txt_phone.ReadOnly = false;
            txt_email.ReadOnly = false;

            //make the administrator checkbox visible
            chk_administrator.Enabled = true;
        }

        private void renderDelete()
        {
            //set all menu operations visible for the user
            setAllOperationsTrue();

            //show only the create groupbox
            grp_login.Visible = false;
            grp_create.Visible = true;
            grp_main_menu.Visible = false;

            //center the groupbox
            grpBoxCenter(grp_create);

            //set the groupbox and button text to "delete"
            grp_create.Text = "Delete";
            btn_create.Text = "Delete";

            //set the text boxes visible depending on the
            //requirements of delete mode
            txt_staff_id.ReadOnly = true;
            txt_create_username.ReadOnly = true;
            txt_password1.ReadOnly = true;
            txt_password2.ReadOnly = true;
            txt_fname.ReadOnly = true;
            txt_lname.ReadOnly = true;
            txt_phone.ReadOnly = true;
            txt_email.ReadOnly = true;

            //make the administrator checkbox not visible
            chk_administrator.Enabled = false;
        }

        private void renderSelectID()
        {
            //set all menu operations visible for the user
            setAllOperationsTrue();

            //show only the create groupbox
            grp_login.Visible = false;
            grp_create.Visible = true;
            grp_main_menu.Visible = false;

            //set the groupbox and button text to "select"
            grp_create.Text = "Select";
            btn_create.Text = "Select";

            //center the groupbox
            grpBoxCenter(grp_create);

            //set the text boxes visible depending on the
            //requirements of selectid mode
            txt_staff_id.ReadOnly = false;
            txt_create_username.ReadOnly = true;
            txt_password1.ReadOnly = true;
            txt_password2.ReadOnly = true;
            txt_fname.ReadOnly = true;
            txt_lname.ReadOnly = true;
            txt_phone.ReadOnly = true;
            txt_email.ReadOnly = true;

            //make the administrator checkbox not visible
            chk_administrator.Enabled = false;
        }

        private void renderSelectUsername()
        {
            //set all menu operations visible for the user
            setAllOperationsTrue();

            //show only the create groupbox
            grp_login.Visible = false;
            grp_create.Visible = true;
            grp_main_menu.Visible = false;

            //set the groupbox and button text to "select"
            grp_create.Text = "Select";
            btn_create.Text = "Select";

            //center the groupbox
            grpBoxCenter(grp_create);

            //set the text boxes visible depending on the
            //requirements of selectun mode
            txt_staff_id.ReadOnly = true;
            txt_create_username.ReadOnly = false;
            txt_password1.ReadOnly = true;
            txt_password2.ReadOnly = true;
            txt_fname.ReadOnly = true;
            txt_lname.ReadOnly = true;
            txt_phone.ReadOnly = true;
            txt_email.ReadOnly = true;

            //make the administrator checkbox not visible
            chk_administrator.Enabled = false;
        }

        private void renderMainMenu()
        {
            //show only the MAINMENU groupbox
            grp_login.Visible = false;
            grp_create.Visible = false;
            grp_main_menu.Visible = true;

            //disable all the menu operations
            //except for modify
            menu_strip_add.Enabled = false;
            menu_strip_create.Enabled = false;
            menu_strip_delete.Enabled = false;
            menu_strip_modify.Enabled = true;
            menu_strip_select.Enabled = false;
            menu_strip_select_id.Enabled = false;
            menu_strip_select_username.Enabled = false;

            //center the groupbox
            grpBoxCenter(grp_main_menu);
        }

        private void renderModifyMainMenu()
        {
            //make only create groupbox visible
            grp_login.Visible = false;
            grp_create.Visible = true;
            grp_main_menu.Visible = false;

            //disable all the menu operations
            menu_strip_add.Enabled = false;
            menu_strip_create.Enabled = false;
            menu_strip_delete.Enabled = false;
            menu_strip_modify.Enabled = false;
            menu_strip_select.Enabled = false;
            menu_strip_select_id.Enabled = false;
            menu_strip_select_username.Enabled = false;

            //set all the text fields to modify mode
            txt_staff_id.ReadOnly = true;
            txt_create_username.ReadOnly = false;
            txt_password1.ReadOnly = false;
            txt_password2.ReadOnly = false;
            txt_fname.ReadOnly = false;
            txt_lname.ReadOnly = false;
            txt_phone.ReadOnly = false;
            txt_email.ReadOnly = false;

            //center the groupbox
            grpBoxCenter(grp_create);


        }

        //Modify the objects present on the form based on the looks of the form
        private void renderForm()
        {
            if (mode == LOGIN)
            {
                renderLogin();
            }
            else if (mode == CREATE)
            {
                renderCreate();
            }
            else if (mode == MODIFY)
            {
                renderModify();
            }
            else if (mode == DELETE)
            {
                renderDelete();
            }
            else if (mode == SELECTID)
            {
                renderSelectID();
            }
            else if (mode == SELECTUN)
            {
                renderSelectUsername();
            }
            else if (mode == MAINMENU)
            {
                renderMainMenu();
            }
            else if(mode == MODIFYMAINMENU)
            {
                renderModifyMainMenu();
            }
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

        //this method checks of the two passwords entered in the two fields are valid or not
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

        //validate form checks if all the fields in the field are filled or not
        //more functionality to be added like
        //detecting phone number validity and email validity
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

        //this method clears the form, i.e. all the
        //fields from the form are set to blank
        private void clearForm()
        {
            txt_create_username.Text =
                txt_password1.Text =
                txt_password2.Text =
                txt_fname.Text =
                txt_lname.Text =
                txt_email.Text =
                txt_phone.Text =
                txt_staff_id.Text = "";
        }

        //copy staff_id from the form to the buffer
        //FORM.Staff_id --> STAFF_BUFFER.Id
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

        //copy username from the form to the buffer
        //FORM.Username --> STAFF_BUFFER.Username
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

        //attribues from of the record are copied from the
        //currently open form to the buffer
        // FORM --> STAFF_BUFFER
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
            StaffBuffer.admin = chk_administrator.Checked;
            return true;
        }

        //attributes of a record are copied from the buffer
        //into the currently open form
        //STAFF_BUFFER --> FORM
        private void getFromBuffer()
        {
            txt_staff_id.Text = (StaffBuffer.Id).ToString();
            txt_create_username.Text = StaffBuffer.username;
            txt_password1.Text = txt_password2.Text = "";
            txt_fname.Text = StaffBuffer.firstname;
            txt_lname.Text= StaffBuffer.lastname;
            txt_phone.Text = StaffBuffer.phone;
            txt_email.Text = StaffBuffer.email;
        }

        //shows a message depending on the success of the
        //currently performed database operation
        private void showSuccessMessage(Boolean status, string type)
        {
            MessageBox.Show("The operation was " + (status ? "" : "not") + " successfully performed on the database."+
                (status ? "" : "\n.Some problem occured with the database"), "Database " + (status ? "success" : "failure"));
        }

        //perform databse operation based on the current mode
        //insert a record if CREATE or MODIFY
        //delete a record if DELETE
        //select and load a record if SELECT
        private void performDBOperation()
        {
            if (mode == CREATE)
            {
                putToBuffer();
                if (odbc.insertUser())
                    showSuccessMessage(true, "create");
                else
                    showSuccessMessage(false, "create");
            }
            else if (mode == MODIFY)
            {
                putToBuffer();
                if (odbc.modifyUser())
                    showSuccessMessage(true, "modify");
                else
                    showSuccessMessage(false, "modify");
            }
            else if (mode == DELETE)
            {
                if (odbc.deleteUser())
                    showSuccessMessage(true, "delete");
                else
                    showSuccessMessage(false, "delete");
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

        //perform databse operation based on the mode currently in on clicking
        //[Create]
        private void btn_create_Click(object sender, EventArgs e)
        {
            performDBOperation();
        }

        //Log the user in when the user clicks the button
        //[Login]
        private void login_btn_login_Click(object sender, EventArgs e)
        {
            //calls check login which returns true if the user is allowed to login
            //and returns false if the username and password does not match any records
            if (odbc.checkLogin(login_txt_username.Text, CalculateMD5Hash(login_txt_password.Text)))
            {
                StaffBuffer.setLogin();
                mode = MAINMENU;
                renderForm();
            }
            else
            {
                MessageBox.Show("Login Failed!");
            }
        }

        //exit the program completely when exit on the login form is clicked
        //[Exit]
        private void login_btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        //Go back from the Create new account to Login on clicking the button
        //[Cancel]
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (!(mode == MODIFYMAINMENU))
            {
                mode = LOGIN;
                renderForm();
            }
            else
            {
                mode = MAINMENU;
                renderForm();
            }
        }

        //Open the Create new account form on a user clicking the button
        //[Create New]
        private void login_btn_create_new_Click(object sender, EventArgs e)
        {
            if (!StaffBuffer.admin)
            {
                StaffBuffer.flushBuffer();
                odbc.getNextMaxId();
                getFromBuffer();
                otlf = new OneTimeLoginForm();
                otlf.Show();
            }
            else if(StaffBuffer.admin && otlf.IsDisposed)
            {
                mode = CREATE;
                renderForm();
                StaffBuffer.admin = false;
            }
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
            login_btn_create_new_Click(sender, e);
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
            if (mode == CREATE || mode == SELECTID || mode == SELECTUN || mode == DELETE)
                mode = MODIFY;
            else if (mode == MAINMENU)
                mode = MODIFYMAINMENU;
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
            StaffBuffer.setLogout();
            mode = LOGIN;
            renderForm();
        }

        //exit the whole program whne the user clicks
        //File > Exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //reposition the groupboxes to center
        //if the user resizes the window
        protected override void OnResize(EventArgs e)
        {
            grpBoxCenter(grp_create);
            grpBoxCenter(grp_login);
            grpBoxCenter(grp_main_menu);
        }

        //Logout from the MAIN MENU
        //the user actually loggs out
        private void btn_logout_Click(object sender, EventArgs e)
        {
            StaffBuffer.setLogout();
            mode = LOGIN;
            renderForm();
        }

        private void btn_main_menu_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_modify_account_Click(object sender, EventArgs e)
        {
            modifyToolStripMenuItem_Click(sender, e);
        }
    }
}