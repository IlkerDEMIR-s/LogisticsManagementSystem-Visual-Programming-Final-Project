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
        private IOrderService _orderService;
 
        public SupplierForm(int factoryId, int factoryTypeId)
        {
            InitializeComponent();
            _factoryId = factoryId;
            _factoryTypeId = factoryTypeId;      

            _factoryService = InstanceFactory.GetInstance<IFactoryService>();
            _factoryDetailService = InstanceFactory.GetInstance<IFactoryDetailService>();
            _depotService = InstanceFactory.GetInstance<IDepotService>();
            _orderService = InstanceFactory.GetInstance<IOrderService>();

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
            receivedThings();

        }

        private void receivedThings()
        {
            // Get the data from the data source
            var data = _orderService.GetAllbyFactoryId(_factoryId);

            // Sort the data in reverse order based on the "ColumnName" column
            var sortedData = data.OrderByDescending(x => x.OrderDate).ToList();

            // Bind the sorted data to the DataGridView control
            dgwReceived.DataSource = sortedData;
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
    }
} 
