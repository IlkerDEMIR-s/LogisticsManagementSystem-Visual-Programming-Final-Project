namespace Logistics.WebFormsUI
{
    partial class OrderManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderManagementForm));
            this.dgwOrders = new System.Windows.Forms.DataGridView();
            this.btnHomePage = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.cbxUpdateStatus = new System.Windows.Forms.ComboBox();
            this.btnUpdateStatus = new System.Windows.Forms.Button();
            this.btnExpeditionFilter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxExpeditionStatus = new System.Windows.Forms.ComboBox();
            this.dgwExpedition = new System.Windows.Forms.DataGridView();
            this.gbxOrderTransactions = new System.Windows.Forms.GroupBox();
            this.gbxExpeditionOperations = new System.Windows.Forms.GroupBox();
            this.dtpActualDepartureDate = new System.Windows.Forms.DateTimePicker();
            this.txtCargoName = new System.Windows.Forms.TextBox();
            this.btnActualDepartureDate = new System.Windows.Forms.Button();
            this.menuStripBar = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemWithWebSite = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemTips = new System.Windows.Forms.ToolStripMenuItem();
            this.dffToolStripMenuItemGeneral = new System.Windows.Forms.ToolStripMenuItem();
            this.ddfToolStripMenuItemSpecial = new System.Windows.Forms.ToolStripMenuItem();
            this.accountTransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwExpedition)).BeginInit();
            this.gbxOrderTransactions.SuspendLayout();
            this.gbxExpeditionOperations.SuspendLayout();
            this.menuStripBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwOrders
            // 
            this.dgwOrders.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgwOrders.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgwOrders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgwOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOrders.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgwOrders.Location = new System.Drawing.Point(6, 63);
            this.dgwOrders.Name = "dgwOrders";
            this.dgwOrders.Size = new System.Drawing.Size(884, 132);
            this.dgwOrders.TabIndex = 0;
            this.dgwOrders.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgwOrders_CellFormatting);
            // 
            // btnHomePage
            // 
            this.btnHomePage.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnHomePage.Image = ((System.Drawing.Image)(resources.GetObject("btnHomePage.Image")));
            this.btnHomePage.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHomePage.Location = new System.Drawing.Point(12, 27);
            this.btnHomePage.Name = "btnHomePage";
            this.btnHomePage.Size = new System.Drawing.Size(88, 63);
            this.btnHomePage.TabIndex = 0;
            this.btnHomePage.Text = "&Home Page";
            this.btnHomePage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHomePage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHomePage.UseVisualStyleBackColor = false;
            this.btnHomePage.Click += new System.EventHandler(this.btnHomePage_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFilter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFilter.Location = new System.Drawing.Point(221, 19);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(92, 23);
            this.btnFilter.TabIndex = 1;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStatus.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblStatus.Location = new System.Drawing.Point(12, 22);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(44, 16);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Status";
            // 
            // cbxStatus
            // 
            this.cbxStatus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cbxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Location = new System.Drawing.Point(59, 19);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(156, 23);
            this.cbxStatus.TabIndex = 0;
            // 
            // cbxUpdateStatus
            // 
            this.cbxUpdateStatus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cbxUpdateStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxUpdateStatus.FormattingEnabled = true;
            this.cbxUpdateStatus.Items.AddRange(new object[] {
            "Confirm",
            "Reject"});
            this.cbxUpdateStatus.Location = new System.Drawing.Point(605, 19);
            this.cbxUpdateStatus.Name = "cbxUpdateStatus";
            this.cbxUpdateStatus.Size = new System.Drawing.Size(141, 23);
            this.cbxUpdateStatus.TabIndex = 2;
            // 
            // btnUpdateStatus
            // 
            this.btnUpdateStatus.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnUpdateStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateStatus.ForeColor = System.Drawing.Color.White;
            this.btnUpdateStatus.Location = new System.Drawing.Point(762, 13);
            this.btnUpdateStatus.Name = "btnUpdateStatus";
            this.btnUpdateStatus.Size = new System.Drawing.Size(122, 34);
            this.btnUpdateStatus.TabIndex = 3;
            this.btnUpdateStatus.Text = "&Update Status";
            this.btnUpdateStatus.UseVisualStyleBackColor = false;
            this.btnUpdateStatus.Click += new System.EventHandler(this.btnUpdateStatus_Click);
            // 
            // btnExpeditionFilter
            // 
            this.btnExpeditionFilter.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnExpeditionFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExpeditionFilter.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnExpeditionFilter.Location = new System.Drawing.Point(221, 21);
            this.btnExpeditionFilter.Name = "btnExpeditionFilter";
            this.btnExpeditionFilter.Size = new System.Drawing.Size(92, 23);
            this.btnExpeditionFilter.TabIndex = 1;
            this.btnExpeditionFilter.Text = "Filter";
            this.btnExpeditionFilter.UseVisualStyleBackColor = false;
            this.btnExpeditionFilter.Click += new System.EventHandler(this.btnExpeditionFilter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Status";
            // 
            // cbxExpeditionStatus
            // 
            this.cbxExpeditionStatus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cbxExpeditionStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxExpeditionStatus.FormattingEnabled = true;
            this.cbxExpeditionStatus.Location = new System.Drawing.Point(59, 21);
            this.cbxExpeditionStatus.Name = "cbxExpeditionStatus";
            this.cbxExpeditionStatus.Size = new System.Drawing.Size(156, 23);
            this.cbxExpeditionStatus.TabIndex = 0;
            // 
            // dgwExpedition
            // 
            this.dgwExpedition.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgwExpedition.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgwExpedition.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgwExpedition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwExpedition.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgwExpedition.Location = new System.Drawing.Point(6, 63);
            this.dgwExpedition.Name = "dgwExpedition";
            this.dgwExpedition.Size = new System.Drawing.Size(884, 131);
            this.dgwExpedition.TabIndex = 17;
            this.dgwExpedition.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwExpedition_CellClick);
            this.dgwExpedition.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgwExpedition_CellFormatting);
            // 
            // gbxOrderTransactions
            // 
            this.gbxOrderTransactions.BackColor = System.Drawing.Color.LightSteelBlue;
            this.gbxOrderTransactions.Controls.Add(this.dgwOrders);
            this.gbxOrderTransactions.Controls.Add(this.cbxStatus);
            this.gbxOrderTransactions.Controls.Add(this.btnFilter);
            this.gbxOrderTransactions.Controls.Add(this.btnUpdateStatus);
            this.gbxOrderTransactions.Controls.Add(this.lblStatus);
            this.gbxOrderTransactions.Controls.Add(this.cbxUpdateStatus);
            this.gbxOrderTransactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxOrderTransactions.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.gbxOrderTransactions.Location = new System.Drawing.Point(12, 96);
            this.gbxOrderTransactions.Name = "gbxOrderTransactions";
            this.gbxOrderTransactions.Size = new System.Drawing.Size(901, 210);
            this.gbxOrderTransactions.TabIndex = 1;
            this.gbxOrderTransactions.TabStop = false;
            this.gbxOrderTransactions.Text = "Order Transactions";
            // 
            // gbxExpeditionOperations
            // 
            this.gbxExpeditionOperations.BackColor = System.Drawing.Color.LightSteelBlue;
            this.gbxExpeditionOperations.Controls.Add(this.dtpActualDepartureDate);
            this.gbxExpeditionOperations.Controls.Add(this.txtCargoName);
            this.gbxExpeditionOperations.Controls.Add(this.btnActualDepartureDate);
            this.gbxExpeditionOperations.Controls.Add(this.dgwExpedition);
            this.gbxExpeditionOperations.Controls.Add(this.cbxExpeditionStatus);
            this.gbxExpeditionOperations.Controls.Add(this.label1);
            this.gbxExpeditionOperations.Controls.Add(this.btnExpeditionFilter);
            this.gbxExpeditionOperations.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxExpeditionOperations.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.gbxExpeditionOperations.Location = new System.Drawing.Point(12, 323);
            this.gbxExpeditionOperations.Name = "gbxExpeditionOperations";
            this.gbxExpeditionOperations.Size = new System.Drawing.Size(901, 206);
            this.gbxExpeditionOperations.TabIndex = 2;
            this.gbxExpeditionOperations.TabStop = false;
            this.gbxExpeditionOperations.Text = "Expedition Operations";
            // 
            // dtpActualDepartureDate
            // 
            this.dtpActualDepartureDate.Location = new System.Drawing.Point(553, 37);
            this.dtpActualDepartureDate.Name = "dtpActualDepartureDate";
            this.dtpActualDepartureDate.Size = new System.Drawing.Size(200, 20);
            this.dtpActualDepartureDate.TabIndex = 2;
            // 
            // txtCargoName
            // 
            this.txtCargoName.Location = new System.Drawing.Point(567, 11);
            this.txtCargoName.Name = "txtCargoName";
            this.txtCargoName.ReadOnly = true;
            this.txtCargoName.Size = new System.Drawing.Size(170, 20);
            this.txtCargoName.TabIndex = 18;
            // 
            // btnActualDepartureDate
            // 
            this.btnActualDepartureDate.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnActualDepartureDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualDepartureDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnActualDepartureDate.ForeColor = System.Drawing.Color.White;
            this.btnActualDepartureDate.Location = new System.Drawing.Point(762, 11);
            this.btnActualDepartureDate.Name = "btnActualDepartureDate";
            this.btnActualDepartureDate.Size = new System.Drawing.Size(122, 46);
            this.btnActualDepartureDate.TabIndex = 3;
            this.btnActualDepartureDate.Text = "&Add Actual Departure Date";
            this.btnActualDepartureDate.UseVisualStyleBackColor = false;
            this.btnActualDepartureDate.Click += new System.EventHandler(this.btnActualDepartureDate_Click);
            // 
            // menuStripBar
            // 
            this.menuStripBar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStripBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItemAbout,
            this.helpToolStripMenuItemHelp,
            this.accountTransactionsToolStripMenuItem});
            this.menuStripBar.Location = new System.Drawing.Point(0, 0);
            this.menuStripBar.Name = "menuStripBar";
            this.menuStripBar.Size = new System.Drawing.Size(924, 24);
            this.menuStripBar.TabIndex = 3;
            this.menuStripBar.Text = "menuStrip";
            // 
            // helpToolStripMenuItemAbout
            // 
            this.helpToolStripMenuItemAbout.BackColor = System.Drawing.Color.LightBlue;
            this.helpToolStripMenuItemAbout.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.helpToolStripMenuItemAbout.Name = "helpToolStripMenuItemAbout";
            this.helpToolStripMenuItemAbout.Size = new System.Drawing.Size(52, 20);
            this.helpToolStripMenuItemAbout.Text = "About";
            this.helpToolStripMenuItemAbout.Click += new System.EventHandler(this.helpToolStripMenuItemAbout_Click);
            // 
            // helpToolStripMenuItemHelp
            // 
            this.helpToolStripMenuItemHelp.BackColor = System.Drawing.Color.LightBlue;
            this.helpToolStripMenuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemWithWebSite,
            this.toolStripSeparator1,
            this.toolStripMenuItemTips});
            this.helpToolStripMenuItemHelp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.helpToolStripMenuItemHelp.Name = "helpToolStripMenuItemHelp";
            this.helpToolStripMenuItemHelp.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItemHelp.Text = "Help";
            // 
            // toolStripMenuItemWithWebSite
            // 
            this.toolStripMenuItemWithWebSite.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemWithWebSite.Image")));
            this.toolStripMenuItemWithWebSite.Name = "toolStripMenuItemWithWebSite";
            this.toolStripMenuItemWithWebSite.Size = new System.Drawing.Size(114, 22);
            this.toolStripMenuItemWithWebSite.Text = "Tutorial";
            this.toolStripMenuItemWithWebSite.Click += new System.EventHandler(this.toolStripMenuItemWithWebSite_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(111, 6);
            // 
            // toolStripMenuItemTips
            // 
            this.toolStripMenuItemTips.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dffToolStripMenuItemGeneral,
            this.ddfToolStripMenuItemSpecial});
            this.toolStripMenuItemTips.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemTips.Image")));
            this.toolStripMenuItemTips.Name = "toolStripMenuItemTips";
            this.toolStripMenuItemTips.Size = new System.Drawing.Size(114, 22);
            this.toolStripMenuItemTips.Text = "Tips";
            // 
            // dffToolStripMenuItemGeneral
            // 
            this.dffToolStripMenuItemGeneral.Name = "dffToolStripMenuItemGeneral";
            this.dffToolStripMenuItemGeneral.Size = new System.Drawing.Size(138, 22);
            this.dffToolStripMenuItemGeneral.Text = "General Tips";
            this.dffToolStripMenuItemGeneral.Click += new System.EventHandler(this.dffToolStripMenuItemGeneral_Click);
            // 
            // ddfToolStripMenuItemSpecial
            // 
            this.ddfToolStripMenuItemSpecial.Name = "ddfToolStripMenuItemSpecial";
            this.ddfToolStripMenuItemSpecial.Size = new System.Drawing.Size(138, 22);
            this.ddfToolStripMenuItemSpecial.Text = "Special Tips";
            this.ddfToolStripMenuItemSpecial.Click += new System.EventHandler(this.ddfToolStripMenuItemSpecial_Click);
            // 
            // accountTransactionsToolStripMenuItem
            // 
            this.accountTransactionsToolStripMenuItem.BackColor = System.Drawing.Color.LightBlue;
            this.accountTransactionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem});
            this.accountTransactionsToolStripMenuItem.Name = "accountTransactionsToolStripMenuItem";
            this.accountTransactionsToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.accountTransactionsToolStripMenuItem.Text = "Account transactions";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("changePasswordToolStripMenuItem.Image")));
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.changePasswordToolStripMenuItem.Text = "Change password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click_1);
            // 
            // OrderManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(924, 545);
            this.Controls.Add(this.menuStripBar);
            this.Controls.Add(this.gbxExpeditionOperations);
            this.Controls.Add(this.gbxOrderTransactions);
            this.Controls.Add(this.btnHomePage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrderManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Management Form";
            this.Load += new System.EventHandler(this.OrderManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwExpedition)).EndInit();
            this.gbxOrderTransactions.ResumeLayout(false);
            this.gbxOrderTransactions.PerformLayout();
            this.gbxExpeditionOperations.ResumeLayout(false);
            this.gbxExpeditionOperations.PerformLayout();
            this.menuStripBar.ResumeLayout(false);
            this.menuStripBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwOrders;
        private System.Windows.Forms.Button btnHomePage;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.ComboBox cbxUpdateStatus;
        private System.Windows.Forms.Button btnUpdateStatus;
        private System.Windows.Forms.Button btnExpeditionFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxExpeditionStatus;
        private System.Windows.Forms.DataGridView dgwExpedition;
        private System.Windows.Forms.GroupBox gbxOrderTransactions;
        private System.Windows.Forms.GroupBox gbxExpeditionOperations;
        private System.Windows.Forms.Button btnActualDepartureDate;
        private System.Windows.Forms.TextBox txtCargoName;
        private System.Windows.Forms.DateTimePicker dtpActualDepartureDate;
        private System.Windows.Forms.MenuStrip menuStripBar;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItemAbout;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemWithWebSite;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTips;
        private System.Windows.Forms.ToolStripMenuItem dffToolStripMenuItemGeneral;
        private System.Windows.Forms.ToolStripMenuItem ddfToolStripMenuItemSpecial;
        private System.Windows.Forms.ToolStripMenuItem accountTransactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
    }
}