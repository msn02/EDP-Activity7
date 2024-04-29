namespace Activity5
{
    partial class employeeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.emp_idtb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.successLabel2 = new System.Windows.Forms.Label();
            this.emp_status = new System.Windows.Forms.ComboBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.successLabel1 = new System.Windows.Forms.Label();
            this.emp_jobPos = new System.Windows.Forms.ComboBox();
            this.emp_ans = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.emp_sq = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.emp_password = new System.Windows.Forms.TextBox();
            this.emp_uname = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.emp_cpnum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.emp_email = new System.Windows.Forms.TextBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.emp_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.employeeData = new System.Windows.Forms.DataGridView();
            this.searchTb = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employees";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.clearBtn);
            this.panel1.Controls.Add(this.emp_idtb);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.successLabel2);
            this.panel1.Controls.Add(this.emp_status);
            this.panel1.Controls.Add(this.errorLabel);
            this.panel1.Controls.Add(this.successLabel1);
            this.panel1.Controls.Add(this.emp_jobPos);
            this.panel1.Controls.Add(this.emp_ans);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.emp_sq);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.emp_password);
            this.panel1.Controls.Add(this.emp_uname);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.emp_cpnum);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.emp_email);
            this.panel1.Controls.Add(this.updateBtn);
            this.panel1.Controls.Add(this.emp_name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.addBtn);
            this.panel1.Location = new System.Drawing.Point(20, 311);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 228);
            this.panel1.TabIndex = 2;
            // 
            // emp_idtb
            // 
            this.emp_idtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_idtb.Location = new System.Drawing.Point(92, 20);
            this.emp_idtb.Name = "emp_idtb";
            this.emp_idtb.ReadOnly = true;
            this.emp_idtb.Size = new System.Drawing.Size(186, 20);
            this.emp_idtb.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(48, 22);
            this.label8.MaximumSize = new System.Drawing.Size(200, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 14);
            this.label8.TabIndex = 35;
            this.label8.Text = "Emp ID";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // successLabel2
            // 
            this.successLabel2.AutoSize = true;
            this.successLabel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.successLabel2.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.successLabel2.ForeColor = System.Drawing.Color.DarkGreen;
            this.successLabel2.Location = new System.Drawing.Point(365, 150);
            this.successLabel2.MaximumSize = new System.Drawing.Size(210, 0);
            this.successLabel2.Name = "successLabel2";
            this.successLabel2.Size = new System.Drawing.Size(209, 14);
            this.successLabel2.TabIndex = 34;
            this.successLabel2.Text = "Employee info updated successfully!";
            this.successLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.successLabel2.Visible = false;
            // 
            // emp_status
            // 
            this.emp_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.emp_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_status.FormattingEnabled = true;
            this.emp_status.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.emp_status.Location = new System.Drawing.Point(92, 143);
            this.emp_status.Name = "emp_status";
            this.emp_status.Size = new System.Drawing.Size(186, 21);
            this.emp_status.TabIndex = 33;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.errorLabel.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(365, 150);
            this.errorLabel.MaximumSize = new System.Drawing.Size(200, 0);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(90, 14);
            this.errorLabel.TabIndex = 32;
            this.errorLabel.Text = "Error! Try again";
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.errorLabel.Visible = false;
            // 
            // successLabel1
            // 
            this.successLabel1.AutoSize = true;
            this.successLabel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.successLabel1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.successLabel1.ForeColor = System.Drawing.Color.DarkGreen;
            this.successLabel1.Location = new System.Drawing.Point(365, 150);
            this.successLabel1.MaximumSize = new System.Drawing.Size(200, 0);
            this.successLabel1.Name = "successLabel1";
            this.successLabel1.Size = new System.Drawing.Size(174, 14);
            this.successLabel1.TabIndex = 31;
            this.successLabel1.Text = "Employee added successfully!";
            this.successLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.successLabel1.Visible = false;
            // 
            // emp_jobPos
            // 
            this.emp_jobPos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.emp_jobPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_jobPos.FormattingEnabled = true;
            this.emp_jobPos.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.emp_jobPos.Location = new System.Drawing.Point(92, 117);
            this.emp_jobPos.Name = "emp_jobPos";
            this.emp_jobPos.Size = new System.Drawing.Size(186, 21);
            this.emp_jobPos.TabIndex = 30;
            // 
            // emp_ans
            // 
            this.emp_ans.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_ans.Location = new System.Drawing.Point(368, 118);
            this.emp_ans.Name = "emp_ans";
            this.emp_ans.Size = new System.Drawing.Size(186, 20);
            this.emp_ans.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(316, 118);
            this.label7.MaximumSize = new System.Drawing.Size(200, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 14);
            this.label7.TabIndex = 27;
            this.label7.Text = "Answer";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // emp_sq
            // 
            this.emp_sq.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_sq.Location = new System.Drawing.Point(368, 69);
            this.emp_sq.Multiline = true;
            this.emp_sq.Name = "emp_sq";
            this.emp_sq.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.emp_sq.Size = new System.Drawing.Size(186, 43);
            this.emp_sq.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(316, 69);
            this.label9.MaximumSize = new System.Drawing.Size(80, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 28);
            this.label9.TabIndex = 23;
            this.label9.Text = "Security Question";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // emp_password
            // 
            this.emp_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_password.Location = new System.Drawing.Point(368, 45);
            this.emp_password.Name = "emp_password";
            this.emp_password.Size = new System.Drawing.Size(186, 20);
            this.emp_password.TabIndex = 22;
            // 
            // emp_uname
            // 
            this.emp_uname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_uname.Location = new System.Drawing.Point(368, 21);
            this.emp_uname.Name = "emp_uname";
            this.emp_uname.Size = new System.Drawing.Size(186, 20);
            this.emp_uname.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(305, 47);
            this.label10.MaximumSize = new System.Drawing.Size(200, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 14);
            this.label10.TabIndex = 20;
            this.label10.Text = "Password";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(307, 23);
            this.label11.MaximumSize = new System.Drawing.Size(200, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 14);
            this.label11.TabIndex = 19;
            this.label11.Text = "Username";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 144);
            this.label6.MaximumSize = new System.Drawing.Size(200, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 14);
            this.label6.TabIndex = 17;
            this.label6.Text = "Status";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // emp_cpnum
            // 
            this.emp_cpnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_cpnum.Location = new System.Drawing.Point(92, 92);
            this.emp_cpnum.Name = "emp_cpnum";
            this.emp_cpnum.Size = new System.Drawing.Size(186, 20);
            this.emp_cpnum.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 118);
            this.label3.MaximumSize = new System.Drawing.Size(200, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 14);
            this.label3.TabIndex = 14;
            this.label3.Text = "Job Code";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 94);
            this.label4.MaximumSize = new System.Drawing.Size(200, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 14);
            this.label4.TabIndex = 13;
            this.label4.Text = "Contact Num";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // emp_email
            // 
            this.emp_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_email.Location = new System.Drawing.Point(92, 68);
            this.emp_email.Name = "emp_email";
            this.emp_email.Size = new System.Drawing.Size(186, 20);
            this.emp_email.TabIndex = 12;
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(150, 172);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(66, 32);
            this.updateBtn.TabIndex = 6;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // emp_name
            // 
            this.emp_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_name.Location = new System.Drawing.Point(92, 44);
            this.emp_name.Name = "emp_name";
            this.emp_name.Size = new System.Drawing.Size(186, 20);
            this.emp_name.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 68);
            this.label2.MaximumSize = new System.Drawing.Size(200, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 14);
            this.label2.TabIndex = 10;
            this.label2.Text = "Email";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 44);
            this.label5.MaximumSize = new System.Drawing.Size(200, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 14);
            this.label5.TabIndex = 9;
            this.label5.Text = "Full Name";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(92, 172);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(52, 32);
            this.addBtn.TabIndex = 4;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // employeeData
            // 
            this.employeeData.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.employeeData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeData.Location = new System.Drawing.Point(20, 76);
            this.employeeData.Name = "employeeData";
            this.employeeData.RowHeadersWidth = 51;
            this.employeeData.Size = new System.Drawing.Size(596, 219);
            this.employeeData.TabIndex = 3;
            this.employeeData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeData_CellContentClick);
            // 
            // searchTb
            // 
            this.searchTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTb.Location = new System.Drawing.Point(171, 46);
            this.searchTb.Name = "searchTb";
            this.searchTb.Size = new System.Drawing.Size(288, 21);
            this.searchTb.TabIndex = 12;
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(465, 44);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(71, 27);
            this.searchBtn.TabIndex = 29;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.Location = new System.Drawing.Point(542, 43);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(74, 27);
            this.refreshBtn.TabIndex = 34;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(222, 173);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(56, 32);
            this.clearBtn.TabIndex = 37;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // employeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchTb);
            this.Controls.Add(this.employeeData);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "employeeForm";
            this.Size = new System.Drawing.Size(635, 561);
            this.Load += new System.EventHandler(this.employeeForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.DataGridView employeeData;
        private System.Windows.Forms.TextBox emp_email;
        private System.Windows.Forms.TextBox emp_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox emp_cpnum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox emp_ans;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox emp_sq;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox emp_password;
        private System.Windows.Forms.TextBox emp_uname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox searchTb;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.ComboBox emp_jobPos;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label successLabel1;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.ComboBox emp_status;
        private System.Windows.Forms.Label successLabel2;
        private System.Windows.Forms.TextBox emp_idtb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button clearBtn;
    }
}
