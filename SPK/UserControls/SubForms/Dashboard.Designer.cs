namespace SPK.UserControls.SubForms
{
    partial class Dashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.picSchoolLogo = new System.Windows.Forms.PictureBox();
            this.lblSchool = new System.Windows.Forms.Label();
            this.lblTermNSession = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSchoolLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTermNSession);
            this.panel1.Controls.Add(this.lblSchool);
            this.panel1.Controls.Add(this.picSchoolLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1295, 168);
            this.panel1.TabIndex = 0;
            // 
            // picSchoolLogo
            // 
            this.picSchoolLogo.Location = new System.Drawing.Point(68, 9);
            this.picSchoolLogo.Name = "picSchoolLogo";
            this.picSchoolLogo.Size = new System.Drawing.Size(150, 150);
            this.picSchoolLogo.TabIndex = 0;
            this.picSchoolLogo.TabStop = false;
            // 
            // lblSchool
            // 
            this.lblSchool.AutoSize = true;
            this.lblSchool.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchool.Location = new System.Drawing.Point(259, 67);
            this.lblSchool.Name = "lblSchool";
            this.lblSchool.Size = new System.Drawing.Size(108, 34);
            this.lblSchool.TabIndex = 1;
            this.lblSchool.Text = "label1";
            // 
            // lblTermNSession
            // 
            this.lblTermNSession.AutoSize = true;
            this.lblTermNSession.Font = new System.Drawing.Font("Lucida Sans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTermNSession.Location = new System.Drawing.Point(334, 136);
            this.lblTermNSession.Name = "lblTermNSession";
            this.lblTermNSession.Size = new System.Drawing.Size(62, 19);
            this.lblTermNSession.TabIndex = 2;
            this.lblTermNSession.Text = "label2";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel2.Location = new System.Drawing.Point(31, 174);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1251, 591);
            this.panel2.TabIndex = 1;
            // 
            // Dashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(1295, 765);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSchoolLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTermNSession;
        private System.Windows.Forms.Label lblSchool;
        private System.Windows.Forms.PictureBox picSchoolLogo;
        private System.Windows.Forms.Panel panel2;
    }
}
