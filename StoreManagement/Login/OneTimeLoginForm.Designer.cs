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
    partial class OneTimeLoginForm
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
            this.admin_lbl_admin = new System.Windows.Forms.Label();
            this.admin_lbl_username = new System.Windows.Forms.Label();
            this.admin_lbl_password = new System.Windows.Forms.Label();
            this.admin_txt_username = new System.Windows.Forms.TextBox();
            this.admin_txt_password = new System.Windows.Forms.TextBox();
            this.admin_btn_login = new System.Windows.Forms.Button();
            this.admin_btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // admin_lbl_admin
            // 
            this.admin_lbl_admin.AutoSize = true;
            this.admin_lbl_admin.Location = new System.Drawing.Point(13, 13);
            this.admin_lbl_admin.Name = "admin_lbl_admin";
            this.admin_lbl_admin.Size = new System.Drawing.Size(175, 13);
            this.admin_lbl_admin.TabIndex = 0;
            this.admin_lbl_admin.Text = "Administrator Login (Single Sign On)";
            // 
            // admin_lbl_username
            // 
            this.admin_lbl_username.AutoSize = true;
            this.admin_lbl_username.Location = new System.Drawing.Point(12, 46);
            this.admin_lbl_username.Name = "admin_lbl_username";
            this.admin_lbl_username.Size = new System.Drawing.Size(58, 13);
            this.admin_lbl_username.TabIndex = 1;
            this.admin_lbl_username.Text = "Username:";
            // 
            // admin_lbl_password
            // 
            this.admin_lbl_password.AutoSize = true;
            this.admin_lbl_password.Location = new System.Drawing.Point(13, 77);
            this.admin_lbl_password.Name = "admin_lbl_password";
            this.admin_lbl_password.Size = new System.Drawing.Size(56, 13);
            this.admin_lbl_password.TabIndex = 2;
            this.admin_lbl_password.Text = "Password:";
            // 
            // admin_txt_username
            // 
            this.admin_txt_username.Location = new System.Drawing.Point(76, 43);
            this.admin_txt_username.Name = "admin_txt_username";
            this.admin_txt_username.Size = new System.Drawing.Size(115, 20);
            this.admin_txt_username.TabIndex = 3;
            // 
            // admin_txt_password
            // 
            this.admin_txt_password.Location = new System.Drawing.Point(76, 74);
            this.admin_txt_password.Name = "admin_txt_password";
            this.admin_txt_password.PasswordChar = '•';
            this.admin_txt_password.Size = new System.Drawing.Size(115, 20);
            this.admin_txt_password.TabIndex = 4;
            this.admin_txt_password.UseSystemPasswordChar = true;
            // 
            // admin_btn_login
            // 
            this.admin_btn_login.Location = new System.Drawing.Point(16, 110);
            this.admin_btn_login.Name = "admin_btn_login";
            this.admin_btn_login.Size = new System.Drawing.Size(75, 23);
            this.admin_btn_login.TabIndex = 5;
            this.admin_btn_login.Text = "Login";
            this.admin_btn_login.UseVisualStyleBackColor = true;
            this.admin_btn_login.Click += new System.EventHandler(this.admin_btn_login_Click);
            // 
            // admin_btn_cancel
            // 
            this.admin_btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.admin_btn_cancel.Location = new System.Drawing.Point(116, 110);
            this.admin_btn_cancel.Name = "admin_btn_cancel";
            this.admin_btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.admin_btn_cancel.TabIndex = 6;
            this.admin_btn_cancel.Text = "Cancel";
            this.admin_btn_cancel.UseVisualStyleBackColor = true;
            this.admin_btn_cancel.Click += new System.EventHandler(this.admin_btn_cancel_Click);
            // 
            // OneTimeLoginForm
            // 
            this.AcceptButton = this.admin_btn_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.admin_btn_cancel;
            this.ClientSize = new System.Drawing.Size(217, 145);
            this.Controls.Add(this.admin_btn_cancel);
            this.Controls.Add(this.admin_btn_login);
            this.Controls.Add(this.admin_txt_password);
            this.Controls.Add(this.admin_txt_username);
            this.Controls.Add(this.admin_lbl_password);
            this.Controls.Add(this.admin_lbl_username);
            this.Controls.Add(this.admin_lbl_admin);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OneTimeLoginForm";
            this.ShowInTaskbar = false;
            this.Text = "One Time Login Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label admin_lbl_admin;
        private System.Windows.Forms.Label admin_lbl_username;
        private System.Windows.Forms.Label admin_lbl_password;
        private System.Windows.Forms.TextBox admin_txt_username;
        private System.Windows.Forms.TextBox admin_txt_password;
        private System.Windows.Forms.Button admin_btn_login;
        private System.Windows.Forms.Button admin_btn_cancel;
    }
}