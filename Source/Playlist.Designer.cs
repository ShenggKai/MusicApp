namespace MusicApp.Source
{
    partial class Playlist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Playlist));
            this.pnPlaylist = new Bunifu.UI.WinForms.BunifuPanel();
            this.txtPlaylist = new System.Windows.Forms.Label();
            this.pPlaylist = new System.Windows.Forms.PictureBox();
            this.pnPlaylist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pPlaylist)).BeginInit();
            this.SuspendLayout();
            // 
            // pnPlaylist
            // 
            this.pnPlaylist.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.pnPlaylist.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnPlaylist.BackgroundImage")));
            this.pnPlaylist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnPlaylist.BorderColor = System.Drawing.Color.Transparent;
            this.pnPlaylist.BorderRadius = 20;
            this.pnPlaylist.BorderThickness = 1;
            this.pnPlaylist.Controls.Add(this.txtPlaylist);
            this.pnPlaylist.Controls.Add(this.pPlaylist);
            this.pnPlaylist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPlaylist.Location = new System.Drawing.Point(0, 0);
            this.pnPlaylist.Margin = new System.Windows.Forms.Padding(0);
            this.pnPlaylist.Name = "pnPlaylist";
            this.pnPlaylist.ShowBorders = true;
            this.pnPlaylist.Size = new System.Drawing.Size(261, 292);
            this.pnPlaylist.TabIndex = 0;
            // 
            // txtPlaylist
            // 
            this.txtPlaylist.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPlaylist.ForeColor = System.Drawing.Color.White;
            this.txtPlaylist.Location = new System.Drawing.Point(0, 241);
            this.txtPlaylist.Name = "txtPlaylist";
            this.txtPlaylist.Size = new System.Drawing.Size(258, 28);
            this.txtPlaylist.TabIndex = 1;
            this.txtPlaylist.Text = "Danh sách phát số 1";
            this.txtPlaylist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pPlaylist
            // 
            this.pPlaylist.Image = global::MusicApp.Properties.Resources.music;
            this.pPlaylist.Location = new System.Drawing.Point(23, 0);
            this.pPlaylist.Name = "pPlaylist";
            this.pPlaylist.Size = new System.Drawing.Size(215, 215);
            this.pPlaylist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pPlaylist.TabIndex = 0;
            this.pPlaylist.TabStop = false;
            // 
            // Playlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnPlaylist);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(0, 0, 50, 60);
            this.Name = "Playlist";
            this.Size = new System.Drawing.Size(261, 292);
            this.pnPlaylist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pPlaylist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel pnPlaylist;
        private PictureBox pPlaylist;
        private Label txtPlaylist;
    }
}
