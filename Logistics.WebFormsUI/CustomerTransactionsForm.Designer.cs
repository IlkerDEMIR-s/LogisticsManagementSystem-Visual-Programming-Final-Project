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
            ((System.ComponentModel.ISupportInitialize)(this.dgwCustomers)).BeginInit();
            this.gbxDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwCustomers
            // 
            this.dgwCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCustomers.Location = new System.Drawing.Point(12, 85);
            this.dgwCustomers.Name = "dgwCustomers";
            this.dgwCustomers.ReadOnly = true;
            this.dgwCustomers.Size = new System.Drawing.Size(833, 87);
            this.dgwCustomers.TabIndex = 0;
            this.dgwCustomers.TabStop = false;
            // 
            // btnHomePage
            // 
            this.btnHomePage.Image = ((System.Drawing.Image)(resources.GetObject("btnHomePage.Image")));
            this.btnHomePage.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHomePage.Location = new System.Drawing.Point(12, 12);
            this.btnHomePage.Name = "btnHomePage";
            this.btnHomePage.Size = new System.Drawing.Size(88, 67);
            this.btnHomePage.TabIndex = 0;
            this.btnHomePage.Text = "&Home Page";
            this.btnHomePage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHomePage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHomePage.UseVisualStyleBackColor = true;
            this.btnHomePage.Click += new System.EventHandler(this.btnHomePage_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteCustomer.Image")));
            this.btnDeleteCustomer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeleteCustomer.Location = new System.Drawing.Point(483, 19);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(216, 62);
            this.btnDeleteCustomer.TabIndex = 0;
            this.btnDeleteCustomer.Text = "&Delete Customer";
            this.btnDeleteCustomer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeleteCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // cbxCustomers
            // 
            this.cbxCustomers.FormattingEnabled = true;
            this.cbxCustomers.Location = new System.Drawing.Point(228, 21);
            this.cbxCustomers.Name = "cbxCustomers";
            this.cbxCustomers.Size = new System.Drawing.Size(219, 21);
            this.cbxCustomers.TabIndex = 1;
            this.cbxCustomers.SelectedValueChanged += new System.EventHandler(this.cbxCustomers_SelectedValueChanged);
            // 
            // lblCustomers
            // 
            this.lblCustomers.AutoSize = true;
            this.lblCustomers.Location = new System.Drawing.Point(166, 24);
            this.lblCustomers.Name = "lblCustomers";
            this.lblCustomers.Size = new System.Drawing.Size(56, 13);
            this.lblCustomers.TabIndex = 7;
            this.lblCustomers.Text = "Customers";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(453, 21);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(92, 23);
            this.btnAddCustomer.TabIndex = 2;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // gbxDelete
            // 
            this.gbxDelete.Controls.Add(this.cbxDeleteCustomer);
            this.gbxDelete.Controls.Add(this.btnDeleteCustomer);
            this.gbxDelete.Location = new System.Drawing.Point(12, 188);
            this.gbxDelete.Name = "gbxDelete";
            this.gbxDelete.Size = new System.Drawing.Size(833, 97);
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
            this.cbxDeleteCustomer.Location = new System.Drawing.Point(47, 35);
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
            // CustomerTransactionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 296);
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
    }
}