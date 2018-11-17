namespace SPK.UserControls.SubForms
{
    partial class AddAdmin
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radMiss = new System.Windows.Forms.RadioButton();
            this.radMrs = new System.Windows.Forms.RadioButton();
            this.radMr = new System.Windows.Forms.RadioButton();
            this.cBoxCountry = new System.Windows.Forms.ComboBox();
            this.cBoxState = new System.Windows.Forms.ComboBox();
            this._txtEmail = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this._txtPassword = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this._txtPhone = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this._txtAddress = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this._txtLGA = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOthernames = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this._txtFirstname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._txtSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSave = new SPK.UserControls.Buttons.ButtonWithoutMenu();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSchoolLogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(1100, 130);
            this.panel1.TabIndex = 6;
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.Location = new System.Drawing.Point(107, 75);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(117, 17);
            this.lblSubTitle.TabIndex = 2;
            this.lblSubTitle.Text = "Add new admin";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(149, 38);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(262, 26);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "ADMIN MANAGEMENT";
            // 
            // picSchoolLogo
            // 
            this.picSchoolLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.picSchoolLogo.Image = global::SPK.Properties.Resources.Icons8_flat_businessman_svg;
            this.picSchoolLogo.Location = new System.Drawing.Point(108, 31);
            this.picSchoolLogo.Name = "picSchoolLogo";
            this.picSchoolLogo.Size = new System.Drawing.Size(40, 40);
            this.picSchoolLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSchoolLogo.TabIndex = 0;
            this.picSchoolLogo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(100, 137);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(907, 640);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.cBoxCountry);
            this.panel3.Controls.Add(this.cBoxState);
            this.panel3.Controls.Add(this._txtEmail);
            this.panel3.Controls.Add(this.label24);
            this.panel3.Controls.Add(this.txtConfirmPassword);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this._txtPassword);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this._txtPhone);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this._txtAddress);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this._txtLGA);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtOthernames);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this._txtFirstname);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this._txtSurname);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(23, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(834, 613);
            this.panel3.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radMiss);
            this.groupBox1.Controls.Add(this.radMrs);
            this.groupBox1.Controls.Add(this.radMr);
            this.groupBox1.Location = new System.Drawing.Point(32, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 56);
            this.groupBox1.TabIndex = 75;
            this.groupBox1.TabStop = false;
            // 
            // radMiss
            // 
            this.radMiss.AutoSize = true;
            this.radMiss.Location = new System.Drawing.Point(159, 20);
            this.radMiss.Name = "radMiss";
            this.radMiss.Size = new System.Drawing.Size(58, 21);
            this.radMiss.TabIndex = 76;
            this.radMiss.TabStop = true;
            this.radMiss.Text = "Miss";
            this.radMiss.UseVisualStyleBackColor = true;
            // 
            // radMrs
            // 
            this.radMrs.AutoSize = true;
            this.radMrs.Location = new System.Drawing.Point(80, 20);
            this.radMrs.Name = "radMrs";
            this.radMrs.Size = new System.Drawing.Size(52, 21);
            this.radMrs.TabIndex = 75;
            this.radMrs.TabStop = true;
            this.radMrs.Text = "Mrs";
            this.radMrs.UseVisualStyleBackColor = true;
            // 
            // radMr
            // 
            this.radMr.AutoSize = true;
            this.radMr.Location = new System.Drawing.Point(11, 20);
            this.radMr.Name = "radMr";
            this.radMr.Size = new System.Drawing.Size(44, 21);
            this.radMr.TabIndex = 74;
            this.radMr.TabStop = true;
            this.radMr.Text = "Mr";
            this.radMr.UseVisualStyleBackColor = true;
            // 
            // cBoxCountry
            // 
            this.cBoxCountry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBoxCountry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxCountry.FormattingEnabled = true;
            this.cBoxCountry.Items.AddRange(new object[] {
            "--Select--",
            "Other",
            "Botswana",
            "Cameroon",
            "Gambia",
            "Ghana",
            "Kenya",
            "Kingdom of eSwatini",
            "Lesotho",
            "Malawi",
            "Mauritius",
            "Mozambique",
            "Namibia",
            "Nigeria",
            "Rwanda",
            "Seychelles",
            "Sierra Leone",
            "South Africa",
            "Uganda",
            "United Republic of Tanzania",
            "Zambia",
            "Bangladesh",
            "Brunei Darussalam",
            "India",
            "Malaysia",
            "Pakistan",
            "Singapore",
            "Sri Lanka",
            "Antigua and Barbuda",
            "Bahamas, The",
            "Barbados",
            "Belize",
            "Canada",
            "Dominica",
            "Grenada",
            "Guyana",
            "Jamaica",
            "Saint Lucia",
            "St Kitts and Nevis",
            "St Vincent and The Grenadines",
            "Trinidad and Tobago",
            "Cyprus",
            "Malta",
            "UK",
            "USA",
            "Australia",
            "Fiji",
            "Kiribati",
            "Nauru",
            "New Zealand",
            "Papua New Guinea",
            "Samoa",
            "Solomon Islands",
            "Tonga",
            "Tuvalu",
            "Vanuatu"});
            this.cBoxCountry.Location = new System.Drawing.Point(13, 223);
            this.cBoxCountry.Name = "cBoxCountry";
            this.cBoxCountry.Size = new System.Drawing.Size(254, 24);
            this.cBoxCountry.TabIndex = 71;
            // 
            // cBoxState
            // 
            this.cBoxState.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBoxState.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxState.FormattingEnabled = true;
            this.cBoxState.Items.AddRange(new object[] {
            "--Select--",
            "Other",
            "Abia",
            "Adamawa",
            "Akwa Ibom",
            "Anambra",
            "Bauchi",
            "Bayelsa",
            "Benue",
            "Borno",
            "Cross River",
            "Delta",
            "Ebonyi",
            "Enugu",
            "Edo",
            "Ekiti",
            "Gombe",
            "Imo",
            "Jigawa",
            "Kaduna",
            "Kano",
            "Katsina",
            "Kebbi",
            "Kogi",
            "Kwara",
            "Lagos",
            "Nasarawa",
            "Niger",
            "Ogun",
            "Ondo",
            "Osun",
            "Oyo",
            "Plateau",
            "Rivers",
            "Sokoto",
            "Taraba",
            "Yobe",
            "Zamfara"});
            this.cBoxState.Location = new System.Drawing.Point(283, 223);
            this.cBoxState.Name = "cBoxState";
            this.cBoxState.Size = new System.Drawing.Size(254, 24);
            this.cBoxState.TabIndex = 71;
            // 
            // _txtEmail
            // 
            this._txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this._txtEmail.Location = new System.Drawing.Point(293, 361);
            this._txtEmail.Name = "_txtEmail";
            this._txtEmail.Size = new System.Drawing.Size(513, 23);
            this._txtEmail.TabIndex = 58;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label24.Location = new System.Drawing.Point(289, 338);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(47, 17);
            this.label24.TabIndex = 57;
            this.label24.Text = "Email";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtConfirmPassword.Location = new System.Drawing.Point(13, 510);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '#';
            this.txtConfirmPassword.Size = new System.Drawing.Size(376, 23);
            this.txtConfirmPassword.TabIndex = 38;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label16.Location = new System.Drawing.Point(9, 487);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(137, 17);
            this.label16.TabIndex = 37;
            this.label16.Text = "Confirm Password";
            // 
            // _txtPassword
            // 
            this._txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this._txtPassword.Location = new System.Drawing.Point(13, 434);
            this._txtPassword.Name = "_txtPassword";
            this._txtPassword.PasswordChar = '#';
            this._txtPassword.Size = new System.Drawing.Size(376, 23);
            this._txtPassword.TabIndex = 36;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label17.Location = new System.Drawing.Point(9, 411);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 17);
            this.label17.TabIndex = 35;
            this.label17.Text = "Password";
            // 
            // _txtPhone
            // 
            this._txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this._txtPhone.Location = new System.Drawing.Point(13, 361);
            this._txtPhone.Name = "_txtPhone";
            this._txtPhone.Size = new System.Drawing.Size(254, 23);
            this._txtPhone.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label13.Location = new System.Drawing.Point(9, 338);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 17);
            this.label13.TabIndex = 31;
            this.label13.Text = "Phone Number";
            // 
            // _txtAddress
            // 
            this._txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this._txtAddress.Location = new System.Drawing.Point(13, 290);
            this._txtAddress.Name = "_txtAddress";
            this._txtAddress.Size = new System.Drawing.Size(793, 23);
            this._txtAddress.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label14.Location = new System.Drawing.Point(9, 267);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 17);
            this.label14.TabIndex = 29;
            this.label14.Text = "Address";
            // 
            // _txtLGA
            // 
            this._txtLGA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtLGA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this._txtLGA.Location = new System.Drawing.Point(553, 223);
            this._txtLGA.Name = "_txtLGA";
            this._txtLGA.Size = new System.Drawing.Size(254, 23);
            this._txtLGA.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label10.Location = new System.Drawing.Point(549, 200);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 17);
            this.label10.TabIndex = 25;
            this.label10.Text = "LGA";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label11.Location = new System.Drawing.Point(279, 200);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "State";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label7.Location = new System.Drawing.Point(9, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Nationalty";
            // 
            // txtOthernames
            // 
            this.txtOthernames.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOthernames.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtOthernames.Location = new System.Drawing.Point(553, 156);
            this.txtOthernames.Name = "txtOthernames";
            this.txtOthernames.Size = new System.Drawing.Size(254, 23);
            this.txtOthernames.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label6.Location = new System.Drawing.Point(549, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Othername(s)";
            // 
            // _txtFirstname
            // 
            this._txtFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtFirstname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this._txtFirstname.Location = new System.Drawing.Point(283, 156);
            this._txtFirstname.Name = "_txtFirstname";
            this._txtFirstname.Size = new System.Drawing.Size(254, 23);
            this._txtFirstname.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label3.Location = new System.Drawing.Point(279, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Firstname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.label2.Location = new System.Drawing.Point(289, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Register New Admin";
            // 
            // _txtSurname
            // 
            this._txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this._txtSurname.Location = new System.Drawing.Point(13, 156);
            this._txtSurname.Name = "_txtSurname";
            this._txtSurname.Size = new System.Drawing.Size(254, 23);
            this._txtSurname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label1.Location = new System.Drawing.Point(9, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Surname";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.btnSave.BtnText = "SAVE CHANGES";
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(15)))), ((int)(((byte)(23)))));
            this.btnSave.Icon = global::SPK.Properties.Resources.icons8_save_64;
            this.btnSave.Location = new System.Drawing.Point(278, 550);
            this.btnSave.Name = "btnSave";
            this.btnSave.SideColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(113)))));
            this.btnSave.Size = new System.Drawing.Size(250, 50);
            this.btnSave.TabIndex = 11;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddAdmin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "AddAdmin";
            this.Size = new System.Drawing.Size(1100, 780);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSchoolLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picSchoolLogo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cBoxCountry;
        private System.Windows.Forms.ComboBox cBoxState;
        private System.Windows.Forms.TextBox _txtEmail;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox _txtPassword;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox _txtPhone;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox _txtAddress;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox _txtLGA;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOthernames;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox _txtFirstname;
        private Buttons.ButtonWithoutMenu btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _txtSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radMiss;
        private System.Windows.Forms.RadioButton radMrs;
        private System.Windows.Forms.RadioButton radMr;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
