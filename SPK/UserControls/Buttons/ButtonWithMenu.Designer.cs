namespace SPK.UserControls.Buttons
{
    partial class ButtonWithMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.imgLeft = new System.Windows.Forms.PictureBox();
            this.imgRight = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRight)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(113)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 50);
            this.panel1.TabIndex = 0;
            this.panel1.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(50, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imgLeft
            // 
            this.imgLeft.Image = global::SPK.Properties.Resources.icons8_person_64;
            this.imgLeft.Location = new System.Drawing.Point(7, 3);
            this.imgLeft.Name = "imgLeft";
            this.imgLeft.Size = new System.Drawing.Size(30, 44);
            this.imgLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLeft.TabIndex = 3;
            this.imgLeft.TabStop = false;
            // 
            // imgRight
            // 
            this.imgRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgRight.Image = global::SPK.Properties.Resources.icons8_menu_vertical_64;
            this.imgRight.Location = new System.Drawing.Point(166, 3);
            this.imgRight.Name = "imgRight";
            this.imgRight.Size = new System.Drawing.Size(30, 44);
            this.imgRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgRight.TabIndex = 2;
            this.imgRight.TabStop = false;
            // 
            // ButtonWithMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.imgLeft);
            this.Controls.Add(this.imgRight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ButtonWithMenu";
            this.Size = new System.Drawing.Size(200, 50);
            this.Load += new System.EventHandler(this.ButtonWithMenu_Load);
            this.Resize += new System.EventHandler(this.ButtonWithMenu_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.imgLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imgRight;
        private System.Windows.Forms.PictureBox imgLeft;
    }
}
