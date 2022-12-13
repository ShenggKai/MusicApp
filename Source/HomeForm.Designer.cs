﻿namespace MusicApp
{
    partial class HomeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        // Auto click button 'Trang Chu' when the form start
        protected override void OnShown(EventArgs e)
        {
            //base.OnShown(e);
            //this.btnHome_Click(null, null);
            btnHome.PerformClick();
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.pnPlay = new System.Windows.Forms.Panel();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.btnCollection = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.lbLogo = new System.Windows.Forms.Label();
            this.pnMain = new System.Windows.Forms.Panel();
            this.pnMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnPlay
            // 
            this.pnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.pnPlay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnPlay.Location = new System.Drawing.Point(0, 878);
            this.pnPlay.Name = "pnPlay";
            this.pnPlay.Size = new System.Drawing.Size(1896, 135);
            this.pnPlay.TabIndex = 0;
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnMenu.Controls.Add(this.btnCollection);
            this.pnMenu.Controls.Add(this.btnFind);
            this.pnMenu.Controls.Add(this.btnHome);
            this.pnMenu.Controls.Add(this.lbLogo);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(272, 878);
            this.pnMenu.TabIndex = 1;
            // 
            // btnCollection
            // 
            this.btnCollection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCollection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCollection.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCollection.FlatAppearance.BorderSize = 0;
            this.btnCollection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCollection.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCollection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.btnCollection.Image = global::MusicApp.Properties.Resources.folder;
            this.btnCollection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCollection.Location = new System.Drawing.Point(0, 246);
            this.btnCollection.Name = "btnCollection";
            this.btnCollection.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnCollection.Size = new System.Drawing.Size(272, 80);
            this.btnCollection.TabIndex = 3;
            this.btnCollection.Text = " Thư Viện";
            this.btnCollection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCollection.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCollection.UseVisualStyleBackColor = false;
            this.btnCollection.Click += new System.EventHandler(this.btnCollection_Click);
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFind.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFind.FlatAppearance.BorderSize = 0;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.btnFind.Image = global::MusicApp.Properties.Resources.search;
            this.btnFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFind.Location = new System.Drawing.Point(0, 166);
            this.btnFind.Name = "btnFind";
            this.btnFind.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnFind.Size = new System.Drawing.Size(272, 80);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = " Tìm Kiếm";
            this.btnFind.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.btnHome.Image = global::MusicApp.Properties.Resources.home;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 86);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(272, 80);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = " Trang Chủ";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lbLogo
            // 
            this.lbLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbLogo.Font = new System.Drawing.Font("Cascadia Mono", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.lbLogo.Location = new System.Drawing.Point(0, 0);
            this.lbLogo.Name = "lbLogo";
            this.lbLogo.Size = new System.Drawing.Size(272, 86);
            this.lbLogo.TabIndex = 0;
            this.lbLogo.Text = "MusicApp";
            this.lbLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.Transparent;
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(272, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1624, 878);
            this.pnMain.TabIndex = 2;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1896, 1013);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.pnMenu);
            this.Controls.Add(this.pnPlay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusicApp";
            this.pnMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnPlay;
        private Panel pnMenu;
        private Panel pnMain;
        private Label lbLogo;
        private Button btnHome;
        private Button btnCollection;
        private Button btnFind;
    }
}