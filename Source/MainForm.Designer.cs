namespace MusicApp.Source
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lbHistory = new System.Windows.Forms.Label();
            this.fpnHistory = new System.Windows.Forms.FlowLayoutPanel();
            this.lbSongs = new System.Windows.Forms.Label();
            this.fpnSongs = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lbHistory
            // 
            this.lbHistory.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbHistory.ForeColor = System.Drawing.Color.White;
            this.lbHistory.Location = new System.Drawing.Point(45, 20);
            this.lbHistory.Name = "lbHistory";
            this.lbHistory.Size = new System.Drawing.Size(252, 36);
            this.lbHistory.TabIndex = 1;
            this.lbHistory.Text = "Mới phát gần đây";
            this.lbHistory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fpnHistory
            // 
            this.fpnHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.fpnHistory.Location = new System.Drawing.Point(80, 81);
            this.fpnHistory.Name = "fpnHistory";
            this.fpnHistory.Size = new System.Drawing.Size(1505, 293);
            this.fpnHistory.TabIndex = 3;
            // 
            // lbSongs
            // 
            this.lbSongs.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSongs.ForeColor = System.Drawing.Color.White;
            this.lbSongs.Location = new System.Drawing.Point(45, 449);
            this.lbSongs.Name = "lbSongs";
            this.lbSongs.Size = new System.Drawing.Size(107, 36);
            this.lbSongs.TabIndex = 4;
            this.lbSongs.Text = "Bài hát";
            this.lbSongs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fpnSongs
            // 
            this.fpnSongs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.fpnSongs.Location = new System.Drawing.Point(80, 502);
            this.fpnSongs.Name = "fpnSongs";
            this.fpnSongs.Size = new System.Drawing.Size(1505, 360);
            this.fpnSongs.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(1635, 918);
            this.Controls.Add(this.fpnSongs);
            this.Controls.Add(this.lbSongs);
            this.Controls.Add(this.fpnHistory);
            this.Controls.Add(this.lbHistory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private Label lbHistory;
        private FlowLayoutPanel fpnHistory;
        private Label lbSongs;
        private FlowLayoutPanel fpnSongs;
    }
}