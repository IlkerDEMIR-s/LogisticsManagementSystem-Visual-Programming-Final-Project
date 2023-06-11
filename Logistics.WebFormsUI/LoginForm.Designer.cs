namespace Logistics.WebFormsUI
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.cbxCompanyName = new System.Windows.Forms.ComboBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cbxShowPassword = new System.Windows.Forms.CheckBox();
            this.cbxFactoryType = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblFactoryType = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.toolTipPassword = new System.Windows.Forms.ToolTip(this.components);
            this.lblRegisterSys = new System.Windows.Forms.LinkLabel();
            this.btnDirectEntry = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pbxCopyright = new System.Windows.Forms.PictureBox();
            this.lblCopyrightName = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pbxMain = new System.Windows.Forms.PictureBox();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCopyright)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMain)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxCompanyName
            // 
            this.cbxCompanyName.FormattingEnabled = true;
            this.cbxCompanyName.Location = new System.Drawing.Point(614, 168);
            this.cbxCompanyName.Name = "cbxCompanyName";
            this.cbxCompanyName.Size = new System.Drawing.Size(168, 21);
            this.cbxCompanyName.TabIndex = 2;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogin.ForeColor = System.Drawing.Color.MintCream;
            this.btnLogin.Location = new System.Drawing.Point(533, 302);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(237, 33);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "&Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.IndianRed;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.Color.MintCream;
            this.btnExit.Location = new System.Drawing.Point(533, 348);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(237, 33);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cbxShowPassword
            // 
            this.cbxShowPassword.AutoSize = true;
            this.cbxShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.cbxShowPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxShowPassword.ForeColor = System.Drawing.Color.SlateGray;
            this.cbxShowPassword.Location = new System.Drawing.Point(614, 234);
            this.cbxShowPassword.Name = "cbxShowPassword";
            this.cbxShowPassword.Size = new System.Drawing.Size(59, 19);
            this.cbxShowPassword.TabIndex = 4;
            this.cbxShowPassword.Text = "show";
            this.cbxShowPassword.UseVisualStyleBackColor = false;
            this.cbxShowPassword.CheckedChanged += new System.EventHandler(this.cbxShowPassword_CheckedChanged);
            // 
            // cbxFactoryType
            // 
            this.cbxFactoryType.FormattingEnabled = true;
            this.cbxFactoryType.Location = new System.Drawing.Point(614, 125);
            this.cbxFactoryType.Name = "cbxFactoryType";
            this.cbxFactoryType.Size = new System.Drawing.Size(168, 21);
            this.cbxFactoryType.TabIndex = 1;
            this.cbxFactoryType.SelectedIndexChanged += new System.EventHandler(this.cbxFactoryType_SelectedIndexChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(614, 208);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(168, 20);
            this.txtPassword.TabIndex = 3;
            this.toolTipPassword.SetToolTip(this.txtPassword, "Please enter your password.\r\n");
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPassword.ForeColor = System.Drawing.Color.SlateGray;
            this.lblPassword.Location = new System.Drawing.Point(522, 208);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(86, 20);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Password";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.BackColor = System.Drawing.Color.Transparent;
            this.lblCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCompanyName.ForeColor = System.Drawing.Color.SlateGray;
            this.lblCompanyName.Location = new System.Drawing.Point(474, 166);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(134, 20);
            this.lblCompanyName.TabIndex = 6;
            this.lblCompanyName.Text = "Company Name";
            // 
            // lblFactoryType
            // 
            this.lblFactoryType.AutoSize = true;
            this.lblFactoryType.BackColor = System.Drawing.Color.Transparent;
            this.lblFactoryType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFactoryType.ForeColor = System.Drawing.Color.SlateGray;
            this.lblFactoryType.Location = new System.Drawing.Point(496, 123);
            this.lblFactoryType.Name = "lblFactoryType";
            this.lblFactoryType.Size = new System.Drawing.Size(112, 20);
            this.lblFactoryType.TabIndex = 5;
            this.lblFactoryType.Text = "Factory Type";
            this.lblFactoryType.UseMnemonic = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.ForeColor = System.Drawing.Color.NavajoWhite;
            this.lblTitle.Location = new System.Drawing.Point(24, 341);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(420, 37);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Logistics Management System";
            // 
            // lblRegisterSys
            // 
            this.lblRegisterSys.AutoSize = true;
            this.lblRegisterSys.BackColor = System.Drawing.Color.Transparent;
            this.lblRegisterSys.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRegisterSys.LinkColor = System.Drawing.Color.DarkBlue;
            this.lblRegisterSys.Location = new System.Drawing.Point(611, 265);
            this.lblRegisterSys.Name = "lblRegisterSys";
            this.lblRegisterSys.Size = new System.Drawing.Size(138, 16);
            this.lblRegisterSys.TabIndex = 5;
            this.lblRegisterSys.TabStop = true;
            this.lblRegisterSys.Text = "Register in the system";
            this.lblRegisterSys.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblRegisterSys_LinkClicked);
            // 
            // btnDirectEntry
            // 
            this.btnDirectEntry.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnDirectEntry.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDirectEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDirectEntry.ForeColor = System.Drawing.Color.White;
            this.btnDirectEntry.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDirectEntry.Location = new System.Drawing.Point(614, 79);
            this.btnDirectEntry.Name = "btnDirectEntry";
            this.btnDirectEntry.Size = new System.Drawing.Size(168, 30);
            this.btnDirectEntry.TabIndex = 0;
            this.btnDirectEntry.Text = "Direct Entry";
            this.btnDirectEntry.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDirectEntry.UseVisualStyleBackColor = false;
            this.btnDirectEntry.Click += new System.EventHandler(this.btnDirectEntry_Click_1);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.SlateGray;
            this.pnlMain.Controls.Add(this.pbxCopyright);
            this.pnlMain.Controls.Add(this.lblCopyrightName);
            this.pnlMain.Controls.Add(this.lblWelcome);
            this.pnlMain.Controls.Add(this.pbxMain);
            this.pnlMain.Controls.Add(this.lblTitle);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(467, 430);
            this.pnlMain.TabIndex = 8;
            // 
            // pbxCopyright
            // 
            this.pbxCopyright.BackColor = System.Drawing.Color.Transparent;
            this.pbxCopyright.Image = ((System.Drawing.Image)(resources.GetObject("pbxCopyright.Image")));
            this.pbxCopyright.Location = new System.Drawing.Point(216, 412);
            this.pbxCopyright.Name = "pbxCopyright";
            this.pbxCopyright.Size = new System.Drawing.Size(19, 15);
            this.pbxCopyright.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCopyright.TabIndex = 11;
            this.pbxCopyright.TabStop = false;
            // 
            // lblCopyrightName
            // 
            this.lblCopyrightName.AutoSize = true;
            this.lblCopyrightName.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyrightName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCopyrightName.ForeColor = System.Drawing.Color.White;
            this.lblCopyrightName.Location = new System.Drawing.Point(233, 414);
            this.lblCopyrightName.Name = "lblCopyrightName";
            this.lblCopyrightName.Size = new System.Drawing.Size(231, 13);
            this.lblCopyrightName.TabIndex = 10;
            this.lblCopyrightName.Text = "2023 Ilker DEMIR | All Rights Reserved";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Trebuchet MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWelcome.ForeColor = System.Drawing.Color.NavajoWhite;
            this.lblWelcome.Location = new System.Drawing.Point(22, 295);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(224, 46);
            this.lblWelcome.TabIndex = 7;
            this.lblWelcome.Text = "Welcome to";
            // 
            // pbxMain
            // 
            this.pbxMain.Image = ((System.Drawing.Image)(resources.GetObject("pbxMain.Image")));
            this.pbxMain.Location = new System.Drawing.Point(12, 12);
            this.pbxMain.Name = "pbxMain";
            this.pbxMain.Size = new System.Drawing.Size(443, 265);
            this.pbxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxMain.TabIndex = 0;
            this.pbxMain.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(811, 430);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.btnDirectEntry);
            this.Controls.Add(this.lblRegisterSys);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.lblFactoryType);
            this.Controls.Add(this.cbxCompanyName);
            this.Controls.Add(this.cbxShowPassword);
            this.Controls.Add(this.cbxFactoryType);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnExit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logistics Management System";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCopyright)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxCompanyName;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckBox cbxShowPassword;
        private System.Windows.Forms.ComboBox cbxFactoryType;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblFactoryType;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ToolTip toolTipPassword;
        private System.Windows.Forms.LinkLabel lblRegisterSys;
        private System.Windows.Forms.Button btnDirectEntry;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.PictureBox pbxMain;
        private System.Windows.Forms.Label lblCopyrightName;
        private System.Windows.Forms.PictureBox pbxCopyright;
    }
}

