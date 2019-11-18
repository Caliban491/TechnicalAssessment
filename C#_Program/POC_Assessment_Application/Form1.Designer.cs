namespace POC_Assessment_Application
{
    partial class Form1
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDOB = new System.Windows.Forms.Button();
            this.btnRank = new System.Windows.Forms.Button();
            this.treeViewEmployees = new System.Windows.Forms.TreeView();
            this.managerListBox = new System.Windows.Forms.ListBox();
            this.rankingTable = new System.Windows.Forms.Panel();
            this.employeeListBox = new System.Windows.Forms.ListBox();
            this.traineeListBox = new System.Windows.Forms.ListBox();
            this.highestListBox = new System.Windows.Forms.ListBox();
            this.statsListBox = new System.Windows.Forms.ListBox();
            this.treeViewStats = new System.Windows.Forms.TreeView();
            this.expCS = new System.Windows.Forms.Button();
            this.collCS = new System.Windows.Forms.Button();
            this.dobInterface = new System.Windows.Forms.Panel();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbtnBefore = new System.Windows.Forms.RadioButton();
            this.rbtnAfter = new System.Windows.Forms.RadioButton();
            this.btnGetList = new System.Windows.Forms.Button();
            this.resultListBox = new System.Windows.Forms.ListBox();
            this.pnlSearching = new System.Windows.Forms.Panel();
            this.resultsBox = new System.Windows.Forms.ListBox();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbtnName = new System.Windows.Forms.RadioButton();
            this.rbtnEmpNum = new System.Windows.Forms.RadioButton();
            this.tbNameSurname = new System.Windows.Forms.TextBox();
            this.nudEmpNo = new System.Windows.Forms.NumericUpDown();
            this.pnlHome = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pnlMenu.SuspendLayout();
            this.rankingTable.SuspendLayout();
            this.dobInterface.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlSearching.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEmpNo)).BeginInit();
            this.pnlHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlMenu.Controls.Add(this.btnRank);
            this.pnlMenu.Controls.Add(this.btnDOB);
            this.pnlMenu.Controls.Add(this.btnSearch);
            this.pnlMenu.Controls.Add(this.btnDisplay);
            this.pnlMenu.Location = new System.Drawing.Point(44, 62);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(181, 304);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Enabled = false;
            this.btnDisplay.Location = new System.Drawing.Point(22, 21);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(139, 40);
            this.btnDisplay.TabIndex = 0;
            this.btnDisplay.Text = "Display Tree Structure";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.BtnDisplay_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Enabled = false;
            this.btnSearch.Location = new System.Drawing.Point(22, 92);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(139, 40);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Searching Facility";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // btnDOB
            // 
            this.btnDOB.Enabled = false;
            this.btnDOB.Location = new System.Drawing.Point(22, 166);
            this.btnDOB.Name = "btnDOB";
            this.btnDOB.Size = new System.Drawing.Size(139, 40);
            this.btnDOB.TabIndex = 2;
            this.btnDOB.Text = "Identify via Date of Birth";
            this.btnDOB.UseVisualStyleBackColor = true;
            this.btnDOB.Click += new System.EventHandler(this.BtnDOB_Click);
            // 
            // btnRank
            // 
            this.btnRank.Enabled = false;
            this.btnRank.Location = new System.Drawing.Point(22, 239);
            this.btnRank.Name = "btnRank";
            this.btnRank.Size = new System.Drawing.Size(139, 40);
            this.btnRank.TabIndex = 3;
            this.btnRank.Text = "Rank Earnings";
            this.btnRank.UseVisualStyleBackColor = true;
            this.btnRank.Click += new System.EventHandler(this.BtnRank_Click);
            // 
            // treeViewEmployees
            // 
            this.treeViewEmployees.Location = new System.Drawing.Point(265, 37);
            this.treeViewEmployees.Name = "treeViewEmployees";
            this.treeViewEmployees.Size = new System.Drawing.Size(371, 358);
            this.treeViewEmployees.TabIndex = 2;
            this.treeViewEmployees.Visible = false;
            // 
            // managerListBox
            // 
            this.managerListBox.FormattingEnabled = true;
            this.managerListBox.Location = new System.Drawing.Point(15, 15);
            this.managerListBox.Name = "managerListBox";
            this.managerListBox.Size = new System.Drawing.Size(157, 264);
            this.managerListBox.TabIndex = 0;
            // 
            // rankingTable
            // 
            this.rankingTable.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.rankingTable.Controls.Add(this.statsListBox);
            this.rankingTable.Controls.Add(this.highestListBox);
            this.rankingTable.Controls.Add(this.traineeListBox);
            this.rankingTable.Controls.Add(this.employeeListBox);
            this.rankingTable.Controls.Add(this.managerListBox);
            this.rankingTable.Location = new System.Drawing.Point(292, 12);
            this.rankingTable.Name = "rankingTable";
            this.rankingTable.Size = new System.Drawing.Size(532, 436);
            this.rankingTable.TabIndex = 3;
            this.rankingTable.Visible = false;
            // 
            // employeeListBox
            // 
            this.employeeListBox.FormattingEnabled = true;
            this.employeeListBox.Location = new System.Drawing.Point(179, 15);
            this.employeeListBox.Name = "employeeListBox";
            this.employeeListBox.Size = new System.Drawing.Size(163, 264);
            this.employeeListBox.TabIndex = 1;
            // 
            // traineeListBox
            // 
            this.traineeListBox.FormattingEnabled = true;
            this.traineeListBox.Location = new System.Drawing.Point(349, 15);
            this.traineeListBox.Name = "traineeListBox";
            this.traineeListBox.Size = new System.Drawing.Size(167, 264);
            this.traineeListBox.TabIndex = 2;
            // 
            // highestListBox
            // 
            this.highestListBox.FormattingEnabled = true;
            this.highestListBox.Location = new System.Drawing.Point(15, 303);
            this.highestListBox.Name = "highestListBox";
            this.highestListBox.Size = new System.Drawing.Size(241, 108);
            this.highestListBox.TabIndex = 3;
            // 
            // statsListBox
            // 
            this.statsListBox.FormattingEnabled = true;
            this.statsListBox.Location = new System.Drawing.Point(274, 303);
            this.statsListBox.Name = "statsListBox";
            this.statsListBox.Size = new System.Drawing.Size(242, 108);
            this.statsListBox.TabIndex = 4;
            // 
            // treeViewStats
            // 
            this.treeViewStats.Location = new System.Drawing.Point(644, 37);
            this.treeViewStats.Name = "treeViewStats";
            this.treeViewStats.Size = new System.Drawing.Size(184, 241);
            this.treeViewStats.TabIndex = 4;
            this.treeViewStats.Visible = false;
            // 
            // expCS
            // 
            this.expCS.Location = new System.Drawing.Point(644, 301);
            this.expCS.Name = "expCS";
            this.expCS.Size = new System.Drawing.Size(182, 23);
            this.expCS.TabIndex = 5;
            this.expCS.Text = "Expand Corporate Structure";
            this.expCS.UseVisualStyleBackColor = true;
            this.expCS.Visible = false;
            this.expCS.Click += new System.EventHandler(this.ExpCS_Click);
            // 
            // collCS
            // 
            this.collCS.Location = new System.Drawing.Point(642, 330);
            this.collCS.Name = "collCS";
            this.collCS.Size = new System.Drawing.Size(182, 23);
            this.collCS.TabIndex = 6;
            this.collCS.Text = "Collapse Corporate Structure";
            this.collCS.UseVisualStyleBackColor = true;
            this.collCS.Visible = false;
            this.collCS.Click += new System.EventHandler(this.CollCS_Click);
            // 
            // dobInterface
            // 
            this.dobInterface.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.dobInterface.Controls.Add(this.resultListBox);
            this.dobInterface.Controls.Add(this.btnGetList);
            this.dobInterface.Controls.Add(this.panel2);
            this.dobInterface.Controls.Add(this.datePicker);
            this.dobInterface.Location = new System.Drawing.Point(292, 12);
            this.dobInterface.Name = "dobInterface";
            this.dobInterface.Size = new System.Drawing.Size(532, 436);
            this.dobInterface.TabIndex = 7;
            this.dobInterface.Visible = false;
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(15, 15);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 20);
            this.datePicker.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.rbtnAfter);
            this.panel2.Controls.Add(this.rbtnBefore);
            this.panel2.Location = new System.Drawing.Point(15, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 37);
            this.panel2.TabIndex = 1;
            // 
            // rbtnBefore
            // 
            this.rbtnBefore.AutoSize = true;
            this.rbtnBefore.Checked = true;
            this.rbtnBefore.Location = new System.Drawing.Point(29, 8);
            this.rbtnBefore.Name = "rbtnBefore";
            this.rbtnBefore.Size = new System.Drawing.Size(56, 17);
            this.rbtnBefore.TabIndex = 0;
            this.rbtnBefore.TabStop = true;
            this.rbtnBefore.Text = "Before";
            this.rbtnBefore.UseVisualStyleBackColor = true;
            // 
            // rbtnAfter
            // 
            this.rbtnAfter.AutoSize = true;
            this.rbtnAfter.Location = new System.Drawing.Point(126, 8);
            this.rbtnAfter.Name = "rbtnAfter";
            this.rbtnAfter.Size = new System.Drawing.Size(47, 17);
            this.rbtnAfter.TabIndex = 1;
            this.rbtnAfter.Text = "After";
            this.rbtnAfter.UseVisualStyleBackColor = true;
            // 
            // btnGetList
            // 
            this.btnGetList.Location = new System.Drawing.Point(15, 86);
            this.btnGetList.Name = "btnGetList";
            this.btnGetList.Size = new System.Drawing.Size(200, 56);
            this.btnGetList.TabIndex = 2;
            this.btnGetList.Text = "Search";
            this.btnGetList.UseVisualStyleBackColor = true;
            this.btnGetList.Click += new System.EventHandler(this.BtnGetList_Click);
            // 
            // resultListBox
            // 
            this.resultListBox.FormattingEnabled = true;
            this.resultListBox.Location = new System.Drawing.Point(226, 15);
            this.resultListBox.Name = "resultListBox";
            this.resultListBox.Size = new System.Drawing.Size(290, 407);
            this.resultListBox.TabIndex = 3;
            // 
            // pnlSearching
            // 
            this.pnlSearching.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlSearching.Controls.Add(this.panel3);
            this.pnlSearching.Controls.Add(this.cmbFilter);
            this.pnlSearching.Controls.Add(this.resultsBox);
            this.pnlSearching.Location = new System.Drawing.Point(265, 57);
            this.pnlSearching.Name = "pnlSearching";
            this.pnlSearching.Size = new System.Drawing.Size(532, 312);
            this.pnlSearching.TabIndex = 8;
            this.pnlSearching.Visible = false;
            this.pnlSearching.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlSearching_Paint);
            // 
            // resultsBox
            // 
            this.resultsBox.FormattingEnabled = true;
            this.resultsBox.Location = new System.Drawing.Point(15, 164);
            this.resultsBox.Name = "resultsBox";
            this.resultsBox.Size = new System.Drawing.Size(501, 134);
            this.resultsBox.TabIndex = 0;
            this.resultsBox.SelectedIndexChanged += new System.EventHandler(this.ResultsBox_SelectedIndexChanged);
            // 
            // cmbFilter
            // 
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Items.AddRange(new object[] {
            "All",
            "Managers",
            "Employees",
            "Trainees"});
            this.cmbFilter.Location = new System.Drawing.Point(15, 121);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(121, 21);
            this.cmbFilter.TabIndex = 1;
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.CmbFilter_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.Controls.Add(this.nudEmpNo);
            this.panel3.Controls.Add(this.tbNameSurname);
            this.panel3.Controls.Add(this.rbtnEmpNum);
            this.panel3.Controls.Add(this.rbtnName);
            this.panel3.Location = new System.Drawing.Point(15, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(308, 79);
            this.panel3.TabIndex = 2;
            // 
            // rbtnName
            // 
            this.rbtnName.AutoSize = true;
            this.rbtnName.Checked = true;
            this.rbtnName.Location = new System.Drawing.Point(13, 12);
            this.rbtnName.Name = "rbtnName";
            this.rbtnName.Size = new System.Drawing.Size(137, 17);
            this.rbtnName.TabIndex = 0;
            this.rbtnName.TabStop = true;
            this.rbtnName.Text = "Search Name/Surname";
            this.rbtnName.UseVisualStyleBackColor = true;
            this.rbtnName.CheckedChanged += new System.EventHandler(this.RbtnName_CheckedChanged);
            // 
            // rbtnEmpNum
            // 
            this.rbtnEmpNum.AutoSize = true;
            this.rbtnEmpNum.Location = new System.Drawing.Point(156, 12);
            this.rbtnEmpNum.Name = "rbtnEmpNum";
            this.rbtnEmpNum.Size = new System.Drawing.Size(148, 17);
            this.rbtnEmpNum.TabIndex = 1;
            this.rbtnEmpNum.Text = "Search Employee Number";
            this.rbtnEmpNum.UseVisualStyleBackColor = true;
            this.rbtnEmpNum.CheckedChanged += new System.EventHandler(this.RbtnEmpNum_CheckedChanged);
            // 
            // tbNameSurname
            // 
            this.tbNameSurname.Location = new System.Drawing.Point(13, 35);
            this.tbNameSurname.Name = "tbNameSurname";
            this.tbNameSurname.Size = new System.Drawing.Size(137, 20);
            this.tbNameSurname.TabIndex = 2;
            this.tbNameSurname.TextChanged += new System.EventHandler(this.TbNameSurname_TextChanged);
            // 
            // nudEmpNo
            // 
            this.nudEmpNo.Enabled = false;
            this.nudEmpNo.Location = new System.Drawing.Point(164, 35);
            this.nudEmpNo.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.nudEmpNo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEmpNo.Name = "nudEmpNo";
            this.nudEmpNo.Size = new System.Drawing.Size(120, 20);
            this.nudEmpNo.TabIndex = 3;
            this.nudEmpNo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEmpNo.ValueChanged += new System.EventHandler(this.NudEmpNo_ValueChanged);
            // 
            // pnlHome
            // 
            this.pnlHome.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlHome.Controls.Add(this.lblStatus);
            this.pnlHome.Location = new System.Drawing.Point(243, 133);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(341, 172);
            this.pnlHome.TabIndex = 9;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblStatus.Location = new System.Drawing.Point(87, 82);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(164, 13);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "REQUESTING DATA FROM API";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 460);
            this.Controls.Add(this.pnlHome);
            this.Controls.Add(this.pnlSearching);
            this.Controls.Add(this.dobInterface);
            this.Controls.Add(this.collCS);
            this.Controls.Add(this.expCS);
            this.Controls.Add(this.treeViewStats);
            this.Controls.Add(this.rankingTable);
            this.Controls.Add(this.treeViewEmployees);
            this.Controls.Add(this.pnlMenu);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proof of Concept";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlMenu.ResumeLayout(false);
            this.rankingTable.ResumeLayout(false);
            this.dobInterface.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlSearching.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEmpNo)).EndInit();
            this.pnlHome.ResumeLayout(false);
            this.pnlHome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnRank;
        private System.Windows.Forms.Button btnDOB;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.TreeView treeViewEmployees;
        private System.Windows.Forms.ListBox managerListBox;
        private System.Windows.Forms.Panel rankingTable;
        private System.Windows.Forms.ListBox traineeListBox;
        private System.Windows.Forms.ListBox employeeListBox;
        private System.Windows.Forms.ListBox highestListBox;
        private System.Windows.Forms.ListBox statsListBox;
        private System.Windows.Forms.TreeView treeViewStats;
        private System.Windows.Forms.Button expCS;
        private System.Windows.Forms.Button collCS;
        private System.Windows.Forms.Panel dobInterface;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbtnAfter;
        private System.Windows.Forms.RadioButton rbtnBefore;
        private System.Windows.Forms.Button btnGetList;
        private System.Windows.Forms.ListBox resultListBox;
        private System.Windows.Forms.Panel pnlSearching;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.ListBox resultsBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rbtnEmpNum;
        private System.Windows.Forms.RadioButton rbtnName;
        private System.Windows.Forms.NumericUpDown nudEmpNo;
        private System.Windows.Forms.TextBox tbNameSurname;
        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.Label lblStatus;
    }
}

