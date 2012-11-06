namespace StoreManagement.Suppliers
{
    partial class Suppliers
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
            this.grp_suppliers = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rad_select = new System.Windows.Forms.RadioButton();
            this.rad_modify = new System.Windows.Forms.RadioButton();
            this.rad_delete = new System.Windows.Forms.RadioButton();
            this.btn_accept = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.rad_add = new System.Windows.Forms.RadioButton();
            this.txt_supplier_name = new System.Windows.Forms.TextBox();
            this.txt_supplier_phone = new System.Windows.Forms.TextBox();
            this.txt_supplier_email = new System.Windows.Forms.TextBox();
            this.grp_suppliers.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_suppliers
            // 
            this.grp_suppliers.Controls.Add(this.txt_supplier_email);
            this.grp_suppliers.Controls.Add(this.txt_supplier_phone);
            this.grp_suppliers.Controls.Add(this.txt_supplier_name);
            this.grp_suppliers.Controls.Add(this.rad_add);
            this.grp_suppliers.Controls.Add(this.label1);
            this.grp_suppliers.Controls.Add(this.label2);
            this.grp_suppliers.Controls.Add(this.label3);
            this.grp_suppliers.Controls.Add(this.rad_select);
            this.grp_suppliers.Controls.Add(this.rad_modify);
            this.grp_suppliers.Controls.Add(this.rad_delete);
            this.grp_suppliers.Controls.Add(this.btn_accept);
            this.grp_suppliers.Controls.Add(this.btn_cancel);
            this.grp_suppliers.Location = new System.Drawing.Point(13, 13);
            this.grp_suppliers.Name = "grp_suppliers";
            this.grp_suppliers.Size = new System.Drawing.Size(259, 237);
            this.grp_suppliers.TabIndex = 0;
            this.grp_suppliers.TabStop = false;
            this.grp_suppliers.Text = "Suppliers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Supplier\'s Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Supplier\'s Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Supplier\'s Phone:";
            // 
            // rad_select
            // 
            this.rad_select.AutoSize = true;
            this.rad_select.Location = new System.Drawing.Point(6, 162);
            this.rad_select.Name = "rad_select";
            this.rad_select.Size = new System.Drawing.Size(55, 17);
            this.rad_select.TabIndex = 4;
            this.rad_select.TabStop = true;
            this.rad_select.Text = "Select";
            this.rad_select.UseVisualStyleBackColor = true;
            // 
            // rad_modify
            // 
            this.rad_modify.AutoSize = true;
            this.rad_modify.Location = new System.Drawing.Point(6, 185);
            this.rad_modify.Name = "rad_modify";
            this.rad_modify.Size = new System.Drawing.Size(56, 17);
            this.rad_modify.TabIndex = 5;
            this.rad_modify.TabStop = true;
            this.rad_modify.Text = "Modify";
            this.rad_modify.UseVisualStyleBackColor = true;
            // 
            // rad_delete
            // 
            this.rad_delete.AutoSize = true;
            this.rad_delete.Location = new System.Drawing.Point(6, 208);
            this.rad_delete.Name = "rad_delete";
            this.rad_delete.Size = new System.Drawing.Size(56, 17);
            this.rad_delete.TabIndex = 6;
            this.rad_delete.TabStop = true;
            this.rad_delete.Text = "Delete";
            this.rad_delete.UseVisualStyleBackColor = true;
            // 
            // btn_accept
            // 
            this.btn_accept.Location = new System.Drawing.Point(178, 179);
            this.btn_accept.Name = "btn_accept";
            this.btn_accept.Size = new System.Drawing.Size(75, 23);
            this.btn_accept.TabIndex = 7;
            this.btn_accept.Text = "Accept";
            this.btn_accept.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(178, 208);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 8;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // rad_add
            // 
            this.rad_add.AutoSize = true;
            this.rad_add.Location = new System.Drawing.Point(6, 139);
            this.rad_add.Name = "rad_add";
            this.rad_add.Size = new System.Drawing.Size(44, 17);
            this.rad_add.TabIndex = 9;
            this.rad_add.TabStop = true;
            this.rad_add.Text = "Add";
            this.rad_add.UseVisualStyleBackColor = true;
            // 
            // txt_supplier_name
            // 
            this.txt_supplier_name.Location = new System.Drawing.Point(107, 26);
            this.txt_supplier_name.Name = "txt_supplier_name";
            this.txt_supplier_name.Size = new System.Drawing.Size(100, 20);
            this.txt_supplier_name.TabIndex = 10;
            // 
            // txt_supplier_phone
            // 
            this.txt_supplier_phone.Location = new System.Drawing.Point(107, 56);
            this.txt_supplier_phone.Name = "txt_supplier_phone";
            this.txt_supplier_phone.Size = new System.Drawing.Size(100, 20);
            this.txt_supplier_phone.TabIndex = 11;
            // 
            // txt_supplier_email
            // 
            this.txt_supplier_email.Location = new System.Drawing.Point(107, 84);
            this.txt_supplier_email.Name = "txt_supplier_email";
            this.txt_supplier_email.Size = new System.Drawing.Size(100, 20);
            this.txt_supplier_email.TabIndex = 12;
            // 
            // Suppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.grp_suppliers);
            this.Name = "Suppliers";
            this.Text = "Suppliers";
            this.grp_suppliers.ResumeLayout(false);
            this.grp_suppliers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_suppliers;
        private System.Windows.Forms.TextBox txt_supplier_email;
        private System.Windows.Forms.TextBox txt_supplier_phone;
        private System.Windows.Forms.TextBox txt_supplier_name;
        private System.Windows.Forms.RadioButton rad_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rad_select;
        private System.Windows.Forms.RadioButton rad_modify;
        private System.Windows.Forms.RadioButton rad_delete;
        private System.Windows.Forms.Button btn_accept;
        private System.Windows.Forms.Button btn_cancel;
    }
}