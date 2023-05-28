namespace CarRentalApp
{
    partial class AddEditRentalRecord
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
            this.lblRental = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.dtPick1 = new System.Windows.Forms.DateTimePicker();
            this.dtPick2 = new System.Windows.Forms.DateTimePicker();
            this.lblRentDate = new System.Windows.Forms.Label();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.cbCarType = new System.Windows.Forms.ComboBox();
            this.lblTypeCar = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRental
            // 
            this.lblRental.AutoSize = true;
            this.lblRental.Font = new System.Drawing.Font("Matura MT Script Capitals", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRental.Location = new System.Drawing.Point(143, 9);
            this.lblRental.Name = "lblRental";
            this.lblRental.Size = new System.Drawing.Size(538, 72);
            this.lblRental.TabIndex = 0;
            this.lblRental.Text = "Add Rental Record";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(12, 174);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(137, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Customer Name";
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(155, 176);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(200, 20);
            this.txtCustomer.TabIndex = 2;
            // 
            // dtPick1
            // 
            this.dtPick1.Location = new System.Drawing.Point(155, 210);
            this.dtPick1.Name = "dtPick1";
            this.dtPick1.Size = new System.Drawing.Size(200, 20);
            this.dtPick1.TabIndex = 3;
            // 
            // dtPick2
            // 
            this.dtPick2.Location = new System.Drawing.Point(155, 245);
            this.dtPick2.Name = "dtPick2";
            this.dtPick2.Size = new System.Drawing.Size(200, 20);
            this.dtPick2.TabIndex = 3;
            // 
            // lblRentDate
            // 
            this.lblRentDate.AutoSize = true;
            this.lblRentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentDate.Location = new System.Drawing.Point(12, 211);
            this.lblRentDate.Name = "lblRentDate";
            this.lblRentDate.Size = new System.Drawing.Size(112, 20);
            this.lblRentDate.TabIndex = 1;
            this.lblRentDate.Text = "Date Rented";
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnDate.Location = new System.Drawing.Point(12, 246);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(128, 20);
            this.lblReturnDate.TabIndex = 1;
            this.lblReturnDate.Text = "Date Returned";
            // 
            // cbCarType
            // 
            this.cbCarType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCarType.FormattingEnabled = true;
            this.cbCarType.Location = new System.Drawing.Point(155, 279);
            this.cbCarType.Name = "cbCarType";
            this.cbCarType.Size = new System.Drawing.Size(200, 21);
            this.cbCarType.TabIndex = 4;
            // 
            // lblTypeCar
            // 
            this.lblTypeCar.AutoSize = true;
            this.lblTypeCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeCar.Location = new System.Drawing.Point(12, 277);
            this.lblTypeCar.Name = "lblTypeCar";
            this.lblTypeCar.Size = new System.Drawing.Size(98, 20);
            this.lblTypeCar.TabIndex = 1;
            this.lblTypeCar.Text = "Type of car";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(155, 336);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(200, 51);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(388, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cost";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(440, 176);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(200, 20);
            this.txtCost.TabIndex = 2;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(739, 423);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 13);
            this.lblID.TabIndex = 6;
            this.lblID.Visible = false;
            // 
            // AddEditRentalRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cbCarType);
            this.Controls.Add(this.dtPick2);
            this.Controls.Add(this.dtPick1);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.lblTypeCar);
            this.Controls.Add(this.lblReturnDate);
            this.Controls.Add(this.lblRentDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblRental);
            this.Name = "AddEditRentalRecord";
            this.Text = "Add Rental Record";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRental;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.DateTimePicker dtPick1;
        private System.Windows.Forms.DateTimePicker dtPick2;
        private System.Windows.Forms.Label lblRentDate;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.ComboBox cbCarType;
        private System.Windows.Forms.Label lblTypeCar;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label lblID;
    }
}

