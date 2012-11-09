namespace StoreManagement
{
    partial class OracleDatabaseController
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
            this.grp_bill = new System.Windows.Forms.GroupBox();
            this.data_grid_view_bill = new System.Windows.Forms.DataGridView();
            this.txt_customer_lastname = new System.Windows.Forms.TextBox();
            this.txt_customer_firstname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_total_cost = new System.Windows.Forms.TextBox();
            this.grp_select = new System.Windows.Forms.GroupBox();
            this.btn_generate = new System.Windows.Forms.Button();
            this.txt_select = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grp_bill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_view_bill)).BeginInit();
            this.grp_select.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_bill
            // 
            this.grp_bill.Controls.Add(this.data_grid_view_bill);
            this.grp_bill.Controls.Add(this.txt_customer_lastname);
            this.grp_bill.Controls.Add(this.txt_customer_firstname);
            this.grp_bill.Controls.Add(this.label3);
            this.grp_bill.Controls.Add(this.btn_close);
            this.grp_bill.Controls.Add(this.label2);
            this.grp_bill.Controls.Add(this.txt_total_cost);
            this.grp_bill.Controls.Add(this.grp_select);
            this.grp_bill.Location = new System.Drawing.Point(12, 12);
            this.grp_bill.Name = "grp_bill";
            this.grp_bill.Size = new System.Drawing.Size(401, 324);
            this.grp_bill.TabIndex = 0;
            this.grp_bill.TabStop = false;
            this.grp_bill.Text = "Bill";
            // 
            // data_grid_view_bill
            // 
            this.data_grid_view_bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid_view_bill.Location = new System.Drawing.Point(7, 118);
            this.data_grid_view_bill.Name = "data_grid_view_bill";
            this.data_grid_view_bill.ReadOnly = true;
            this.data_grid_view_bill.Size = new System.Drawing.Size(388, 145);
            this.data_grid_view_bill.TabIndex = 6;
            // 
            // txt_customer_lastname
            // 
            this.txt_customer_lastname.Location = new System.Drawing.Point(234, 89);
            this.txt_customer_lastname.Name = "txt_customer_lastname";
            this.txt_customer_lastname.ReadOnly = true;
            this.txt_customer_lastname.Size = new System.Drawing.Size(100, 20);
            this.txt_customer_lastname.TabIndex = 5;
            // 
            // txt_customer_firstname
            // 
            this.txt_customer_firstname.Location = new System.Drawing.Point(117, 89);
            this.txt_customer_firstname.Name = "txt_customer_firstname";
            this.txt_customer_firstname.ReadOnly = true;
            this.txt_customer_firstname.Size = new System.Drawing.Size(100, 20);
            this.txt_customer_firstname.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Customer Name:";
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(320, 295);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total Cost:";
            // 
            // txt_total_cost
            // 
            this.txt_total_cost.Location = new System.Drawing.Point(295, 269);
            this.txt_total_cost.Name = "txt_total_cost";
            this.txt_total_cost.ReadOnly = true;
            this.txt_total_cost.Size = new System.Drawing.Size(100, 20);
            this.txt_total_cost.TabIndex = 1;
            // 
            // grp_select
            // 
            this.grp_select.Controls.Add(this.btn_generate);
            this.grp_select.Controls.Add(this.txt_select);
            this.grp_select.Controls.Add(this.label1);
            this.grp_select.Location = new System.Drawing.Point(6, 19);
            this.grp_select.Name = "grp_select";
            this.grp_select.Size = new System.Drawing.Size(389, 41);
            this.grp_select.TabIndex = 0;
            this.grp_select.TabStop = false;
            this.grp_select.Text = "Select";
            // 
            // btn_generate
            // 
            this.btn_generate.Location = new System.Drawing.Point(253, 11);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(75, 23);
            this.btn_generate.TabIndex = 2;
            this.btn_generate.Text = "Generate Bill";
            this.btn_generate.UseVisualStyleBackColor = true;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // txt_select
            // 
            this.txt_select.Location = new System.Drawing.Point(111, 13);
            this.txt_select.Name = "txt_select";
            this.txt_select.Size = new System.Drawing.Size(100, 20);
            this.txt_select.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order ID:";
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 348);
            this.Controls.Add(this.grp_bill);
            this.Name = "Bill";
            this.Text = "Bill";
            this.grp_bill.ResumeLayout(false);
            this.grp_bill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_view_bill)).EndInit();
            this.grp_select.ResumeLayout(false);
            this.grp_select.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_bill;
        private System.Windows.Forms.GroupBox grp_select;
        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.TextBox txt_select;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_total_cost;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.TextBox txt_customer_lastname;
        private System.Windows.Forms.TextBox txt_customer_firstname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView data_grid_view_bill;
    }
}