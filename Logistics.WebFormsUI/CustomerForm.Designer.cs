﻿namespace Logistics.WebFormsUI
{
    partial class CustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.pbxSearch = new System.Windows.Forms.PictureBox();
            this.txtSearchDepotName = new System.Windows.Forms.TextBox();
            this.lblSearchDepotName = new System.Windows.Forms.Label();
            this.dgwDepots = new System.Windows.Forms.DataGridView();
            this.gbxSend = new System.Windows.Forms.GroupBox();
            this.lblStockInputSecondLine = new System.Windows.Forms.Label();
            this.lblDepotName = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtProductNameDisplay = new System.Windows.Forms.TextBox();
            this.txtStockInput = new System.Windows.Forms.TextBox();
            this.lblStockInput = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtDepotNameDisplay = new System.Windows.Forms.TextBox();
            this.gbxFactoryInfo = new System.Windows.Forms.GroupBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtContactName = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtContactTitle = new System.Windows.Forms.TextBox();
            this.txtFactoryType = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.RichTextBox();
            this.txtHomePage = new System.Windows.Forms.RichTextBox();
            this.lblFactoryType = new System.Windows.Forms.Label();
            this.lblHomePage = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblContactName = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblContactTitle = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.toolTipSearchDepotName = new System.Windows.Forms.ToolTip(this.components);
            this.dgwOwnDepot = new System.Windows.Forms.DataGridView();
            this.btnDepotOperations = new System.Windows.Forms.Button();
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
            this.btnMyOrders = new System.Windows.Forms.Button();
            this.gbxFrame = new System.Windows.Forms.GroupBox();
            this.gbxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDepots)).BeginInit();
            this.gbxSend.SuspendLayout();
            this.gbxFactoryInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOwnDepot)).BeginInit();
            this.menuStripBar.SuspendLayout();
            this.gbxFrame.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogOut.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(698, 529);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(129, 39);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "&Log Out";
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(833, 529);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(129, 39);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gbxSearch
            // 
            this.gbxSearch.Controls.Add(this.btnClear);
            this.gbxSearch.Controls.Add(this.btnFilter);
            this.gbxSearch.Controls.Add(this.pbxSearch);
            this.gbxSearch.Controls.Add(this.txtSearchDepotName);
            this.gbxSearch.Controls.Add(this.lblSearchDepotName);
            this.gbxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxSearch.ForeColor = System.Drawing.SystemColors.GrayText;
            this.gbxSearch.Location = new System.Drawing.Point(323, 27);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Size = new System.Drawing.Size(639, 46);
            this.gbxSearch.TabIndex = 0;
            this.gbxSearch.TabStop = false;
            this.gbxSearch.Text = "Search or Filter";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClear.Location = new System.Drawing.Point(547, 15);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
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
            this.btnFilter.Location = new System.Drawing.Point(466, 15);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 1;
            this.btnFilter.Text = "&Filter";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // pbxSearch
            // 
            this.pbxSearch.Image = ((System.Drawing.Image)(resources.GetObject("pbxSearch.Image")));
            this.pbxSearch.Location = new System.Drawing.Point(294, 11);
            this.pbxSearch.Name = "pbxSearch";
            this.pbxSearch.Size = new System.Drawing.Size(32, 29);
            this.pbxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSearch.TabIndex = 28;
            this.pbxSearch.TabStop = false;
            // 
            // txtSearchDepotName
            // 
            this.txtSearchDepotName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtSearchDepotName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearchDepotName.Location = new System.Drawing.Point(87, 20);
            this.txtSearchDepotName.Name = "txtSearchDepotName";
            this.txtSearchDepotName.Size = new System.Drawing.Size(201, 21);
            this.txtSearchDepotName.TabIndex = 0;
            this.toolTipSearchDepotName.SetToolTip(this.txtSearchDepotName, "Enter the name of the depot you want to find.\r\n");
            this.txtSearchDepotName.TextChanged += new System.EventHandler(this.txtSearchDepotName_TextChanged);
            // 
            // lblSearchDepotName
            // 
            this.lblSearchDepotName.AutoSize = true;
            this.lblSearchDepotName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSearchDepotName.ForeColor = System.Drawing.Color.Black;
            this.lblSearchDepotName.Location = new System.Drawing.Point(14, 25);
            this.lblSearchDepotName.Name = "lblSearchDepotName";
            this.lblSearchDepotName.Size = new System.Drawing.Size(67, 13);
            this.lblSearchDepotName.TabIndex = 0;
            this.lblSearchDepotName.Text = "Depot Name";
            // 
            // dgwDepots
            // 
            this.dgwDepots.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgwDepots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDepots.Location = new System.Drawing.Point(17, 18);
            this.dgwDepots.Name = "dgwDepots";
            this.dgwDepots.ReadOnly = true;
            this.dgwDepots.Size = new System.Drawing.Size(606, 172);
            this.dgwDepots.TabIndex = 23;
            this.dgwDepots.TabStop = false;
            this.dgwDepots.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwDepots_CellClick);
            this.dgwDepots.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgwDepots_CellFormatting);
            // 
            // gbxSend
            // 
            this.gbxSend.Controls.Add(this.lblStockInputSecondLine);
            this.gbxSend.Controls.Add(this.lblDepotName);
            this.gbxSend.Controls.Add(this.btnSubmit);
            this.gbxSend.Controls.Add(this.txtProductNameDisplay);
            this.gbxSend.Controls.Add(this.txtStockInput);
            this.gbxSend.Controls.Add(this.lblStockInput);
            this.gbxSend.Controls.Add(this.lblProductName);
            this.gbxSend.Controls.Add(this.txtDepotNameDisplay);
            this.gbxSend.Location = new System.Drawing.Point(17, 190);
            this.gbxSend.Name = "gbxSend";
            this.gbxSend.Size = new System.Drawing.Size(606, 117);
            this.gbxSend.TabIndex = 0;
            this.gbxSend.TabStop = false;
            // 
            // lblStockInputSecondLine
            // 
            this.lblStockInputSecondLine.AutoSize = true;
            this.lblStockInputSecondLine.Location = new System.Drawing.Point(333, 25);
            this.lblStockInputSecondLine.Name = "lblStockInputSecondLine";
            this.lblStockInputSecondLine.Size = new System.Drawing.Size(159, 13);
            this.lblStockInputSecondLine.TabIndex = 19;
            this.lblStockInputSecondLine.Text = "You want to take from the depot";
            // 
            // lblDepotName
            // 
            this.lblDepotName.AutoSize = true;
            this.lblDepotName.Location = new System.Drawing.Point(40, 34);
            this.lblDepotName.Name = "lblDepotName";
            this.lblDepotName.Size = new System.Drawing.Size(64, 13);
            this.lblDepotName.TabIndex = 16;
            this.lblDepotName.Text = "DepotName";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.SlateBlue;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubmit.Location = new System.Drawing.Point(356, 69);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(115, 42);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "&Request";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // txtProductNameDisplay
            // 
            this.txtProductNameDisplay.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtProductNameDisplay.Location = new System.Drawing.Point(110, 69);
            this.txtProductNameDisplay.Name = "txtProductNameDisplay";
            this.txtProductNameDisplay.ReadOnly = true;
            this.txtProductNameDisplay.Size = new System.Drawing.Size(159, 20);
            this.txtProductNameDisplay.TabIndex = 1;
            this.txtProductNameDisplay.TabStop = false;
            // 
            // txtStockInput
            // 
            this.txtStockInput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtStockInput.Location = new System.Drawing.Point(320, 43);
            this.txtStockInput.Name = "txtStockInput";
            this.txtStockInput.Size = new System.Drawing.Size(172, 20);
            this.txtStockInput.TabIndex = 0;
            // 
            // lblStockInput
            // 
            this.lblStockInput.AutoSize = true;
            this.lblStockInput.Location = new System.Drawing.Point(342, 12);
            this.lblStockInput.Name = "lblStockInput";
            this.lblStockInput.Size = new System.Drawing.Size(129, 13);
            this.lblStockInput.TabIndex = 2;
            this.lblStockInput.Text = "Enter the amount of stock";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(32, 75);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(72, 13);
            this.lblProductName.TabIndex = 17;
            this.lblProductName.Text = "ProductName";
            // 
            // txtDepotNameDisplay
            // 
            this.txtDepotNameDisplay.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtDepotNameDisplay.Location = new System.Drawing.Point(110, 31);
            this.txtDepotNameDisplay.Name = "txtDepotNameDisplay";
            this.txtDepotNameDisplay.ReadOnly = true;
            this.txtDepotNameDisplay.Size = new System.Drawing.Size(159, 20);
            this.txtDepotNameDisplay.TabIndex = 0;
            this.txtDepotNameDisplay.TabStop = false;
            // 
            // gbxFactoryInfo
            // 
            this.gbxFactoryInfo.BackColor = System.Drawing.Color.Transparent;
            this.gbxFactoryInfo.Controls.Add(this.txtCompanyName);
            this.gbxFactoryInfo.Controls.Add(this.txtContactName);
            this.gbxFactoryInfo.Controls.Add(this.txtCity);
            this.gbxFactoryInfo.Controls.Add(this.txtCountry);
            this.gbxFactoryInfo.Controls.Add(this.txtPhone);
            this.gbxFactoryInfo.Controls.Add(this.txtContactTitle);
            this.gbxFactoryInfo.Controls.Add(this.txtFactoryType);
            this.gbxFactoryInfo.Controls.Add(this.txtAddress);
            this.gbxFactoryInfo.Controls.Add(this.txtHomePage);
            this.gbxFactoryInfo.Controls.Add(this.lblFactoryType);
            this.gbxFactoryInfo.Controls.Add(this.lblHomePage);
            this.gbxFactoryInfo.Controls.Add(this.lblCompanyName);
            this.gbxFactoryInfo.Controls.Add(this.lblPhone);
            this.gbxFactoryInfo.Controls.Add(this.lblContactName);
            this.gbxFactoryInfo.Controls.Add(this.lblCountry);
            this.gbxFactoryInfo.Controls.Add(this.lblContactTitle);
            this.gbxFactoryInfo.Controls.Add(this.lblCity);
            this.gbxFactoryInfo.Controls.Add(this.lblAddress);
            this.gbxFactoryInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxFactoryInfo.ForeColor = System.Drawing.SystemColors.GrayText;
            this.gbxFactoryInfo.Location = new System.Drawing.Point(12, 27);
            this.gbxFactoryInfo.Name = "gbxFactoryInfo";
            this.gbxFactoryInfo.Size = new System.Drawing.Size(305, 341);
            this.gbxFactoryInfo.TabIndex = 27;
            this.gbxFactoryInfo.TabStop = false;
            this.gbxFactoryInfo.Text = "Factory Info";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCompanyName.Location = new System.Drawing.Point(125, 70);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.ReadOnly = true;
            this.txtCompanyName.Size = new System.Drawing.Size(172, 21);
            this.txtCompanyName.TabIndex = 29;
            this.txtCompanyName.TabStop = false;
            // 
            // txtContactName
            // 
            this.txtContactName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtContactName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtContactName.Location = new System.Drawing.Point(111, 104);
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.ReadOnly = true;
            this.txtContactName.Size = new System.Drawing.Size(172, 21);
            this.txtContactName.TabIndex = 28;
            this.txtContactName.TabStop = false;
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCity.Location = new System.Drawing.Point(61, 208);
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(172, 21);
            this.txtCity.TabIndex = 26;
            this.txtCity.TabStop = false;
            // 
            // txtCountry
            // 
            this.txtCountry.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCountry.Location = new System.Drawing.Point(84, 232);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.ReadOnly = true;
            this.txtCountry.Size = new System.Drawing.Size(172, 21);
            this.txtCountry.TabIndex = 25;
            this.txtCountry.TabStop = false;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPhone.Location = new System.Drawing.Point(72, 258);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(172, 21);
            this.txtPhone.TabIndex = 24;
            this.txtPhone.TabStop = false;
            // 
            // txtContactTitle
            // 
            this.txtContactTitle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtContactTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtContactTitle.Location = new System.Drawing.Point(111, 130);
            this.txtContactTitle.Name = "txtContactTitle";
            this.txtContactTitle.ReadOnly = true;
            this.txtContactTitle.Size = new System.Drawing.Size(172, 21);
            this.txtContactTitle.TabIndex = 22;
            this.txtContactTitle.TabStop = false;
            // 
            // txtFactoryType
            // 
            this.txtFactoryType.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtFactoryType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFactoryType.Location = new System.Drawing.Point(111, 36);
            this.txtFactoryType.Name = "txtFactoryType";
            this.txtFactoryType.ReadOnly = true;
            this.txtFactoryType.Size = new System.Drawing.Size(172, 21);
            this.txtFactoryType.TabIndex = 21;
            this.txtFactoryType.TabStop = false;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAddress.Location = new System.Drawing.Point(84, 162);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(213, 40);
            this.txtAddress.TabIndex = 13;
            this.txtAddress.TabStop = false;
            this.txtAddress.Text = "";
            // 
            // txtHomePage
            // 
            this.txtHomePage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtHomePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHomePage.Location = new System.Drawing.Point(96, 286);
            this.txtHomePage.Name = "txtHomePage";
            this.txtHomePage.ReadOnly = true;
            this.txtHomePage.Size = new System.Drawing.Size(201, 45);
            this.txtHomePage.TabIndex = 12;
            this.txtHomePage.TabStop = false;
            this.txtHomePage.Text = "";
            // 
            // lblFactoryType
            // 
            this.lblFactoryType.AutoSize = true;
            this.lblFactoryType.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFactoryType.ForeColor = System.Drawing.Color.Navy;
            this.lblFactoryType.Location = new System.Drawing.Point(15, 38);
            this.lblFactoryType.Name = "lblFactoryType";
            this.lblFactoryType.Size = new System.Drawing.Size(89, 18);
            this.lblFactoryType.TabIndex = 11;
            this.lblFactoryType.Text = "Factory Type :";
            // 
            // lblHomePage
            // 
            this.lblHomePage.AutoSize = true;
            this.lblHomePage.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHomePage.ForeColor = System.Drawing.Color.Navy;
            this.lblHomePage.Location = new System.Drawing.Point(15, 287);
            this.lblHomePage.Name = "lblHomePage";
            this.lblHomePage.Size = new System.Drawing.Size(73, 18);
            this.lblHomePage.TabIndex = 10;
            this.lblHomePage.Text = "HomePage :";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCompanyName.ForeColor = System.Drawing.Color.Navy;
            this.lblCompanyName.Location = new System.Drawing.Point(15, 74);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(102, 18);
            this.lblCompanyName.TabIndex = 3;
            this.lblCompanyName.Text = "Company Name :";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPhone.ForeColor = System.Drawing.Color.Navy;
            this.lblPhone.Location = new System.Drawing.Point(15, 258);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(51, 18);
            this.lblPhone.TabIndex = 9;
            this.lblPhone.Text = "Phone :";
            // 
            // lblContactName
            // 
            this.lblContactName.AutoSize = true;
            this.lblContactName.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblContactName.ForeColor = System.Drawing.Color.Navy;
            this.lblContactName.Location = new System.Drawing.Point(16, 104);
            this.lblContactName.Name = "lblContactName";
            this.lblContactName.Size = new System.Drawing.Size(94, 18);
            this.lblContactName.TabIndex = 4;
            this.lblContactName.Text = "Contact Name :";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCountry.ForeColor = System.Drawing.Color.Navy;
            this.lblCountry.Location = new System.Drawing.Point(15, 232);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(61, 18);
            this.lblCountry.TabIndex = 8;
            this.lblCountry.Text = "Country :";
            // 
            // lblContactTitle
            // 
            this.lblContactTitle.AutoSize = true;
            this.lblContactTitle.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblContactTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblContactTitle.Location = new System.Drawing.Point(15, 131);
            this.lblContactTitle.Name = "lblContactTitle";
            this.lblContactTitle.Size = new System.Drawing.Size(94, 18);
            this.lblContactTitle.TabIndex = 6;
            this.lblContactTitle.Text = "Contact Title : ";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCity.ForeColor = System.Drawing.Color.Navy;
            this.lblCity.Location = new System.Drawing.Point(16, 206);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(39, 18);
            this.lblCity.TabIndex = 7;
            this.lblCity.Text = "City :";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAddress.ForeColor = System.Drawing.Color.Navy;
            this.lblAddress.Location = new System.Drawing.Point(16, 162);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(60, 18);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "Address :";
            // 
            // dgwOwnDepot
            // 
            this.dgwOwnDepot.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwOwnDepot.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgwOwnDepot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOwnDepot.Location = new System.Drawing.Point(17, 313);
            this.dgwOwnDepot.Name = "dgwOwnDepot";
            this.dgwOwnDepot.ReadOnly = true;
            this.dgwOwnDepot.Size = new System.Drawing.Size(606, 121);
            this.dgwOwnDepot.TabIndex = 20;
            this.dgwOwnDepot.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwOwnDepot_CellClick);
            // 
            // btnDepotOperations
            // 
            this.btnDepotOperations.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDepotOperations.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDepotOperations.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnDepotOperations.Image = ((System.Drawing.Image)(resources.GetObject("btnDepotOperations.Image")));
            this.btnDepotOperations.Location = new System.Drawing.Point(12, 451);
            this.btnDepotOperations.Name = "btnDepotOperations";
            this.btnDepotOperations.Size = new System.Drawing.Size(305, 73);
            this.btnDepotOperations.TabIndex = 3;
            this.btnDepotOperations.Text = "&Depot Operations";
            this.btnDepotOperations.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDepotOperations.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDepotOperations.UseVisualStyleBackColor = false;
            this.btnDepotOperations.Click += new System.EventHandler(this.btnDepotOperations_Click);
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
            this.menuStripBar.Size = new System.Drawing.Size(970, 24);
            this.menuStripBar.TabIndex = 6;
            this.menuStripBar.Text = "menuStrip1";
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
            // btnMyOrders
            // 
            this.btnMyOrders.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnMyOrders.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMyOrders.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnMyOrders.Image = ((System.Drawing.Image)(resources.GetObject("btnMyOrders.Image")));
            this.btnMyOrders.Location = new System.Drawing.Point(12, 374);
            this.btnMyOrders.Name = "btnMyOrders";
            this.btnMyOrders.Size = new System.Drawing.Size(305, 71);
            this.btnMyOrders.TabIndex = 2;
            this.btnMyOrders.Text = "&My Orders";
            this.btnMyOrders.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMyOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMyOrders.UseVisualStyleBackColor = false;
            this.btnMyOrders.Click += new System.EventHandler(this.btnMyOrders_Click);
            // 
            // gbxFrame
            // 
            this.gbxFrame.Controls.Add(this.dgwDepots);
            this.gbxFrame.Controls.Add(this.gbxSend);
            this.gbxFrame.Controls.Add(this.dgwOwnDepot);
            this.gbxFrame.Location = new System.Drawing.Point(323, 79);
            this.gbxFrame.Name = "gbxFrame";
            this.gbxFrame.Size = new System.Drawing.Size(639, 444);
            this.gbxFrame.TabIndex = 1;
            this.gbxFrame.TabStop = false;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(970, 572);
            this.Controls.Add(this.gbxFrame);
            this.Controls.Add(this.btnMyOrders);
            this.Controls.Add(this.menuStripBar);
            this.Controls.Add(this.btnDepotOperations);
            this.Controls.Add(this.gbxFactoryInfo);
            this.Controls.Add(this.gbxSearch);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnCancel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Page";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDepots)).EndInit();
            this.gbxSend.ResumeLayout(false);
            this.gbxSend.PerformLayout();
            this.gbxFactoryInfo.ResumeLayout(false);
            this.gbxFactoryInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOwnDepot)).EndInit();
            this.menuStripBar.ResumeLayout(false);
            this.menuStripBar.PerformLayout();
            this.gbxFrame.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gbxSearch;
        private System.Windows.Forms.TextBox txtSearchDepotName;
        private System.Windows.Forms.Label lblSearchDepotName;
        private System.Windows.Forms.DataGridView dgwDepots;
        private System.Windows.Forms.GroupBox gbxSend;
        private System.Windows.Forms.Label lblDepotName;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtProductNameDisplay;
        private System.Windows.Forms.TextBox txtStockInput;
        private System.Windows.Forms.Label lblStockInput;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtDepotNameDisplay;
        private System.Windows.Forms.Label lblStockInputSecondLine;
        private System.Windows.Forms.GroupBox gbxFactoryInfo;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.TextBox txtContactName;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtContactTitle;
        private System.Windows.Forms.TextBox txtFactoryType;
        private System.Windows.Forms.RichTextBox txtAddress;
        private System.Windows.Forms.RichTextBox txtHomePage;
        private System.Windows.Forms.Label lblFactoryType;
        private System.Windows.Forms.Label lblHomePage;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblContactName;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblContactTitle;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.ToolTip toolTipSearchDepotName;
        private System.Windows.Forms.DataGridView dgwOwnDepot;
        private System.Windows.Forms.Button btnDepotOperations;
        private System.Windows.Forms.PictureBox pbxSearch;
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
        private System.Windows.Forms.Button btnMyOrders;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.GroupBox gbxFrame;
    }
}