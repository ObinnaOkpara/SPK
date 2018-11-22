namespace SPK.UserControls.SubForms
{
    partial class AddnViewClass
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this._txtClassName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dGridAllClass = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateaddedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSave = new SPK.UserControls.Buttons.ButtonWithoutMenu();
            this.picSchoolLogo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridAllClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSchoolLogo)).BeginInit();
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
            this.panel1.TabIndex = 3;
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Lucida Sans", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.Location = new System.Drawing.Point(27, 60);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(113, 16);
            this.lblSubTitle.TabIndex = 2;
            this.lblSubTitle.Text = "Add new class";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Lucida Sans", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(69, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(253, 25);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "CLASS MANAGEMENT";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this._txtClassName);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(47, 106);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(706, 95);
            this.panel3.TabIndex = 5;
            // 
            // _txtClassName
            // 
            this._txtClassName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtClassName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this._txtClassName.Location = new System.Drawing.Point(61, 64);
            this._txtClassName.Name = "_txtClassName";
            this._txtClassName.Size = new System.Drawing.Size(424, 23);
            this._txtClassName.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label1.Location = new System.Drawing.Point(57, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Class Name (eg; JSS1A, SSS1B)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.label2.Location = new System.Drawing.Point(272, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "ADD CLASS";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dGridAllClass);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(97, 209);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(596, 363);
            this.panel2.TabIndex = 6;
            // 
            // dGridAllClass
            // 
            this.dGridAllClass.AllowUserToAddRows = false;
            this.dGridAllClass.AllowUserToDeleteRows = false;
            this.dGridAllClass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dGridAllClass.AutoGenerateColumns = false;
            this.dGridAllClass.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGridAllClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridAllClass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.classesDataGridViewTextBoxColumn,
            this.dateaddedDataGridViewTextBoxColumn,
            this.Delete});
            this.dGridAllClass.DataSource = this.classBindingSource;
            this.dGridAllClass.Location = new System.Drawing.Point(20, 43);
            this.dGridAllClass.Margin = new System.Windows.Forms.Padding(2);
            this.dGridAllClass.Name = "dGridAllClass";
            this.dGridAllClass.ReadOnly = true;
            this.dGridAllClass.RowTemplate.Height = 24;
            this.dGridAllClass.Size = new System.Drawing.Size(557, 305);
            this.dGridAllClass.TabIndex = 15;
            this.dGridAllClass.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridAllClass_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.label3.Location = new System.Drawing.Point(210, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "ALL CLASSES";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Delete
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.Delete.DefaultCellStyle = dataGridViewCellStyle2;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.HeaderText = "";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
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
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // classesDataGridViewTextBoxColumn
            // 
            this.classesDataGridViewTextBoxColumn.DataPropertyName = "classes";
            this.classesDataGridViewTextBoxColumn.HeaderText = "Class";
            this.classesDataGridViewTextBoxColumn.Name = "classesDataGridViewTextBoxColumn";
            this.classesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateaddedDataGridViewTextBoxColumn
            // 
            this.dateaddedDataGridViewTextBoxColumn.DataPropertyName = "date_added";
            this.dateaddedDataGridViewTextBoxColumn.HeaderText = "Date Added";
            this.dateaddedDataGridViewTextBoxColumn.Name = "dateaddedDataGridViewTextBoxColumn";
            this.dateaddedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classBindingSource
            // 
            this.classBindingSource.DataSource = typeof(DB._class);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.btnSave.BtnText = "SAVE";
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(15)))), ((int)(((byte)(23)))));
            this.btnSave.Icon = global::SPK.Properties.Resources.icons8_save_64;
            this.btnSave.Location = new System.Drawing.Point(500, 41);
            this.btnSave.Name = "btnSave";
            this.btnSave.SideColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(113)))));
            this.btnSave.Size = new System.Drawing.Size(150, 46);
            this.btnSave.TabIndex = 26;
            this.btnSave.ClickEvent += new System.EventHandler(this.btnSave_ClickEvent);
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
            // AddnViewClass
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "AddnViewClass";
            this.Size = new System.Drawing.Size(800, 580);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridAllClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSchoolLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picSchoolLogo;
        private System.Windows.Forms.Panel panel3;
        private Buttons.ButtonWithoutMenu btnSave;
        private System.Windows.Forms.TextBox _txtClassName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dGridAllClass;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateaddedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.BindingSource classBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
