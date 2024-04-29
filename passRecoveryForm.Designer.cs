namespace Activity5
{
    partial class passRecoveryForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.emailTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.verifyBtn = new System.Windows.Forms.Button();
            this.ansTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.reEnterPassTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.newPassTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.prf_backBtn = new System.Windows.Forms.Button();
            this.squestion = new System.Windows.Forms.Label();
            this.emailErrorLabel = new System.Windows.Forms.Label();
            this.confirmResetBtn = new System.Windows.Forms.Button();
            this.invalidAnsLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.sucessLabel = new System.Windows.Forms.Label();
            this.loginLink = new System.Windows.Forms.LinkLabel();
            this.showPass = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(44, 83);
            this.label4.MaximumSize = new System.Drawing.Size(250, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 42);
            this.label4.TabIndex = 6;
            this.label4.Text = "Enter the email associated to your account then click the button to generate your" +
    " security question.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Password Recovery";
            // 
            // emailTb
            // 
            this.emailTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTb.Location = new System.Drawing.Point(85, 146);
            this.emailTb.Name = "emailTb";
            this.emailTb.Size = new System.Drawing.Size(201, 22);
            this.emailTb.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 149);
            this.label2.MaximumSize = new System.Drawing.Size(200, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Email";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // verifyBtn
            // 
            this.verifyBtn.Enabled = false;
            this.verifyBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verifyBtn.Location = new System.Drawing.Point(85, 319);
            this.verifyBtn.Name = "verifyBtn";
            this.verifyBtn.Size = new System.Drawing.Size(67, 31);
            this.verifyBtn.TabIndex = 15;
            this.verifyBtn.Text = "Verify";
            this.verifyBtn.UseVisualStyleBackColor = true;
            this.verifyBtn.Click += new System.EventHandler(this.verifyBtn_Click);
            // 
            // ansTb
            // 
            this.ansTb.Enabled = false;
            this.ansTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ansTb.Location = new System.Drawing.Point(85, 292);
            this.ansTb.Name = "ansTb";
            this.ansTb.Size = new System.Drawing.Size(201, 22);
            this.ansTb.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 295);
            this.label3.MaximumSize = new System.Drawing.Size(200, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Answer";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // confirmBtn
            // 
            this.confirmBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBtn.Location = new System.Drawing.Point(85, 174);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(69, 31);
            this.confirmBtn.TabIndex = 12;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.showPass);
            this.panel1.Controls.Add(this.loginLink);
            this.panel1.Controls.Add(this.sucessLabel);
            this.panel1.Controls.Add(this.errorLabel);
            this.panel1.Controls.Add(this.confirmResetBtn);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.reEnterPassTb);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.newPassTb);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(317, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 411);
            this.panel1.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(35, 106);
            this.label8.MaximumSize = new System.Drawing.Size(250, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(203, 14);
            this.label8.TabIndex = 17;
            this.label8.Text = "Create a new password for your account";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reEnterPassTb
            // 
            this.reEnterPassTb.Enabled = false;
            this.reEnterPassTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reEnterPassTb.Location = new System.Drawing.Point(36, 242);
            this.reEnterPassTb.Name = "reEnterPassTb";
            this.reEnterPassTb.Size = new System.Drawing.Size(201, 22);
            this.reEnterPassTb.TabIndex = 21;
            this.reEnterPassTb.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 221);
            this.label7.MaximumSize = new System.Drawing.Size(200, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Re-enter new password";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // newPassTb
            // 
            this.newPassTb.Enabled = false;
            this.newPassTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPassTb.Location = new System.Drawing.Point(36, 163);
            this.newPassTb.Name = "newPassTb";
            this.newPassTb.Size = new System.Drawing.Size(201, 22);
            this.newPassTb.TabIndex = 18;
            this.newPassTb.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 29);
            this.label5.TabIndex = 17;
            this.label5.Text = "Reset Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 142);
            this.label6.MaximumSize = new System.Drawing.Size(200, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Enter new password";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // prf_backBtn
            // 
            this.prf_backBtn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prf_backBtn.Location = new System.Drawing.Point(12, 12);
            this.prf_backBtn.Name = "prf_backBtn";
            this.prf_backBtn.Size = new System.Drawing.Size(47, 25);
            this.prf_backBtn.TabIndex = 17;
            this.prf_backBtn.Text = "Back";
            this.prf_backBtn.UseVisualStyleBackColor = true;
            this.prf_backBtn.Click += new System.EventHandler(this.prf_backBtn_Click);
            // 
            // squestion
            // 
            this.squestion.AutoSize = true;
            this.squestion.BackColor = System.Drawing.SystemColors.Control;
            this.squestion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.squestion.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.squestion.Location = new System.Drawing.Point(29, 244);
            this.squestion.MaximumSize = new System.Drawing.Size(260, 0);
            this.squestion.Name = "squestion";
            this.squestion.Size = new System.Drawing.Size(228, 16);
            this.squestion.TabIndex = 18;
            this.squestion.Text = "Your security question will appear here";
            this.squestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // emailErrorLabel
            // 
            this.emailErrorLabel.AutoSize = true;
            this.emailErrorLabel.BackColor = System.Drawing.SystemColors.Control;
            this.emailErrorLabel.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailErrorLabel.ForeColor = System.Drawing.Color.Crimson;
            this.emailErrorLabel.Location = new System.Drawing.Point(82, 211);
            this.emailErrorLabel.MaximumSize = new System.Drawing.Size(200, 0);
            this.emailErrorLabel.Name = "emailErrorLabel";
            this.emailErrorLabel.Size = new System.Drawing.Size(121, 14);
            this.emailErrorLabel.TabIndex = 19;
            this.emailErrorLabel.Text = "Email does not exist!";
            this.emailErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.emailErrorLabel.Visible = false;
            // 
            // confirmResetBtn
            // 
            this.confirmResetBtn.Enabled = false;
            this.confirmResetBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmResetBtn.Location = new System.Drawing.Point(36, 283);
            this.confirmResetBtn.Name = "confirmResetBtn";
            this.confirmResetBtn.Size = new System.Drawing.Size(69, 31);
            this.confirmResetBtn.TabIndex = 20;
            this.confirmResetBtn.Text = "Confirm";
            this.confirmResetBtn.UseVisualStyleBackColor = true;
            this.confirmResetBtn.Click += new System.EventHandler(this.confirmResetBtn_Click);
            // 
            // invalidAnsLabel
            // 
            this.invalidAnsLabel.AutoSize = true;
            this.invalidAnsLabel.BackColor = System.Drawing.SystemColors.Control;
            this.invalidAnsLabel.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidAnsLabel.ForeColor = System.Drawing.Color.Crimson;
            this.invalidAnsLabel.Location = new System.Drawing.Point(82, 355);
            this.invalidAnsLabel.MaximumSize = new System.Drawing.Size(200, 0);
            this.invalidAnsLabel.Name = "invalidAnsLabel";
            this.invalidAnsLabel.Size = new System.Drawing.Size(144, 14);
            this.invalidAnsLabel.TabIndex = 20;
            this.invalidAnsLabel.Text = "Invalid answer. Try again!";
            this.invalidAnsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.invalidAnsLabel.Visible = false;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.errorLabel.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Crimson;
            this.errorLabel.Location = new System.Drawing.Point(35, 331);
            this.errorLabel.MaximumSize = new System.Drawing.Size(200, 0);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(187, 14);
            this.errorLabel.TabIndex = 21;
            this.errorLabel.Text = "Password must match! Try again";
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.errorLabel.Visible = false;
            // 
            // sucessLabel
            // 
            this.sucessLabel.AutoSize = true;
            this.sucessLabel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.sucessLabel.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sucessLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.sucessLabel.Location = new System.Drawing.Point(35, 331);
            this.sucessLabel.MaximumSize = new System.Drawing.Size(200, 0);
            this.sucessLabel.Name = "sucessLabel";
            this.sucessLabel.Size = new System.Drawing.Size(119, 14);
            this.sucessLabel.TabIndex = 22;
            this.sucessLabel.Text = "Password changed! ";
            this.sucessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sucessLabel.Visible = false;
            // 
            // loginLink
            // 
            this.loginLink.AutoSize = true;
            this.loginLink.Location = new System.Drawing.Point(152, 331);
            this.loginLink.Name = "loginLink";
            this.loginLink.Size = new System.Drawing.Size(37, 13);
            this.loginLink.TabIndex = 23;
            this.loginLink.TabStop = true;
            this.loginLink.Text = "Log In";
            this.loginLink.Visible = false;
            this.loginLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.loginLink_LinkClicked);
            // 
            // showPass
            // 
            this.showPass.AutoSize = true;
            this.showPass.Enabled = false;
            this.showPass.Location = new System.Drawing.Point(134, 191);
            this.showPass.Name = "showPass";
            this.showPass.Size = new System.Drawing.Size(102, 17);
            this.showPass.TabIndex = 24;
            this.showPass.Text = "Show Password";
            this.showPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.showPass.UseVisualStyleBackColor = true;
            this.showPass.CheckedChanged += new System.EventHandler(this.showPass_CheckedChanged);
            // 
            // passRecoveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.invalidAnsLabel);
            this.Controls.Add(this.emailErrorLabel);
            this.Controls.Add(this.squestion);
            this.Controls.Add(this.prf_backBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.verifyBtn);
            this.Controls.Add(this.ansTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.emailTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "passRecoveryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Recovery";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emailTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button verifyBtn;
        private System.Windows.Forms.TextBox ansTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox reEnterPassTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox newPassTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button prf_backBtn;
        private System.Windows.Forms.Label squestion;
        private System.Windows.Forms.Label emailErrorLabel;
        private System.Windows.Forms.Button confirmResetBtn;
        private System.Windows.Forms.Label invalidAnsLabel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label sucessLabel;
        private System.Windows.Forms.LinkLabel loginLink;
        private System.Windows.Forms.CheckBox showPass;
    }
}