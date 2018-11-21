namespace SPK.UserControls.SubForms
{
    partial class AllocateFees
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtFeeedit = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtedittype = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIDedit = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txteditclas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFee = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cBoxType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cBoxClass = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dGridStudents = new System.Windows.Forms.DataGridView();
            this.feeallocationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picSchoolLogo = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allocateclassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studenttypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feeamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateallocatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnUpdate = new SPK.UserControls.Buttons.ButtonWithoutMenu();
            this.btnSave = new SPK.UserControls.Buttons.ButtonWithoutMenu();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feeallocationBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSchoolLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.txtFeeedit);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtedittype);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtIDedit);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txteditclas);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtFee);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.cBoxType);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.cBoxClass);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(5, 106);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(791, 173);
            this.panel3.TabIndex = 26;
            // 
            // txtFeeedit
            // 
            this.txtFeeedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFeeedit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtFeeedit.Location = new System.Drawing.Point(423, 147);
            this.txtFeeedit.Name = "txtFeeedit";
            this.txtFeeedit.Size = new System.Drawing.Size(191, 23);
            this.txtFeeedit.TabIndex = 89;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label8.Location = new System.Drawing.Point(421, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 17);
            this.label8.TabIndex = 86;
            this.label8.Text = "Fee Allocation";
            // 
            // txtedittype
            // 
            this.txtedittype.Enabled = false;
            this.txtedittype.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtedittype.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtedittype.Location = new System.Drawing.Point(296, 147);
            this.txtedittype.Name = "txtedittype";
            this.txtedittype.Size = new System.Drawing.Size(103, 23);
            this.txtedittype.TabIndex = 89;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label9.Location = new System.Drawing.Point(306, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 17);
            this.label9.TabIndex = 86;
            this.label9.Text = "UPDATE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label7.Location = new System.Drawing.Point(293, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 17);
            this.label7.TabIndex = 86;
            this.label7.Text = "Student Type";
            // 
            // txtIDedit
            // 
            this.txtIDedit.Enabled = false;
            this.txtIDedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDedit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtIDedit.Location = new System.Drawing.Point(26, 147);
            this.txtIDedit.Name = "txtIDedit";
            this.txtIDedit.Size = new System.Drawing.Size(103, 23);
            this.txtIDedit.TabIndex = 89;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label10.Location = new System.Drawing.Point(23, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 17);
            this.label10.TabIndex = 86;
            this.label10.Text = "ID";
            // 
            // txteditclas
            // 
            this.txteditclas.Enabled = false;
            this.txteditclas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txteditclas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txteditclas.Location = new System.Drawing.Point(156, 147);
            this.txteditclas.Name = "txteditclas";
            this.txteditclas.Size = new System.Drawing.Size(103, 23);
            this.txteditclas.TabIndex = 89;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label4.Location = new System.Drawing.Point(153, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 86;
            this.label4.Text = "Class";
            // 
            // txtFee
            // 
            this.txtFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtFee.Location = new System.Drawing.Point(423, 62);
            this.txtFee.Name = "txtFee";
            this.txtFee.Size = new System.Drawing.Size(191, 23);
            this.txtFee.TabIndex = 89;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label6.Location = new System.Drawing.Point(421, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 17);
            this.label6.TabIndex = 86;
            this.label6.Text = "Fee Allocation";
            // 
            // cBoxType
            // 
            this.cBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxType.FormattingEnabled = true;
            this.cBoxType.Items.AddRange(new object[] {
            "--Select--",
            "Old Students",
            "New Students",
            "Old Students on Scholarship",
            "New Students on Scholarship"});
            this.cBoxType.Location = new System.Drawing.Point(209, 61);
            this.cBoxType.Name = "cBoxType";
            this.cBoxType.Size = new System.Drawing.Size(202, 24);
            this.cBoxType.TabIndex = 85;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label5.Location = new System.Drawing.Point(205, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 84;
            this.label5.Text = "Student type";
            // 
            // cBoxClass
            // 
            this.cBoxClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxClass.FormattingEnabled = true;
            this.cBoxClass.Location = new System.Drawing.Point(8, 61);
            this.cBoxClass.Name = "cBoxClass";
            this.cBoxClass.Size = new System.Drawing.Size(183, 24);
            this.cBoxClass.TabIndex = 83;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label1.Location = new System.Drawing.Point(4, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 81;
            this.label1.Text = "Class";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.label2.Location = new System.Drawing.Point(288, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Allocate Fees to Class";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dGridStudents);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(5, 285);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(791, 292);
            this.panel2.TabIndex = 25;
            // 
            // dGridStudents
            // 
            this.dGridStudents.AllowUserToAddRows = false;
            this.dGridStudents.AllowUserToDeleteRows = false;
            this.dGridStudents.AutoGenerateColumns = false;
            this.dGridStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGridStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.allocateclassDataGridViewTextBoxColumn,
            this.studenttypeDataGridViewTextBoxColumn,
            this.feeamountDataGridViewTextBoxColumn,
            this.dateallocatedDataGridViewTextBoxColumn,
            this.Delete});
            this.dGridStudents.DataSource = this.feeallocationBindingSource;
            this.dGridStudents.Location = new System.Drawing.Point(5, 30);
            this.dGridStudents.Name = "dGridStudents";
            this.dGridStudents.ReadOnly = true;
            this.dGridStudents.RowTemplate.Height = 24;
            this.dGridStudents.Size = new System.Drawing.Size(780, 326);
            this.dGridStudents.TabIndex = 15;
            this.dGridStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridStudents_CellClick);
            this.dGridStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridStudents_CellContentClick);
            // 
            // feeallocationBindingSource
            // 
            this.feeallocationBindingSource.DataSource = typeof(DB.fee_allocation);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.label3.Location = new System.Drawing.Point(232, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(292, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "View Allocated Fees for each Class";
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
            this.panel1.TabIndex = 24;
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.Location = new System.Drawing.Point(28, 59);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(106, 17);
            this.lblSubTitle.TabIndex = 2;
            this.lblSubTitle.Text = "Allocate Fees";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(70, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(248, 26);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "FEES MANAGEMENT";
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
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // allocateclassDataGridViewTextBoxColumn
            // 
            this.allocateclassDataGridViewTextBoxColumn.DataPropertyName = "allocate_class";
            this.allocateclassDataGridViewTextBoxColumn.HeaderText = "Class";
            this.allocateclassDataGridViewTextBoxColumn.Name = "allocateclassDataGridViewTextBoxColumn";
            this.allocateclassDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studenttypeDataGridViewTextBoxColumn
            // 
            this.studenttypeDataGridViewTextBoxColumn.DataPropertyName = "student_type";
            this.studenttypeDataGridViewTextBoxColumn.HeaderText = "Student Type";
            this.studenttypeDataGridViewTextBoxColumn.Name = "studenttypeDataGridViewTextBoxColumn";
            this.studenttypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // feeamountDataGridViewTextBoxColumn
            // 
            this.feeamountDataGridViewTextBoxColumn.DataPropertyName = "fee_amount";
            this.feeamountDataGridViewTextBoxColumn.HeaderText = "Amount(#)";
            this.feeamountDataGridViewTextBoxColumn.Name = "feeamountDataGridViewTextBoxColumn";
            this.feeamountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateallocatedDataGridViewTextBoxColumn
            // 
            this.dateallocatedDataGridViewTextBoxColumn.DataPropertyName = "date_allocated";
            this.dateallocatedDataGridViewTextBoxColumn.HeaderText = "Date Allocated";
            this.dateallocatedDataGridViewTextBoxColumn.Name = "dateallocatedDataGridViewTextBoxColumn";
            this.dateallocatedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Delete
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            this.Delete.DefaultCellStyle = dataGridViewCellStyle1;
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.btnUpdate.BtnText = "UPDATE";
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(15)))), ((int)(((byte)(23)))));
            this.btnUpdate.Icon = global::SPK.Properties.Resources.icons8_save_64;
            this.btnUpdate.Location = new System.Drawing.Point(635, 123);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.SideColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(113)))));
            this.btnUpdate.Size = new System.Drawing.Size(157, 47);
            this.btnUpdate.TabIndex = 91;
            this.btnUpdate.ClickEvent += new System.EventHandler(this.btnUpdate_ClickEvent);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.btnSave.BtnText = "SAVE";
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(15)))), ((int)(((byte)(23)))));
            this.btnSave.Icon = global::SPK.Properties.Resources.icons8_save_64;
            this.btnSave.Location = new System.Drawing.Point(635, 38);
            this.btnSave.Name = "btnSave";
            this.btnSave.SideColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(113)))));
            this.btnSave.Size = new System.Drawing.Size(134, 49);
            this.btnSave.TabIndex = 90;
            this.btnSave.ClickEvent += new System.EventHandler(this.btnSave_ClickEvent);
            // 
            // AllocateFees
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AllocateFees";
            this.Size = new System.Drawing.Size(800, 580);
            this.Tag = "";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feeallocationBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSchoolLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cBoxType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cBoxClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dGridStudents;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picSchoolLogo;
        private System.Windows.Forms.TextBox txtFee;
        private Buttons.ButtonWithoutMenu btnSave;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.BindingSource feeallocationBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Buttons.ButtonWithoutMenu btnUpdate;
        private System.Windows.Forms.TextBox txtFeeedit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtedittype;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txteditclas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIDedit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn allocateclassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studenttypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feeamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateallocatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}
