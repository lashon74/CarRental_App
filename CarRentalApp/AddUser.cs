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
    public partial class AddUser : Form
    {
        private readonly CarRental_Entity _db = new CarRental_Entity();
        private ManageUsers _manageUsers;
        public AddUser(ManageUsers manageUsers)
        {
            InitializeComponent();
            _manageUsers = manageUsers;

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var username = txtUserName.Text;
                var roleId = (int)cmbUserRole.SelectedValue;
                var password = Utils.DefaultHashedPassword();
                var user = new CarRental_Users
                {
                    username = username,
                    password = password,
                    IsActive = true
                };

                _db.CarRental_Users.Add(user);
                _db.SaveChanges();

                var userId = user.Id;

                var userRole = new CarRental_UserRoles
                {
                    roleId = roleId,
                    userId  = userId
                };

                _db.CarRental_UserRoles.Add(userRole);
                _db.SaveChanges();

                MessageBox.Show("User has been created!");
                _manageUsers.PopulateGrid();
                Close();
            }
            catch (Exception)
            {

                MessageBox.Show("An Error has occured");
            }
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            var roles = _db.CarRental_Roles.ToList();
            cmbUserRole.DataSource = roles;
            cmbUserRole.DisplayMember = "Name";
            cmbUserRole.ValueMember = "Id";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
