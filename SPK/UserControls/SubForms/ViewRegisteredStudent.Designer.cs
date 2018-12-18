namespace SPK.UserControls.SubForms
{
    partial class ViewRegisteredStudent
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picSchoolLogo = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cBoxSession = new System.Windows.Forms.ComboBox();
            this.sessionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.cBoxTerm = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cBoxSubject = new System.Windows.Forms.ComboBox();
            this.schoolsubjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.cBoxClass = new System.Windows.Forms.ComboBox();
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSearch = new SPK.UserControls.Buttons.ButtonWithoutMenu();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dGridStudents = new System.Windows.Forms.DataGridView();
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.termDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSchoolLogo)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sessionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolsubjectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.TabIndex = 13;
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.Location = new System.Drawing.Point(29, 61);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(245, 17);
            this.lblSubTitle.TabIndex = 2;
            this.lblSubTitle.Text = "View Registered Student Subject";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(71, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(293, 26);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "SUBJECT MANAGEMENT";
            // 
            // picSchoolLogo
            // 
            this.picSchoolLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.picSchoolLogo.Image = global::SPK.Properties.Resources.icons8_file_64;
            this.picSchoolLogo.Location = new System.Drawing.Point(30, 17);
            this.picSchoolLogo.Name = "picSchoolLogo";
            this.picSchoolLogo.Size = new System.Drawing.Size(40, 40);
            this.picSchoolLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSchoolLogo.TabIndex = 0;
            this.picSchoolLogo.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.cBoxSession);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.cBoxTerm);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.cBoxSubject);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.cBoxClass);
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(7, 106);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(787, 93);
            this.panel3.TabIndex = 14;
            // 
            // cBoxSession
            // 
            this.cBoxSession.DataSource = this.sessionBindingSource;
            this.cBoxSession.DisplayMember = "sessions";
            this.cBoxSession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxSession.FormattingEnabled = true;
            this.cBoxSession.Location = new System.Drawing.Point(497, 55);
            this.cBoxSession.Name = "cBoxSession";
            this.cBoxSession.Size = new System.Drawing.Size(145, 24);
            this.cBoxSession.TabIndex = 80;
            this.cBoxSession.ValueMember = "sessions";
            // 
            // sessionBindingSource
            // 
            this.sessionBindingSource.DataSource = typeof(DB.session);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label6.Location = new System.Drawing.Point(493, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 79;
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
            this.cBoxTerm.Location = new System.Drawing.Point(338, 55);
            this.cBoxTerm.Name = "cBoxTerm";
            this.cBoxTerm.Size = new System.Drawing.Size(147, 24);
            this.cBoxTerm.TabIndex = 78;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label5.Location = new System.Drawing.Point(334, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 77;
            this.label5.Text = "Term";
            // 
            // cBoxSubject
            // 
            this.cBoxSubject.DataSource = this.schoolsubjectsBindingSource;
            this.cBoxSubject.DisplayMember = "subjects";
            this.cBoxSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxSubject.FormattingEnabled = true;
            this.cBoxSubject.Location = new System.Drawing.Point(171, 55);
            this.cBoxSubject.Name = "cBoxSubject";
            this.cBoxSubject.Size = new System.Drawing.Size(151, 24);
            this.cBoxSubject.TabIndex = 76;
            this.cBoxSubject.ValueMember = "subjects";
            // 
            // schoolsubjectsBindingSource
            // 
            this.schoolsubjectsBindingSource.DataSource = typeof(DB.school_subjects);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label4.Location = new System.Drawing.Point(167, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 75;
            this.label4.Text = "Subject";
            // 
            // cBoxClass
            // 
            this.cBoxClass.DataSource = this.classBindingSource;
            this.cBoxClass.DisplayMember = "classes";
            this.cBoxClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxClass.FormattingEnabled = true;
            this.cBoxClass.Location = new System.Drawing.Point(12, 55);
            this.cBoxClass.Name = "cBoxClass";
            this.cBoxClass.Size = new System.Drawing.Size(148, 24);
            this.cBoxClass.TabIndex = 74;
            this.cBoxClass.ValueMember = "classes";
            // 
            // classBindingSource
            // 
            this.classBindingSource.DataSource = typeof(DB._class);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.btnSearch.BtnText = "SHOW";
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(15)))), ((int)(((byte)(23)))));
            this.btnSearch.Icon = global::SPK.Properties.Resources.search_3;
            this.btnSearch.Location = new System.Drawing.Point(652, 34);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.SideColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(113)))));
            this.btnSearch.Size = new System.Drawing.Size(130, 45);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.ClickEvent += new System.EventHandler(this.btnSearch_ClickEvent);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.label2.Location = new System.Drawing.Point(257, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "View Registered Student";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label1.Location = new System.Drawing.Point(8, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Class";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dGridStudents);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(7, 205);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(787, 362);
            this.panel2.TabIndex = 15;
            // 
            // dGridStudents
            // 
            this.dGridStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dGridStudents.AutoGenerateColumns = false;
            this.dGridStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGridStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.regnumberDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.classDataGridViewTextBoxColumn,
            this.subjectsDataGridViewTextBoxColumn,
            this.termDataGridViewTextBoxColumn,
            this.sessionDataGridViewTextBoxColumn});
            this.dGridStudents.DataSource = this.subjectBindingSource;
            this.dGridStudents.Location = new System.Drawing.Point(9, 33);
            this.dGridStudents.Name = "dGridStudents";
            this.dGridStudents.RowTemplate.Height = 24;
            this.dGridStudents.Size = new System.Drawing.Size(770, 319);
            this.dGridStudents.TabIndex = 15;
            // 
            // subjectBindingSource
            // 
            this.subjectBindingSource.DataSource = typeof(DB.subject);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.label3.Location = new System.Drawing.Point(282, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Registered student";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // regnumberDataGridViewTextBoxColumn
            // 
            this.regnumberDataGridViewTextBoxColumn.DataPropertyName = "reg_number";
            this.regnumberDataGridViewTextBoxColumn.HeaderText = "reg_number";
            this.regnumberDataGridViewTextBoxColumn.Name = "regnumberDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // classDataGridViewTextBoxColumn
            // 
            this.classDataGridViewTextBoxColumn.DataPropertyName = "_class";
            this.classDataGridViewTextBoxColumn.HeaderText = "_class";
            this.classDataGridViewTextBoxColumn.Name = "classDataGridViewTextBoxColumn";
            // 
            // subjectsDataGridViewTextBoxColumn
            // 
            this.subjectsDataGridViewTextBoxColumn.DataPropertyName = "subjects";
            this.subjectsDataGridViewTextBoxColumn.HeaderText = "subjects";
            this.subjectsDataGridViewTextBoxColumn.Name = "subjectsDataGridViewTextBoxColumn";
            // 
            // termDataGridViewTextBoxColumn
            // 
            this.termDataGridViewTextBoxColumn.DataPropertyName = "term";
            this.termDataGridViewTextBoxColumn.HeaderText = "term";
            this.termDataGridViewTextBoxColumn.Name = "termDataGridViewTextBoxColumn";
            // 
            // sessionDataGridViewTextBoxColumn
            // 
            this.sessionDataGridViewTextBoxColumn.DataPropertyName = "session";
            this.sessionDataGridViewTextBoxColumn.HeaderText = "session";
            this.sessionDataGridViewTextBoxColumn.Name = "sessionDataGridViewTextBoxColumn";
            // 
            // ViewRegisteredStudent
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "ViewRegisteredStudent";
            this.Size = new System.Drawing.Size(800, 580);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSchoolLogo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sessionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolsubjectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picSchoolLogo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cBoxSession;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cBoxTerm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cBoxSubject;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cBoxClass;
        private Buttons.ButtonWithoutMenu btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dGridStudents;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.BindingSource schoolsubjectsBindingSource;
        private System.Windows.Forms.BindingSource classBindingSource;
        private System.Windows.Forms.BindingSource sessionBindingSource;
        private System.Windows.Forms.BindingSource subjectBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn termDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionDataGridViewTextBoxColumn;
    }
}
