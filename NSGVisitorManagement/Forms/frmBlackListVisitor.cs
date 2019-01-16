using NSGVisitorManagement.Classes;
using NSGVisitorManagement.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NSGVisitorManagement.Forms
{
    public partial class frmBlackListVisitor : Form
    {
        private bool isNewEntry = true;
        private long visitorID = 0;
        private string visitorMobileNumber;
        private bool doNoClose;

        private NSGVisitorEntities DB = new NSGVisitorEntities();

        BlackListedVisitor blackListedVisitor;

        public frmBlackListVisitor(long visitorID, string mobileNumber)
        {
            InitializeComponent();
            this.visitorID = visitorID;
            this.visitorMobileNumber = mobileNumber;
        }

        public frmBlackListVisitor(BlackListedVisitor blVisitor)
        {
            InitializeComponent();
            
            this.visitorID = blVisitor.VisitorID;
            this.visitorMobileNumber = blVisitor.MobileNo;
            this.blackListedVisitor = blVisitor;
        }

        private void frmBlackListVisitor_Load(object sender, EventArgs e)
        {
            this.Text += " - " + visitorMobileNumber;

            LoadData();
        }

        private void LoadData()
        {
            if(blackListedVisitor == null)
            {
                blackListedVisitor = DB.BlackListedVisitors.Where(blv => blv.MobileNo == visitorMobileNumber).FirstOrDefault();
            }

            if (blackListedVisitor == null)
            {
                btnSave.Enabled = false;
                return;
            }

            isNewEntry = false;

            chkBlackList.Checked = blackListedVisitor.IsBlackListed;
            txtHistory.Text = blackListedVisitor.Reason;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(blackListedVisitor == null && !chkBlackList.Checked)
            {
                MessageBox.Show("Please select the Black List or close the form.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                doNoClose = true;
                return;
            }

            if (chkBlackList.Checked && txtReason.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter a reason for Black Listing this visitor.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                doNoClose = true;
                return;
            }


            DialogResult msgResponse = MessageBox.Show("Are you sure you want to " + (chkBlackList.Checked ? "Black List" : "UnList") + " this visitor?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            if(msgResponse == DialogResult.No)
            {
                doNoClose = true;
                return;
            }

            if (blackListedVisitor == null)
            {
                blackListedVisitor = new BlackListedVisitor();
                blackListedVisitor.EntryDate = DateTime.Now;
                blackListedVisitor.EntryUserID = GlobalClass.LoggedInUserID;
            }
            else
            {
                blackListedVisitor.UpdateDate = DateTime.Now;
                blackListedVisitor.UpdateUserID = GlobalClass.LoggedInUserID;
            }

            blackListedVisitor.VisitorID = visitorID;
            blackListedVisitor.MobileNo = visitorMobileNumber;
            blackListedVisitor.IsBlackListed = chkBlackList.Checked;

            if(txtHistory.Text != string.Empty)
            {
                txtHistory.Text += "\r\n";
            }

            blackListedVisitor.Reason = txtHistory.Text + DateTime.Now.ToShortDateString() + " : " + (chkBlackList.Checked ? "BlackListed" : "UnListed") + "\r\n" + txtReason.Text;

            if(isNewEntry)
            {
                DB.BlackListedVisitors.Add(blackListedVisitor);
            }

            DB.SaveChanges();

            doNoClose = false;

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            doNoClose = false;
            this.Close();
        }

        private void chkBlackList_CheckedChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void frmBlackListVisitor_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = doNoClose;
        }
    }
}
