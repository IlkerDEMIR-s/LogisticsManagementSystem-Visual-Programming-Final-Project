using Logistics.Business.Abstract;
using Logistics.Business.DependencyResolvers.Ninject;
using Logistics.Entities.Concrete;
using System;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Windows.Forms;

namespace Logistics.WebFormsUI
{
    public partial class DepotOperationsForm : Form
    {
        private int _factoryId;
        private int _factoryTypeId;


        private IDepotService _depotService;
        private IProductService _productService;
        private IStockUpdaterService _stockUpdaterService;

        private int _selectedProductId;
        private int _selectedDepotId;  

        public DepotOperationsForm(int factoryId, int factoryTypeId)
        {
            InitializeComponent();

            _factoryId = factoryId;
            _factoryTypeId = factoryTypeId;

  
            _depotService = InstanceFactory.GetInstance<IDepotService>();
            _productService = InstanceFactory.GetInstance<IProductService>();
            _stockUpdaterService = InstanceFactory.GetInstance<IStockUpdaterService>();
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            SupplierForm supplierForm = new SupplierForm(_factoryId, _factoryTypeId);
            supplierForm.Show();
            this.Close();
        }

        private void DepotOperationsForm_Load(object sender, EventArgs e)
        {
            loadDepots();
            loadProducts();
        }

        private void loadProducts()
        {
            dgwProducts.DataSource = _productService.GetByFactoryId(_factoryId);
        }

        private void loadDepots()
        {
            dgwDepots.DataSource = _depotService.GetByFactoryId(_factoryId);

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            int increaseAmount = 0;

            try
            {
                if (int.TryParse(txtStockInput.Text, out increaseAmount) && increaseAmount > 0)
                {

                    if (_stockUpdaterService.UpdateStockQuantityAfterShipmentToDepot(_selectedProductId, _selectedDepotId, increaseAmount))
                    {
                        MessageBox.Show("Stock has been updated!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtStockInput.Clear();
                        loadDepots();
                        loadProducts() ;
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
        }


        private void dgwDepots_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwDepots.CurrentRow;
            _selectedDepotId = Convert.ToInt32(row.Cells[0].Value);
            _selectedProductId = Convert.ToInt32(row.Cells[3].Value);

            txtDepotId.ReadOnly = true;
            txtProductIdDisplay.ReadOnly = true;
            txtUnitInStockDisplay.ReadOnly = true;

            txtDepotId.Text = row.Cells[0].Value.ToString();
            txtProductIdDisplay.Text = row.Cells[3].Value.ToString();
            txtUnitInStockDisplay.Text = row.Cells[10].Value.ToString();

            txtUpdateDepotName.Text = row.Cells[1].Value.ToString();
            txtUpdateContactName.Text = row.Cells[4].Value.ToString();
            txtUpdateContactTitle.Text = row.Cells[5].Value.ToString();
            txtUpdatePhone.Text = row.Cells[9].Value.ToString();
            txtUpdateAddress.Text = row.Cells[6].Value.ToString();

        }   

        private void txtSearchDepotName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtSearchDepotName.Text))
            {
                string searchKey = txtSearchDepotName.Text;
                dgwDepots.DataSource = _depotService.GetByDepotNameAndFactoryID(searchKey, _factoryId);
            }
            else
            {
                loadDepots();
            }
        }

        private void btnCloseDepot_Click(object sender, EventArgs e)
        {
            if (dgwDepots.CurrentRow != null)
            {
                var depotId = Convert.ToInt32(dgwDepots.CurrentRow.Cells[0].Value);
                var result = MessageBox.Show($"Are you sure you want to close the depot with ID {depotId}?", "Confirm Closure", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        _depotService.Delete(new Depot
                        {
                            DepotID = depotId
                        });
                        MessageBox.Show("Depot Closed!");
                        loadDepots();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while closing the depot: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _depotService.Add(new Depot
                {
                    FactoryID = Convert.ToInt32(_factoryId),
                    DepotName = txtDepotName.Text.ToString(),
                    ProductID = Convert.ToInt32(txtProductId.Text),
                    ContactName = txtContactName.Text.ToString(),
                    ContactTitle = txtContactTitle.Text.ToString(),
                    Address = rtxtAdress.Text.ToString(),
                    City = txtCity.Text.ToString(),
                    Country = txtCountry.Text.ToString(),
                    Phone = txtPhone.Text.ToString(),
                    UnitInStock = Convert.ToInt32(txtUnitInStock.Text),
                });
                MessageBox.Show("Depot added successfully.");
                loadDepots();

                clearTextBoxes();

                txtDepotName.Focus();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearTextBoxes()
        {
            txtDepotName.Clear();
            txtProductId.Clear();
            txtContactName.Clear();
            txtContactTitle.Clear();
            rtxtAdress.Clear();
            txtCity.Clear();
            txtCountry.Clear();
            txtPhone.Clear();
            txtUnitInStock.Clear();

            txtUpdateDepotName.Clear();
            txtUpdateContactName.Clear();
            txtUpdateContactTitle.Clear();
            txtUpdatePhone.Clear();
            txtUpdateAddress.Clear();

        }

        private void dgwProducts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgwProducts.Columns[e.ColumnIndex].Name == "UnitInStock")
            {
                int stock = (int)e.Value;
                if (stock < 100)
                {
                    dgwProducts.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.DarkRed;
                    dgwProducts.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                }
                else if (stock >= 100 && stock <= 700)
                {
                    dgwProducts.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Thistle;
                }
                else
                {
                    dgwProducts.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.PaleGreen;
                }
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var row = dgwDepots.CurrentRow;
            try
            {
                _depotService.Update(new Depot
                {                   
                    DepotID = Convert.ToInt32(row.Cells[0].Value),
                    DepotName = txtUpdateDepotName.Text.ToString(),
                    FactoryID = Convert.ToInt32(_factoryId),
                    ProductID = Convert.ToInt32(row.Cells[3].Value),
                    ContactName = txtUpdateContactName.Text.ToString(),
                    ContactTitle = txtUpdateContactTitle.Text.ToString(),
                    Address = txtUpdateAddress.Text.ToString(),
                    City = row.Cells[7].Value.ToString(),
                    Country = row.Cells[8].Value.ToString(),
                    Phone = txtUpdatePhone.Text.ToString(),
                    UnitInStock = Convert.ToInt32(row.Cells[10].Value),


                });
                MessageBox.Show("Depot updated successfully.");
                
                loadDepots();

                clearTextBoxes();

                txtUpdateDepotName.Focus();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCloneDepot_Click(object sender, EventArgs e)
        {
            var row = dgwDepots.CurrentRow;

            if(row != null)
            {
                txtDepotName.Text = row.Cells[1].Value.ToString();
                txtContactName.Text = row.Cells[4].Value.ToString();
                txtContactTitle.Text = row.Cells[5].Value.ToString();
                rtxtAdress.Text = row.Cells[6].Value.ToString();
                txtCity.Text = row.Cells[7].Value.ToString();
                txtCountry.Text = row.Cells[8].Value.ToString();
                txtPhone.Text = row.Cells[9].Value.ToString();

                MessageBox.Show("Depot cloned successfully.");
            }
            else
            {
                MessageBox.Show("Please select a depot to clone.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }
    }
}


