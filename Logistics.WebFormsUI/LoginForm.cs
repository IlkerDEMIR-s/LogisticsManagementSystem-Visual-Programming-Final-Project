using Logistics.Business.Abstract;
using Logistics.Business.DependencyResolvers.Ninject;
using Logistics.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Logistics.WebFormsUI
{
    public partial class LoginForm : Form
    {
        private IFactoryDetailService _factoryDetailService;
        private IFactoryService _factoryService;

        private const int SUPPLIER_FACTORY_TYPE_ID = 1;
        private const int CUSTOMER_FACTORY_TYPE_ID = 2;

        public LoginForm()
        {
            InitializeComponent();
            _factoryDetailService = InstanceFactory.GetInstance<IFactoryDetailService>();
            _factoryService = InstanceFactory.GetInstance<IFactoryService>();

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            checkAccount();            

            loadFactoryTypes();
            hidePassword();
        }

        private void loadCompanyName()
        {
            btnDirectEntry.Text = "Continue as " + _factoryService.GetCompanyNameById(Properties.Settings.Default.FactoryId);
        }

        private void checkAccount()
        {
            if (
                Properties.Settings.Default.FactoryId == 0 &&
                Properties.Settings.Default.FactoryTypeId == 0 &&
                Properties.Settings.Default.Password == ""
                )

            {
                btnDirectEntry.Visible = false;
            }

            loadCompanyName();
        }

        private void hidePassword()
        {
            txtPassword.PasswordChar = '•';
        }
          
        private void loadFactoryTypes()
        {           
            var factoryTypes = _factoryDetailService.GetAll();
          
            var dataSource = new List<FactoryDetail> { 
                new FactoryDetail { TypeID = 0, TypeName = "Select a factory type..." } };
            dataSource.AddRange(factoryTypes);
         
            cbxFactoryType.DataSource = dataSource;
            cbxFactoryType.DisplayMember = "TypeName";
            cbxFactoryType.ValueMember = "TypeId";
        }

        private void cbxFactoryType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string typeIdStr = cbxFactoryType.SelectedValue.ToString();
                int typeId = Convert.ToInt32(typeIdStr);
                List<Factory> factories = _factoryService.GetByTypeId(typeId);

                loadFactories(factories);
            }
            catch { }
        }

        private void loadFactories(List<Factory> factories)
        {
            cbxCompanyName.DataSource = factories;
            cbxCompanyName.DisplayMember = "CompanyName";
            cbxCompanyName.ValueMember = "FactoryID";
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            authenticateUser();
        }

        private void saveCredentials(int factoryId, int factoryTypeId, string password)
        {
            Properties.Settings.Default.FactoryId = factoryId;
            Properties.Settings.Default.FactoryTypeId = factoryTypeId;
            Properties.Settings.Default.Password = password;
            Properties.Settings.Default.Save();
        }

        private void authenticateUser()
        {
            string password = txtPassword.Text;
            int factoryId = Convert.ToInt32(cbxCompanyName.SelectedValue);
            int factoryTypeId = Convert.ToInt32(cbxFactoryType.SelectedValue);


            string storedEncodedPassword = _factoryService.GetEncodedPassword(factoryId);

            bool verified = BCrypt.Net.BCrypt.Verify(password,storedEncodedPassword);

            if (verified)
            {
                saveCredentials(factoryId, factoryTypeId, password); // Save credentials
                launchForm(factoryId, factoryTypeId);
            }
            else
            {
                MessageBox.Show("Invalid login credentials!", "Invalid Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void launchForm(int factoryId, int factoryTypeId)
        {
            //int factoryTypeId = Convert.ToInt32(cbxFactoryType.SelectedValue);

            if (factoryTypeId == SUPPLIER_FACTORY_TYPE_ID) // Supplier
            {
                SupplierForm supplierForm = new SupplierForm(factoryId, factoryTypeId);
                supplierForm.Show();
            }
            else if (factoryTypeId == CUSTOMER_FACTORY_TYPE_ID) // Customer
            {
                CustomerForm customerForm = new CustomerForm(factoryId, factoryTypeId);
                customerForm.Show();
            }

            this.Hide(); // Close the login form

        }

        private void tryAutoLogin()
        {
            int factoryId = Properties.Settings.Default.FactoryId;
            int factoryTypeId = Properties.Settings.Default.FactoryTypeId;
            string password = Properties.Settings.Default.Password;

            if (factoryId != 0 && factoryTypeId != 0 && !string.IsNullOrEmpty(password))
            {
                // Retrieve the stored encoded password from the database
                string storedEncodedPassword = _factoryService.GetEncodedPassword(factoryId);

                bool verified = BCrypt.Net.BCrypt.Verify(password, storedEncodedPassword);

                if (verified)
                {
                    launchForm(factoryId, factoryTypeId);
                }
                else
                {
                    MessageBox.Show("Invalid login credentials!", "Invalid Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void cbxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
            }
        }

        private void lblRegisterSys_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
            this.Hide();
        }

        private void btnDirectEntry_Click_1(object sender, EventArgs e)
        {
            tryAutoLogin();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}

