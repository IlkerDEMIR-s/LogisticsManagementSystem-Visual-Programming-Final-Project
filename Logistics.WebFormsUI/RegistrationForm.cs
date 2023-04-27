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
    public partial class RegistrationForm : Form
    {
        private IFactoryService _factoryService;
        private IFactoryDetailService _factoryDetailService;

        private int typeId = 0;
        public RegistrationForm()
        {
            InitializeComponent();
            _factoryDetailService = InstanceFactory.GetInstance<IFactoryDetailService>();
            _factoryService = InstanceFactory.GetInstance<IFactoryService>();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            loadFactoryTypes();
            txtPassword.PasswordChar = '•';
        }

        private void loadFactoryTypes()
        {
            var factoryTypes = _factoryDetailService.GetAll();

            var dataSource = new List<FactoryDetail> {
                new FactoryDetail { TypeID = 0, TypeName = "Select a factory type..." } };
            dataSource.AddRange(factoryTypes);

            cbxFactoryType.DataSource = dataSource;
            cbxFactoryType.DisplayMember = "TypeName";
            cbxFactoryType.ValueMember = "TypeId";
        }

        private void cbxFactoryType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string typeIdStr = cbxFactoryType.SelectedValue.ToString();
                typeId = Convert.ToInt32(typeIdStr);
            }
            catch { }
        }

        private void cbxShow_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxShow.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (typeId == 0)
                {
                    throw new Exception("Please select a factory type.");
                }

                _factoryService.Add(new Factory
                {
                    CompanyName = txtCompanyName.Text,
                    ContactName = txtContactName.Text,
                    ContactTitle = txtContactTitle.Text,
                    Adress = txtAddress.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text,
                    Phone = txtPhone.Text,
                    TypeId = typeId,
                    Password = txtPassword.Text,
                    HomePage = txtHomepage.Text

                });
                MessageBox.Show("Factory added successfully.", "Info",MessageBoxButtons.OK,MessageBoxIcon.Information);


                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
                
            }
            catch (Exception ex) when (ex.Message == "Please select a factory type.")
            {
                MessageBox.Show(ex.Message, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception exception)
            {               
                MessageBox.Show(exception.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
    }
    
}
