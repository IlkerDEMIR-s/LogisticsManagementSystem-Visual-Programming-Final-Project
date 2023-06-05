namespace Logistics.WebFormsUI
{
    partial class ProductOperationsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductOperationsForm));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxUpdateCategory = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtUpdateUnitInStock = new System.Windows.Forms.TextBox();
            this.txtUpdateUnitPrice = new System.Windows.Forms.TextBox();
            this.txtUpdateProductName = new System.Windows.Forms.TextBox();
            this.lblUpdateUnitInStock = new System.Windows.Forms.Label();
            this.lblUpdateUnitPrice = new System.Windows.Forms.Label();
            this.lblUpdateCategory = new System.Windows.Forms.Label();
            this.lblUpdateProductName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxAddCategory = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtAddUnitInStock = new System.Windows.Forms.TextBox();
            this.txtAddUnitPrice = new System.Windows.Forms.TextBox();
            this.txtAddProductName = new System.Windows.Forms.TextBox();
            this.lblAddUnitInStock = new System.Windows.Forms.Label();
            this.lblAddUnitPrice = new System.Windows.Forms.Label();
            this.lblAddCategory = new System.Windows.Forms.Label();
            this.lblAddProductName = new System.Windows.Forms.Label();
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.lblSearchProductName = new System.Windows.Forms.Label();
            this.txtSearchProductName = new System.Windows.Forms.TextBox();
            this.gbxSearchByName = new System.Windows.Forms.GroupBox();
            this.pbxSearch = new System.Windows.Forms.PictureBox();
            this.btnHomePage = new System.Windows.Forms.Button();
            this.toolTipSearchName = new System.Windows.Forms.ToolTip(this.components);
            this.gbxCategory = new System.Windows.Forms.GroupBox();
            this.cbxSearchCategory = new System.Windows.Forms.ComboBox();
            this.lblSelect = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.gbxSearchByName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSearch)).BeginInit();
            this.gbxCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxUpdateCategory);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.txtUpdateUnitInStock);
            this.groupBox2.Controls.Add(this.txtUpdateUnitPrice);
            this.groupBox2.Controls.Add(this.txtUpdateProductName);
            this.groupBox2.Controls.Add(this.lblUpdateUnitInStock);
            this.groupBox2.Controls.Add(this.lblUpdateUnitPrice);
            this.groupBox2.Controls.Add(this.lblUpdateCategory);
            this.groupBox2.Controls.Add(this.lblUpdateProductName);
            this.groupBox2.Location = new System.Drawing.Point(370, 251);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 207);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update product";
            // 
            // cbxUpdateCategory
            // 
            this.cbxUpdateCategory.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cbxUpdateCategory.FormattingEnabled = true;
            this.cbxUpdateCategory.Location = new System.Drawing.Point(105, 59);
            this.cbxUpdateCategory.Name = "cbxUpdateCategory";
            this.cbxUpdateCategory.Size = new System.Drawing.Size(121, 21);
            this.cbxUpdateCategory.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnUpdate.Location = new System.Drawing.Point(121, 160);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtUpdateUnitInStock
            // 
            this.txtUpdateUnitInStock.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtUpdateUnitInStock.Location = new System.Drawing.Point(105, 134);
            this.txtUpdateUnitInStock.Name = "txtUpdateUnitInStock";
            this.txtUpdateUnitInStock.Size = new System.Drawing.Size(121, 20);
            this.txtUpdateUnitInStock.TabIndex = 3;
            // 
            // txtUpdateUnitPrice
            // 
            this.txtUpdateUnitPrice.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtUpdateUnitPrice.Location = new System.Drawing.Point(105, 97);
            this.txtUpdateUnitPrice.Name = "txtUpdateUnitPrice";
            this.txtUpdateUnitPrice.Size = new System.Drawing.Size(121, 20);
            this.txtUpdateUnitPrice.TabIndex = 2;
            // 
            // txtUpdateProductName
            // 
            this.txtUpdateProductName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtUpdateProductName.Location = new System.Drawing.Point(105, 20);
            this.txtUpdateProductName.Name = "txtUpdateProductName";
            this.txtUpdateProductName.Size = new System.Drawing.Size(121, 20);
            this.txtUpdateProductName.TabIndex = 0;
            // 
            // lblUpdateUnitInStock
            // 
            this.lblUpdateUnitInStock.AutoSize = true;
            this.lblUpdateUnitInStock.Location = new System.Drawing.Point(24, 141);
            this.lblUpdateUnitInStock.Name = "lblUpdateUnitInStock";
            this.lblUpdateUnitInStock.Size = new System.Drawing.Size(74, 13);
            this.lblUpdateUnitInStock.TabIndex = 3;
            this.lblUpdateUnitInStock.Text = "Units In Stock";
            // 
            // lblUpdateUnitPrice
            // 
            this.lblUpdateUnitPrice.AutoSize = true;
            this.lblUpdateUnitPrice.Location = new System.Drawing.Point(49, 100);
            this.lblUpdateUnitPrice.Name = "lblUpdateUnitPrice";
            this.lblUpdateUnitPrice.Size = new System.Drawing.Size(50, 13);
            this.lblUpdateUnitPrice.TabIndex = 2;
            this.lblUpdateUnitPrice.Text = "UnitPrice";
            // 
            // lblUpdateCategory
            // 
            this.lblUpdateCategory.AutoSize = true;
            this.lblUpdateCategory.Location = new System.Drawing.Point(50, 59);
            this.lblUpdateCategory.Name = "lblUpdateCategory";
            this.lblUpdateCategory.Size = new System.Drawing.Size(49, 13);
            this.lblUpdateCategory.TabIndex = 1;
            this.lblUpdateCategory.Text = "Category";
            // 
            // lblUpdateProductName
            // 
            this.lblUpdateProductName.AutoSize = true;
            this.lblUpdateProductName.Location = new System.Drawing.Point(24, 23);
            this.lblUpdateProductName.Name = "lblUpdateProductName";
            this.lblUpdateProductName.Size = new System.Drawing.Size(75, 13);
            this.lblUpdateProductName.TabIndex = 0;
            this.lblUpdateProductName.Text = "Product Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxAddCategory);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtAddUnitInStock);
            this.groupBox1.Controls.Add(this.txtAddUnitPrice);
            this.groupBox1.Controls.Add(this.txtAddProductName);
            this.groupBox1.Controls.Add(this.lblAddUnitInStock);
            this.groupBox1.Controls.Add(this.lblAddUnitPrice);
            this.groupBox1.Controls.Add(this.lblAddCategory);
            this.groupBox1.Controls.Add(this.lblAddProductName);
            this.groupBox1.Location = new System.Drawing.Point(16, 253);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 205);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add new product";
            // 
            // cbxAddCategory
            // 
            this.cbxAddCategory.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cbxAddCategory.FormattingEnabled = true;
            this.cbxAddCategory.Location = new System.Drawing.Point(105, 59);
            this.cbxAddCategory.Name = "cbxAddCategory";
            this.cbxAddCategory.Size = new System.Drawing.Size(121, 21);
            this.cbxAddCategory.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAdd.Location = new System.Drawing.Point(151, 167);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtAddUnitInStock
            // 
            this.txtAddUnitInStock.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtAddUnitInStock.Location = new System.Drawing.Point(105, 132);
            this.txtAddUnitInStock.Name = "txtAddUnitInStock";
            this.txtAddUnitInStock.Size = new System.Drawing.Size(121, 20);
            this.txtAddUnitInStock.TabIndex = 3;
            // 
            // txtAddUnitPrice
            // 
            this.txtAddUnitPrice.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtAddUnitPrice.Location = new System.Drawing.Point(105, 97);
            this.txtAddUnitPrice.Name = "txtAddUnitPrice";
            this.txtAddUnitPrice.Size = new System.Drawing.Size(121, 20);
            this.txtAddUnitPrice.TabIndex = 2;
            // 
            // txtAddProductName
            // 
            this.txtAddProductName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtAddProductName.Location = new System.Drawing.Point(105, 23);
            this.txtAddProductName.Name = "txtAddProductName";
            this.txtAddProductName.Size = new System.Drawing.Size(121, 20);
            this.txtAddProductName.TabIndex = 0;
            // 
            // lblAddUnitInStock
            // 
            this.lblAddUnitInStock.AutoSize = true;
            this.lblAddUnitInStock.Location = new System.Drawing.Point(24, 132);
            this.lblAddUnitInStock.Name = "lblAddUnitInStock";
            this.lblAddUnitInStock.Size = new System.Drawing.Size(74, 13);
            this.lblAddUnitInStock.TabIndex = 3;
            this.lblAddUnitInStock.Text = "Units In Stock";
            // 
            // lblAddUnitPrice
            // 
            this.lblAddUnitPrice.AutoSize = true;
            this.lblAddUnitPrice.Location = new System.Drawing.Point(48, 97);
            this.lblAddUnitPrice.Name = "lblAddUnitPrice";
            this.lblAddUnitPrice.Size = new System.Drawing.Size(50, 13);
            this.lblAddUnitPrice.TabIndex = 2;
            this.lblAddUnitPrice.Text = "UnitPrice";
            // 
            // lblAddCategory
            // 
            this.lblAddCategory.AutoSize = true;
            this.lblAddCategory.Location = new System.Drawing.Point(50, 59);
            this.lblAddCategory.Name = "lblAddCategory";
            this.lblAddCategory.Size = new System.Drawing.Size(49, 13);
            this.lblAddCategory.TabIndex = 1;
            this.lblAddCategory.Text = "Category";
            // 
            // lblAddProductName
            // 
            this.lblAddProductName.AutoSize = true;
            this.lblAddProductName.Location = new System.Drawing.Point(23, 23);
            this.lblAddProductName.Name = "lblAddProductName";
            this.lblAddProductName.Size = new System.Drawing.Size(75, 13);
            this.lblAddProductName.TabIndex = 0;
            this.lblAddProductName.Text = "Product Name";
            // 
            // dgwProduct
            // 
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(16, 95);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.ReadOnly = true;
            this.dgwProduct.Size = new System.Drawing.Size(660, 134);
            this.dgwProduct.TabIndex = 6;
            this.dgwProduct.TabStop = false;
            this.dgwProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellClick);
            this.dgwProduct.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgwProduct_CellFormatting);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteProduct.Image")));
            this.btnDeleteProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteProduct.Location = new System.Drawing.Point(22, 464);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(190, 40);
            this.btnDeleteProduct.TabIndex = 5;
            this.btnDeleteProduct.Text = "&Delete Product";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // lblSearchProductName
            // 
            this.lblSearchProductName.AutoSize = true;
            this.lblSearchProductName.Location = new System.Drawing.Point(6, 38);
            this.lblSearchProductName.Name = "lblSearchProductName";
            this.lblSearchProductName.Size = new System.Drawing.Size(75, 13);
            this.lblSearchProductName.TabIndex = 0;
            this.lblSearchProductName.Text = "Product Name";
            // 
            // txtSearchProductName
            // 
            this.txtSearchProductName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtSearchProductName.Location = new System.Drawing.Point(87, 35);
            this.txtSearchProductName.Name = "txtSearchProductName";
            this.txtSearchProductName.Size = new System.Drawing.Size(160, 20);
            this.txtSearchProductName.TabIndex = 0;
            this.toolTipSearchName.SetToolTip(this.txtSearchProductName, "Enter the name of the product you want to find.\r\n");
            this.txtSearchProductName.TextChanged += new System.EventHandler(this.txtSearchProductName_TextChanged);
            // 
            // gbxSearchByName
            // 
            this.gbxSearchByName.Controls.Add(this.pbxSearch);
            this.gbxSearchByName.Controls.Add(this.txtSearchProductName);
            this.gbxSearchByName.Controls.Add(this.lblSearchProductName);
            this.gbxSearchByName.Location = new System.Drawing.Point(385, 12);
            this.gbxSearchByName.Name = "gbxSearchByName";
            this.gbxSearchByName.Size = new System.Drawing.Size(291, 67);
            this.gbxSearchByName.TabIndex = 2;
            this.gbxSearchByName.TabStop = false;
            this.gbxSearchByName.Text = "Search by Name";
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
            // btnHomePage
            // 
            this.btnHomePage.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnHomePage.Image = ((System.Drawing.Image)(resources.GetObject("btnHomePage.Image")));
            this.btnHomePage.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHomePage.Location = new System.Drawing.Point(14, 12);
            this.btnHomePage.Name = "btnHomePage";
            this.btnHomePage.Size = new System.Drawing.Size(88, 67);
            this.btnHomePage.TabIndex = 0;
            this.btnHomePage.Text = "&Home Page";
            this.btnHomePage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHomePage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHomePage.UseVisualStyleBackColor = false;
            this.btnHomePage.Click += new System.EventHandler(this.btnHomePage_Click);
            // 
            // gbxCategory
            // 
            this.gbxCategory.Controls.Add(this.cbxSearchCategory);
            this.gbxCategory.Controls.Add(this.lblSelect);
            this.gbxCategory.Location = new System.Drawing.Point(108, 12);
            this.gbxCategory.Name = "gbxCategory";
            this.gbxCategory.Size = new System.Drawing.Size(271, 67);
            this.gbxCategory.TabIndex = 1;
            this.gbxCategory.TabStop = false;
            this.gbxCategory.Text = "Search by Category";
            // 
            // cbxSearchCategory
            // 
            this.cbxSearchCategory.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cbxSearchCategory.FormattingEnabled = true;
            this.cbxSearchCategory.Location = new System.Drawing.Point(95, 35);
            this.cbxSearchCategory.Name = "cbxSearchCategory";
            this.cbxSearchCategory.Size = new System.Drawing.Size(170, 21);
            this.cbxSearchCategory.TabIndex = 0;
            this.cbxSearchCategory.SelectedIndexChanged += new System.EventHandler(this.cbxSearchCategory_SelectedIndexChanged);
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Location = new System.Drawing.Point(6, 38);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(82, 13);
            this.lblSelect.TabIndex = 0;
            this.lblSelect.Text = "Select Category";
            // 
            // ProductOperationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(688, 507);
            this.Controls.Add(this.gbxCategory);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.btnHomePage);
            this.Controls.Add(this.gbxSearchByName);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgwProduct);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProductOperationsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Operations  Page";
            this.Load += new System.EventHandler(this.ProductOperationsForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.gbxSearchByName.ResumeLayout(false);
            this.gbxSearchByName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSearch)).EndInit();
            this.gbxCategory.ResumeLayout(false);
            this.gbxCategory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtUpdateUnitInStock;
        private System.Windows.Forms.TextBox txtUpdateUnitPrice;
        private System.Windows.Forms.TextBox txtUpdateProductName;
        private System.Windows.Forms.Label lblUpdateUnitInStock;
        private System.Windows.Forms.Label lblUpdateUnitPrice;
        private System.Windows.Forms.Label lblUpdateProductName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtAddUnitInStock;
        private System.Windows.Forms.TextBox txtAddUnitPrice;
        private System.Windows.Forms.TextBox txtAddProductName;
        private System.Windows.Forms.Label lblAddUnitInStock;
        private System.Windows.Forms.Label lblAddUnitPrice;
        private System.Windows.Forms.Label lblAddProductName;
        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnHomePage;
        private System.Windows.Forms.Label lblSearchProductName;
        private System.Windows.Forms.TextBox txtSearchProductName;
        private System.Windows.Forms.GroupBox gbxSearchByName;
        private System.Windows.Forms.ToolTip toolTipSearchName;
        private System.Windows.Forms.ComboBox cbxUpdateCategory;
        private System.Windows.Forms.Label lblUpdateCategory;
        private System.Windows.Forms.ComboBox cbxAddCategory;
        private System.Windows.Forms.Label lblAddCategory;
        private System.Windows.Forms.GroupBox gbxCategory;
        private System.Windows.Forms.ComboBox cbxSearchCategory;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.PictureBox pbxSearch;
    }
}