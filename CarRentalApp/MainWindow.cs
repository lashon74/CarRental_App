using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class MainWindow : Form
    {
        private Login _login;
        public string _roleName;
        public CarRental_Users _user;


        public MainWindow()
        {
            InitializeComponent();
        }

        public MainWindow(Login login, CarRental_Users user)
        {
            InitializeComponent();
            this._login = login;
            _user = user;
            //Linq uses inner join to get results from table that has a foreign key on it
            this._roleName = user.CarRental_UserRoles.FirstOrDefault().CarRental_Roles.Shortname;
        }

        private void addRentalRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Text == "Add Rental Record")
                {
                    IsOpen = true;
                    form.Focus();
                    break;
                }
            }
            if(IsOpen == false)
    {
                var addRentalRecord = new AddEditRentalRecord();
                addRentalRecord.MdiParent = this;
                addRentalRecord.WindowState = FormWindowState.Maximized;
                addRentalRecord.Show();
            }
        }

        private void manageVehicleListingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Text == "Manage Vehicle Listing")
                {
                    IsOpen = true;
                    form.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                var manageVehicleListing = new ManageVehicleListing();
                manageVehicleListing.MdiParent = this;
                manageVehicleListing.WindowState = FormWindowState.Maximized;
                manageVehicleListing.Show();
            }
        }

        private void viewArchiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Text == "Manage Rental Record")
                {
                    IsOpen = true;
                    form.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                var manageRentalrecord = new ManageRentalrecord();
                manageRentalrecord.MdiParent = this;
                manageRentalrecord.WindowState = FormWindowState.Maximized;
                manageRentalrecord.Show();
            }
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Close();
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Text == "Manage Users")
                {
                    IsOpen = true;
                    form.Focus();
                    break;
                }
            }
            if (IsOpen == false)
            {
                var manageUsers = new ManageUsers();
                manageUsers.MdiParent = this;
                manageUsers.WindowState = FormWindowState.Maximized;
                manageUsers.Show();
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

            if (_user.password == Utils.DefaultHashedPassword())
            {
                var resetPassword = new PasswordReset(_user);
                resetPassword.ShowDialog();
            }
            var username = _user.username;
            statusTxt.Text = $"Logged In As: {username}";
            if (_roleName != "admin")
            {
                manageUsersToolStripMenuItem.Visible = false;
            }
        }
    }
}
