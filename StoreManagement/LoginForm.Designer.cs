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
            this.login_grpBox_login = new System.Windows.Forms.GroupBox();
            this.login_btn_exit = new System.Windows.Forms.Button();
            this.login_btn_login = new System.Windows.Forms.Button();
            this.login_btn_create_new = new System.Windows.Forms.Button();
            this.login_txt_password = new System.Windows.Forms.TextBox();
            this.login_txt_username = new System.Windows.Forms.TextBox();
            this.login_lbl_username = new System.Windows.Forms.Label();
            this.login_lbl_password = new System.Windows.Forms.Label();
            this.login_grp_create = new System.Windows.Forms.GroupBox();
            this.login_chk_administrator = new System.Windows.Forms.CheckBox();
            this.login_btn_create = new System.Windows.Forms.Button();
            this.login_txt_staff_id = new System.Windows.Forms.TextBox();
            this.login_lbl_staff_id = new System.Windows.Forms.Label();
            this.login_create_lbl_username = new System.Windows.Forms.Label();
            this.login_lbl_create_password1 = new System.Windows.Forms.Label();
            this.login_lbl_create_password2 = new System.Windows.Forms.Label();
            this.login_lbl_phone = new System.Windows.Forms.Label();
            this.login_lbl_email = new System.Windows.Forms.Label();
            this.login_txt_create_username = new System.Windows.Forms.TextBox();
            this.login_txt_password1 = new System.Windows.Forms.TextBox();
            this.login_txt_password2 = new System.Windows.Forms.TextBox();
            this.login_txt_phone = new System.Windows.Forms.TextBox();
            this.login_txt_email = new System.Windows.Forms.TextBox();
            this.login_lbl_fname = new System.Windows.Forms.Label();
            this.login_lbl_lname = new System.Windows.Forms.Label();
            this.login_txt_fname = new System.Windows.Forms.TextBox();
            this.login_txt_lname = new System.Windows.Forms.TextBox();
            this.login_btn_cancel = new System.Windows.Forms.Button();
            this.login_grpBox_login.SuspendLayout();
            this.login_grp_create.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_grpBox_login
            // 
            this.login_grpBox_login.Controls.Add(this.login_btn_exit);
            this.login_grpBox_login.Controls.Add(this.login_btn_login);
            this.login_grpBox_login.Controls.Add(this.login_btn_create_new);
            this.login_grpBox_login.Controls.Add(this.login_txt_password);
            this.login_grpBox_login.Controls.Add(this.login_txt_username);
            this.login_grpBox_login.Controls.Add(this.login_lbl_username);
            this.login_grpBox_login.Controls.Add(this.login_lbl_password);
            this.login_grpBox_login.Location = new System.Drawing.Point(12, 12);
            this.login_grpBox_login.Name = "login_grpBox_login";
            this.login_grpBox_login.Size = new System.Drawing.Size(253, 139);
            this.login_grpBox_login.TabIndex = 0;
            this.login_grpBox_login.TabStop = false;
            this.login_grpBox_login.Text = "Login";
            // 
            // login_btn_exit
            // 
            this.login_btn_exit.Location = new System.Drawing.Point(168, 96);
            this.login_btn_exit.Name = "login_btn_exit";
            this.login_btn_exit.Size = new System.Drawing.Size(75, 23);
            this.login_btn_exit.TabIndex = 7;
            this.login_btn_exit.Text = "Exit";
            this.login_btn_exit.UseVisualStyleBackColor = true;
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
            // login_grp_create
            // 
            this.login_grp_create.Controls.Add(this.login_btn_cancel);
            this.login_grp_create.Controls.Add(this.login_txt_lname);
            this.login_grp_create.Controls.Add(this.login_txt_email);
            this.login_grp_create.Controls.Add(this.login_txt_fname);
            this.login_grp_create.Controls.Add(this.login_lbl_lname);
            this.login_grp_create.Controls.Add(this.login_txt_phone);
            this.login_grp_create.Controls.Add(this.login_lbl_fname);
            this.login_grp_create.Controls.Add(this.login_txt_password2);
            this.login_grp_create.Controls.Add(this.login_txt_password1);
            this.login_grp_create.Controls.Add(this.login_txt_create_username);
            this.login_grp_create.Controls.Add(this.login_lbl_email);
            this.login_grp_create.Controls.Add(this.login_lbl_phone);
            this.login_grp_create.Controls.Add(this.login_lbl_create_password2);
            this.login_grp_create.Controls.Add(this.login_lbl_create_password1);
            this.login_grp_create.Controls.Add(this.login_create_lbl_username);
            this.login_grp_create.Controls.Add(this.login_chk_administrator);
            this.login_grp_create.Controls.Add(this.login_btn_create);
            this.login_grp_create.Controls.Add(this.login_txt_staff_id);
            this.login_grp_create.Controls.Add(this.login_lbl_staff_id);
            this.login_grp_create.Location = new System.Drawing.Point(317, 12);
            this.login_grp_create.Name = "login_grp_create";
            this.login_grp_create.Size = new System.Drawing.Size(285, 318);
            this.login_grp_create.TabIndex = 1;
            this.login_grp_create.TabStop = false;
            this.login_grp_create.Text = "Create";
            // 
            // login_chk_administrator
            // 
            this.login_chk_administrator.AutoSize = true;
            this.login_chk_administrator.Location = new System.Drawing.Point(127, 244);
            this.login_chk_administrator.Name = "login_chk_administrator";
            this.login_chk_administrator.Size = new System.Drawing.Size(86, 17);
            this.login_chk_administrator.TabIndex = 3;
            this.login_chk_administrator.Text = "Administrator";
            this.login_chk_administrator.UseVisualStyleBackColor = true;
            // 
            // login_btn_create
            // 
            this.login_btn_create.Location = new System.Drawing.Point(68, 280);
            this.login_btn_create.Name = "login_btn_create";
            this.login_btn_create.Size = new System.Drawing.Size(75, 23);
            this.login_btn_create.TabIndex = 2;
            this.login_btn_create.Text = "Create";
            this.login_btn_create.UseVisualStyleBackColor = true;
            // 
            // login_txt_staff_id
            // 
            this.login_txt_staff_id.Location = new System.Drawing.Point(127, 31);
            this.login_txt_staff_id.Name = "login_txt_staff_id";
            this.login_txt_staff_id.ReadOnly = true;
            this.login_txt_staff_id.Size = new System.Drawing.Size(100, 20);
            this.login_txt_staff_id.TabIndex = 1;
            // 
            // login_lbl_staff_id
            // 
            this.login_lbl_staff_id.AutoSize = true;
            this.login_lbl_staff_id.Location = new System.Drawing.Point(18, 31);
            this.login_lbl_staff_id.Name = "login_lbl_staff_id";
            this.login_lbl_staff_id.Size = new System.Drawing.Size(44, 13);
            this.login_lbl_staff_id.TabIndex = 0;
            this.login_lbl_staff_id.Text = "Staff Id:";
            // 
            // login_create_lbl_username
            // 
            this.login_create_lbl_username.AutoSize = true;
            this.login_create_lbl_username.Location = new System.Drawing.Point(18, 61);
            this.login_create_lbl_username.Name = "login_create_lbl_username";
            this.login_create_lbl_username.Size = new System.Drawing.Size(58, 13);
            this.login_create_lbl_username.TabIndex = 4;
            this.login_create_lbl_username.Text = "Username:";
            // 
            // login_lbl_create_password1
            // 
            this.login_lbl_create_password1.AutoSize = true;
            this.login_lbl_create_password1.Location = new System.Drawing.Point(18, 87);
            this.login_lbl_create_password1.Name = "login_lbl_create_password1";
            this.login_lbl_create_password1.Size = new System.Drawing.Size(56, 13);
            this.login_lbl_create_password1.TabIndex = 5;
            this.login_lbl_create_password1.Text = "Password:";
            // 
            // login_lbl_create_password2
            // 
            this.login_lbl_create_password2.AutoSize = true;
            this.login_lbl_create_password2.Location = new System.Drawing.Point(18, 116);
            this.login_lbl_create_password2.Name = "login_lbl_create_password2";
            this.login_lbl_create_password2.Size = new System.Drawing.Size(94, 13);
            this.login_lbl_create_password2.TabIndex = 6;
            this.login_lbl_create_password2.Text = "Password Confirm:";
            // 
            // login_lbl_phone
            // 
            this.login_lbl_phone.AutoSize = true;
            this.login_lbl_phone.Location = new System.Drawing.Point(18, 194);
            this.login_lbl_phone.Name = "login_lbl_phone";
            this.login_lbl_phone.Size = new System.Drawing.Size(41, 13);
            this.login_lbl_phone.TabIndex = 7;
            this.login_lbl_phone.Text = "Phone:";
            // 
            // login_lbl_email
            // 
            this.login_lbl_email.AutoSize = true;
            this.login_lbl_email.Location = new System.Drawing.Point(18, 221);
            this.login_lbl_email.Name = "login_lbl_email";
            this.login_lbl_email.Size = new System.Drawing.Size(35, 13);
            this.login_lbl_email.TabIndex = 8;
            this.login_lbl_email.Text = "Email:";
            // 
            // login_txt_create_username
            // 
            this.login_txt_create_username.Location = new System.Drawing.Point(127, 58);
            this.login_txt_create_username.Name = "login_txt_create_username";
            this.login_txt_create_username.Size = new System.Drawing.Size(100, 20);
            this.login_txt_create_username.TabIndex = 9;
            // 
            // login_txt_password1
            // 
            this.login_txt_password1.Location = new System.Drawing.Point(127, 84);
            this.login_txt_password1.Name = "login_txt_password1";
            this.login_txt_password1.Size = new System.Drawing.Size(100, 20);
            this.login_txt_password1.TabIndex = 10;
            this.login_txt_password1.UseSystemPasswordChar = true;
            // 
            // login_txt_password2
            // 
            this.login_txt_password2.Location = new System.Drawing.Point(127, 113);
            this.login_txt_password2.Name = "login_txt_password2";
            this.login_txt_password2.Size = new System.Drawing.Size(100, 20);
            this.login_txt_password2.TabIndex = 11;
            this.login_txt_password2.UseSystemPasswordChar = true;
            // 
            // login_txt_phone
            // 
            this.login_txt_phone.Location = new System.Drawing.Point(127, 191);
            this.login_txt_phone.Name = "login_txt_phone";
            this.login_txt_phone.Size = new System.Drawing.Size(100, 20);
            this.login_txt_phone.TabIndex = 12;
            // 
            // login_txt_email
            // 
            this.login_txt_email.Location = new System.Drawing.Point(127, 218);
            this.login_txt_email.Name = "login_txt_email";
            this.login_txt_email.Size = new System.Drawing.Size(100, 20);
            this.login_txt_email.TabIndex = 13;
            // 
            // login_lbl_fname
            // 
            this.login_lbl_fname.AutoSize = true;
            this.login_lbl_fname.Location = new System.Drawing.Point(18, 142);
            this.login_lbl_fname.Name = "login_lbl_fname";
            this.login_lbl_fname.Size = new System.Drawing.Size(60, 13);
            this.login_lbl_fname.TabIndex = 14;
            this.login_lbl_fname.Text = "First Name:";
            // 
            // login_lbl_lname
            // 
            this.login_lbl_lname.AutoSize = true;
            this.login_lbl_lname.Location = new System.Drawing.Point(18, 166);
            this.login_lbl_lname.Name = "login_lbl_lname";
            this.login_lbl_lname.Size = new System.Drawing.Size(61, 13);
            this.login_lbl_lname.TabIndex = 15;
            this.login_lbl_lname.Text = "Last Name:";
            // 
            // login_txt_fname
            // 
            this.login_txt_fname.Location = new System.Drawing.Point(127, 139);
            this.login_txt_fname.Name = "login_txt_fname";
            this.login_txt_fname.Size = new System.Drawing.Size(100, 20);
            this.login_txt_fname.TabIndex = 16;
            // 
            // login_txt_lname
            // 
            this.login_txt_lname.Location = new System.Drawing.Point(127, 163);
            this.login_txt_lname.Name = "login_txt_lname";
            this.login_txt_lname.Size = new System.Drawing.Size(100, 20);
            this.login_txt_lname.TabIndex = 17;
            // 
            // login_btn_cancel
            // 
            this.login_btn_cancel.Location = new System.Drawing.Point(152, 280);
            this.login_btn_cancel.Name = "login_btn_cancel";
            this.login_btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.login_btn_cancel.TabIndex = 18;
            this.login_btn_cancel.Text = "Cancel";
            this.login_btn_cancel.UseVisualStyleBackColor = true;
            // 
            // form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 342);
            this.Controls.Add(this.login_grp_create);
            this.Controls.Add(this.login_grpBox_login);
            this.Name = "form_login";
            this.Text = "Store Management (Login)";
            this.Load += new System.EventHandler(this.form_login_Load);
            this.login_grpBox_login.ResumeLayout(false);
            this.login_grpBox_login.PerformLayout();
            this.login_grp_create.ResumeLayout(false);
            this.login_grp_create.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox login_grpBox_login;
        private System.Windows.Forms.Label login_lbl_username;
        private System.Windows.Forms.Label login_lbl_password;
        private System.Windows.Forms.TextBox login_txt_username;
        private System.Windows.Forms.TextBox login_txt_password;
        private System.Windows.Forms.Button login_btn_exit;
        private System.Windows.Forms.Button login_btn_login;
        private System.Windows.Forms.Button login_btn_create_new;
        private System.Windows.Forms.GroupBox login_grp_create;
        private System.Windows.Forms.Button login_btn_create;
        private System.Windows.Forms.TextBox login_txt_staff_id;
        private System.Windows.Forms.Label login_lbl_staff_id;
        private System.Windows.Forms.CheckBox login_chk_administrator;
        private System.Windows.Forms.Label login_lbl_create_password2;
        private System.Windows.Forms.Label login_lbl_create_password1;
        private System.Windows.Forms.Label login_create_lbl_username;
        private System.Windows.Forms.Button login_btn_cancel;
        private System.Windows.Forms.TextBox login_txt_lname;
        private System.Windows.Forms.TextBox login_txt_email;
        private System.Windows.Forms.TextBox login_txt_fname;
        private System.Windows.Forms.Label login_lbl_lname;
        private System.Windows.Forms.TextBox login_txt_phone;
        private System.Windows.Forms.Label login_lbl_fname;
        private System.Windows.Forms.TextBox login_txt_password2;
        private System.Windows.Forms.TextBox login_txt_password1;
        private System.Windows.Forms.TextBox login_txt_create_username;
        private System.Windows.Forms.Label login_lbl_email;
        private System.Windows.Forms.Label login_lbl_phone;
    }
}

