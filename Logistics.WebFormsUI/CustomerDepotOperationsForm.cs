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
    public partial class CustomerDepotOperationsForm : Form
    {
        private int _factoryId;
        private int _factoryTypeId;
        private IDepotService _depotService;
        private IProductService _productService;
        public CustomerDepotOperationsForm(int factoryId, int factoryTypeId)
        {
            InitializeComponent();
            _factoryId = factoryId;
            _factoryTypeId = factoryTypeId;
            _depotService = InstanceFactory.GetInstance<IDepotService>();
            _productService = InstanceFactory.GetInstance<IProductService>();                
        }

        private void CustomerDepotOperationsForm_Load(object sender, EventArgs e)
        {
            loadDepots();
            loadProductsID();
        }

        private void loadProductsID()
        {
            cbxProducts.DataSource = _productService.GetAll(); ;
            cbxProducts.DisplayMember = "ProductID";
            cbxProducts.ValueMember = "ProductID";
        }

        private void loadDepots()
        {
            dgwDepots.DataSource = _depotService.GetByFactoryId(_factoryId);
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm(_factoryId, _factoryTypeId);
            customerForm.Show();
            this.Hide();
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

        private void dgwDepots_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwDepots.CurrentRow;

            txtUpdateDepotName.Text = row.Cells[1].Value.ToString();
            txtUpdateContactName.Text = row.Cells[5].Value.ToString();
            txtUpdateContactTitle.Text = row.Cells[6].Value.ToString();
            txtUpdatePhone.Text = row.Cells[10].Value.ToString();
            txtUpdateAddress.Text = row.Cells[7].Value.ToString();
            txtUpdateUnitInStock.Text = row.Cells[11].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _depotService.Add(new Depot
                {
                    FactoryID = Convert.ToInt32(_factoryId),
                    DepotName = txtDepotName.Text.ToString(),
                    ProductID = Convert.ToInt32(cbxProducts.SelectedValue),
                    ProductName = _productService.GetByProductId(Convert.ToInt32((int)cbxProducts.SelectedValue))[0].ProductName,
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
            txtUpdateUnitInStock.Clear();
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
                    ProductName = row.Cells[4].Value.ToString(),
                    ContactName = txtUpdateContactName.Text.ToString(),
                    ContactTitle = txtUpdateContactTitle.Text.ToString(),
                    Address = txtUpdateAddress.Text.ToString(),
                    City = row.Cells[8].Value.ToString(),
                    Country = row.Cells[9].Value.ToString(),
                    Phone = txtUpdatePhone.Text.ToString(),
                    UnitInStock = Convert.ToInt32(txtUpdateUnitInStock.Text),


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

        private void dgwDepots_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgwDepots.Columns[e.ColumnIndex].Name == "UnitInStock")
            {
                int stock = (int)e.Value;
                if (stock < 100)
                {
                    dgwDepots.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.DarkRed;
                    dgwDepots.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
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

        private void btnCloneDepot_Click(object sender, EventArgs e)
        {
            var row = dgwDepots.CurrentRow;

            if (row != null)
            {
                txtDepotName.Text = row.Cells[1].Value.ToString();
                txtContactName.Text = row.Cells[5].Value.ToString();
                txtContactTitle.Text = row.Cells[6].Value.ToString();
                rtxtAdress.Text = row.Cells[7].Value.ToString();
                txtCity.Text = row.Cells[8].Value.ToString();
                txtCountry.Text = row.Cells[9].Value.ToString();
                txtPhone.Text = row.Cells[10].Value.ToString();

                MessageBox.Show("Depot cloned successfully.");
            }
            else
            {
                MessageBox.Show("Please select a depot to clone.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
