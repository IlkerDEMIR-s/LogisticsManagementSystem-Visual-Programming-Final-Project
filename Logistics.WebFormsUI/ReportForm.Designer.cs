namespace Logistics.WebFormsUI
{
    partial class ReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.dgwExpedition = new System.Windows.Forms.DataGridView();
            this.btnHomePage = new System.Windows.Forms.Button();
            this.gbxProducts = new System.Windows.Forms.GroupBox();
            this.dgwOrders = new System.Windows.Forms.DataGridView();
            this.gbxExpeditions = new System.Windows.Forms.GroupBox();
            this.gbxSearchByDepotName = new System.Windows.Forms.GroupBox();
            this.pbxSearch = new System.Windows.Forms.PictureBox();
            this.txtSearchDepotName = new System.Windows.Forms.TextBox();
            this.lblSearchDepotName = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.gbxSearchByDate = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.gbxFrame = new System.Windows.Forms.GroupBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgwExpedition)).BeginInit();
            this.gbxProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOrders)).BeginInit();
            this.gbxExpeditions.SuspendLayout();
            this.gbxSearchByDepotName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSearch)).BeginInit();
            this.gbxSearchByDate.SuspendLayout();
            this.gbxFrame.SuspendLayout();
            this.menuStripBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwExpedition
            // 
            this.dgwExpedition.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgwExpedition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwExpedition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwExpedition.Location = new System.Drawing.Point(17, 28);
            this.dgwExpedition.Name = "dgwExpedition";
            this.dgwExpedition.ReadOnly = true;
            this.dgwExpedition.Size = new System.Drawing.Size(813, 108);
            this.dgwExpedition.TabIndex = 0;
            this.dgwExpedition.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgwExpedition_CellFormatting);
            // 
            // btnHomePage
            // 
            this.btnHomePage.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnHomePage.Image = ((System.Drawing.Image)(resources.GetObject("btnHomePage.Image")));
            this.btnHomePage.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHomePage.Location = new System.Drawing.Point(12, 27);
            this.btnHomePage.Name = "btnHomePage";
            this.btnHomePage.Size = new System.Drawing.Size(88, 67);
            this.btnHomePage.TabIndex = 0;
            this.btnHomePage.Text = "&Home Page";
            this.btnHomePage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHomePage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHomePage.UseVisualStyleBackColor = false;
            this.btnHomePage.Click += new System.EventHandler(this.btnHomePage_Click);
            // 
            // gbxProducts
            // 
            this.gbxProducts.BackColor = System.Drawing.Color.LightSteelBlue;
            this.gbxProducts.Controls.Add(this.dgwOrders);
            this.gbxProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxProducts.Location = new System.Drawing.Point(6, 19);
            this.gbxProducts.Name = "gbxProducts";
            this.gbxProducts.Size = new System.Drawing.Size(847, 152);
            this.gbxProducts.TabIndex = 0;
            this.gbxProducts.TabStop = false;
            this.gbxProducts.Text = "The products taken by the customers";
            // 
            // dgwOrders
            // 
            this.dgwOrders.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgwOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOrders.Location = new System.Drawing.Point(17, 28);
            this.dgwOrders.Name = "dgwOrders";
            this.dgwOrders.ReadOnly = true;
            this.dgwOrders.Size = new System.Drawing.Size(813, 108);
            this.dgwOrders.TabIndex = 0;
            this.dgwOrders.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgwOrders_CellFormatting);
            // 
            // gbxExpeditions
            // 
            this.gbxExpeditions.BackColor = System.Drawing.Color.LightSteelBlue;
            this.gbxExpeditions.Controls.Add(this.dgwExpedition);
            this.gbxExpeditions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxExpeditions.Location = new System.Drawing.Point(6, 177);
            this.gbxExpeditions.Name = "gbxExpeditions";
            this.gbxExpeditions.Size = new System.Drawing.Size(847, 152);
            this.gbxExpeditions.TabIndex = 1;
            this.gbxExpeditions.TabStop = false;
            this.gbxExpeditions.Text = "Expeditions";
            // 
            // gbxSearchByDepotName
            // 
            this.gbxSearchByDepotName.Controls.Add(this.pbxSearch);
            this.gbxSearchByDepotName.Controls.Add(this.txtSearchDepotName);
            this.gbxSearchByDepotName.Controls.Add(this.lblSearchDepotName);
            this.gbxSearchByDepotName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxSearchByDepotName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.gbxSearchByDepotName.Location = new System.Drawing.Point(127, 27);
            this.gbxSearchByDepotName.Name = "gbxSearchByDepotName";
            this.gbxSearchByDepotName.Size = new System.Drawing.Size(291, 78);
            this.gbxSearchByDepotName.TabIndex = 1;
            this.gbxSearchByDepotName.TabStop = false;
            this.gbxSearchByDepotName.Text = "Search by Depot Name";
            // 
            // pbxSearch
            // 
            this.pbxSearch.Image = ((System.Drawing.Image)(resources.GetObject("pbxSearch.Image")));
            this.pbxSearch.Location = new System.Drawing.Point(253, 27);
            this.pbxSearch.Name = "pbxSearch";
            this.pbxSearch.Size = new System.Drawing.Size(32, 29);
            this.pbxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSearch.TabIndex = 2;
            this.pbxSearch.TabStop = false;
            // 
            // txtSearchDepotName
            // 
            this.txtSearchDepotName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtSearchDepotName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearchDepotName.Location = new System.Drawing.Point(87, 35);
            this.txtSearchDepotName.Name = "txtSearchDepotName";
            this.txtSearchDepotName.Size = new System.Drawing.Size(160, 21);
            this.txtSearchDepotName.TabIndex = 0;
            this.txtSearchDepotName.TextChanged += new System.EventHandler(this.txtSearchDepotName_TextChanged);
            // 
            // lblSearchDepotName
            // 
            this.lblSearchDepotName.AutoSize = true;
            this.lblSearchDepotName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSearchDepotName.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblSearchDepotName.Location = new System.Drawing.Point(14, 38);
            this.lblSearchDepotName.Name = "lblSearchDepotName";
            this.lblSearchDepotName.Size = new System.Drawing.Size(67, 13);
            this.lblSearchDepotName.TabIndex = 0;
            this.lblSearchDepotName.Text = "Depot Name";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlText;
            this.dtpEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpEndDate.Location = new System.Drawing.Point(111, 48);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 21);
            this.dtpEndDate.TabIndex = 1;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlText;
            this.dtpStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpStartDate.Location = new System.Drawing.Point(111, 20);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 21);
            this.dtpStartDate.TabIndex = 0;
            // 
            // gbxSearchByDate
            // 
            this.gbxSearchByDate.Controls.Add(this.btnClear);
            this.gbxSearchByDate.Controls.Add(this.btnFilter);
            this.gbxSearchByDate.Controls.Add(this.lblEndDate);
            this.gbxSearchByDate.Controls.Add(this.lblStartDate);
            this.gbxSearchByDate.Controls.Add(this.dtpStartDate);
            this.gbxSearchByDate.Controls.Add(this.dtpEndDate);
            this.gbxSearchByDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxSearchByDate.ForeColor = System.Drawing.SystemColors.GrayText;
            this.gbxSearchByDate.Location = new System.Drawing.Point(424, 27);
            this.gbxSearchByDate.Name = "gbxSearchByDate";
            this.gbxSearchByDate.Size = new System.Drawing.Size(451, 78);
            this.gbxSearchByDate.TabIndex = 2;
            this.gbxSearchByDate.TabStop = false;
            this.gbxSearchByDate.Text = "Search by Date";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClear.Location = new System.Drawing.Point(349, 48);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFilter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFilter.Location = new System.Drawing.Point(349, 20);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 2;
            this.btnFilter.Text = "&Filter";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.BackColor = System.Drawing.Color.Transparent;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEndDate.ForeColor = System.Drawing.Color.Maroon;
            this.lblEndDate.Location = new System.Drawing.Point(39, 52);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(66, 15);
            this.lblEndDate.TabIndex = 20;
            this.lblEndDate.Text = "End Date";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.BackColor = System.Drawing.Color.Transparent;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStartDate.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblStartDate.Location = new System.Drawing.Point(34, 24);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(71, 15);
            this.lblStartDate.TabIndex = 19;
            this.lblStartDate.Text = "Start Date";
            // 
            // gbxFrame
            // 
            this.gbxFrame.Controls.Add(this.gbxProducts);
            this.gbxFrame.Controls.Add(this.gbxExpeditions);
            this.gbxFrame.Location = new System.Drawing.Point(12, 122);
            this.gbxFrame.Name = "gbxFrame";
            this.gbxFrame.Size = new System.Drawing.Size(863, 350);
            this.gbxFrame.TabIndex = 3;
            this.gbxFrame.TabStop = false;
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
            this.menuStripBar.Size = new System.Drawing.Size(882, 24);
            this.menuStripBar.TabIndex = 4;
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
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(882, 480);
            this.Controls.Add(this.menuStripBar);
            this.Controls.Add(this.gbxFrame);
            this.Controls.Add(this.gbxSearchByDate);
            this.Controls.Add(this.gbxSearchByDepotName);
            this.Controls.Add(this.btnHomePage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Form";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwExpedition)).EndInit();
            this.gbxProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwOrders)).EndInit();
            this.gbxExpeditions.ResumeLayout(false);
            this.gbxSearchByDepotName.ResumeLayout(false);
            this.gbxSearchByDepotName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSearch)).EndInit();
            this.gbxSearchByDate.ResumeLayout(false);
            this.gbxSearchByDate.PerformLayout();
            this.gbxFrame.ResumeLayout(false);
            this.menuStripBar.ResumeLayout(false);
            this.menuStripBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwExpedition;
        private System.Windows.Forms.Button btnHomePage;
        private System.Windows.Forms.GroupBox gbxProducts;
        private System.Windows.Forms.GroupBox gbxExpeditions;
        private System.Windows.Forms.DataGridView dgwOrders;
        private System.Windows.Forms.GroupBox gbxSearchByDepotName;
        private System.Windows.Forms.PictureBox pbxSearch;
        private System.Windows.Forms.TextBox txtSearchDepotName;
        private System.Windows.Forms.Label lblSearchDepotName;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.GroupBox gbxSearchByDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.GroupBox gbxFrame;
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