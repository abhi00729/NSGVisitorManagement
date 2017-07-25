using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NSGVisitorManagement.Classes;
using NSGVisitorManagement.DAL;
using System.Data.Entity.Core.Objects.DataClasses;

namespace NSGVisitorManagement.Forms
{
    public partial class frmMasterList : Form
    {
        private NSGVisitorEntities DB = new NSGVisitorEntities();
        MasterTypes masterType;
        
        public frmMasterList()
        {
            InitializeComponent();
        }

        public frmMasterList(MasterTypes masterOf)
        {
            masterType = masterOf;
            InitializeComponent();
        }

        private void frmMasterList_Load(object sender, EventArgs e)
        {
            if (GlobalClass.LoggedInUserID != 1)
            {
                btnAdd.Enabled = false;
                btnEdit.Enabled = false;
            }

            this.Text += " - " + masterType.ToString();
            switch (masterType)
            {
                case MasterTypes.States:
                    PopulateStates();
                    break;
                case MasterTypes.Cities:
                    PopulateCities();
                    break;
                case MasterTypes.Users:
                    PopulateUsers();
                    break;
                case MasterTypes.IdentityTypes:
                    PopulateIdentityTypes();
                    break;
                case MasterTypes.Relationships:
                    PopulateRelationships();
                    break;
                case MasterTypes.Ranks:
                    PopulateRanks();
                    break;
                case MasterTypes.Units:
                    PopulateUnits();
                    break;
                case MasterTypes.QuarterTypes:
                    PopulateQuarterTypes();
                    break;
                default:
                    break;
            }

            if(dgvMasterList.Columns.Count > 0)
            {
                dgvMasterList.Columns[0].Visible = false;
            }
        }

        private void PopulateQuarterTypes()
        {
            dgvMasterList.DataSource = DB.CoreQuarterTypes.Select(qt => new { qt.QuarterTypeID, qt.QuarterTypeName, qt.MaxQuarterNumber, qt.IsActive }).OrderBy(qt => qt.QuarterTypeName).ToList();
        }

        private void PopulateUnits()
        {
            dgvMasterList.DataSource = DB.CoreUnits.Select(cu => new { cu.UnitID, cu.UnitName, cu.IsActive }).OrderBy(cu => cu.UnitName).ToList();
        }

        private void PopulateRanks()
        {
            dgvMasterList.DataSource = DB.CoreRanks.Select(cr => new { cr.RankID, cr.RankName, cr.IsActive }).OrderBy(cr => cr.RankName).ToList();
        }

        private void PopulateRelationships()
        {
            dgvMasterList.DataSource = DB.CoreRelationships.Select(cr => new { cr.RelationshipID, cr.Relationship }).OrderBy(cr => cr.Relationship).ToList();
        }

        private void PopulateIdentityTypes()
        {
            dgvMasterList.DataSource = DB.CoreIdentityTypes.Select(ci => new { ci.IdentityTypeID, ci.IdentityType, ci.IsActive }).OrderBy(ci => ci.IdentityType).ToList();
        }

        private void PopulateUsers()
        {
            var employees = (from emp in DB.NSGEmployees
                             join cr in DB.CoreRanks on emp.RankID equals cr.RankID
                             join cu in DB.CoreUnits on emp.UnitID equals cu.UnitID
                             join qt in DB.CoreQuarterTypes on emp.QuarterTypeID equals qt.QuarterTypeID into tmpqt from cqt in tmpqt.DefaultIfEmpty()
                             join usr in DB.CoreUsers on emp.NSGEmployeeCode equals usr.EmployeeID into tmpUser from cusr in tmpUser.DefaultIfEmpty()
                             select new
                             {
                                 emp.NSGEmployeeID,
                                 emp.NSGEmployeeCode,
                                 EmployeeName = emp.FirstName + " " +emp.LastName,
                                 emp.Gender,
                                 cr.RankName,
                                 cu.UnitName,
                                 cqt.QuarterTypeName,
                                 emp.QuarterNumber,
                                 EmployeeActive = emp.IsActive,
                                 UserName = cusr.UserName,
                                 UserActive = (cusr != null ? cusr.IsActive : false)
                             }).OrderBy(e => e.EmployeeName);

            dgvMasterList.DataSource = employees.ToList();
        }

        private void PopulateStates()
        {
            dgvMasterList.DataSource = DB.CoreStates.Select(cs => new { cs.StateID, cs.StateName, TotalCities = cs.CoreCities.Where(cc => cc.StateID == cs.StateID).Count() }).OrderBy(cs => cs.StateName).ToList();
        }

        private void PopulateCities()
        {
            dgvMasterList.DataSource = DB.CoreCities.Select(cc => new { cc.CityID, cc.CityName, cc.CoreState.StateName }).OrderBy(cc => cc.CityName).ToList();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
