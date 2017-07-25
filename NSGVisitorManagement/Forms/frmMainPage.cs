﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NSGVisitorManagement.Forms;
using System.Data.SqlClient;
using NSGVisitorManagement.Classes;

namespace NSGVisitorManagement
{
    public partial class frmMainPage : Form
    {
        Form formToOpen;
        public frmMainPage()
        {
            InitializeComponent();
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            Application.Exit();
        }

        private void mnuFileChangePassword_Click(object sender, EventArgs e)
        {
            if (CheckIsFormOpen("frmChangePassword"))
            {
                return;
            }

            formToOpen = new frmChangePassword();
            formToOpen.MdiParent = this;
            formToOpen.Show();
        }

        private void mnuVisitorBookVisitorIn_Click(object sender, EventArgs e)
        {
            if (CheckIsFormOpen("frmVisitor"))
            {
                return;
            }

            formToOpen = new frmVisitor(true);
            formToOpen.MdiParent = this;
            formToOpen.Show();
        }

        private void mnuVisitorBookVisitorOut_Click(object sender, EventArgs e)
        {
            if (CheckIsFormOpen("frmVisitor"))
            {
                return;
            }

            formToOpen = new frmVisitor(false);
            formToOpen.MdiParent = this;
            formToOpen.Show();
        }
        
        private bool CheckIsFormOpen(string frmName)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == frmName)
                {
                    form.Activate();
                    return true;
                }
            }
            return false;
        }
        
        private void frmMainPage_Load(object sender, EventArgs e)
        {
            this.Text = " Welcome " + GlobalClass.EmployeeName + " [ "+ GlobalClass.LoggedInUserRank +" ] " + " [" + GlobalClass.LoggedInUserUnit + "] " + " | " + GlobalClass.ProductName + " [" + GlobalClass.BuildVersion + "]";
        }

        private void mnuFileNSGEmployees_Click(object sender, EventArgs e)
        {
            formToOpen = new frmCreateUser();
            formToOpen.MdiParent = this;
            formToOpen.Show();
        }

        private void mnuVisitorBookVisitorSearch_Click(object sender, EventArgs e)
        {
            if (CheckIsFormOpen("frmVisitorSearch"))
            {
                return;
            }

            formToOpen = new frmVisitorSearch();
            formToOpen.MdiParent = this;
            formToOpen.Show();
        }

        private void mnuHelpAbout_Click(object sender, EventArgs e)
        {
            frmAbout af = new frmAbout();
            af.MdiParent = this;
            af.Show();
        }

        private void frmMainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if(MessageBox.Show("Are you sure your want to close this Application?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.No)
            //{
            //    e.Cancel = true;
            //}
        }

        private void mnuMastersStates_Click(object sender, EventArgs e)
        {
            OpenMasterList(MasterTypes.States);
        }

        private void mnuMastersCities_Click(object sender, EventArgs e)
        {
            OpenMasterList(MasterTypes.Cities);
        }

        private void mnuMastersUsers_Click(object sender, EventArgs e)
        {
            OpenMasterList(MasterTypes.Users);
        }

        private void mnuMastersIdentityTypes_Click(object sender, EventArgs e)
        {
            OpenMasterList(MasterTypes.IdentityTypes);
        }

        private void mnuMastersRelationships_Click(object sender, EventArgs e)
        {
            OpenMasterList(MasterTypes.Relationships);
        }

        private void mnuMastersRanks_Click(object sender, EventArgs e)
        {
            OpenMasterList(MasterTypes.Ranks);
        }

        private void mnuMastersUnits_Click(object sender, EventArgs e)
        {
            OpenMasterList(MasterTypes.Units);
        }

        private void mnuMastersQuarterTypes_Click(object sender, EventArgs e)
        {
            OpenMasterList(MasterTypes.QuarterTypes);
        }

        private void OpenMasterList(MasterTypes masterType)
        {
            if (CheckIsFormOpen("frmMasterList"))
            {
                return;
            }

            formToOpen = new frmMasterList(masterType);
            formToOpen.MdiParent = this;
            formToOpen.Show();
        }
    }
}
