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
    public partial class AddEditRentalRecord : Form
    {
        //Making an object of data base model initializing it
        private readonly CarRental_Entity _db = new CarRental_Entity();
        private bool IsEditMode;
        ManageRentalrecord manageRentalrecord = new ManageRentalrecord();

        public AddEditRentalRecord()
        {
            InitializeComponent();
            lblRental.Text = "Add Rental Record";
            this.Text = "Add Rental Record";
            IsEditMode = false;
        }
        public AddEditRentalRecord(CarRental_Records rentalToEdit)
        {
            InitializeComponent();
            lblRental.Text = "Edit Rental Record";
            this.Text = "Edit Rental Record";
            if (rentalToEdit == null)
            {
                MessageBox.Show("Please ensure that you selected a valid record to edit");
                Close();
            }
            else
            {
                IsEditMode = true;
                PopulateFields(rentalToEdit);
            }
           
        }

        private void PopulateFields(CarRental_Records rentalToEdit)
        {
            txtCustomer.Text = rentalToEdit.CustomerName;
            dtPick1.Value = (DateTime)rentalToEdit.DateRented;
            dtPick2.Value = (DateTime)rentalToEdit.DateReturned;
            txtCost.Text = rentalToEdit.Cost.ToString();
            lblID.Text = rentalToEdit.Id.ToString();

        }

        private void OpenForm()
        {
            this.Close();
            manageRentalrecord.PopulateGrid();
            manageRentalrecord.MdiParent = CarRentalApp.MainWindow.ActiveForm;
            manageRentalrecord.WindowState = FormWindowState.Maximized;
            manageRentalrecord.Show();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            try
            {
                var customerName = txtCustomer.Text;
                var dateOut = dtPick1.Value;
                var dateIn = dtPick2.Value;
                var cost = Convert.ToDouble(txtCost.Text);

                string carType = cbCarType.Text;
                var isValid = true;
                var errorMessage = "";


                if (string.IsNullOrWhiteSpace(customerName) || string.IsNullOrWhiteSpace(carType))
                {
                    isValid = false;
                   errorMessage +=  "Error: Please enter missing data.";
                }
                if (dateOut > dateIn)
                {
                    isValid = false;
                    errorMessage += "Error: Illegal date selection";

                }

                if (isValid)
                {
                    var rentalRecord = new CarRental_Records();
                    if (IsEditMode)
                    {
                        var id = int.Parse(lblID.Text);
                        //rentalRecord = _dbcarRentalRecord.CarRental_Records.FirstOrDefault(column => column.Id == id);
                    }
                    rentalRecord.CustomerName = customerName;
                    rentalRecord.DateRented = dateOut;
                    rentalRecord.DateReturned = dateIn;
                    rentalRecord.Cost = (decimal)cost;
                    rentalRecord.TypeOfCarId = (int)cbCarType.SelectedValue;

                    if (!IsEditMode)
                    {
                        //_dbcarRentalRecord.CarRentalRecords.Add(rentalRecord);
                    }

                    _db.SaveChanges();

                    MessageBox.Show($"Customer Name: {customerName}\n\r + " +
                        $"Date Rented: {dateOut}\n\r" +
                        $"Date returned: {dateIn}\n\r" +
                        $"Cost: {cost}\n\r" +
                        $"Car Type: {carType}\n\r" +
                        $"THANK YOU FOR YOUR RENTAL");
                    OpenForm();
                }
                else
                {
                    MessageBox.Show(errorMessage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        private void Reset()
        {
            txtCost.Text = "";
            txtCustomer.Text = "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Select * from typeofcars
            //var cars = _dbcarRentalRecord.TypesOfCars.ToList();

            var cars = _db.CarRental_TypesOfCars.Select(column => new {
                CarID = column.Id, 
                CarMake = column.Make + " " + column.Model
            }).ToList();
            cbCarType.DisplayMember = "CarMake";
            cbCarType.ValueMember = "CarID";
            cbCarType.DataSource = cars;
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            var main = new MainWindow();
            main.Show();
        }
    }
}
