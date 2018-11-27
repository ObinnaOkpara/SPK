namespace SPK
{
    partial class frmMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.picMinimise = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblUserType = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panContainer = new System.Windows.Forms.Panel();
            this.MenuSchoolInfo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateSchoolInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentTermAndSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAttendance1 = new SPK.UserControls.SubForms.ViewAttendance();
            this.buttonWithMenu11 = new SPK.UserControls.Buttons.ButtonWithMenu();
            this.buttonWithMenu10 = new SPK.UserControls.Buttons.ButtonWithMenu();
            this.buttonWithMenu9 = new SPK.UserControls.Buttons.ButtonWithMenu();
            this.buttonWithMenu8 = new SPK.UserControls.Buttons.ButtonWithMenu();
            this.buttonWithMenu7 = new SPK.UserControls.Buttons.ButtonWithMenu();
            this.buttonWithMenu6 = new SPK.UserControls.Buttons.ButtonWithMenu();
            this.buttonWithMenu5 = new SPK.UserControls.Buttons.ButtonWithMenu();
            this.buttonWithMenu4 = new SPK.UserControls.Buttons.ButtonWithMenu();
            this.buttonWithMenu3 = new SPK.UserControls.Buttons.ButtonWithMenu();
            this.btnStudents = new SPK.UserControls.Buttons.ButtonWithMenu();
            this.buttonWithoutMenu2 = new SPK.UserControls.Buttons.ButtonWithoutMenu();
            this.btnDashboard = new SPK.UserControls.Buttons.ButtonWithoutMenu();
            this.btnSchInfo = new SPK.UserControls.Buttons.ButtonWithMenu();
            this.menuStudents = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimise)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panContainer.SuspendLayout();
            this.MenuSchoolInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.picClose);
            this.panel1.Controls.Add(this.picMinimise);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1035, 47);
            this.panel1.TabIndex = 18;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(113)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 46);
            this.panel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "School Portal Kit";
            // 
            // picClose
            // 
            this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClose.BackColor = System.Drawing.Color.Red;
            this.picClose.Image = global::SPK.Properties.Resources.close;
            this.picClose.Location = new System.Drawing.Point(1002, 10);
            this.picClose.Margin = new System.Windows.Forms.Padding(2);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(22, 24);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picClose.TabIndex = 2;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            this.picClose.MouseLeave += new System.EventHandler(this.picClose_MouseLeave);
            this.picClose.MouseHover += new System.EventHandler(this.picClose_MouseHover);
            // 
            // picMinimise
            // 
            this.picMinimise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMinimise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.picMinimise.Image = global::SPK.Properties.Resources.minimise;
            this.picMinimise.Location = new System.Drawing.Point(975, 9);
            this.picMinimise.Margin = new System.Windows.Forms.Padding(2);
            this.picMinimise.Name = "picMinimise";
            this.picMinimise.Size = new System.Drawing.Size(22, 24);
            this.picMinimise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMinimise.TabIndex = 5;
            this.picMinimise.TabStop = false;
            this.picMinimise.Click += new System.EventHandler(this.picMinimise_Click);
            this.picMinimise.MouseLeave += new System.EventHandler(this.picMinimise_MouseLeave);
            this.picMinimise.MouseHover += new System.EventHandler(this.picMinimise_MouseHover);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.panel3.Controls.Add(this.buttonWithMenu11);
            this.panel3.Controls.Add(this.buttonWithMenu10);
            this.panel3.Controls.Add(this.buttonWithMenu9);
            this.panel3.Controls.Add(this.buttonWithMenu8);
            this.panel3.Controls.Add(this.buttonWithMenu7);
            this.panel3.Controls.Add(this.buttonWithMenu6);
            this.panel3.Controls.Add(this.buttonWithMenu5);
            this.panel3.Controls.Add(this.buttonWithMenu4);
            this.panel3.Controls.Add(this.buttonWithMenu3);
            this.panel3.Controls.Add(this.btnStudents);
            this.panel3.Controls.Add(this.buttonWithoutMenu2);
            this.panel3.Controls.Add(this.btnDashboard);
            this.panel3.Controls.Add(this.btnSchInfo);
            this.panel3.Controls.Add(this.lblUserType);
            this.panel3.Controls.Add(this.lblUsername);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(2, 48);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(232, 590);
            this.panel3.TabIndex = 19;
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserType.Location = new System.Drawing.Point(53, 31);
            this.lblUserType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(50, 19);
            this.lblUserType.TabIndex = 9;
            this.lblUserType.Text = "Admin";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(52, 5);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(95, 24);
            this.lblUsername.TabIndex = 8;
            this.lblUsername.Text = "SPK Guest";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SPK.Properties.Resources.icons8_circled_user_female_skin_type_6_96;
            this.pictureBox1.Location = new System.Drawing.Point(4, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panContainer
            // 
            this.panContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panContainer.Controls.Add(this.viewAttendance1);
            this.panContainer.Location = new System.Drawing.Point(237, 53);
            this.panContainer.Margin = new System.Windows.Forms.Padding(2);
            this.panContainer.Name = "panContainer";
            this.panContainer.Size = new System.Drawing.Size(800, 580);
            this.panContainer.TabIndex = 20;
            // 
            // MenuSchoolInfo
            // 
            this.MenuSchoolInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.MenuSchoolInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.MenuSchoolInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateSchoolInfoToolStripMenuItem,
            this.currentTermAndSessionToolStripMenuItem,
            this.addNewSessionToolStripMenuItem});
            this.MenuSchoolInfo.Name = "MenuSchoolInfo";
            this.MenuSchoolInfo.ShowImageMargin = false;
            this.MenuSchoolInfo.Size = new System.Drawing.Size(192, 70);
            // 
            // updateSchoolInfoToolStripMenuItem
            // 
            this.updateSchoolInfoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.updateSchoolInfoToolStripMenuItem.Name = "updateSchoolInfoToolStripMenuItem";
            this.updateSchoolInfoToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.updateSchoolInfoToolStripMenuItem.Text = "Update School Info";
            this.updateSchoolInfoToolStripMenuItem.Click += new System.EventHandler(this.updateSchoolInfoToolStripMenuItem_Click);
            // 
            // currentTermAndSessionToolStripMenuItem
            // 
            this.currentTermAndSessionToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.currentTermAndSessionToolStripMenuItem.Name = "currentTermAndSessionToolStripMenuItem";
            this.currentTermAndSessionToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.currentTermAndSessionToolStripMenuItem.Text = "Current Term and Session";
            this.currentTermAndSessionToolStripMenuItem.Click += new System.EventHandler(this.currentTermAndSessionToolStripMenuItem_Click);
            // 
            // addNewSessionToolStripMenuItem
            // 
            this.addNewSessionToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addNewSessionToolStripMenuItem.Name = "addNewSessionToolStripMenuItem";
            this.addNewSessionToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.addNewSessionToolStripMenuItem.Text = "Add New Session";
            this.addNewSessionToolStripMenuItem.Click += new System.EventHandler(this.addNewSessionToolStripMenuItem_Click);
            // 
            // viewAttendance1
            // 
            this.viewAttendance1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.viewAttendance1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewAttendance1.Location = new System.Drawing.Point(0, 0);
            this.viewAttendance1.Name = "viewAttendance1";
            this.viewAttendance1.Size = new System.Drawing.Size(800, 580);
            this.viewAttendance1.TabIndex = 0;
            // 
            // buttonWithMenu11
            // 
            this.buttonWithMenu11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonWithMenu11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.buttonWithMenu11.BtnText = "Teachers";
            this.buttonWithMenu11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWithMenu11.ForeColor = System.Drawing.Color.White;
            this.buttonWithMenu11.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(15)))), ((int)(((byte)(23)))));
            this.buttonWithMenu11.Icon = global::SPK.Properties.Resources.icons8_person_64;
            this.buttonWithMenu11.Location = new System.Drawing.Point(0, 544);
            this.buttonWithMenu11.Margin = new System.Windows.Forms.Padding(2);
            this.buttonWithMenu11.Name = "buttonWithMenu11";
            this.buttonWithMenu11.SideColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(113)))));
            this.buttonWithMenu11.Size = new System.Drawing.Size(232, 41);
            this.buttonWithMenu11.TabIndex = 23;
            // 
            // buttonWithMenu10
            // 
            this.buttonWithMenu10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonWithMenu10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.buttonWithMenu10.BtnText = "Principal";
            this.buttonWithMenu10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWithMenu10.ForeColor = System.Drawing.Color.White;
            this.buttonWithMenu10.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(15)))), ((int)(((byte)(23)))));
            this.buttonWithMenu10.Icon = global::SPK.Properties.Resources.icons8_person_64;
            this.buttonWithMenu10.Location = new System.Drawing.Point(0, 503);
            this.buttonWithMenu10.Margin = new System.Windows.Forms.Padding(2);
            this.buttonWithMenu10.Name = "buttonWithMenu10";
            this.buttonWithMenu10.SideColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(113)))));
            this.buttonWithMenu10.Size = new System.Drawing.Size(232, 41);
            this.buttonWithMenu10.TabIndex = 22;
            // 
            // buttonWithMenu9
            // 
            this.buttonWithMenu9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonWithMenu9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.buttonWithMenu9.BtnText = "Admin";
            this.buttonWithMenu9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWithMenu9.ForeColor = System.Drawing.Color.White;
            this.buttonWithMenu9.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(15)))), ((int)(((byte)(23)))));
            this.buttonWithMenu9.Icon = global::SPK.Properties.Resources.icons8_person_64;
            this.buttonWithMenu9.Location = new System.Drawing.Point(0, 463);
            this.buttonWithMenu9.Margin = new System.Windows.Forms.Padding(2);
            this.buttonWithMenu9.Name = "buttonWithMenu9";
            this.buttonWithMenu9.SideColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(113)))));
            this.buttonWithMenu9.Size = new System.Drawing.Size(232, 41);
            this.buttonWithMenu9.TabIndex = 21;
            // 
            // buttonWithMenu8
            // 
            this.buttonWithMenu8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonWithMenu8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.buttonWithMenu8.BtnText = "Fees Management";
            this.buttonWithMenu8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWithMenu8.ForeColor = System.Drawing.Color.White;
            this.buttonWithMenu8.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(15)))), ((int)(((byte)(23)))));
            this.buttonWithMenu8.Icon = global::SPK.Properties.Resources.icons8_money_64;
            this.buttonWithMenu8.Location = new System.Drawing.Point(0, 422);
            this.buttonWithMenu8.Margin = new System.Windows.Forms.Padding(2);
            this.buttonWithMenu8.Name = "buttonWithMenu8";
            this.buttonWithMenu8.SideColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(113)))));
            this.buttonWithMenu8.Size = new System.Drawing.Size(232, 41);
            this.buttonWithMenu8.TabIndex = 20;
            // 
            // buttonWithMenu7
            // 
            this.buttonWithMenu7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonWithMenu7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.buttonWithMenu7.BtnText = "Result Management";
            this.buttonWithMenu7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWithMenu7.ForeColor = System.Drawing.Color.White;
            this.buttonWithMenu7.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(15)))), ((int)(((byte)(23)))));
            this.buttonWithMenu7.Icon = global::SPK.Properties.Resources.icons8_book_52;
            this.buttonWithMenu7.Location = new System.Drawing.Point(0, 381);
            this.buttonWithMenu7.Margin = new System.Windows.Forms.Padding(2);
            this.buttonWithMenu7.Name = "buttonWithMenu7";
            this.buttonWithMenu7.SideColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(113)))));
            this.buttonWithMenu7.Size = new System.Drawing.Size(232, 41);
            this.buttonWithMenu7.TabIndex = 19;
            // 
            // buttonWithMenu6
            // 
            this.buttonWithMenu6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonWithMenu6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.buttonWithMenu6.BtnText = "Subject Management";
            this.buttonWithMenu6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWithMenu6.ForeColor = System.Drawing.Color.White;
            this.buttonWithMenu6.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(15)))), ((int)(((byte)(23)))));
            this.buttonWithMenu6.Icon = global::SPK.Properties.Resources.icons8_file_64;
            this.buttonWithMenu6.Location = new System.Drawing.Point(0, 341);
            this.buttonWithMenu6.Margin = new System.Windows.Forms.Padding(2);
            this.buttonWithMenu6.Name = "buttonWithMenu6";
            this.buttonWithMenu6.SideColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(113)))));
            this.buttonWithMenu6.Size = new System.Drawing.Size(232, 41);
            this.buttonWithMenu6.TabIndex = 18;
            // 
            // buttonWithMenu5
            // 
            this.buttonWithMenu5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonWithMenu5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.buttonWithMenu5.BtnText = "Class Management";
            this.buttonWithMenu5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWithMenu5.ForeColor = System.Drawing.Color.White;
            this.buttonWithMenu5.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(15)))), ((int)(((byte)(23)))));
            this.buttonWithMenu5.Icon = global::SPK.Properties.Resources.icons8_people_64;
            this.buttonWithMenu5.Location = new System.Drawing.Point(0, 300);
            this.buttonWithMenu5.Margin = new System.Windows.Forms.Padding(2);
            this.buttonWithMenu5.Name = "buttonWithMenu5";
            this.buttonWithMenu5.SideColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(113)))));
            this.buttonWithMenu5.Size = new System.Drawing.Size(232, 41);
            this.buttonWithMenu5.TabIndex = 17;
            // 
            // buttonWithMenu4
            // 
            this.buttonWithMenu4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonWithMenu4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.buttonWithMenu4.BtnText = "Behavioural Analysis";
            this.buttonWithMenu4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWithMenu4.ForeColor = System.Drawing.Color.White;
            this.buttonWithMenu4.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(15)))), ((int)(((byte)(23)))));
            this.buttonWithMenu4.Icon = global::SPK.Properties.Resources.icons8_edit_64;
            this.buttonWithMenu4.Location = new System.Drawing.Point(0, 259);
            this.buttonWithMenu4.Margin = new System.Windows.Forms.Padding(2);
            this.buttonWithMenu4.Name = "buttonWithMenu4";
            this.buttonWithMenu4.SideColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(113)))));
            this.buttonWithMenu4.Size = new System.Drawing.Size(232, 41);
            this.buttonWithMenu4.TabIndex = 16;
            // 
            // buttonWithMenu3
            // 
            this.buttonWithMenu3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonWithMenu3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.buttonWithMenu3.BtnText = "Attendance Manager";
            this.buttonWithMenu3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWithMenu3.ForeColor = System.Drawing.Color.White;
            this.buttonWithMenu3.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(15)))), ((int)(((byte)(23)))));
            this.buttonWithMenu3.Icon = global::SPK.Properties.Resources.icons8_todo_list_64;
            this.buttonWithMenu3.Location = new System.Drawing.Point(0, 219);
            this.buttonWithMenu3.Margin = new System.Windows.Forms.Padding(2);
            this.buttonWithMenu3.Name = "buttonWithMenu3";
            this.buttonWithMenu3.SideColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(113)))));
            this.buttonWithMenu3.Size = new System.Drawing.Size(232, 41);
            this.buttonWithMenu3.TabIndex = 15;
            // 
            // btnStudents
            // 
            this.btnStudents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.btnStudents.BtnText = "Student Management";
            this.btnStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudents.ForeColor = System.Drawing.Color.White;
            this.btnStudents.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(15)))), ((int)(((byte)(23)))));
            this.btnStudents.Icon = global::SPK.Properties.Resources.icons8_laptop_64;
            this.btnStudents.Location = new System.Drawing.Point(0, 178);
            this.btnStudents.Margin = new System.Windows.Forms.Padding(2);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.SideColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(113)))));
            this.btnStudents.Size = new System.Drawing.Size(232, 41);
            this.btnStudents.TabIndex = 14;
            // 
            // buttonWithoutMenu2
            // 
            this.buttonWithoutMenu2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonWithoutMenu2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.buttonWithoutMenu2.BtnText = "Profile";
            this.buttonWithoutMenu2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWithoutMenu2.ForeColor = System.Drawing.Color.White;
            this.buttonWithoutMenu2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(15)))), ((int)(((byte)(23)))));
            this.buttonWithoutMenu2.Icon = global::SPK.Properties.Resources.icons8_person_64;
            this.buttonWithoutMenu2.Location = new System.Drawing.Point(0, 97);
            this.buttonWithoutMenu2.Margin = new System.Windows.Forms.Padding(2);
            this.buttonWithoutMenu2.Name = "buttonWithoutMenu2";
            this.buttonWithoutMenu2.SideColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(113)))));
            this.buttonWithoutMenu2.Size = new System.Drawing.Size(232, 41);
            this.buttonWithoutMenu2.TabIndex = 12;
            // 
            // btnDashboard
            // 
            this.btnDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.btnDashboard.BtnText = "Dashboard";
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(15)))), ((int)(((byte)(23)))));
            this.btnDashboard.Icon = global::SPK.Properties.Resources.icons8_dashboard_64;
            this.btnDashboard.Location = new System.Drawing.Point(0, 56);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(2);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.SideColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(113)))));
            this.btnDashboard.Size = new System.Drawing.Size(232, 41);
            this.btnDashboard.TabIndex = 11;
            this.btnDashboard.ClickEvent += new System.EventHandler(this.btnDashboard_ClickEvent);
            // 
            // btnSchInfo
            // 
            this.btnSchInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSchInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.btnSchInfo.BtnText = "School Information";
            this.btnSchInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchInfo.ForeColor = System.Drawing.Color.White;
            this.btnSchInfo.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(15)))), ((int)(((byte)(23)))));
            this.btnSchInfo.Icon = global::SPK.Properties.Resources.icons8_laptop_64;
            this.btnSchInfo.Location = new System.Drawing.Point(0, 138);
            this.btnSchInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btnSchInfo.Name = "btnSchInfo";
            this.btnSchInfo.SideColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(113)))));
            this.btnSchInfo.Size = new System.Drawing.Size(232, 41);
            this.btnSchInfo.TabIndex = 10;
            this.btnSchInfo.ClickEvent += new System.EventHandler(this.btnSchInfo_ClickEvent);
            // 
            // menuStudents
            // 
            this.menuStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.menuStudents.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuStudents.Name = "menuStudents";
            this.menuStudents.ShowImageMargin = false;
            this.menuStudents.Size = new System.Drawing.Size(156, 26);
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1040, 640);
            this.Controls.Add(this.panContainer);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimise)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panContainer.ResumeLayout(false);
            this.MenuSchoolInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox picMinimise;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUserType;
        private UserControls.Buttons.ButtonWithMenu btnSchInfo;
        private UserControls.Buttons.ButtonWithoutMenu btnDashboard;
        private UserControls.Buttons.ButtonWithoutMenu buttonWithoutMenu2;
        private UserControls.Buttons.ButtonWithMenu btnStudents;
        private UserControls.Buttons.ButtonWithMenu buttonWithMenu3;
        private UserControls.Buttons.ButtonWithMenu buttonWithMenu4;
        private UserControls.Buttons.ButtonWithMenu buttonWithMenu5;
        private UserControls.Buttons.ButtonWithMenu buttonWithMenu7;
        private UserControls.Buttons.ButtonWithMenu buttonWithMenu6;
        private UserControls.Buttons.ButtonWithMenu buttonWithMenu11;
        private UserControls.Buttons.ButtonWithMenu buttonWithMenu10;
        private UserControls.Buttons.ButtonWithMenu buttonWithMenu9;
        private UserControls.Buttons.ButtonWithMenu buttonWithMenu8;
        private System.Windows.Forms.Panel panContainer;
        private UserControls.SubForms.ViewAttendance viewAttendance1;
        private System.Windows.Forms.ContextMenuStrip MenuSchoolInfo;
        private System.Windows.Forms.ToolStripMenuItem updateSchoolInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentTermAndSessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewSessionToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip menuStudents;
    }
}

