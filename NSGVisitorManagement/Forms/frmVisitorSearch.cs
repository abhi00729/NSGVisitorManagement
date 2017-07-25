﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NSGVisitorManagement.Classes;
using System.Data.SqlClient;
using System.Xml;
using System.IO;
using System.Reflection;
using NSGVisitorManagement.DAL;
using MsExl = Microsoft.Office.Interop.Excel;

namespace NSGVisitorManagement.Forms
{
    public partial class frmVisitorSearch : Form
    {
        private bool beenHere;
        private DataSet DSExcel = new DataSet();

        private NSGVisitorEntities DB = new NSGVisitorEntities();
        
        public frmVisitorSearch()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (Form form in System.Windows.Forms.Application.OpenForms)
            {
                if (form.Name == "frmVisitor")
                {
                    //form.Activate();
                    //return;
                    form.Close();
                    break;
                }
            }

            frmVisitor visitorEntryForm = new frmVisitor(true);
            visitorEntryForm.MdiParent = this.MdiParent;
            visitorEntryForm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmVisitorSearch_Load(object sender, EventArgs e)
        {
            beenHere = false;
            btnExcelExport.Visible = true;
            btnExcelExport.Enabled = false;
        }

        private void frmVisitorSearch_Activated(object sender, EventArgs e)
        {
            if (!beenHere)
            {
                LoadValues();
            }
        }

        private void LoadValues()
        {
            long? visitorNumber = null;

            string Message = Validation.ValidateDateSelection(dteEntryDateFrom, dteEntryDateTo);

            if (Message != String.Empty)
            {
                MessageBox.Show(Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if(txtVisitorNumber.Text.Length > 0 && Validation.ValidateTextIsNumeric(txtVisitorNumber))
            {
                visitorNumber = long.Parse(txtVisitorNumber.Text);
            }

            var visitorDetails = DB.VisitorsDetailsGet(dteEntryDateFrom.Value.Date, dteEntryDateTo.Value.Date, visitorNumber, txtVisitorName.Text, txtVisitedPerson.Text, chkExitDate.Checked);
            
            grdVisitorDetails.DataSource = null;
            grdVisitorDetails.DataSource = visitorDetails.ToList();
            
            if (grdVisitorDetails.Rows.Count > 0)
            {
                grdVisitorDetails.Rows[0].Selected = false;
            }
            
            if (grdVisitorDetails.Rows.Count > 0)
            {
                lblTotalRecordCount.Text = "Total Records Found: (" + Convert.ToString(grdVisitorDetails.Rows.Count) + ") out of [" + Convert.ToString(DB.Visitors.Count()) + "]";
            }
            else
            {
                lblTotalRecordCount.Text = "Total Records Found: (0)";
            }

            btnExcelExport.Enabled = false;
            if (grdVisitorDetails.Rows.Count > 0)
            {
                btnExcelExport.Enabled = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadValues();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (grdVisitorDetails.Rows.Count <= 0 || grdVisitorDetails.CurrentRow == null)
            {
                return;
            }

            foreach (Form form in System.Windows.Forms.Application.OpenForms)
            {
                if (form.Name == "frmVisitor")
                {
                    //form.Activate();
                    form.Close();
                    break;
                    //return;
                }
            }

            frmVisitor visitorEntry = new frmVisitor(int.Parse(grdVisitorDetails.CurrentRow.Cells[0].Value.ToString()), true);
            visitorEntry.MdiParent = this.MdiParent;
            //this.Hide();
            visitorEntry.Show();
            //this.Close();
        }

        private void chkShowExported_CheckedChanged(object sender, EventArgs e)
        {
            //if (chkShowExported.Checked)
            //{
            //    LoadValues();
            //    btnXmlExport.Enabled = false;
            //}
            //else
            //{
            //    LoadValues();
            //    btnXmlExport.Enabled = true;
            //}
        }

        private void txtAppNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.ValidateQuoteCharacter(txtVisitorNumber, e);
        }

        private void txtStudentName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.ValidateQuoteCharacter(txtVisitorName, e);
        }
        
        private void btnExcelExport_Click(object sender, EventArgs e)
        {
            MsExl.Application app = null;
            MsExl.Workbook wb = null;
            MsExl.Worksheet ws = null;

            if (MessageBox.Show("This process will take few minutes to generate file. \n Click OK to Continue.", this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Information) != DialogResult.OK)
            {
                return;
            }

            try
            {
                panel1.Enabled = false;
                panel2.Enabled = false;
                panel3.Enabled = false;
                this.Cursor = Cursors.WaitCursor;

                app = new MsExl.Application();
                app.Visible = false;

                wb = app.Workbooks.Add(MsExl.XlWBATemplate.xlWBATWorksheet);
                ws = (MsExl.Worksheet)wb.ActiveSheet;

                // Headers. 
                for (int i = 0; i < grdVisitorDetails.Columns.Count; i++)
                {
                    ws.Cells[1, i + 1] = grdVisitorDetails.Columns[i].Name;
                }

                // Content.  
                for (int i = 0; i < grdVisitorDetails.Rows.Count; i++)
                {
                    for (int j = 0; j < grdVisitorDetails.Columns.Count; j++)
                    {
                        if (grdVisitorDetails.Rows[i].Cells[j].Value != null)
                        {
                            ws.Cells[i + 2, j + 1] = grdVisitorDetails.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                }
                
                // Autofit Cells,Column and Rows Width.
                ws.Columns.AutoFit();
                ws.Rows.WrapText = true;

                ws.Range[ws.Cells[1, 1], ws.Cells[grdVisitorDetails.Rows.Count + 1, grdVisitorDetails.Columns.Count]].Borders.LineStyle = true;
                ws.Range[ws.Cells[1, 1], ws.Cells[1, grdVisitorDetails.Columns.Count]].Font.Bold = true;

                wb.SaveAs(GetExportFileName(".xls"), MsExl.XlFileFormat.xlWorkbookNormal,
                    Missing.Value, Missing.Value, Missing.Value, Missing.Value,
                    Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive,
                    Missing.Value, Missing.Value, Missing.Value,
                    Missing.Value, Missing.Value);

                wb.Close(Missing.Value, Missing.Value, Missing.Value);
                app.Quit();
                app = null;
                wb = null;
                ws = null;

                MessageBox.Show("Export Excel file successfully created at below mentioned path. \n " + GetExportFileName(".xls"), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Cursor = Cursors.Default;
                panel1.Enabled = true;
                panel2.Enabled = true;
                panel3.Enabled = true;
            }
            catch(Exception ex)
            {
                this.Cursor = Cursors.Default;
                panel1.Enabled = true;
                panel2.Enabled = true;
                panel3.Enabled = true;

                if (app != null)
                {
                    wb = null;
                    ws = null;
                    app.Quit();
                    app = null;
                }

                MessageBox.Show(ex.Message, this.Text + " : btnExcelExport_Click : " + ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetExportFileName(string format)
        {
            string dirChar = AppDomain.CurrentDomain.BaseDirectory.Substring(0, 1);

            string dir = dirChar + @":\NSGExport";
            string fileName = "";

            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            fileName = dir + @"\" + GlobalClass.MachineName + DateTime.Now.ToString("dd_MM_yyyy hh_mm_ss") + ".xls";

            return fileName;
        }

    }
}
