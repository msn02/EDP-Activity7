using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Activity5
{
    public partial class passRecoveryForm : Form
    {
        Data.DBConnection conn = new Data.DBConnection();
        String email = null;
        public passRecoveryForm()
        {
            InitializeComponent();
        }

        private void prf_backBtn_Click(object sender, EventArgs e)
        {
            // go back to the log in form
            loginForm loginForm1 = new loginForm();
            loginForm1.Show();
            this.Hide();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            // store the email
            email = emailTb.Text;

            try
            {
                // query to check if there is an existing account
                String query = $"SELECT COUNT(*) FROM employee WHERE email = '{email}'";

                // ensure the connection is open
                MySqlCommand cmd = new MySqlCommand(query, conn.ConnOpen());
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                {
                    emailErrorLabel.Visible = false;

                    // show the security question
                    String ques_query = $"SELECT security_question FROM employee WHERE email = '{email}'";
                    MySqlCommand cmd1 = new MySqlCommand(ques_query, conn.ConnOpen());
                    
                    // store the data from the db into the variable
                    String question = cmd1.ExecuteScalar()?.ToString();
                    // display the question
                    squestion.Text = question;

                    // enable the textbox and button
                    ansTb.Enabled = true;
                    verifyBtn.Enabled = true;
                    // disable email textbox and confirm button
                    emailTb.Enabled = false;
                    confirmBtn.Enabled = false;
                }
                else
                {
                    // Show an error message
                    emailErrorLabel.Visible = true;
                }
            }
            catch (Exception)
            {
                // wala lang
            }
            finally
            {
                conn.ConnClose();
            }

        }

        private void verifyBtn_Click(object sender, EventArgs e)
        {
            // store user input
            String answer = ansTb.Text;
            invalidAnsLabel.Visible = false;

            try
            {
                String ansQuery = $"SELECT answer FROM employee WHERE email = '{email}'";
                MySqlCommand cmd2 = new MySqlCommand(ansQuery, conn.ConnOpen());
                String storedAns = cmd2.ExecuteScalar()?.ToString();

                if (string.Equals(answer, storedAns, StringComparison.OrdinalIgnoreCase))
                {
                    // enable the textboxes and button
                    newPassTb.Enabled = true;
                    reEnterPassTb.Enabled = true;
                    showPass.Enabled = true;
                    confirmResetBtn.Enabled = true;

                    // disable answer textbox and verify button
                    ansTb.Enabled = false;
                    verifyBtn.Enabled = false;
                }
                else
                {
                    // display error message
                    invalidAnsLabel.Visible = true;
                }
            }
            catch (Exception){}
            finally
            {
                conn.ConnClose();
            }
        }

        private void confirmResetBtn_Click(object sender, EventArgs e)
        {
            // store user input
            String newPass = newPassTb.Text;
            String rePass = reEnterPassTb.Text;
            errorLabel.Visible = false;

            // check the password if it has the same value
            if (string.Equals(newPass, rePass))
            {
                try
                {
                    // update the password in the database
                    String updatePass = $"UPDATE employee SET employee_password = '{newPass}' WHERE email = '{email}'";
                    using (conn.ConnOpen())
                    {
                        using (var command = new MySqlCommand(updatePass, conn.ConnOpen()))
                        {
                            int rowsAffected = command.ExecuteNonQuery();
                            // Check rowsAffected to verify if the update was successful

                            if (rowsAffected > 0)
                            {
                                // display success message and login link
                                sucessLabel.Visible = true;
                                loginLink.Visible = true;

                                // disable the remaining textbox and the confirm reset button
                                newPassTb.Enabled = false;
                                reEnterPassTb.Enabled = false;
                                showPass.Enabled = false;
                                confirmResetBtn.Enabled = false;
                            }
                        }
                    }
                }
                catch (Exception){}
                finally
                {
                    conn.ConnClose();
                }
            }
            else
            {
                // warning message if the password does not match
                errorLabel.Visible = true;
            }

        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            // password visibility toggle
            if (showPass.Checked)
            {
                newPassTb.UseSystemPasswordChar = false;
            }
            else
            {
                newPassTb.UseSystemPasswordChar = true;
            }
        }

        private void loginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // go back to the log in form
            loginForm loginForm1 = new loginForm();
            loginForm1.Show();
            this.Hide();
        }
    }
}