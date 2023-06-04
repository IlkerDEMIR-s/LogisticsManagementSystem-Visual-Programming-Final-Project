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
    public partial class ChangePasswordForm : Form
    {
        private int _factoryId;
        private int _factoryTypeId;

        private IFactoryService _factoryService;
        public ChangePasswordForm(int factoryId, int factoryTypeId)
        {
            InitializeComponent();

            _factoryId = factoryId;
            _factoryTypeId = factoryTypeId;

            _factoryService = InstanceFactory.GetInstance<IFactoryService>();
        }

        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {
            hidePassword();
        }

        private void hidePassword()
        {
            txtOldPassword.PasswordChar = '•';
            txtNewPassword.PasswordChar = '•';
            txtConfirmPassword.PasswordChar = '•';
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            Factory factory = _factoryService.GetFactoryById(_factoryId);

            try
            {
                if(checkIfSame() && passwordMatchCheck(factory))
                {
                    string password = txtNewPassword.Text;
                    string encodedPassword = BCrypt.Net.BCrypt.HashPassword(password);
                    factory.Password = encodedPassword;
                    _factoryService.Update(factory);

                    resetSession();

                    clearTextBoxes();

                    MessageBox.Show("Password changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool checkIfSame()
        {
            if (txtOldPassword.Text == txtNewPassword.Text)
            {
                MessageBox.Show("Old password and new password cannot be the same!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool passwordMatchCheck(Factory factory)
        {
            string oldPassword = txtOldPassword.Text;

            bool verified = BCrypt.Net.BCrypt.Verify(oldPassword, factory.Password);

            if (verified)
            {
                if (txtNewPassword.Text == txtConfirmPassword.Text)
                {
                    // Check if the new password meets the validation criteria
                    var passwordValidator = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{4,28}$");
                    if (!passwordValidator.IsMatch(txtNewPassword.Text))
                    {
                        MessageBox.Show("Password must contain at least one uppercase letter, one lowercase letter, one number, and one special character. It should be between 4 and 28 characters long.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }

                    return true;
                }
                else
                {
                    MessageBox.Show("Passwords do not match!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Old password is incorrect!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        private void clearTextBoxes()
        {
            txtOldPassword.Clear();
            txtNewPassword.Clear();
            txtConfirmPassword.Clear();
            txtOldPassword.Focus();
        }

        private static void resetSession()
        {
            Properties.Settings.Default.FactoryId = 0;
            Properties.Settings.Default.FactoryTypeId = 0;
            Properties.Settings.Default.Password = "";
            Properties.Settings.Default.Save();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
             this.Hide();
        }

        private void cbxHide_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxHide.Checked)
            {
                txtOldPassword.PasswordChar = '\0';
                txtNewPassword.PasswordChar = '\0';
                txtConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                txtOldPassword.PasswordChar = '•';
                txtNewPassword.PasswordChar = '•';
                txtConfirmPassword.PasswordChar = '•';
            }

        }
    }
}
