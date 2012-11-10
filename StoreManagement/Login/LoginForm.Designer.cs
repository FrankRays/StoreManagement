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
namespace StoreManagement
{
    partial class form_login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grp_login = new System.Windows.Forms.GroupBox();
            this.login_btn_exit = new System.Windows.Forms.Button();
            this.login_btn_login = new System.Windows.Forms.Button();
            this.login_btn_create_new = new System.Windows.Forms.Button();
            this.login_txt_password = new System.Windows.Forms.TextBox();
            this.login_txt_username = new System.Windows.Forms.TextBox();
            this.login_lbl_username = new System.Windows.Forms.Label();
            this.login_lbl_password = new System.Windows.Forms.Label();
            this.grp_create = new System.Windows.Forms.GroupBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txt_lname = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_fname = new System.Windows.Forms.TextBox();
            this.lbl_lname = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.lbl_fname = new System.Windows.Forms.Label();
            this.txt_password2 = new System.Windows.Forms.TextBox();
            this.txt_password1 = new System.Windows.Forms.TextBox();
            this.txt_create_username = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.lbl_create_password2 = new System.Windows.Forms.Label();
            this.lbl_create_password1 = new System.Windows.Forms.Label();
            this.create_lbl_username = new System.Windows.Forms.Label();
            this.chk_administrator = new System.Windows.Forms.CheckBox();
            this.btn_create = new System.Windows.Forms.Button();
            this.txt_staff_id = new System.Windows.Forms.TextBox();
            this.lbl_staff_id = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_strip_logout = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_strip_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_strip_products = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_strip_suppliers = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_strip_orders = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_strip_bill = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_strip_product_categories = new System.Windows.Forms.ToolStripMenuItem();
            this.operationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_strip_select = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_strip_select_id = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_strip_select_username = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_strip_add = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_strip_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_strip_modify = new System.Windows.Forms.ToolStripMenuItem();
            this.grp_main_menu = new System.Windows.Forms.GroupBox();
            this.btn_main_menu_exit = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_orders = new System.Windows.Forms.Button();
            this.btn_supplies = new System.Windows.Forms.Button();
            this.btn_product_categories = new System.Windows.Forms.Button();
            this.btn_products = new System.Windows.Forms.Button();
            this.btn_modify_account = new System.Windows.Forms.Button();
            this.btn_bill = new System.Windows.Forms.Button();
            this.grp_login.SuspendLayout();
            this.grp_create.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.grp_main_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_login
            // 
            this.grp_login.Controls.Add(this.login_btn_exit);
            this.grp_login.Controls.Add(this.login_btn_login);
            this.grp_login.Controls.Add(this.login_btn_create_new);
            this.grp_login.Controls.Add(this.login_txt_password);
            this.grp_login.Controls.Add(this.login_txt_username);
            this.grp_login.Controls.Add(this.login_lbl_username);
            this.grp_login.Controls.Add(this.login_lbl_password);
            this.grp_login.Location = new System.Drawing.Point(12, 46);
            this.grp_login.Name = "grp_login";
            this.grp_login.Size = new System.Drawing.Size(253, 139);
            this.grp_login.TabIndex = 0;
            this.grp_login.TabStop = false;
            this.grp_login.Text = "Login";
            // 
            // login_btn_exit
            // 
            this.login_btn_exit.Location = new System.Drawing.Point(168, 96);
            this.login_btn_exit.Name = "login_btn_exit";
            this.login_btn_exit.Size = new System.Drawing.Size(75, 23);
            this.login_btn_exit.TabIndex = 7;
            this.login_btn_exit.Text = "Exit";
            this.login_btn_exit.UseVisualStyleBackColor = true;
            this.login_btn_exit.Click += new System.EventHandler(this.login_btn_exit_Click);
            // 
            // login_btn_login
            // 
            this.login_btn_login.Location = new System.Drawing.Point(87, 96);
            this.login_btn_login.Name = "login_btn_login";
            this.login_btn_login.Size = new System.Drawing.Size(75, 23);
            this.login_btn_login.TabIndex = 6;
            this.login_btn_login.Text = "Login";
            this.login_btn_login.UseVisualStyleBackColor = true;
            this.login_btn_login.Click += new System.EventHandler(this.login_btn_login_Click);
            // 
            // login_btn_create_new
            // 
            this.login_btn_create_new.Location = new System.Drawing.Point(6, 96);
            this.login_btn_create_new.Name = "login_btn_create_new";
            this.login_btn_create_new.Size = new System.Drawing.Size(75, 23);
            this.login_btn_create_new.TabIndex = 5;
            this.login_btn_create_new.Text = "Create New";
            this.login_btn_create_new.UseVisualStyleBackColor = true;
            this.login_btn_create_new.Click += new System.EventHandler(this.login_btn_create_new_Click);
            // 
            // login_txt_password
            // 
            this.login_txt_password.Location = new System.Drawing.Point(87, 54);
            this.login_txt_password.Name = "login_txt_password";
            this.login_txt_password.PasswordChar = '•';
            this.login_txt_password.Size = new System.Drawing.Size(134, 20);
            this.login_txt_password.TabIndex = 4;
            this.login_txt_password.UseSystemPasswordChar = true;
            // 
            // login_txt_username
            // 
            this.login_txt_username.Location = new System.Drawing.Point(87, 19);
            this.login_txt_username.Name = "login_txt_username";
            this.login_txt_username.Size = new System.Drawing.Size(134, 20);
            this.login_txt_username.TabIndex = 3;
            // 
            // login_lbl_username
            // 
            this.login_lbl_username.AutoSize = true;
            this.login_lbl_username.Location = new System.Drawing.Point(23, 22);
            this.login_lbl_username.Name = "login_lbl_username";
            this.login_lbl_username.Size = new System.Drawing.Size(58, 13);
            this.login_lbl_username.TabIndex = 1;
            this.login_lbl_username.Text = "Username:";
            // 
            // login_lbl_password
            // 
            this.login_lbl_password.AutoSize = true;
            this.login_lbl_password.Location = new System.Drawing.Point(23, 57);
            this.login_lbl_password.Name = "login_lbl_password";
            this.login_lbl_password.Size = new System.Drawing.Size(56, 13);
            this.login_lbl_password.TabIndex = 2;
            this.login_lbl_password.Text = "Password:";
            // 
            // grp_create
            // 
            this.grp_create.Controls.Add(this.btn_cancel);
            this.grp_create.Controls.Add(this.txt_lname);
            this.grp_create.Controls.Add(this.txt_email);
            this.grp_create.Controls.Add(this.txt_fname);
            this.grp_create.Controls.Add(this.lbl_lname);
            this.grp_create.Controls.Add(this.txt_phone);
            this.grp_create.Controls.Add(this.lbl_fname);
            this.grp_create.Controls.Add(this.txt_password2);
            this.grp_create.Controls.Add(this.txt_password1);
            this.grp_create.Controls.Add(this.txt_create_username);
            this.grp_create.Controls.Add(this.lbl_email);
            this.grp_create.Controls.Add(this.lbl_phone);
            this.grp_create.Controls.Add(this.lbl_create_password2);
            this.grp_create.Controls.Add(this.lbl_create_password1);
            this.grp_create.Controls.Add(this.create_lbl_username);
            this.grp_create.Controls.Add(this.chk_administrator);
            this.grp_create.Controls.Add(this.btn_create);
            this.grp_create.Controls.Add(this.txt_staff_id);
            this.grp_create.Controls.Add(this.lbl_staff_id);
            this.grp_create.Location = new System.Drawing.Point(320, 46);
            this.grp_create.Name = "grp_create";
            this.grp_create.Size = new System.Drawing.Size(275, 318);
            this.grp_create.TabIndex = 1;
            this.grp_create.TabStop = false;
            this.grp_create.Text = "Create";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(152, 280);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 18;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // txt_lname
            // 
            this.txt_lname.Location = new System.Drawing.Point(127, 163);
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(100, 20);
            this.txt_lname.TabIndex = 17;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(127, 218);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(100, 20);
            this.txt_email.TabIndex = 13;
            // 
            // txt_fname
            // 
            this.txt_fname.Location = new System.Drawing.Point(127, 139);
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(100, 20);
            this.txt_fname.TabIndex = 16;
            // 
            // lbl_lname
            // 
            this.lbl_lname.AutoSize = true;
            this.lbl_lname.Location = new System.Drawing.Point(18, 166);
            this.lbl_lname.Name = "lbl_lname";
            this.lbl_lname.Size = new System.Drawing.Size(61, 13);
            this.lbl_lname.TabIndex = 15;
            this.lbl_lname.Text = "Last Name:";
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(127, 191);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(100, 20);
            this.txt_phone.TabIndex = 12;
            // 
            // lbl_fname
            // 
            this.lbl_fname.AutoSize = true;
            this.lbl_fname.Location = new System.Drawing.Point(18, 142);
            this.lbl_fname.Name = "lbl_fname";
            this.lbl_fname.Size = new System.Drawing.Size(60, 13);
            this.lbl_fname.TabIndex = 14;
            this.lbl_fname.Text = "First Name:";
            // 
            // txt_password2
            // 
            this.txt_password2.Location = new System.Drawing.Point(127, 113);
            this.txt_password2.Name = "txt_password2";
            this.txt_password2.Size = new System.Drawing.Size(100, 20);
            this.txt_password2.TabIndex = 11;
            this.txt_password2.UseSystemPasswordChar = true;
            // 
            // txt_password1
            // 
            this.txt_password1.Location = new System.Drawing.Point(127, 84);
            this.txt_password1.Name = "txt_password1";
            this.txt_password1.Size = new System.Drawing.Size(100, 20);
            this.txt_password1.TabIndex = 10;
            this.txt_password1.UseSystemPasswordChar = true;
            // 
            // txt_create_username
            // 
            this.txt_create_username.Location = new System.Drawing.Point(127, 58);
            this.txt_create_username.Name = "txt_create_username";
            this.txt_create_username.Size = new System.Drawing.Size(100, 20);
            this.txt_create_username.TabIndex = 9;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(18, 221);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(35, 13);
            this.lbl_email.TabIndex = 8;
            this.lbl_email.Text = "Email:";
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Location = new System.Drawing.Point(18, 194);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(41, 13);
            this.lbl_phone.TabIndex = 7;
            this.lbl_phone.Text = "Phone:";
            // 
            // lbl_create_password2
            // 
            this.lbl_create_password2.AutoSize = true;
            this.lbl_create_password2.Location = new System.Drawing.Point(18, 116);
            this.lbl_create_password2.Name = "lbl_create_password2";
            this.lbl_create_password2.Size = new System.Drawing.Size(94, 13);
            this.lbl_create_password2.TabIndex = 6;
            this.lbl_create_password2.Text = "Password Confirm:";
            // 
            // lbl_create_password1
            // 
            this.lbl_create_password1.AutoSize = true;
            this.lbl_create_password1.Location = new System.Drawing.Point(18, 87);
            this.lbl_create_password1.Name = "lbl_create_password1";
            this.lbl_create_password1.Size = new System.Drawing.Size(56, 13);
            this.lbl_create_password1.TabIndex = 5;
            this.lbl_create_password1.Text = "Password:";
            // 
            // create_lbl_username
            // 
            this.create_lbl_username.AutoSize = true;
            this.create_lbl_username.Location = new System.Drawing.Point(18, 61);
            this.create_lbl_username.Name = "create_lbl_username";
            this.create_lbl_username.Size = new System.Drawing.Size(58, 13);
            this.create_lbl_username.TabIndex = 4;
            this.create_lbl_username.Text = "Username:";
            // 
            // chk_administrator
            // 
            this.chk_administrator.AutoSize = true;
            this.chk_administrator.Location = new System.Drawing.Point(127, 244);
            this.chk_administrator.Name = "chk_administrator";
            this.chk_administrator.Size = new System.Drawing.Size(86, 17);
            this.chk_administrator.TabIndex = 3;
            this.chk_administrator.Text = "Administrator";
            this.chk_administrator.UseVisualStyleBackColor = true;
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(68, 280);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(75, 23);
            this.btn_create.TabIndex = 2;
            this.btn_create.Text = "Create";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // txt_staff_id
            // 
            this.txt_staff_id.Location = new System.Drawing.Point(127, 31);
            this.txt_staff_id.Name = "txt_staff_id";
            this.txt_staff_id.Size = new System.Drawing.Size(100, 20);
            this.txt_staff_id.TabIndex = 1;
            // 
            // lbl_staff_id
            // 
            this.lbl_staff_id.AutoSize = true;
            this.lbl_staff_id.Location = new System.Drawing.Point(18, 31);
            this.lbl_staff_id.Name = "lbl_staff_id";
            this.lbl_staff_id.Size = new System.Drawing.Size(44, 13);
            this.lbl_staff_id.TabIndex = 0;
            this.lbl_staff_id.Text = "Staff Id:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.operationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1020, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_strip_logout,
            this.menu_strip_exit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menu_strip_logout
            // 
            this.menu_strip_logout.Name = "menu_strip_logout";
            this.menu_strip_logout.Size = new System.Drawing.Size(107, 22);
            this.menu_strip_logout.Text = "Logout";
            this.menu_strip_logout.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // menu_strip_exit
            // 
            this.menu_strip_exit.Name = "menu_strip_exit";
            this.menu_strip_exit.Size = new System.Drawing.Size(107, 22);
            this.menu_strip_exit.Text = "Exit";
            this.menu_strip_exit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_strip_products,
            this.menu_strip_suppliers,
            this.menu_strip_orders,
            this.menu_strip_bill,
            this.menu_strip_product_categories});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // menu_strip_products
            // 
            this.menu_strip_products.Name = "menu_strip_products";
            this.menu_strip_products.Size = new System.Drawing.Size(166, 22);
            this.menu_strip_products.Text = "Products";
            this.menu_strip_products.Click += new System.EventHandler(this.menu_strip_products_Click);
            // 
            // menu_strip_suppliers
            // 
            this.menu_strip_suppliers.Name = "menu_strip_suppliers";
            this.menu_strip_suppliers.Size = new System.Drawing.Size(166, 22);
            this.menu_strip_suppliers.Text = "Suppliers";
            this.menu_strip_suppliers.Click += new System.EventHandler(this.menu_strip_suppliers_Click);
            // 
            // menu_strip_orders
            // 
            this.menu_strip_orders.Name = "menu_strip_orders";
            this.menu_strip_orders.Size = new System.Drawing.Size(166, 22);
            this.menu_strip_orders.Text = "Orders";
            this.menu_strip_orders.Click += new System.EventHandler(this.menu_strip_orders_Click);
            // 
            // menu_strip_bill
            // 
            this.menu_strip_bill.Name = "menu_strip_bill";
            this.menu_strip_bill.Size = new System.Drawing.Size(166, 22);
            this.menu_strip_bill.Text = "Bill";
            this.menu_strip_bill.Click += new System.EventHandler(this.menu_strip_bill_Click);
            // 
            // menu_strip_product_categories
            // 
            this.menu_strip_product_categories.Name = "menu_strip_product_categories";
            this.menu_strip_product_categories.Size = new System.Drawing.Size(166, 22);
            this.menu_strip_product_categories.Text = "Product Categories";
            this.menu_strip_product_categories.Click += new System.EventHandler(this.menu_strip_product_categories_Click);
            // 
            // operationToolStripMenuItem
            // 
            this.operationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_strip_select,
            this.menu_strip_add,
            this.menu_strip_delete,
            this.menu_strip_modify});
            this.operationToolStripMenuItem.Name = "operationToolStripMenuItem";
            this.operationToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.operationToolStripMenuItem.Text = "Operation";
            // 
            // menu_strip_select
            // 
            this.menu_strip_select.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_strip_select_id,
            this.menu_strip_select_username});
            this.menu_strip_select.Name = "menu_strip_select";
            this.menu_strip_select.Size = new System.Drawing.Size(106, 22);
            this.menu_strip_select.Text = "Select";
            // 
            // menu_strip_select_id
            // 
            this.menu_strip_select_id.Name = "menu_strip_select_id";
            this.menu_strip_select_id.Size = new System.Drawing.Size(137, 22);
            this.menu_strip_select_id.Text = "By ID";
            this.menu_strip_select_id.Click += new System.EventHandler(this.byIDToolStripMenuItem_Click);
            // 
            // menu_strip_select_username
            // 
            this.menu_strip_select_username.Name = "menu_strip_select_username";
            this.menu_strip_select_username.Size = new System.Drawing.Size(137, 22);
            this.menu_strip_select_username.Text = "By Username";
            this.menu_strip_select_username.Click += new System.EventHandler(this.byUsernameToolStripMenuItem_Click);
            // 
            // menu_strip_add
            // 
            this.menu_strip_add.Name = "menu_strip_add";
            this.menu_strip_add.Size = new System.Drawing.Size(106, 22);
            this.menu_strip_add.Text = "Add";
            this.menu_strip_add.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // menu_strip_delete
            // 
            this.menu_strip_delete.Name = "menu_strip_delete";
            this.menu_strip_delete.Size = new System.Drawing.Size(106, 22);
            this.menu_strip_delete.Text = "Delete";
            this.menu_strip_delete.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
            // 
            // menu_strip_modify
            // 
            this.menu_strip_modify.Name = "menu_strip_modify";
            this.menu_strip_modify.Size = new System.Drawing.Size(106, 22);
            this.menu_strip_modify.Text = "Modify";
            this.menu_strip_modify.Click += new System.EventHandler(this.modifyToolStripMenuItem_Click);
            // 
            // grp_main_menu
            // 
            this.grp_main_menu.Controls.Add(this.btn_main_menu_exit);
            this.grp_main_menu.Controls.Add(this.btn_logout);
            this.grp_main_menu.Controls.Add(this.btn_bill);
            this.grp_main_menu.Controls.Add(this.btn_orders);
            this.grp_main_menu.Controls.Add(this.btn_supplies);
            this.grp_main_menu.Controls.Add(this.btn_product_categories);
            this.grp_main_menu.Controls.Add(this.btn_products);
            this.grp_main_menu.Controls.Add(this.btn_modify_account);
            this.grp_main_menu.Location = new System.Drawing.Point(641, 46);
            this.grp_main_menu.Name = "grp_main_menu";
            this.grp_main_menu.Size = new System.Drawing.Size(338, 280);
            this.grp_main_menu.TabIndex = 3;
            this.grp_main_menu.TabStop = false;
            this.grp_main_menu.Text = "MAIN MENU";
            // 
            // btn_main_menu_exit
            // 
            this.btn_main_menu_exit.Location = new System.Drawing.Point(50, 238);
            this.btn_main_menu_exit.Name = "btn_main_menu_exit";
            this.btn_main_menu_exit.Size = new System.Drawing.Size(247, 23);
            this.btn_main_menu_exit.TabIndex = 7;
            this.btn_main_menu_exit.Text = "Exit";
            this.btn_main_menu_exit.UseVisualStyleBackColor = true;
            this.btn_main_menu_exit.Click += new System.EventHandler(this.btn_main_menu_exit_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(50, 209);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(247, 23);
            this.btn_logout.TabIndex = 6;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_orders
            // 
            this.btn_orders.Location = new System.Drawing.Point(50, 149);
            this.btn_orders.Name = "btn_orders";
            this.btn_orders.Size = new System.Drawing.Size(247, 23);
            this.btn_orders.TabIndex = 4;
            this.btn_orders.Text = "Orders";
            this.btn_orders.UseVisualStyleBackColor = true;
            this.btn_orders.Click += new System.EventHandler(this.btn_orders_Click);
            // 
            // btn_supplies
            // 
            this.btn_supplies.Location = new System.Drawing.Point(50, 120);
            this.btn_supplies.Name = "btn_supplies";
            this.btn_supplies.Size = new System.Drawing.Size(247, 23);
            this.btn_supplies.TabIndex = 3;
            this.btn_supplies.Text = "Suppliers";
            this.btn_supplies.UseVisualStyleBackColor = true;
            this.btn_supplies.Click += new System.EventHandler(this.btn_supplies_Click);
            // 
            // btn_product_categories
            // 
            this.btn_product_categories.Location = new System.Drawing.Point(50, 91);
            this.btn_product_categories.Name = "btn_product_categories";
            this.btn_product_categories.Size = new System.Drawing.Size(247, 23);
            this.btn_product_categories.TabIndex = 2;
            this.btn_product_categories.Text = "Product Categories";
            this.btn_product_categories.UseVisualStyleBackColor = true;
            this.btn_product_categories.Click += new System.EventHandler(this.btn_product_categories_Click);
            // 
            // btn_products
            // 
            this.btn_products.Location = new System.Drawing.Point(50, 60);
            this.btn_products.Name = "btn_products";
            this.btn_products.Size = new System.Drawing.Size(247, 25);
            this.btn_products.TabIndex = 1;
            this.btn_products.Text = "Products";
            this.btn_products.UseVisualStyleBackColor = true;
            this.btn_products.Click += new System.EventHandler(this.btn_products_Click);
            // 
            // btn_modify_account
            // 
            this.btn_modify_account.Location = new System.Drawing.Point(50, 31);
            this.btn_modify_account.Name = "btn_modify_account";
            this.btn_modify_account.Size = new System.Drawing.Size(247, 23);
            this.btn_modify_account.TabIndex = 0;
            this.btn_modify_account.Text = "Modify My Account";
            this.btn_modify_account.UseVisualStyleBackColor = true;
            this.btn_modify_account.Click += new System.EventHandler(this.btn_modify_account_Click);
            // 
            // btn_bill
            // 
            this.btn_bill.Location = new System.Drawing.Point(50, 180);
            this.btn_bill.Name = "btn_bill";
            this.btn_bill.Size = new System.Drawing.Size(247, 23);
            this.btn_bill.TabIndex = 5;
            this.btn_bill.Text = "Bill";
            this.btn_bill.UseVisualStyleBackColor = true;
            this.btn_bill.Click += new System.EventHandler(this.btn_bill_Click);
            // 
            // form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 403);
            this.Controls.Add(this.grp_main_menu);
            this.Controls.Add(this.grp_create);
            this.Controls.Add(this.grp_login);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "form_login";
            this.Text = "Store Management (Login)";
            this.Load += new System.EventHandler(this.form_login_Load);
            this.grp_login.ResumeLayout(false);
            this.grp_login.PerformLayout();
            this.grp_create.ResumeLayout(false);
            this.grp_create.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grp_main_menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_login;
        private System.Windows.Forms.Label login_lbl_username;
        private System.Windows.Forms.Label login_lbl_password;
        private System.Windows.Forms.TextBox login_txt_username;
        private System.Windows.Forms.TextBox login_txt_password;
        private System.Windows.Forms.Button login_btn_exit;
        private System.Windows.Forms.Button login_btn_login;
        private System.Windows.Forms.Button login_btn_create_new;
        private System.Windows.Forms.GroupBox grp_create;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.TextBox txt_staff_id;
        private System.Windows.Forms.Label lbl_staff_id;
        private System.Windows.Forms.CheckBox chk_administrator;
        private System.Windows.Forms.Label lbl_create_password2;
        private System.Windows.Forms.Label lbl_create_password1;
        private System.Windows.Forms.Label create_lbl_username;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox txt_lname;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_fname;
        private System.Windows.Forms.Label lbl_lname;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label lbl_fname;
        private System.Windows.Forms.TextBox txt_password2;
        private System.Windows.Forms.TextBox txt_password1;
        private System.Windows.Forms.TextBox txt_create_username;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_strip_logout;
        private System.Windows.Forms.ToolStripMenuItem menu_strip_exit;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_strip_products;
        private System.Windows.Forms.ToolStripMenuItem operationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_strip_select;
        private System.Windows.Forms.ToolStripMenuItem menu_strip_add;
        private System.Windows.Forms.ToolStripMenuItem menu_strip_delete;
        private System.Windows.Forms.ToolStripMenuItem menu_strip_modify;
        private System.Windows.Forms.ToolStripMenuItem menu_strip_select_id;
        private System.Windows.Forms.ToolStripMenuItem menu_strip_select_username;
        private System.Windows.Forms.GroupBox grp_main_menu;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_orders;
        private System.Windows.Forms.Button btn_supplies;
        private System.Windows.Forms.Button btn_product_categories;
        private System.Windows.Forms.Button btn_products;
        private System.Windows.Forms.Button btn_modify_account;
        private System.Windows.Forms.Button btn_main_menu_exit;
        private System.Windows.Forms.ToolStripMenuItem menu_strip_suppliers;
        private System.Windows.Forms.ToolStripMenuItem menu_strip_orders;
        private System.Windows.Forms.ToolStripMenuItem menu_strip_bill;
        private System.Windows.Forms.ToolStripMenuItem menu_strip_product_categories;
        private System.Windows.Forms.Button btn_bill;
    }
}

