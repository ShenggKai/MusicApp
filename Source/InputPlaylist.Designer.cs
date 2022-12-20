namespace MusicApp.Source
{
    partial class InputPlaylist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputPlaylist));
            this.pnPlaylist = new Bunifu.UI.WinForms.BunifuPanel();
            this.txtAdd = new System.Windows.Forms.Label();
            this.btnClose = new Bunifu.UI.WinForms.BunifuImageButton();
            this.pnLine = new System.Windows.Forms.Panel();
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.pnPlaylist.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnPlaylist
            // 
            this.pnPlaylist.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.pnPlaylist.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnPlaylist.BackgroundImage")));
            this.pnPlaylist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnPlaylist.BorderColor = System.Drawing.Color.Transparent;
            this.pnPlaylist.BorderRadius = 30;
            this.pnPlaylist.BorderThickness = 1;
            this.pnPlaylist.Controls.Add(this.txtboxName);
            this.pnPlaylist.Controls.Add(this.pnLine);
            this.pnPlaylist.Controls.Add(this.txtAdd);
            this.pnPlaylist.Controls.Add(this.btnClose);
            this.pnPlaylist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPlaylist.Location = new System.Drawing.Point(0, 0);
            this.pnPlaylist.Margin = new System.Windows.Forms.Padding(0);
            this.pnPlaylist.Name = "pnPlaylist";
            this.pnPlaylist.ShowBorders = true;
            this.pnPlaylist.Size = new System.Drawing.Size(474, 273);
            this.pnPlaylist.TabIndex = 1;
            // 
            // txtAdd
            // 
            this.txtAdd.BackColor = System.Drawing.Color.Transparent;
            this.txtAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtAdd.ForeColor = System.Drawing.Color.White;
            this.txtAdd.Location = new System.Drawing.Point(132, 20);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(227, 38);
            this.txtAdd.TabIndex = 1;
            this.txtAdd.Text = "Tạo playlist mới";
            this.txtAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnClose
            // 
            this.btnClose.ActiveImage = null;
            this.btnClose.AllowAnimations = true;
            this.btnClose.AllowBuffering = false;
            this.btnClose.AllowToggling = false;
            this.btnClose.AllowZooming = true;
            this.btnClose.AllowZoomingOnFocus = false;
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClose.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnClose.ErrorImage")));
            this.btnClose.FadeWhenInactive = false;
            this.btnClose.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnClose.Image = global::MusicApp.Properties.Resources.close;
            this.btnClose.ImageActive = null;
            this.btnClose.ImageLocation = null;
            this.btnClose.ImageMargin = 0;
            this.btnClose.ImageSize = new System.Drawing.Size(21, 21);
            this.btnClose.ImageZoomSize = new System.Drawing.Size(22, 22);
            this.btnClose.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.btnClose.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnClose.InitialImage")));
            this.btnClose.Location = new System.Drawing.Point(432, 20);
            this.btnClose.Name = "btnClose";
            this.btnClose.Rotation = 0;
            this.btnClose.ShowActiveImage = true;
            this.btnClose.ShowCursorChanges = true;
            this.btnClose.ShowImageBorders = true;
            this.btnClose.ShowSizeMarkers = false;
            this.btnClose.Size = new System.Drawing.Size(22, 22);
            this.btnClose.TabIndex = 0;
            this.btnClose.ToolTipText = "";
            this.btnClose.WaitOnLoad = false;
            this.btnClose.Zoom = 0;
            this.btnClose.ZoomSpeed = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnLine
            // 
            this.pnLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.pnLine.Location = new System.Drawing.Point(42, 132);
            this.pnLine.Name = "pnLine";
            this.pnLine.Size = new System.Drawing.Size(390, 1);
            this.pnLine.TabIndex = 2;
            // 
            // txtboxName
            // 
            this.txtboxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.txtboxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtboxName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.txtboxName.Location = new System.Drawing.Point(42, 97);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.PlaceholderText = "Nhập tên Playlist";
            this.txtboxName.Size = new System.Drawing.Size(390, 32);
            this.txtboxName.TabIndex = 3;
            // 
            // InputPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(474, 273);
            this.Controls.Add(this.pnPlaylist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InputPlaylist";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tạo playlist mới";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.pnPlaylist.ResumeLayout(false);
            this.pnPlaylist.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuPanel pnPlaylist;
        private Bunifu.UI.WinForms.BunifuImageButton btnClose;
        private Label txtAdd;
        private Panel pnLine;
        private TextBox txtboxName;
    }
}