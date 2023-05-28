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
    public partial class ManageVehicleListing : Form
    {
        private readonly CarRental_Entity _db = new CarRental_Entity();
        public ManageVehicleListing()
        {
            InitializeComponent();
            //_dbcarRentalRecord = new TestSP_DBEntities();
        }

        private void ManageVehicleListing_Load(object sender, EventArgs e)
        {
            try
            {
                PopulateGrid();

            }
            catch (Exception)
            {

                throw;
                
            }
        }

        public void PopulateGrid()
        {
            /*Select * from typeofcars var cars = _dbcarRentalRecord.TypesOfCars.ToList(); To get certain columns use use alliase with arrow function for linq*/
            try
            {
                var cars = _db.CarRental_TypesOfCars
                .Select(column => new
                {
                    column.Id,
                    CarYear = column.Year,
                    CarMake = column.Make,
                    CarModel = column.Model,
                    CarVin = column.Vin,
                    CarLicense = column.LicensePlateNumber
                })
                .ToList();
                dgvVehicles.DataSource = cars;
                dgvVehicles.Columns["Id"].Visible = false;
            }
            catch (Exception error)
            {

                MessageBox.Show($"Error: {error.Message}");
            }
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            try
            {
                var addEditVehicle = new AddEditVehicle();
                addEditVehicle.MdiParent = this.MdiParent;
                addEditVehicle.WindowState = FormWindowState.Maximized;
                addEditVehicle.Show();
                this.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show($"Error: {error.Message}");
            }
        }

        private void btnEditCar_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)dgvVehicles.SelectedRows[0].Cells["Id"].Value;
                var car = _db.CarRental_TypesOfCars.FirstOrDefault(column => column.Id == id);

                var addEditVehicle = new AddEditVehicle(car);
                addEditVehicle.MdiParent = this.MdiParent;
                addEditVehicle.WindowState = FormWindowState.Maximized;
                addEditVehicle.Show();
                this.Close();

            }
            catch (Exception error)
            {
                MessageBox.Show($"Error: {error.Message}");
            }
        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)dgvVehicles.SelectedRows[0].Cells["Id"].Value;
                var car = _db.CarRental_TypesOfCars.FirstOrDefault(column => column.Id == id);

                _db.CarRental_TypesOfCars.Remove(car);
                _db.SaveChanges();
                dgvVehicles.Refresh();
                MessageBox.Show("The record of the vehicle has been deleted");
                PopulateGrid();

            }
            catch (Exception error)
            {

                MessageBox.Show($"Error: {error.Message}");
            }
        }
    }
}
