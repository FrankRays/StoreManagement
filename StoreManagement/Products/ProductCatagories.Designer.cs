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
    partial class ProductCatagories
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
            this.grp_product_categories = new System.Windows.Forms.GroupBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.rad_delete = new System.Windows.Forms.RadioButton();
            this.rad_select = new System.Windows.Forms.RadioButton();
            this.rad_add = new System.Windows.Forms.RadioButton();
            this.txt_category_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grp_product_categories.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_product_categories
            // 
            this.grp_product_categories.Controls.Add(this.btn_cancel);
            this.grp_product_categories.Controls.Add(this.btn_ok);
            this.grp_product_categories.Controls.Add(this.rad_delete);
            this.grp_product_categories.Controls.Add(this.rad_select);
            this.grp_product_categories.Controls.Add(this.rad_add);
            this.grp_product_categories.Controls.Add(this.txt_category_name);
            this.grp_product_categories.Controls.Add(this.label1);
            this.grp_product_categories.Location = new System.Drawing.Point(9, 10);
            this.grp_product_categories.Name = "grp_product_categories";
            this.grp_product_categories.Size = new System.Drawing.Size(224, 166);
            this.grp_product_categories.TabIndex = 0;
            this.grp_product_categories.TabStop = false;
            this.grp_product_categories.Text = "Product Categories";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(94, 109);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(94, 66);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 6;
            this.btn_ok.Text = "Ok";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_accept_Click);
            // 
            // rad_delete
            // 
            this.rad_delete.AutoSize = true;
            this.rad_delete.Location = new System.Drawing.Point(6, 112);
            this.rad_delete.Name = "rad_delete";
            this.rad_delete.Size = new System.Drawing.Size(56, 17);
            this.rad_delete.TabIndex = 5;
            this.rad_delete.TabStop = true;
            this.rad_delete.Text = "Delete";
            this.rad_delete.UseVisualStyleBackColor = true;
            this.rad_delete.CheckedChanged += new System.EventHandler(this.rad_delete_CheckedChanged);
            // 
            // rad_select
            // 
            this.rad_select.AutoSize = true;
            this.rad_select.Location = new System.Drawing.Point(6, 89);
            this.rad_select.Name = "rad_select";
            this.rad_select.Size = new System.Drawing.Size(55, 17);
            this.rad_select.TabIndex = 3;
            this.rad_select.TabStop = true;
            this.rad_select.Text = "Select";
            this.rad_select.UseVisualStyleBackColor = true;
            this.rad_select.CheckedChanged += new System.EventHandler(this.rad_select_CheckedChanged);
            // 
            // rad_add
            // 
            this.rad_add.AutoSize = true;
            this.rad_add.Location = new System.Drawing.Point(6, 66);
            this.rad_add.Name = "rad_add";
            this.rad_add.Size = new System.Drawing.Size(44, 17);
            this.rad_add.TabIndex = 2;
            this.rad_add.TabStop = true;
            this.rad_add.Text = "Add";
            this.rad_add.UseVisualStyleBackColor = true;
            this.rad_add.CheckedChanged += new System.EventHandler(this.rad_add_CheckedChanged);
            // 
            // txt_category_name
            // 
            this.txt_category_name.Location = new System.Drawing.Point(116, 19);
            this.txt_category_name.Name = "txt_category_name";
            this.txt_category_name.Size = new System.Drawing.Size(100, 20);
            this.txt_category_name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category Name:";
            // 
            // ProductCatagories
            // 
            this.AcceptButton = this.btn_ok;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(240, 182);
            this.Controls.Add(this.grp_product_categories);
            this.MaximumSize = new System.Drawing.Size(256, 220);
            this.MinimumSize = new System.Drawing.Size(256, 220);
            this.Name = "ProductCatagories";
            this.Text = "ProductCatagories";
            this.grp_product_categories.ResumeLayout(false);
            this.grp_product_categories.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_product_categories;
        private System.Windows.Forms.RadioButton rad_add;
        private System.Windows.Forms.TextBox txt_category_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rad_delete;
        private System.Windows.Forms.RadioButton rad_select;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_ok;
    }
}