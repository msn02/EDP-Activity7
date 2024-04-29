using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Activity5
{
    public partial class customerRegForm : Form
    {
        Data.DBConnection conn = new Data.DBConnection();
        public customerRegForm()
        {
            InitializeComponent();
            // load the customer data
            customerDataLoad();
        }

        public void customerDataLoad()
        {
            String loadQuery = $"SELECT * FROM customer";
            try
            {
                MySqlCommand cmd = new MySqlCommand(loadQuery, conn.ConnOpen());
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
                dataAdapter.SelectCommand = cmd;

                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                customerData.DataSource = dt;
            }
            catch (Exception) { }
            finally
            {
                conn.ConnClose();
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            customerDataLoad();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            clearWarn();
            // display an error if there is a textbox with no data input
            if (customerIDTbx.Text == "" || fullNameTbx.Text == "" || addressTbx.Text == "" || zipCodeTbx.Text == "" || contactNumTbx.Text == "" || emailTbx.Text == "")
            {
                errorLabel.Visible = true;
            } 
            else
            {
                clearWarn();

                String regQuery = "INSERT INTO customer(id, customer_name, address, zipcode, contact_num, email) " +
            "VALUES(@customerID, @customerName, @address, @zipCode, @contactNum, @email)";

                try
                {
                    MySqlCommand cmd = new MySqlCommand(regQuery, conn.ConnOpen());
                    cmd.Parameters.AddWithValue("@customerID", customerIDTbx.Text);
                    cmd.Parameters.AddWithValue("@customerName", fullNameTbx.Text);
                    cmd.Parameters.AddWithValue("@address", addressTbx.Text);
                    cmd.Parameters.AddWithValue("@zipCode", zipCodeTbx.Text);
                    cmd.Parameters.AddWithValue("@contactNum", contactNumTbx.Text);
                    cmd.Parameters.AddWithValue("@email", emailTbx.Text);

                    cmd.ExecuteNonQuery();

                    errorLabel.Visible = false;
                    successLabel1.Visible = true;

                    clearTbxData();
                }
                catch (Exception)
                {
                    errorLabel.Visible = true;
                    successLabel1.Visible = false;
                }
                finally
                {
                    conn.ConnClose();
                }
            }
        }

        public void clearTbxData()
        {
            // clear textboxes
            customerIDTbx.Text = "";
            fullNameTbx.Text = "";
            addressTbx.Text = "";
            zipCodeTbx.Text = "";
            contactNumTbx.Text = "";
            emailTbx.Text = "";
        }
        
        public void clearWarn()
        {
            // clear warning messages
            errorLabel.Visible = false;
            successLabel1.Visible = false;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            clearTbxData();
            clearWarn();
        }
    }
}
