namespace MusicApp.Source
{
    partial class Genre
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
            this.sdPanel = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.lbGenre = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sdPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sdPanel
            // 
            this.sdPanel.BackColor = System.Drawing.Color.Transparent;
            this.sdPanel.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.sdPanel.BorderRadius = 10;
            this.sdPanel.BorderThickness = 0;
            this.sdPanel.Controls.Add(this.pictureBox1);
            this.sdPanel.Controls.Add(this.lbGenre);
            this.sdPanel.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.sdPanel.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.sdPanel.Location = new System.Drawing.Point(0, 0);
            this.sdPanel.Name = "sdPanel";
            this.sdPanel.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(172)))), ((int)(((byte)(172)))));
            this.sdPanel.PanelColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(172)))), ((int)(((byte)(172)))));
            this.sdPanel.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.sdPanel.ShadowDept = 2;
            this.sdPanel.ShadowDepth = 4;
            this.sdPanel.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.ForwardDiagonal;
            this.sdPanel.ShadowTopLeftVisible = false;
            this.sdPanel.Size = new System.Drawing.Size(261, 292);
            this.sdPanel.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.sdPanel.TabIndex = 1;
            // 
            // lbGenre
            // 
            this.lbGenre.Font = new System.Drawing.Font("Segoe UI Semibold", 15.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbGenre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lbGenre.Location = new System.Drawing.Point(0, 0);
            this.lbGenre.Name = "lbGenre";
            this.lbGenre.Size = new System.Drawing.Size(258, 52);
            this.lbGenre.TabIndex = 1;
            this.lbGenre.Text = "Nhạc Việt";
            this.lbGenre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MusicApp.Properties.Resources.HoaVangNayTan;
            this.pictureBox1.Location = new System.Drawing.Point(0, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 237);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Genre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.sdPanel);
            this.Name = "Genre";
            this.Size = new System.Drawing.Size(261, 292);
            this.sdPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuShadowPanel sdPanel;
        private Label lbGenre;
        private PictureBox pictureBox1;
    }
}
