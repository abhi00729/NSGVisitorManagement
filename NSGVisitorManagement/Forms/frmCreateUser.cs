using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using NSGVisitorManagement.Classes;
using NSGVisitorManagement.DAL;
using System.Data.SqlClient;

namespace NSGVisitorManagement
{
    public partial class frmCreateUser : Form
    {
        NSGVisitorEntities DB = new NSGVisitorEntities();

        CoreUser coreUser;
        NSGEmployee nsgEmployee;
        List<CoreQuarterType> coreQuarterTypes;

        public frmCreateUser()
        {
            InitializeComponent();
        }

        private void SetDefaultErrProviderValues()
        {
            errEmployeeId.SetError(txtEmployeeID, "Required");
            errFirstName.SetError(txtFirstName, "Required");
            errLastName.SetError(txtLastName, "Required");
            errRank.SetError(cmbRank, "Required");
            errUnit.SetError(cmbUnit, "Required");
        }

        private bool ValidateControls()
        {
            if (string.IsNullOrEmpty(txtEmployeeID.Text.TrimEnd()))
            {
                MessageBox.Show("Please enter the Employee Id.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(txtFirstName.Text.TrimEnd()))
            {
                MessageBox.Show("Please enter the First Name.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(txtLastName.Text.TrimEnd()))
            {
                MessageBox.Show("Please enter the Last Name.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbRank.SelectedIndex < 0)
            {
                MessageBox.Show("Please select the Rank.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbUnit.SelectedIndex < 0)
            {
                MessageBox.Show("Please select the Unit.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if(!string.IsNullOrEmpty(txtQuarterNumber.Text.TrimEnd()) && cmbQuarterType.SelectedIndex != -1)
            {
                int quarterTypeID = int.Parse(cmbQuarterType.SelectedValue.ToString());
                int maxQuarterNumber = coreQuarterTypes.Where(qt => qt.QuarterTypeID == quarterTypeID).FirstOrDefault().MaxQuarterNumber;

                if(int.Parse(txtQuarterNumber.Text) > maxQuarterNumber)
                {
                    MessageBox.Show("This Quarter Number does not exists for selected Quarter Type.\nPlease enter a valid Quarter Number.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            if (chkCreateLogin.Checked)
            {
                if (txtUserName.Text.Equals(string.Empty))
                {
                    MessageBox.Show("Please enter the User Name.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (txtPassword.Text.Equals(string.Empty))
                {
                    MessageBox.Show("Please enter the Password.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (!txtPassword.Text.Equals(string.Empty) && txtPassword.Text.Length < 5)
                {
                    MessageBox.Show("Password length can not be less then 5 digit.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (txtReTypePassword.Text.Equals(string.Empty))
                {
                    MessageBox.Show("Please enter the Re-Type Password.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else if (!txtPassword.Text.Trim().Equals(txtReTypePassword.Text.Trim()))
                {
                    MessageBox.Show("Password and Re-Type Password should be same.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            
            return true;
        }
        
        private void frmCreateUser_Load(object sender, EventArgs e)
        {
            SetDefaultErrProviderValues();

            ToolTip ttip = new ToolTip();
            ttip.SetToolTip(this.txtEmployeeID, "Please enter NSG Employee ID.");
            ttip.SetToolTip(this.txtFirstName, "Please enter First Name. Max 100 characters.");
            ttip.SetToolTip(this.txtLastName, "Please enter Last Name. Max 100 characters.");
            ttip.SetToolTip(this.txtUserName, "Username length can be 5-20 characters.");
            ttip.SetToolTip(this.txtPassword, "Password length can be 5-20 characters.");
            ttip.SetToolTip(this.txtReTypePassword, "Re-Type Password length can be 5-20 characters.");

            FillCombos();
        }

        private void FillCombos()
        {
            List<CoreRank> coreRanks = DB.CoreRanks.Where(cr => cr.IsActive == true).ToList();
            List<CoreUnit> coreUnits = DB.CoreUnits.Where(cu => cu.IsActive == true).ToList();
            coreQuarterTypes = DB.CoreQuarterTypes.Where(qt => qt.IsActive == true).ToList();

            cmbRank.DisplayMember = "RankName";
            cmbRank.ValueMember = "RankID";
            cmbRank.DataSource = coreRanks;
            cmbRank.SelectedIndex = -1;
            
            cmbUnit.DisplayMember = "UnitName";
            cmbUnit.ValueMember = "UnitID";
            cmbUnit.DataSource = coreUnits;
            cmbUnit.SelectedIndex = -1;

            cmbQuarterType.DisplayMember = "QuarterTypeName";
            cmbQuarterType.ValueMember = "QuarterTypeID";
            cmbQuarterType.DataSource = coreQuarterTypes;
            cmbQuarterType.SelectedIndex = -1;
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.ValidateQuoteCharacter(txtUserName, e);
            if (!Validation.ValidateCharacterIsSpace(txtUserName, e, true))
            {
                MessageBox.Show("Space is not allowed.");
                txtUserName.Focus();
                return;
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.ValidateQuoteCharacter(txtPassword, e);
            if (!Validation.ValidateCharacterIsSpace(txtPassword, e, true))
            {
                MessageBox.Show("Space is not allowed.");
                txtPassword.Focus();
            }
        }

        private void txtReTypePassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.ValidateQuoteCharacter(txtReTypePassword, e);

            if (!Validation.ValidateCharacterIsSpace(txtReTypePassword, e, true))
            {
                MessageBox.Show("Space is not allowed.");
                txtReTypePassword.Focus();
            }
        }

        private void txtEmployeeID_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.ValidateTextIsNumeric(txtEmployeeID, e, false);
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.ValidateQuoteCharacter(txtFirstName, e);
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.ValidateQuoteCharacter(txtLastName, e);
        }

        private void txtQuarterNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.ValidateTextIsNumeric(txtQuarterNumber, e);
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (!Validation.ValidateStringForAlphabets(txtFirstName.Text))
            {
                MessageBox.Show("Please enter only alphabets in this column.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
            }
        }
        
        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (!Validation.ValidateStringForAlphabets(txtLastName.Text))
            {
                MessageBox.Show("Please enter only alphabets in this column.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
            }
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (!Validation.ValidateAlphaNumericString(txtUserName.Text, new char[] { '.' }))
            {
                MessageBox.Show("Please enter only alpha numeric in this column.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
            }
        }

        private void txtQuarterNumber_Validating(object sender, CancelEventArgs e)
        {
            if (!Validation.ValidateTextIsNumeric(txtQuarterNumber))
            {
                MessageBox.Show("Please enter only numeric in this column.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
            }
        }

        private void chkCreateLogin_CheckedChanged(object sender, EventArgs e)
        {
            if(chkCreateLogin.Checked)
            {
                grpBoxLoginDetails.Enabled = true;
                txtUserName.BackColor = txtEmployeeID.BackColor;
                txtPassword.BackColor = txtEmployeeID.BackColor;
                txtReTypePassword.BackColor = txtEmployeeID.BackColor;
                chkUserActive.BackColor = txtEmployeeID.BackColor;
            }
            else
            {
                grpBoxLoginDetails.Enabled = false;
                txtUserName.BackColor = Color.LightGray;
                txtPassword.BackColor = Color.LightGray;
                txtReTypePassword.BackColor = Color.LightGray;
                chkUserActive.BackColor = Color.LightGray;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string successMsg = string.Empty;
            try
            {
                if (ValidateControls())
                {
                    btnCreate.Enabled = false;
                    btnCancel.Enabled = false;

                    this.Cursor = System.Windows.Forms.Cursors.WaitCursor;

                    if (nsgEmployee == null)
                    {
                        nsgEmployee = new NSGEmployee();
                        nsgEmployee.EntryDate = DateTime.Now;
                        nsgEmployee.EntryUserID = GlobalClass.LoggedInUserID;
                    }
                    else
                    {
                        nsgEmployee.UpdateDate = DateTime.Now;
                        nsgEmployee.UpdateUserID = GlobalClass.LoggedInUserID;
                    }

                    nsgEmployee.NSGEmployeeCode = txtEmployeeID.Text;
                    nsgEmployee.FirstName = txtFirstName.Text;
                    nsgEmployee.LastName = txtLastName.Text;
                    nsgEmployee.Gender = (radMale.Checked ? "Male" : "Female");
                    nsgEmployee.RankID = int.Parse(cmbRank.SelectedValue.ToString());
                    nsgEmployee.UnitID = int.Parse(cmbUnit.SelectedValue.ToString());

                    if (cmbQuarterType.SelectedIndex > -1)
                    {
                        nsgEmployee.QuarterTypeID = int.Parse(cmbQuarterType.SelectedValue.ToString());
                    }
                    
                    nsgEmployee.QuarterNumber = int.Parse(txtQuarterNumber.Text);
                    
                    nsgEmployee.IsActive = chkEmpActive.Checked;

                    DB.NSGEmployees.Add(nsgEmployee);

                    successMsg = "Employee created successfully.";

                    if (chkCreateLogin.Checked)
                    {
                        CoreUser coreDupUser;

                        if (coreUser == null)
                        {
                            coreDupUser = DB.CoreUsers.Where(cu => cu.UserName.ToUpper() == txtUserName.Text.ToUpper()).FirstOrDefault();
                        }
                        else
                        {
                            coreDupUser = DB.CoreUsers.Where(cu => cu.UserName.ToUpper() == txtUserName.Text.ToUpper() && cu.EmployeeID != txtEmployeeID.Text).FirstOrDefault();
                        }

                        if (coreDupUser == null)
                        {
                            if (coreUser == null)
                            {
                                coreUser = new CoreUser();
                                coreUser.EntryDate = DateTime.Now;
                                coreUser.EntryUserID = GlobalClass.LoggedInUserID;
                            }
                            else
                            {
                                coreUser.UpdateDate = DateTime.Now;
                                coreUser.UpdateUserID = GlobalClass.LoggedInUserID;
                            }

                            coreUser.UserName = txtUserName.Text;
                            coreUser.UserPassword = txtPassword.Text;
                            coreUser.EmployeeID = txtEmployeeID.Text;
                            coreUser.FirstName = txtFirstName.Text;
                            coreUser.LastName = txtLastName.Text;
                            coreUser.IsActive = chkUserActive.Checked;

                            DB.CoreUsers.Add(coreUser);
                            successMsg = "Employee and login created successfully.";
                        }
                        else
                        {
                            MessageBox.Show("This user name already exists.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtUserName.Text = string.Empty;
                            txtPassword.Text = string.Empty;
                            txtReTypePassword.Text = string.Empty;
                            txtUserName.Focus();
                            this.btnCreate.Enabled = true;
                            this.btnCancel.Enabled = true;
                            this.Cursor = System.Windows.Forms.Cursors.Default;
                            return;
                        }
                    }

                    DB.SaveChanges();
                    MessageBox.Show(successMsg, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Cursor = System.Windows.Forms.Cursors.Default;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                this.Cursor = System.Windows.Forms.Cursors.Default;
                MessageBox.Show(ex.Message, this.Text + " : btnCreate_Click : " + ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.btnCreate.Enabled = true;
                this.btnCancel.Enabled = true;
                this.Cursor = System.Windows.Forms.Cursors.Default;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(!this.IsMdiChild)
            {
                this.Hide();
                frmLogin loginpage = new frmLogin();
                loginpage.ShowDialog();
            }
            this.Close();
            this.Dispose();
        }

        private void txtEmployeeID_Leave(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtEmployeeID.Text.TrimEnd()))
            {
                btnCreate.Text = "&Create";

                nsgEmployee = DB.NSGEmployees.Where(emp => emp.NSGEmployeeCode == txtEmployeeID.Text).FirstOrDefault();

                if(nsgEmployee != null)
                {
                    btnCreate.Text = "&Update";

                    txtFirstName.Text = nsgEmployee.FirstName;
                    txtLastName.Text = nsgEmployee.LastName;
                    if(nsgEmployee.Gender.ToUpper() == "MALE")
                    {
                        radMale.Checked = true;
                    }
                    else
                    {
                        radFemale.Checked = true;
                    }
                    cmbRank.SelectedValue = nsgEmployee.RankID;
                    cmbUnit.SelectedValue = nsgEmployee.UnitID;
                    cmbQuarterType.SelectedValue = nsgEmployee.QuarterTypeID;
                    txtQuarterNumber.Text = nsgEmployee.QuarterNumber.ToString();
                    
                    coreUser = DB.CoreUsers.Where(cu => cu.EmployeeID.ToString() == txtEmployeeID.Text).FirstOrDefault();

                    if (coreUser != null)
                    {
                        txtUserName.Text = coreUser.UserName;
                    }
                }
            }
        }

    }
}