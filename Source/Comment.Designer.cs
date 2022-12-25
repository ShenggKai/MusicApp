namespace MusicApp.Source
{
    partial class Comment
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
            this.pUser = new System.Windows.Forms.PictureBox();
            this.txtUserName = new System.Windows.Forms.Label();
            this.txtCmt = new System.Windows.Forms.Label();
            this.bunifuRating1 = new Bunifu.UI.WinForms.BunifuRating();
            this.txtTime = new System.Windows.Forms.Label();
            this.pLike = new System.Windows.Forms.PictureBox();
            this.pUnlike = new System.Windows.Forms.PictureBox();
            this.pTrash = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLike)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUnlike)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pTrash)).BeginInit();
            this.SuspendLayout();
            // 
            // pUser
            // 
            this.pUser.Image = global::MusicApp.Properties.Resources.user;
            this.pUser.Location = new System.Drawing.Point(25, 12);
            this.pUser.Name = "pUser";
            this.pUser.Size = new System.Drawing.Size(100, 100);
            this.pUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pUser.TabIndex = 0;
            this.pUser.TabStop = false;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUserName.ForeColor = System.Drawing.Color.White;
            this.txtUserName.Location = new System.Drawing.Point(151, 12);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(129, 33);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.Text = "ShengKai";
            // 
            // txtCmt
            // 
            this.txtCmt.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCmt.ForeColor = System.Drawing.Color.White;
            this.txtCmt.Location = new System.Drawing.Point(151, 62);
            this.txtCmt.Name = "txtCmt";
            this.txtCmt.Size = new System.Drawing.Size(393, 33);
            this.txtCmt.TabIndex = 1;
            this.txtCmt.Text = "Bài hát hay";
            // 
            // bunifuRating1
            // 
            this.bunifuRating1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuRating1.DisabledEmptyFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.bunifuRating1.DisabledRatedFillColor = System.Drawing.Color.DarkGray;
            this.bunifuRating1.EmptyBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.bunifuRating1.EmptyFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.bunifuRating1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bunifuRating1.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.bunifuRating1.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.bunifuRating1.InnerRadius = 2F;
            this.bunifuRating1.Location = new System.Drawing.Point(299, 20);
            this.bunifuRating1.Name = "bunifuRating1";
            this.bunifuRating1.OuterRadius = 10F;
            this.bunifuRating1.RatedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.bunifuRating1.RatedFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.bunifuRating1.ReadOnly = false;
            this.bunifuRating1.RightClickToClear = true;
            this.bunifuRating1.Size = new System.Drawing.Size(151, 22);
            this.bunifuRating1.Spacing = 10;
            this.bunifuRating1.TabIndex = 2;
            this.bunifuRating1.Text = "bunifuRating1";
            this.bunifuRating1.Value = 3;
            // 
            // txtTime
            // 
            this.txtTime.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTime.ForeColor = System.Drawing.Color.White;
            this.txtTime.Location = new System.Drawing.Point(490, 12);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(243, 33);
            this.txtTime.TabIndex = 1;
            this.txtTime.Text = "22:22, 22/12/2022";
            // 
            // pLike
            // 
            this.pLike.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pLike.Image = global::MusicApp.Properties.Resources.like;
            this.pLike.Location = new System.Drawing.Point(822, 45);
            this.pLike.Name = "pLike";
            this.pLike.Size = new System.Drawing.Size(35, 35);
            this.pLike.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pLike.TabIndex = 3;
            this.pLike.TabStop = false;
            this.pLike.MouseLeave += new System.EventHandler(this.pLike_MouseLeave);
            this.pLike.MouseHover += new System.EventHandler(this.pLike_MouseHover);
            // 
            // pUnlike
            // 
            this.pUnlike.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pUnlike.Image = global::MusicApp.Properties.Resources.unlike;
            this.pUnlike.Location = new System.Drawing.Point(952, 45);
            this.pUnlike.Name = "pUnlike";
            this.pUnlike.Size = new System.Drawing.Size(35, 35);
            this.pUnlike.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pUnlike.TabIndex = 3;
            this.pUnlike.TabStop = false;
            // 
            // pTrash
            // 
            this.pTrash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pTrash.Image = global::MusicApp.Properties.Resources.trash;
            this.pTrash.Location = new System.Drawing.Point(1082, 45);
            this.pTrash.Name = "pTrash";
            this.pTrash.Size = new System.Drawing.Size(35, 35);
            this.pTrash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pTrash.TabIndex = 3;
            this.pTrash.TabStop = false;
            // 
            // Comment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Controls.Add(this.pTrash);
            this.Controls.Add(this.pUnlike);
            this.Controls.Add(this.pLike);
            this.Controls.Add(this.bunifuRating1);
            this.Controls.Add(this.txtCmt);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.pUser);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Comment";
            this.Size = new System.Drawing.Size(1170, 124);
            this.Load += new System.EventHandler(this.Comment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLike)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pUnlike)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pTrash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pUser;
        private Label txtUserName;
        private Label txtCmt;
        private Bunifu.UI.WinForms.BunifuRating bunifuRating1;
        private Label txtTime;
        private PictureBox pLike;
        private PictureBox pUnlike;
        private PictureBox pTrash;
    }
}
