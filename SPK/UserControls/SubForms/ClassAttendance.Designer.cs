namespace SPK.UserControls.SubForms
{
    partial class ClassAttendance
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSave = new SPK.UserControls.Buttons.ButtonWithoutMenu();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cBoxSession = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cBoxTerm = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cBoxClass = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShow = new SPK.UserControls.Buttons.ButtonWithoutMenu();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picSchoolLogo = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dGridClassMembers = new System.Windows.Forms.DataGridView();
            this.regnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendanceDummyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSchoolLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGridClassMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dGridClassMembers);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.dtpDate);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cBoxSession);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cBoxTerm);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(9, 190);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(782, 380);
            this.panel2.TabIndex = 9;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(DB.student);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.btnSave.BtnText = "SAVE";
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(15)))), ((int)(((byte)(23)))));
            this.btnSave.Icon = global::SPK.Properties.Resources.icons8_save_64;
            this.btnSave.Location = new System.Drawing.Point(310, 339);
            this.btnSave.Name = "btnSave";
            this.btnSave.SideColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(113)))));
            this.btnSave.Size = new System.Drawing.Size(150, 38);
            this.btnSave.TabIndex = 92;
            this.btnSave.ClickEvent += new System.EventHandler(this.btnSave_ClickEvent);
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd/MM/yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(100, 18);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(144, 23);
            this.dtpDate.TabIndex = 91;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label7.Location = new System.Drawing.Point(42, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 90;
            this.label7.Text = "Date :";
            // 
            // cBoxSession
            // 
            this.cBoxSession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxSession.FormattingEnabled = true;
            this.cBoxSession.Location = new System.Drawing.Point(566, 17);
            this.cBoxSession.Name = "cBoxSession";
            this.cBoxSession.Size = new System.Drawing.Size(168, 24);
            this.cBoxSession.TabIndex = 84;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label6.Location = new System.Drawing.Point(486, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 83;
            this.label6.Text = "Session :";
            // 
            // cBoxTerm
            // 
            this.cBoxTerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxTerm.FormattingEnabled = true;
            this.cBoxTerm.Location = new System.Drawing.Point(310, 17);
            this.cBoxTerm.Name = "cBoxTerm";
            this.cBoxTerm.Size = new System.Drawing.Size(170, 24);
            this.cBoxTerm.TabIndex = 82;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label5.Location = new System.Drawing.Point(250, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 81;
            this.label5.Text = "Term :";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.cBoxClass);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnShow);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(47, 107);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(706, 75);
            this.panel3.TabIndex = 8;
            // 
            // cBoxClass
            // 
            this.cBoxClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxClass.FormattingEnabled = true;
            this.cBoxClass.Items.AddRange(new object[] {
            "--Select--"});
            this.cBoxClass.Location = new System.Drawing.Point(183, 34);
            this.cBoxClass.Name = "cBoxClass";
            this.cBoxClass.Size = new System.Drawing.Size(263, 24);
            this.cBoxClass.TabIndex = 76;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label1.Location = new System.Drawing.Point(70, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 75;
            this.label1.Text = "Select Class :";
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.btnShow.BtnText = "DISPLAY STUDENTS";
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(15)))), ((int)(((byte)(23)))));
            this.btnShow.Icon = global::SPK.Properties.Resources.search_3;
            this.btnShow.Location = new System.Drawing.Point(451, 23);
            this.btnShow.Name = "btnShow";
            this.btnShow.SideColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(113)))));
            this.btnShow.Size = new System.Drawing.Size(208, 41);
            this.btnShow.TabIndex = 26;
            this.btnShow.ClickEvent += new System.EventHandler(this.btnShow_ClickEvent);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.label2.Location = new System.Drawing.Point(242, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "CLASS ATTENDANCE";
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
            this.panel1.TabIndex = 7;
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Lucida Sans", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.Location = new System.Drawing.Point(27, 60);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(138, 16);
            this.lblSubTitle.TabIndex = 2;
            this.lblSubTitle.Text = "Save daily roll call";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Lucida Sans", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(69, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(340, 25);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "ATTENDANCE MANAGEMENT";
            // 
            // picSchoolLogo
            // 
            this.picSchoolLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.picSchoolLogo.Image = global::SPK.Properties.Resources.icons8_people_64;
            this.picSchoolLogo.Location = new System.Drawing.Point(28, 16);
            this.picSchoolLogo.Name = "picSchoolLogo";
            this.picSchoolLogo.Size = new System.Drawing.Size(40, 40);
            this.picSchoolLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSchoolLogo.TabIndex = 0;
            this.picSchoolLogo.TabStop = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // dGridClassMembers
            // 
            this.dGridClassMembers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dGridClassMembers.AutoGenerateColumns = false;
            this.dGridClassMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGridClassMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridClassMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.regnumberDataGridViewTextBoxColumn,
            this.fullnameDataGridViewTextBoxColumn,
            this.classDataGridViewTextBoxColumn,
            this.attendanceDummyDataGridViewTextBoxColumn});
            this.dGridClassMembers.DataSource = this.studentBindingSource;
            this.dGridClassMembers.Location = new System.Drawing.Point(5, 45);
            this.dGridClassMembers.Name = "dGridClassMembers";
            this.dGridClassMembers.RowTemplate.Height = 24;
            this.dGridClassMembers.Size = new System.Drawing.Size(773, 293);
            this.dGridClassMembers.TabIndex = 93;
            // 
            // regnumberDataGridViewTextBoxColumn
            // 
            this.regnumberDataGridViewTextBoxColumn.DataPropertyName = "reg_number";
            this.regnumberDataGridViewTextBoxColumn.HeaderText = "Reg Number";
            this.regnumberDataGridViewTextBoxColumn.Name = "regnumberDataGridViewTextBoxColumn";
            // 
            // fullnameDataGridViewTextBoxColumn
            // 
            this.fullnameDataGridViewTextBoxColumn.DataPropertyName = "Fullname";
            this.fullnameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.fullnameDataGridViewTextBoxColumn.Name = "fullnameDataGridViewTextBoxColumn";
            this.fullnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classDataGridViewTextBoxColumn
            // 
            this.classDataGridViewTextBoxColumn.DataPropertyName = "_class";
            this.classDataGridViewTextBoxColumn.HeaderText = "Class";
            this.classDataGridViewTextBoxColumn.Name = "classDataGridViewTextBoxColumn";
            // 
            // attendanceDummyDataGridViewTextBoxColumn
            // 
            this.attendanceDummyDataGridViewTextBoxColumn.DataPropertyName = "AttendanceDummy";
            this.attendanceDummyDataGridViewTextBoxColumn.HeaderText = "Roll Call";
            this.attendanceDummyDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "Present",
            "Absent"});
            this.attendanceDummyDataGridViewTextBoxColumn.Name = "attendanceDummyDataGridViewTextBoxColumn";
            this.attendanceDummyDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.attendanceDummyDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ClassAttendance
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "ClassAttendance";
            this.Size = new System.Drawing.Size(800, 580);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSchoolLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGridClassMembers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Buttons.ButtonWithoutMenu btnShow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picSchoolLogo;
        private System.Windows.Forms.ComboBox cBoxClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxSession;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cBoxTerm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private Buttons.ButtonWithoutMenu btnSave;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dGridClassMembers;
        private System.Windows.Forms.DataGridViewTextBoxColumn regnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn attendanceDummyDataGridViewTextBoxColumn;
    }
}
