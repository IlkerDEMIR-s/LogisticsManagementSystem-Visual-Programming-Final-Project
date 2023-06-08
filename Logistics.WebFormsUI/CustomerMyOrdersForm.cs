using Logistics.Business.Abstract;
using Logistics.Business.DependencyResolvers.Ninject;
using Logistics.Business.Utilities;
using Logistics.Entities.Concrete;
using System;
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
    public partial class CustomerMyOrdersForm : Form
    {
        private int _factoryId;
        private int _factoryTypeId;

        private IOrderService _orderService;
        private IStatusDetailService _statusDetailService;
        private IExpeditionService _expeditionService;
        private IStockUpdaterService _stockUpdaterService;

        private int _selectedSupplierDepotId;
        private int _selectedCustomerDepotId;
        public CustomerMyOrdersForm(int factoryId, int factoryTypeId)
        {
            InitializeComponent();
            _factoryId = factoryId;
            _factoryTypeId = factoryTypeId;

            _orderService = InstanceFactory.GetInstance<IOrderService>();
            _statusDetailService = InstanceFactory.GetInstance<IStatusDetailService>();
            _expeditionService = InstanceFactory.GetInstance<IExpeditionService>();
            _stockUpdaterService = InstanceFactory.GetInstance<IStockUpdaterService>();
                
        }

        private void CustomerMyOrdersForm_Load(object sender, EventArgs e)
        {
            loadOrders();
            loadOrderFilters();
            loadConfirmationOptions();
        }

        private void loadOrders()
        {
            // Get the data from the data source
            var data = _orderService.GetAllByCustomerId(_factoryId);

            // Sort the data in reverse order based on the "ColumnName" column
            var sortedData = data.OrderByDescending(x => x.OrderDate).ToList();

            // Bind the sorted data to the DataGridView control
            dgwOrders.DataSource = sortedData;

            // Decreace the width of the column 
            dgwOrders.Columns["SupplierDepotName"].Width = 170;
            dgwOrders.Columns["CustomerDepotName"].Width = 170;

            HideSomeColumns();

        }

        private void HideSomeColumns()
        {
            dgwOrders.Columns["OrderId"].Visible = false;
            dgwOrders.Columns["SupplierID"].Visible = false;
            dgwOrders.Columns["SupplierDepotID"].Visible = false;
            dgwOrders.Columns["CustomerID"].Visible = false;
            dgwOrders.Columns["CustomerDepotID"].Visible = false;
            dgwOrders.Columns["ProductID"].Visible = false;
            dgwOrders.Columns["Status"].Visible = false;
        }

        private void loadOrderFilters()
        {
            var filters = _statusDetailService.GetAll();

            var dataSource = new List<StatusDetail> {
                     new StatusDetail { Id = 0, StatusName = "Select a filter..." } };
            dataSource.AddRange(filters.Take(3)); // Only take the first three filters

            cbxStatus.DataSource = dataSource;
            cbxStatus.DisplayMember = "StatusName";
            cbxStatus.ValueMember = "Id";
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            int selectedFilter = Convert.ToInt32(cbxStatus.SelectedValue);

            if (selectedFilter == 0)
            {
                loadOrders();
                loadConfirmationOptions();
            }
            else
            {
                var data = _orderService.GetAllByCustomerId(_factoryId);
                var sortedData = data.OrderByDescending(x => x.OrderDate).ToList();
                var filteredData = sortedData.Where(x => x.Status == selectedFilter).ToList();
                dgwOrders.DataSource = filteredData;
            }
        }

        private void loadConfirmationOptions()
        {
            var filters = _statusDetailService.GetAll();

            var dataSource = new List<StatusDetail>
                     {
                        new StatusDetail { Id = 0, StatusName = "Select a filter..." }
                     };

            dataSource.AddRange(filters.Where(filter => filter.Id == FixedValues.DeliveredStatusId ||
                                                          filter.Id == FixedValues.NotDeliveredStatusId));

            cbxApprove.DataSource = dataSource;
            cbxApprove.DisplayMember = "StatusName";
            cbxApprove.ValueMember = "Id";
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm(_factoryId, _factoryTypeId);
            customerForm.Show();
            this.Hide();
        }

        private void dgwOrders_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgwOrders.Columns[e.ColumnIndex].Name == "StatusName")
            {
                var status = (String)e.Value;
                if (status == "Rejected")
                {
                    e.CellStyle.BackColor = Color.DarkRed;
                    e.CellStyle.ForeColor = Color.White;
                }
                if (status == "Confirmed")
                {
                    e.CellStyle.BackColor = Color.DarkGreen;
                    e.CellStyle.ForeColor = Color.White;
                }
                if (status == "Pending")
                {
                    e.CellStyle.BackColor = Color.PaleTurquoise;
                    e.CellStyle.ForeColor = Color.Black;
                }

            }
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            var selectedOrderId = Convert.ToInt32(dgwOrders.CurrentRow.Cells[0].Value);

            var expeditionData = _expeditionService.GetExpeditionByOrderId(selectedOrderId);

            rtbInfo.Clear();

            try
            {
                if (expeditionData != null)
                {
                    var message = "EstimatedDepartureDate/EstimatedArrivalDate : \n"
                                      + expeditionData.EstimatedDepartureDate.Date.ToShortDateString() + "/" +
                                      expeditionData.EstimatedArrivalDate.Date.ToShortDateString() + "\n\n" +
                                      "Cargo Status : " + expeditionData.CargoStatusName + "\n\n" +
                                      "ActualDepartureDate : " +
                                      (expeditionData.ActualDepartureDate != null ? expeditionData.ActualDepartureDate.ToString()
                                                                                  : "Not Departed Yet");

                    rtbInfo.Text = message;
                }
                else
                {
                    MessageBox.Show("There is no expedition data for this order!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            var selectedApprove = Convert.ToInt32(cbxApprove.SelectedValue);
            var selectedOrder = Convert.ToInt32(dgwOrders.CurrentRow.Cells[0].Value);            
            var Order = _orderService.GetOrderById(selectedOrder);
            var increaseAmount = Order.Quantity;
            var Expedition = _expeditionService.GetExpeditionByOrderId(selectedOrder);

            if(Order == null || Expedition == null)
            {
                MessageBox.Show("There is expedition data for this order!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (selectedApprove == 0)
            {
                MessageBox.Show("Please select an option!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (selectedApprove == FixedValues.DeliveredStatusId)
            {

                try
                {
                    try
                    {
                        if (increaseAmount > 0)
                        {

                            if (_stockUpdaterService.UpdateStockQuantityAfterReceivingProductFromDepot(_selectedSupplierDepotId, increaseAmount)
                                 && _stockUpdaterService.SendReceivedProductsToOurOwnDepot(_selectedCustomerDepotId, increaseAmount))
                            {
                                Expedition.CargoStatusID = selectedApprove;
                                Expedition.CargoStatusName = _statusDetailService.GetByStatusId(selectedApprove)[0].StatusName;
                                Expedition.ActualArrivalDate = DateTime.Now;
                                _expeditionService.Update(Expedition);

                                loadOrders();

                                MessageBox.Show("Stock has been updated!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                MessageBox.Show("Order has been delivered!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
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
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if(selectedApprove == FixedValues.NotDeliveredStatusId)
            {
                if (Expedition.EstimatedArrivalDate > DateTime.Now.Date)
                {
                    MessageBox.Show("Order cannot be rejected before the estimated arrival date!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    Expedition.CargoStatusID = selectedApprove;
                    Expedition.CargoStatusName = _statusDetailService.GetByStatusId(selectedApprove)[0].StatusName;
                    _expeditionService.Update(Expedition);
                    loadOrders();
                    MessageBox.Show("Order not delivered information, sent to supplier.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

        }

        private void dgwOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwOrders.CurrentRow;
            _selectedSupplierDepotId = Convert.ToInt32(row.Cells[2].Value);
            _selectedCustomerDepotId = Convert.ToInt32(row.Cells[6].Value);
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

        private void changePasswordToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ChangePasswordForm changePasswordForm = new ChangePasswordForm(_factoryId, _factoryTypeId);
            changePasswordForm.ShowDialog();
        }
    }
}
