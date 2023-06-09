namespace Logistics.WebFormsUI
{
    partial class CustomerDepotOperationsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerDepotOperationsForm));
            this.btnHomePage = new System.Windows.Forms.Button();
            this.gbxSearchByName = new System.Windows.Forms.GroupBox();
            this.pbxSearch = new System.Windows.Forms.PictureBox();
            this.txtSearchDepotName = new System.Windows.Forms.TextBox();
            this.lblSearchDepotName = new System.Windows.Forms.Label();
            this.dgwDepots = new System.Windows.Forms.DataGridView();
            this.gbxAddDepot = new System.Windows.Forms.GroupBox();
            this.cbxProducts = new System.Windows.Forms.ComboBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.rtxtAdress = new System.Windows.Forms.RichTextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtUnitInStock = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblAdress = new System.Windows.Forms.Label();
            this.lblUnitInStock = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtContactTitle = new System.Windows.Forms.TextBox();
            this.txtContactName = new System.Windows.Forms.TextBox();
            this.txtDepotName = new System.Windows.Forms.TextBox();
            this.lblContactTitle = new System.Windows.Forms.Label();
            this.lblContactName = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblDepotName = new System.Windows.Forms.Label();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.txtUpdateUnitInStock = new System.Windows.Forms.TextBox();
            this.lblUpdateUnitInStock = new System.Windows.Forms.Label();
            this.txtUpdatePhone = new System.Windows.Forms.TextBox();
            this.lblUpdatePhone = new System.Windows.Forms.Label();
            this.txtUpdateAddress = new System.Windows.Forms.RichTextBox();
            this.txtUpdateDepotName = new System.Windows.Forms.TextBox();
            this.lblUpdateAddress = new System.Windows.Forms.Label();
            this.lblUpdateDepotName = new System.Windows.Forms.Label();
            this.txtUpdateContactTitle = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtUpdateContactName = new System.Windows.Forms.TextBox();
            this.lblUpdateContactTitle = new System.Windows.Forms.Label();
            this.lblUpdateContactName = new System.Windows.Forms.Label();
            this.btnCloseDepot = new System.Windows.Forms.Button();
            this.btnCloneDepot = new System.Windows.Forms.Button();
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
            this.gbxSearchByName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDepots)).BeginInit();
            this.gbxAddDepot.SuspendLayout();
            this.gbxUpdate.SuspendLayout();
            this.menuStripBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHomePage
            // 
            this.btnHomePage.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnHomePage.Image = ((System.Drawing.Image)(resources.GetObject("btnHomePage.Image")));
            this.btnHomePage.Location = new System.Drawing.Point(12, 27);
            this.btnHomePage.Name = "btnHomePage";
            this.btnHomePage.Size = new System.Drawing.Size(87, 67);
            this.btnHomePage.TabIndex = 0;
            this.btnHomePage.Text = "&Home Page";
            this.btnHomePage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHomePage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHomePage.UseVisualStyleBackColor = false;
            this.btnHomePage.Click += new System.EventHandler(this.btnHomePage_Click);
            // 
            // gbxSearchByName
            // 
            this.gbxSearchByName.BackColor = System.Drawing.Color.Transparent;
            this.gbxSearchByName.Controls.Add(this.pbxSearch);
            this.gbxSearchByName.Controls.Add(this.txtSearchDepotName);
            this.gbxSearchByName.Controls.Add(this.lblSearchDepotName);
            this.gbxSearchByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxSearchByName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.gbxSearchByName.Location = new System.Drawing.Point(115, 27);
            this.gbxSearchByName.Name = "gbxSearchByName";
            this.gbxSearchByName.Size = new System.Drawing.Size(309, 67);
            this.gbxSearchByName.TabIndex = 1;
            this.gbxSearchByName.TabStop = false;
            this.gbxSearchByName.Text = "Search by Name";
            // 
            // pbxSearch
            // 
            this.pbxSearch.Image = ((System.Drawing.Image)(resources.GetObject("pbxSearch.Image")));
            this.pbxSearch.Location = new System.Drawing.Point(256, 32);
            this.pbxSearch.Name = "pbxSearch";
            this.pbxSearch.Size = new System.Drawing.Size(32, 29);
            this.pbxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSearch.TabIndex = 1;
            this.pbxSearch.TabStop = false;
            // 
            // txtSearchDepotName
            // 
            this.txtSearchDepotName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtSearchDepotName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearchDepotName.Location = new System.Drawing.Point(87, 37);
            this.txtSearchDepotName.Name = "txtSearchDepotName";
            this.txtSearchDepotName.Size = new System.Drawing.Size(163, 20);
            this.txtSearchDepotName.TabIndex = 0;
            this.txtSearchDepotName.TextChanged += new System.EventHandler(this.txtSearchDepotName_TextChanged);
            // 
            // lblSearchDepotName
            // 
            this.lblSearchDepotName.AutoSize = true;
            this.lblSearchDepotName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSearchDepotName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSearchDepotName.Location = new System.Drawing.Point(14, 40);
            this.lblSearchDepotName.Name = "lblSearchDepotName";
            this.lblSearchDepotName.Size = new System.Drawing.Size(67, 13);
            this.lblSearchDepotName.TabIndex = 0;
            this.lblSearchDepotName.Text = "Depot Name";
            // 
            // dgwDepots
            // 
            this.dgwDepots.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgwDepots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDepots.Location = new System.Drawing.Point(12, 100);
            this.dgwDepots.Name = "dgwDepots";
            this.dgwDepots.ReadOnly = true;
            this.dgwDepots.Size = new System.Drawing.Size(899, 141);
            this.dgwDepots.TabIndex = 1;
            this.dgwDepots.TabStop = false;
            this.dgwDepots.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwDepots_CellClick);
            this.dgwDepots.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgwDepots_CellFormatting);
            // 
            // gbxAddDepot
            // 
            this.gbxAddDepot.Controls.Add(this.cbxProducts);
            this.gbxAddDepot.Controls.Add(this.txtCountry);
            this.gbxAddDepot.Controls.Add(this.lblCountry);
            this.gbxAddDepot.Controls.Add(this.rtxtAdress);
            this.gbxAddDepot.Controls.Add(this.txtPhone);
            this.gbxAddDepot.Controls.Add(this.txtUnitInStock);
            this.gbxAddDepot.Controls.Add(this.txtCity);
            this.gbxAddDepot.Controls.Add(this.lblAdress);
            this.gbxAddDepot.Controls.Add(this.lblUnitInStock);
            this.gbxAddDepot.Controls.Add(this.lblPhone);
            this.gbxAddDepot.Controls.Add(this.lblCity);
            this.gbxAddDepot.Controls.Add(this.btnAdd);
            this.gbxAddDepot.Controls.Add(this.txtContactTitle);
            this.gbxAddDepot.Controls.Add(this.txtContactName);
            this.gbxAddDepot.Controls.Add(this.txtDepotName);
            this.gbxAddDepot.Controls.Add(this.lblContactTitle);
            this.gbxAddDepot.Controls.Add(this.lblContactName);
            this.gbxAddDepot.Controls.Add(this.lblProduct);
            this.gbxAddDepot.Controls.Add(this.lblDepotName);
            this.gbxAddDepot.Location = new System.Drawing.Point(12, 247);
            this.gbxAddDepot.Name = "gbxAddDepot";
            this.gbxAddDepot.Size = new System.Drawing.Size(424, 251);
            this.gbxAddDepot.TabIndex = 2;
            this.gbxAddDepot.TabStop = false;
            this.gbxAddDepot.Text = "Add new depot";
            // 
            // cbxProducts
            // 
            this.cbxProducts.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cbxProducts.FormattingEnabled = true;
            this.cbxProducts.Location = new System.Drawing.Point(83, 61);
            this.cbxProducts.Name = "cbxProducts";
            this.cbxProducts.Size = new System.Drawing.Size(124, 21);
            this.cbxProducts.TabIndex = 22;
            // 
            // txtCountry
            // 
            this.txtCountry.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtCountry.Location = new System.Drawing.Point(291, 58);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(115, 20);
            this.txtCountry.TabIndex = 6;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(242, 62);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(43, 13);
            this.lblCountry.TabIndex = 21;
            this.lblCountry.Text = "Country";
            // 
            // rtxtAdress
            // 
            this.rtxtAdress.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rtxtAdress.Location = new System.Drawing.Point(83, 158);
            this.rtxtAdress.Name = "rtxtAdress";
            this.rtxtAdress.Size = new System.Drawing.Size(323, 58);
            this.rtxtAdress.TabIndex = 4;
            this.rtxtAdress.Text = "";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtPhone.Location = new System.Drawing.Point(291, 93);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(115, 20);
            this.txtPhone.TabIndex = 7;
            // 
            // txtUnitInStock
            // 
            this.txtUnitInStock.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtUnitInStock.Location = new System.Drawing.Point(291, 130);
            this.txtUnitInStock.Name = "txtUnitInStock";
            this.txtUnitInStock.Size = new System.Drawing.Size(115, 20);
            this.txtUnitInStock.TabIndex = 8;
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtCity.Location = new System.Drawing.Point(291, 23);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(115, 20);
            this.txtCity.TabIndex = 5;
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(32, 164);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(45, 13);
            this.lblAdress.TabIndex = 15;
            this.lblAdress.Text = "Address";
            // 
            // lblUnitInStock
            // 
            this.lblUnitInStock.AutoSize = true;
            this.lblUnitInStock.Location = new System.Drawing.Point(222, 134);
            this.lblUnitInStock.Name = "lblUnitInStock";
            this.lblUnitInStock.Size = new System.Drawing.Size(63, 13);
            this.lblUnitInStock.TabIndex = 14;
            this.lblUnitInStock.Text = "UnitInStock";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(247, 96);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(38, 13);
            this.lblPhone.TabIndex = 13;
            this.lblPhone.Text = "Phone";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(261, 25);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 12;
            this.lblCity.Text = "City";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAdd.Location = new System.Drawing.Point(178, 222);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtContactTitle
            // 
            this.txtContactTitle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtContactTitle.Location = new System.Drawing.Point(83, 129);
            this.txtContactTitle.Name = "txtContactTitle";
            this.txtContactTitle.Size = new System.Drawing.Size(124, 20);
            this.txtContactTitle.TabIndex = 3;
            // 
            // txtContactName
            // 
            this.txtContactName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtContactName.Location = new System.Drawing.Point(83, 94);
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.Size = new System.Drawing.Size(124, 20);
            this.txtContactName.TabIndex = 2;
            // 
            // txtDepotName
            // 
            this.txtDepotName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtDepotName.Location = new System.Drawing.Point(83, 20);
            this.txtDepotName.Name = "txtDepotName";
            this.txtDepotName.Size = new System.Drawing.Size(124, 20);
            this.txtDepotName.TabIndex = 0;
            // 
            // lblContactTitle
            // 
            this.lblContactTitle.AutoSize = true;
            this.lblContactTitle.Location = new System.Drawing.Point(10, 132);
            this.lblContactTitle.Name = "lblContactTitle";
            this.lblContactTitle.Size = new System.Drawing.Size(67, 13);
            this.lblContactTitle.TabIndex = 3;
            this.lblContactTitle.Text = "Contact Title";
            // 
            // lblContactName
            // 
            this.lblContactName.AutoSize = true;
            this.lblContactName.Location = new System.Drawing.Point(2, 97);
            this.lblContactName.Name = "lblContactName";
            this.lblContactName.Size = new System.Drawing.Size(75, 13);
            this.lblContactName.TabIndex = 2;
            this.lblContactName.Text = "Contact Name";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(19, 65);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(58, 13);
            this.lblProduct.TabIndex = 1;
            this.lblProduct.Text = "Product ID";
            // 
            // lblDepotName
            // 
            this.lblDepotName.AutoSize = true;
            this.lblDepotName.Location = new System.Drawing.Point(10, 23);
            this.lblDepotName.Name = "lblDepotName";
            this.lblDepotName.Size = new System.Drawing.Size(67, 13);
            this.lblDepotName.TabIndex = 0;
            this.lblDepotName.Text = "Depot Name";
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.txtUpdateUnitInStock);
            this.gbxUpdate.Controls.Add(this.lblUpdateUnitInStock);
            this.gbxUpdate.Controls.Add(this.txtUpdatePhone);
            this.gbxUpdate.Controls.Add(this.lblUpdatePhone);
            this.gbxUpdate.Controls.Add(this.txtUpdateAddress);
            this.gbxUpdate.Controls.Add(this.txtUpdateDepotName);
            this.gbxUpdate.Controls.Add(this.lblUpdateAddress);
            this.gbxUpdate.Controls.Add(this.lblUpdateDepotName);
            this.gbxUpdate.Controls.Add(this.txtUpdateContactTitle);
            this.gbxUpdate.Controls.Add(this.btnUpdate);
            this.gbxUpdate.Controls.Add(this.txtUpdateContactName);
            this.gbxUpdate.Controls.Add(this.lblUpdateContactTitle);
            this.gbxUpdate.Controls.Add(this.lblUpdateContactName);
            this.gbxUpdate.Location = new System.Drawing.Point(442, 247);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(469, 251);
            this.gbxUpdate.TabIndex = 3;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Update depot";
            // 
            // txtUpdateUnitInStock
            // 
            this.txtUpdateUnitInStock.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtUpdateUnitInStock.Location = new System.Drawing.Point(328, 125);
            this.txtUpdateUnitInStock.Name = "txtUpdateUnitInStock";
            this.txtUpdateUnitInStock.Size = new System.Drawing.Size(115, 20);
            this.txtUpdateUnitInStock.TabIndex = 5;
            // 
            // lblUpdateUnitInStock
            // 
            this.lblUpdateUnitInStock.AutoSize = true;
            this.lblUpdateUnitInStock.Location = new System.Drawing.Point(259, 129);
            this.lblUpdateUnitInStock.Name = "lblUpdateUnitInStock";
            this.lblUpdateUnitInStock.Size = new System.Drawing.Size(63, 13);
            this.lblUpdateUnitInStock.TabIndex = 23;
            this.lblUpdateUnitInStock.Text = "UnitInStock";
            // 
            // txtUpdatePhone
            // 
            this.txtUpdatePhone.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtUpdatePhone.Location = new System.Drawing.Point(83, 125);
            this.txtUpdatePhone.Name = "txtUpdatePhone";
            this.txtUpdatePhone.Size = new System.Drawing.Size(163, 20);
            this.txtUpdatePhone.TabIndex = 3;
            // 
            // lblUpdatePhone
            // 
            this.lblUpdatePhone.AutoSize = true;
            this.lblUpdatePhone.Location = new System.Drawing.Point(39, 128);
            this.lblUpdatePhone.Name = "lblUpdatePhone";
            this.lblUpdatePhone.Size = new System.Drawing.Size(38, 13);
            this.lblUpdatePhone.TabIndex = 23;
            this.lblUpdatePhone.Text = "Phone";
            // 
            // txtUpdateAddress
            // 
            this.txtUpdateAddress.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtUpdateAddress.Location = new System.Drawing.Point(83, 158);
            this.txtUpdateAddress.Name = "txtUpdateAddress";
            this.txtUpdateAddress.Size = new System.Drawing.Size(360, 47);
            this.txtUpdateAddress.TabIndex = 4;
            this.txtUpdateAddress.Text = "";
            // 
            // txtUpdateDepotName
            // 
            this.txtUpdateDepotName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtUpdateDepotName.Location = new System.Drawing.Point(83, 24);
            this.txtUpdateDepotName.Name = "txtUpdateDepotName";
            this.txtUpdateDepotName.Size = new System.Drawing.Size(163, 20);
            this.txtUpdateDepotName.TabIndex = 0;
            // 
            // lblUpdateAddress
            // 
            this.lblUpdateAddress.AutoSize = true;
            this.lblUpdateAddress.Location = new System.Drawing.Point(32, 158);
            this.lblUpdateAddress.Name = "lblUpdateAddress";
            this.lblUpdateAddress.Size = new System.Drawing.Size(45, 13);
            this.lblUpdateAddress.TabIndex = 23;
            this.lblUpdateAddress.Text = "Address";
            // 
            // lblUpdateDepotName
            // 
            this.lblUpdateDepotName.AutoSize = true;
            this.lblUpdateDepotName.Location = new System.Drawing.Point(10, 27);
            this.lblUpdateDepotName.Name = "lblUpdateDepotName";
            this.lblUpdateDepotName.Size = new System.Drawing.Size(67, 13);
            this.lblUpdateDepotName.TabIndex = 23;
            this.lblUpdateDepotName.Text = "Depot Name";
            // 
            // txtUpdateContactTitle
            // 
            this.txtUpdateContactTitle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtUpdateContactTitle.Location = new System.Drawing.Point(83, 91);
            this.txtUpdateContactTitle.Name = "txtUpdateContactTitle";
            this.txtUpdateContactTitle.Size = new System.Drawing.Size(163, 20);
            this.txtUpdateContactTitle.TabIndex = 2;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnUpdate.Location = new System.Drawing.Point(109, 220);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtUpdateContactName
            // 
            this.txtUpdateContactName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtUpdateContactName.Location = new System.Drawing.Point(83, 56);
            this.txtUpdateContactName.Name = "txtUpdateContactName";
            this.txtUpdateContactName.Size = new System.Drawing.Size(163, 20);
            this.txtUpdateContactName.TabIndex = 1;
            // 
            // lblUpdateContactTitle
            // 
            this.lblUpdateContactTitle.AutoSize = true;
            this.lblUpdateContactTitle.Location = new System.Drawing.Point(10, 94);
            this.lblUpdateContactTitle.Name = "lblUpdateContactTitle";
            this.lblUpdateContactTitle.Size = new System.Drawing.Size(67, 13);
            this.lblUpdateContactTitle.TabIndex = 25;
            this.lblUpdateContactTitle.Text = "Contact Title";
            // 
            // lblUpdateContactName
            // 
            this.lblUpdateContactName.AutoSize = true;
            this.lblUpdateContactName.Location = new System.Drawing.Point(2, 59);
            this.lblUpdateContactName.Name = "lblUpdateContactName";
            this.lblUpdateContactName.Size = new System.Drawing.Size(75, 13);
            this.lblUpdateContactName.TabIndex = 23;
            this.lblUpdateContactName.Text = "Contact Name";
            // 
            // btnCloseDepot
            // 
            this.btnCloseDepot.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCloseDepot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCloseDepot.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseDepot.Image")));
            this.btnCloseDepot.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseDepot.Location = new System.Drawing.Point(749, 27);
            this.btnCloseDepot.Name = "btnCloseDepot";
            this.btnCloseDepot.Size = new System.Drawing.Size(161, 67);
            this.btnCloseDepot.TabIndex = 4;
            this.btnCloseDepot.Text = "&Close Depot";
            this.btnCloseDepot.UseVisualStyleBackColor = false;
            this.btnCloseDepot.Click += new System.EventHandler(this.btnCloseDepot_Click);
            // 
            // btnCloneDepot
            // 
            this.btnCloneDepot.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCloneDepot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCloneDepot.Image = ((System.Drawing.Image)(resources.GetObject("btnCloneDepot.Image")));
            this.btnCloneDepot.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloneDepot.Location = new System.Drawing.Point(430, 52);
            this.btnCloneDepot.Name = "btnCloneDepot";
            this.btnCloneDepot.Size = new System.Drawing.Size(165, 42);
            this.btnCloneDepot.TabIndex = 8;
            this.btnCloneDepot.Text = "Clo&ne Depot";
            this.btnCloneDepot.UseVisualStyleBackColor = false;
            this.btnCloneDepot.Click += new System.EventHandler(this.btnCloneDepot_Click);
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
            this.menuStripBar.Size = new System.Drawing.Size(922, 24);
            this.menuStripBar.TabIndex = 9;
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
            // CustomerDepotOperationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(922, 509);
            this.Controls.Add(this.menuStripBar);
            this.Controls.Add(this.btnCloneDepot);
            this.Controls.Add(this.btnCloseDepot);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.gbxAddDepot);
            this.Controls.Add(this.dgwDepots);
            this.Controls.Add(this.gbxSearchByName);
            this.Controls.Add(this.btnHomePage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomerDepotOperationsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Depot Operations Page";
            this.Load += new System.EventHandler(this.CustomerDepotOperationsForm_Load);
            this.gbxSearchByName.ResumeLayout(false);
            this.gbxSearchByName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDepots)).EndInit();
            this.gbxAddDepot.ResumeLayout(false);
            this.gbxAddDepot.PerformLayout();
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.menuStripBar.ResumeLayout(false);
            this.menuStripBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHomePage;
        private System.Windows.Forms.GroupBox gbxSearchByName;
        private System.Windows.Forms.TextBox txtSearchDepotName;
        private System.Windows.Forms.Label lblSearchDepotName;
        private System.Windows.Forms.DataGridView dgwDepots;
        private System.Windows.Forms.GroupBox gbxAddDepot;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.RichTextBox rtxtAdress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtUnitInStock;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Label lblUnitInStock;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtContactTitle;
        private System.Windows.Forms.TextBox txtContactName;
        private System.Windows.Forms.TextBox txtDepotName;
        private System.Windows.Forms.Label lblContactTitle;
        private System.Windows.Forms.Label lblContactName;
        private System.Windows.Forms.Label lblDepotName;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.TextBox txtUpdatePhone;
        private System.Windows.Forms.Label lblUpdatePhone;
        private System.Windows.Forms.RichTextBox txtUpdateAddress;
        private System.Windows.Forms.TextBox txtUpdateDepotName;
        private System.Windows.Forms.Label lblUpdateAddress;
        private System.Windows.Forms.Label lblUpdateDepotName;
        private System.Windows.Forms.TextBox txtUpdateContactTitle;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtUpdateContactName;
        private System.Windows.Forms.Label lblUpdateContactTitle;
        private System.Windows.Forms.Label lblUpdateContactName;
        private System.Windows.Forms.Button btnCloseDepot;
        private System.Windows.Forms.TextBox txtUpdateUnitInStock;
        private System.Windows.Forms.Label lblUpdateUnitInStock;
        private System.Windows.Forms.PictureBox pbxSearch;
        private System.Windows.Forms.Button btnCloneDepot;
        private System.Windows.Forms.ComboBox cbxProducts;
        private System.Windows.Forms.Label lblProduct;
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