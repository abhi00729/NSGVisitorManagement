namespace NSGVisitorManagement.Forms
{
    partial class frmBlackListedVisitor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBlackListedVisitor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkSearchByDates = new System.Windows.Forms.CheckBox();
            this.dteDateTo = new System.Windows.Forms.DateTimePicker();
            this.dteDateFrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkUnListed = new System.Windows.Forms.CheckBox();
            this.txtMobileNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVisitedPerson = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtVisitorName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grdVisitorDetails = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExcelExport = new System.Windows.Forms.Button();
            this.lblTotalRecordCount = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVisitorDetails)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.chkSearchByDates);
            this.panel1.Controls.Add(this.dteDateTo);
            this.panel1.Controls.Add(this.dteDateFrom);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.chkUnListed);
            this.panel1.Controls.Add(this.txtMobileNo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtVisitedPerson);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtVisitorName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 75);
            this.panel1.TabIndex = 0;
            // 
            // chkSearchByDates
            // 
            this.chkSearchByDates.AutoSize = true;
            this.chkSearchByDates.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSearchByDates.Location = new System.Drawing.Point(7, 47);
            this.chkSearchByDates.Name = "chkSearchByDates";
            this.chkSearchByDates.Size = new System.Drawing.Size(107, 18);
            this.chkSearchByDates.TabIndex = 16;
            this.chkSearchByDates.Text = "Search By Dates";
            this.chkSearchByDates.UseVisualStyleBackColor = true;
            this.chkSearchByDates.CheckedChanged += new System.EventHandler(this.chkSearchByDates_CheckedChanged);
            // 
            // dteDateTo
            // 
            this.dteDateTo.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dteDateTo.CustomFormat = "dd-MMM-yyyy";
            this.dteDateTo.Enabled = false;
            this.dteDateTo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dteDateTo.Location = new System.Drawing.Point(369, 43);
            this.dteDateTo.Name = "dteDateTo";
            this.dteDateTo.Size = new System.Drawing.Size(111, 23);
            this.dteDateTo.TabIndex = 13;
            // 
            // dteDateFrom
            // 
            this.dteDateFrom.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dteDateFrom.CustomFormat = "dd-MMM-yyyy";
            this.dteDateFrom.Enabled = false;
            this.dteDateFrom.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dteDateFrom.Location = new System.Drawing.Point(183, 43);
            this.dteDateFrom.Name = "dteDateFrom";
            this.dteDateFrom.Size = new System.Drawing.Size(111, 23);
            this.dteDateFrom.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(316, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "To Date:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "From Date:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // chkUnListed
            // 
            this.chkUnListed.AutoSize = true;
            this.chkUnListed.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUnListed.Location = new System.Drawing.Point(512, 47);
            this.chkUnListed.Name = "chkUnListed";
            this.chkUnListed.Size = new System.Drawing.Size(105, 18);
            this.chkUnListed.TabIndex = 10;
            this.chkUnListed.Text = "Search UnListed";
            this.chkUnListed.UseVisualStyleBackColor = true;
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtMobileNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMobileNo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobileNo.Location = new System.Drawing.Point(369, 8);
            this.txtMobileNo.MaxLength = 15;
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Size = new System.Drawing.Size(134, 23);
            this.txtMobileNo.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(300, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Mobile No:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtVisitedPerson
            // 
            this.txtVisitedPerson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtVisitedPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVisitedPerson.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVisitedPerson.Location = new System.Drawing.Point(641, 8);
            this.txtVisitedPerson.Name = "txtVisitedPerson";
            this.txtVisitedPerson.Size = new System.Drawing.Size(196, 23);
            this.txtVisitedPerson.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(509, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Visited Person Name:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(744, 43);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(93, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtVisitorName
            // 
            this.txtVisitorName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtVisitorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVisitorName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVisitorName.Location = new System.Drawing.Point(91, 8);
            this.txtVisitorName.Name = "txtVisitorName";
            this.txtVisitorName.Size = new System.Drawing.Size(203, 23);
            this.txtVisitorName.TabIndex = 3;
            this.txtVisitorName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStudentName_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Visitor Name:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.grdVisitorDetails);
            this.panel2.Location = new System.Drawing.Point(12, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(844, 293);
            this.panel2.TabIndex = 1;
            // 
            // grdVisitorDetails
            // 
            this.grdVisitorDetails.AllowUserToAddRows = false;
            this.grdVisitorDetails.AllowUserToDeleteRows = false;
            this.grdVisitorDetails.AllowUserToResizeRows = false;
            this.grdVisitorDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdVisitorDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.grdVisitorDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdVisitorDetails.Location = new System.Drawing.Point(7, 6);
            this.grdVisitorDetails.MultiSelect = false;
            this.grdVisitorDetails.Name = "grdVisitorDetails";
            this.grdVisitorDetails.ReadOnly = true;
            this.grdVisitorDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdVisitorDetails.Size = new System.Drawing.Size(830, 278);
            this.grdVisitorDetails.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnExcelExport);
            this.panel3.Controls.Add(this.lblTotalRecordCount);
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Controls.Add(this.btnEdit);
            this.panel3.Location = new System.Drawing.Point(12, 382);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(844, 37);
            this.panel3.TabIndex = 2;
            // 
            // btnExcelExport
            // 
            this.btnExcelExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnExcelExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcelExport.Image = global::NSGVisitorManagement.Properties.Resources.Excel;
            this.btnExcelExport.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcelExport.Location = new System.Drawing.Point(7, 5);
            this.btnExcelExport.Name = "btnExcelExport";
            this.btnExcelExport.Size = new System.Drawing.Size(75, 23);
            this.btnExcelExport.TabIndex = 10;
            this.btnExcelExport.Text = "&Export";
            this.btnExcelExport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.btnExcelExport, "Export Grid Data to Excel File");
            this.btnExcelExport.UseVisualStyleBackColor = false;
            this.btnExcelExport.Click += new System.EventHandler(this.btnExcelExport_Click);
            // 
            // lblTotalRecordCount
            // 
            this.lblTotalRecordCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalRecordCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblTotalRecordCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRecordCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTotalRecordCount.Location = new System.Drawing.Point(88, 5);
            this.lblTotalRecordCount.Name = "lblTotalRecordCount";
            this.lblTotalRecordCount.Size = new System.Drawing.Size(489, 23);
            this.lblTotalRecordCount.TabIndex = 9;
            this.lblTotalRecordCount.Text = "#";
            this.lblTotalRecordCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(762, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Location = new System.Drawing.Point(673, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // frmBlackListedVisitor
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(865, 425);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBlackListedVisitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Time Expired Visitor";
            this.Activated += new System.EventHandler(this.frmTimeExpiredVisitor_Activated);
            this.Load += new System.EventHandler(this.frmTimeExpiredVisitor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdVisitorDetails)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView grdVisitorDetails;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtVisitorName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalRecordCount;
        private System.Windows.Forms.Button btnExcelExport;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtVisitedPerson;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMobileNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkSearchByDates;
        private System.Windows.Forms.DateTimePicker dteDateTo;
        private System.Windows.Forms.DateTimePicker dteDateFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkUnListed;
    }
}