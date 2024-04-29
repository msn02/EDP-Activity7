using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Activity5
{
    public partial class employeeForm : UserControl
    {
        Data.DBConnection conn = new Data.DBConnection();
        int emp_id = 0;
        public employeeForm()
        {
            InitializeComponent();
            // load the employee data
            employeeDataLoad();
        }

        private void employeeDataLoad()
        {
            String loadQuery = $"SELECT * FROM employee";
            try
            {
                MySqlCommand cmd = new MySqlCommand(loadQuery, conn.ConnOpen());
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
                dataAdapter.SelectCommand = cmd;

                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                employeeData.DataSource = dt;
            }
            catch (Exception) { }
            finally
            {
                conn.ConnClose();
            }
        }
        private void updateBtn_Click(object sender, EventArgs e)
        {
            // display an error if there is a textbox with no data input
            if (emp_name.Text == "" || emp_cpnum.Text == "" || emp_email.Text == "" || emp_jobPos.Text == "" || emp_uname.Text == "" || emp_password.Text == "" || emp_sq.Text == "" || emp_ans.Text == "" || emp_status.Text == "")
            {
                errorLabel.Visible = true;
            }

            else
            {
                String updateQuery = "UPDATE employee SET employee_name = @fullName, contact_num = @contactNum, email = @email, job_code = @jobCode, employee_username = @uname, employee_password = @pass, security_question = @secq, answer = @ans, account_status = @status WHERE id = @emp_id";

                try
                {
                    MySqlCommand cmd = new MySqlCommand(updateQuery, conn.ConnOpen());
                    cmd.Parameters.AddWithValue("@fullName", emp_name.Text);
                    cmd.Parameters.AddWithValue("@contactNum", emp_cpnum.Text);
                    cmd.Parameters.AddWithValue("@email", emp_email.Text);
                    cmd.Parameters.AddWithValue("@jobCode", emp_jobPos.Text);
                    cmd.Parameters.AddWithValue("@uname", emp_uname.Text);
                    cmd.Parameters.AddWithValue("@pass", emp_password.Text);
                    cmd.Parameters.AddWithValue("@secq", emp_sq.Text);
                    cmd.Parameters.AddWithValue("@ans", emp_ans.Text);
                    cmd.Parameters.AddWithValue("@status", emp_status.Text);
                    cmd.Parameters.AddWithValue("@emp_id", emp_idtb.Text);

                    cmd.ExecuteNonQuery();

                    // display success message
                    errorLabel.Visible = false;
                    successLabel2.Visible = true;
                    successLabel1.Visible = false;

                    clearTbxData();
                }
                catch (Exception ex)
                {
                    // Handle exceptions
                    errorLabel.Text = "Update failed: " + ex.Message;
                    errorLabel.Visible = true;
                    successLabel1.Visible = false;
                    successLabel2.Visible = false;
                }
                finally
                {
                    conn.ConnClose();
                }
            }
        }


        private void employeeForm_Load(object sender, EventArgs e)
        {

        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            employeeDataLoad();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            clearWarn();

            String addQuery = "INSERT INTO employee(employee_name, contact_num, email, job_code, employee_username, employee_password, security_question, answer, account_status) " +
            "VALUES(@fullName, @contactNum, @email, @jobCode, @uname, @pass, @secq, @ans, @status)";

            try
            {
                MySqlCommand cmd = new MySqlCommand(addQuery, conn.ConnOpen());
                cmd.Parameters.AddWithValue("@fullName", emp_name.Text);
                cmd.Parameters.AddWithValue("@contactNum", emp_cpnum.Text);
                cmd.Parameters.AddWithValue("@email", emp_email.Text);
                cmd.Parameters.AddWithValue("@jobCode", emp_jobPos.Text);
                cmd.Parameters.AddWithValue("@uname", emp_uname.Text);
                cmd.Parameters.AddWithValue("@pass", emp_password.Text);
                cmd.Parameters.AddWithValue("@secq", emp_sq.Text);
                cmd.Parameters.AddWithValue("@ans", emp_ans.Text);
                cmd.Parameters.AddWithValue("@status", emp_status.Text);

                cmd.ExecuteNonQuery();

                errorLabel.Visible = false;
                successLabel1.Visible = true;
                successLabel2.Visible = false;

                clearTbxData();
            }
            catch (Exception)
            {
                errorLabel.Visible = true;
                successLabel1.Visible = false;
                successLabel2.Visible = false;
            }
            finally
            {
                conn.ConnClose();
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            String searchInput = searchTb.Text;
            String searchQuery = $"SELECT * FROM employee WHERE employee_name LIKE @searchInput";
            try
            {
                MySqlCommand cmd = new MySqlCommand(searchQuery, conn.ConnOpen());
                cmd.Parameters.AddWithValue("@searchInput", "%" + searchInput + "%");
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
                dataAdapter.SelectCommand = cmd;

                // fill the data grid with values
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                employeeData.DataSource = dt;
            }
            catch (Exception) { }
            finally
            {
                conn.ConnClose();
            }
        }
        private void employeeData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            clearWarn();

            // check if the clicked row index is within the valid range
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.employeeData.Rows[e.RowIndex];

                // store the values into the textboxes
                emp_idtb.Text = row.Cells["id"].Value.ToString();
                emp_name.Text = row.Cells["employee_name"].Value.ToString();
                emp_cpnum.Text = row.Cells["contact_num"].Value.ToString();
                emp_email.Text = row.Cells["email"].Value.ToString();
                emp_jobPos.Text = row.Cells["job_code"].Value.ToString();
                emp_uname.Text = row.Cells["employee_username"].Value.ToString();
                emp_password.Text = row.Cells["employee_password"].Value.ToString();
                emp_sq.Text = row.Cells["security_question"].Value.ToString();
                emp_ans.Text = row.Cells["answer"].Value.ToString();
                emp_status.Text = row.Cells["account_status"].Value.ToString();
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            clearTbxData();
            clearWarn();
        }

        public void clearTbxData()
        {
            // clear textboxes
            emp_idtb.Text = "";
            emp_name.Text = "";
            emp_cpnum.Text = "";
            emp_email.Text = "";
            emp_jobPos.SelectedIndex = -1;
            emp_uname.Text = "";
            emp_password.Text = "";
            emp_sq.Text = "";
            emp_ans.Text = "";
            emp_status.SelectedIndex = -1;
        }

        public void clearWarn()
        {
            // clear warning messages
            errorLabel.Visible = false;
            successLabel1.Visible = false;
            successLabel2.Visible = false;
        }
    }
}
