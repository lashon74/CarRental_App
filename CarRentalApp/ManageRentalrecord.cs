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
    public partial class ManageRentalrecord : Form
    {
        private readonly CarRental_Entity _db = new CarRental_Entity();
        public ManageRentalrecord()
        {
            InitializeComponent();
        }

        private void btnNewRecord_Click(object sender, EventArgs e)
        {
            try
            {
                var addRentalRecord = new AddEditRentalRecord();
                addRentalRecord.MdiParent = this.MdiParent;
                addRentalRecord.WindowState = FormWindowState.Maximized;
                addRentalRecord.Show();
                this.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show($"Error: {error.Message}");
            }
        }

        private void btnEditRecord_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)dgvRecords.SelectedRows[0].Cells["Id"].Value;
                var record = _db.CarRental_Records.FirstOrDefault(column => 
                column.Id == id);

                var addEditRentalRecord = new AddEditRentalRecord(record);
                addEditRentalRecord.MdiParent = this.MdiParent;
                addEditRentalRecord.WindowState = FormWindowState.Maximized;
                addEditRentalRecord.Show();
                this.Close();

            }
            catch (Exception error)
            {
                MessageBox.Show($"Error: {error.Message}");
            }
        }

        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)dgvRecords.SelectedRows[0].Cells["Id"].Value;
                var record = _db.CarRental_Records.FirstOrDefault(column => 
                column.Id == id);

                _db.CarRental_Records.Remove(record);
                _db.SaveChanges();
                dgvRecords.Refresh();
                MessageBox.Show("The record of the rental purchase has been deleted");
                PopulateGrid();

            }
            catch (Exception error)
            {

                MessageBox.Show($"Error: {error.Message}");
            }
        }

        private void ManageRentalrecord_Load(object sender, EventArgs e)
        {
            try
            {
                PopulateGrid();

            }
            catch (Exception)
            {

                MessageBox.Show("An Error has occured");
            }
        }

        public void PopulateGrid()
        {
            try
            {
                var records = _db.CarRental_Records
                .Select(column => new
                {
                    Id = column.Id,
                    Customer = column.CustomerName,
                    DateOut = column.DateRented,
                    DateIn = column.DateReturned,
                    Cost = column.Cost,
                    Car = column.CarRental_TypesOfCars.Make + " " + column.CarRental_TypesOfCars.Model
                }).ToList();

                dgvRecords.DataSource = records;
                dgvRecords.Columns["Id"].Visible = false;
            }
            catch (Exception error)
            {

                MessageBox.Show($"Error: {error.Message}");
            }
        }

        private void dgvRecords_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblRental_Click(object sender, EventArgs e)
        {

        }
    }
}
