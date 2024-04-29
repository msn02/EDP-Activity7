namespace Activity5
{
    partial class reportForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.reportData = new System.Windows.Forms.DataGridView();
            this.reportBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.monthLbl = new System.Windows.Forms.Label();
            this.monthBox = new System.Windows.Forms.ComboBox();
            this.quarterBox = new System.Windows.Forms.ComboBox();
            this.quarterLbl = new System.Windows.Forms.Label();
            this.exportBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addItembtn = new System.Windows.Forms.Button();
            this.cusRegisBtn = new System.Windows.Forms.Button();
            this.placeOrderBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.reportData)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportData
            // 
            this.reportData.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.reportData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportData.Location = new System.Drawing.Point(20, 119);
            this.reportData.Name = "reportData";
            this.reportData.RowHeadersWidth = 51;
            this.reportData.Size = new System.Drawing.Size(595, 300);
            this.reportData.TabIndex = 4;
            // 
            // reportBox
            // 
            this.reportBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.reportBox.Items.AddRange(new object[] {
            "Order Report",
            "Product Sales",
            "Inventory"});
            this.reportBox.Location = new System.Drawing.Point(111, 10);
            this.reportBox.Name = "reportBox";
            this.reportBox.Size = new System.Drawing.Size(156, 21);
            this.reportBox.TabIndex = 5;
            this.reportBox.SelectedIndexChanged += new System.EventHandler(this.reportBox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.monthLbl);
            this.panel1.Controls.Add(this.reportBox);
            this.panel1.Controls.Add(this.monthBox);
            this.panel1.Controls.Add(this.quarterBox);
            this.panel1.Controls.Add(this.quarterLbl);
            this.panel1.Location = new System.Drawing.Point(20, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 40);
            this.panel1.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 13);
            this.label8.MaximumSize = new System.Drawing.Size(200, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 15);
            this.label8.TabIndex = 37;
            this.label8.Text = "Select a Report";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // monthLbl
            // 
            this.monthLbl.AutoSize = true;
            this.monthLbl.Enabled = false;
            this.monthLbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthLbl.Location = new System.Drawing.Point(446, 12);
            this.monthLbl.MaximumSize = new System.Drawing.Size(200, 0);
            this.monthLbl.Name = "monthLbl";
            this.monthLbl.Size = new System.Drawing.Size(40, 15);
            this.monthLbl.TabIndex = 39;
            this.monthLbl.Text = "Month";
            this.monthLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // monthBox
            // 
            this.monthBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monthBox.Enabled = false;
            this.monthBox.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.monthBox.Location = new System.Drawing.Point(492, 10);
            this.monthBox.Name = "monthBox";
            this.monthBox.Size = new System.Drawing.Size(88, 21);
            this.monthBox.TabIndex = 38;
            this.monthBox.SelectedIndexChanged += new System.EventHandler(this.monthBox_SelectedIndexChanged);
            // 
            // quarterBox
            // 
            this.quarterBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.quarterBox.Enabled = false;
            this.quarterBox.Items.AddRange(new object[] {
            "First Quarter",
            "Second Quarter",
            "Third Quarter",
            "Fourth Quarter"});
            this.quarterBox.Location = new System.Drawing.Point(346, 10);
            this.quarterBox.Name = "quarterBox";
            this.quarterBox.Size = new System.Drawing.Size(88, 21);
            this.quarterBox.TabIndex = 5;
            this.quarterBox.SelectedIndexChanged += new System.EventHandler(this.quarterBox_SelectedIndexChanged);
            // 
            // quarterLbl
            // 
            this.quarterLbl.AutoSize = true;
            this.quarterLbl.Enabled = false;
            this.quarterLbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quarterLbl.Location = new System.Drawing.Point(292, 12);
            this.quarterLbl.MaximumSize = new System.Drawing.Size(200, 0);
            this.quarterLbl.Name = "quarterLbl";
            this.quarterLbl.Size = new System.Drawing.Size(48, 15);
            this.quarterLbl.TabIndex = 37;
            this.quarterLbl.Text = "Quarter";
            this.quarterLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // exportBtn
            // 
            this.exportBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportBtn.Location = new System.Drawing.Point(537, 425);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(78, 31);
            this.exportBtn.TabIndex = 37;
            this.exportBtn.Text = "Export";
            this.exportBtn.UseVisualStyleBackColor = true;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 22);
            this.label2.TabIndex = 40;
            this.label2.Text = "Reports";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.placeOrderBtn);
            this.panel2.Controls.Add(this.cusRegisBtn);
            this.panel2.Controls.Add(this.addItembtn);
            this.panel2.Location = new System.Drawing.Point(20, 470);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(595, 69);
            this.panel2.TabIndex = 40;
            // 
            // addItembtn
            // 
            this.addItembtn.Location = new System.Drawing.Point(121, 14);
            this.addItembtn.Name = "addItembtn";
            this.addItembtn.Size = new System.Drawing.Size(101, 43);
            this.addItembtn.TabIndex = 1;
            this.addItembtn.Text = "Add item to inventory";
            this.addItembtn.UseVisualStyleBackColor = true;
            this.addItembtn.Click += new System.EventHandler(this.addItembtn_Click);
            // 
            // cusRegisBtn
            // 
            this.cusRegisBtn.Location = new System.Drawing.Point(228, 14);
            this.cusRegisBtn.Name = "cusRegisBtn";
            this.cusRegisBtn.Size = new System.Drawing.Size(101, 43);
            this.cusRegisBtn.TabIndex = 2;
            this.cusRegisBtn.Text = "Customer Registration";
            this.cusRegisBtn.UseVisualStyleBackColor = true;
            this.cusRegisBtn.Click += new System.EventHandler(this.cusRegisBtn_Click);
            // 
            // placeOrderBtn
            // 
            this.placeOrderBtn.Location = new System.Drawing.Point(14, 14);
            this.placeOrderBtn.Name = "placeOrderBtn";
            this.placeOrderBtn.Size = new System.Drawing.Size(101, 43);
            this.placeOrderBtn.TabIndex = 3;
            this.placeOrderBtn.Text = "Place an Order";
            this.placeOrderBtn.UseVisualStyleBackColor = true;
            this.placeOrderBtn.Click += new System.EventHandler(this.placeOrderBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.Location = new System.Drawing.Point(541, 35);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(74, 27);
            this.refreshBtn.TabIndex = 36;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // reportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.exportBtn);
            this.Controls.Add(this.reportData);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Name = "reportForm";
            this.Size = new System.Drawing.Size(635, 561);
            ((System.ComponentModel.ISupportInitialize)(this.reportData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView reportData;
        private System.Windows.Forms.ComboBox reportBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button exportBtn;
        private System.Windows.Forms.ComboBox quarterBox;
        private System.Windows.Forms.Label monthLbl;
        private System.Windows.Forms.ComboBox monthBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label quarterLbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cusRegisBtn;
        private System.Windows.Forms.Button addItembtn;
        private System.Windows.Forms.Button placeOrderBtn;
        private System.Windows.Forms.Button refreshBtn;
    }
}
