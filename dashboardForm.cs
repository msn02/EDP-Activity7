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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Activity5
{
    public partial class dashboardForm : UserControl
    {
        Data.DBConnection conn = new Data.DBConnection();
        public dashboardForm()
        {
            InitializeComponent();
            dashboardData();
        }

        // encapsulated the components in a method to be able to refresh data 
        // if there is an update from the employee form
        public void dashboardData()
        {
            // employee database
            String empnumQuery = $"SELECT COUNT(*) FROM employee";
            String activeQuery = $"SELECT COUNT(*) FROM employee WHERE account_status = 'Active'";
            String inactiveQuery = $"SELECT COUNT(*) FROM employee WHERE account_status = 'Inactive'";

            // products
            String prodQuery = $"SELECT COUNT(*) FROM product";
            // orders
            String orderQuery = $"SELECT COUNT(*) FROM orders";
            // out of stock products
            String outStockQuery = $"SELECT COUNT(*) FROM product WHERE unit_in_stock = '0'";

            try
            {
                // employee count
                MySqlCommand cmd1 = new MySqlCommand(empnumQuery, conn.ConnOpen());
                int empCount = Convert.ToInt32(cmd1.ExecuteScalar());
                totalEmpLbl.Text = empCount.ToString();

                // active employees
                MySqlCommand cmd2 = new MySqlCommand(activeQuery, conn.ConnOpen());
                int activeCount = Convert.ToInt32(cmd2.ExecuteScalar());
                activeLbl.Text = activeCount.ToString();

                // inactive employees
                MySqlCommand cmd3 = new MySqlCommand(inactiveQuery, conn.ConnOpen());
                int inactiveCount = Convert.ToInt32(cmd3.ExecuteScalar());
                inactiveLbl.Text = inactiveCount.ToString();

                // products 
                MySqlCommand cmd4 = new MySqlCommand(prodQuery, conn.ConnOpen());
                int prodCount = Convert.ToInt32(cmd4.ExecuteScalar());
                totalProdLbl.Text = prodCount.ToString();

                // orders 
                MySqlCommand cmd5 = new MySqlCommand(orderQuery, conn.ConnOpen());
                int orderCount = Convert.ToInt32(cmd5.ExecuteScalar());
                totalOrdLbl.Text = orderCount.ToString();

                // products out of stock 
                MySqlCommand cmd6 = new MySqlCommand(outStockQuery, conn.ConnOpen());
                int outProdCount = Convert.ToInt32(cmd6.ExecuteScalar());
                outProdLbl.Text = outProdCount.ToString();
            }
            catch (Exception)
            {
                // wala lang
            }
        }

        private void totalProdLbl_Click(object sender, EventArgs e)
        {
            
        }

        private void totalEmpLbl_Click(object sender, EventArgs e)
        {

        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            // refresh the data in the dashboard
            dashboardData();
        }
    }
}
