namespace Logistics.WebFormsUI
{
    partial class DepotOperationsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepotOperationsForm));
            this.dgwDepots = new System.Windows.Forms.DataGridView();
            this.lblSendStock = new System.Windows.Forms.Label();
            this.txtStockInput = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtDepotId = new System.Windows.Forms.TextBox();
            this.txtProductIdDisplay = new System.Windows.Forms.TextBox();
            this.txtUnitInStockDisplay = new System.Windows.Forms.TextBox();
            this.gbxSearchByName = new System.Windows.Forms.GroupBox();
            this.pbxSearch = new System.Windows.Forms.PictureBox();
            this.txtSearchDepotName = new System.Windows.Forms.TextBox();
            this.lblSearchDepotName = new System.Windows.Forms.Label();
            this.lblDepotId = new System.Windows.Forms.Label();
            this.lblProductIdDisplay = new System.Windows.Forms.Label();
            this.lblUnitInStockDisplay = new System.Windows.Forms.Label();
            this.gbxSend = new System.Windows.Forms.GroupBox();
            this.gbxAddDepot = new System.Windows.Forms.GroupBox();
            this.cbxProducts = new System.Windows.Forms.ComboBox();
            this.lblProduct = new System.Windows.Forms.Label();
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
            this.lblDepotName = new System.Windows.Forms.Label();
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
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
            this.toolTipSearchDepotName = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipInfo = new System.Windows.Forms.ToolTip(this.components);
            this.btnCloseDepot = new System.Windows.Forms.Button();
            this.btnHomePage = new System.Windows.Forms.Button();
            this.btnCloneDepot = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDepots)).BeginInit();
            this.gbxSearchByName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSearch)).BeginInit();
            this.gbxSend.SuspendLayout();
            this.gbxAddDepot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.gbxUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwDepots
            // 
            this.dgwDepots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDepots.Location = new System.Drawing.Point(12, 127);
            this.dgwDepots.Name = "dgwDepots";
            this.dgwDepots.ReadOnly = true;
            this.dgwDepots.Size = new System.Drawing.Size(953, 141);
            this.dgwDepots.TabIndex = 0;
            this.dgwDepots.TabStop = false;
            this.dgwDepots.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwDepots_CellClick);
            this.dgwDepots.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgwDepots_CellFormatting);
            // 
            // lblSendStock
            // 
            this.lblSendStock.AutoSize = true;
            this.lblSendStock.Location = new System.Drawing.Point(6, 113);
            this.lblSendStock.Name = "lblSendStock";
            this.lblSendStock.Size = new System.Drawing.Size(183, 13);
            this.lblSendStock.TabIndex = 2;
            this.lblSendStock.Text = "Stock amount to be sent to the depot";
            // 
            // txtStockInput
            // 
            this.txtStockInput.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtStockInput.Location = new System.Drawing.Point(30, 132);
            this.txtStockInput.Name = "txtStockInput";
            this.txtStockInput.Size = new System.Drawing.Size(136, 20);
            this.txtStockInput.TabIndex = 3;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(58, 158);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(92, 24);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "&Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtDepotId
            // 
            this.txtDepotId.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtDepotId.Location = new System.Drawing.Point(83, 29);
            this.txtDepotId.Name = "txtDepotId";
            this.txtDepotId.Size = new System.Drawing.Size(100, 20);
            this.txtDepotId.TabIndex = 0;
            this.txtDepotId.TabStop = false;
            // 
            // txtProductIdDisplay
            // 
            this.txtProductIdDisplay.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtProductIdDisplay.Location = new System.Drawing.Point(83, 53);
            this.txtProductIdDisplay.Name = "txtProductIdDisplay";
            this.txtProductIdDisplay.Size = new System.Drawing.Size(100, 20);
            this.txtProductIdDisplay.TabIndex = 1;
            this.txtProductIdDisplay.TabStop = false;
            // 
            // txtUnitInStockDisplay
            // 
            this.txtUnitInStockDisplay.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtUnitInStockDisplay.Location = new System.Drawing.Point(83, 80);
            this.txtUnitInStockDisplay.Name = "txtUnitInStockDisplay";
            this.txtUnitInStockDisplay.Size = new System.Drawing.Size(100, 20);
            this.txtUnitInStockDisplay.TabIndex = 2;
            this.txtUnitInStockDisplay.TabStop = false;
            // 
            // gbxSearchByName
            // 
            this.gbxSearchByName.Controls.Add(this.pbxSearch);
            this.gbxSearchByName.Controls.Add(this.txtSearchDepotName);
            this.gbxSearchByName.Controls.Add(this.lblSearchDepotName);
            this.gbxSearchByName.Location = new System.Drawing.Point(105, 3);
            this.gbxSearchByName.Name = "gbxSearchByName";
            this.gbxSearchByName.Size = new System.Drawing.Size(269, 70);
            this.gbxSearchByName.TabIndex = 1;
            this.gbxSearchByName.TabStop = false;
            this.gbxSearchByName.Text = "Search by Name";
            // 
            // pbxSearch
            // 
            this.pbxSearch.Image = ((System.Drawing.Image)(resources.GetObject("pbxSearch.Image")));
            this.pbxSearch.Location = new System.Drawing.Point(231, 26);
            this.pbxSearch.Name = "pbxSearch";
            this.pbxSearch.Size = new System.Drawing.Size(32, 29);
            this.pbxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSearch.TabIndex = 2;
            this.pbxSearch.TabStop = false;
            // 
            // txtSearchDepotName
            // 
            this.txtSearchDepotName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtSearchDepotName.Location = new System.Drawing.Point(87, 35);
            this.txtSearchDepotName.Name = "txtSearchDepotName";
            this.txtSearchDepotName.Size = new System.Drawing.Size(138, 20);
            this.txtSearchDepotName.TabIndex = 0;
            this.toolTipSearchDepotName.SetToolTip(this.txtSearchDepotName, "Enter the name of the depot you want to find.");
            this.txtSearchDepotName.TextChanged += new System.EventHandler(this.txtSearchDepotName_TextChanged);
            // 
            // lblSearchDepotName
            // 
            this.lblSearchDepotName.AutoSize = true;
            this.lblSearchDepotName.Location = new System.Drawing.Point(6, 38);
            this.lblSearchDepotName.Name = "lblSearchDepotName";
            this.lblSearchDepotName.Size = new System.Drawing.Size(67, 13);
            this.lblSearchDepotName.TabIndex = 0;
            this.lblSearchDepotName.Text = "Depot Name";
            // 
            // lblDepotId
            // 
            this.lblDepotId.AutoSize = true;
            this.lblDepotId.Location = new System.Drawing.Point(6, 32);
            this.lblDepotId.Name = "lblDepotId";
            this.lblDepotId.Size = new System.Drawing.Size(47, 13);
            this.lblDepotId.TabIndex = 16;
            this.lblDepotId.Text = "DepotID";
            // 
            // lblProductIdDisplay
            // 
            this.lblProductIdDisplay.AutoSize = true;
            this.lblProductIdDisplay.Location = new System.Drawing.Point(6, 60);
            this.lblProductIdDisplay.Name = "lblProductIdDisplay";
            this.lblProductIdDisplay.Size = new System.Drawing.Size(55, 13);
            this.lblProductIdDisplay.TabIndex = 17;
            this.lblProductIdDisplay.Text = "ProductID";
            // 
            // lblUnitInStockDisplay
            // 
            this.lblUnitInStockDisplay.AutoSize = true;
            this.lblUnitInStockDisplay.Location = new System.Drawing.Point(6, 83);
            this.lblUnitInStockDisplay.Name = "lblUnitInStockDisplay";
            this.lblUnitInStockDisplay.Size = new System.Drawing.Size(71, 13);
            this.lblUnitInStockDisplay.TabIndex = 18;
            this.lblUnitInStockDisplay.Text = "Unit in stocks";
            // 
            // gbxSend
            // 
            this.gbxSend.Controls.Add(this.lblDepotId);
            this.gbxSend.Controls.Add(this.lblUnitInStockDisplay);
            this.gbxSend.Controls.Add(this.btnSend);
            this.gbxSend.Controls.Add(this.txtProductIdDisplay);
            this.gbxSend.Controls.Add(this.txtStockInput);
            this.gbxSend.Controls.Add(this.txtUnitInStockDisplay);
            this.gbxSend.Controls.Add(this.lblSendStock);
            this.gbxSend.Controls.Add(this.lblProductIdDisplay);
            this.gbxSend.Controls.Add(this.txtDepotId);
            this.gbxSend.Location = new System.Drawing.Point(12, 274);
            this.gbxSend.Name = "gbxSend";
            this.gbxSend.Size = new System.Drawing.Size(242, 205);
            this.gbxSend.TabIndex = 2;
            this.gbxSend.TabStop = false;
            this.gbxSend.Text = "Send product to depot";
            // 
            // gbxAddDepot
            // 
            this.gbxAddDepot.Controls.Add(this.cbxProducts);
            this.gbxAddDepot.Controls.Add(this.lblProduct);
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
            this.gbxAddDepot.Controls.Add(this.lblDepotName);
            this.gbxAddDepot.Location = new System.Drawing.Point(260, 274);
            this.gbxAddDepot.Name = "gbxAddDepot";
            this.gbxAddDepot.Size = new System.Drawing.Size(412, 251);
            this.gbxAddDepot.TabIndex = 3;
            this.gbxAddDepot.TabStop = false;
            this.gbxAddDepot.Text = "Add new depot";
            // 
            // cbxProducts
            // 
            this.cbxProducts.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cbxProducts.FormattingEnabled = true;
            this.cbxProducts.Location = new System.Drawing.Point(85, 57);
            this.cbxProducts.Name = "cbxProducts";
            this.cbxProducts.Size = new System.Drawing.Size(115, 21);
            this.cbxProducts.TabIndex = 24;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(19, 61);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(58, 13);
            this.lblProduct.TabIndex = 23;
            this.lblProduct.Text = "Product ID";
            // 
            // txtCountry
            // 
            this.txtCountry.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtCountry.Location = new System.Drawing.Point(276, 57);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(115, 20);
            this.txtCountry.TabIndex = 6;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(227, 61);
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
            this.rtxtAdress.Size = new System.Drawing.Size(308, 58);
            this.rtxtAdress.TabIndex = 4;
            this.rtxtAdress.Text = "";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtPhone.Location = new System.Drawing.Point(276, 92);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(115, 20);
            this.txtPhone.TabIndex = 7;
            // 
            // txtUnitInStock
            // 
            this.txtUnitInStock.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtUnitInStock.Location = new System.Drawing.Point(276, 129);
            this.txtUnitInStock.Name = "txtUnitInStock";
            this.txtUnitInStock.Size = new System.Drawing.Size(115, 20);
            this.txtUnitInStock.TabIndex = 8;
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtCity.Location = new System.Drawing.Point(276, 22);
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
            this.lblUnitInStock.Location = new System.Drawing.Point(207, 133);
            this.lblUnitInStock.Name = "lblUnitInStock";
            this.lblUnitInStock.Size = new System.Drawing.Size(63, 13);
            this.lblUnitInStock.TabIndex = 14;
            this.lblUnitInStock.Text = "UnitInStock";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(232, 95);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(38, 13);
            this.lblPhone.TabIndex = 13;
            this.lblPhone.Text = "Phone";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(246, 24);
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
            this.txtContactTitle.Size = new System.Drawing.Size(115, 20);
            this.txtContactTitle.TabIndex = 3;
            // 
            // txtContactName
            // 
            this.txtContactName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtContactName.Location = new System.Drawing.Point(83, 94);
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.Size = new System.Drawing.Size(115, 20);
            this.txtContactName.TabIndex = 2;
            // 
            // txtDepotName
            // 
            this.txtDepotName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtDepotName.Location = new System.Drawing.Point(83, 20);
            this.txtDepotName.Name = "txtDepotName";
            this.txtDepotName.Size = new System.Drawing.Size(115, 20);
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
            // lblDepotName
            // 
            this.lblDepotName.AutoSize = true;
            this.lblDepotName.Location = new System.Drawing.Point(10, 23);
            this.lblDepotName.Name = "lblDepotName";
            this.lblDepotName.Size = new System.Drawing.Size(67, 13);
            this.lblDepotName.TabIndex = 0;
            this.lblDepotName.Text = "Depot Name";
            // 
            // dgwProducts
            // 
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(380, 3);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.ReadOnly = true;
            this.dgwProducts.Size = new System.Drawing.Size(585, 118);
            this.dgwProducts.TabIndex = 6;
            this.dgwProducts.TabStop = false;
            this.dgwProducts.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgwProducts_CellFormatting);
            // 
            // gbxUpdate
            // 
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
            this.gbxUpdate.Location = new System.Drawing.Point(678, 274);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(287, 251);
            this.gbxUpdate.TabIndex = 4;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Update depot";
            // 
            // txtUpdatePhone
            // 
            this.txtUpdatePhone.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtUpdatePhone.Location = new System.Drawing.Point(83, 125);
            this.txtUpdatePhone.Name = "txtUpdatePhone";
            this.txtUpdatePhone.Size = new System.Drawing.Size(133, 20);
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
            this.txtUpdateAddress.Size = new System.Drawing.Size(192, 47);
            this.txtUpdateAddress.TabIndex = 4;
            this.txtUpdateAddress.Text = "";
            // 
            // txtUpdateDepotName
            // 
            this.txtUpdateDepotName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtUpdateDepotName.Location = new System.Drawing.Point(83, 24);
            this.txtUpdateDepotName.Name = "txtUpdateDepotName";
            this.txtUpdateDepotName.Size = new System.Drawing.Size(133, 20);
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
            this.txtUpdateContactTitle.Size = new System.Drawing.Size(133, 20);
            this.txtUpdateContactTitle.TabIndex = 2;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnUpdate.Location = new System.Drawing.Point(109, 220);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtUpdateContactName
            // 
            this.txtUpdateContactName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtUpdateContactName.Location = new System.Drawing.Point(83, 56);
            this.txtUpdateContactName.Name = "txtUpdateContactName";
            this.txtUpdateContactName.Size = new System.Drawing.Size(133, 20);
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
            this.btnCloseDepot.Location = new System.Drawing.Point(12, 485);
            this.btnCloseDepot.Name = "btnCloseDepot";
            this.btnCloseDepot.Size = new System.Drawing.Size(242, 40);
            this.btnCloseDepot.TabIndex = 5;
            this.btnCloseDepot.Text = "&Close Depot";
            this.toolTipInfo.SetToolTip(this.btnCloseDepot, "You delete the data of the selected depot from the database.\r\n");
            this.btnCloseDepot.UseVisualStyleBackColor = false;
            this.btnCloseDepot.Click += new System.EventHandler(this.btnCloseDepot_Click);
            // 
            // btnHomePage
            // 
            this.btnHomePage.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnHomePage.Image = ((System.Drawing.Image)(resources.GetObject("btnHomePage.Image")));
            this.btnHomePage.Location = new System.Drawing.Point(12, 3);
            this.btnHomePage.Name = "btnHomePage";
            this.btnHomePage.Size = new System.Drawing.Size(87, 70);
            this.btnHomePage.TabIndex = 0;
            this.btnHomePage.Text = "&Home Page";
            this.btnHomePage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHomePage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHomePage.UseVisualStyleBackColor = false;
            this.btnHomePage.Click += new System.EventHandler(this.btnHomePage_Click);
            // 
            // btnCloneDepot
            // 
            this.btnCloneDepot.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCloneDepot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCloneDepot.Image = ((System.Drawing.Image)(resources.GetObject("btnCloneDepot.Image")));
            this.btnCloneDepot.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloneDepot.Location = new System.Drawing.Point(13, 79);
            this.btnCloneDepot.Name = "btnCloneDepot";
            this.btnCloneDepot.Size = new System.Drawing.Size(165, 42);
            this.btnCloneDepot.TabIndex = 7;
            this.btnCloneDepot.Text = "Clo&ne Depot";
            this.btnCloneDepot.UseVisualStyleBackColor = false;
            this.btnCloneDepot.Click += new System.EventHandler(this.btnCloneDepot_Click);
            // 
            // DepotOperationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(978, 533);
            this.Controls.Add(this.btnCloneDepot);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.dgwProducts);
            this.Controls.Add(this.btnCloseDepot);
            this.Controls.Add(this.gbxAddDepot);
            this.Controls.Add(this.gbxSend);
            this.Controls.Add(this.gbxSearchByName);
            this.Controls.Add(this.btnHomePage);
            this.Controls.Add(this.dgwDepots);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DepotOperationsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Depot Operations Page";
            this.Load += new System.EventHandler(this.DepotOperationsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwDepots)).EndInit();
            this.gbxSearchByName.ResumeLayout(false);
            this.gbxSearchByName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSearch)).EndInit();
            this.gbxSend.ResumeLayout(false);
            this.gbxSend.PerformLayout();
            this.gbxAddDepot.ResumeLayout(false);
            this.gbxAddDepot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwDepots;
        private System.Windows.Forms.Button btnHomePage;
        private System.Windows.Forms.Label lblSendStock;
        private System.Windows.Forms.TextBox txtStockInput;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtDepotId;
        private System.Windows.Forms.TextBox txtProductIdDisplay;
        private System.Windows.Forms.TextBox txtUnitInStockDisplay;
        private System.Windows.Forms.GroupBox gbxSearchByName;
        private System.Windows.Forms.TextBox txtSearchDepotName;
        private System.Windows.Forms.Label lblSearchDepotName;
        private System.Windows.Forms.Label lblDepotId;
        private System.Windows.Forms.Label lblProductIdDisplay;
        private System.Windows.Forms.Label lblUnitInStockDisplay;
        private System.Windows.Forms.GroupBox gbxSend;
        private System.Windows.Forms.Button btnCloseDepot;
        private System.Windows.Forms.GroupBox gbxAddDepot;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtContactTitle;
        private System.Windows.Forms.TextBox txtContactName;
        private System.Windows.Forms.TextBox txtDepotName;
        private System.Windows.Forms.Label lblContactTitle;
        private System.Windows.Forms.Label lblContactName;
        private System.Windows.Forms.Label lblDepotName;
        private System.Windows.Forms.RichTextBox rtxtAdress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtUnitInStock;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Label lblUnitInStock;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.DataGridView dgwProducts;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.TextBox txtUpdateDepotName;
        private System.Windows.Forms.Label lblUpdateDepotName;
        private System.Windows.Forms.TextBox txtUpdateContactTitle;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtUpdateContactName;
        private System.Windows.Forms.Label lblUpdateContactTitle;
        private System.Windows.Forms.Label lblUpdateContactName;
        private System.Windows.Forms.TextBox txtUpdatePhone;
        private System.Windows.Forms.Label lblUpdatePhone;
        private System.Windows.Forms.RichTextBox txtUpdateAddress;
        private System.Windows.Forms.Label lblUpdateAddress;
        private System.Windows.Forms.ToolTip toolTipSearchDepotName;
        private System.Windows.Forms.ToolTip toolTipInfo;
        private System.Windows.Forms.PictureBox pbxSearch;
        private System.Windows.Forms.Button btnCloneDepot;
        private System.Windows.Forms.ComboBox cbxProducts;
        private System.Windows.Forms.Label lblProduct;
    }
}