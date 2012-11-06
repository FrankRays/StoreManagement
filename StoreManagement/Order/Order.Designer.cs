namespace StoreManagement
{
    partial class Order
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
            this.grp_order = new System.Windows.Forms.GroupBox();
            this.dtp_date_of_dispatch = new System.Windows.Forms.DateTimePicker();
            this.dtp_date_of_order = new System.Windows.Forms.DateTimePicker();
            this.cmb_mode_of_payment = new System.Windows.Forms.ComboBox();
            this.txt_customer_last_name = new System.Windows.Forms.TextBox();
            this.txt_customer_first_name = new System.Windows.Forms.TextBox();
            this.txt_order_id = new System.Windows.Forms.TextBox();
            this.rad_delete = new System.Windows.Forms.RadioButton();
            this.rad_modify = new System.Windows.Forms.RadioButton();
            this.rad_select = new System.Windows.Forms.RadioButton();
            this.rad_add = new System.Windows.Forms.RadioButton();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_accept = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grp_order.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_order
            // 
            this.grp_order.Controls.Add(this.dtp_date_of_dispatch);
            this.grp_order.Controls.Add(this.dtp_date_of_order);
            this.grp_order.Controls.Add(this.cmb_mode_of_payment);
            this.grp_order.Controls.Add(this.txt_customer_last_name);
            this.grp_order.Controls.Add(this.txt_customer_first_name);
            this.grp_order.Controls.Add(this.txt_order_id);
            this.grp_order.Controls.Add(this.rad_delete);
            this.grp_order.Controls.Add(this.rad_modify);
            this.grp_order.Controls.Add(this.rad_select);
            this.grp_order.Controls.Add(this.rad_add);
            this.grp_order.Controls.Add(this.btn_cancel);
            this.grp_order.Controls.Add(this.btn_accept);
            this.grp_order.Controls.Add(this.label6);
            this.grp_order.Controls.Add(this.label5);
            this.grp_order.Controls.Add(this.label4);
            this.grp_order.Controls.Add(this.label3);
            this.grp_order.Controls.Add(this.label2);
            this.grp_order.Controls.Add(this.label1);
            this.grp_order.Location = new System.Drawing.Point(12, 12);
            this.grp_order.Name = "grp_order";
            this.grp_order.Size = new System.Drawing.Size(300, 266);
            this.grp_order.TabIndex = 0;
            this.grp_order.TabStop = false;
            this.grp_order.Text = "Order";
            // 
            // dtp_date_of_dispatch
            // 
            this.dtp_date_of_dispatch.Location = new System.Drawing.Point(162, 143);
            this.dtp_date_of_dispatch.Name = "dtp_date_of_dispatch";
            this.dtp_date_of_dispatch.Size = new System.Drawing.Size(121, 20);
            this.dtp_date_of_dispatch.TabIndex = 17;
            // 
            // dtp_date_of_order
            // 
            this.dtp_date_of_order.Location = new System.Drawing.Point(162, 117);
            this.dtp_date_of_order.Name = "dtp_date_of_order";
            this.dtp_date_of_order.Size = new System.Drawing.Size(121, 20);
            this.dtp_date_of_order.TabIndex = 16;
            // 
            // cmb_mode_of_payment
            // 
            this.cmb_mode_of_payment.AutoCompleteCustomSource.AddRange(new string[] {
            "abcd",
            "efgh",
            "ijkl",
            "lmno",
            "pqrs"});
            this.cmb_mode_of_payment.FormattingEnabled = true;
            this.cmb_mode_of_payment.Items.AddRange(new object[] {
            "Cash",
            "Cheque",
            "Demand Draft",
            "Credit Card",
            "Debit Card"});
            this.cmb_mode_of_payment.Location = new System.Drawing.Point(162, 90);
            this.cmb_mode_of_payment.Name = "cmb_mode_of_payment";
            this.cmb_mode_of_payment.Size = new System.Drawing.Size(121, 21);
            this.cmb_mode_of_payment.TabIndex = 15;
            // 
            // txt_customer_last_name
            // 
            this.txt_customer_last_name.Location = new System.Drawing.Point(162, 68);
            this.txt_customer_last_name.Name = "txt_customer_last_name";
            this.txt_customer_last_name.Size = new System.Drawing.Size(121, 20);
            this.txt_customer_last_name.TabIndex = 14;
            // 
            // txt_customer_first_name
            // 
            this.txt_customer_first_name.Location = new System.Drawing.Point(162, 45);
            this.txt_customer_first_name.Name = "txt_customer_first_name";
            this.txt_customer_first_name.Size = new System.Drawing.Size(121, 20);
            this.txt_customer_first_name.TabIndex = 13;
            // 
            // txt_order_id
            // 
            this.txt_order_id.Location = new System.Drawing.Point(162, 21);
            this.txt_order_id.Name = "txt_order_id";
            this.txt_order_id.Size = new System.Drawing.Size(121, 20);
            this.txt_order_id.TabIndex = 12;
            // 
            // rad_delete
            // 
            this.rad_delete.AutoSize = true;
            this.rad_delete.Location = new System.Drawing.Point(6, 242);
            this.rad_delete.Name = "rad_delete";
            this.rad_delete.Size = new System.Drawing.Size(56, 17);
            this.rad_delete.TabIndex = 11;
            this.rad_delete.TabStop = true;
            this.rad_delete.Text = "Delete";
            this.rad_delete.UseVisualStyleBackColor = true;
            // 
            // rad_modify
            // 
            this.rad_modify.AutoSize = true;
            this.rad_modify.Location = new System.Drawing.Point(6, 219);
            this.rad_modify.Name = "rad_modify";
            this.rad_modify.Size = new System.Drawing.Size(56, 17);
            this.rad_modify.TabIndex = 10;
            this.rad_modify.TabStop = true;
            this.rad_modify.Text = "Modify";
            this.rad_modify.UseVisualStyleBackColor = true;
            // 
            // rad_select
            // 
            this.rad_select.AutoSize = true;
            this.rad_select.Location = new System.Drawing.Point(6, 196);
            this.rad_select.Name = "rad_select";
            this.rad_select.Size = new System.Drawing.Size(55, 17);
            this.rad_select.TabIndex = 9;
            this.rad_select.TabStop = true;
            this.rad_select.Text = "Select";
            this.rad_select.UseVisualStyleBackColor = true;
            // 
            // rad_add
            // 
            this.rad_add.AutoSize = true;
            this.rad_add.Location = new System.Drawing.Point(6, 173);
            this.rad_add.Name = "rad_add";
            this.rad_add.Size = new System.Drawing.Size(44, 17);
            this.rad_add.TabIndex = 8;
            this.rad_add.TabStop = true;
            this.rad_add.Text = "Add";
            this.rad_add.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(208, 223);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_accept
            // 
            this.btn_accept.Location = new System.Drawing.Point(208, 194);
            this.btn_accept.Name = "btn_accept";
            this.btn_accept.Size = new System.Drawing.Size(75, 23);
            this.btn_accept.TabIndex = 6;
            this.btn_accept.Text = "Accept";
            this.btn_accept.UseVisualStyleBackColor = true;
            this.btn_accept.Click += new System.EventHandler(this.btn_accept_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Date of Dispatch:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date of Order:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mode of Payment:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer First Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order_Id:";
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 290);
            this.Controls.Add(this.grp_order);
            this.Name = "Order";
            this.Text = "Order";
            this.grp_order.ResumeLayout(false);
            this.grp_order.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_order;
        private System.Windows.Forms.DateTimePicker dtp_date_of_dispatch;
        private System.Windows.Forms.DateTimePicker dtp_date_of_order;
        private System.Windows.Forms.ComboBox cmb_mode_of_payment;
        private System.Windows.Forms.TextBox txt_customer_last_name;
        private System.Windows.Forms.TextBox txt_customer_first_name;
        private System.Windows.Forms.TextBox txt_order_id;
        private System.Windows.Forms.RadioButton rad_delete;
        private System.Windows.Forms.RadioButton rad_modify;
        private System.Windows.Forms.RadioButton rad_select;
        private System.Windows.Forms.RadioButton rad_add;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_accept;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}