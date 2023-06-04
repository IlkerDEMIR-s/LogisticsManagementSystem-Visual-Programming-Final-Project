using Logistics.Business.Abstract;
using Logistics.Business.DependencyResolvers.Ninject;
using Logistics.DataAccess.Concrete.EntityFramework;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Logistics.WebFormsUI
{
    public partial class SupplierForm : Form
    {
        private int _factoryId;
        private int _factoryTypeId;        
       
        private IFactoryService _factoryService;
        private IFactoryDetailService _factoryDetailService;
        private IDepotService _depotService;
 
        public SupplierForm(int factoryId, int factoryTypeId)
        {
            InitializeComponent();
            _factoryId = factoryId;
            _factoryTypeId = factoryTypeId;      

            _factoryService = InstanceFactory.GetInstance<IFactoryService>();
            _factoryDetailService = InstanceFactory.GetInstance<IFactoryDetailService>();
            _depotService = InstanceFactory.GetInstance<IDepotService>();        

            string warningMessage = _depotService.CheckUnitInStock(_factoryId);
            if (!string.IsNullOrEmpty(warningMessage))
            {
                rtbWarning.AppendText(warningMessage);
            }
            else
            {
                rtbWarning.AppendText("All stocks are in sufficient quantity...");
                lblWarning.Visible = false;
                pbxWarning.Visible = false;
            }
      
        }

        private void btnProductOperations_Click(object sender, EventArgs e)
        {
            ProductOperationsForm productOperationsForm = new ProductOperationsForm(_factoryId, _factoryTypeId);
            productOperationsForm.Show();
            this.Hide();
        }

        private void SupplierForm_Load(object sender, EventArgs e)
        {
            displayFactoryInformations();            

        }
        private void displayFactoryInformations()
        {
            var factoryInfo = _factoryService.GetByFactoryId(_factoryId);
            if (factoryInfo.Count > 0)
            {
                txtCompanyName.Text = factoryInfo[0].CompanyName;
                txtContactName.Text = factoryInfo[0].ContactName;
                txtContactTitle.Text = factoryInfo[0].ContactTitle;
                txtAddress.Text = factoryInfo[0].Adress;
                txtCity.Text = factoryInfo[0].City;
                txtCountry.Text = factoryInfo[0].Country;
                txtPhone.Text = factoryInfo[0].Phone;
                txtHomePage.Text = factoryInfo[0].HomePage;
            }

            var factoryType = _factoryDetailService.GetFactoryTypeNameById(_factoryTypeId);

            if (factoryType != null)
            {              
                txtFactoryType.Text = factoryType;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDepotOperations_Click(object sender, EventArgs e)
        {

            DepotOperationsForm depotOperationsForm = new DepotOperationsForm(_factoryId, _factoryTypeId);
            depotOperationsForm.Show();
            this.Hide();
        }

        private void btnCustomerTransactions_Click(object sender, EventArgs e)
        {
            CustomerTransactionsForm customerTransactionsForm = new CustomerTransactionsForm(_factoryId, _factoryTypeId);
            customerTransactionsForm.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.FactoryId = 0;
            Properties.Settings.Default.FactoryTypeId = 0;
            Properties.Settings.Default.Password = "";
            Properties.Settings.Default.Save();

            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void toolStripMenuItemWithWebSite_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.microsoft.com/tr-tr");
        }

        private void dffToolStripMenuItemGeneral_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://visualstudio.microsoft.com/tr/");
        }

        private void ddfToolStripMenuItemSpecial_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://learn.microsoft.com/en-us/dotnet/desktop/winforms/?view=netdesktop-7.0");
        }

        private void helpToolStripMenuItemAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We have been working on the development of logistics management systems for many years.",
                                                        "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changePasswordForm = new ChangePasswordForm(_factoryId, _factoryTypeId);
            changePasswordForm.ShowDialog();
            
        }

        private void btnOrderManagement_Click(object sender, EventArgs e)
        {           
            OrderManagementForm orderManagementForm = new OrderManagementForm(_factoryId, _factoryTypeId);
            orderManagementForm.Show();
            this.Hide();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm(_factoryId, _factoryTypeId);
            reportForm.Show();
            this.Hide();
        }
    }
} 
