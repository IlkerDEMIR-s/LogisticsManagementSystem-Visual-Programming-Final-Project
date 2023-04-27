using Logistics.Business.Abstract;
using Logistics.Business.DependencyResolvers.Ninject;
using Logistics.Entities.Concrete;
using System;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Windows.Forms;

namespace Logistics.WebFormsUI
{
    public partial class ProductOperationsForm : Form
    {
        private IProductService _productService;
        private ICategoryService _categoryService;

        private int _factoryId;
        private int _factoryTypeId;

        public ProductOperationsForm(int factoryId, int factoryTypeId)
        {
            InitializeComponent();
            _productService = InstanceFactory.GetInstance<IProductService>(); 
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();

            _factoryId = factoryId;
            _factoryTypeId = factoryTypeId; 
        }

        private void ProductOperationsForm_Load(object sender, EventArgs e)
        {
            loadProducts();
            loadCategories();
        }

        private void loadCategories()
        {
            cbxSearchCategory.DataSource = _categoryService.GetAll();
            cbxSearchCategory.DisplayMember = "CategoryName";
            cbxSearchCategory.ValueMember = "CategoryID";

            cbxAddCategory.DataSource = _categoryService.GetAll();
            cbxAddCategory.DisplayMember = "CategoryName";
            cbxAddCategory.ValueMember = "CategoryID";

            cbxUpdateCategory.DataSource = _categoryService.GetAll();
            cbxUpdateCategory.DisplayMember = "CategoryName";
            cbxUpdateCategory.ValueMember = "CategoryID";
        }

        private void loadProducts()
        {
            dgwProduct.DataSource = _productService.GetByFactoryId(_factoryId);
        }

        private void cbxSearchCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int categoryId = Convert.ToInt32(cbxSearchCategory.SelectedValue);
                dgwProduct.DataSource = _productService.GetByCategory(categoryId , _factoryId);
            }
            catch { }
        }

        private void txtSearchProductName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtSearchProductName.Text))
            {
                string searchKey = txtSearchProductName.Text;
                dgwProduct.DataSource = _productService.GetByProductName(searchKey , _factoryId);
            }
            else
            {
                loadProducts();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Add(new Product
                {
                    CategoryID = Convert.ToInt32(cbxAddCategory.SelectedValue),
                    ProductName = txtAddProductName.Text,
                    UnitPrice = Convert.ToDecimal(txtAddUnitPrice.Text),
                    UnitInStock = Convert.ToInt16(txtAddUnitInStock.Text),
                    FactoryID = Convert.ToInt32(_factoryId)
                });
                MessageBox.Show("Product added successfully.");
                loadProducts();

                clearTextBoxes();

                txtAddProductName.Focus();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearTextBoxes()
        {
            txtAddProductName.Clear();
            txtAddUnitPrice.Clear();
            txtAddUnitInStock.Clear();

            txtUpdateProductName.Clear();
            txtUpdateUnitPrice.Clear();
            txtUpdateUnitInStock.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Update(new Product
                {
                    ProductID = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                    CategoryID = Convert.ToInt32(cbxUpdateCategory.SelectedValue),
                    ProductName = txtUpdateProductName.Text.ToString(),
                    UnitPrice = Convert.ToDecimal(txtUpdateUnitPrice.Text),
                    UnitInStock = Convert.ToInt16(txtUpdateUnitInStock.Text),
                    FactoryID = Convert.ToInt32(_factoryId)
                });
                MessageBox.Show("Product updated successfully");
                loadProducts();

                clearTextBoxes();

                txtUpdateProductName.Focus();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwProduct.CurrentRow;
            txtUpdateProductName.Text = row.Cells[1].Value.ToString();
            cbxUpdateCategory.SelectedValue = row.Cells[3].Value;
            txtUpdateUnitPrice.Text = row.Cells[4].Value.ToString();           
            txtUpdateUnitInStock.Text = row.Cells[5].Value.ToString();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (dgwProduct.CurrentRow != null)
            {
                var productId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value);
                var result = MessageBox.Show($"Are you sure you want to delete product with ID {productId}?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        _productService.Delete(new Product
                        {
                            ProductID = productId
                        });
                        MessageBox.Show("Product deleted!");
                        loadProducts();
                        clearTextBoxes();
                    }
                    catch (ValidationException ex)
                    {
                        MessageBox.Show($"Product could not be deleted. {ex.Message}", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while deleting the product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            SupplierForm supplierForm = new SupplierForm(_factoryId, _factoryTypeId);
            supplierForm.Show();
            this.Close();
        }

        private void dgwProduct_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgwProduct.Columns[e.ColumnIndex].Name == "UnitInStock")
            {
                int stock = (int)e.Value;
                if (stock < 100)
                {
                    dgwProduct.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.DarkRed;
                    dgwProduct.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
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

    }
}
