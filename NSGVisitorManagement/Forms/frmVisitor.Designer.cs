namespace NSGVisitorManagement.Forms
{
    partial class frmVisitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisitor));
            this.lblVisitorNumber = new System.Windows.Forms.Label();
            this.txtVisitorNumber = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnCapture = new System.Windows.Forms.Button();
            this.picVisitorPhoto = new System.Windows.Forms.PictureBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblIdentityType = new System.Windows.Forms.Label();
            this.txtIdentityNumber = new System.Windows.Forms.TextBox();
            this.lblIdentityNumber = new System.Windows.Forms.Label();
            this.txtVisitorAddress = new System.Windows.Forms.TextBox();
            this.lblVisitorAddress = new System.Windows.Forms.Label();
            this.cmbIdentityType = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.dgvCoVisitors = new System.Windows.Forms.DataGridView();
            this.CoVisitorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoVisitorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.IdentityType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.IdentityNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Relationship = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVehicleNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtEntryTime = new System.Windows.Forms.TextBox();
            this.lblEntryTime = new System.Windows.Forms.Label();
            this.lblExitTime = new System.Windows.Forms.Label();
            this.txtExitTime = new System.Windows.Forms.TextBox();
            this.visitorTimer = new System.Windows.Forms.Timer(this.components);
            this.txtQuarterNumber = new System.Windows.Forms.TextBox();
            this.cmbQuarterType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.cmbRank = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPurpose = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMobileNo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.txtVisitedPersonMobile = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dteValidTill = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmBlackList = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVisitorPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoVisitors)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVisitorNumber
            // 
            this.lblVisitorNumber.AutoSize = true;
            this.lblVisitorNumber.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisitorNumber.Location = new System.Drawing.Point(6, 10);
            this.lblVisitorNumber.Name = "lblVisitorNumber";
            this.lblVisitorNumber.Size = new System.Drawing.Size(110, 16);
            this.lblVisitorNumber.TabIndex = 0;
            this.lblVisitorNumber.Text = "Visitor Number :";
            // 
            // txtVisitorNumber
            // 
            this.txtVisitorNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtVisitorNumber.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVisitorNumber.ForeColor = System.Drawing.Color.Black;
            this.txtVisitorNumber.Location = new System.Drawing.Point(122, 6);
            this.txtVisitorNumber.MaxLength = 10;
            this.txtVisitorNumber.Name = "txtVisitorNumber";
            this.txtVisitorNumber.Size = new System.Drawing.Size(211, 22);
            this.txtVisitorNumber.TabIndex = 0;
            this.txtVisitorNumber.Leave += new System.EventHandler(this.txtVisitorNumber_Leave);
            this.txtVisitorNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtVisitorNumber_Validating);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnCapture);
            this.groupBox6.Controls.Add(this.picVisitorPhoto);
            this.groupBox6.Location = new System.Drawing.Point(681, 1);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(206, 306);
            this.groupBox6.TabIndex = 19;
            this.groupBox6.TabStop = false;
            // 
            // btnCapture
            // 
            this.btnCapture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapture.Image = ((System.Drawing.Image)(resources.GetObject("btnCapture.Image")));
            this.btnCapture.Location = new System.Drawing.Point(7, 238);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(193, 60);
            this.btnCapture.TabIndex = 21;
            this.btnCapture.Text = "&Capture Photo";
            this.btnCapture.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // picVisitorPhoto
            // 
            this.picVisitorPhoto.AccessibleDescription = "";
            this.picVisitorPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picVisitorPhoto.InitialImage = null;
            this.picVisitorPhoto.Location = new System.Drawing.Point(7, 15);
            this.picVisitorPhoto.Name = "picVisitorPhoto";
            this.picVisitorPhoto.Size = new System.Drawing.Size(193, 215);
            this.picVisitorPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picVisitorPhoto.TabIndex = 0;
            this.picVisitorPhoto.TabStop = false;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtFirstName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(96, 59);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(237, 21);
            this.txtFirstName.TabIndex = 2;
            this.txtFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstName_KeyPress);
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtFirstName_Validating);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(6, 61);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(84, 16);
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Text = "First Name :";
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtLastName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(95, 86);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(238, 21);
            this.txtLastName.TabIndex = 3;
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastName_KeyPress);
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtLastName_Validating);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(6, 89);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(83, 16);
            this.lblLastName.TabIndex = 6;
            this.lblLastName.Text = "Last Name :";
            // 
            // lblIdentityType
            // 
            this.lblIdentityType.AutoSize = true;
            this.lblIdentityType.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentityType.Location = new System.Drawing.Point(6, 150);
            this.lblIdentityType.Name = "lblIdentityType";
            this.lblIdentityType.Size = new System.Drawing.Size(97, 16);
            this.lblIdentityType.TabIndex = 8;
            this.lblIdentityType.Text = "Identity Type :";
            // 
            // txtIdentityNumber
            // 
            this.txtIdentityNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtIdentityNumber.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentityNumber.Location = new System.Drawing.Point(129, 176);
            this.txtIdentityNumber.Name = "txtIdentityNumber";
            this.txtIdentityNumber.Size = new System.Drawing.Size(204, 21);
            this.txtIdentityNumber.TabIndex = 6;
            // 
            // lblIdentityNumber
            // 
            this.lblIdentityNumber.AutoSize = true;
            this.lblIdentityNumber.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentityNumber.Location = new System.Drawing.Point(6, 178);
            this.lblIdentityNumber.Name = "lblIdentityNumber";
            this.lblIdentityNumber.Size = new System.Drawing.Size(117, 16);
            this.lblIdentityNumber.TabIndex = 10;
            this.lblIdentityNumber.Text = "Identity Number :";
            // 
            // txtVisitorAddress
            // 
            this.txtVisitorAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtVisitorAddress.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVisitorAddress.Location = new System.Drawing.Point(6, 225);
            this.txtVisitorAddress.Multiline = true;
            this.txtVisitorAddress.Name = "txtVisitorAddress";
            this.txtVisitorAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtVisitorAddress.Size = new System.Drawing.Size(327, 58);
            this.txtVisitorAddress.TabIndex = 7;
            // 
            // lblVisitorAddress
            // 
            this.lblVisitorAddress.AutoSize = true;
            this.lblVisitorAddress.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisitorAddress.Location = new System.Drawing.Point(6, 206);
            this.lblVisitorAddress.Name = "lblVisitorAddress";
            this.lblVisitorAddress.Size = new System.Drawing.Size(119, 16);
            this.lblVisitorAddress.TabIndex = 13;
            this.lblVisitorAddress.Text = "Visitor\'s Address :";
            // 
            // cmbIdentityType
            // 
            this.cmbIdentityType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbIdentityType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdentityType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbIdentityType.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIdentityType.FormattingEnabled = true;
            this.cmbIdentityType.Location = new System.Drawing.Point(109, 147);
            this.cmbIdentityType.Name = "cmbIdentityType";
            this.cmbIdentityType.Size = new System.Drawing.Size(224, 23);
            this.cmbIdentityType.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(715, 465);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(166, 35);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Ca&ncel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(715, 370);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(166, 35);
            this.btnEnter.TabIndex = 22;
            this.btnEnter.Text = "&Save Entry";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // dgvCoVisitors
            // 
            this.dgvCoVisitors.AllowUserToResizeRows = false;
            this.dgvCoVisitors.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvCoVisitors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoVisitors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CoVisitorID,
            this.CoVisitorName,
            this.Gender,
            this.IdentityType,
            this.IdentityNumber,
            this.Relationship});
            this.dgvCoVisitors.Location = new System.Drawing.Point(9, 370);
            this.dgvCoVisitors.Name = "dgvCoVisitors";
            this.dgvCoVisitors.Size = new System.Drawing.Size(692, 131);
            this.dgvCoVisitors.TabIndex = 20;
            this.dgvCoVisitors.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvCoVisitors_UserDeletingRow);
            // 
            // CoVisitorID
            // 
            this.CoVisitorID.HeaderText = "CoVisitorID";
            this.CoVisitorID.Name = "CoVisitorID";
            this.CoVisitorID.Visible = false;
            // 
            // CoVisitorName
            // 
            this.CoVisitorName.HeaderText = "Co Visitor Name";
            this.CoVisitorName.Name = "CoVisitorName";
            this.CoVisitorName.Width = 150;
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Genter";
            this.Gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.Gender.Name = "Gender";
            // 
            // IdentityType
            // 
            this.IdentityType.HeaderText = "Identity Type";
            this.IdentityType.Name = "IdentityType";
            this.IdentityType.Width = 120;
            // 
            // IdentityNumber
            // 
            this.IdentityNumber.HeaderText = "Identity Number";
            this.IdentityNumber.Name = "IdentityNumber";
            this.IdentityNumber.Width = 120;
            // 
            // Relationship
            // 
            this.Relationship.HeaderText = "Relationship";
            this.Relationship.Name = "Relationship";
            this.Relationship.Width = 120;
            // 
            // cmbCity
            // 
            this.cmbCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCity.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbCity.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(61, 317);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(272, 23);
            this.cmbCity.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "City :";
            // 
            // cmbState
            // 
            this.cmbState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbState.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbState.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Location = new System.Drawing.Point(61, 288);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(272, 23);
            this.cmbState.TabIndex = 8;
            this.cmbState.SelectedIndexChanged += new System.EventHandler(this.cmbState_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "State :";
            // 
            // txtVehicleNumber
            // 
            this.txtVehicleNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtVehicleNumber.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVehicleNumber.Location = new System.Drawing.Point(467, 59);
            this.txtVehicleNumber.Name = "txtVehicleNumber";
            this.txtVehicleNumber.Size = new System.Drawing.Size(206, 21);
            this.txtVehicleNumber.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(344, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Vehicle Number :";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnPrint.Enabled = false;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(715, 417);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(166, 35);
            this.btnPrint.TabIndex = 23;
            this.btnPrint.Text = "&Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtEntryTime
            // 
            this.txtEntryTime.BackColor = System.Drawing.Color.Black;
            this.txtEntryTime.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntryTime.ForeColor = System.Drawing.Color.Lime;
            this.txtEntryTime.Location = new System.Drawing.Point(442, 7);
            this.txtEntryTime.Name = "txtEntryTime";
            this.txtEntryTime.ReadOnly = true;
            this.txtEntryTime.Size = new System.Drawing.Size(231, 22);
            this.txtEntryTime.TabIndex = 25;
            // 
            // lblEntryTime
            // 
            this.lblEntryTime.AutoSize = true;
            this.lblEntryTime.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntryTime.Location = new System.Drawing.Point(344, 10);
            this.lblEntryTime.Name = "lblEntryTime";
            this.lblEntryTime.Size = new System.Drawing.Size(84, 16);
            this.lblEntryTime.TabIndex = 25;
            this.lblEntryTime.Text = "Entry Time :";
            // 
            // lblExitTime
            // 
            this.lblExitTime.AutoSize = true;
            this.lblExitTime.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExitTime.Location = new System.Drawing.Point(344, 35);
            this.lblExitTime.Name = "lblExitTime";
            this.lblExitTime.Size = new System.Drawing.Size(76, 16);
            this.lblExitTime.TabIndex = 27;
            this.lblExitTime.Text = "Exit Time :";
            // 
            // txtExitTime
            // 
            this.txtExitTime.BackColor = System.Drawing.Color.Black;
            this.txtExitTime.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExitTime.ForeColor = System.Drawing.Color.Lime;
            this.txtExitTime.Location = new System.Drawing.Point(442, 32);
            this.txtExitTime.Name = "txtExitTime";
            this.txtExitTime.ReadOnly = true;
            this.txtExitTime.Size = new System.Drawing.Size(231, 22);
            this.txtExitTime.TabIndex = 26;
            // 
            // visitorTimer
            // 
            this.visitorTimer.Interval = 1000;
            this.visitorTimer.Tick += new System.EventHandler(this.visitorTimer_Tick);
            // 
            // txtQuarterNumber
            // 
            this.txtQuarterNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtQuarterNumber.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuarterNumber.Location = new System.Drawing.Point(467, 318);
            this.txtQuarterNumber.Name = "txtQuarterNumber";
            this.txtQuarterNumber.Size = new System.Drawing.Size(206, 21);
            this.txtQuarterNumber.TabIndex = 18;
            this.txtQuarterNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuarterNumber_KeyPress);
            this.txtQuarterNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtQuarterNumber_Validating);
            // 
            // cmbQuarterType
            // 
            this.cmbQuarterType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbQuarterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuarterType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbQuarterType.FormattingEnabled = true;
            this.cmbQuarterType.Location = new System.Drawing.Point(448, 289);
            this.cmbQuarterType.Name = "cmbQuarterType";
            this.cmbQuarterType.Size = new System.Drawing.Size(225, 21);
            this.cmbQuarterType.TabIndex = 17;
            this.cmbQuarterType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbQuarterType_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(344, 320);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 16);
            this.label10.TabIndex = 125;
            this.label10.Text = "Quarter Number :";
            // 
            // cmbUnit
            // 
            this.cmbUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Location = new System.Drawing.Point(391, 259);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(282, 21);
            this.cmbUnit.TabIndex = 16;
            // 
            // cmbRank
            // 
            this.cmbRank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbRank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRank.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbRank.FormattingEnabled = true;
            this.cmbRank.Location = new System.Drawing.Point(398, 231);
            this.cmbRank.Name = "cmbRank";
            this.cmbRank.Size = new System.Drawing.Size(275, 21);
            this.cmbRank.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(344, 291);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 16);
            this.label9.TabIndex = 124;
            this.label9.Text = "Quarter Type :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(344, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 123;
            this.label7.Text = "Rank :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(344, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 122;
            this.label6.Text = "Unit :";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtEmployeeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmployeeName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeName.Location = new System.Drawing.Point(466, 175);
            this.txtEmployeeName.MaxLength = 100;
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(207, 23);
            this.txtEmployeeName.TabIndex = 13;
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtEmployeeID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmployeeID.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeID.Location = new System.Drawing.Point(442, 147);
            this.txtEmployeeID.MaxLength = 16;
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(231, 23);
            this.txtEmployeeID.TabIndex = 12;
            this.txtEmployeeID.Leave += new System.EventHandler(this.txtEmployeeID_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(344, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 120;
            this.label4.Text = "Employee Name :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(344, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 121;
            this.label5.Text = "Employee ID :";
            // 
            // txtPurpose
            // 
            this.txtPurpose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPurpose.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurpose.Location = new System.Drawing.Point(418, 86);
            this.txtPurpose.Multiline = true;
            this.txtPurpose.Name = "txtPurpose";
            this.txtPurpose.Size = new System.Drawing.Size(255, 54);
            this.txtPurpose.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(344, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 16);
            this.label8.TabIndex = 127;
            this.label8.Text = "Purpose :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 16);
            this.label11.TabIndex = 130;
            this.label11.Text = "Gender:";
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtMobileNo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobileNo.Location = new System.Drawing.Point(122, 32);
            this.txtMobileNo.MaxLength = 10;
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Size = new System.Drawing.Size(211, 21);
            this.txtMobileNo.TabIndex = 1;
            this.txtMobileNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMobileNo_KeyPress);
            this.txtMobileNo.Leave += new System.EventHandler(this.txtMobileNo_Leave);
            this.txtMobileNo.Validating += new System.ComponentModel.CancelEventHandler(this.txtMobileNo_Validating);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 16);
            this.label12.TabIndex = 132;
            this.label12.Text = "Mobile Number :";
            // 
            // cmbGender
            // 
            this.cmbGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbGender.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.cmbGender.Location = new System.Drawing.Point(95, 117);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(238, 23);
            this.cmbGender.TabIndex = 4;
            // 
            // txtVisitedPersonMobile
            // 
            this.txtVisitedPersonMobile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtVisitedPersonMobile.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVisitedPersonMobile.Location = new System.Drawing.Point(466, 204);
            this.txtVisitedPersonMobile.MaxLength = 10;
            this.txtVisitedPersonMobile.Name = "txtVisitedPersonMobile";
            this.txtVisitedPersonMobile.Size = new System.Drawing.Size(207, 21);
            this.txtVisitedPersonMobile.TabIndex = 14;
            this.txtVisitedPersonMobile.Validating += new System.ComponentModel.CancelEventHandler(this.txtVisitedPersonMobile_Validating);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(344, 206);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 16);
            this.label13.TabIndex = 135;
            this.label13.Text = "Mobile Number :";
            // 
            // dteValidTill
            // 
            this.dteValidTill.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dteValidTill.CustomFormat = "dd-MMM-yyyy  hh:mm tt";
            this.dteValidTill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteValidTill.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dteValidTill.Location = new System.Drawing.Point(467, 343);
            this.dteValidTill.Name = "dteValidTill";
            this.dteValidTill.Size = new System.Drawing.Size(206, 22);
            this.dteValidTill.TabIndex = 19;
            this.dteValidTill.Value = new System.DateTime(2018, 10, 7, 0, 0, 0, 0);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(344, 346);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 16);
            this.label14.TabIndex = 137;
            this.label14.Text = "Valid Till :";
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmBlackList});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(124, 26);
            // 
            // tsmBlackList
            // 
            this.tsmBlackList.Name = "tsmBlackList";
            this.tsmBlackList.Size = new System.Drawing.Size(123, 22);
            this.tsmBlackList.Text = "Black List";
            this.tsmBlackList.Click += new System.EventHandler(this.tsmBlackList_Click);
            // 
            // frmVisitor
            // 
            this.AcceptButton = this.btnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(891, 504);
            this.ContextMenuStrip = this.contextMenuStrip;
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dteValidTill);
            this.Controls.Add(this.txtVisitedPersonMobile);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.txtMobileNo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtPurpose);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtQuarterNumber);
            this.Controls.Add(this.cmbQuarterType);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbUnit);
            this.Controls.Add(this.cmbRank);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblExitTime);
            this.Controls.Add(this.txtExitTime);
            this.Controls.Add(this.lblEntryTime);
            this.Controls.Add(this.txtEntryTime);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtVehicleNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbState);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCoVisitors);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.cmbIdentityType);
            this.Controls.Add(this.txtVisitorAddress);
            this.Controls.Add(this.lblVisitorAddress);
            this.Controls.Add(this.txtIdentityNumber);
            this.Controls.Add(this.lblIdentityNumber);
            this.Controls.Add(this.lblIdentityType);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.txtVisitorNumber);
            this.Controls.Add(this.lblVisitorNumber);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmVisitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visitor Detail";
            this.Activated += new System.EventHandler(this.frmVisitor_Activated);
            this.Load += new System.EventHandler(this.frmVisitor_Load);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picVisitorPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoVisitors)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVisitorNumber;
        private System.Windows.Forms.TextBox txtVisitorNumber;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.PictureBox picVisitorPhoto;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblIdentityType;
        private System.Windows.Forms.TextBox txtIdentityNumber;
        private System.Windows.Forms.Label lblIdentityNumber;
        private System.Windows.Forms.TextBox txtVisitorAddress;
        private System.Windows.Forms.Label lblVisitorAddress;
        private System.Windows.Forms.ComboBox cmbIdentityType;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.DataGridView dgvCoVisitors;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVehicleNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtEntryTime;
        private System.Windows.Forms.Label lblEntryTime;
        private System.Windows.Forms.Label lblExitTime;
        private System.Windows.Forms.TextBox txtExitTime;
        private System.Windows.Forms.Timer visitorTimer;
        private System.Windows.Forms.TextBox txtQuarterNumber;
        private System.Windows.Forms.ComboBox cmbQuarterType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.ComboBox cmbRank;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPurpose;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMobileNo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoVisitorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoVisitorName;
        private System.Windows.Forms.DataGridViewComboBoxColumn Gender;
        private System.Windows.Forms.DataGridViewComboBoxColumn IdentityType;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdentityNumber;
        private System.Windows.Forms.DataGridViewComboBoxColumn Relationship;
        private System.Windows.Forms.TextBox txtVisitedPersonMobile;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dteValidTill;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmBlackList;
    }
}