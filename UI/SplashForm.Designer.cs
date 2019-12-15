namespace VenousPluck.UI
{
    partial class SplashForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashForm));
            this.splashPictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelBGBack = new System.Windows.Forms.Panel();
            this.panelBGFont = new System.Windows.Forms.Panel();
            this.timerSplash = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splashPictureBoxLogo)).BeginInit();
            this.panelBGBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // splashPictureBoxLogo
            // 
            this.splashPictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("splashPictureBoxLogo.Image")));
            this.splashPictureBoxLogo.Location = new System.Drawing.Point(302, 26);
            this.splashPictureBoxLogo.Name = "splashPictureBoxLogo";
            this.splashPictureBoxLogo.Size = new System.Drawing.Size(252, 237);
            this.splashPictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.splashPictureBoxLogo.TabIndex = 0;
            this.splashPictureBoxLogo.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(278, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(277, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Blood Bank Managment System";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(319, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 38);
            this.label3.TabIndex = 11;
            this.label3.Text = "Venous Pluck";
            // 
            // panelBGBack
            // 
            this.panelBGBack.BackColor = System.Drawing.Color.White;
            this.panelBGBack.Controls.Add(this.panelBGFont);
            this.panelBGBack.Location = new System.Drawing.Point(1, 399);
            this.panelBGBack.Name = "panelBGBack";
            this.panelBGBack.Size = new System.Drawing.Size(890, 59);
            this.panelBGBack.TabIndex = 12;
            // 
            // panelBGFont
            // 
            this.panelBGFont.BackColor = System.Drawing.Color.Tomato;
            this.panelBGFont.Location = new System.Drawing.Point(3, 8);
            this.panelBGFont.Name = "panelBGFont";
            this.panelBGFont.Size = new System.Drawing.Size(12, 48);
            this.panelBGFont.TabIndex = 13;
            // 
            // timerSplash
            // 
            this.timerSplash.Tick += new System.EventHandler(this.TimerSplash_Tick);
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(890, 516);
            this.Controls.Add(this.panelBGBack);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.splashPictureBoxLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashForm";
            this.Text = "SplashForm";
            this.Load += new System.EventHandler(this.SplashForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splashPictureBoxLogo)).EndInit();
            this.panelBGBack.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox splashPictureBoxLogo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelBGBack;
        private System.Windows.Forms.Panel panelBGFont;
        private System.Windows.Forms.Timer timerSplash;
    }
}