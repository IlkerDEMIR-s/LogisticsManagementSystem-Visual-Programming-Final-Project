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
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtContactTitle = new System.Windows.Forms.TextBox();
            this.txtContactName = new System.Windows.Forms.TextBox();
            this.txtDepotName = new System.Windows.Forms.TextBox();
            this.lblContactTitle = new System.Windows.Forms.Label();
            this.lblContactName = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
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
            this.gbxSearchByName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDepots)).BeginInit();
            this.gbxAddDepot.SuspendLayout();
            this.gbxUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHomePage
            // 
            this.btnHomePage.Image = ((System.Drawing.Image)(resources.GetObject("btnHomePage.Image")));
            this.btnHomePage.Location = new System.Drawing.Point(12, 12);
            this.btnHomePage.Name = "btnHomePage";
            this.btnHomePage.Size = new System.Drawing.Size(87, 67);
            this.btnHomePage.TabIndex = 0;
            this.btnHomePage.Text = "&Home Page";
            this.btnHomePage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHomePage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHomePage.UseVisualStyleBackColor = true;
            this.btnHomePage.Click += new System.EventHandler(this.btnHomePage_Click);
            // 
            // gbxSearchByName
            // 
            this.gbxSearchByName.Controls.Add(this.pbxSearch);
            this.gbxSearchByName.Controls.Add(this.txtSearchDepotName);
            this.gbxSearchByName.Controls.Add(this.lblSearchDepotName);
            this.gbxSearchByName.Location = new System.Drawing.Point(115, 12);
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
            this.txtSearchDepotName.Location = new System.Drawing.Point(87, 35);
            this.txtSearchDepotName.Name = "txtSearchDepotName";
            this.txtSearchDepotName.Size = new System.Drawing.Size(163, 20);
            this.txtSearchDepotName.TabIndex = 0;
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
            // dgwDepots
            // 
            this.dgwDepots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDepots.Location = new System.Drawing.Point(12, 85);
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
            this.gbxAddDepot.Controls.Add(this.txtProductId);
            this.gbxAddDepot.Controls.Add(this.btnAdd);
            this.gbxAddDepot.Controls.Add(this.txtContactTitle);
            this.gbxAddDepot.Controls.Add(this.txtContactName);
            this.gbxAddDepot.Controls.Add(this.txtDepotName);
            this.gbxAddDepot.Controls.Add(this.lblContactTitle);
            this.gbxAddDepot.Controls.Add(this.lblContactName);
            this.gbxAddDepot.Controls.Add(this.lblProductID);
            this.gbxAddDepot.Controls.Add(this.lblDepotName);
            this.gbxAddDepot.Location = new System.Drawing.Point(12, 232);
            this.gbxAddDepot.Name = "gbxAddDepot";
            this.gbxAddDepot.Size = new System.Drawing.Size(412, 251);
            this.gbxAddDepot.TabIndex = 2;
            this.gbxAddDepot.TabStop = false;
            this.gbxAddDepot.Text = "Add new depot";
            // 
            // txtCountry
            // 
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
            this.rtxtAdress.Location = new System.Drawing.Point(83, 158);
            this.rtxtAdress.Name = "rtxtAdress";
            this.rtxtAdress.Size = new System.Drawing.Size(308, 58);
            this.rtxtAdress.TabIndex = 4;
            this.rtxtAdress.Text = "";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(276, 92);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(115, 20);
            this.txtPhone.TabIndex = 7;
            // 
            // txtUnitInStock
            // 
            this.txtUnitInStock.Location = new System.Drawing.Point(276, 129);
            this.txtUnitInStock.Name = "txtUnitInStock";
            this.txtUnitInStock.Size = new System.Drawing.Size(115, 20);
            this.txtUnitInStock.TabIndex = 8;
            // 
            // txtCity
            // 
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
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(83, 57);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(115, 20);
            this.txtProductId.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(178, 222);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtContactTitle
            // 
            this.txtContactTitle.Location = new System.Drawing.Point(83, 129);
            this.txtContactTitle.Name = "txtContactTitle";
            this.txtContactTitle.Size = new System.Drawing.Size(115, 20);
            this.txtContactTitle.TabIndex = 3;
            // 
            // txtContactName
            // 
            this.txtContactName.Location = new System.Drawing.Point(83, 94);
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.Size = new System.Drawing.Size(115, 20);
            this.txtContactName.TabIndex = 2;
            // 
            // txtDepotName
            // 
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
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(19, 60);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(58, 13);
            this.lblProductID.TabIndex = 1;
            this.lblProductID.Text = "Product ID";
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
            this.gbxUpdate.Location = new System.Drawing.Point(442, 232);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(469, 251);
            this.gbxUpdate.TabIndex = 3;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Update depot";
            // 
            // txtUpdateUnitInStock
            // 
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
            this.txtUpdateAddress.Location = new System.Drawing.Point(83, 158);
            this.txtUpdateAddress.Name = "txtUpdateAddress";
            this.txtUpdateAddress.Size = new System.Drawing.Size(360, 47);
            this.txtUpdateAddress.TabIndex = 4;
            this.txtUpdateAddress.Text = "";
            // 
            // txtUpdateDepotName
            // 
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
            this.txtUpdateContactTitle.Location = new System.Drawing.Point(83, 91);
            this.txtUpdateContactTitle.Name = "txtUpdateContactTitle";
            this.txtUpdateContactTitle.Size = new System.Drawing.Size(163, 20);
            this.txtUpdateContactTitle.TabIndex = 2;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(109, 220);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtUpdateContactName
            // 
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
            this.btnCloseDepot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCloseDepot.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseDepot.Image")));
            this.btnCloseDepot.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseDepot.Location = new System.Drawing.Point(749, 12);
            this.btnCloseDepot.Name = "btnCloseDepot";
            this.btnCloseDepot.Size = new System.Drawing.Size(161, 67);
            this.btnCloseDepot.TabIndex = 4;
            this.btnCloseDepot.Text = "&Close Depot";
            this.btnCloseDepot.UseVisualStyleBackColor = true;
            this.btnCloseDepot.Click += new System.EventHandler(this.btnCloseDepot_Click);
            // 
            // CustomerDepotOperationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 494);
            this.Controls.Add(this.btnCloseDepot);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.gbxAddDepot);
            this.Controls.Add(this.dgwDepots);
            this.Controls.Add(this.gbxSearchByName);
            this.Controls.Add(this.btnHomePage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomerDepotOperationsForm";
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
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtContactTitle;
        private System.Windows.Forms.TextBox txtContactName;
        private System.Windows.Forms.TextBox txtDepotName;
        private System.Windows.Forms.Label lblContactTitle;
        private System.Windows.Forms.Label lblContactName;
        private System.Windows.Forms.Label lblProductID;
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
    }
}