using Logistics.Business.Abstract;
using Logistics.Business.DependencyResolvers.Ninject;
using Logistics.Business.Utilities;
using Logistics.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Logistics.WebFormsUI
{
    public partial class OrderManagementForm : Form
    {
        private int _factoryId;
        private int _factoryTypeId;

        private IOrderService _orderService;
        private IStatusDetailService _statusDetailService;
        private IExpeditionService _expeditionService;

        public static bool expeditionControl;  

        private const int CONFIRM = 0;
        private const int REJECT = 1;
        public OrderManagementForm(int factoryId, int factoryTypeId)
        {
            InitializeComponent();
            _factoryId = factoryId;
            _factoryTypeId = factoryTypeId;        

            _orderService = InstanceFactory.GetInstance<IOrderService>();
            _statusDetailService = InstanceFactory.GetInstance<IStatusDetailService>();   
            _expeditionService = InstanceFactory.GetInstance<IExpeditionService>();

        }

        private void OrderManagementForm_Load(object sender, EventArgs e)
        {
            loadOrders();
            loadExpedition();

            loadOrderFilters();
            loadExpeditionFilters();           
            
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

        private void loadOrders()
        {
            // Get the data from the data source
            var data = _orderService.GetAllBySupplierId(_factoryId);

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
            dgwOrders.Columns["OrderId"].Visible = false;
            
        }

        private void loadExpeditionFilters()
        {
            var filters = _statusDetailService.GetAll();

            var dataSource = new List<StatusDetail> {
        new StatusDetail { Id = 0, StatusName = "Select a filter..." } };
            dataSource.AddRange(filters.Where(filter => filter.Id == FixedValues.PreparingStatusId ||
                       filter.Id == FixedValues.OnTheCourierStatusId || filter.Id == FixedValues.DeliveredStatusId));

            cbxExpeditionStatus.DataSource = dataSource;
            cbxExpeditionStatus.DisplayMember = "StatusName";
            cbxExpeditionStatus.ValueMember = "Id";
        }


        private void loadExpedition()
        {
            // Get the data from the data source
            var data = _expeditionService.GetAllByFactoryId(_factoryId);

            // Sort the data in reverse order based on the "ColumnName" column
            var sortedData = data.OrderByDescending(x => x.EstimatedDepartureDate).ToList();

            // Bind the sorted data to the DataGridView control
            dgwExpedition.DataSource = sortedData;

            hideExpeditionSomeColumns();

        }

        private void hideExpeditionSomeColumns()
        {
            dgwExpedition.Columns["ExpeditionID"].Visible = false;
            dgwExpedition.Columns["SupplierID"].Visible = false;
            dgwExpedition.Columns["CustomerID"].Visible = false;
            dgwExpedition.Columns["CargoStatusID"].Visible = false;
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            SupplierForm supplierForm = new SupplierForm(_factoryId, _factoryTypeId);
            supplierForm.Show();
            this.Close();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            int selectedFilter = Convert.ToInt32(cbxStatus.SelectedValue);

            if (selectedFilter == 0)
            {
                loadOrders();
            }
            else
            {
                var data = _orderService.GetAllBySupplierId(_factoryId);
                var sortedData = data.OrderByDescending(x => x.OrderDate).ToList();
                var filteredData = sortedData.Where(x => x.Status == selectedFilter).ToList();
                dgwOrders.DataSource = filteredData;
            }
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {                   

            if (dgwOrders.CurrentRow == null)
            {
                MessageBox.Show("Please select an order to update the status!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }           

            var statusColumn = Convert.ToInt32(dgwOrders.CurrentRow.Cells[12].Value.ToString());

            if (statusColumn == FixedValues.ConfirmedStatusId || statusColumn == FixedValues.RejectedStatusId)
            {
                MessageBox.Show("You can not update the status of this order!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedUpdateStatus = Convert.ToInt32(cbxUpdateStatus.SelectedIndex);
            var sourceName = dgwOrders.CurrentRow.Cells[3].Value.ToString();
            var destinationName = dgwOrders.CurrentRow.Cells[7].Value.ToString();
            var customerId = Convert.ToInt32(dgwOrders.CurrentRow.Cells[4].Value);
            var orderId = Convert.ToInt32(dgwOrders.CurrentRow.Cells[0].Value);

            try
            {
                if (selectedUpdateStatus == CONFIRM)   
                {
                    ExpeditionForm expeditionForm = new ExpeditionForm(_factoryId, _factoryTypeId, sourceName, destinationName, customerId, orderId);
                    expeditionForm.ShowDialog();

                    if (expeditionControl)
                    {
                        int selectedOrderId = Convert.ToInt32(dgwOrders.CurrentRow.Cells[0].Value);
                        var order = _orderService.GetOrderById(selectedOrderId);
                        order.Status = FixedValues.ConfirmedStatusId;
                        order.StatusName = _statusDetailService.GetByStatusId(FixedValues.ConfirmedStatusId)[0].StatusName;
                        _orderService.Update(order);
                        loadExpedition();
                        MessageBox.Show("Order status updated successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadOrders();
                    }
                    else
                    {
                        MessageBox.Show("Expedition is not created.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                } 
                if (selectedUpdateStatus == REJECT)  
                { 
                    int selectedOrderId = Convert.ToInt32(dgwOrders.CurrentRow.Cells[0].Value);
                    var order = _orderService.GetOrderById(selectedOrderId);
                    order.Status = FixedValues.RejectedStatusId;
                    order.StatusName = _statusDetailService.GetByStatusId(FixedValues.RejectedStatusId)[0].StatusName;
                    _orderService.Update(order);
                    MessageBox.Show("Order status updated successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadOrders();
                }

            }catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
                if(status == "Pending")
                {
                    e.CellStyle.BackColor = Color.PaleTurquoise;
                    e.CellStyle.ForeColor = Color.Black;
                }

            }
        }

        private void dgwExpedition_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgwExpedition.Columns[e.ColumnIndex].Name == "CargoStatusName")
            {
                var status = (String)e.Value;
                if (status == "Preparing")
                {
                    e.CellStyle.BackColor = Color.LemonChiffon;
                    e.CellStyle.ForeColor = Color.Black;
                }
                if (status == "Delivered")
                {
                    e.CellStyle.BackColor = Color.DarkGreen;
                    e.CellStyle.ForeColor = Color.White;
                }
                if (status == "On the courier")
                {
                    e.CellStyle.BackColor = Color.PaleTurquoise;
                    e.CellStyle.ForeColor = Color.Black;
                }
                if (status == "NotDelivered")
                {
                    e.CellStyle.BackColor = Color.DarkRed;
                    e.CellStyle.ForeColor = Color.White;
                }

            }
        }

        private void btnExpeditionFilter_Click(object sender, EventArgs e)
        {
            int selectedFilter = Convert.ToInt32(cbxExpeditionStatus.SelectedValue);

            if (selectedFilter == 0)
            {
                loadExpedition();
            }
            else
            {
                var data = _expeditionService.GetAllByFactoryId(_factoryId);
                var sortedData = data.OrderByDescending(x => x.EstimatedDepartureDate).ToList();
                var filteredData = sortedData.Where(x => x.CargoStatusID == selectedFilter).ToList();
                dgwExpedition.DataSource = filteredData;
            }
        }

        private void dgwExpedition_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwExpedition.CurrentRow;
            txtCargoName.Text = row.Cells[7].Value.ToString();

        }

        private void btnActualDepartureDate_Click(object sender, EventArgs e)
        {

            if (!IsValidExpeditionSelected())
            {
                ShowWarningMessage("Please select an expedition to add actual departure date!");
                return;
            }

            var selectedExpeditionId = Convert.ToInt32(dgwExpedition.CurrentRow.Cells[0].Value);
            var expedition = _expeditionService.GetExpeditionById(selectedExpeditionId);

            if (IsCargoAlreadyGivenToCourier(expedition))
            {
                ShowWarningMessage("The cargo has already been given to the courier!");
                return;
            }

            if (IsCargoAlreadyDelivered(expedition))
            {
                ShowWarningMessage("The cargo has already been delivered!");
                return;
            }

            if (IsActualDepartureDateAdded(expedition))
            {
                ShowWarningMessage("Actual departure date is already added!");
                return;
            }

            if (IsActualDepartureDateEarlierThanToday())
            {
                ShowWarningMessage("Actual departure date cannot be earlier than today!");
                return;
            }

            try
            {
                UpdateExpeditionWithActualDepartureDate(expedition);
                MessageBox.Show("Actual departure date added successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadExpedition();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValidExpeditionSelected()
        {
            return dgwExpedition.CurrentRow != null;
        }

        private bool IsCargoAlreadyGivenToCourier(Expedition expedition)
        {
            return expedition.CargoStatusID == FixedValues.OnTheCourierStatusId;
        }

        private bool IsCargoAlreadyDelivered(Expedition expedition)
        {
            return expedition.CargoStatusID == FixedValues.DeliveredStatusId;
        }

        private bool IsActualDepartureDateAdded(Expedition expedition)
        {
            return expedition.ActualDepartureDate != null;
        }

        private bool IsActualDepartureDateEarlierThanToday()
        {
            return dtpActualDepartureDate.Value.Date < DateTime.Now.Date;
        }

        private void UpdateExpeditionWithActualDepartureDate(Expedition expedition)
        {
            expedition.ActualDepartureDate = dtpActualDepartureDate.Value;
            expedition.CargoStatusID = FixedValues.OnTheCourierStatusId;
            expedition.CargoStatusName = _statusDetailService.GetByStatusId(FixedValues.OnTheCourierStatusId)[0].StatusName;
            _expeditionService.Update(expedition);
        }

        private void ShowWarningMessage(string message)
        {
            MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        private void changePasswordToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ChangePasswordForm changePasswordForm = new ChangePasswordForm(_factoryId, _factoryTypeId);
            changePasswordForm.ShowDialog();
        }
    }
}
