using System;
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
    public partial class frmExportNotExitedVisitors : Form
    {
        private Timer timerVisitorNotExited;
        private NSGVisitorEntities DB = new NSGVisitorEntities();

        public frmExportNotExitedVisitors()
        {
            InitializeComponent();
        }

        private void frmExportNotExitedVisitors_Load(object sender, EventArgs e)
        {
            lblMessage.Text = "System is exporting not exited visitors for the day.\nThis form will auto close after completion of process.\nPlease wait for the process to finish.";
        }

        private void ExcelExport()
        {
            MsExl.Application app = null;
            MsExl.Workbook wb = null;
            MsExl.Worksheet ws = null;
            
            try
            {
                var visitorDetails = DB.GetNotExitedVisitorsForTheDate(DateTime.Today).ToList();

                var dtVisitorDetails = GlobalClass.ConvertToDataTable(visitorDetails);

                this.Cursor = Cursors.WaitCursor;

                app = new MsExl.Application();
                app.Visible = false;

                wb = app.Workbooks.Add(MsExl.XlWBATemplate.xlWBATWorksheet);
                ws = (MsExl.Worksheet)wb.ActiveSheet;

                // Headers. 
                for (int i = 0; i < dtVisitorDetails.Columns.Count; i++)
                {
                    ws.Cells[1, i + 1] = dtVisitorDetails.Columns[i].ColumnName;
                }

                // Content.  
                for (int i = 0; i < dtVisitorDetails.Rows.Count; i++)
                {
                    for (int j = 0; j < dtVisitorDetails.Columns.Count; j++)
                    {
                        if (dtVisitorDetails.Rows[i][j] != null)
                        {
                            ws.Cells[i + 2, j + 1] = dtVisitorDetails.Rows[i][j].ToString();
                        }
                    }
                }

                // Autofit Cells,Column and Rows Width.
                ws.Columns.AutoFit();
                ws.Rows.WrapText = true;

                ws.Range[ws.Cells[1, 1], ws.Cells[dtVisitorDetails.Rows.Count + 1, dtVisitorDetails.Columns.Count]].Borders.LineStyle = true;
                ws.Range[ws.Cells[1, 1], ws.Cells[1, dtVisitorDetails.Columns.Count]].Font.Bold = true;

                string exportFileName = GetExportFileName(".xls");

                wb.SaveAs(exportFileName, MsExl.XlFileFormat.xlWorkbookNormal,
                    Missing.Value, Missing.Value, Missing.Value, Missing.Value,
                    Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive,
                    Missing.Value, Missing.Value, Missing.Value,
                    Missing.Value, Missing.Value);

                wb.Close(Missing.Value, Missing.Value, Missing.Value);
                app.Quit();
                app = null;
                wb = null;
                ws = null;

                MessageBox.Show("Export Excel file successfully created at below mentioned path. \n " + exportFileName, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;

                if (app != null)
                {
                    wb = null;
                    ws = null;
                    app.Quit();
                    app = null;
                }

                MessageBox.Show(ex.Message, this.Text + " : ExcelExport : " + ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            fileName = dir + @"\" + "NotExitedVisitorsForTheDay_" + GlobalClass.MachineName + DateTime.Now.ToString("dd_MM_yyyy hh_mm_ss") + ".xls";

            return fileName;
        }

        private void frmExportNotExitedVisitors_Activated(object sender, EventArgs e)
        {
            timerVisitorNotExited = new Timer();
            timerVisitorNotExited.Tick += TimerVisitorNotExited_Tick;
            timerVisitorNotExited.Interval = 2000;
            timerVisitorNotExited.Start();
        }

        private void TimerVisitorNotExited_Tick(object sender, EventArgs e)
        {
            timerVisitorNotExited.Stop();
            ExcelExport();
            this.Close();
        }
    }
}
