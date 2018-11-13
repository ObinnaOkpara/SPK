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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.schoolProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSchoolInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSchoolInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panContainer = new System.Windows.Forms.Panel();
            this.buttonWithMenu11 = new SPK.UserControls.Buttons.ButtonWithMenu();
            this.buttonWithMenu10 = new SPK.UserControls.Buttons.ButtonWithMenu();
            this.buttonWithMenu9 = new SPK.UserControls.Buttons.ButtonWithMenu();
            this.buttonWithMenu8 = new SPK.UserControls.Buttons.ButtonWithMenu();
            this.buttonWithMenu7 = new SPK.UserControls.Buttons.ButtonWithMenu();
            this.buttonWithMenu6 = new SPK.UserControls.Buttons.ButtonWithMenu();
            this.buttonWithMenu5 = new SPK.UserControls.Buttons.ButtonWithMenu();
            this.buttonWithMenu4 = new SPK.UserControls.Buttons.ButtonWithMenu();
            this.buttonWithMenu3 = new SPK.UserControls.Buttons.ButtonWithMenu();
            this.buttonWithMenu2 = new SPK.UserControls.Buttons.ButtonWithMenu();
            this.buttonWithoutMenu2 = new SPK.UserControls.Buttons.ButtonWithoutMenu();
            this.buttonWithoutMenu1 = new SPK.UserControls.Buttons.ButtonWithoutMenu();
            this.buttonWithMenu1 = new SPK.UserControls.Buttons.ButtonWithMenu();
            this.dashboard1 = new SPK.UserControls.SubForms.Dashboard();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimise)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panContainer.SuspendLayout();
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1416, 58);
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
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 57);
            this.panel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "School Portal Kit";
            // 
            // picClose
            // 
            this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClose.BackColor = System.Drawing.Color.Red;
            this.picClose.Image = global::SPK.Properties.Resources.close;
            this.picClose.Location = new System.Drawing.Point(1375, 9);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(30, 30);
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
            this.picMinimise.Location = new System.Drawing.Point(1339, 9);
            this.picMinimise.Name = "picMinimise";
            this.picMinimise.Size = new System.Drawing.Size(30, 30);
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
            this.panel3.Controls.Add(this.buttonWithMenu2);
            this.panel3.Controls.Add(this.buttonWithoutMenu2);
            this.panel3.Controls.Add(this.buttonWithoutMenu1);
            this.panel3.Controls.Add(this.buttonWithMenu1);
            this.panel3.Controls.Add(this.lblUserType);
            this.panel3.Controls.Add(this.lblUsername);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(3, 59);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(310, 785);
            this.panel3.TabIndex = 19;
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserType.Location = new System.Drawing.Point(71, 56);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(65, 24);
            this.lblUserType.TabIndex = 9;
            this.lblUserType.Text = "Admin";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(69, 25);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(120, 31);
            this.lblUsername.TabIndex = 8;
            this.lblUsername.Text = "SPK Guest";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SPK.Properties.Resources.icons8_circled_user_female_skin_type_6_96;
            this.pictureBox1.Location = new System.Drawing.Point(6, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schoolProfileToolStripMenuItem,
            this.saveSchoolInfoToolStripMenuItem,
            this.viewSchoolInfoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(190, 76);
            // 
            // schoolProfileToolStripMenuItem
            // 
            this.schoolProfileToolStripMenuItem.Name = "schoolProfileToolStripMenuItem";
            this.schoolProfileToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.schoolProfileToolStripMenuItem.Text = "School Profile";
            // 
            // saveSchoolInfoToolStripMenuItem
            // 
            this.saveSchoolInfoToolStripMenuItem.Name = "saveSchoolInfoToolStripMenuItem";
            this.saveSchoolInfoToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.saveSchoolInfoToolStripMenuItem.Text = "Save School Info";
            // 
            // viewSchoolInfoToolStripMenuItem
            // 
            this.viewSchoolInfoToolStripMenuItem.Name = "viewSchoolInfoToolStripMenuItem";
            this.viewSchoolInfoToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.viewSchoolInfoToolStripMenuItem.Text = "View School info";
            // 
            // panContainer
            // 
            this.panContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panContainer.Controls.Add(this.dashboard1);
            this.panContainer.Location = new System.Drawing.Point(316, 63);
            this.panContainer.Name = "panContainer";
            this.panContainer.Size = new System.Drawing.Size(1100, 780);
            this.panContainer.TabIndex = 20;
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
            this.buttonWithMenu11.Location = new System.Drawing.Point(0, 710);
            this.buttonWithMenu11.Name = "buttonWithMenu11";
            this.buttonWithMenu11.SideColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(113)))));
            this.buttonWithMenu11.Size = new System.Drawing.Size(310, 50);
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
            this.buttonWithMenu10.Location = new System.Drawing.Point(0, 660);
            this.buttonWithMenu10.Name = "buttonWithMenu10";
            this.buttonWithMenu10.SideColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(113)))));
            this.buttonWithMenu10.Size = new System.Drawing.Size(310, 50);
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
            this.buttonWithMenu9.Location = new System.Drawing.Point(0, 610);
            this.buttonWithMenu9.Name = "buttonWithMenu9";
            this.buttonWithMenu9.SideColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(113)))));
            this.buttonWithMenu9.Size = new System.Drawing.Size(310, 50);
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
            this.buttonWithMenu8.Location = new System.Drawing.Point(0, 560);
            this.buttonWithMenu8.Name = "buttonWithMenu8";
            this.buttonWithMenu8.SideColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(113)))));
            this.buttonWithMenu8.Size = new System.Drawing.Size(310, 50);
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
            this.buttonWithMenu7.Location = new System.Drawing.Point(0, 510);
            this.buttonWithMenu7.Name = "buttonWithMenu7";
            this.buttonWithMenu7.SideColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(113)))));
            this.buttonWithMenu7.Size = new System.Drawing.Size(310, 50);
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
            this.buttonWithMenu6.Location = new System.Drawing.Point(0, 460);
            this.buttonWithMenu6.Name = "buttonWithMenu6";
            this.buttonWithMenu6.SideColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(113)))));
            this.buttonWithMenu6.Size = new System.Drawing.Size(310, 50);
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
            this.buttonWithMenu5.Location = new System.Drawing.Point(0, 410);
            this.buttonWithMenu5.Name = "buttonWithMenu5";
            this.buttonWithMenu5.SideColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(113)))));
            this.buttonWithMenu5.Size = new System.Drawing.Size(310, 50);
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
            this.buttonWithMenu4.Location = new System.Drawing.Point(0, 360);
            this.buttonWithMenu4.Name = "buttonWithMenu4";
            this.buttonWithMenu4.SideColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(113)))));
            this.buttonWithMenu4.Size = new System.Drawing.Size(310, 50);
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
            this.buttonWithMenu3.Location = new System.Drawing.Point(0, 310);
            this.buttonWithMenu3.Name = "buttonWithMenu3";
            this.buttonWithMenu3.SideColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(113)))));
            this.buttonWithMenu3.Size = new System.Drawing.Size(310, 50);
            this.buttonWithMenu3.TabIndex = 15;
            this.buttonWithMenu3.ClickEvent += new System.EventHandler(this.buttonWithMenu3_Click);
            // 
            // buttonWithMenu2
            // 
            this.buttonWithMenu2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonWithMenu2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.buttonWithMenu2.BtnText = "Student Management";
            this.buttonWithMenu2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWithMenu2.ForeColor = System.Drawing.Color.White;
            this.buttonWithMenu2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(15)))), ((int)(((byte)(23)))));
            this.buttonWithMenu2.Icon = global::SPK.Properties.Resources.icons8_laptop_64;
            this.buttonWithMenu2.Location = new System.Drawing.Point(0, 260);
            this.buttonWithMenu2.Name = "buttonWithMenu2";
            this.buttonWithMenu2.SideColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(113)))));
            this.buttonWithMenu2.Size = new System.Drawing.Size(310, 50);
            this.buttonWithMenu2.TabIndex = 14;
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
            this.buttonWithoutMenu2.Location = new System.Drawing.Point(0, 160);
            this.buttonWithoutMenu2.Name = "buttonWithoutMenu2";
            this.buttonWithoutMenu2.SideColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(113)))));
            this.buttonWithoutMenu2.Size = new System.Drawing.Size(310, 50);
            this.buttonWithoutMenu2.TabIndex = 12;
            // 
            // buttonWithoutMenu1
            // 
            this.buttonWithoutMenu1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonWithoutMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.buttonWithoutMenu1.BtnText = "Dashboard";
            this.buttonWithoutMenu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWithoutMenu1.ForeColor = System.Drawing.Color.White;
            this.buttonWithoutMenu1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(15)))), ((int)(((byte)(23)))));
            this.buttonWithoutMenu1.Icon = global::SPK.Properties.Resources.icons8_dashboard_64;
            this.buttonWithoutMenu1.Location = new System.Drawing.Point(0, 110);
            this.buttonWithoutMenu1.Name = "buttonWithoutMenu1";
            this.buttonWithoutMenu1.SideColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(113)))));
            this.buttonWithoutMenu1.Size = new System.Drawing.Size(310, 50);
            this.buttonWithoutMenu1.TabIndex = 11;
            // 
            // buttonWithMenu1
            // 
            this.buttonWithMenu1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonWithMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.buttonWithMenu1.BtnText = "School Information";
            this.buttonWithMenu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWithMenu1.ForeColor = System.Drawing.Color.White;
            this.buttonWithMenu1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(15)))), ((int)(((byte)(23)))));
            this.buttonWithMenu1.Icon = global::SPK.Properties.Resources.icons8_laptop_64;
            this.buttonWithMenu1.Location = new System.Drawing.Point(0, 210);
            this.buttonWithMenu1.Name = "buttonWithMenu1";
            this.buttonWithMenu1.SideColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(113)))));
            this.buttonWithMenu1.Size = new System.Drawing.Size(310, 50);
            this.buttonWithMenu1.TabIndex = 10;
            // 
            // dashboard1
            // 
            this.dashboard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.dashboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboard1.Location = new System.Drawing.Point(0, 0);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.ProfilePic = null;
            this.dashboard1.School = "SCHOOL NAME";
            this.dashboard1.Session = "Third Term - 2017/2018 Session";
            this.dashboard1.Size = new System.Drawing.Size(1100, 780);
            this.dashboard1.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1421, 847);
            this.Controls.Add(this.panContainer);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
            this.contextMenuStrip1.ResumeLayout(false);
            this.panContainer.ResumeLayout(false);
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem schoolProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveSchoolInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSchoolInfoToolStripMenuItem;
        private UserControls.Buttons.ButtonWithMenu buttonWithMenu1;
        private UserControls.Buttons.ButtonWithoutMenu buttonWithoutMenu1;
        private UserControls.Buttons.ButtonWithoutMenu buttonWithoutMenu2;
        private UserControls.Buttons.ButtonWithMenu buttonWithMenu2;
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
        private UserControls.SubForms.Dashboard dashboard1;
    }
}

