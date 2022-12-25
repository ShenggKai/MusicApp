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
            ((System.ComponentModel.ISupportInitialize)(this.pUser)).BeginInit();
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
            // Comment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Controls.Add(this.pUser);
            this.Name = "Comment";
            this.Size = new System.Drawing.Size(1176, 124);
            ((System.ComponentModel.ISupportInitialize)(this.pUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pUser;
    }
}
