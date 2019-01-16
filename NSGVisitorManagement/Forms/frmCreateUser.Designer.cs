namespace NSGVisitorManagement
{
    partial class frmCreateUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateUser));
            this.grpboxEntry = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.chkEmpActive = new System.Windows.Forms.CheckBox();
            this.chkCreateLogin = new System.Windows.Forms.CheckBox();
            this.grpBoxLoginDetails = new System.Windows.Forms.GroupBox();
            this.chkUserActive = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtReTypePassword = new System.Windows.Forms.TextBox();
            this.txtQuarterNumber = new System.Windows.Forms.TextBox();
            this.cmbQuarterType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.cmbRank = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.picLogoCreateUser = new System.Windows.Forms.PictureBox();
            this.errEmployeeId = new System.Windows.Forms.ErrorProvider(this.components);
            this.errFirstName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errLastName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errRank = new System.Windows.Forms.ErrorProvider(this.components);
            this.errUnit = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.grpboxEntry.SuspendLayout();
            this.grpBoxLoginDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoCreateUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errEmployeeId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errRank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errUnit)).BeginInit();
            this.SuspendLayout();
            // 
            // grpboxEntry
            // 
            this.grpboxEntry.Controls.Add(this.label11);
            this.grpboxEntry.Controls.Add(this.radMale);
            this.grpboxEntry.Controls.Add(this.radFemale);
            this.grpboxEntry.Controls.Add(this.chkEmpActive);
            this.grpboxEntry.Controls.Add(this.chkCreateLogin);
            this.grpboxEntry.Controls.Add(this.grpBoxLoginDetails);
            this.grpboxEntry.Controls.Add(this.txtQuarterNumber);
            this.grpboxEntry.Controls.Add(this.cmbQuarterType);
            this.grpboxEntry.Controls.Add(this.label10);
            this.grpboxEntry.Controls.Add(this.cmbUnit);
            this.grpboxEntry.Controls.Add(this.cmbRank);
            this.grpboxEntry.Controls.Add(this.label9);
            this.grpboxEntry.Controls.Add(this.txtLastName);
            this.grpboxEntry.Controls.Add(this.label8);
            this.grpboxEntry.Controls.Add(this.label7);
            this.grpboxEntry.Controls.Add(this.label6);
            this.grpboxEntry.Controls.Add(this.txtFirstName);
            this.grpboxEntry.Controls.Add(this.txtEmployeeID);
            this.grpboxEntry.Controls.Add(this.label4);
            this.grpboxEntry.Controls.Add(this.label3);
            this.grpboxEntry.Location = new System.Drawing.Point(6, 98);
            this.grpboxEntry.Name = "grpboxEntry";
            this.grpboxEntry.Size = new System.Drawing.Size(340, 424);
            this.grpboxEntry.TabIndex = 0;
            this.grpboxEntry.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(5, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 15);
            this.label11.TabIndex = 119;
            this.label11.Text = "Gender:";
            // 
            // radMale
            // 
            this.radMale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.radMale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radMale.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMale.Location = new System.Drawing.Point(125, 103);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(61, 24);
            this.radMale.TabIndex = 3;
            this.radMale.TabStop = true;
            this.radMale.Text = "Male";
            this.radMale.UseVisualStyleBackColor = false;
            // 
            // radFemale
            // 
            this.radFemale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.radFemale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radFemale.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFemale.Location = new System.Drawing.Point(190, 103);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(72, 24);
            this.radFemale.TabIndex = 4;
            this.radFemale.TabStop = true;
            this.radFemale.Text = "Female";
            this.radFemale.UseVisualStyleBackColor = false;
            // 
            // chkEmpActive
            // 
            this.chkEmpActive.AutoSize = true;
            this.chkEmpActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.chkEmpActive.Checked = true;
            this.chkEmpActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEmpActive.Location = new System.Drawing.Point(125, 262);
            this.chkEmpActive.Name = "chkEmpActive";
            this.chkEmpActive.Size = new System.Drawing.Size(120, 17);
            this.chkEmpActive.TabIndex = 10;
            this.chkEmpActive.Text = "Active Employee";
            this.chkEmpActive.UseVisualStyleBackColor = false;
            // 
            // chkCreateLogin
            // 
            this.chkCreateLogin.AutoSize = true;
            this.chkCreateLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.chkCreateLogin.Checked = true;
            this.chkCreateLogin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCreateLogin.Location = new System.Drawing.Point(8, 262);
            this.chkCreateLogin.Name = "chkCreateLogin";
            this.chkCreateLogin.Size = new System.Drawing.Size(98, 17);
            this.chkCreateLogin.TabIndex = 9;
            this.chkCreateLogin.Text = "Create Login";
            this.chkCreateLogin.UseVisualStyleBackColor = false;
            this.chkCreateLogin.CheckedChanged += new System.EventHandler(this.chkCreateLogin_CheckedChanged);
            // 
            // grpBoxLoginDetails
            // 
            this.grpBoxLoginDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxLoginDetails.Controls.Add(this.chkUserActive);
            this.grpBoxLoginDetails.Controls.Add(this.label1);
            this.grpBoxLoginDetails.Controls.Add(this.label2);
            this.grpBoxLoginDetails.Controls.Add(this.label5);
            this.grpBoxLoginDetails.Controls.Add(this.txtUserName);
            this.grpBoxLoginDetails.Controls.Add(this.txtPassword);
            this.grpBoxLoginDetails.Controls.Add(this.txtReTypePassword);
            this.grpBoxLoginDetails.Location = new System.Drawing.Point(8, 283);
            this.grpBoxLoginDetails.Name = "grpBoxLoginDetails";
            this.grpBoxLoginDetails.Size = new System.Drawing.Size(323, 132);
            this.grpBoxLoginDetails.TabIndex = 11;
            this.grpBoxLoginDetails.TabStop = false;
            this.grpBoxLoginDetails.Text = "Login Details (Optional)";
            // 
            // chkUserActive
            // 
            this.chkUserActive.AutoSize = true;
            this.chkUserActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.chkUserActive.Checked = true;
            this.chkUserActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUserActive.Location = new System.Drawing.Point(117, 106);
            this.chkUserActive.Name = "chkUserActive";
            this.chkUserActive.Size = new System.Drawing.Size(92, 17);
            this.chkUserActive.TabIndex = 15;
            this.chkUserActive.Text = "Active User";
            this.chkUserActive.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 103;
            this.label1.Text = "User Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Re-Type Password:";
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(117, 19);
            this.txtUserName.MaxLength = 20;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(191, 23);
            this.txtUserName.TabIndex = 12;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(117, 48);
            this.txtPassword.MaxLength = 20;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(191, 23);
            this.txtPassword.TabIndex = 13;
            // 
            // txtReTypePassword
            // 
            this.txtReTypePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtReTypePassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReTypePassword.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReTypePassword.Location = new System.Drawing.Point(117, 77);
            this.txtReTypePassword.MaxLength = 20;
            this.txtReTypePassword.Name = "txtReTypePassword";
            this.txtReTypePassword.PasswordChar = '*';
            this.txtReTypePassword.Size = new System.Drawing.Size(191, 23);
            this.txtReTypePassword.TabIndex = 14;
            // 
            // txtQuarterNumber
            // 
            this.txtQuarterNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtQuarterNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuarterNumber.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuarterNumber.Location = new System.Drawing.Point(125, 229);
            this.txtQuarterNumber.MaxLength = 4;
            this.txtQuarterNumber.Name = "txtQuarterNumber";
            this.txtQuarterNumber.Size = new System.Drawing.Size(191, 23);
            this.txtQuarterNumber.TabIndex = 8;
            this.txtQuarterNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuarterNumber_KeyPress);
            this.txtQuarterNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtQuarterNumber_Validating);
            // 
            // cmbQuarterType
            // 
            this.cmbQuarterType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbQuarterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuarterType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbQuarterType.FormattingEnabled = true;
            this.cmbQuarterType.Location = new System.Drawing.Point(125, 198);
            this.cmbQuarterType.Name = "cmbQuarterType";
            this.cmbQuarterType.Size = new System.Drawing.Size(191, 21);
            this.cmbQuarterType.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(5, 231);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 15);
            this.label10.TabIndex = 113;
            this.label10.Text = "Quarter Number:";
            // 
            // cmbUnit
            // 
            this.cmbUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Location = new System.Drawing.Point(125, 166);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(191, 21);
            this.cmbUnit.TabIndex = 6;
            // 
            // cmbRank
            // 
            this.cmbRank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbRank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRank.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbRank.FormattingEnabled = true;
            this.cmbRank.Location = new System.Drawing.Point(125, 135);
            this.cmbRank.Name = "cmbRank";
            this.cmbRank.Size = new System.Drawing.Size(191, 21);
            this.cmbRank.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(5, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 15);
            this.label9.TabIndex = 110;
            this.label9.Text = "Quarter Type:";
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(125, 74);
            this.txtLastName.MaxLength = 100;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(191, 23);
            this.txtLastName.TabIndex = 2;
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastName_KeyPress);
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtLastName_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 15);
            this.label8.TabIndex = 109;
            this.label8.Text = "Last Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 107;
            this.label7.Text = "Rank:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 15);
            this.label6.TabIndex = 105;
            this.label6.Text = "Unit:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(125, 45);
            this.txtFirstName.MaxLength = 100;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(191, 23);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstName_KeyPress);
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtFirstName_Validating);
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtEmployeeID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmployeeID.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeID.Location = new System.Drawing.Point(125, 16);
            this.txtEmployeeID.MaxLength = 16;
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(191, 23);
            this.txtEmployeeID.TabIndex = 0;
            this.txtEmployeeID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmployeeID_KeyPress);
            this.txtEmployeeID.Leave += new System.EventHandler(this.txtEmployeeID_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 100;
            this.label4.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 101;
            this.label3.Text = "Employee ID:";
            // 
            // picLogoCreateUser
            // 
            this.picLogoCreateUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picLogoCreateUser.BackColor = System.Drawing.SystemColors.HighlightText;
            this.picLogoCreateUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLogoCreateUser.Image = ((System.Drawing.Image)(resources.GetObject("picLogoCreateUser.Image")));
            this.picLogoCreateUser.Location = new System.Drawing.Point(6, 9);
            this.picLogoCreateUser.Name = "picLogoCreateUser";
            this.picLogoCreateUser.Size = new System.Drawing.Size(340, 83);
            this.picLogoCreateUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogoCreateUser.TabIndex = 1;
            this.picLogoCreateUser.TabStop = false;
            // 
            // errEmployeeId
            // 
            this.errEmployeeId.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errEmployeeId.ContainerControl = this;
            this.errEmployeeId.Icon = ((System.Drawing.Icon)(resources.GetObject("errEmployeeId.Icon")));
            // 
            // errFirstName
            // 
            this.errFirstName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errFirstName.ContainerControl = this;
            this.errFirstName.Icon = ((System.Drawing.Icon)(resources.GetObject("errFirstName.Icon")));
            // 
            // errLastName
            // 
            this.errLastName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errLastName.ContainerControl = this;
            this.errLastName.Icon = ((System.Drawing.Icon)(resources.GetObject("errLastName.Icon")));
            // 
            // errRank
            // 
            this.errRank.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errRank.ContainerControl = this;
            this.errRank.Icon = ((System.Drawing.Icon)(resources.GetObject("errRank.Icon")));
            // 
            // errUnit
            // 
            this.errUnit.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errUnit.ContainerControl = this;
            this.errUnit.Icon = ((System.Drawing.Icon)(resources.GetObject("errUnit.Icon")));
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(259, 531);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 25);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Ca&ncel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(155, 531);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(87, 25);
            this.btnCreate.TabIndex = 16;
            this.btnCreate.Text = "&Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // frmCreateUser
            // 
            this.AcceptButton = this.btnCreate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(353, 565);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.picLogoCreateUser);
            this.Controls.Add(this.grpboxEntry);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmCreateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create User";
            this.Load += new System.EventHandler(this.frmCreateUser_Load);
            this.grpboxEntry.ResumeLayout(false);
            this.grpboxEntry.PerformLayout();
            this.grpBoxLoginDetails.ResumeLayout(false);
            this.grpBoxLoginDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoCreateUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errEmployeeId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errRank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errUnit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpboxEntry;
        private System.Windows.Forms.PictureBox picLogoCreateUser;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errEmployeeId;
        private System.Windows.Forms.ErrorProvider errFirstName;
        private System.Windows.Forms.ErrorProvider errLastName;
        private System.Windows.Forms.ErrorProvider errRank;
        private System.Windows.Forms.ErrorProvider errUnit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpBoxLoginDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtReTypePassword;
        private System.Windows.Forms.TextBox txtQuarterNumber;
        private System.Windows.Forms.ComboBox cmbQuarterType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.ComboBox cmbRank;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.CheckBox chkCreateLogin;
        private System.Windows.Forms.CheckBox chkEmpActive;
        private System.Windows.Forms.CheckBox chkUserActive;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.RadioButton radFemale;
    }
}

