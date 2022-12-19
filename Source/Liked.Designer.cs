namespace MusicApp.Source
{
    partial class Liked
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Liked));
            this.panelLiked = new Bunifu.UI.WinForms.BunifuPanel();
            this.lbLiked = new System.Windows.Forms.Label();
            this.pHeart = new System.Windows.Forms.PictureBox();
            this.panelLiked.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pHeart)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLiked
            // 
            this.panelLiked.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.panelLiked.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLiked.BackgroundImage")));
            this.panelLiked.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLiked.BorderColor = System.Drawing.Color.Transparent;
            this.panelLiked.BorderRadius = 20;
            this.panelLiked.BorderThickness = 1;
            this.panelLiked.Controls.Add(this.lbLiked);
            this.panelLiked.Controls.Add(this.pHeart);
            this.panelLiked.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLiked.Location = new System.Drawing.Point(0, 0);
            this.panelLiked.Margin = new System.Windows.Forms.Padding(0);
            this.panelLiked.Name = "panelLiked";
            this.panelLiked.ShowBorders = true;
            this.panelLiked.Size = new System.Drawing.Size(261, 292);
            this.panelLiked.TabIndex = 0;
            // 
            // lbLiked
            // 
            this.lbLiked.Font = new System.Drawing.Font("Segoe UI Semibold", 14.4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbLiked.ForeColor = System.Drawing.Color.White;
            this.lbLiked.Location = new System.Drawing.Point(3, 199);
            this.lbLiked.Name = "lbLiked";
            this.lbLiked.Size = new System.Drawing.Size(255, 44);
            this.lbLiked.TabIndex = 1;
            this.lbLiked.Text = "Bài hát đã thích";
            this.lbLiked.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pHeart
            // 
            this.pHeart.Image = global::MusicApp.Properties.Resources.green_love;
            this.pHeart.Location = new System.Drawing.Point(76, 65);
            this.pHeart.Name = "pHeart";
            this.pHeart.Size = new System.Drawing.Size(110, 110);
            this.pHeart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pHeart.TabIndex = 0;
            this.pHeart.TabStop = false;
            // 
            // Liked
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelLiked);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(0, 0, 50, 60);
            this.Name = "Liked";
            this.Size = new System.Drawing.Size(261, 292);
            this.panelLiked.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pHeart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel panelLiked;
        private PictureBox pHeart;
        private Label lbLiked;
    }
}
