namespace Activity5
{
    partial class customerRegForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.emailTbx = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addressTbx = new System.Windows.Forms.TextBox();
            this.contactNumTbx = new System.Windows.Forms.TextBox();
            this.zipCodeTbx = new System.Windows.Forms.TextBox();
            this.successLabel1 = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fullNameTbx = new System.Windows.Forms.TextBox();
            this.customerIDTbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.registerBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.customerData = new System.Windows.Forms.DataGridView();
            this.clearBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "Register new customers";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.clearBtn);
            this.panel1.Controls.Add(this.emailTbx);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.addressTbx);
            this.panel1.Controls.Add(this.contactNumTbx);
            this.panel1.Controls.Add(this.zipCodeTbx);
            this.panel1.Controls.Add(this.successLabel1);
            this.panel1.Controls.Add(this.errorLabel);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.fullNameTbx);
            this.panel1.Controls.Add(this.customerIDTbx);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.registerBtn);
            this.panel1.Location = new System.Drawing.Point(23, 344);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 149);
            this.panel1.TabIndex = 23;
            // 
            // emailTbx
            // 
            this.emailTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTbx.Location = new System.Drawing.Point(364, 68);
            this.emailTbx.Name = "emailTbx";
            this.emailTbx.Size = new System.Drawing.Size(186, 20);
            this.emailTbx.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(327, 71);
            this.label7.MaximumSize = new System.Drawing.Size(200, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 14);
            this.label7.TabIndex = 39;
            this.label7.Text = "Email";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // addressTbx
            // 
            this.addressTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTbx.Location = new System.Drawing.Point(92, 68);
            this.addressTbx.Name = "addressTbx";
            this.addressTbx.Size = new System.Drawing.Size(186, 20);
            this.addressTbx.TabIndex = 38;
            // 
            // contactNumTbx
            // 
            this.contactNumTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactNumTbx.Location = new System.Drawing.Point(364, 44);
            this.contactNumTbx.Name = "contactNumTbx";
            this.contactNumTbx.Size = new System.Drawing.Size(186, 20);
            this.contactNumTbx.TabIndex = 37;
            // 
            // zipCodeTbx
            // 
            this.zipCodeTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipCodeTbx.Location = new System.Drawing.Point(364, 18);
            this.zipCodeTbx.Name = "zipCodeTbx";
            this.zipCodeTbx.Size = new System.Drawing.Size(186, 20);
            this.zipCodeTbx.TabIndex = 36;
            // 
            // successLabel1
            // 
            this.successLabel1.AutoSize = true;
            this.successLabel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.successLabel1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.successLabel1.ForeColor = System.Drawing.Color.DarkGreen;
            this.successLabel1.Location = new System.Drawing.Point(361, 114);
            this.successLabel1.MaximumSize = new System.Drawing.Size(210, 0);
            this.successLabel1.Name = "successLabel1";
            this.successLabel1.Size = new System.Drawing.Size(168, 14);
            this.successLabel1.TabIndex = 34;
            this.successLabel1.Text = "Customer is now registered!";
            this.successLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.successLabel1.Visible = false;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.errorLabel.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(361, 114);
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
            this.label6.Location = new System.Drawing.Point(290, 47);
            this.label6.MaximumSize = new System.Drawing.Size(200, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 14);
            this.label6.TabIndex = 17;
            this.label6.Text = "Contact Num";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(309, 21);
            this.label3.MaximumSize = new System.Drawing.Size(200, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 14);
            this.label3.TabIndex = 14;
            this.label3.Text = "Zip Code";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 72);
            this.label4.MaximumSize = new System.Drawing.Size(200, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 14);
            this.label4.TabIndex = 13;
            this.label4.Text = "Address";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fullNameTbx
            // 
            this.fullNameTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullNameTbx.Location = new System.Drawing.Point(92, 41);
            this.fullNameTbx.Name = "fullNameTbx";
            this.fullNameTbx.Size = new System.Drawing.Size(186, 20);
            this.fullNameTbx.TabIndex = 12;
            // 
            // customerIDTbx
            // 
            this.customerIDTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIDTbx.Location = new System.Drawing.Point(92, 17);
            this.customerIDTbx.Name = "customerIDTbx";
            this.customerIDTbx.Size = new System.Drawing.Size(186, 20);
            this.customerIDTbx.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 44);
            this.label2.MaximumSize = new System.Drawing.Size(200, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 14);
            this.label2.TabIndex = 10;
            this.label2.Text = "Full Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 20);
            this.label5.MaximumSize = new System.Drawing.Size(200, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 14);
            this.label5.TabIndex = 9;
            this.label5.Text = "Customer ID";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // registerBtn
            // 
            this.registerBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBtn.Location = new System.Drawing.Point(92, 104);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(73, 32);
            this.registerBtn.TabIndex = 4;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
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
            // customerData
            // 
            this.customerData.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.customerData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerData.Location = new System.Drawing.Point(23, 71);
            this.customerData.Name = "customerData";
            this.customerData.RowHeadersWidth = 51;
            this.customerData.Size = new System.Drawing.Size(571, 255);
            this.customerData.TabIndex = 37;
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(171, 104);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(62, 32);
            this.clearBtn.TabIndex = 41;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // customerRegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 522);
            this.Controls.Add(this.customerData);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "customerRegForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Registration";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox contactNumTbx;
        private System.Windows.Forms.TextBox zipCodeTbx;
        private System.Windows.Forms.Label successLabel1;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fullNameTbx;
        private System.Windows.Forms.TextBox customerIDTbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.TextBox addressTbx;
        private System.Windows.Forms.TextBox emailTbx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.DataGridView customerData;
        private System.Windows.Forms.Button clearBtn;
    }
}