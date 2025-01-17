namespace TechnicalService.Forms
{
    partial class CustomerTestForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBusinessName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblBusinessName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.dataGridCustomers = new System.Windows.Forms.DataGridView();

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Text = "Customer Test Form";

            // GroupBox
            this.groupBox1.Text = "Customer Information";
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Size = new System.Drawing.Size(300, 250);

            // Labels
            this.lblBusinessName.Text = "Business Name:";
            this.lblBusinessName.Location = new System.Drawing.Point(20, 30);
            this.lblFirstName.Text = "First Name:";
            this.lblFirstName.Location = new System.Drawing.Point(20, 60);
            this.lblLastName.Text = "Last Name:";
            this.lblLastName.Location = new System.Drawing.Point(20, 90);
            this.lblPhone.Text = "Phone:";
            this.lblPhone.Location = new System.Drawing.Point(20, 120);
            this.lblEmail.Text = "Email:";
            this.lblEmail.Location = new System.Drawing.Point(20, 150);

            // TextBoxes
            this.txtBusinessName.Location = new System.Drawing.Point(100, 30);
            this.txtBusinessName.Size = new System.Drawing.Size(180, 20);
            this.txtFirstName.Location = new System.Drawing.Point(100, 60);
            this.txtFirstName.Size = new System.Drawing.Size(180, 20);
            this.txtLastName.Location = new System.Drawing.Point(100, 90);
            this.txtLastName.Size = new System.Drawing.Size(180, 20);
            this.txtPhone.Location = new System.Drawing.Point(100, 120);
            this.txtPhone.Size = new System.Drawing.Size(180, 20);
            this.txtEmail.Location = new System.Drawing.Point(100, 150);
            this.txtEmail.Size = new System.Drawing.Size(180, 20);

            // Save Button
            this.btnSave.Text = "Save Customer";
            this.btnSave.Location = new System.Drawing.Point(100, 190);
            this.btnSave.Size = new System.Drawing.Size(180, 30);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // DataGridView
            this.dataGridCustomers.Location = new System.Drawing.Point(320, 12);
            this.dataGridCustomers.Size = new System.Drawing.Size(468, 576);
            this.dataGridCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridCustomers.AllowUserToAddRows = false;
            this.dataGridCustomers.ReadOnly = true;

            // Add controls to form
            this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblBusinessName, this.txtBusinessName,
                this.lblFirstName, this.txtFirstName,
                this.lblLastName, this.txtLastName,
                this.lblPhone, this.txtPhone,
                this.lblEmail, this.txtEmail,
                this.btnSave
            });

            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.groupBox1,
                this.dataGridCustomers
            });
        }

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBusinessName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblBusinessName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dataGridCustomers;

        #endregion
    }
}
