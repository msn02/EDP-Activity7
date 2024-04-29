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
using MySql.Data.MySqlClient;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;

namespace Activity5
{
    public partial class reportForm : UserControl
    {
        Data.DBConnection conn = new Data.DBConnection();
        String month = "";
        String quarter = "";
        String loadQuery = "";
        String selectedReport = "";
        String reportName = "";
        int index = 0;
        
        public reportForm()
        {
            InitializeComponent();
        }

        // show the selected report
        private void reportBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedReport = reportBox.SelectedItem?.ToString();

            if (selectedReport == "Order Report")
            {
                // MONTHLY
                quarterLbl.Enabled = false;
                quarterBox.Enabled = false;
                quarterBox.SelectedIndex = -1;
                monthLbl.Enabled = true;
                monthBox.Enabled = true;
                orderDataLoad();
            }
            else if (selectedReport == "Product Sales")
            {
                // QUARTERLY    
                quarterLbl.Enabled = true;
                quarterBox.Enabled = true;
                monthLbl.Enabled = false;
                monthBox.Enabled = false;
                monthBox.SelectedIndex = -1;
                productDataLoad();
            }
            else if (selectedReport == "Inventory")
            {
                // CURRENT
                quarterLbl.Enabled = false;
                quarterBox.Enabled = false;
                quarterBox.SelectedIndex = -1;
                monthLbl.Enabled = false;
                monthBox.Enabled = false;
                monthBox.SelectedIndex = -1;
                inventoryDataLoad();
            }
        }

        // methods to load different data
        // view  the order data status (available QUARTERLY and MONTHLY)
        public void orderDataLoad()
        {
            loadQuery = $"SELECT o.id AS order_id, o.order_date, p.product_name, o.quantity, o.price, c.customer_name FROM orders o JOIN customer c ON o.customer_id = c.id JOIN product p ON o.product_id = p.id WHERE DATE_FORMAT(order_date, '%Y-%m') = '" + month +"'";
            try
            {
                MySqlCommand cmd = new MySqlCommand(loadQuery, conn.ConnOpen());
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
                dataAdapter.SelectCommand = cmd;

                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                reportData.DataSource = dt;
            }
            catch (Exception) { }
            finally
            {
                conn.ConnClose();
            }
        }

        // view the products purchased during a specific MONTH 
        public void productDataLoad()
        {
            loadQuery = $"SELECT p.product_name AS product, p.cost AS cost_per_item, p.price AS price_per_item, COUNT(o.product_id) AS total_orders, SUM(o.quantity) AS total_quantity, p.price * SUM(o.quantity) AS total_price FROM orders o JOIN product p ON o.product_id = p.id WHERE MONTH(order_date) BETWEEN " + quarter +" GROUP BY o.product_id, p.product_name ORDER BY total_quantity DESC;";
            try
            {
                MySqlCommand cmd = new MySqlCommand(loadQuery, conn.ConnOpen());
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
                dataAdapter.SelectCommand = cmd;

                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                reportData.DataSource = dt;
            }
            catch (Exception) { }
            finally
            {
                conn.ConnClose();
            }
        }

        // view the inventory status
        public void inventoryDataLoad()
        {
            // load the current inventory count 
            loadQuery = $"SELECT p.id, p.product_name, p.brand, p.color, t.prod_type AS product_type, p.unit_in_stock, p.cost FROM product p JOIN product_type t ON p.product_type = t.type_id ORDER BY p.unit_in_stock DESC;";
            try
            {
                MySqlCommand cmd = new MySqlCommand(loadQuery, conn.ConnOpen());
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd);
                dataAdapter.SelectCommand = cmd;

                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                reportData.DataSource = dt;
            }
            catch (Exception) { }
            finally
            {
                conn.ConnClose();
            }
        }

        private void monthBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // select the month
            index = monthBox.SelectedIndex + 1;
            month = "2024-0" + index;

            selectedReport = reportBox.SelectedItem?.ToString();

            if (selectedReport == "Order Report")
            {
                orderDataLoad();
            } 
        }

        private void quarterBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // select the quarter
            index = quarterBox.SelectedIndex + 1;
            int index2 = index * 3;

            String d2 = index2.ToString();
            String d1 = (index2 - 2).ToString();

            // set the complete quarter
            quarter = d1+" AND "+d2;

            selectedReport = reportBox.SelectedItem?.ToString();

            if (selectedReport == "Product Sales")
            {
                productDataLoad();
            }
        }

        // export the data into excel with specified names
        private void exportBtn_Click(object sender, EventArgs e)
        {
            selectedReport = reportBox.SelectedItem?.ToString();
            month = monthBox.SelectedItem?.ToString();
            
            if (selectedReport == "Order Report")
            {
                reportName = "Order_Report("+month+"_2024)";
                orderDataToExcel(reportData);
            }
            else if (selectedReport == "Product Sales")
            {
                reportName = "Product_Status(Quarter_"+index+"_2024)";
                productDataToExcel(reportData);
            }
            else if (selectedReport == "Inventory")
            {
                reportName = "Inventory_Report(2024)";
                inventoryDataToExcel(reportData);
            }
        }

        // get the current date and time
        public static String getCurrentDateTime()
        {
            DateTime currentDateTime = DateTime.Now;
            String formattedDateTime = currentDateTime.ToString("MMMM dd, yyyy h:mm:ss tt");

            return formattedDateTime;
        }

        // get current time
        public static String getCurrentDate()
        {
            DateTime currentDateTime = DateTime.Now;
            String formattedDate = currentDateTime.ToString("MMMM dd, yyyy");

            return formattedDate;
        }

        // ORDER SALE STATUS
        public void orderDataToExcel(DataGridView dataGridView)
        {
            try
            {
                // load the Excel template
                String templateFilePath = "C:\\Users\\Lenovo\\Documents\\Misty\\BSIT 3A - Second Sem\\EDP\\Activity6\\reports\\OrderTemp.xlsx";
                Excel.Application excelApp = new Excel.Application();
                excelApp.Visible = false;
                Excel.Workbook templateWorkbook = excelApp.Workbooks.Open(templateFilePath);
                Excel.Worksheet templateWorksheet = (Excel.Worksheet)templateWorkbook.Sheets[1];

                // create a new workbook
                Excel.Workbook newWorkbook = excelApp.Workbooks.Add();
                Excel.Worksheet newWorksheet = (Excel.Worksheet)newWorkbook.Sheets[1];

                // copy the template worksheet into the new workbook
                templateWorksheet.Copy(After: newWorksheet);

                // get the copied worksheet
                Excel.Worksheet copiedWorksheet = (Excel.Worksheet)newWorkbook.Sheets[2];

                // rename the copied worksheet
                copiedWorksheet.Name = "Report";

                // define starting row and column indices for the copied worksheet
                int startRow = 10;
                int startColumn = 1;

                // define column mappings (DataGridView column index to Excel column index)
                // DGV col index to EXC col index
                Dictionary<int, int> columnMappings = new Dictionary<int, int>
                {
                    { 0, startColumn },
                    { 1, startColumn + 1 },
                    { 2, startColumn + 2 },
                    { 3, startColumn + 3 },
                    { 4, startColumn + 4 },
                    { 5, startColumn + 5 }
                };

                // populate the copied worksheet with the data from the DataGridView
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                    {
                        // check if the DataGridView column index has a corresponding mapping
                        if (columnMappings.ContainsKey(j))
                        {
                            // get the corresponding Excel column index based on the mapping
                            int excelColumnIndex = columnMappings[j];

                            // Check if the cell value is a DateTime and format it to remove the time portion
                            if (dataGridView.Rows[i].Cells[j].Value is DateTime)
                            {
                                copiedWorksheet.Cells[startRow + i, excelColumnIndex] = ((DateTime)dataGridView.Rows[i].Cells[j].Value).ToString("MMMM dd, yyyy");
                            }
                            else
                            {
                                // write the cell value to the specified Excel cell in the copied worksheet
                                copiedWorksheet.Cells[startRow + i, excelColumnIndex] = dataGridView.Rows[i].Cells[j].Value?.ToString();
                            }
                        }
                    }
                }

                // create a new worksheet for the chart
                Excel.Worksheet chartWorksheet = (Excel.Worksheet)newWorkbook.Worksheets.Add();
                chartWorksheet.Name = "Chart";

                // Define the ranges for columns A, D, and E
                Excel.Range rangeB = copiedWorksheet.Range["B10", "B" + (startRow + dataGridView.Rows.Count - 1)];
                Excel.Range rangeE = copiedWorksheet.Range["E10", "E" + (startRow + dataGridView.Rows.Count - 1)];

                // Merge the ranges
                Excel.Range chartRange = copiedWorksheet.Application.Union(rangeB, rangeE);

                // create a chart object
                Excel.ChartObjects chartObjects = (Excel.ChartObjects)chartWorksheet.ChartObjects();
                Excel.ChartObject chartObject = chartObjects.Add(100, 100, 450, 300);
                Excel.Chart chart = chartObject.Chart;

                // configure the chart
                chart.SetSourceData(chartRange);
                chart.ChartType = Excel.XlChartType.xlColumnStacked;

                // position the chart in the "Chart" worksheet
                chartObject.Left = 25;
                chartObject.Top = 25;

                // add labels
                Excel.Axis xAxis = (Excel.Axis)chart.Axes(Excel.XlAxisType.xlCategory, Excel.XlAxisGroup.xlPrimary);
                xAxis.HasTitle = true;
                xAxis.AxisTitle.Text = "Date";

                // get the quarter
                String mon = monthBox.SelectedItem?.ToString();

                // chart title
                chart.HasTitle = true;
                chart.ChartTitle.Text = "Order Sales Status as of " + mon + " 2024";

                // change chart labels
                chart.SeriesCollection(1).Name = "Revenue";

                // get the current date and time
                String currentDate = getCurrentDateTime();
                // row/column
                copiedWorksheet.Cells[1, 1] = "Last Updated " + currentDate;
                copiedWorksheet.Cells[6, 1] = "As of "+mon+" 2024";

                // delete the hidden "Sheet1" from the new workbook
                newWorkbook.Sheets["Sheet1"].Delete();

                // save the copy with a new name (no path, copy is saved in Documents folder)
                string newFilePath = "C:\\Users\\Lenovo\\Documents\\Misty\\BSIT 3A - Second Sem\\EDP\\Activity6\\reports\\" + reportName + ".xlsx";
                newWorkbook.SaveAs(newFilePath);

                // close and quit Excel
                templateWorkbook.Close(false);
                newWorkbook.Close(false);
                excelApp.Quit();

                // release COM objects
                System.Runtime.InteropServices.Marshal.ReleaseComObject(templateWorksheet);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(templateWorkbook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(newWorksheet);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(copiedWorksheet); // Release the copied worksheet as well
                System.Runtime.InteropServices.Marshal.ReleaseComObject(newWorkbook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);

                // display success message
                MessageBox.Show("Exported successfully!\n\nFile saved to:\n" + newFilePath, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while exporting the file:\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // PRODUCT SALES REPORT
        public void productDataToExcel(DataGridView dataGridView)
        {
            try
            {
                // load the Excel template
                String templateFilePath = "C:\\Users\\Lenovo\\Documents\\Misty\\BSIT 3A - Second Sem\\EDP\\Activity6\\reports\\ProductTemp.xlsx";
                Excel.Application excelApp = new Excel.Application();
                excelApp.Visible = false;
                Excel.Workbook templateWorkbook = excelApp.Workbooks.Open(templateFilePath);
                Excel.Worksheet templateWorksheet = (Excel.Worksheet)templateWorkbook.Sheets[1];

                // create a new workbook
                Excel.Workbook newWorkbook = excelApp.Workbooks.Add();
                Excel.Worksheet newWorksheet = (Excel.Worksheet)newWorkbook.Sheets[1];

                // copy the template worksheet into the new workbook
                templateWorksheet.Copy(After: newWorksheet);

                // get the copied worksheet
                Excel.Worksheet copiedWorksheet = (Excel.Worksheet)newWorkbook.Sheets[2];

                // rename the copied worksheet
                copiedWorksheet.Name = "Report";

                // define starting row and column indices for the copied worksheet
                int startRow = 10;
                int startColumn = 1;

                // define column mappings (DataGridView column index to Excel column index)
                // DGV col index to EXC col index
                Dictionary<int, int> columnMappings = new Dictionary<int, int>
                {
                    { 0, startColumn },     
                    { 1, startColumn + 1 },  
                    { 2, startColumn + 2 },
                    { 3, startColumn + 3 },
                    { 4, startColumn + 4 },
                    { 5, startColumn + 5 }
                };

                // populate the copied worksheet with the data from the DataGridView
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                    {
                        // check if the DataGridView column index has a corresponding mapping
                        if (columnMappings.ContainsKey(j))
                        {
                            // get the corresponding Excel column index based on the mapping
                            int excelColumnIndex = columnMappings[j];

                            // write the cell value to the specified Excel cell in the copied worksheet
                            copiedWorksheet.Cells[startRow + i, excelColumnIndex] = dataGridView.Rows[i].Cells[j].Value?.ToString();
                        }
                    }
                }

                // create a new worksheet for the chart
                Excel.Worksheet chartWorksheet = (Excel.Worksheet)newWorkbook.Worksheets.Add();
                chartWorksheet.Name = "Chart";

                // Define the ranges for columns A, D, and E
                Excel.Range rangeA = copiedWorksheet.Range["A10", "A" + (startRow + dataGridView.Rows.Count - 1)];
                Excel.Range rangeD = copiedWorksheet.Range["D10", "D" + (startRow + dataGridView.Rows.Count - 1)];
                Excel.Range rangeE = copiedWorksheet.Range["E10", "E" + (startRow + dataGridView.Rows.Count - 1)];

                // Merge the ranges
                Excel.Range chartRange = copiedWorksheet.Application.Union(rangeA, rangeD, rangeE);

                // create a chart object
                Excel.ChartObjects chartObjects = (Excel.ChartObjects)chartWorksheet.ChartObjects();
                Excel.ChartObject chartObject = chartObjects.Add(100, 100, 450, 300);
                Excel.Chart chart = chartObject.Chart;

                // configure the chart
                chart.SetSourceData(chartRange);
                chart.ChartType = Excel.XlChartType.xlBarStacked;

                // position the chart in the "Chart" worksheet
                chartObject.Left = 25;
                chartObject.Top = 25;

                // add labels
                Excel.Axis xAxis = (Excel.Axis)chart.Axes(Excel.XlAxisType.xlCategory, Excel.XlAxisGroup.xlPrimary);
                xAxis.HasTitle = true;
                xAxis.AxisTitle.Text = "Products";

                Excel.Axis yAxis = (Excel.Axis)chart.Axes(Excel.XlAxisType.xlValue, Excel.XlAxisGroup.xlPrimary);
                yAxis.HasTitle = true;
                yAxis.AxisTitle.Text = "Orders and Total Quantity";

                // get the quarter
                String quar = quarterBox.SelectedItem?.ToString();

                // chart title
                chart.HasTitle = true;
                chart.ChartTitle.Text = "Product Sales Status as of " + quar + " 2024";

                // change chart labels
                chart.SeriesCollection(1).Name = "No. of Orders";
                chart.SeriesCollection(2).Name = "Total Quantity";

                // get the current date and time
                String currentDate = getCurrentDateTime();
                // row/column
                copiedWorksheet.Cells[1, 1] = "Last Updated "+ currentDate;
                copiedWorksheet.Cells[6, 1] = quar + " of 2024";

                // delete the hidden "Sheet1" from the new workbook
                newWorkbook.Sheets["Sheet1"].Delete();

                // save the copy with a new name (no path, copy is saved in Documents folder)
                string newFilePath = "C:\\Users\\Lenovo\\Documents\\Misty\\BSIT 3A - Second Sem\\EDP\\Activity6\\reports\\" + reportName + ".xlsx";
                newWorkbook.SaveAs(newFilePath);

                // close and quit Excel
                templateWorkbook.Close(false);
                newWorkbook.Close(false);
                excelApp.Quit();

                // release COM objects
                System.Runtime.InteropServices.Marshal.ReleaseComObject(templateWorksheet);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(templateWorkbook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(newWorksheet);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(copiedWorksheet); // Release the copied worksheet as well
                System.Runtime.InteropServices.Marshal.ReleaseComObject(newWorkbook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);

                // display success message
                MessageBox.Show("Exported successfully!\n\nFile saved to:\n" + newFilePath, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while exporting the file:\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // PRODUCT INVENTORY STATUS
        public void inventoryDataToExcel(DataGridView dataGridView)
        {
            try
            {
                // load the Excel template
                String templateFilePath = "C:\\Users\\Lenovo\\Documents\\Misty\\BSIT 3A - Second Sem\\EDP\\Activity6\\reports\\InventoryTemp.xlsx";
                Excel.Application excelApp = new Excel.Application();
                excelApp.Visible = false;
                Excel.Workbook templateWorkbook = excelApp.Workbooks.Open(templateFilePath);
                Excel.Worksheet templateWorksheet = (Excel.Worksheet)templateWorkbook.Sheets[1];

                // create a new workbook
                Excel.Workbook newWorkbook = excelApp.Workbooks.Add();
                Excel.Worksheet newWorksheet = (Excel.Worksheet)newWorkbook.Sheets[1];

                // copy the template worksheet into the new workbook
                templateWorksheet.Copy(After: newWorksheet);

                // get the copied worksheet
                Excel.Worksheet copiedWorksheet = (Excel.Worksheet)newWorkbook.Sheets[2];

                // rename the copied worksheet
                copiedWorksheet.Name = "Report";

                // define starting row and column indices for the copied worksheet
                int startRow = 10;
                int startColumn = 1;

                // define column mappings (DataGridView column index to Excel column index)
                // DGV col index to EXC col index
                Dictionary<int, int> columnMappings = new Dictionary<int, int>
                {
                    { 0, startColumn },
                    { 1, startColumn + 1 },
                    { 2, startColumn + 2 },
                    { 3, startColumn + 3 },
                    { 4, startColumn + 4 },
                    { 5, startColumn + 5 },
                    { 6, startColumn + 6 }
                };

                // populate the copied worksheet with the data from the DataGridView
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                    {
                        // check if the DataGridView column index has a corresponding mapping
                        if (columnMappings.ContainsKey(j))
                        {
                            // get the corresponding Excel column index based on the mapping
                            int excelColumnIndex = columnMappings[j];

                            // write the cell value to the specified Excel cell in the copied worksheet
                            copiedWorksheet.Cells[startRow + i, excelColumnIndex] = dataGridView.Rows[i].Cells[j].Value?.ToString();
                        }
                    }
                }

                // create a new worksheet for the chart
                Excel.Worksheet chartWorksheet = (Excel.Worksheet)newWorkbook.Worksheets.Add();
                chartWorksheet.Name = "Chart";

                // Define the ranges for columns B and F
                Excel.Range rangeB = copiedWorksheet.Range["B10", "B" + (startRow + dataGridView.Rows.Count - 1)];
                Excel.Range rangeF = copiedWorksheet.Range["F10", "F" + (startRow + dataGridView.Rows.Count - 1)];

                // Merge the ranges
                Excel.Range chartRange = copiedWorksheet.Application.Union(rangeB, rangeF);

                // create a chart object
                Excel.ChartObjects chartObjects = (Excel.ChartObjects)chartWorksheet.ChartObjects();
                // left/top/width/height
                Excel.ChartObject chartObject = chartObjects.Add(100, 100, 800, 300);
                Excel.Chart chart = chartObject.Chart;

                // configure the chart
                chart.SetSourceData(chartRange);
                chart.ChartType = Excel.XlChartType.xlBarStacked;

                // position the chart in the "Chart" worksheet
                chartObject.Left = 25;
                chartObject.Top = 25;

                // add labels
                Excel.Axis xAxis = (Excel.Axis)chart.Axes(Excel.XlAxisType.xlCategory, Excel.XlAxisGroup.xlPrimary);
                xAxis.HasTitle = true;
                xAxis.AxisTitle.Text = "Products";

                Excel.Axis yAxis = (Excel.Axis)chart.Axes(Excel.XlAxisType.xlValue, Excel.XlAxisGroup.xlPrimary);
                yAxis.HasTitle = true;
                yAxis.AxisTitle.Text = "Items in Stock";

                // get the current date today
                String date = getCurrentDate();

                // chart title
                chart.HasTitle = true;
                chart.ChartTitle.Text = "Product Inventory Status as of " + date;

                // change chart label
                chart.SeriesCollection(1).Name = "Items in Stock";

                // get the current date and time
                String currentDate = getCurrentDateTime();
                // row/column
                copiedWorksheet.Cells[1, 1] = "Last Updated " + currentDate;
                copiedWorksheet.Cells[6, 1] = "As of " + date;

                // delete the hidden "Sheet1" from the new workbook
                newWorkbook.Sheets["Sheet1"].Delete();

                // save the copy with a new name (no path, copy is saved in Documents folder)
                string newFilePath = "C:\\Users\\Lenovo\\Documents\\Misty\\BSIT 3A - Second Sem\\EDP\\Activity6\\reports\\" + reportName + ".xlsx";
                newWorkbook.SaveAs(newFilePath);

                // close and quit Excel
                templateWorkbook.Close(false);
                newWorkbook.Close(false);
                excelApp.Quit();

                // release COM objects
                System.Runtime.InteropServices.Marshal.ReleaseComObject(templateWorksheet);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(templateWorkbook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(newWorksheet);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(copiedWorksheet); // Release the copied worksheet as well
                System.Runtime.InteropServices.Marshal.ReleaseComObject(newWorkbook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);

                // display success message
                MessageBox.Show("Exported successfully!\n\nFile saved to:\n" + newFilePath, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while exporting the file:\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void placeOrderBtn_Click(object sender, EventArgs e)
        {
            // open form for placing orders
            placeOrderForm placeOrderForm = new placeOrderForm();
            placeOrderForm.Show();
        }

        private void addItembtn_Click(object sender, EventArgs e)
        {
            addItemForm addItemForm = new addItemForm();
            addItemForm.Show();
        }

        // refresh the data
        private void refreshBtn_Click(object sender, EventArgs e)
        {
            selectedReport = reportBox.SelectedItem?.ToString();

            if (selectedReport == "Order Report")
            {
                orderDataLoad();
            }
            else if (selectedReport == "Product Sales")
            {
                productDataLoad();
            }
            else if (selectedReport == "Inventory")
            {
                inventoryDataLoad();
            }
        }

        private void cusRegisBtn_Click(object sender, EventArgs e)
        {
            customerRegForm customerRegForm = new customerRegForm();
            customerRegForm.Show();
        }
    }
}