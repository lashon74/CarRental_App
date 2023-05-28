
namespace CarRentalApp
{
    partial class ManageUsers
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
            this.btnDeactivateUser = new System.Windows.Forms.Button();
            this.btnRestPassword = new System.Windows.Forms.Button();
            this.btnNewUser = new System.Windows.Forms.Button();
            this.lblUsers = new System.Windows.Forms.Label();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeactivateUser
            // 
            this.btnDeactivateUser.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeactivateUser.Location = new System.Drawing.Point(554, 114);
            this.btnDeactivateUser.Name = "btnDeactivateUser";
            this.btnDeactivateUser.Size = new System.Drawing.Size(200, 51);
            this.btnDeactivateUser.TabIndex = 18;
            this.btnDeactivateUser.Text = "Deactivate/Activate User";
            this.btnDeactivateUser.UseVisualStyleBackColor = true;
            this.btnDeactivateUser.Click += new System.EventHandler(this.btnDeactivateUser_Click);
            // 
            // btnRestPassword
            // 
            this.btnRestPassword.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestPassword.Location = new System.Drawing.Point(296, 114);
            this.btnRestPassword.Name = "btnRestPassword";
            this.btnRestPassword.Size = new System.Drawing.Size(200, 51);
            this.btnRestPassword.TabIndex = 17;
            this.btnRestPassword.Text = "Rest Password";
            this.btnRestPassword.UseVisualStyleBackColor = true;
            this.btnRestPassword.Click += new System.EventHandler(this.btnRestPassword_Click);
            // 
            // btnNewUser
            // 
            this.btnNewUser.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewUser.Location = new System.Drawing.Point(46, 114);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(200, 51);
            this.btnNewUser.TabIndex = 16;
            this.btnNewUser.Text = "Add New User";
            this.btnNewUser.UseVisualStyleBackColor = true;
            this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
            // 
            // lblUsers
            // 
            this.lblUsers.AutoSize = true;
            this.lblUsers.Font = new System.Drawing.Font("Matura MT Script Capitals", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsers.Location = new System.Drawing.Point(196, 9);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(425, 72);
            this.lblUsers.TabIndex = 15;
            this.lblUsers.Text = "Manage Users";
            // 
            // dgvUsers
            // 
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(46, 171);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.Size = new System.Drawing.Size(708, 269);
            this.dgvUsers.TabIndex = 14;
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeactivateUser);
            this.Controls.Add(this.btnRestPassword);
            this.Controls.Add(this.btnNewUser);
            this.Controls.Add(this.lblUsers);
            this.Controls.Add(this.dgvUsers);
            this.Name = "ManageUsers";
            this.Text = "Manage Users";
            this.Load += new System.EventHandler(this.ManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeactivateUser;
        private System.Windows.Forms.Button btnRestPassword;
        private System.Windows.Forms.Button btnNewUser;
        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.DataGridView dgvUsers;
    }
}