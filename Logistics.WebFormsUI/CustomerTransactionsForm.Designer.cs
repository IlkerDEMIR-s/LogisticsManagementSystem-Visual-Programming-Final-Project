namespace Logistics.WebFormsUI
{
    partial class CustomerTransactionsForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerTransactionsForm));
            this.dgwCustomers = new System.Windows.Forms.DataGridView();
            this.btnHomePage = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.toolTipSearchCustomerName = new System.Windows.Forms.ToolTip(this.components);
            this.cbxCustomers = new System.Windows.Forms.ComboBox();
            this.lblCustomers = new System.Windows.Forms.Label();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.gbxDelete = new System.Windows.Forms.GroupBox();
            this.cbxDeleteCustomer = new System.Windows.Forms.ComboBox();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgwCustomers)).BeginInit();
            this.gbxDelete.SuspendLayout();
            this.menuStripBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwCustomers
            // 
            this.dgwCustomers.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgwCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCustomers.Location = new System.Drawing.Point(29, 117);
            this.dgwCustomers.Name = "dgwCustomers";
            this.dgwCustomers.ReadOnly = true;
            this.dgwCustomers.Size = new System.Drawing.Size(833, 120);
            this.dgwCustomers.TabIndex = 0;
            this.dgwCustomers.TabStop = false;
            // 
            // btnHomePage
            // 
            this.btnHomePage.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnHomePage.Image = ((System.Drawing.Image)(resources.GetObject("btnHomePage.Image")));
            this.btnHomePage.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHomePage.Location = new System.Drawing.Point(12, 26);
            this.btnHomePage.Name = "btnHomePage";
            this.btnHomePage.Size = new System.Drawing.Size(88, 67);
            this.btnHomePage.TabIndex = 0;
            this.btnHomePage.Text = "&Home Page";
            this.btnHomePage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHomePage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHomePage.UseVisualStyleBackColor = false;
            this.btnHomePage.Click += new System.EventHandler(this.btnHomePage_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDeleteCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteCustomer.Image")));
            this.btnDeleteCustomer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeleteCustomer.Location = new System.Drawing.Point(528, 39);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(216, 62);
            this.btnDeleteCustomer.TabIndex = 0;
            this.btnDeleteCustomer.Text = "&Delete Customer";
            this.btnDeleteCustomer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeleteCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeleteCustomer.UseVisualStyleBackColor = false;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // cbxCustomers
            // 
            this.cbxCustomers.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cbxCustomers.FormattingEnabled = true;
            this.cbxCustomers.Location = new System.Drawing.Point(229, 55);
            this.cbxCustomers.Name = "cbxCustomers";
            this.cbxCustomers.Size = new System.Drawing.Size(219, 21);
            this.cbxCustomers.TabIndex = 1;
            this.cbxCustomers.SelectedValueChanged += new System.EventHandler(this.cbxCustomers_SelectedValueChanged);
            // 
            // lblCustomers
            // 
            this.lblCustomers.AutoSize = true;
            this.lblCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCustomers.Location = new System.Drawing.Point(157, 58);
            this.lblCustomers.Name = "lblCustomers";
            this.lblCustomers.Size = new System.Drawing.Size(66, 15);
            this.lblCustomers.TabIndex = 7;
            this.lblCustomers.Text = "Customers";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAddCustomer.Location = new System.Drawing.Point(454, 55);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(92, 23);
            this.btnAddCustomer.TabIndex = 2;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // gbxDelete
            // 
            this.gbxDelete.Controls.Add(this.cbxDeleteCustomer);
            this.gbxDelete.Controls.Add(this.btnDeleteCustomer);
            this.gbxDelete.Location = new System.Drawing.Point(29, 255);
            this.gbxDelete.Name = "gbxDelete";
            this.gbxDelete.Size = new System.Drawing.Size(833, 137);
            this.gbxDelete.TabIndex = 3;
            this.gbxDelete.TabStop = false;
            this.gbxDelete.Text = "Delete Customer ";
            // 
            // cbxDeleteCustomer
            // 
            this.cbxDeleteCustomer.BackColor = System.Drawing.Color.Brown;
            this.cbxDeleteCustomer.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbxDeleteCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxDeleteCustomer.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.cbxDeleteCustomer.FormattingEnabled = true;
            this.cbxDeleteCustomer.Location = new System.Drawing.Point(92, 55);
            this.cbxDeleteCustomer.Name = "cbxDeleteCustomer";
            this.cbxDeleteCustomer.Size = new System.Drawing.Size(271, 24);
            this.cbxDeleteCustomer.TabIndex = 1;
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
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
            this.menuStripBar.Size = new System.Drawing.Size(886, 24);
            this.menuStripBar.TabIndex = 8;
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
            // CustomerTransactionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(886, 409);
            this.Controls.Add(this.menuStripBar);
            this.Controls.Add(this.gbxDelete);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.lblCustomers);
            this.Controls.Add(this.cbxCustomers);
            this.Controls.Add(this.btnHomePage);
            this.Controls.Add(this.dgwCustomers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomerTransactionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Transactions Page";
            this.Load += new System.EventHandler(this.CustomerTransactionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCustomers)).EndInit();
            this.gbxDelete.ResumeLayout(false);
            this.menuStripBar.ResumeLayout(false);
            this.menuStripBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgwCustomers;
        private System.Windows.Forms.Button btnHomePage;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.ToolTip toolTipSearchCustomerName;
        private System.Windows.Forms.ComboBox cbxCustomers;
        private System.Windows.Forms.Label lblCustomers;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.GroupBox gbxDelete;
        private System.Windows.Forms.ComboBox cbxDeleteCustomer;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
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