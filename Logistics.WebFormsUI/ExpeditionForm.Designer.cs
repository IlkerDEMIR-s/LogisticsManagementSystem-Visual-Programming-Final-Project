namespace Logistics.WebFormsUI
{
    partial class ExpeditionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpeditionForm));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblTotalCargoWeight = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.lblCargoParcelAmount = new System.Windows.Forms.Label();
            this.lblTotalCargoVolume = new System.Windows.Forms.Label();
            this.lblEstimatedDepartureDate = new System.Windows.Forms.Label();
            this.lblCargoName = new System.Windows.Forms.Label();
            this.lblEstimatedArrivalDate = new System.Windows.Forms.Label();
            this.txtCargoName = new System.Windows.Forms.TextBox();
            this.txtCargoParcelAmount = new System.Windows.Forms.TextBox();
            this.txtTotalCargoVolume = new System.Windows.Forms.TextBox();
            this.lblSource = new System.Windows.Forms.Label();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.txtTotalCargoWeight = new System.Windows.Forms.TextBox();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.dtpEstimatedDepartureDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEstimatedArrivalDate = new System.Windows.Forms.DateTimePicker();
            this.lblCreateExpedition = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCancel.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCancel.Location = new System.Drawing.Point(667, 386);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 42);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.LightGreen;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreate.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnCreate.Location = new System.Drawing.Point(537, 386);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(108, 42);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "&Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblTotalCargoWeight
            // 
            this.lblTotalCargoWeight.AutoSize = true;
            this.lblTotalCargoWeight.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalCargoWeight.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalCargoWeight.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTotalCargoWeight.Location = new System.Drawing.Point(397, 188);
            this.lblTotalCargoWeight.Name = "lblTotalCargoWeight";
            this.lblTotalCargoWeight.Size = new System.Drawing.Size(151, 20);
            this.lblTotalCargoWeight.TabIndex = 47;
            this.lblTotalCargoWeight.Text = "Total Cargo Weight";
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.BackColor = System.Drawing.Color.Transparent;
            this.lblDestination.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDestination.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblDestination.Location = new System.Drawing.Point(43, 147);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(92, 20);
            this.lblDestination.TabIndex = 46;
            this.lblDestination.Text = "Destination";
            // 
            // lblCargoParcelAmount
            // 
            this.lblCargoParcelAmount.AutoSize = true;
            this.lblCargoParcelAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblCargoParcelAmount.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCargoParcelAmount.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblCargoParcelAmount.Location = new System.Drawing.Point(387, 103);
            this.lblCargoParcelAmount.Name = "lblCargoParcelAmount";
            this.lblCargoParcelAmount.Size = new System.Drawing.Size(164, 20);
            this.lblCargoParcelAmount.TabIndex = 44;
            this.lblCargoParcelAmount.Text = "Cargo Parcel Amount";
            // 
            // lblTotalCargoVolume
            // 
            this.lblTotalCargoVolume.AutoSize = true;
            this.lblTotalCargoVolume.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalCargoVolume.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalCargoVolume.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTotalCargoVolume.Location = new System.Drawing.Point(397, 147);
            this.lblTotalCargoVolume.Name = "lblTotalCargoVolume";
            this.lblTotalCargoVolume.Size = new System.Drawing.Size(154, 20);
            this.lblTotalCargoVolume.TabIndex = 42;
            this.lblTotalCargoVolume.Text = "Total Cargo Volume";
            // 
            // lblEstimatedDepartureDate
            // 
            this.lblEstimatedDepartureDate.AutoSize = true;
            this.lblEstimatedDepartureDate.BackColor = System.Drawing.Color.Transparent;
            this.lblEstimatedDepartureDate.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEstimatedDepartureDate.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblEstimatedDepartureDate.Location = new System.Drawing.Point(51, 262);
            this.lblEstimatedDepartureDate.Name = "lblEstimatedDepartureDate";
            this.lblEstimatedDepartureDate.Size = new System.Drawing.Size(197, 20);
            this.lblEstimatedDepartureDate.TabIndex = 41;
            this.lblEstimatedDepartureDate.Text = "Estimated Departure Date";
            // 
            // lblCargoName
            // 
            this.lblCargoName.AutoSize = true;
            this.lblCargoName.BackColor = System.Drawing.Color.Transparent;
            this.lblCargoName.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCargoName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblCargoName.Location = new System.Drawing.Point(34, 191);
            this.lblCargoName.Name = "lblCargoName";
            this.lblCargoName.Size = new System.Drawing.Size(100, 20);
            this.lblCargoName.TabIndex = 40;
            this.lblCargoName.Text = "Cargo Name";
            // 
            // lblEstimatedArrivalDate
            // 
            this.lblEstimatedArrivalDate.AutoSize = true;
            this.lblEstimatedArrivalDate.BackColor = System.Drawing.Color.Transparent;
            this.lblEstimatedArrivalDate.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEstimatedArrivalDate.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblEstimatedArrivalDate.Location = new System.Drawing.Point(78, 319);
            this.lblEstimatedArrivalDate.Name = "lblEstimatedArrivalDate";
            this.lblEstimatedArrivalDate.Size = new System.Drawing.Size(170, 20);
            this.lblEstimatedArrivalDate.TabIndex = 39;
            this.lblEstimatedArrivalDate.Text = "Estimated Arrival Date";
            // 
            // txtCargoName
            // 
            this.txtCargoName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtCargoName.Location = new System.Drawing.Point(137, 190);
            this.txtCargoName.Name = "txtCargoName";
            this.txtCargoName.Size = new System.Drawing.Size(207, 20);
            this.txtCargoName.TabIndex = 2;
            // 
            // txtCargoParcelAmount
            // 
            this.txtCargoParcelAmount.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtCargoParcelAmount.Location = new System.Drawing.Point(556, 104);
            this.txtCargoParcelAmount.Name = "txtCargoParcelAmount";
            this.txtCargoParcelAmount.Size = new System.Drawing.Size(206, 20);
            this.txtCargoParcelAmount.TabIndex = 3;
            // 
            // txtTotalCargoVolume
            // 
            this.txtTotalCargoVolume.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtTotalCargoVolume.Location = new System.Drawing.Point(556, 147);
            this.txtTotalCargoVolume.Name = "txtTotalCargoVolume";
            this.txtTotalCargoVolume.Size = new System.Drawing.Size(207, 20);
            this.txtTotalCargoVolume.TabIndex = 4;
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.BackColor = System.Drawing.Color.Transparent;
            this.lblSource.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSource.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblSource.Location = new System.Drawing.Point(71, 104);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(60, 20);
            this.lblSource.TabIndex = 34;
            this.lblSource.Text = "Source";
            // 
            // txtDestination
            // 
            this.txtDestination.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtDestination.Location = new System.Drawing.Point(137, 147);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.ReadOnly = true;
            this.txtDestination.Size = new System.Drawing.Size(207, 20);
            this.txtDestination.TabIndex = 1;
            // 
            // txtTotalCargoWeight
            // 
            this.txtTotalCargoWeight.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtTotalCargoWeight.Location = new System.Drawing.Point(556, 187);
            this.txtTotalCargoWeight.Name = "txtTotalCargoWeight";
            this.txtTotalCargoWeight.Size = new System.Drawing.Size(205, 20);
            this.txtTotalCargoWeight.TabIndex = 5;
            // 
            // txtSource
            // 
            this.txtSource.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtSource.Location = new System.Drawing.Point(137, 103);
            this.txtSource.Name = "txtSource";
            this.txtSource.ReadOnly = true;
            this.txtSource.Size = new System.Drawing.Size(207, 20);
            this.txtSource.TabIndex = 0;
            // 
            // dtpEstimatedDepartureDate
            // 
            this.dtpEstimatedDepartureDate.Location = new System.Drawing.Point(254, 262);
            this.dtpEstimatedDepartureDate.Name = "dtpEstimatedDepartureDate";
            this.dtpEstimatedDepartureDate.Size = new System.Drawing.Size(200, 20);
            this.dtpEstimatedDepartureDate.TabIndex = 6;
            // 
            // dtpEstimatedArrivalDate
            // 
            this.dtpEstimatedArrivalDate.Location = new System.Drawing.Point(254, 317);
            this.dtpEstimatedArrivalDate.Name = "dtpEstimatedArrivalDate";
            this.dtpEstimatedArrivalDate.Size = new System.Drawing.Size(200, 20);
            this.dtpEstimatedArrivalDate.TabIndex = 7;
            // 
            // lblCreateExpedition
            // 
            this.lblCreateExpedition.AutoSize = true;
            this.lblCreateExpedition.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCreateExpedition.ForeColor = System.Drawing.Color.White;
            this.lblCreateExpedition.Location = new System.Drawing.Point(283, 23);
            this.lblCreateExpedition.Name = "lblCreateExpedition";
            this.lblCreateExpedition.Size = new System.Drawing.Size(258, 39);
            this.lblCreateExpedition.TabIndex = 50;
            this.lblCreateExpedition.Text = "Create Expedition";
            // 
            // ExpeditionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCreateExpedition);
            this.Controls.Add(this.dtpEstimatedArrivalDate);
            this.Controls.Add(this.dtpEstimatedDepartureDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblTotalCargoWeight);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.lblCargoParcelAmount);
            this.Controls.Add(this.lblTotalCargoVolume);
            this.Controls.Add(this.lblEstimatedDepartureDate);
            this.Controls.Add(this.lblCargoName);
            this.Controls.Add(this.lblEstimatedArrivalDate);
            this.Controls.Add(this.txtCargoName);
            this.Controls.Add(this.txtCargoParcelAmount);
            this.Controls.Add(this.txtTotalCargoVolume);
            this.Controls.Add(this.lblSource);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.txtTotalCargoWeight);
            this.Controls.Add(this.txtSource);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExpeditionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Expedition Form";
            this.Load += new System.EventHandler(this.ExpeditionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblTotalCargoWeight;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label lblCargoParcelAmount;
        private System.Windows.Forms.Label lblTotalCargoVolume;
        private System.Windows.Forms.Label lblEstimatedDepartureDate;
        private System.Windows.Forms.Label lblCargoName;
        private System.Windows.Forms.Label lblEstimatedArrivalDate;
        private System.Windows.Forms.TextBox txtCargoName;
        private System.Windows.Forms.TextBox txtCargoParcelAmount;
        private System.Windows.Forms.TextBox txtTotalCargoVolume;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.TextBox txtTotalCargoWeight;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.DateTimePicker dtpEstimatedDepartureDate;
        private System.Windows.Forms.DateTimePicker dtpEstimatedArrivalDate;
        private System.Windows.Forms.Label lblCreateExpedition;
    }
}