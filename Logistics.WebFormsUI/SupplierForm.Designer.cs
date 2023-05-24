namespace Logistics.WebFormsUI
{
    partial class SupplierForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierForm));
            this.btnProductOperations = new System.Windows.Forms.Button();
            this.btnDepotOperations = new System.Windows.Forms.Button();
            this.btnCustomerTransactions = new System.Windows.Forms.Button();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblContactName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblContactTitle = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblHomePage = new System.Windows.Forms.Label();
            this.lblFactoryType = new System.Windows.Forms.Label();
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.rtbWarning = new System.Windows.Forms.RichTextBox();
            this.lblWarning = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgwReceived = new System.Windows.Forms.DataGridView();
            this.lblReceived = new System.Windows.Forms.Label();
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
            this.gbxFactoryInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwReceived)).BeginInit();
            this.menuStripBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProductOperations
            // 
            this.btnProductOperations.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProductOperations.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnProductOperations.Image = ((System.Drawing.Image)(resources.GetObject("btnProductOperations.Image")));
            this.btnProductOperations.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProductOperations.Location = new System.Drawing.Point(411, 23);
            this.btnProductOperations.Name = "btnProductOperations";
            this.btnProductOperations.Size = new System.Drawing.Size(287, 89);
            this.btnProductOperations.TabIndex = 1;
            this.btnProductOperations.Text = "&Product Operations";
            this.btnProductOperations.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProductOperations.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProductOperations.UseVisualStyleBackColor = true;
            this.btnProductOperations.Click += new System.EventHandler(this.btnProductOperations_Click);
            // 
            // btnDepotOperations
            // 
            this.btnDepotOperations.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDepotOperations.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnDepotOperations.Image = ((System.Drawing.Image)(resources.GetObject("btnDepotOperations.Image")));
            this.btnDepotOperations.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDepotOperations.Location = new System.Drawing.Point(411, 127);
            this.btnDepotOperations.Name = "btnDepotOperations";
            this.btnDepotOperations.Size = new System.Drawing.Size(287, 89);
            this.btnDepotOperations.TabIndex = 2;
            this.btnDepotOperations.Text = "&Depot Operations";
            this.btnDepotOperations.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDepotOperations.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDepotOperations.UseVisualStyleBackColor = true;
            this.btnDepotOperations.Click += new System.EventHandler(this.btnDepotOperations_Click);
            // 
            // btnCustomerTransactions
            // 
            this.btnCustomerTransactions.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCustomerTransactions.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnCustomerTransactions.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomerTransactions.Image")));
            this.btnCustomerTransactions.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCustomerTransactions.Location = new System.Drawing.Point(411, 229);
            this.btnCustomerTransactions.Name = "btnCustomerTransactions";
            this.btnCustomerTransactions.Size = new System.Drawing.Size(287, 89);
            this.btnCustomerTransactions.TabIndex = 3;
            this.btnCustomerTransactions.Text = "Customer &Transactions";
            this.btnCustomerTransactions.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCustomerTransactions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomerTransactions.UseCompatibleTextRendering = true;
            this.btnCustomerTransactions.UseVisualStyleBackColor = true;
            this.btnCustomerTransactions.Click += new System.EventHandler(this.btnCustomerTransactions_Click);
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
            // gbxFactoryInfo
            // 
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
            this.gbxFactoryInfo.Location = new System.Drawing.Point(12, 23);
            this.gbxFactoryInfo.Name = "gbxFactoryInfo";
            this.gbxFactoryInfo.Size = new System.Drawing.Size(393, 341);
            this.gbxFactoryInfo.TabIndex = 12;
            this.gbxFactoryInfo.TabStop = false;
            this.gbxFactoryInfo.Text = "Factory Info";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(125, 70);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.ReadOnly = true;
            this.txtCompanyName.Size = new System.Drawing.Size(172, 20);
            this.txtCompanyName.TabIndex = 29;
            this.txtCompanyName.TabStop = false;
            // 
            // txtContactName
            // 
            this.txtContactName.Location = new System.Drawing.Point(111, 104);
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.ReadOnly = true;
            this.txtContactName.Size = new System.Drawing.Size(172, 20);
            this.txtContactName.TabIndex = 28;
            this.txtContactName.TabStop = false;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(61, 208);
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(172, 20);
            this.txtCity.TabIndex = 26;
            this.txtCity.TabStop = false;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(84, 232);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.ReadOnly = true;
            this.txtCountry.Size = new System.Drawing.Size(172, 20);
            this.txtCountry.TabIndex = 25;
            this.txtCountry.TabStop = false;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(72, 258);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(172, 20);
            this.txtPhone.TabIndex = 24;
            this.txtPhone.TabStop = false;
            // 
            // txtContactTitle
            // 
            this.txtContactTitle.Location = new System.Drawing.Point(111, 130);
            this.txtContactTitle.Name = "txtContactTitle";
            this.txtContactTitle.ReadOnly = true;
            this.txtContactTitle.Size = new System.Drawing.Size(172, 20);
            this.txtContactTitle.TabIndex = 22;
            this.txtContactTitle.TabStop = false;
            // 
            // txtFactoryType
            // 
            this.txtFactoryType.Location = new System.Drawing.Point(111, 36);
            this.txtFactoryType.Name = "txtFactoryType";
            this.txtFactoryType.ReadOnly = true;
            this.txtFactoryType.Size = new System.Drawing.Size(172, 20);
            this.txtFactoryType.TabIndex = 1;
            this.txtFactoryType.TabStop = false;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(84, 162);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(294, 40);
            this.txtAddress.TabIndex = 13;
            this.txtAddress.TabStop = false;
            this.txtAddress.Text = "";
            // 
            // txtHomePage
            // 
            this.txtHomePage.Location = new System.Drawing.Point(96, 286);
            this.txtHomePage.Name = "txtHomePage";
            this.txtHomePage.ReadOnly = true;
            this.txtHomePage.Size = new System.Drawing.Size(282, 45);
            this.txtHomePage.TabIndex = 12;
            this.txtHomePage.TabStop = false;
            this.txtHomePage.Text = "";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(574, 545);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(129, 40);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogOut.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(439, 546);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(129, 39);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "&Log Out";
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // rtbWarning
            // 
            this.rtbWarning.Location = new System.Drawing.Point(17, 433);
            this.rtbWarning.Name = "rtbWarning";
            this.rtbWarning.ReadOnly = true;
            this.rtbWarning.Size = new System.Drawing.Size(686, 106);
            this.rtbWarning.TabIndex = 15;
            this.rtbWarning.TabStop = false;
            this.rtbWarning.Text = "";
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWarning.Location = new System.Drawing.Point(40, 412);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(60, 15);
            this.lblWarning.TabIndex = 16;
            this.lblWarning.Text = "Warning";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 412);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(17, 15);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // dgwReceived
            // 
            this.dgwReceived.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgwReceived.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgwReceived.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwReceived.Location = new System.Drawing.Point(411, 342);
            this.dgwReceived.Name = "dgwReceived";
            this.dgwReceived.ReadOnly = true;
            this.dgwReceived.Size = new System.Drawing.Size(292, 85);
            this.dgwReceived.TabIndex = 18;
            // 
            // lblReceived
            // 
            this.lblReceived.AutoSize = true;
            this.lblReceived.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblReceived.Location = new System.Drawing.Point(412, 323);
            this.lblReceived.Name = "lblReceived";
            this.lblReceived.Size = new System.Drawing.Size(139, 15);
            this.lblReceived.TabIndex = 19;
            this.lblReceived.Text = "Received from depot";
            // 
            // menuStripBar
            // 
            this.menuStripBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItemAbout,
            this.helpToolStripMenuItemHelp,
            this.accountTransactionsToolStripMenuItem});
            this.menuStripBar.Location = new System.Drawing.Point(0, 0);
            this.menuStripBar.Name = "menuStripBar";
            this.menuStripBar.Size = new System.Drawing.Size(718, 24);
            this.menuStripBar.TabIndex = 0;
            this.menuStripBar.Text = "menuStrip";
            // 
            // helpToolStripMenuItemAbout
            // 
            this.helpToolStripMenuItemAbout.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.helpToolStripMenuItemAbout.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.helpToolStripMenuItemAbout.Name = "helpToolStripMenuItemAbout";
            this.helpToolStripMenuItemAbout.Size = new System.Drawing.Size(52, 20);
            this.helpToolStripMenuItemAbout.Text = "About";
            this.helpToolStripMenuItemAbout.Click += new System.EventHandler(this.helpToolStripMenuItemAbout_Click);
            // 
            // helpToolStripMenuItemHelp
            // 
            this.helpToolStripMenuItemHelp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
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
            this.accountTransactionsToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
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
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.changePasswordToolStripMenuItem.Text = "Change password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 592);
            this.Controls.Add(this.lblReceived);
            this.Controls.Add(this.dgwReceived);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.rtbWarning);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gbxFactoryInfo);
            this.Controls.Add(this.btnCustomerTransactions);
            this.Controls.Add(this.btnDepotOperations);
            this.Controls.Add(this.btnProductOperations);
            this.Controls.Add(this.menuStripBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripBar;
            this.Name = "SupplierForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supplier Page";
            this.Load += new System.EventHandler(this.SupplierForm_Load);
            this.gbxFactoryInfo.ResumeLayout(false);
            this.gbxFactoryInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwReceived)).EndInit();
            this.menuStripBar.ResumeLayout(false);
            this.menuStripBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProductOperations;
        private System.Windows.Forms.Button btnDepotOperations;
        private System.Windows.Forms.Button btnCustomerTransactions;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblContactName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblContactTitle;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblHomePage;
        private System.Windows.Forms.Label lblFactoryType;
        private System.Windows.Forms.GroupBox gbxFactoryInfo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.RichTextBox txtHomePage;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.TextBox txtContactName;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtContactTitle;
        private System.Windows.Forms.TextBox txtFactoryType;
        private System.Windows.Forms.RichTextBox txtAddress;
        private System.Windows.Forms.RichTextBox rtbWarning;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgwReceived;
        private System.Windows.Forms.Label lblReceived;
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