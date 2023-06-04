using Logistics.Business.Abstract;
using Logistics.Business.DependencyResolvers.Ninject;
using Logistics.Business.Utilities;
using Logistics.Entities.Concrete;
using Ninject.Planning.Bindings;
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
    public partial class ExpeditionForm : Form
    {
        private int _factoryId;
        private int _factoryTypeId;
        private string _sourceName;
        private string _destinationName;
        private int _customerId;    
        private int _orderId;

        private IExpeditionService _expeditionService;
        private IStatusDetailService _statusDetailService;
        private IFactoryService _factoryService;  
        public ExpeditionForm(int factoryId, int factoryTypeId, string sourceName, string destinationName, int customerId, int orderId)
        {
            InitializeComponent();
            _factoryId = factoryId;
            _factoryTypeId = factoryTypeId;
            _sourceName = sourceName;
            _destinationName = destinationName;
            _customerId = customerId;      
            _orderId = orderId;

            _expeditionService = InstanceFactory.GetInstance<IExpeditionService>();
            _statusDetailService = InstanceFactory.GetInstance<IStatusDetailService>();
            _factoryService = InstanceFactory.GetInstance<IFactoryService>();
         
        }

        private void ExpeditionForm_Load(object sender, EventArgs e)
        {
            loadSourceAndDestination();

        }

        private void loadSourceAndDestination()
        {
            txtSource.Text = _sourceName;
            txtDestination.Text = _destinationName;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                _expeditionService.Add(new Expedition
                {
                    OrderId = _orderId,
                    Source = _sourceName,
                    Destination = _destinationName,
                    SupplierID = _factoryId,
                    CustomerID = _customerId,
                    CustomerName = _factoryService.GetByFactoryId(_customerId)[0].CompanyName,
                    CargoName = txtCargoName.Text.ToString(),
                    CargoParcelAmount = Convert.ToInt32(txtCargoParcelAmount.Text),
                    TotalCargoVolume = Convert.ToInt32(txtTotalCargoVolume.Text),
                    TotalCargoWeight = Convert.ToInt32(txtTotalCargoWeight.Text),
                    EstimatedDepartureDate = dtpEstimatedDepartureDate.Value,
                    EstimatedArrivalDate = dtpEstimatedArrivalDate.Value,
                    CargoStatusID = FixedValues.PreparingStatusId,
                    CargoStatusName = _statusDetailService.GetByStatusId(FixedValues.PreparingStatusId)[0].StatusName,            

                });

                MessageBox.Show("Expedition created successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                OrderManagementForm.expeditionControl = true;
                this.Close();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            OrderManagementForm.expeditionControl = false;
            this.Close();
        }
    }
}
