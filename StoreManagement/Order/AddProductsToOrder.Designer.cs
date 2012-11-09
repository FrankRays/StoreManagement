namespace StoreManagement
{
    partial class AddProductsToOrder
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGrid_addToProducts = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_accept = new System.Windows.Forms.Button();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.cmb_product_name = new System.Windows.Forms.ComboBox();
            this.txt_order_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_addToProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGrid_addToProducts);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_cancel);
            this.groupBox1.Controls.Add(this.btn_accept);
            this.groupBox1.Controls.Add(this.txt_quantity);
            this.groupBox1.Controls.Add(this.cmb_product_name);
            this.groupBox1.Controls.Add(this.txt_order_id);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 301);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add to products";
            // 
            // dataGrid_addToProducts
            // 
            this.dataGrid_addToProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_addToProducts.Location = new System.Drawing.Point(10, 144);
            this.dataGrid_addToProducts.Name = "dataGrid_addToProducts";
            this.dataGrid_addToProducts.ReadOnly = true;
            this.dataGrid_addToProducts.Size = new System.Drawing.Size(342, 112);
            this.dataGrid_addToProducts.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Products ordered:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Product quantity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Product Name:";
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(277, 272);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_accept
            // 
            this.btn_accept.Location = new System.Drawing.Point(196, 272);
            this.btn_accept.Name = "btn_accept";
            this.btn_accept.Size = new System.Drawing.Size(75, 23);
            this.btn_accept.TabIndex = 4;
            this.btn_accept.Text = "Accept";
            this.btn_accept.UseVisualStyleBackColor = true;
            this.btn_accept.Click += new System.EventHandler(this.btn_accept_Click);
            // 
            // txt_quantity
            // 
            this.txt_quantity.Location = new System.Drawing.Point(169, 83);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(121, 20);
            this.txt_quantity.TabIndex = 3;
            // 
            // cmb_product_name
            // 
            this.cmb_product_name.FormattingEnabled = true;
            this.cmb_product_name.Location = new System.Drawing.Point(169, 56);
            this.cmb_product_name.Name = "cmb_product_name";
            this.cmb_product_name.Size = new System.Drawing.Size(121, 21);
            this.cmb_product_name.TabIndex = 2;
            // 
            // txt_order_id
            // 
            this.txt_order_id.Location = new System.Drawing.Point(169, 30);
            this.txt_order_id.Name = "txt_order_id";
            this.txt_order_id.ReadOnly = true;
            this.txt_order_id.Size = new System.Drawing.Size(121, 20);
            this.txt_order_id.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order ID:";
            // 
            // AddProductsToOrder
            // 
            this.AcceptButton = this.btn_accept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(386, 325);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddProductsToOrder";
            this.Text = "AddProductsToOrder";
            this.Load += new System.EventHandler(this.AddProductsToOrder_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_addToProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_accept;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.ComboBox cmb_product_name;
        private System.Windows.Forms.TextBox txt_order_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGrid_addToProducts;
    }
}