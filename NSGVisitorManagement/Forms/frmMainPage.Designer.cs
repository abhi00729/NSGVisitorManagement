namespace NSGVisitorManagement
{
    partial class frmMainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainPage));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVisitorBook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVisitorBookVisitorIn = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVisitorBookVisitorOut = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVisitorBookVisitorSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMasters = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMastersStates = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMastersCities = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMastersUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMastersIdentityTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMastersRelationships = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMastersRanks = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMastersUnits = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMastersQuarterTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuVisitorBook,
            this.mnuMasters,
            this.mnuHelp});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1115, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.mnuFileChangePassword,
            this.toolStripSeparator5,
            this.mnuFileExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "&File";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(165, 6);
            // 
            // mnuFileChangePassword
            // 
            this.mnuFileChangePassword.Name = "mnuFileChangePassword";
            this.mnuFileChangePassword.Size = new System.Drawing.Size(168, 22);
            this.mnuFileChangePassword.Text = "C&hange Password";
            this.mnuFileChangePassword.Click += new System.EventHandler(this.mnuFileChangePassword_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(165, 6);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(168, 22);
            this.mnuFileExit.Text = "E&xit";
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
            // 
            // mnuVisitorBook
            // 
            this.mnuVisitorBook.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuVisitorBookVisitorIn,
            this.mnuVisitorBookVisitorOut,
            this.mnuVisitorBookVisitorSearch});
            this.mnuVisitorBook.Name = "mnuVisitorBook";
            this.mnuVisitorBook.Size = new System.Drawing.Size(87, 20);
            this.mnuVisitorBook.Text = "&Visitors Book";
            // 
            // mnuVisitorBookVisitorIn
            // 
            this.mnuVisitorBookVisitorIn.Name = "mnuVisitorBookVisitorIn";
            this.mnuVisitorBookVisitorIn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.mnuVisitorBookVisitorIn.Size = new System.Drawing.Size(190, 22);
            this.mnuVisitorBookVisitorIn.Text = "Visitor &In";
            this.mnuVisitorBookVisitorIn.Click += new System.EventHandler(this.mnuVisitorBookVisitorIn_Click);
            // 
            // mnuVisitorBookVisitorOut
            // 
            this.mnuVisitorBookVisitorOut.Name = "mnuVisitorBookVisitorOut";
            this.mnuVisitorBookVisitorOut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuVisitorBookVisitorOut.Size = new System.Drawing.Size(190, 22);
            this.mnuVisitorBookVisitorOut.Text = "Visitor &Out";
            this.mnuVisitorBookVisitorOut.Click += new System.EventHandler(this.mnuVisitorBookVisitorOut_Click);
            // 
            // mnuVisitorBookVisitorSearch
            // 
            this.mnuVisitorBookVisitorSearch.Name = "mnuVisitorBookVisitorSearch";
            this.mnuVisitorBookVisitorSearch.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuVisitorBookVisitorSearch.Size = new System.Drawing.Size(190, 22);
            this.mnuVisitorBookVisitorSearch.Text = "&Search Visitors";
            this.mnuVisitorBookVisitorSearch.Click += new System.EventHandler(this.mnuVisitorBookVisitorSearch_Click);
            // 
            // mnuMasters
            // 
            this.mnuMasters.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMastersStates,
            this.mnuMastersCities,
            this.mnuMastersUsers,
            this.mnuMastersIdentityTypes,
            this.mnuMastersRelationships,
            this.mnuMastersRanks,
            this.mnuMastersUnits,
            this.mnuMastersQuarterTypes});
            this.mnuMasters.Name = "mnuMasters";
            this.mnuMasters.Size = new System.Drawing.Size(60, 20);
            this.mnuMasters.Text = "&Masters";
            // 
            // mnuMastersStates
            // 
            this.mnuMastersStates.Name = "mnuMastersStates";
            this.mnuMastersStates.Size = new System.Drawing.Size(152, 22);
            this.mnuMastersStates.Text = "&States";
            this.mnuMastersStates.Click += new System.EventHandler(this.mnuMastersStates_Click);
            // 
            // mnuMastersCities
            // 
            this.mnuMastersCities.Name = "mnuMastersCities";
            this.mnuMastersCities.Size = new System.Drawing.Size(152, 22);
            this.mnuMastersCities.Text = "&Cities";
            this.mnuMastersCities.Click += new System.EventHandler(this.mnuMastersCities_Click);
            // 
            // mnuMastersUsers
            // 
            this.mnuMastersUsers.Name = "mnuMastersUsers";
            this.mnuMastersUsers.Size = new System.Drawing.Size(152, 22);
            this.mnuMastersUsers.Text = "&Users";
            this.mnuMastersUsers.Click += new System.EventHandler(this.mnuMastersUsers_Click);
            // 
            // mnuMastersIdentityTypes
            // 
            this.mnuMastersIdentityTypes.Name = "mnuMastersIdentityTypes";
            this.mnuMastersIdentityTypes.Size = new System.Drawing.Size(152, 22);
            this.mnuMastersIdentityTypes.Text = "&Identity Types";
            this.mnuMastersIdentityTypes.Click += new System.EventHandler(this.mnuMastersIdentityTypes_Click);
            // 
            // mnuMastersRelationships
            // 
            this.mnuMastersRelationships.Name = "mnuMastersRelationships";
            this.mnuMastersRelationships.Size = new System.Drawing.Size(152, 22);
            this.mnuMastersRelationships.Text = "&Relationships";
            this.mnuMastersRelationships.Click += new System.EventHandler(this.mnuMastersRelationships_Click);
            // 
            // mnuMastersRanks
            // 
            this.mnuMastersRanks.Name = "mnuMastersRanks";
            this.mnuMastersRanks.Size = new System.Drawing.Size(152, 22);
            this.mnuMastersRanks.Text = "Ra&nks";
            this.mnuMastersRanks.Click += new System.EventHandler(this.mnuMastersRanks_Click);
            // 
            // mnuMastersUnits
            // 
            this.mnuMastersUnits.Name = "mnuMastersUnits";
            this.mnuMastersUnits.Size = new System.Drawing.Size(152, 22);
            this.mnuMastersUnits.Text = "Uni&ts";
            this.mnuMastersUnits.Click += new System.EventHandler(this.mnuMastersUnits_Click);
            // 
            // mnuMastersQuarterTypes
            // 
            this.mnuMastersQuarterTypes.Name = "mnuMastersQuarterTypes";
            this.mnuMastersQuarterTypes.Size = new System.Drawing.Size(152, 22);
            this.mnuMastersQuarterTypes.Text = "&Quarter Types";
            this.mnuMastersQuarterTypes.Click += new System.EventHandler(this.mnuMastersQuarterTypes_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelpAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuHelp.Text = "&Help";
            // 
            // mnuHelpAbout
            // 
            this.mnuHelpAbout.Name = "mnuHelpAbout";
            this.mnuHelpAbout.Size = new System.Drawing.Size(116, 22);
            this.mnuHelpAbout.Text = "&About...";
            this.mnuHelpAbout.Click += new System.EventHandler(this.mnuHelpAbout_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.statusStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 501);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip.Size = new System.Drawing.Size(1115, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // frmMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::NSGVisitorManagement.Properties.Resources.NSGLogo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1115, 523);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMainPage";
            this.Text = "NSG Visitor Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMainPage_FormClosing);
            this.Load += new System.EventHandler(this.frmMainPage_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem mnuVisitorBook;
        private System.Windows.Forms.ToolStripMenuItem mnuVisitorBookVisitorIn;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuFileChangePassword;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem mnuVisitorBookVisitorOut;
        private System.Windows.Forms.ToolStripMenuItem mnuMasters;
        private System.Windows.Forms.ToolStripMenuItem mnuMastersStates;
        private System.Windows.Forms.ToolStripMenuItem mnuMastersCities;
        private System.Windows.Forms.ToolStripMenuItem mnuMastersUsers;
        private System.Windows.Forms.ToolStripMenuItem mnuMastersIdentityTypes;
        private System.Windows.Forms.ToolStripMenuItem mnuMastersRelationships;
        private System.Windows.Forms.ToolStripMenuItem mnuMastersRanks;
        private System.Windows.Forms.ToolStripMenuItem mnuMastersUnits;
        private System.Windows.Forms.ToolStripMenuItem mnuMastersQuarterTypes;
        private System.Windows.Forms.ToolStripMenuItem mnuVisitorBookVisitorSearch;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuHelpAbout;
    }
}



