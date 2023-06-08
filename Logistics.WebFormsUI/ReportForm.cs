using Logistics.Business.Abstract;
using Logistics.Business.DependencyResolvers.Ninject;
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
    public partial class ReportForm : Form
    {
        private int _factoryId;
        private int _factoryTypeId;

        private IExpeditionService _expeditionService;
        private IStatusDetailService _statusDetailService;
        private IOrderService _orderService;

        public ReportForm(int factoryId, int factoryTypeId)
        {
            InitializeComponent();
            _factoryId = factoryId;
            _factoryTypeId = factoryTypeId;

            _expeditionService = InstanceFactory.GetInstance<IExpeditionService>();
            _statusDetailService = InstanceFactory.GetInstance<IStatusDetailService>();
            _orderService = InstanceFactory.GetInstance<IOrderService>();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            loadExpedition();  
            loadOrders();
        }

        private void loadOrders()
        {
            // Get the data from the data source
            var data = _orderService.GetAllCompletedOrdersByFactoryId(_factoryId);

            // Sort the data in reverse order based on the "ColumnName" column
            var sortedData = data.OrderByDescending(x => x.OrderDate).ToList();

            // Bind the sorted data to the DataGridView control
            dgwOrders.DataSource = sortedData;

            // Decreace the width of the column 
            dgwOrders.Columns["SupplierDepotName"].Width = 170;
            dgwOrders.Columns["CustomerDepotName"].Width = 170;

            HideSomeOrderColumns();

        }

        private void HideSomeOrderColumns()
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

        private void loadExpedition()
        {

            // Get the data from the data source
            var data = _expeditionService.GetAllCompletedExpeditionsByFactoryId( _factoryId );

            // Sort the data in reverse order based on the "ColumnName" column
            var sortedData = data.OrderByDescending(x => x.EstimatedDepartureDate).ToList();

            // Bind the sorted data to the DataGridView control
            dgwExpedition.DataSource = sortedData;

            hideSomeColumns();
        }

        private void hideSomeColumns()
        {
            dgwExpedition.Columns["ExpeditionID"].Visible = false;
            dgwExpedition.Columns["SupplierID"].Visible = false;
            dgwExpedition.Columns["CustomerID"].Visible = false;
            dgwExpedition.Columns["CargoStatusID"].Visible = false;
            dgwExpedition.Columns["OrderID"].Visible = false;
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            SupplierForm supplierForm = new SupplierForm(_factoryId, _factoryTypeId);
            supplierForm.Show();
            this.Close();
        }

        private void dgwExpedition_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgwExpedition.Columns[e.ColumnIndex].Name == "CargoStatusName")
            {
                var status = (String)e.Value;
                if (status == "Preparing")
                {
                    e.CellStyle.BackColor = Color.SandyBrown;
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

        private void btnFilter_Click(object sender, EventArgs e)
        {
            var startDate = dtpStartDate.Value;
            var endDate = dtpEndDate.Value;
            dgwExpedition.DataSource = _expeditionService.GetByDateRange(startDate, endDate, _factoryId);
            dgwOrders.DataSource = _orderService.GetByDateRange(startDate, endDate, _factoryId);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            loadExpedition();
            loadOrders();
        }

        private void txtSearchDepotName_TextChanged(object sender, EventArgs e)
        {
            var serchKey = txtSearchDepotName.Text.ToLower();

            if (!String.IsNullOrEmpty(serchKey))
            {
                dgwExpedition.DataSource = _expeditionService.GetByDepotName(serchKey, _factoryId);
                dgwOrders.DataSource = _orderService.GetByDepotName(serchKey, _factoryId);
            }
            else
            {
                loadExpedition();
                loadOrders();
            }
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
    }
}
