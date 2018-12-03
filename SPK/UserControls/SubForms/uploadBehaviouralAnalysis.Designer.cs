namespace SPK.UserControls.SubForms
{
    partial class uploadBehaviouralAnalysis
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cBoxSession = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cBoxTerm = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cBoxClass = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picSchoolLogo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new SPK.UserControls.Buttons.ButtonWithoutMenu();
            this.dGridStudentsBehaviour = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch = new SPK.UserControls.Buttons.ButtonWithoutMenu();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.behavioralBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.regnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.termDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.handwrittingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.musicalskillsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.sportsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.attentivenessDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.attitudetoworkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.healthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.politenessDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSchoolLogo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridStudentsBehaviour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behavioralBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Controls.Add(this.cBoxSession);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.cBoxTerm);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.cBoxClass);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(5, 106);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(791, 92);
            this.panel3.TabIndex = 28;
            // 
            // cBoxSession
            // 
            this.cBoxSession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxSession.FormattingEnabled = true;
            this.cBoxSession.Items.AddRange(new object[] {
            "--Select--"});
            this.cBoxSession.Location = new System.Drawing.Point(412, 59);
            this.cBoxSession.Name = "cBoxSession";
            this.cBoxSession.Size = new System.Drawing.Size(193, 24);
            this.cBoxSession.TabIndex = 89;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label6.Location = new System.Drawing.Point(408, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 88;
            this.label6.Text = "Session";
            // 
            // cBoxTerm
            // 
            this.cBoxTerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxTerm.FormattingEnabled = true;
            this.cBoxTerm.Items.AddRange(new object[] {
            "--Select--",
            "First Term",
            "Second Term",
            "Third Term"});
            this.cBoxTerm.Location = new System.Drawing.Point(204, 59);
            this.cBoxTerm.Name = "cBoxTerm";
            this.cBoxTerm.Size = new System.Drawing.Size(191, 24);
            this.cBoxTerm.TabIndex = 87;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label5.Location = new System.Drawing.Point(200, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 86;
            this.label5.Text = "Term";
            // 
            // cBoxClass
            // 
            this.cBoxClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxClass.FormattingEnabled = true;
            this.cBoxClass.Items.AddRange(new object[] {
            "--Select--"});
            this.cBoxClass.Location = new System.Drawing.Point(15, 59);
            this.cBoxClass.Name = "cBoxClass";
            this.cBoxClass.Size = new System.Drawing.Size(174, 24);
            this.cBoxClass.TabIndex = 83;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label1.Location = new System.Drawing.Point(11, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 81;
            this.label1.Text = "Class";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.label2.Location = new System.Drawing.Point(325, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Select Class";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblSubTitle);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.picSchoolLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 27;
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.Location = new System.Drawing.Point(28, 59);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(260, 17);
            this.lblSubTitle.TabIndex = 2;
            this.lblSubTitle.Text = "Save Students Behavioral Analysis";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(70, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(306, 26);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "BEHAVIOURAL ANALYSIS";
            // 
            // picSchoolLogo
            // 
            this.picSchoolLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.picSchoolLogo.Image = global::SPK.Properties.Resources.icons8_money_64;
            this.picSchoolLogo.Location = new System.Drawing.Point(29, 15);
            this.picSchoolLogo.Name = "picSchoolLogo";
            this.picSchoolLogo.Size = new System.Drawing.Size(40, 40);
            this.picSchoolLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSchoolLogo.TabIndex = 0;
            this.picSchoolLogo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.dGridStudentsBehaviour);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(4, 206);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(792, 366);
            this.panel2.TabIndex = 29;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.btnSave.BtnText = "SAVE";
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(15)))), ((int)(((byte)(23)))));
            this.btnSave.Icon = global::SPK.Properties.Resources.icons8_save_64;
            this.btnSave.Location = new System.Drawing.Point(316, 320);
            this.btnSave.Name = "btnSave";
            this.btnSave.SideColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(113)))));
            this.btnSave.Size = new System.Drawing.Size(158, 43);
            this.btnSave.TabIndex = 81;
            this.btnSave.ClickEvent += new System.EventHandler(this.btnSave_ClickEvent);
            // 
            // dGridStudentsBehaviour
            // 
            this.dGridStudentsBehaviour.AllowUserToAddRows = false;
            this.dGridStudentsBehaviour.AllowUserToDeleteRows = false;
            this.dGridStudentsBehaviour.AutoGenerateColumns = false;
            this.dGridStudentsBehaviour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridStudentsBehaviour.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.regnumberDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.classDataGridViewTextBoxColumn,
            this.termDataGridViewTextBoxColumn,
            this.sessionDataGridViewTextBoxColumn,
            this.handwrittingDataGridViewTextBoxColumn,
            this.musicalskillsDataGridViewTextBoxColumn,
            this.sportsDataGridViewTextBoxColumn,
            this.attentivenessDataGridViewTextBoxColumn,
            this.attitudetoworkDataGridViewTextBoxColumn,
            this.healthDataGridViewTextBoxColumn,
            this.politenessDataGridViewTextBoxColumn});
            this.dGridStudentsBehaviour.DataSource = this.behavioralBindingSource;
            this.dGridStudentsBehaviour.Location = new System.Drawing.Point(5, 28);
            this.dGridStudentsBehaviour.Name = "dGridStudentsBehaviour";
            this.dGridStudentsBehaviour.RowTemplate.Height = 24;
            this.dGridStudentsBehaviour.Size = new System.Drawing.Size(784, 290);
            this.dGridStudentsBehaviour.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.label3.Location = new System.Drawing.Point(268, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Fill Behaviours and Save";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.btnSearch.BtnText = "Load";
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(15)))), ((int)(((byte)(23)))));
            this.btnSearch.Icon = global::SPK.Properties.Resources.search_3;
            this.btnSearch.Location = new System.Drawing.Point(624, 36);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.SideColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(113)))));
            this.btnSearch.Size = new System.Drawing.Size(141, 47);
            this.btnSearch.TabIndex = 91;
            this.btnSearch.ClickEvent += new System.EventHandler(this.btnSearch_ClickEvent);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // behavioralBindingSource
            // 
            this.behavioralBindingSource.DataSource = typeof(DB.behavioral);
            // 
            // regnumberDataGridViewTextBoxColumn
            // 
            this.regnumberDataGridViewTextBoxColumn.DataPropertyName = "reg_number";
            this.regnumberDataGridViewTextBoxColumn.HeaderText = "Reg Number";
            this.regnumberDataGridViewTextBoxColumn.Name = "regnumberDataGridViewTextBoxColumn";
            this.regnumberDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // classDataGridViewTextBoxColumn
            // 
            this.classDataGridViewTextBoxColumn.DataPropertyName = "_class";
            this.classDataGridViewTextBoxColumn.HeaderText = "Class";
            this.classDataGridViewTextBoxColumn.Name = "classDataGridViewTextBoxColumn";
            // 
            // termDataGridViewTextBoxColumn
            // 
            this.termDataGridViewTextBoxColumn.DataPropertyName = "term";
            this.termDataGridViewTextBoxColumn.HeaderText = "Term";
            this.termDataGridViewTextBoxColumn.Name = "termDataGridViewTextBoxColumn";
            this.termDataGridViewTextBoxColumn.Width = 120;
            // 
            // sessionDataGridViewTextBoxColumn
            // 
            this.sessionDataGridViewTextBoxColumn.DataPropertyName = "session";
            this.sessionDataGridViewTextBoxColumn.HeaderText = "Session";
            this.sessionDataGridViewTextBoxColumn.Name = "sessionDataGridViewTextBoxColumn";
            // 
            // handwrittingDataGridViewTextBoxColumn
            // 
            this.handwrittingDataGridViewTextBoxColumn.DataPropertyName = "hand_writting";
            this.handwrittingDataGridViewTextBoxColumn.HeaderText = "Hand Writting";
            this.handwrittingDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.handwrittingDataGridViewTextBoxColumn.Name = "handwrittingDataGridViewTextBoxColumn";
            this.handwrittingDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.handwrittingDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // musicalskillsDataGridViewTextBoxColumn
            // 
            this.musicalskillsDataGridViewTextBoxColumn.DataPropertyName = "musical_skills";
            this.musicalskillsDataGridViewTextBoxColumn.HeaderText = "Musical Skills";
            this.musicalskillsDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.musicalskillsDataGridViewTextBoxColumn.Name = "musicalskillsDataGridViewTextBoxColumn";
            this.musicalskillsDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.musicalskillsDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // sportsDataGridViewTextBoxColumn
            // 
            this.sportsDataGridViewTextBoxColumn.DataPropertyName = "sports";
            this.sportsDataGridViewTextBoxColumn.HeaderText = "Sports";
            this.sportsDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.sportsDataGridViewTextBoxColumn.Name = "sportsDataGridViewTextBoxColumn";
            this.sportsDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sportsDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // attentivenessDataGridViewTextBoxColumn
            // 
            this.attentivenessDataGridViewTextBoxColumn.DataPropertyName = "attentiveness";
            this.attentivenessDataGridViewTextBoxColumn.HeaderText = "Attentiveness";
            this.attentivenessDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.attentivenessDataGridViewTextBoxColumn.Name = "attentivenessDataGridViewTextBoxColumn";
            this.attentivenessDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.attentivenessDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // attitudetoworkDataGridViewTextBoxColumn
            // 
            this.attitudetoworkDataGridViewTextBoxColumn.DataPropertyName = "attitude_to_work";
            this.attitudetoworkDataGridViewTextBoxColumn.HeaderText = "Attitude to Work";
            this.attitudetoworkDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.attitudetoworkDataGridViewTextBoxColumn.Name = "attitudetoworkDataGridViewTextBoxColumn";
            this.attitudetoworkDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.attitudetoworkDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // healthDataGridViewTextBoxColumn
            // 
            this.healthDataGridViewTextBoxColumn.DataPropertyName = "health";
            this.healthDataGridViewTextBoxColumn.HeaderText = "Health";
            this.healthDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.healthDataGridViewTextBoxColumn.Name = "healthDataGridViewTextBoxColumn";
            this.healthDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.healthDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // politenessDataGridViewTextBoxColumn
            // 
            this.politenessDataGridViewTextBoxColumn.DataPropertyName = "politeness";
            this.politenessDataGridViewTextBoxColumn.HeaderText = "Politeness";
            this.politenessDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.politenessDataGridViewTextBoxColumn.Name = "politenessDataGridViewTextBoxColumn";
            this.politenessDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.politenessDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // uploadBehaviouralAnalysis
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "uploadBehaviouralAnalysis";
            this.Size = new System.Drawing.Size(800, 580);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSchoolLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridStudentsBehaviour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behavioralBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picSchoolLogo;
        private System.Windows.Forms.ComboBox cBoxSession;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cBoxTerm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cBoxClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Buttons.ButtonWithoutMenu btnSave;
        private System.Windows.Forms.DataGridView dGridStudentsBehaviour;
        private System.Windows.Forms.Label label3;
        private Buttons.ButtonWithoutMenu btnSearch;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn regnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn termDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn handwrittingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn musicalskillsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn sportsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn attentivenessDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn attitudetoworkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn healthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn politenessDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource behavioralBindingSource;
    }
}
