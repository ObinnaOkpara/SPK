namespace SPK.UserControls.Buttons
{
    partial class ButtonWithoutMenu
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
            this.imgLeft = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panTop = new SPK.UserControls.Panels.ExtendedPanel();
            ((System.ComponentModel.ISupportInitialize)(this.imgLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // imgLeft
            // 
            this.imgLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.imgLeft.Image = global::SPK.Properties.Resources.icons8_person_64;
            this.imgLeft.Location = new System.Drawing.Point(9, 3);
            this.imgLeft.Name = "imgLeft";
            this.imgLeft.Size = new System.Drawing.Size(30, 44);
            this.imgLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLeft.TabIndex = 7;
            this.imgLeft.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(52, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 44);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(113)))));
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 50);
            this.panel1.TabIndex = 4;
            this.panel1.Visible = false;
            // 
            // panTop
            // 
            this.panTop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panTop.Location = new System.Drawing.Point(1, 1);
            this.panTop.Name = "panTop";
            this.panTop.Size = new System.Drawing.Size(198, 48);
            this.panTop.TabIndex = 8;
            this.panTop.Click += new System.EventHandler(this.panTop_Click);
            this.panTop.MouseLeave += new System.EventHandler(this.panTop_MouseLeave);
            this.panTop.MouseHover += new System.EventHandler(this.panTop_MouseHover);
            // 
            // ButtonWithoutMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.panTop);
            this.Controls.Add(this.imgLeft);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ButtonWithoutMenu";
            this.Size = new System.Drawing.Size(200, 50);
            this.Load += new System.EventHandler(this.ButtonWithoutMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgLeft)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgLeft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Panels.ExtendedPanel panTop;
    }
}
