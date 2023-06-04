namespace Logistics.WebFormsUI
{
    partial class CustomerMyOrdersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerMyOrdersForm));
            this.dgwOrders = new System.Windows.Forms.DataGridView();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnShowDetails = new System.Windows.Forms.Button();
            this.rtbInfo = new System.Windows.Forms.RichTextBox();
            this.gbxViewDetails = new System.Windows.Forms.GroupBox();
            this.gbxApproval = new System.Windows.Forms.GroupBox();
            this.cbxApprove = new System.Windows.Forms.ComboBox();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnHomePage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOrders)).BeginInit();
            this.gbxViewDetails.SuspendLayout();
            this.gbxApproval.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwOrders
            // 
            this.dgwOrders.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dgwOrders.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgwOrders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgwOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOrders.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgwOrders.Location = new System.Drawing.Point(12, 91);
            this.dgwOrders.Name = "dgwOrders";
            this.dgwOrders.Size = new System.Drawing.Size(863, 165);
            this.dgwOrders.TabIndex = 1;
            this.dgwOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwOrders_CellClick);
            this.dgwOrders.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgwOrders_CellFormatting);
            // 
            // cbxStatus
            // 
            this.cbxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Location = new System.Drawing.Point(167, 40);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(156, 23);
            this.cbxStatus.TabIndex = 1;
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFilter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFilter.Location = new System.Drawing.Point(329, 40);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(92, 23);
            this.btnFilter.TabIndex = 2;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStatus.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblStatus.Location = new System.Drawing.Point(120, 43);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(44, 16);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "Status";
            // 
            // btnShowDetails
            // 
            this.btnShowDetails.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnShowDetails.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnShowDetails.Location = new System.Drawing.Point(287, 133);
            this.btnShowDetails.Name = "btnShowDetails";
            this.btnShowDetails.Size = new System.Drawing.Size(122, 33);
            this.btnShowDetails.TabIndex = 0;
            this.btnShowDetails.Text = "&Show Details";
            this.btnShowDetails.UseVisualStyleBackColor = false;
            this.btnShowDetails.Click += new System.EventHandler(this.btnShowDetails_Click);
            // 
            // rtbInfo
            // 
            this.rtbInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbInfo.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbInfo.Location = new System.Drawing.Point(16, 19);
            this.rtbInfo.Name = "rtbInfo";
            this.rtbInfo.Size = new System.Drawing.Size(393, 112);
            this.rtbInfo.TabIndex = 15;
            this.rtbInfo.Text = "";
            // 
            // gbxViewDetails
            // 
            this.gbxViewDetails.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gbxViewDetails.Controls.Add(this.rtbInfo);
            this.gbxViewDetails.Controls.Add(this.btnShowDetails);
            this.gbxViewDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxViewDetails.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gbxViewDetails.Location = new System.Drawing.Point(12, 271);
            this.gbxViewDetails.Name = "gbxViewDetails";
            this.gbxViewDetails.Size = new System.Drawing.Size(420, 174);
            this.gbxViewDetails.TabIndex = 3;
            this.gbxViewDetails.TabStop = false;
            this.gbxViewDetails.Text = "View Details";
            // 
            // gbxApproval
            // 
            this.gbxApproval.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gbxApproval.Controls.Add(this.cbxApprove);
            this.gbxApproval.Controls.Add(this.btnApprove);
            this.gbxApproval.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxApproval.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gbxApproval.Location = new System.Drawing.Point(461, 272);
            this.gbxApproval.Name = "gbxApproval";
            this.gbxApproval.Size = new System.Drawing.Size(414, 173);
            this.gbxApproval.TabIndex = 4;
            this.gbxApproval.TabStop = false;
            this.gbxApproval.Text = "Approval";
            // 
            // cbxApprove
            // 
            this.cbxApprove.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cbxApprove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxApprove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxApprove.ForeColor = System.Drawing.Color.White;
            this.cbxApprove.FormattingEnabled = true;
            this.cbxApprove.Location = new System.Drawing.Point(70, 79);
            this.cbxApprove.Name = "cbxApprove";
            this.cbxApprove.Size = new System.Drawing.Size(146, 23);
            this.cbxApprove.TabIndex = 0;
            // 
            // btnApprove
            // 
            this.btnApprove.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApprove.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnApprove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnApprove.Location = new System.Drawing.Point(240, 74);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(122, 33);
            this.btnApprove.TabIndex = 1;
            this.btnApprove.Text = "&Approve";
            this.btnApprove.UseVisualStyleBackColor = false;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnHomePage
            // 
            this.btnHomePage.Image = ((System.Drawing.Image)(resources.GetObject("btnHomePage.Image")));
            this.btnHomePage.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHomePage.Location = new System.Drawing.Point(12, 12);
            this.btnHomePage.Name = "btnHomePage";
            this.btnHomePage.Size = new System.Drawing.Size(88, 63);
            this.btnHomePage.TabIndex = 0;
            this.btnHomePage.Text = "&Home Page";
            this.btnHomePage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHomePage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHomePage.UseVisualStyleBackColor = true;
            this.btnHomePage.Click += new System.EventHandler(this.btnHomePage_Click);
            // 
            // CustomerMyOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 461);
            this.Controls.Add(this.btnHomePage);
            this.Controls.Add(this.gbxApproval);
            this.Controls.Add(this.gbxViewDetails);
            this.Controls.Add(this.cbxStatus);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.dgwOrders);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomerMyOrdersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Orders Form";
            this.Load += new System.EventHandler(this.CustomerMyOrdersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwOrders)).EndInit();
            this.gbxViewDetails.ResumeLayout(false);
            this.gbxApproval.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwOrders;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnShowDetails;
        private System.Windows.Forms.RichTextBox rtbInfo;
        private System.Windows.Forms.GroupBox gbxViewDetails;
        private System.Windows.Forms.GroupBox gbxApproval;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.ComboBox cbxApprove;
        private System.Windows.Forms.Button btnHomePage;
    }
}