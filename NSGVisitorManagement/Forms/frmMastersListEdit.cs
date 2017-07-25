using NSGVisitorManagement.Classes;
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
    public partial class frmMastersListEdit : Form
    {
        MasterTypes masterType;
        long recordID;

        delegate void LoadData();
        delegate void SaveData();

        LoadData loadRespectiveData;
        SaveData saveRespectiveData;

        public frmMastersListEdit()
        {
            InitializeComponent();
        }

        public frmMastersListEdit(MasterTypes editMasterOf, long editRecordID)
        {
            masterType = editMasterOf;
            recordID = editRecordID;
            InitializeComponent();
            
            switch (masterType)
            {
                case MasterTypes.States:
                    loadRespectiveData = new LoadData(LoadState);
                    saveRespectiveData = new SaveData(SaveState);
                    break;
                case MasterTypes.Cities:
                    loadRespectiveData = new LoadData(LoadCity);
                    saveRespectiveData = new SaveData(SaveCity);
                    break;
                case MasterTypes.IdentityTypes:
                    loadRespectiveData = new LoadData(LoadIdentityType);
                    saveRespectiveData = new SaveData(SaveIdentityType);
                    break;
                case MasterTypes.Relationships:
                    loadRespectiveData = new LoadData(LoadRelationship);
                    saveRespectiveData = new SaveData(SaveRelationship);
                    break;
                case MasterTypes.Ranks:
                    loadRespectiveData = new LoadData(LoadRank);
                    saveRespectiveData = new SaveData(SaveRank);
                    break;
                case MasterTypes.Units:
                    loadRespectiveData = new LoadData(LoadUnit);
                    saveRespectiveData = new SaveData(SaveUnit);
                    break;
                case MasterTypes.QuarterTypes:
                    loadRespectiveData = new LoadData(LoadQuarterType);
                    saveRespectiveData = new SaveData(SaveQuarterType);
                    break;
                default:
                    break;
            }
        }

        private void frmMastersListEdit_Load(object sender, EventArgs e)
        {
            this.Text += " - " + masterType.ToString();
            loadRespectiveData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsDataValid())
            {
                saveRespectiveData();
            }
        }

        private bool IsDataValid()
        {
            bool response = true;

            return response;
        }

        #region LoadData

        private void LoadState()
        {
            throw new NotImplementedException();
        }
        
        private void LoadCity()
        {
            throw new NotImplementedException();
        }
        
        private void LoadIdentityType()
        {
            throw new NotImplementedException();
        }
        
        private void LoadRelationship()
        {
            throw new NotImplementedException();
        }
        
        private void LoadRank()
        {
            throw new NotImplementedException();
        }
        
        private void LoadUnit()
        {
            throw new NotImplementedException();
        }
        
        private void LoadQuarterType()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region SaveData

        private void SaveState()
        {
            throw new NotImplementedException();
        }

        private void SaveCity()
        {
            throw new NotImplementedException();
        }

        private void SaveIdentityType()
        {
            throw new NotImplementedException();
        }

        private void SaveRelationship()
        {
            throw new NotImplementedException();
        }

        private void SaveRank()
        {
            throw new NotImplementedException();
        }

        private void SaveUnit()
        {
            throw new NotImplementedException();
        }

        private void SaveQuarterType()
        {
            throw new NotImplementedException();
        }

        #endregion

        
    }
}
