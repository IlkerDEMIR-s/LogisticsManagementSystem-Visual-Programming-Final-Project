using Logistics.Business.Abstract;
using Logistics.Business.DependencyResolvers.Ninject;
using Logistics.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Logistics.WebFormsUI
{
    public partial class CustomerTransactionsForm : Form
    {
        private int _factoryId;
        private int _factoryTypeId;
       

        private IFactoryService _factoryService;
        private ICustomerSupplierService _customerSupplierService;

        private const int CUSTOMER_FACTORY_TYPE_ID = 2;
        private int customerId; 

        public CustomerTransactionsForm(int factoryId, int factoryTypeId)
        {
            InitializeComponent();
            _factoryId = factoryId;
            _factoryTypeId = factoryTypeId;

            _factoryService = InstanceFactory.GetInstance<IFactoryService>();
            _customerSupplierService = InstanceFactory.GetInstance<ICustomerSupplierService>();

        }
        private void CustomerTransactionsForm_Load(object sender, EventArgs e)
        {
            loadCategoryCustomers();
            loadCustomers();
            loadCustomersTLoadCustomersToComboBox();
        }

        private void loadCustomers()
        {              
            dgwCustomers.DataSource = _factoryService.GetCustomersForDataGridView(_factoryId);
            dgwCustomers.Columns["Password"].Visible = false;
            dgwCustomers.Columns["TypeID"].Visible = false;            
        }

        private void loadCategoryCustomers()
        {
            var customers = _factoryService.GetAllCustomers(CUSTOMER_FACTORY_TYPE_ID);

            var dataSource = new List<Factory> {
                new Factory { FactoryID = 0, CompanyName = "Select a customer..." } };
            dataSource.AddRange(customers);

            cbxCustomers.DataSource = dataSource;
            cbxCustomers.DisplayMember = "CompanyName";
            cbxCustomers.ValueMember = "FactoryID";
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            SupplierForm supplierForm = new SupplierForm(_factoryId, _factoryTypeId);
            supplierForm.Show();
            this.Close();
        }
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                bool customerExists = _customerSupplierService.CheckIfCustomerExists(customerId, _factoryId);
                int selectedValueId = Convert.ToInt32(cbxCustomers.SelectedValue);
                string customerName = cbxCustomers.GetItemText(cbxCustomers.SelectedItem);

                if (customerExists)
                {
                    MessageBox.Show("The customer already exists.",
                        "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (selectedValueId == 0)
                {
                    MessageBox.Show("Please select a customer.",
                                               "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _customerSupplierService.AddCustomerToSuppliers(customerId, _factoryId, customerName);
                    loadCustomers();
                    loadCustomersTLoadCustomersToComboBox();

                    MessageBox.Show("The customer has been successfully added.",
                        "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cbxCustomers_SelectedValueChanged(object sender, EventArgs e)
        {
            // Get the selected customer from the ComboBox
            var selectedCustomer = cbxCustomers.SelectedItem as Factory;

            // Check if the selected customer is not null
            if (selectedCustomer != null)
            {
                // Set the customerId field to the selected customer's ID
                customerId = selectedCustomer.FactoryID;
            }
        }

        private void loadCustomersTLoadCustomersToComboBox()
        {
            var customers = _customerSupplierService.GetAllCustomersBySupplierId(_factoryId);

            var dataSource = new List<CustomerSupplier> {
                new CustomerSupplier { Id = 0, CustomerName = "Select a customer..." } };
            dataSource.AddRange(customers);

            cbxDeleteCustomer.DataSource = dataSource;
            cbxDeleteCustomer.DisplayMember = "CustomerName";
            cbxDeleteCustomer.ValueMember = "Id";
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedValueId = Convert.ToInt32(cbxDeleteCustomer.SelectedValue);

                if (selectedValueId == 0)
                {
                    MessageBox.Show("Please select a customer.",
                            "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    var id = Convert.ToInt32(cbxDeleteCustomer.SelectedValue);
                    var customerName = cbxDeleteCustomer.GetItemText(cbxDeleteCustomer.SelectedItem);
                    var result = MessageBox.Show($"Are you sure you want to delete the customer {customerName}?", "Confirm Closure", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {

                        _customerSupplierService.Delete(new CustomerSupplier
                        {
                            Id = id
                        });
                        MessageBox.Show("Customer deleted!");
                        loadCustomers();
                        loadCustomersTLoadCustomersToComboBox();
                    }
                }
            }
            catch (ValidationException ex)
            {
                MessageBox.Show($"Customer could not be deleted. {ex.Message}", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting the customer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }        
            
        }

    }
    
}


