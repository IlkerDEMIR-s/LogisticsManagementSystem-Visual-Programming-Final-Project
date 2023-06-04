using Logistics.Business.Abstract;
using Logistics.Business.DependencyResolvers.Ninject;
using Logistics.Business.Utilities;
using Logistics.Entities.Concrete;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logistics.WebFormsUI
{
    public partial class CustomerForm : Form
    {
        private int _factoryId;
        private int _factoryTypeId;

        private IFactoryService _factoryService;
        private IFactoryDetailService _factoryDetailService; 
        private IStockUpdaterService _stockUpdaterService;
        private IStatusDetailService _statusDetailService;

        private IDepotService _depotService;
        private IProductService _productService;
        private IOrderService _orderService;        

        private int _selectedProductId;
        private int _selectedSupplierDepotId;
        private int _selectedCustomerDepotId;
        private string _selectedCustomerDepotName;
        private int _selectedSupplierId;
        private string _selectedSupplierDepotName;
        private int increaseAmount = 0;
                

        public CustomerForm(int factoryId, int factoryTypeId)
        {
            InitializeComponent();

            _factoryId = factoryId;
            _factoryTypeId = factoryTypeId;

            _factoryService = InstanceFactory.GetInstance<IFactoryService>();
            _factoryDetailService = InstanceFactory.GetInstance<IFactoryDetailService>();

            _depotService = InstanceFactory.GetInstance<IDepotService>();
            _productService = InstanceFactory.GetInstance<IProductService>();

            _stockUpdaterService = InstanceFactory.GetInstance<IStockUpdaterService>();
            _orderService = InstanceFactory.GetInstance<IOrderService>();

            _statusDetailService = InstanceFactory.GetInstance<IStatusDetailService>();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            displayFactoryInformations();
            loadDepots();       
            loadOwnDepot();
        }

        private void loadOwnDepot()
        {
            dgwOwnDepot.DataSource = _depotService.GetByFactoryId(_factoryId);

            dgwOwnDepot.Columns["DepotName"].Width = 80;

            hideOwnDepotColumns();
        }

        private void hideOwnDepotColumns()
        {
            dgwOwnDepot.Columns["FactoryId"].Visible = false;
            dgwOwnDepot.Columns["DepotId"].Visible = false;
            dgwOwnDepot.Columns["ProductID"].Visible = false;
        }

        private void loadDepots()
        {
            dgwDepots.DataSource = _depotService.GetDepotsByCustomer(_factoryId);

            hideSupplierColumns();
        }

        private void hideSupplierColumns()
        {
            dgwDepots.Columns["UnitInStock"].Visible = false;
            dgwDepots.Columns["FactoryId"].Visible = false;
            dgwDepots.Columns["DepotId"].Visible = false;
            dgwDepots.Columns["ProductID"].Visible = false;
        }

        private void loadOwnDepots()
        {
            dgwOwnDepot.DataSource = _depotService.GetByFactoryId(_factoryId);
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

        private void btnReceive_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtStockInput.Text, out increaseAmount) && increaseAmount > 0)
                {

                    if (_stockUpdaterService.UpdateStockQuantityAfterReceivingProductFromDepot(_selectedSupplierDepotId, increaseAmount)
                         && _stockUpdaterService.SendReceivedProductsToOurOwnDepot(_selectedCustomerDepotId, increaseAmount))
                    {
                        addOrders();
                        loadDepots();
                        loadOwnDepots();

                        txtStockInput.Clear();
                        txtStockInput.Focus();

                    }
                    else
                    {
                        MessageBox.Show("There are not enough products in stock!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid stock amount entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Check if _selectedOwnDepotId is selected
            try
            {
                if (_selectedCustomerDepotId == 0)
                {
                    throw new Exception("Please select a receiving repository!");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }  

        }

        private void clearTextboxes()
        {
            txtStockInput.Clear();
            txtDepotNameDisplay.Clear();
            txtProductNameDisplay.Clear();
        }

        private int addOrders()
        {
            try
            {
                _orderService.Add(new Order
                {
                    SupplierID = _selectedSupplierId,
                    SupplierDepotId = _selectedSupplierDepotId,
                    SupplierDepotName = _selectedSupplierDepotName,
                    CustomerID = _factoryId,
                    CustomerName = _factoryService.GetByFactoryId(_factoryId)[0].CompanyName,
                    CustomerDepotId = _selectedCustomerDepotId,
                    CustomerDepotName = _selectedCustomerDepotName,
                    ProductID = _selectedProductId,
                    ProductName = _productService.GetByProductId(_selectedProductId)[0].ProductName,
                    Quantity = Convert.ToInt32(txtStockInput.Text),
                    OrderDate = DateTime.Now,
                    Status = FixedValues.PendingStatusId,
                    StatusName = _statusDetailService.GetByStatusId(FixedValues.PendingStatusId)[0].StatusName

                });

                MessageBox.Show($"Your order dated {DateTime.Now.Date.ToShortDateString()} has been received successfully.", "Order Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return increaseAmount;
        }

        private void dgwDepots_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwDepots.CurrentRow;
            _selectedSupplierDepotId = Convert.ToInt32(row.Cells[0].Value);
            _selectedSupplierDepotName = Convert.ToString(row.Cells[1].Value);
            _selectedSupplierId = Convert.ToInt32(row.Cells[2].Value);
            _selectedProductId = Convert.ToInt32(row.Cells[3].Value);
            

            txtDepotNameDisplay.Text = row.Cells[1].Value.ToString();
            txtProductNameDisplay.Text = row.Cells[4].Value.ToString();
        }

        private void txtSearchDepotName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtSearchDepotName.Text))
            {
                string searchKey = txtSearchDepotName.Text;
                dgwDepots.DataSource = _depotService.GetDepotsByCustomerWithSearchKey(_factoryId, searchKey);
            }
            else
            {
                loadDepots();
            }
        }

        private void dgwDepots_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgwDepots.Columns[e.ColumnIndex].Name == "UnitInStock")
            {
                int stock = (int)e.Value;
                if (stock < 100)
                {
                    e.CellStyle.BackColor = Color.DarkRed;
                    e.CellStyle.ForeColor = Color.White;
                }
                else if (stock >= 100 && stock <= 700)
                {
                    e.CellStyle.BackColor = Color.Thistle;
                }
                else
                {
                    e.CellStyle.BackColor = Color.PaleGreen;
                }
            }
        }

        private void dgwOwnDepot_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwOwnDepot.CurrentRow;
            _selectedCustomerDepotId = Convert.ToInt32(row.Cells[0].Value);
            _selectedCustomerDepotName = Convert.ToString(row.Cells[1].Value);
        }

        private void btnDepotOperations_Click(object sender, EventArgs e)
        {
            CustomerDepotOperationsForm customerDepotOperationsForm =
                                             new CustomerDepotOperationsForm(_factoryId, _factoryTypeId);
            customerDepotOperationsForm.Show();
            this.Close();
        }

        private void helpToolStripMenuItemAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We have been working on the development of logistics management systems for many years.",
                                                   "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changePasswordForm = new ChangePasswordForm(_factoryId, _factoryTypeId);
            changePasswordForm.ShowDialog();
        }

        private void btnMyOrders_Click(object sender, EventArgs e)
        {
            CustomerMyOrdersForm customerMyOrdersForm = new CustomerMyOrdersForm(_factoryId, _factoryTypeId);
            customerMyOrdersForm.Show();
            this.Close();
        }
    }

}
