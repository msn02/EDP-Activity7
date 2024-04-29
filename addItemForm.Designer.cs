namespace Activity5
{
    partial class addItemForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.productData = new System.Windows.Forms.DataGridView();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clearBtn = new System.Windows.Forms.Button();
            this.prodTypeTbx = new System.Windows.Forms.ComboBox();
            this.priceTbx = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.colorTbx = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.costTbx = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.brandTbx = new System.Windows.Forms.TextBox();
            this.unitStockTbx = new System.Windows.Forms.TextBox();
            this.successLabel1 = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.itemNameTbx = new System.Windows.Forms.TextBox();
            this.prodIDTbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productData)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "Add a New Product";
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(23, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(47, 25);
            this.backBtn.TabIndex = 20;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // productData
            // 
            this.productData.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.productData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productData.Location = new System.Drawing.Point(23, 71);
            this.productData.Name = "productData";
            this.productData.RowHeadersWidth = 51;
            this.productData.Size = new System.Drawing.Size(571, 235);
            this.productData.TabIndex = 22;
            // 
            // refreshBtn
            // 
            this.refreshBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.Location = new System.Drawing.Point(520, 38);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(74, 27);
            this.refreshBtn.TabIndex = 35;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.clearBtn);
            this.panel1.Controls.Add(this.prodTypeTbx);
            this.panel1.Controls.Add(this.priceTbx);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.colorTbx);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.costTbx);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.brandTbx);
            this.panel1.Controls.Add(this.unitStockTbx);
            this.panel1.Controls.Add(this.successLabel1);
            this.panel1.Controls.Add(this.errorLabel);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.itemNameTbx);
            this.panel1.Controls.Add(this.prodIDTbx);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.addBtn);
            this.panel1.Location = new System.Drawing.Point(23, 324);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 169);
            this.panel1.TabIndex = 36;
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(187, 125);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(55, 32);
            this.clearBtn.TabIndex = 45;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // prodTypeTbx
            // 
            this.prodTypeTbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.prodTypeTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodTypeTbx.FormattingEnabled = true;
            this.prodTypeTbx.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.prodTypeTbx.Location = new System.Drawing.Point(364, 18);
            this.prodTypeTbx.Name = "prodTypeTbx";
            this.prodTypeTbx.Size = new System.Drawing.Size(186, 21);
            this.prodTypeTbx.TabIndex = 37;
            // 
            // priceTbx
            // 
            this.priceTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTbx.Location = new System.Drawing.Point(364, 94);
            this.priceTbx.Name = "priceTbx";
            this.priceTbx.Size = new System.Drawing.Size(186, 20);
            this.priceTbx.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(327, 97);
            this.label8.MaximumSize = new System.Drawing.Size(200, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 14);
            this.label8.TabIndex = 43;
            this.label8.Text = "Price";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // colorTbx
            // 
            this.colorTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorTbx.Location = new System.Drawing.Point(92, 94);
            this.colorTbx.Name = "colorTbx";
            this.colorTbx.Size = new System.Drawing.Size(186, 20);
            this.colorTbx.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(54, 97);
            this.label9.MaximumSize = new System.Drawing.Size(200, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 14);
            this.label9.TabIndex = 41;
            this.label9.Text = "Color";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // costTbx
            // 
            this.costTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costTbx.Location = new System.Drawing.Point(364, 68);
            this.costTbx.Name = "costTbx";
            this.costTbx.Size = new System.Drawing.Size(186, 20);
            this.costTbx.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(329, 71);
            this.label7.MaximumSize = new System.Drawing.Size(200, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 14);
            this.label7.TabIndex = 39;
            this.label7.Text = "Cost";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // brandTbx
            // 
            this.brandTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandTbx.Location = new System.Drawing.Point(92, 68);
            this.brandTbx.Name = "brandTbx";
            this.brandTbx.Size = new System.Drawing.Size(186, 20);
            this.brandTbx.TabIndex = 38;
            // 
            // unitStockTbx
            // 
            this.unitStockTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitStockTbx.Location = new System.Drawing.Point(364, 44);
            this.unitStockTbx.Name = "unitStockTbx";
            this.unitStockTbx.Size = new System.Drawing.Size(186, 20);
            this.unitStockTbx.TabIndex = 37;
            // 
            // successLabel1
            // 
            this.successLabel1.AutoSize = true;
            this.successLabel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.successLabel1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.successLabel1.ForeColor = System.Drawing.Color.DarkGreen;
            this.successLabel1.Location = new System.Drawing.Point(361, 135);
            this.successLabel1.MaximumSize = new System.Drawing.Size(210, 0);
            this.successLabel1.Name = "successLabel1";
            this.successLabel1.Size = new System.Drawing.Size(90, 14);
            this.successLabel1.TabIndex = 34;
            this.successLabel1.Text = "Product added!";
            this.successLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.successLabel1.Visible = false;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.errorLabel.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(361, 135);
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
            this.label6.Location = new System.Drawing.Point(292, 47);
            this.label6.MaximumSize = new System.Drawing.Size(200, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 14);
            this.label6.TabIndex = 17;
            this.label6.Text = "Unit in Stock";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(329, 21);
            this.label3.MaximumSize = new System.Drawing.Size(200, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 14);
            this.label3.TabIndex = 14;
            this.label3.Text = "Type";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 71);
            this.label4.MaximumSize = new System.Drawing.Size(200, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 14);
            this.label4.TabIndex = 13;
            this.label4.Text = "Brand";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // itemNameTbx
            // 
            this.itemNameTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNameTbx.Location = new System.Drawing.Point(92, 41);
            this.itemNameTbx.Name = "itemNameTbx";
            this.itemNameTbx.Size = new System.Drawing.Size(186, 20);
            this.itemNameTbx.TabIndex = 12;
            // 
            // prodIDTbx
            // 
            this.prodIDTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodIDTbx.Location = new System.Drawing.Point(92, 17);
            this.prodIDTbx.Name = "prodIDTbx";
            this.prodIDTbx.Size = new System.Drawing.Size(186, 20);
            this.prodIDTbx.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 44);
            this.label2.MaximumSize = new System.Drawing.Size(200, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 14);
            this.label2.TabIndex = 10;
            this.label2.Text = "Item name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 20);
            this.label5.MaximumSize = new System.Drawing.Size(200, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 14);
            this.label5.TabIndex = 9;
            this.label5.Text = "Product ID";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(92, 125);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(89, 32);
            this.addBtn.TabIndex = 4;
            this.addBtn.Text = "Add Product";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // addItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 522);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.productData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "addItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add new product";
            ((System.ComponentModel.ISupportInitialize)(this.productData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.DataGridView productData;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox costTbx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox brandTbx;
        private System.Windows.Forms.TextBox unitStockTbx;
        private System.Windows.Forms.Label successLabel1;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox itemNameTbx;
        private System.Windows.Forms.TextBox prodIDTbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox priceTbx;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox colorTbx;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox prodTypeTbx;
        private System.Windows.Forms.Button clearBtn;
    }
}