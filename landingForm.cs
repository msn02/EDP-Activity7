using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity5
{
    public partial class landingForm : Form
    {
        public landingForm()
        {
            InitializeComponent();
            InitializeImage();
            // create a new instance of the user control forms
            dashboardForm2 = new dashboardForm();
            employeeForm2 = new employeeForm();
            aboutForm1 = new aboutForm();
            reportForm1 = new reportForm();

            // add the forms as controls to the landing form
            this.Controls.Add(dashboardForm2);
            this.Controls.Add(employeeForm2);
            this.Controls.Add(aboutForm1);
            this.Controls.Add(reportForm1);

            // show the dashboard form by default
            // hide the rest
            dashboardForm2.Show();
            employeeForm2.Hide();
            aboutForm1.Hide();
            reportForm1.Hide();
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            // show the dashboard form
            dashboardForm2.Show();
            employeeForm2.Hide();
            aboutForm1.Hide();
            reportForm1.Hide();
        }

        private void reportsBtn_Click(object sender, EventArgs e)
        {
            // show the employee form
            dashboardForm2.Hide();
            employeeForm2.Hide();
            aboutForm1.Hide();
            reportForm1.Show();
            // bring the user control form of employee to front
            reportForm1.BringToFront();
            // set the location manually
            reportForm1.Location = new Point(153, 0);
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            // go back to the log in form
            loginForm loginForm1 = new loginForm();
            loginForm1.Show();
            this.Hide();
        }

        private void employeeBtn_Click(object sender, EventArgs e)
        {
            // show the employee form
            dashboardForm2.Hide();
            employeeForm2.Show();
            aboutForm1.Hide();
            reportForm1.Hide();
            // bring the user control form of employee to front
            employeeForm2.BringToFront();
            // set the location manually
            employeeForm2.Location = new Point(153, 0);
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            // show the about form
            dashboardForm2.Hide();
            employeeForm2.Hide();
            aboutForm1.Show();
            reportForm1.Hide();
            aboutForm1.BringToFront();
            aboutForm1.Location = new Point(153, 0);
        }

        private void landingForm_Load(object sender, EventArgs e)
        {

        }


        private void InitializeImage()
        {
            PictureBox pictureBox = new PictureBox();
            // set size and location
            pictureBox.Location = new Point(0, 0);
            pictureBox.Size = new Size(120, 100);
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
