using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace Activity5
{
    public partial class placeOrderForm : Form
    {
        Data.DBConnection conn = new Data.DBConnection();
        String date = "";

        public placeOrderForm()
        {
            InitializeComponent();
            orderDataLoad();
            dateTbx.Text = getCurrentDate();
            productDataLoad();
        }

        public void orderDataLoad()
        {
            String loadQuery = $"SELECT * FROM orders";
            try
            {
                MySqlCommand cmd = new MySqlCommand(loadQuery, conn.ConnOpen());
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
                dataAdapter.SelectCommand = cmd;

                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                orderData.DataSource = dt;
            }
            catch (Exception) { }
            finally
            {
                conn.ConnClose();
            }
        }

        public void productDataLoad()
        {
            String loadQuery = $"SELECT id, product_name, unit_in_stock, color, price FROM product";
            try
            {
                MySqlCommand cmd = new MySqlCommand(loadQuery, conn.ConnOpen());
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
                dataAdapter.SelectCommand = cmd;

                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                productData.DataSource = dt;
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

        private void deliveryID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void customerID_TextChanged(object sender, EventArgs e)
        {

        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            orderDataLoad();
            productDataLoad();
        }

        // get current date
        public static String getCurrentDate()
        {
            DateTime currentDateTime = DateTime.Now;
            String formattedDate = currentDateTime.ToString("MMMM dd, yyyy");

            return formattedDate;
        }

        public static DateTime currentDate()
        {
            DateTime currentDateTime = DateTime.Now;
            DateTime currentFormatted = currentDateTime.Date;
            return currentFormatted;
        }

        private void placeOrderForm_Load(object sender, EventArgs e)
        {

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            clearTbxData();
            clearWarn();
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            clearWarn();
            // display an error if there is a textbox with no data input
            if (prodIDTbx.Text == "" || quantityTbx.Text == "" || orderStatusTbx.Text == "" || customerIDTbx.Text == "" || paymentTbx.Text == "" || deliveryIDTbx.Text == "")
            {
                errorLabel.Visible = true;
            }
            else
            {
                clearWarn();
                DateTime dateNow = currentDate();

                String orderQuery = "INSERT INTO orders(order_date, product_id, quantity, order_status, customer_id, payment_method, delivery_id) " +
            "VALUES(@orderDate, @productID, @quantity, @orderStatus, @customerID, @paymentMethod, @deliveryID)";

                try
                {
                    MySqlCommand cmd = new MySqlCommand(orderQuery, conn.ConnOpen());
                    cmd.Parameters.AddWithValue("@orderDate", dateNow);
                    cmd.Parameters.AddWithValue("@productID", prodIDTbx.Text);
                    cmd.Parameters.AddWithValue("@quantity", quantityTbx.Text);
                    cmd.Parameters.AddWithValue("@orderStatus", orderStatusTbx.Text);
                    cmd.Parameters.AddWithValue("@customerID", customerIDTbx.Text);
                    cmd.Parameters.AddWithValue("@paymentMethod", paymentTbx.Text);
                    cmd.Parameters.AddWithValue("@deliveryID", deliveryIDTbx.Text);

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
            prodIDTbx.Text = "";
            quantityTbx.Text = "";
            orderStatusTbx.SelectedIndex = -1;
            customerIDTbx.Text = "";
            paymentTbx.SelectedIndex = -1;
            deliveryIDTbx.Text = "";
        }

        public void clearWarn()
        {
            // clear warning messages
            errorLabel.Visible = false;
            successLabel1.Visible = false;
        }

        private void productData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            clearWarn();

            // check if the clicked row index is within the valid range
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.productData.Rows[e.RowIndex];

                // store the values into the textboxes
                prodIDTbx.Text = row.Cells["id"].Value.ToString();
            }
        }
    }
}
