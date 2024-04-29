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
    public partial class addItemForm : Form
    {
        Data.DBConnection conn = new Data.DBConnection();
        public addItemForm()
        {
            InitializeComponent();
            // load product data
            productDataLoad();
        }

        public void productDataLoad()
        {
            String loadQuery = $"SELECT * FROM product";
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

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            productDataLoad();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            clearTbxData();
            clearWarn();
        }

        public void clearTbxData()
        {
            // clear textboxes
            prodIDTbx.Text = "";
            itemNameTbx.Text = "";
            brandTbx.Text = "";
            colorTbx.Text = "";
            prodTypeTbx.SelectedIndex = -1;
            unitStockTbx.Text = "";
            costTbx.Text = "";
            priceTbx.Text = "";

        }

        public void clearWarn()
        {
            // clear warning messages
            errorLabel.Visible = false;
            successLabel1.Visible = false;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            clearWarn();

            // display an error if there is a textbox with no data input
            if (prodIDTbx.Text == "" || itemNameTbx.Text == "" || brandTbx.Text == "" || colorTbx.Text == "" || prodTypeTbx.Text == "" || unitStockTbx.Text == "" || costTbx.Text == "" || priceTbx.Text == "")
            {
                errorLabel.Visible = true;
            }
            else
            {
                clearWarn();

                String addQuery = "INSERT INTO product(id, product_name, brand, product_type, unit_in_stock, color, cost, price) " +
            "VALUES(@prodID, @prodName, @brand, @prodType, @unitStock, @color, @cost, @price)";

                try
                {
                    MySqlCommand cmd = new MySqlCommand(addQuery, conn.ConnOpen());
                    cmd.Parameters.AddWithValue("@prodID", prodIDTbx.Text);
                    cmd.Parameters.AddWithValue("@prodName", itemNameTbx.Text);
                    cmd.Parameters.AddWithValue("@brand", brandTbx.Text);
                    cmd.Parameters.AddWithValue("@prodType", prodTypeTbx.Text);
                    cmd.Parameters.AddWithValue("@unitStock", unitStockTbx.Text);
                    cmd.Parameters.AddWithValue("@color", colorTbx.Text);
                    cmd.Parameters.AddWithValue("@cost", costTbx.Text);
                    cmd.Parameters.AddWithValue("@price", priceTbx.Text);

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
    }
}
