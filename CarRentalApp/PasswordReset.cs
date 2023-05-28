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
    public partial class PasswordReset : Form
    {
        private readonly CarRental_Entity _db = new CarRental_Entity();
        private CarRental_Users _user;

        public PasswordReset(CarRental_Users user)
        {
            InitializeComponent();
            _user = user;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                var password = txtPassword.Text;
                var confirm = txtConfirm.Text;
                var user = _db.CarRental_Users.FirstOrDefault(column => column.Id == _user.Id);

                if (password != confirm)
                {
                    MessageBox.Show("Passwords do not match. Please try again!");
                }

                user.password = Utils.HashPassword(password);
                _db.SaveChanges();
                MessageBox.Show("Password was reset successfully!");
                Close();

            }
            catch (Exception)
            {
                MessageBox.Show("An Error has occured. Please try again!");

            }

        }
    }
}
