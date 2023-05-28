
namespace CarRentalApp
{
    partial class ManageRentalrecord
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
            this.btnDeleteRecord = new System.Windows.Forms.Button();
            this.btnEditRecord = new System.Windows.Forms.Button();
            this.btnNewRecord = new System.Windows.Forms.Button();
            this.lblRental = new System.Windows.Forms.Label();
            this.dgvRecords = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteRecord
            // 
            this.btnDeleteRecord.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRecord.Location = new System.Drawing.Point(520, 112);
            this.btnDeleteRecord.Name = "btnDeleteRecord";
            this.btnDeleteRecord.Size = new System.Drawing.Size(200, 51);
            this.btnDeleteRecord.TabIndex = 13;
            this.btnDeleteRecord.Text = "Delete Record";
            this.btnDeleteRecord.UseVisualStyleBackColor = true;
            this.btnDeleteRecord.Click += new System.EventHandler(this.btnDeleteRecord_Click);
            // 
            // btnEditRecord
            // 
            this.btnEditRecord.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditRecord.Location = new System.Drawing.Point(262, 112);
            this.btnEditRecord.Name = "btnEditRecord";
            this.btnEditRecord.Size = new System.Drawing.Size(200, 51);
            this.btnEditRecord.TabIndex = 12;
            this.btnEditRecord.Text = "Edit Record";
            this.btnEditRecord.UseVisualStyleBackColor = true;
            this.btnEditRecord.Click += new System.EventHandler(this.btnEditRecord_Click);
            // 
            // btnNewRecord
            // 
            this.btnNewRecord.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewRecord.Location = new System.Drawing.Point(12, 112);
            this.btnNewRecord.Name = "btnNewRecord";
            this.btnNewRecord.Size = new System.Drawing.Size(200, 51);
            this.btnNewRecord.TabIndex = 11;
            this.btnNewRecord.Text = "Add New Record";
            this.btnNewRecord.UseVisualStyleBackColor = true;
            this.btnNewRecord.Click += new System.EventHandler(this.btnNewRecord_Click);
            // 
            // lblRental
            // 
            this.lblRental.AutoSize = true;
            this.lblRental.Font = new System.Drawing.Font("Matura MT Script Capitals", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRental.Location = new System.Drawing.Point(46, 9);
            this.lblRental.Name = "lblRental";
            this.lblRental.Size = new System.Drawing.Size(622, 72);
            this.lblRental.TabIndex = 10;
            this.lblRental.Text = "Manage Rental Record";
            this.lblRental.Click += new System.EventHandler(this.lblRental_Click);
            // 
            // dgvRecords
            // 
            this.dgvRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecords.Location = new System.Drawing.Point(12, 169);
            this.dgvRecords.Name = "dgvRecords";
            this.dgvRecords.Size = new System.Drawing.Size(708, 269);
            this.dgvRecords.TabIndex = 9;
            this.dgvRecords.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecords_CellContentClick);
            // 
            // ManageRentalrecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 450);
            this.Controls.Add(this.btnDeleteRecord);
            this.Controls.Add(this.btnEditRecord);
            this.Controls.Add(this.btnNewRecord);
            this.Controls.Add(this.lblRental);
            this.Controls.Add(this.dgvRecords);
            this.Name = "ManageRentalrecord";
            this.Text = "Manage Rental record";
            this.Load += new System.EventHandler(this.ManageRentalrecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteRecord;
        private System.Windows.Forms.Button btnEditRecord;
        private System.Windows.Forms.Button btnNewRecord;
        private System.Windows.Forms.Label lblRental;
        private System.Windows.Forms.DataGridView dgvRecords;
    }
}