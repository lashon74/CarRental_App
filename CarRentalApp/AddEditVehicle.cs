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
    public partial class AddEditVehicle : Form
    {
        ManageVehicleListing manageVehicleListing = new ManageVehicleListing();
        private bool IsEditMode;
        private readonly CarRental_Entity _db = new CarRental_Entity();

        public AddEditVehicle()
        {
            InitializeComponent();
            lblAddEdit.Text= "Add New Vehicle";
            this.Text = "Add New Vehicle";
            IsEditMode = false;
        }

        public AddEditVehicle(CarRental_TypesOfCars carToEdit)
        {
            InitializeComponent();
            lblAddEdit.Text = "Edit Vehicle";
            this.Text = "Edit Vehicle";
            if (carToEdit == null)
            {
                MessageBox.Show("Please ensure that you selected a valid record to edit");
                Close();
            }
            else
            {
                IsEditMode = true;
                PopulateFields(carToEdit);
            }
            
        }

        private void PopulateFields(CarRental_TypesOfCars carToEdit)
        {
            lblID.Text= carToEdit.Id.ToString();
            txtYear.Text = carToEdit.Year.ToString();
            txtMake.Text = carToEdit.Make;
            txtModel.Text = carToEdit.Model;
            txtVin.Text = carToEdit.Vin;
            txtLicencePlate.Text = carToEdit.LicensePlateNumber;
        }

        private void OpenForm()
        {
            this.Close();
            manageVehicleListing.PopulateGrid();
            manageVehicleListing.MdiParent = CarRentalApp.MainWindow.ActiveForm;
            manageVehicleListing.WindowState = FormWindowState.Maximized;
            manageVehicleListing.Show();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                var errorMessage = "";
                var addEdit = true;

                if (IsEditMode)
                {
                    var id = int.Parse(lblID.Text);
                    var car = _db.CarRental_TypesOfCars.FirstOrDefault(column => column.Id == id);
                    car.Year = int.Parse(txtYear.Text);
                    car.Make = txtMake.Text;
                    car.Model = txtModel.Text;
                    car.Vin = txtVin.Text;
                    car.LicensePlateNumber = txtLicencePlate.Text;

                    if (car.Make == string.Empty || car.Model == string.Empty)
                    {
                        addEdit = false;
                        errorMessage += "Error: Vehicle must have a Make and/or Model.";
                    }
                    else if (car.Year == null)
                    {
                        addEdit = false;
                        errorMessage += "Error: Vehicle must have year.";
                    }

                    if (addEdit)
                    {
                        _db.SaveChanges();
                        MessageBox.Show("You edit to th vehicle has been completed!");
                        OpenForm();
                    }
                    else
                    {
                        MessageBox.Show(errorMessage);
                    }
                   
                }
                else
                {
                    var newCar = new CarRental_TypesOfCars
                    {
                        LicensePlateNumber = txtLicencePlate.Text,
                        Make = txtMake.Text,
                        Model = txtModel.Text,
                        Vin = txtVin.Text,
                        Year = int.Parse(txtYear.Text)
                    };

                    if (newCar.Make == string.Empty || newCar.Model == string.Empty)
                    {
                        addEdit = false;
                        errorMessage += "Error: Vehicle must have a Make and/or Model.";
                    }else if (newCar.Year == null)
                    {
                        addEdit = false;
                        errorMessage += "Error: Vehicle must have year.";
                    }

                    if (addEdit)
                    {
                        //_dbcarRentalRecord.TypesOfCars.Add(newCar);
                        _db.SaveChanges();
                        MessageBox.Show("New Vehicle added to list of cars!");
                        OpenForm();
                    }
                    else
                    {
                        MessageBox.Show(errorMessage);
                    }
                }
            }
            catch (Exception error)
            {

                MessageBox.Show($"Error: {error.Message}");
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
