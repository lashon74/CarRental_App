using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class Login : Form
    {
        private readonly CarRental_Entity _db = new CarRental_Entity();


        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var userName = txtUserName.Text.Trim();
                var password = txtPassword.Text;

                var hashed_password = Utils.HashPassword(password);

                var user = _db.CarRental_Users.FirstOrDefault(column =>
                column.username == userName &&
                column.password == hashed_password &&
                column.IsActive == true);

                if (user == null)
                {
                    MessageBox.Show("Please provide valid credentials");
                }
                else
                {
                    //var role = user.CarRental_UserRoles.FirstOrDefault();
                    //var roleShortName = role.CarRental_Roles.Shortname;
                    //Easier to just pass object through
                    MainWindow mainWindow = new MainWindow(this, user);
                    mainWindow.Show();
                    Hide();
                }

                
            }
            catch (Exception)
            {
                MessageBox.Show("User name or password is incorrect try again!");
            }
           
        }
    }
}
