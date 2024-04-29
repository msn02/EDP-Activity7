namespace Activity5
{
    partial class placeOrderForm
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
            this.backBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.orderData = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deliveryIDTbx = new System.Windows.Forms.TextBox();
            this.customerIDTbx = new System.Windows.Forms.TextBox();
            this.orderStatusTbx = new System.Windows.Forms.ComboBox();
            this.successLabel1 = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.quantityTbx = new System.Windows.Forms.TextBox();
            this.prodIDTbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.orderBtn = new System.Windows.Forms.Button();
            this.dateTbx = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.productData = new System.Windows.Forms.DataGridView();
            this.clearBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.paymentTbx = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orderData)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productData)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(23, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(47, 25);
            this.backBtn.TabIndex = 18;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "Place Order";
            // 
            // orderData
            // 
            this.orderData.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.orderData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderData.Location = new System.Drawing.Point(23, 71);
            this.orderData.Name = "orderData";
            this.orderData.RowHeadersWidth = 51;
            this.orderData.Size = new System.Drawing.Size(571, 148);
            this.orderData.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.paymentTbx);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.clearBtn);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dateTbx);
            this.panel1.Controls.Add(this.deliveryIDTbx);
            this.panel1.Controls.Add(this.customerIDTbx);
            this.panel1.Controls.Add(this.orderStatusTbx);
            this.panel1.Controls.Add(this.successLabel1);
            this.panel1.Controls.Add(this.errorLabel);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.quantityTbx);
            this.panel1.Controls.Add(this.prodIDTbx);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.orderBtn);
            this.panel1.Location = new System.Drawing.Point(291, 229);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 270);
            this.panel1.TabIndex = 21;
            // 
            // deliveryIDTbx
            // 
            this.deliveryIDTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveryIDTbx.Location = new System.Drawing.Point(92, 169);
            this.deliveryIDTbx.Name = "deliveryIDTbx";
            this.deliveryIDTbx.Size = new System.Drawing.Size(186, 20);
            this.deliveryIDTbx.TabIndex = 37;
            this.deliveryIDTbx.TextChanged += new System.EventHandler(this.deliveryID_TextChanged);
            // 
            // customerIDTbx
            // 
            this.customerIDTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIDTbx.Location = new System.Drawing.Point(92, 117);
            this.customerIDTbx.Name = "customerIDTbx";
            this.customerIDTbx.Size = new System.Drawing.Size(186, 20);
            this.customerIDTbx.TabIndex = 36;
            this.customerIDTbx.TextChanged += new System.EventHandler(this.customerID_TextChanged);
            // 
            // orderStatusTbx
            // 
            this.orderStatusTbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.orderStatusTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderStatusTbx.FormattingEnabled = true;
            this.orderStatusTbx.Items.AddRange(new object[] {
            "Pending",
            "Packed",
            "Shipped",
            "Delivered"});
            this.orderStatusTbx.Location = new System.Drawing.Point(92, 90);
            this.orderStatusTbx.Name = "orderStatusTbx";
            this.orderStatusTbx.Size = new System.Drawing.Size(186, 21);
            this.orderStatusTbx.TabIndex = 35;
            // 
            // successLabel1
            // 
            this.successLabel1.AutoSize = true;
            this.successLabel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.successLabel1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.successLabel1.ForeColor = System.Drawing.Color.DarkGreen;
            this.successLabel1.Location = new System.Drawing.Point(92, 199);
            this.successLabel1.MaximumSize = new System.Drawing.Size(210, 0);
            this.successLabel1.Name = "successLabel1";
            this.successLabel1.Size = new System.Drawing.Size(81, 14);
            this.successLabel1.TabIndex = 34;
            this.successLabel1.Text = "Order Placed!";
            this.successLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.successLabel1.Visible = false;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.errorLabel.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(92, 199);
            this.errorLabel.MaximumSize = new System.Drawing.Size(200, 0);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(90, 14);
            this.errorLabel.TabIndex = 32;
            this.errorLabel.Text = "Error! Try again";
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.errorLabel.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 172);
            this.label6.MaximumSize = new System.Drawing.Size(200, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 14);
            this.label6.TabIndex = 17;
            this.label6.Text = "Delivery ID";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 120);
            this.label3.MaximumSize = new System.Drawing.Size(200, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 14);
            this.label3.TabIndex = 14;
            this.label3.Text = "Customer ID";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 93);
            this.label4.MaximumSize = new System.Drawing.Size(200, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 14);
            this.label4.TabIndex = 13;
            this.label4.Text = "Order Status";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // quantityTbx
            // 
            this.quantityTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityTbx.Location = new System.Drawing.Point(92, 64);
            this.quantityTbx.Name = "quantityTbx";
            this.quantityTbx.Size = new System.Drawing.Size(186, 20);
            this.quantityTbx.TabIndex = 12;
            // 
            // prodIDTbx
            // 
            this.prodIDTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodIDTbx.Location = new System.Drawing.Point(92, 40);
            this.prodIDTbx.Name = "prodIDTbx";
            this.prodIDTbx.Size = new System.Drawing.Size(186, 20);
            this.prodIDTbx.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 67);
            this.label2.MaximumSize = new System.Drawing.Size(200, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 14);
            this.label2.TabIndex = 10;
            this.label2.Text = "Quantity";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 43);
            this.label5.MaximumSize = new System.Drawing.Size(200, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 14);
            this.label5.TabIndex = 9;
            this.label5.Text = "Product ID";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // orderBtn
            // 
            this.orderBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderBtn.Location = new System.Drawing.Point(92, 223);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(87, 32);
            this.orderBtn.TabIndex = 4;
            this.orderBtn.Text = "Place Order";
            this.orderBtn.UseVisualStyleBackColor = true;
            this.orderBtn.Click += new System.EventHandler(this.orderBtn_Click);
            // 
            // dateTbx
            // 
            this.dateTbx.Enabled = false;
            this.dateTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTbx.Location = new System.Drawing.Point(92, 14);
            this.dateTbx.Name = "dateTbx";
            this.dateTbx.ReadOnly = true;
            this.dateTbx.Size = new System.Drawing.Size(186, 20);
            this.dateTbx.TabIndex = 37;
            this.dateTbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(55, 17);
            this.label7.MaximumSize = new System.Drawing.Size(200, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 14);
            this.label7.TabIndex = 38;
            this.label7.Text = "Date";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // refreshBtn
            // 
            this.refreshBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.Location = new System.Drawing.Point(520, 38);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(74, 27);
            this.refreshBtn.TabIndex = 36;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // productData
            // 
            this.productData.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.productData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productData.Location = new System.Drawing.Point(23, 247);
            this.productData.Name = "productData";
            this.productData.RowHeadersWidth = 51;
            this.productData.Size = new System.Drawing.Size(258, 252);
            this.productData.TabIndex = 37;
            this.productData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productData_CellContentClick);
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(185, 223);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(56, 32);
            this.clearBtn.TabIndex = 39;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(116, 229);
            this.label8.MaximumSize = new System.Drawing.Size(200, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 14);
            this.label8.TabIndex = 40;
            this.label8.Text = "Product List";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // paymentTbx
            // 
            this.paymentTbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paymentTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentTbx.FormattingEnabled = true;
            this.paymentTbx.Items.AddRange(new object[] {
            "Bank Transfer",
            "GCash",
            "DragonPay"});
            this.paymentTbx.Location = new System.Drawing.Point(92, 143);
            this.paymentTbx.Name = "paymentTbx";
            this.paymentTbx.Size = new System.Drawing.Size(186, 21);
            this.paymentTbx.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(38, 146);
            this.label9.MaximumSize = new System.Drawing.Size(200, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 14);
            this.label9.TabIndex = 40;
            this.label9.Text = "Payment";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // placeOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 522);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.productData);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.orderData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "placeOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Place Order";
            this.Load += new System.EventHandler(this.placeOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView orderData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label successLabel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox quantityTbx;
        private System.Windows.Forms.TextBox prodIDTbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.ComboBox orderStatusTbx;
        private System.Windows.Forms.TextBox deliveryIDTbx;
        private System.Windows.Forms.TextBox customerIDTbx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox dateTbx;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.DataGridView productData;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox paymentTbx;
        private System.Windows.Forms.Label label9;
    }
}