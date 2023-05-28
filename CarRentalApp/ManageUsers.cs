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
    public partial class ManageUsers : Form
    {
        private readonly CarRental_Entity _db = new CarRental_Entity();

        public ManageUsers()
        {
            InitializeComponent();
        }

        public void PopulateGrid()
        {
            try
            {
                var users = _db.CarRental_Users
                .Select(column => new
                {
                    Id = column.Id,
                    UserName = column.username,
                    UserRoles = column.CarRental_UserRoles.FirstOrDefault().CarRental_Roles.Name,
                    IsActive = column.IsActive
                }).ToList();

                dgvUsers.DataSource = users;
                dgvUsers.Columns["Id"].Visible = false;
            }
            catch (Exception error)
            {

                MessageBox.Show($"Error: {error.Message}");
            }
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            var addUser = new AddUser(this);
            addUser.MdiParent = this.MdiParent;
            addUser.Show();
        }

        private void btnRestPassword_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)dgvUsers.SelectedRows[0].Cells["Id"].Value;
                var user = _db.CarRental_Users.FirstOrDefault(column => column.Id == id);

                var genericPassword = Utils.DefaultHashedPassword();
                var hashed_password = Utils.HashPassword(genericPassword);

                user.password = hashed_password;
                _db.SaveChanges();

                MessageBox.Show($"{user.username}'s Password has been reset!");

            }
            catch (Exception error)
            {
                MessageBox.Show($"Error: {error.Message}");
            }
        }

        private void btnDeactivateUser_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)dgvUsers.SelectedRows[0].Cells["Id"].Value;
                var user = _db.CarRental_Users.FirstOrDefault(column => column.Id == id);
                //Toggles if isactivate is true or not to deactivate and activate users
                user.IsActive = user.IsActive == true ? false : true;
                _db.SaveChanges();

                MessageBox.Show($"{user.username}'s Active status has changed!");
                PopulateGrid();

            }
            catch (Exception error)
            {
                MessageBox.Show($"Error: {error.Message}");
            }
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            PopulateGrid();
        }
    }
}
