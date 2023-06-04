using Logistics.Business.Abstract;
using Logistics.Business.DependencyResolvers.Ninject;
using Logistics.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
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
                string password = txtPassword.Text;
                string companyName = txtCompanyName.Text.ToLower();


                if (typeId == 0)
                {
                    throw new Exception("Please select a factory type.");
                }

                if (CheckIfCompanyNameExists(companyName) && passwordValidation(password))
                {
                    // Encode and hash the password
                    string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);

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
                        Password = passwordHash,
                        HomePage = txtHomepage.Text
                    });

                    MessageBox.Show("Factory added successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                    this.Close();
                }
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

        private bool CheckIfCompanyNameExists(string companyName)
        {
            if (_factoryService.GetByCompanyName(companyName) != null)
            {
               MessageBox.Show("This company name already exists.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;       
            }  
            return true;
        }

        private bool passwordValidation(string password)
        {

            var passwordValidator = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{4,28}$");
            if (!passwordValidator.IsMatch(password))
            {
                MessageBox.Show("Password must contain at least one uppercase letter, one lowercase letter, one number, and one special character. It should be between 4 and 28 characters long.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
    }
    
}
