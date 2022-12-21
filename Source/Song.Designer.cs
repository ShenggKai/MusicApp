namespace MusicApp.Source
{
    partial class Song
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
            this.txtNum = new System.Windows.Forms.Label();
            this.pSong = new System.Windows.Forms.PictureBox();
            this.txtName = new System.Windows.Forms.Label();
            this.txtArtist = new System.Windows.Forms.Label();
            this.pInfor = new System.Windows.Forms.PictureBox();
            this.pHeart = new System.Windows.Forms.PictureBox();
            this.pDown = new System.Windows.Forms.PictureBox();
            this.txtTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pSong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pInfor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHeart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDown)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNum
            // 
            this.txtNum.Font = new System.Drawing.Font("Segoe UI", 19.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNum.ForeColor = System.Drawing.Color.White;
            this.txtNum.Location = new System.Drawing.Point(14, 25);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(39, 39);
            this.txtNum.TabIndex = 0;
            this.txtNum.Text = "1";
            this.txtNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pSong
            // 
            this.pSong.Image = global::MusicApp.Properties.Resources.srltdln1;
            this.pSong.Location = new System.Drawing.Point(88, 10);
            this.pSong.Name = "pSong";
            this.pSong.Size = new System.Drawing.Size(70, 70);
            this.pSong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pSong.TabIndex = 1;
            this.pSong.TabStop = false;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(202, 23);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(308, 28);
            this.txtName.TabIndex = 2;
            this.txtName.Text = "Sinh Ra Đã Là Thứ Đối Lập Nhau";
            // 
            // txtArtist
            // 
            this.txtArtist.ForeColor = System.Drawing.Color.White;
            this.txtArtist.Location = new System.Drawing.Point(202, 55);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.Size = new System.Drawing.Size(126, 18);
            this.txtArtist.TabIndex = 3;
            this.txtArtist.Text = "Emcee L, Badbies";
            // 
            // pInfor
            // 
            this.pInfor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pInfor.Image = global::MusicApp.Properties.Resources.info;
            this.pInfor.Location = new System.Drawing.Point(1037, 28);
            this.pInfor.Margin = new System.Windows.Forms.Padding(0);
            this.pInfor.Name = "pInfor";
            this.pInfor.Size = new System.Drawing.Size(35, 35);
            this.pInfor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pInfor.TabIndex = 4;
            this.pInfor.TabStop = false;
            // 
            // pHeart
            // 
            this.pHeart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pHeart.Image = global::MusicApp.Properties.Resources.heart_white;
            this.pHeart.Location = new System.Drawing.Point(1202, 28);
            this.pHeart.Margin = new System.Windows.Forms.Padding(0);
            this.pHeart.Name = "pHeart";
            this.pHeart.Size = new System.Drawing.Size(35, 35);
            this.pHeart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pHeart.TabIndex = 4;
            this.pHeart.TabStop = false;
            // 
            // pDown
            // 
            this.pDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pDown.Image = global::MusicApp.Properties.Resources.download;
            this.pDown.Location = new System.Drawing.Point(1367, 28);
            this.pDown.Margin = new System.Windows.Forms.Padding(0);
            this.pDown.Name = "pDown";
            this.pDown.Size = new System.Drawing.Size(35, 35);
            this.pDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pDown.TabIndex = 4;
            this.pDown.TabStop = false;
            // 
            // txtTime
            // 
            this.txtTime.AutoSize = true;
            this.txtTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTime.ForeColor = System.Drawing.Color.White;
            this.txtTime.Location = new System.Drawing.Point(1532, 33);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(60, 28);
            this.txtTime.TabIndex = 5;
            this.txtTime.Text = "03:54";
            this.txtTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Song
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.pDown);
            this.Controls.Add(this.pHeart);
            this.Controls.Add(this.pInfor);
            this.Controls.Add(this.txtArtist);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.pSong);
            this.Controls.Add(this.txtNum);
            this.Name = "Song";
            this.Size = new System.Drawing.Size(1610, 90);
            ((System.ComponentModel.ISupportInitialize)(this.pSong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pInfor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHeart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label txtNum;
        private PictureBox pSong;
        private Label txtName;
        private Label txtArtist;
        private PictureBox pInfor;
        private PictureBox pHeart;
        private PictureBox pDown;
        private Label txtTime;
    }
}
