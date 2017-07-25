using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NSGVisitorManagement.Classes;
using NSGVisitorManagement.DAL;
using System.Data.SqlClient;

namespace NSGVisitorManagement.Forms
{
    public partial class frmChangePassword : Form
    {
        private NSGVisitorEntities DB = new NSGVisitorEntities();

        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void SetDeafultErrorProviders()
        {
            errConfirmPassword.SetError(txtConfirmNewPassword, "Required");
            errNewPassword.SetError(txtNewPassword, "Required");
            errOldPassword.SetError(txtOldPassword, "Required");
            errUserName.SetError(txtUsername, "Required");
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Please enter username.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtOldPassword.Text))
            {
                MessageBox.Show("Please enter Old Password.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtOldPassword.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtNewPassword.Text))
            {
                MessageBox.Show("Please enter New Password.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNewPassword.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtConfirmNewPassword.Text))
            {
                MessageBox.Show("Please enter Confirm New Password.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtConfirmNewPassword.Focus();
                return;
            }

            if (txtNewPassword.TextLength < 5)
            {
                MessageBox.Show("Password must be minimum 5 and Max 20 characters.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNewPassword.Focus();
                return;
            }

            if (txtConfirmNewPassword.TextLength < 5)
            {
                MessageBox.Show("Confirm Password must be minimum 5 and Max 20 characters.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtConfirmNewPassword.Focus();
                return;
            }

            if (txtNewPassword.Text != txtConfirmNewPassword.Text)
            {
                MessageBox.Show("Password mismatched. Please enter the same password in both the fields.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNewPassword.Text = "";
                txtConfirmNewPassword.Text = "";
                txtNewPassword.Focus();
                return;
            }

            CoreUser coreUser = DB.CoreUsers.Where(cu => cu.UserName.ToUpper() == txtUsername.Text.ToUpper() && cu.UserPassword == txtOldPassword.Text).FirstOrDefault();
            
            if (coreUser != null)
            {
                coreUser.UserPassword = txtNewPassword.Text;

                DB.SaveChanges();

                MessageBox.Show("Password Updated successfully.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Cursor = System.Windows.Forms.Cursors.Default;
                this.Close();
            }
            else
            {
                MessageBox.Show("This user name not found, please enter valid username and password.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsername.Text = string.Empty;
                txtOldPassword.Text = string.Empty;
                txtNewPassword.Text = string.Empty;
                txtConfirmNewPassword.Text = string.Empty;
                txtUsername.Focus();
                this.Cursor = System.Windows.Forms.Cursors.Default;
                return;
            }

        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            SetDeafultErrorProviders();
            ToolTip ttip = new ToolTip();
            ttip.SetToolTip(this.txtUsername, "Please enter existing username.");
            ttip.SetToolTip(this.txtOldPassword, "Please enter existing above user password.");
            ttip.SetToolTip(this.txtNewPassword, "New Password length can be 5-20 characters.");
            ttip.SetToolTip(this.txtConfirmNewPassword, "Confirm Password length can be 5-20 characters.");

        }

        private void txtOldPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.ValidateQuoteCharacter(txtOldPassword, e);
            if (!Validation.ValidateCharacterIsSpace(txtOldPassword, e, true))
            {
                MessageBox.Show("Space is not allowed.");
                txtOldPassword.Focus();
            }
        }

        private void txtNewPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.ValidateQuoteCharacter(txtNewPassword, e);
            if (!Validation.ValidateCharacterIsSpace(txtNewPassword, e, true))
            {
                MessageBox.Show("Space is not allowed.");
                txtNewPassword.Focus();
            }
        }

        private void txtConfirmNewPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.ValidateQuoteCharacter(txtConfirmNewPassword, e);
            if (!Validation.ValidateCharacterIsSpace(txtConfirmNewPassword, e, true))
            {
                MessageBox.Show("Space is not allowed.");
                txtConfirmNewPassword.Focus();
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.ValidateQuoteCharacter(txtUsername, e);
            if (!Validation.ValidateCharacterIsSpace(txtUsername, e, true))
            {
                MessageBox.Show("Space is not allowed.");
                txtUsername.Focus();
            }
        }

     }
}
