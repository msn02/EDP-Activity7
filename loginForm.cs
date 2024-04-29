using Activity5.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity5
{
    public partial class loginForm : Form
    {
        Data.DBConnection conn = new Data.DBConnection();
        public loginForm()
        {
            InitializeComponent();
            InitializeImage();
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            // if show password check box is checked, reveal the password, else hide
            if (showPass.Checked)
            {
                passTb.UseSystemPasswordChar = false;
            } 
            else
            {
                passTb.UseSystemPasswordChar = true;
            }

        }

        private void lf_loginBtn_Click(object sender, EventArgs e)
        {
            String username = unameTb.Text;
            String password = passTb.Text;

            try
            {
                // query to check if there is an existing account
                string query = $"SELECT COUNT(*) FROM employee WHERE employee_username = '{username}' AND employee_password = '{password}'";

                // ensure the connection is open
                MySqlCommand cmd = new MySqlCommand(query, conn.ConnOpen());
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                {
                    // open the next window form (dashboard/landing form)
                    landingForm landingForm1 = new landingForm();
                    landingForm1.Show();
                    this.Hide();
                }
                else
                {
                    // Show an error message
                    invalidLabel.Visible = true;
                }
                errorLabel.Visible = false;
            } 
            catch (Exception)
            {
                // display an error message upon error encounter
                invalidLabel.Visible = false;
                errorLabel.Visible = true;
            }
            finally
            {
                conn.ConnClose();
            }
        }

        private void lf_passTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void lf_unameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }

        private void forgotPassLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            passRecoveryForm passForm = new passRecoveryForm();
            passForm.Show();
            this.Hide();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void InitializeImage()
        {
            PictureBox pictureBox = new PictureBox();
            // set size and location
            pictureBox.Location = new Point(0, 0);
            pictureBox.Size = new Size(170, 150);
            // add the image
            pictureBox.Image = Image.FromFile(@"C:\Users\Lenovo\Pictures\Camera Roll\act6Logo.png");
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            SetPictureBoxPadding(pictureBox, 7, 7, 10, 10);

            // add the pictureBox control to panel
            panel2.Controls.Add(pictureBox);
            pictureBox.BringToFront();
        }

        private void SetPictureBoxPadding(PictureBox pictureBox, int left, int top, int right, int bottom)
        {
            // adjust location and size of the PictureBox to account for padding
            pictureBox.Location = new Point(pictureBox.Location.X + left, pictureBox.Location.Y + top);
            pictureBox.Size = new Size(pictureBox.Size.Width - left - right, pictureBox.Size.Height - top - bottom);
        }
    }
}
