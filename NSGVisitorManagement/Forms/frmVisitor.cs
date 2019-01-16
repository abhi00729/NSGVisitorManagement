using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSGVisitorManagement.DAL;
using System.Windows.Forms;
using NSGVisitorManagement.Classes;
using System.IO;
using System.Runtime.InteropServices;

namespace NSGVisitorManagement.Forms
{
    public partial class frmVisitor : Form
    {
        private bool isNewEntry = true;
        private bool isEditEntry = false;
        private bool isExistingVisitor = false;
        private long visitorID = 0;

        private NSGVisitorEntities DB = new NSGVisitorEntities();
        ImageConverter imgConverter = new ImageConverter();

        Visitor visitor;
        NSGEmployee nsgEmployee;
        BlackListedVisitor blackListedVisitor;
        List<CoVisitor> coVisitors = new List<CoVisitor>();
        List<CoVisitor> coVisitorsRemoved = new List<CoVisitor>();

        List<CoreIdentityType> identityTypes;
        List<CoreState> coreStates;
        List<CoreRelationship> coreRelationships;
        List<CoreCity> coreCitys;
        List<CoreQuarterType> coreQuarterTypes;
        List<CoreRank> coreRanks;
        List<CoreUnit> coreUnits;

        public frmVisitor()
        {
            InitializeComponent();
        }

        public frmVisitor(bool newEntry)
        {
            InitializeComponent();
            isNewEntry = newEntry;
        }

        public frmVisitor(long visitorID, bool editEntry = false)
        {
            InitializeComponent();
            this.visitorID = visitorID;
            isEditEntry = editEntry;
            isNewEntry = false;
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == "frmCapturePhoto")
                {
                    form.Activate();
                    return;
                }
            }

            GlobalClass.VisitorImage = null;
            frmCapturePhoto capturePhoto = new frmCapturePhoto(txtVisitorNumber.Text);

            if (capturePhoto.ShowDialog() == DialogResult.OK)
            {
                if (GlobalClass.VisitorImage == null)
                {
                    MessageBox.Show("Please Capture Photo Again.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                picVisitorPhoto.Image = GlobalClass.VisitorImage;
            }
        }

        private void frmVisitor_Load(object sender, EventArgs e)
        {
            FillCombos();

            if (isNewEntry)
            {
                this.Text += " - In"; 
                txtVisitorNumber.ReadOnly = true;
                btnPrint.Enabled = false;
                txtMobileNo.Focus();
                dteValidTill.Value = DateTime.Now.AddHours(GlobalClass.DefaultPassValidHours);
                this.contextMenuStrip.Enabled = false;
            }
            else if (isEditEntry)
            {
                this.Text += " - Edit";
                txtVisitorNumber.Text = visitorID.ToString();
                txtVisitorNumber_Leave(null, null);
                btnEnter.Text = "&Update";
            }
            else
            {
                this.Text += " - Out";
                btnEnter.Text = "&Save Exit";
            }

            if (!isEditEntry)
            {
                visitorTimer.Enabled = true;
            }
        }

        private void FillCombos()
        {
            var queryIdentityTypes = from cit in DB.CoreIdentityTypes where cit.IsActive == true select cit;

            coreRanks = DB.CoreRanks.Where(cr => cr.IsActive == true).ToList();
            coreUnits = DB.CoreUnits.Where(cu => cu.IsActive == true).ToList();
            coreQuarterTypes = DB.CoreQuarterTypes.Where(qt => qt.IsActive == true).ToList();

            identityTypes = queryIdentityTypes.ToList();
            List<CoreIdentityType> identityTypesForGrid = queryIdentityTypes.ToList();
            coreStates = DB.CoreStates.ToList();
            coreRelationships = DB.CoreRelationships.ToList();

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

            cmbIdentityType.DisplayMember = "IdentityType";
            cmbIdentityType.ValueMember = "IdentityTypeID";
            cmbIdentityType.DataSource = identityTypes;
            cmbIdentityType.SelectedIndex = -1;

            cmbState.DisplayMember = "StateName";
            cmbState.ValueMember = "StateID";
            cmbState.DataSource = coreStates;
            cmbState.SelectedIndex = -1;

            DataGridViewComboBoxColumn dgvCoVisitorsIdentityType = (DataGridViewComboBoxColumn)dgvCoVisitors.Columns["IdentityType"];
            DataGridViewComboBoxColumn dgvCoVisitorsRelationship = (DataGridViewComboBoxColumn)dgvCoVisitors.Columns["Relationship"];

            dgvCoVisitorsIdentityType.DisplayMember = "IdentityType";
            dgvCoVisitorsIdentityType.ValueMember = "IdentityTypeID";
            dgvCoVisitorsIdentityType.DataSource = identityTypesForGrid;

            dgvCoVisitorsRelationship.DisplayMember = "Relationship";
            dgvCoVisitorsRelationship.ValueMember = "RelationshipID";
            dgvCoVisitorsRelationship.DataSource = coreRelationships;
        }

        private void cmbState_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbState.SelectedIndex > -1)
            {
                coreCitys = DB.CoreCities.Where(cc => cc.StateID.ToString() == cmbState.SelectedValue.ToString()).ToList();

                cmbCity.DisplayMember = "CityName";
                cmbCity.ValueMember = "CityID";
                cmbCity.DataSource = coreCitys;
                cmbCity.SelectedIndex = -1;
            }
        }

        private void txtEmployeeID_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEmployeeID.Text.TrimEnd()))
            {
                nsgEmployee = DB.NSGEmployees.Where(emp => emp.NSGEmployeeCode == txtEmployeeID.Text).FirstOrDefault();

                if (nsgEmployee != null)
                {
                    txtEmployeeName.Text = nsgEmployee.FirstName + " " + nsgEmployee.LastName;
                    cmbRank.SelectedValue = nsgEmployee.RankID;
                    cmbUnit.SelectedValue = nsgEmployee.UnitID;

                    if (nsgEmployee.QuarterTypeID != null)
                    {
                        cmbQuarterType.SelectedValue = nsgEmployee.QuarterTypeID;
                    }

                    if (nsgEmployee.QuarterNumber != null)
                    {
                        txtQuarterNumber.Text = nsgEmployee.QuarterNumber.ToString();
                    }
                }
                else
                {
                    txtEmployeeName.Text = string.Empty;
                    cmbRank.SelectedIndex = -1;
                    cmbUnit.SelectedIndex = -1;
                    cmbQuarterType.SelectedIndex = -1;
                    txtQuarterNumber.Text = string.Empty;
                }
            }
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

        private void txtMobileNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.ValidateTextIsNumeric(txtMobileNo, e);
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (!Validation.ValidateStringForAlphabets(txtFirstName.Text))
            {
                MessageBox.Show("Please enter only alphabets in First Name.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
            }
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (!Validation.ValidateStringForAlphabets(txtLastName.Text))
            {
                MessageBox.Show("Please enter only alphabets in Last Name.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
            }
        }

        private void txtVisitorNumber_Validating(object sender, CancelEventArgs e)
        {
            if (!Validation.ValidateAlphaNumericString(txtVisitorNumber.Text, new char[] { '.' }))
            {
                MessageBox.Show("Please enter only alpha numeric in Visitor Number.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
            }
        }

        private void txtQuarterNumber_Validating(object sender, CancelEventArgs e)
        {
            if (!Validation.ValidateTextIsNumeric(txtQuarterNumber))
            {
                MessageBox.Show("Please enter only numeric in Quarter Number.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
            }
        }

        private void txtMobileNo_Validating(object sender, CancelEventArgs e)
        {
            if (!Validation.ValidateTextIsNumeric(txtMobileNo))
            {
                MessageBox.Show("Please enter only numeric in Mobile Number.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
            }
        }

        private void txtVisitedPersonMobile_Validating(object sender, CancelEventArgs e)
        {
            if (!Validation.ValidateTextIsNumeric(txtVisitedPersonMobile))
            {
                MessageBox.Show("Please enter only numeric in Visited Person Mobile Number.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateControls())
                {
                    return;
                }

                if (isNewEntry)
                {
                    visitor = new Visitor();
                    visitor.InTime = DateTime.Now;
                    visitor.EntryDate = DateTime.Now;
                    visitor.EntryUserID = GlobalClass.LoggedInUserID;
                }
                else
                {
                    if (!isEditEntry)
                    {
                        visitor.OutTime = DateTime.Now;
                    }

                    visitor.UpdateDate = DateTime.Now;
                    visitor.UpdateUserID = GlobalClass.LoggedInUserID;
                }
                
                visitor.MachineID = GlobalClass.MachineName;
                visitor.FirstName = txtFirstName.Text;
                visitor.LastName = txtLastName.Text;
                visitor.Gender = cmbGender.Text;
                visitor.MobileNo = txtMobileNo.Text;
                visitor.IdentityTypeID = int.Parse(cmbIdentityType.SelectedValue.ToString());
                visitor.IdentityNumber = txtIdentityNumber.Text;
                visitor.VisitorAddress = txtVisitorAddress.Text;
                visitor.StateID = int.Parse(cmbState.SelectedValue.ToString());

                if (cmbCity.SelectedIndex > -1)
                {
                    visitor.CityID = int.Parse(cmbCity.SelectedValue.ToString());
                }

                visitor.VehicleNumber = txtVehicleNumber.Text;

                visitor.Purpose = txtPurpose.Text;
                visitor.PersonEmpCode = txtEmployeeID.Text;
                visitor.PersonName = txtEmployeeName.Text;

                visitor.VisitedPersonMobile = txtVisitedPersonMobile.Text;
                visitor.ValidTill = dteValidTill.Value;

                if (cmbRank.SelectedIndex != -1)
                {
                    visitor.RankID = int.Parse(cmbRank.SelectedValue.ToString());
                }

                if (cmbUnit.SelectedIndex != -1)
                {
                    visitor.UnitID = int.Parse(cmbUnit.SelectedValue.ToString());
                }

                if (cmbQuarterType.SelectedIndex != -1)
                {
                    visitor.QuarterTypeID = int.Parse(cmbQuarterType.SelectedValue.ToString());
                }

                if (txtQuarterNumber.Text.TrimEnd() != string.Empty)
                {
                    visitor.QuarterNumber = int.Parse(txtQuarterNumber.Text);
                }
                
                byte[] visitorImage = (byte[])imgConverter.ConvertTo(picVisitorPhoto.Image, typeof(byte[]));
                visitor.VisitorPhoto = visitorImage;

                if (isNewEntry)
                {
                    DB.Visitors.Add(visitor);
                }

                if (isNewEntry && nsgEmployee == null && !string.IsNullOrEmpty(txtEmployeeID.Text.TrimEnd()))
                {
                    nsgEmployee = new NSGEmployee();
                    nsgEmployee.NSGEmployeeCode = txtEmployeeID.Text;
                    nsgEmployee.FirstName = txtEmployeeName.Text;
                    nsgEmployee.Gender = "Male";
                    nsgEmployee.RankID = int.Parse(cmbRank.SelectedValue.ToString());
                    nsgEmployee.UnitID = int.Parse(cmbUnit.SelectedValue.ToString());

                    if (cmbQuarterType.SelectedIndex > -1)
                    {
                        nsgEmployee.QuarterTypeID = int.Parse(cmbQuarterType.SelectedValue.ToString());
                    }

                    if (txtQuarterNumber.Text.TrimEnd() != string.Empty)
                    {
                        nsgEmployee.QuarterNumber = int.Parse(txtQuarterNumber.Text);
                    }

                    nsgEmployee.IsActive = true;

                    nsgEmployee.EntryDate = DateTime.Now;
                    nsgEmployee.EntryUserID = GlobalClass.LoggedInUserID;

                    DB.NSGEmployees.Add(nsgEmployee);

                }

                DB.SaveChanges();

                foreach (DataGridViewRow dgvRow in dgvCoVisitors.Rows)
                {
                    if (dgvRow.Cells["CoVisitorName"].Value != null)
                    {
                        CoVisitor coVisitor = null;

                        if (dgvRow.Cells["CoVisitorID"].Value != null)
                        {
                            coVisitor = coVisitors.Find(cv => cv.CoVisitorID == long.Parse(dgvRow.Cells["CoVisitorID"].Value.ToString()));
                            coVisitor.UpdateDate = DateTime.Now;
                            coVisitor.UpdateUserID = GlobalClass.LoggedInUserID;
                        }
                        else
                        {
                            coVisitor = new CoVisitor();
                            coVisitor.EntryDate = DateTime.Now;
                            coVisitor.EntryUserID = GlobalClass.LoggedInUserID;
                            coVisitor = DB.CoVisitors.Add(coVisitor);
                            coVisitors.Add(coVisitor);
                        }

                        coVisitor.VisitorID = visitor.VisitorID;
                        coVisitor.CoVisitorName = dgvRow.Cells["CoVisitorName"].Value.ToString();

                        if (dgvRow.Cells["IdentityType"].Value != null)
                        {
                            coVisitor.IdentityTypeID = int.Parse(dgvRow.Cells["IdentityType"].Value.ToString());
                        }

                        if (dgvRow.Cells["IdentityNumber"].Value != null)
                        {
                            coVisitor.IdentityNumber = dgvRow.Cells["IdentityNumber"].Value.ToString();
                        }

                        coVisitor.Gender = dgvRow.Cells["Gender"].Value.ToString();
                        coVisitor.VisitorAddress = string.Empty;

                        coVisitor.RelationshipID = int.Parse(dgvRow.Cells["Relationship"].Value.ToString());
                    }
                }

                if(coVisitorsRemoved.Count > 0)
                {
                    DB.CoVisitors.RemoveRange(coVisitorsRemoved);
                }

                DB.SaveChanges();

                if (isNewEntry)
                {
                    DialogResult msgResponse = MessageBox.Show("Visitor information saved successfully.\nDo you want to continue with Print?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                    if (msgResponse == DialogResult.Yes)
                    {
                        btnPrint_Click(null, null);
                    }

                    msgResponse = MessageBox.Show("Do you want to continue with Visitor Entry?", this.Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                    if (msgResponse == DialogResult.Yes)
                    {
                        RefreshMe();
                    }
                    else if (msgResponse == DialogResult.No)
                    {
                        btnCancel_Click(null, null);
                    }
                    else
                    {
                        visitorID = visitor.VisitorID;
                        RefreshMe();
                    }
                }
                else if (isEditEntry)
                {
                    MessageBox.Show("Visitor information updated successfully.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnCancel_Click(null, null);
                }
                else
                {
                    MessageBox.Show("Visitor exit saved successfully.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnCancel_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                this.Cursor = System.Windows.Forms.Cursors.Default;
                MessageBox.Show(ex.Message, this.Text + " : btnEnter_Click : " + ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private bool ValidateControls()
        {
            bool dataIsValid = true;

            if (string.IsNullOrEmpty(txtFirstName.Text.TrimEnd()))
            {
                MessageBox.Show("Please enter the First Name.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataIsValid = false;
            }

            if (string.IsNullOrEmpty(txtLastName.Text.TrimEnd()))
            {
                MessageBox.Show("Please enter the Last Name.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataIsValid = false;
            }

            if (cmbGender.SelectedIndex < 0)
            {
                MessageBox.Show("Please select the Gender.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataIsValid = false;
            }

            if (txtMobileNo.Text.Length > 0 && txtMobileNo.Text.Length < 10)
            {
                MessageBox.Show("Please enter valid Mobile Number.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataIsValid = false;
            }

            if (cmbIdentityType.SelectedIndex < 0)
            {
                MessageBox.Show("Please select Identity Type.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataIsValid = false;
            }

            if (string.IsNullOrEmpty(txtIdentityNumber.Text.TrimEnd()))
            {
                MessageBox.Show("Please enter the Identity Number.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataIsValid = false;
            }

            if (string.IsNullOrEmpty(txtVisitorAddress.Text.TrimEnd()))
            {
                MessageBox.Show("Please enter the Visitor Address.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataIsValid = false;
            }

            if (cmbState.SelectedIndex < 0)
            {
                MessageBox.Show("Please select State.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataIsValid = false;
            }

            if (string.IsNullOrEmpty(txtEmployeeName.Text.TrimEnd()))
            {
                MessageBox.Show("Please enter the Employee Name.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataIsValid = false;
            }

            if (cmbRank.SelectedIndex < 0)
            {
                MessageBox.Show("Please select the Rank.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataIsValid = false;
            }

            if (cmbUnit.SelectedIndex < 0)
            {
                MessageBox.Show("Please select the Unit.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataIsValid = false;
            }

            if (!string.IsNullOrEmpty(txtQuarterNumber.Text.TrimEnd()) && cmbQuarterType.SelectedIndex != -1)
            {
                int quarterTypeID = int.Parse(cmbQuarterType.SelectedValue.ToString());
                int maxQuarterNumber = coreQuarterTypes.Where(qt => qt.QuarterTypeID == quarterTypeID).FirstOrDefault().MaxQuarterNumber;

                if (int.Parse(txtQuarterNumber.Text) > maxQuarterNumber)
                {
                    MessageBox.Show("This Quarter Number does not exists for selected Quarter Type.\nPlease enter a valid Quarter Number.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dataIsValid = false;
                }
            }

            foreach (DataGridViewRow dgvRow in dgvCoVisitors.Rows)
            {
                if (dgvRow.Cells["CoVisitorName"].Value != null)
                {
                    if (dgvRow.Cells["Gender"].Value == null)
                    {
                        MessageBox.Show("Please select the Gender of Co-Visitor " + dgvRow.Cells["CoVisitorName"].Value.ToString() + ".", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dataIsValid = false;
                        break;
                    }

                    if (dgvRow.Cells["Relationship"].Value == null)
                    {
                        MessageBox.Show("Please select the Relationship of Co-Visitor " + dgvRow.Cells["CoVisitorName"].Value.ToString() + ".", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dataIsValid = false;
                        break;
                    }
                }
            }

            if(dteValidTill.Value <= DateTime.Parse(txtEntryTime.Text))
            {
                MessageBox.Show("Pass validity should be greater than current date and time.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataIsValid = false;
            }

            if (txtVisitedPersonMobile.Text.Length > 0 && txtVisitedPersonMobile.Text.Length < 10)
            {
                MessageBox.Show("Please enter valid Mobile Number for Visited Person.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataIsValid = false;
            }

            return dataIsValid;
        }

        private void visitorTimer_Tick(object sender, EventArgs e)
        {
            if (isNewEntry)
            {
                txtEntryTime.Text = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt");
            }
            else if (!isEditEntry)
            {
                txtExitTime.Text = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Print(GlobalClass.PrinterName, GetDocument());
        }

        private void txtVisitorNumber_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtVisitorNumber.Text.TrimEnd()))
            {
                visitorID = long.Parse(txtVisitorNumber.Text);

                visitor = DB.Visitors.Where(v => v.VisitorID == visitorID).FirstOrDefault();

                if (visitor != null)
                {
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Please enter a valid visitor number.");
                }
            }
        }

        private void LoadData()
        {
            btnPrint.Enabled = true;
            txtVisitorNumber.ReadOnly = true;
            txtFirstName.Text = visitor.FirstName;
            txtLastName.Text = visitor.LastName;
            cmbGender.Text = visitor.Gender;
            txtMobileNo.Text = visitor.MobileNo;
            cmbIdentityType.SelectedValue = visitor.IdentityTypeID;
            txtIdentityNumber.Text = visitor.IdentityNumber;
            txtVisitorAddress.Text = visitor.VisitorAddress;
            cmbState.SelectedValue = visitor.StateID;

            if(visitor.VisitedPersonMobile != null)
            {
                txtVisitedPersonMobile.Text = visitor.VisitedPersonMobile;
            }
            
            if(visitor.ValidTill != null)
            {
                dteValidTill.Value = DateTime.Parse(visitor.ValidTill.ToString());
            }
            
            if (visitor.CityID != null)
            {
                cmbCity.SelectedValue = visitor.CityID;
            }

            txtVehicleNumber.Text = visitor.VehicleNumber;

            if (!isNewEntry)
            {
                txtEntryTime.Text = visitor.InTime.ToString("dd-MM-yyyy hh:mm:ss tt");
            }

            if (visitor.OutTime != null)
            {
                txtExitTime.Text = visitor.OutTime.Value.ToString("dd-MM-yyyy hh:mm:ss tt");
            }

            txtPurpose.Text = visitor.Purpose;
            txtEmployeeID.Text = visitor.PersonEmpCode;
            txtEmployeeName.Text = visitor.PersonName;
            cmbRank.SelectedValue = visitor.RankID;
            cmbUnit.SelectedValue = visitor.UnitID;

            if (visitor.QuarterTypeID != null)
            {
                cmbQuarterType.SelectedValue = visitor.QuarterTypeID;
            }

            txtQuarterNumber.Text = visitor.QuarterNumber.ToString();

            if (visitor.VisitorPhoto.Length > 0)
            {
                picVisitorPhoto.Image = (Image)imgConverter.ConvertFrom(visitor.VisitorPhoto);
            }

            coVisitors = DB.CoVisitors.Where(cv => cv.VisitorID == visitorID).ToList();

            if (coVisitors != null)
            {
                int rowIndex = 0;
                foreach (CoVisitor coVisitor in coVisitors)
                {
                    dgvCoVisitors.Rows.Add();
                    dgvCoVisitors.Rows[rowIndex].Cells["CoVisitorID"].Value = coVisitor.CoVisitorID;
                    dgvCoVisitors.Rows[rowIndex].Cells["CoVisitorName"].Value = coVisitor.CoVisitorName;
                    dgvCoVisitors.Rows[rowIndex].Cells["Gender"].Value = coVisitor.Gender;
                    dgvCoVisitors.Rows[rowIndex].Cells["IdentityType"].Value = coVisitor.IdentityTypeID;
                    dgvCoVisitors.Rows[rowIndex].Cells["IdentityNumber"].Value = coVisitor.IdentityNumber;
                    dgvCoVisitors.Rows[rowIndex].Cells["Relationship"].Value = coVisitor.RelationshipID;

                    rowIndex++;
                }
            }

            RefreshMe();
        }

        private void RefreshMe()
        {
            if (visitorID == 0)
            {
                if (!isExistingVisitor)
                {
                    txtVisitorNumber.Text = string.Empty;
                    txtFirstName.Text = string.Empty;
                    txtLastName.Text = string.Empty;
                    cmbGender.SelectedIndex = -1;
                    txtMobileNo.Text = string.Empty;
                    cmbIdentityType.SelectedIndex = -1;
                    txtIdentityNumber.Text = string.Empty;
                    txtVisitorAddress.Text = string.Empty;
                    cmbState.SelectedIndex = -1;
                    cmbCity.SelectedIndex = -1;
                    txtVehicleNumber.Text = string.Empty;
                    txtPurpose.Text = string.Empty;
                    txtEmployeeID.Text = string.Empty;
                    txtEmployeeName.Text = string.Empty;
                    txtVisitedPersonMobile.Text = string.Empty;
                    cmbRank.SelectedIndex = -1;
                    cmbUnit.SelectedIndex = -1;
                    cmbQuarterType.SelectedIndex = -1;
                    txtQuarterNumber.Text = string.Empty;
                    dgvCoVisitors.Rows.Clear();
                    picVisitorPhoto.Image = null;
                }

                dteValidTill.Value = DateTime.Now.AddHours(GlobalClass.DefaultPassValidHours);

                btnPrint.Enabled = false;
                isNewEntry = true;
                isEditEntry = false;
                isExistingVisitor = false;
                visitor = null;
                nsgEmployee = null;
                coVisitors = new List<CoVisitor>();
                coVisitorsRemoved = new List<CoVisitor>();
            }
            else
            {
                txtVisitorNumber.Text = visitorID.ToString();

                if (!isEditEntry || visitor.OutTime != null)
                {
                    txtVisitorNumber.ReadOnly = true;
                    txtFirstName.ReadOnly = true;
                    txtLastName.ReadOnly = true;
                    cmbGender.Enabled = false;
                    txtMobileNo.ReadOnly = true;
                    cmbIdentityType.Enabled = false;
                    txtIdentityNumber.ReadOnly = true;
                    txtVisitorAddress.ReadOnly = true;
                    cmbState.Enabled = false;
                    cmbCity.Enabled = false;
                    txtVehicleNumber.ReadOnly = true;
                    txtPurpose.ReadOnly = true;
                    txtEmployeeID.ReadOnly = true;
                    txtEmployeeName.ReadOnly = true;
                    txtVisitedPersonMobile.ReadOnly = true;
                    cmbRank.Enabled = false;
                    cmbUnit.Enabled = false;
                    cmbQuarterType.Enabled = false;
                    txtQuarterNumber.ReadOnly = true;
                    dteValidTill.Enabled = false;
                    dgvCoVisitors.Enabled = false;
                }

                btnPrint.Enabled = true;
            }
        }

        private void frmVisitor_Activated(object sender, EventArgs e)
        {
            if (isNewEntry)
            {
                txtMobileNo.Focus();
            }
        }

        private static void Print(string printerName, byte[] document)
        {
            try
            {
                NativeMethods.DOC_INFO_1 documentInfo;
                IntPtr printerHandle;

                documentInfo = new NativeMethods.DOC_INFO_1();
                documentInfo.pDataType = "RAW";
                documentInfo.pDocName = "Receipt";

                printerHandle = new IntPtr(0);

                if (NativeMethods.OpenPrinter(printerName.Normalize(), out printerHandle, IntPtr.Zero))
                {
                    if (NativeMethods.StartDocPrinter(printerHandle, 1, documentInfo))
                    {
                        int bytesWritten;
                        byte[] managedData;
                        IntPtr unmanagedData;

                        managedData = document;
                        unmanagedData = Marshal.AllocCoTaskMem(managedData.Length);
                        Marshal.Copy(managedData, 0, unmanagedData, managedData.Length);

                        if (NativeMethods.StartPagePrinter(printerHandle))
                        {
                            NativeMethods.WritePrinter(
                                printerHandle,
                                unmanagedData,
                                managedData.Length,
                                out bytesWritten);
                            NativeMethods.EndPagePrinter(printerHandle);
                        }
                        else
                        {
                            throw new Win32Exception();
                        }

                        Marshal.FreeCoTaskMem(unmanagedData);

                        NativeMethods.EndDocPrinter(printerHandle);
                    }
                    else
                    {
                        throw new Win32Exception();
                    }

                    NativeMethods.ClosePrinter(printerHandle);
                }
                else
                {
                    throw new Win32Exception();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Visitor Detail : Print : " + ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private byte[] GetDocument()
        {
            using (var ms = new MemoryStream())
            {
                using (var bw = new BinaryWriter(ms))
                {
                    // Reset the printer bws (NV images are not cleared)
                    bw.Write(AsciiControlChars.Escape);
                    bw.Write('@');

                    // Render the logo
                    //RenderLogo(bw);
                    PrintReceipt(bw);

                    // Feed 3 vertical motion units and cut the paper with a 1 point cut
                    bw.Write(AsciiControlChars.GroupSeparator);
                    bw.Write('V');
                    bw.Write((byte)66);
                    bw.Write((byte)3);

                    bw.Flush();

                    return ms.ToArray();
                }
            }
        }

        /// <summary>
        /// This is the method we print the receipt the way we want. Note the spaces. 
        /// Wasted a lot of paper on this to get it right.
        /// </summary>
        /// <param name="bw"></param>
        private void PrintReceipt(BinaryWriter bw)
        {

            bw.LargeText("NATIONAL SECURITY GUARD");
            bw.LargeText("--------MANESAR---------");
            bw.LargeText("     VISITOR'S PASS");
            bw.LargeText("-----------------------------");
            bw.NormalFont("Visitor #: " + visitor.VisitorID.ToString(), true);
            bw.NormalFont(" In Time : " + txtEntryTime.Text, true);
            bw.NormalFont(" Valid Till : " + dteValidTill.Text, true);
            bw.FeedLines(1);
            bw.NormalFont("Name: " + visitor.FirstName + " " + visitor.LastName, true);
            bw.NormalFont("Address: " + visitor.VisitorAddress, true);
            bw.NormalFont(" " + cmbState.Text, true);
            bw.NormalFont("Mobile #: " + visitor.MobileNo, true);
            bw.NormalFont("Veh Regn #: " + visitor.VehicleNumber, true);
            bw.NormalFont("Co-Visitors : " + coVisitors.Count.ToString(), true);
            bw.FeedLines(1);
            bw.NormalFont("Visited Person Details", true);
            bw.NormalFont("-----------------------------", true);
            bw.NormalFont(visitor.PersonName, true);
            bw.NormalFont(cmbRank.Text, true);
            bw.NormalFont(cmbUnit.Text, true);
            bw.NormalFont("-----------------------------", true);
            bw.FeedLines(1);
            bw.NormalFont("Please return this slip at the time of exit.", true);
            bw.LargeText("-----------------------------");
            bw.Finish();

        }

        private void dgvCoVisitors_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (e.Row.Cells["CoVisitorID"].Value != null)
            {
                coVisitorsRemoved.Add(coVisitors.Find(cv => cv.CoVisitorID.ToString() == e.Row.Cells["CoVisitorID"].Value.ToString()));
            }
        }

        private void txtMobileNo_Leave(object sender, EventArgs e)
        {
            if (isNewEntry && !string.IsNullOrEmpty(txtMobileNo.Text.TrimEnd()))
            {
                visitor = DB.Visitors.Where(v => v.MobileNo == txtMobileNo.Text).OrderByDescending(v => v.EntryDate).FirstOrDefault();
                
                if(visitor != null)
                {
                    isExistingVisitor = true;
                    LoadData();
                }
                
                blackListedVisitor = DB.BlackListedVisitors.Where(blv => blv.MobileNo == txtMobileNo.Text).FirstOrDefault();

                if(blackListedVisitor != null && blackListedVisitor.IsBlackListed)
                {
                    MessageBox.Show("This person has been Black Listed.\nVisitor Pass can not be issued to this person.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnEnter.Enabled = false;
                }
            }
        }
        
        private void tsmBlackList_Click(object sender, EventArgs e)
        {
            frmBlackListVisitor blackListForm;

            if(blackListedVisitor != null)
            {
                blackListForm = new frmBlackListVisitor(blackListedVisitor);
            }
            else
            {
                blackListForm = new frmBlackListVisitor(visitorID, visitor.MobileNo);
            }

            //blackListForm.Parent = this;

            var blackListResult = blackListForm.ShowDialog();

            if(blackListResult == DialogResult.OK)
            {
                var dialogResult = MessageBox.Show("This visitor has been Black Listed successfully.\nDo you want to close the form and continue?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    btnCancel_Click(null, null);
                    return;
                }
                
                btnEnter.Enabled = false;
            }

        }

        private void cmbQuarterType_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                cmbQuarterType.SelectedIndex = -1;
            }
        }
    }
}