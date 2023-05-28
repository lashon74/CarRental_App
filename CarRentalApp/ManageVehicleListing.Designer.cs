namespace CarRentalApp
{
    partial class ManageVehicleListing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvVehicles = new System.Windows.Forms.DataGridView();
            this.lblRental = new System.Windows.Forms.Label();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.btnEditCar = new System.Windows.Forms.Button();
            this.btnDeleteCar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVehicles
            // 
            this.dgvVehicles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicles.Location = new System.Drawing.Point(12, 169);
            this.dgvVehicles.Name = "dgvVehicles";
            this.dgvVehicles.Size = new System.Drawing.Size(708, 269);
            this.dgvVehicles.TabIndex = 0;
            // 
            // lblRental
            // 
            this.lblRental.AutoSize = true;
            this.lblRental.Font = new System.Drawing.Font("Matura MT Script Capitals", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRental.Location = new System.Drawing.Point(46, 9);
            this.lblRental.Name = "lblRental";
            this.lblRental.Size = new System.Drawing.Size(662, 72);
            this.lblRental.TabIndex = 1;
            this.lblRental.Text = "Manage Vehicle Lsting";
            // 
            // btnAddCar
            // 
            this.btnAddCar.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCar.Location = new System.Drawing.Point(12, 112);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(200, 51);
            this.btnAddCar.TabIndex = 6;
            this.btnAddCar.Text = "Add Car";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // btnEditCar
            // 
            this.btnEditCar.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCar.Location = new System.Drawing.Point(262, 112);
            this.btnEditCar.Name = "btnEditCar";
            this.btnEditCar.Size = new System.Drawing.Size(200, 51);
            this.btnEditCar.TabIndex = 7;
            this.btnEditCar.Text = "Edit Car";
            this.btnEditCar.UseVisualStyleBackColor = true;
            this.btnEditCar.Click += new System.EventHandler(this.btnEditCar_Click);
            // 
            // btnDeleteCar
            // 
            this.btnDeleteCar.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCar.Location = new System.Drawing.Point(520, 112);
            this.btnDeleteCar.Name = "btnDeleteCar";
            this.btnDeleteCar.Size = new System.Drawing.Size(200, 51);
            this.btnDeleteCar.TabIndex = 8;
            this.btnDeleteCar.Text = "Delete Car";
            this.btnDeleteCar.UseVisualStyleBackColor = true;
            this.btnDeleteCar.Click += new System.EventHandler(this.btnDeleteCar_Click);
            // 
            // ManageVehicleListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 450);
            this.Controls.Add(this.btnDeleteCar);
            this.Controls.Add(this.btnEditCar);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.lblRental);
            this.Controls.Add(this.dgvVehicles);
            this.Name = "ManageVehicleListing";
            this.Text = "Manage Vehicle Listing";
            this.Load += new System.EventHandler(this.ManageVehicleListing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVehicles;
        private System.Windows.Forms.Label lblRental;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Button btnEditCar;
        private System.Windows.Forms.Button btnDeleteCar;
    }
}