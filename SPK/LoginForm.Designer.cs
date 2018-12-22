namespace SPK
{
    partial class LoginForm
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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cBoxType = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.picMinimise = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSignIn = new SPK.UserControls.Buttons.ButtonWithoutMenu();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimise)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtUsername.Location = new System.Drawing.Point(172, 47);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(220, 23);
            this.txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtPassword.Location = new System.Drawing.Point(172, 99);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(220, 23);
            this.txtPassword.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label1.Location = new System.Drawing.Point(110, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Email :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label2.Location = new System.Drawing.Point(79, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password :";
            // 
            // cBoxType
            // 
            this.cBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.cBoxType.FormattingEnabled = true;
            this.cBoxType.Items.AddRange(new object[] {
            "Admin",
            "Principal",
            "Teacher"});
            this.cBoxType.Location = new System.Drawing.Point(172, 152);
            this.cBoxType.Name = "cBoxType";
            this.cBoxType.Size = new System.Drawing.Size(220, 24);
            this.cBoxType.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.picClose);
            this.panel2.Controls.Add(this.picMinimise);
            this.panel2.Location = new System.Drawing.Point(2, 1);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(598, 42);
            this.panel2.TabIndex = 19;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(113)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(1, 1);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(232, 39);
            this.panel3.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "School Portal Kit";
            // 
            // picClose
            // 
            this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClose.BackColor = System.Drawing.Color.Red;
            this.picClose.Image = global::SPK.Properties.Resources.close;
            this.picClose.Location = new System.Drawing.Point(567, 8);
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
            this.picMinimise.Location = new System.Drawing.Point(540, 7);
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
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.btnSave);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.btnSignIn);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.cBoxType);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txtUsername);
            this.panel4.Controls.Add(this.txtPassword);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(69, 73);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(472, 270);
            this.panel4.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label5.Location = new System.Drawing.Point(73, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "User Type :";
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.btnSignIn.BtnText = "LOGIN";
            this.btnSignIn.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(15)))), ((int)(((byte)(23)))));
            this.btnSignIn.Icon = global::SPK.Properties.Resources.icons8_enter_64;
            this.btnSignIn.Location = new System.Drawing.Point(172, 217);
            this.btnSignIn.Margin = new System.Windows.Forms.Padding(2);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.SideColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(113)))));
            this.btnSignIn.Size = new System.Drawing.Size(145, 41);
            this.btnSignIn.TabIndex = 15;
            this.btnSignIn.ClickEvent += new System.EventHandler(this.btnSignIn_ClickEvent);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.label4.Location = new System.Drawing.Point(203, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "LOGIN";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnSave.Location = new System.Drawing.Point(336, 217);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 41);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(601, 389);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimise)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBoxType;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox picMinimise;
        private System.Windows.Forms.Panel panel4;
        private UserControls.Buttons.ButtonWithoutMenu btnSignIn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
    }
}