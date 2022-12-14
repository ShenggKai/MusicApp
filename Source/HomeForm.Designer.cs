﻿using System.ComponentModel;

namespace MusicApp
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
        //protected override void OnShown(EventArgs e)
        //{
        //    //base.OnShown(e);
        //    //this.btnHome_Click(null, null);
        //    btnHome.PerformClick();
        //}

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            this.pnPlay = new System.Windows.Forms.Panel();
            this.btnOther = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnVolume = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnLyric = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnHeart = new Bunifu.UI.WinForms.BunifuImageButton();
            this.lbTimeEnd = new System.Windows.Forms.Label();
            this.lbTimeStart = new System.Windows.Forms.Label();
            this.lbArtist = new System.Windows.Forms.Label();
            this.lbSongName = new System.Windows.Forms.Label();
            this.pSong = new System.Windows.Forms.PictureBox();
            this.btnShuffle = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnRepeat = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnNext = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnPrevious = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnPlay = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnSlider = new Bunifu.UI.WinForms.BunifuHSlider();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.btnCollection = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.lbLogo = new System.Windows.Forms.Label();
            this.pageMain = new Bunifu.UI.WinForms.BunifuPages();
            this.pageHome = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMore1 = new System.Windows.Forms.Button();
            this.fpnSongs = new System.Windows.Forms.FlowLayoutPanel();
            this.lbSongs = new System.Windows.Forms.Label();
            this.fpnHistory = new System.Windows.Forms.FlowLayoutPanel();
            this.lbHistory = new System.Windows.Forms.Label();
            this.pageFind = new System.Windows.Forms.TabPage();
            this.pageCollection = new System.Windows.Forms.TabPage();
            this.pnPlay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pSong)).BeginInit();
            this.pnMenu.SuspendLayout();
            this.pageMain.SuspendLayout();
            this.pageHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnPlay
            // 
            this.pnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.pnPlay.Controls.Add(this.btnOther);
            this.pnPlay.Controls.Add(this.btnVolume);
            this.pnPlay.Controls.Add(this.btnLyric);
            this.pnPlay.Controls.Add(this.btnHeart);
            this.pnPlay.Controls.Add(this.lbTimeEnd);
            this.pnPlay.Controls.Add(this.lbTimeStart);
            this.pnPlay.Controls.Add(this.lbArtist);
            this.pnPlay.Controls.Add(this.lbSongName);
            this.pnPlay.Controls.Add(this.pSong);
            this.pnPlay.Controls.Add(this.btnShuffle);
            this.pnPlay.Controls.Add(this.btnRepeat);
            this.pnPlay.Controls.Add(this.btnNext);
            this.pnPlay.Controls.Add(this.btnPrevious);
            this.pnPlay.Controls.Add(this.btnPlay);
            this.pnPlay.Controls.Add(this.btnSlider);
            this.pnPlay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnPlay.Location = new System.Drawing.Point(0, 920);
            this.pnPlay.Name = "pnPlay";
            this.pnPlay.Size = new System.Drawing.Size(1896, 135);
            this.pnPlay.TabIndex = 0;
            // 
            // btnOther
            // 
            this.btnOther.ActiveImage = null;
            this.btnOther.AllowAnimations = true;
            this.btnOther.AllowBuffering = false;
            this.btnOther.AllowToggling = false;
            this.btnOther.AllowZooming = true;
            this.btnOther.AllowZoomingOnFocus = false;
            this.btnOther.BackColor = System.Drawing.Color.Transparent;
            this.btnOther.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnOther.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnOther.ErrorImage")));
            this.btnOther.FadeWhenInactive = false;
            this.btnOther.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnOther.Image = global::MusicApp.Properties.Resources.dots_gray;
            this.btnOther.ImageActive = null;
            this.btnOther.ImageLocation = null;
            this.btnOther.ImageMargin = 0;
            this.btnOther.ImageSize = new System.Drawing.Size(39, 39);
            this.btnOther.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.btnOther.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnOther.InitialImage")));
            this.btnOther.Location = new System.Drawing.Point(1814, 48);
            this.btnOther.Name = "btnOther";
            this.btnOther.Rotation = 0;
            this.btnOther.ShowActiveImage = true;
            this.btnOther.ShowCursorChanges = true;
            this.btnOther.ShowImageBorders = true;
            this.btnOther.ShowSizeMarkers = false;
            this.btnOther.Size = new System.Drawing.Size(40, 40);
            this.btnOther.TabIndex = 14;
            this.btnOther.ToolTipText = "Khác";
            this.btnOther.WaitOnLoad = false;
            this.btnOther.Zoom = 0;
            this.btnOther.ZoomSpeed = 10;
            this.btnOther.MouseLeave += new System.EventHandler(this.btnOther_MouseLeave);
            this.btnOther.MouseHover += new System.EventHandler(this.btnOther_MouseHover);
            // 
            // btnVolume
            // 
            this.btnVolume.ActiveImage = null;
            this.btnVolume.AllowAnimations = true;
            this.btnVolume.AllowBuffering = false;
            this.btnVolume.AllowToggling = false;
            this.btnVolume.AllowZooming = true;
            this.btnVolume.AllowZoomingOnFocus = false;
            this.btnVolume.BackColor = System.Drawing.Color.Transparent;
            this.btnVolume.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnVolume.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnVolume.ErrorImage")));
            this.btnVolume.FadeWhenInactive = false;
            this.btnVolume.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnVolume.Image = global::MusicApp.Properties.Resources.volume_gray;
            this.btnVolume.ImageActive = null;
            this.btnVolume.ImageLocation = null;
            this.btnVolume.ImageMargin = 0;
            this.btnVolume.ImageSize = new System.Drawing.Size(39, 39);
            this.btnVolume.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.btnVolume.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnVolume.InitialImage")));
            this.btnVolume.Location = new System.Drawing.Point(1714, 48);
            this.btnVolume.Name = "btnVolume";
            this.btnVolume.Rotation = 0;
            this.btnVolume.ShowActiveImage = true;
            this.btnVolume.ShowCursorChanges = true;
            this.btnVolume.ShowImageBorders = true;
            this.btnVolume.ShowSizeMarkers = false;
            this.btnVolume.Size = new System.Drawing.Size(40, 40);
            this.btnVolume.TabIndex = 13;
            this.btnVolume.ToolTipText = "Tắt âm";
            this.btnVolume.WaitOnLoad = false;
            this.btnVolume.Zoom = 0;
            this.btnVolume.ZoomSpeed = 10;
            this.btnVolume.MouseLeave += new System.EventHandler(this.btnVolume_MouseLeave);
            this.btnVolume.MouseHover += new System.EventHandler(this.btnVolume_MouseHover);
            // 
            // btnLyric
            // 
            this.btnLyric.ActiveImage = null;
            this.btnLyric.AllowAnimations = true;
            this.btnLyric.AllowBuffering = false;
            this.btnLyric.AllowToggling = false;
            this.btnLyric.AllowZooming = true;
            this.btnLyric.AllowZoomingOnFocus = false;
            this.btnLyric.BackColor = System.Drawing.Color.Transparent;
            this.btnLyric.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLyric.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnLyric.ErrorImage")));
            this.btnLyric.FadeWhenInactive = false;
            this.btnLyric.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnLyric.Image = global::MusicApp.Properties.Resources.lyric_gray;
            this.btnLyric.ImageActive = null;
            this.btnLyric.ImageLocation = null;
            this.btnLyric.ImageMargin = 0;
            this.btnLyric.ImageSize = new System.Drawing.Size(39, 39);
            this.btnLyric.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.btnLyric.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnLyric.InitialImage")));
            this.btnLyric.Location = new System.Drawing.Point(1614, 48);
            this.btnLyric.Name = "btnLyric";
            this.btnLyric.Rotation = 0;
            this.btnLyric.ShowActiveImage = true;
            this.btnLyric.ShowCursorChanges = true;
            this.btnLyric.ShowImageBorders = true;
            this.btnLyric.ShowSizeMarkers = false;
            this.btnLyric.Size = new System.Drawing.Size(40, 40);
            this.btnLyric.TabIndex = 12;
            this.btnLyric.ToolTipText = "Xem lời bài hát";
            this.btnLyric.WaitOnLoad = false;
            this.btnLyric.Zoom = 0;
            this.btnLyric.ZoomSpeed = 10;
            this.btnLyric.MouseLeave += new System.EventHandler(this.btnLyric_MouseLeave);
            this.btnLyric.MouseHover += new System.EventHandler(this.btnLyric_MouseHover);
            // 
            // btnHeart
            // 
            this.btnHeart.ActiveImage = null;
            this.btnHeart.AllowAnimations = true;
            this.btnHeart.AllowBuffering = false;
            this.btnHeart.AllowToggling = false;
            this.btnHeart.AllowZooming = true;
            this.btnHeart.AllowZoomingOnFocus = false;
            this.btnHeart.BackColor = System.Drawing.Color.Transparent;
            this.btnHeart.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnHeart.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnHeart.ErrorImage")));
            this.btnHeart.FadeWhenInactive = false;
            this.btnHeart.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnHeart.Image = global::MusicApp.Properties.Resources.heart_gray;
            this.btnHeart.ImageActive = null;
            this.btnHeart.ImageLocation = null;
            this.btnHeart.ImageMargin = 0;
            this.btnHeart.ImageSize = new System.Drawing.Size(39, 39);
            this.btnHeart.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.btnHeart.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnHeart.InitialImage")));
            this.btnHeart.Location = new System.Drawing.Point(1514, 48);
            this.btnHeart.Name = "btnHeart";
            this.btnHeart.Rotation = 0;
            this.btnHeart.ShowActiveImage = true;
            this.btnHeart.ShowCursorChanges = true;
            this.btnHeart.ShowImageBorders = true;
            this.btnHeart.ShowSizeMarkers = false;
            this.btnHeart.Size = new System.Drawing.Size(40, 40);
            this.btnHeart.TabIndex = 11;
            this.btnHeart.ToolTipText = "Thêm vào yêu thích";
            this.btnHeart.WaitOnLoad = false;
            this.btnHeart.Zoom = 0;
            this.btnHeart.ZoomSpeed = 10;
            this.btnHeart.Click += new System.EventHandler(this.btnHeart_Click);
            this.btnHeart.MouseLeave += new System.EventHandler(this.btnHeart_MouseLeave);
            this.btnHeart.MouseHover += new System.EventHandler(this.btnHeart_MouseHover);
            // 
            // lbTimeEnd
            // 
            this.lbTimeEnd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTimeEnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.lbTimeEnd.Location = new System.Drawing.Point(1277, 86);
            this.lbTimeEnd.Name = "lbTimeEnd";
            this.lbTimeEnd.Size = new System.Drawing.Size(49, 24);
            this.lbTimeEnd.TabIndex = 10;
            this.lbTimeEnd.Text = "4:50";
            this.lbTimeEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTimeStart
            // 
            this.lbTimeStart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTimeStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.lbTimeStart.Location = new System.Drawing.Point(581, 86);
            this.lbTimeStart.Name = "lbTimeStart";
            this.lbTimeStart.Size = new System.Drawing.Size(49, 24);
            this.lbTimeStart.TabIndex = 9;
            this.lbTimeStart.Text = "0:30";
            this.lbTimeStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbArtist
            // 
            this.lbArtist.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbArtist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.lbArtist.Location = new System.Drawing.Point(135, 79);
            this.lbArtist.Name = "lbArtist";
            this.lbArtist.Size = new System.Drawing.Size(168, 24);
            this.lbArtist.TabIndex = 8;
            this.lbArtist.Text = "Emcee L, Badbies";
            this.lbArtist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSongName
            // 
            this.lbSongName.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSongName.ForeColor = System.Drawing.Color.White;
            this.lbSongName.Location = new System.Drawing.Point(135, 33);
            this.lbSongName.Name = "lbSongName";
            this.lbSongName.Size = new System.Drawing.Size(430, 34);
            this.lbSongName.TabIndex = 7;
            this.lbSongName.Text = "Sinh Ra Đã Là Thứ Đối Lập Nhau";
            this.lbSongName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pSong
            // 
            this.pSong.Image = global::MusicApp.Properties.Resources.srltdln;
            this.pSong.Location = new System.Drawing.Point(20, 18);
            this.pSong.Name = "pSong";
            this.pSong.Size = new System.Drawing.Size(100, 100);
            this.pSong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pSong.TabIndex = 6;
            this.pSong.TabStop = false;
            // 
            // btnShuffle
            // 
            this.btnShuffle.ActiveImage = null;
            this.btnShuffle.AllowAnimations = true;
            this.btnShuffle.AllowBuffering = false;
            this.btnShuffle.AllowToggling = false;
            this.btnShuffle.AllowZooming = true;
            this.btnShuffle.AllowZoomingOnFocus = false;
            this.btnShuffle.BackColor = System.Drawing.Color.Transparent;
            this.btnShuffle.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnShuffle.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnShuffle.ErrorImage")));
            this.btnShuffle.FadeWhenInactive = false;
            this.btnShuffle.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnShuffle.Image = global::MusicApp.Properties.Resources.shuffle_gray;
            this.btnShuffle.ImageActive = null;
            this.btnShuffle.ImageLocation = null;
            this.btnShuffle.ImageMargin = 0;
            this.btnShuffle.ImageSize = new System.Drawing.Size(44, 44);
            this.btnShuffle.ImageZoomSize = new System.Drawing.Size(45, 45);
            this.btnShuffle.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnShuffle.InitialImage")));
            this.btnShuffle.Location = new System.Drawing.Point(723, 26);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Rotation = 0;
            this.btnShuffle.ShowActiveImage = true;
            this.btnShuffle.ShowCursorChanges = true;
            this.btnShuffle.ShowImageBorders = true;
            this.btnShuffle.ShowSizeMarkers = false;
            this.btnShuffle.Size = new System.Drawing.Size(45, 45);
            this.btnShuffle.TabIndex = 5;
            this.btnShuffle.ToolTipText = "Bật/tắt trộn bài";
            this.btnShuffle.WaitOnLoad = false;
            this.btnShuffle.Zoom = 0;
            this.btnShuffle.ZoomSpeed = 10;
            this.btnShuffle.MouseLeave += new System.EventHandler(this.btnShuffle_MouseLeave);
            this.btnShuffle.MouseHover += new System.EventHandler(this.btnShuffle_MouseHover);
            // 
            // btnRepeat
            // 
            this.btnRepeat.ActiveImage = null;
            this.btnRepeat.AllowAnimations = true;
            this.btnRepeat.AllowBuffering = false;
            this.btnRepeat.AllowToggling = false;
            this.btnRepeat.AllowZooming = true;
            this.btnRepeat.AllowZoomingOnFocus = false;
            this.btnRepeat.BackColor = System.Drawing.Color.Transparent;
            this.btnRepeat.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRepeat.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnRepeat.ErrorImage")));
            this.btnRepeat.FadeWhenInactive = false;
            this.btnRepeat.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnRepeat.Image = global::MusicApp.Properties.Resources.repeat_gray;
            this.btnRepeat.ImageActive = null;
            this.btnRepeat.ImageLocation = null;
            this.btnRepeat.ImageMargin = 0;
            this.btnRepeat.ImageSize = new System.Drawing.Size(44, 44);
            this.btnRepeat.ImageZoomSize = new System.Drawing.Size(45, 45);
            this.btnRepeat.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnRepeat.InitialImage")));
            this.btnRepeat.Location = new System.Drawing.Point(1133, 26);
            this.btnRepeat.Name = "btnRepeat";
            this.btnRepeat.Rotation = 0;
            this.btnRepeat.ShowActiveImage = true;
            this.btnRepeat.ShowCursorChanges = true;
            this.btnRepeat.ShowImageBorders = true;
            this.btnRepeat.ShowSizeMarkers = false;
            this.btnRepeat.Size = new System.Drawing.Size(45, 45);
            this.btnRepeat.TabIndex = 4;
            this.btnRepeat.ToolTipText = "Kích hoạt phát lại";
            this.btnRepeat.WaitOnLoad = false;
            this.btnRepeat.Zoom = 0;
            this.btnRepeat.ZoomSpeed = 10;
            this.btnRepeat.MouseLeave += new System.EventHandler(this.btnRepeat_MouseLeave);
            this.btnRepeat.MouseHover += new System.EventHandler(this.btnRepeat_MouseHover);
            // 
            // btnNext
            // 
            this.btnNext.ActiveImage = null;
            this.btnNext.AllowAnimations = true;
            this.btnNext.AllowBuffering = false;
            this.btnNext.AllowToggling = false;
            this.btnNext.AllowZooming = true;
            this.btnNext.AllowZoomingOnFocus = false;
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNext.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnNext.ErrorImage")));
            this.btnNext.FadeWhenInactive = false;
            this.btnNext.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnNext.Image = global::MusicApp.Properties.Resources.right_gray;
            this.btnNext.ImageActive = null;
            this.btnNext.ImageLocation = null;
            this.btnNext.ImageMargin = 0;
            this.btnNext.ImageSize = new System.Drawing.Size(44, 44);
            this.btnNext.ImageZoomSize = new System.Drawing.Size(45, 45);
            this.btnNext.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnNext.InitialImage")));
            this.btnNext.Location = new System.Drawing.Point(1033, 26);
            this.btnNext.Name = "btnNext";
            this.btnNext.Rotation = 0;
            this.btnNext.ShowActiveImage = true;
            this.btnNext.ShowCursorChanges = true;
            this.btnNext.ShowImageBorders = true;
            this.btnNext.ShowSizeMarkers = false;
            this.btnNext.Size = new System.Drawing.Size(45, 45);
            this.btnNext.TabIndex = 3;
            this.btnNext.ToolTipText = "";
            this.btnNext.WaitOnLoad = false;
            this.btnNext.Zoom = 0;
            this.btnNext.ZoomSpeed = 10;
            this.btnNext.MouseLeave += new System.EventHandler(this.btnNext_MouseLeave);
            this.btnNext.MouseHover += new System.EventHandler(this.btnNext_MouseHover);
            // 
            // btnPrevious
            // 
            this.btnPrevious.ActiveImage = null;
            this.btnPrevious.AllowAnimations = true;
            this.btnPrevious.AllowBuffering = false;
            this.btnPrevious.AllowToggling = false;
            this.btnPrevious.AllowZooming = true;
            this.btnPrevious.AllowZoomingOnFocus = false;
            this.btnPrevious.BackColor = System.Drawing.Color.Transparent;
            this.btnPrevious.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPrevious.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnPrevious.ErrorImage")));
            this.btnPrevious.FadeWhenInactive = false;
            this.btnPrevious.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnPrevious.Image = global::MusicApp.Properties.Resources.left_gray;
            this.btnPrevious.ImageActive = null;
            this.btnPrevious.ImageLocation = null;
            this.btnPrevious.ImageMargin = 0;
            this.btnPrevious.ImageSize = new System.Drawing.Size(44, 44);
            this.btnPrevious.ImageZoomSize = new System.Drawing.Size(45, 45);
            this.btnPrevious.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnPrevious.InitialImage")));
            this.btnPrevious.Location = new System.Drawing.Point(823, 26);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Rotation = 0;
            this.btnPrevious.ShowActiveImage = true;
            this.btnPrevious.ShowCursorChanges = true;
            this.btnPrevious.ShowImageBorders = true;
            this.btnPrevious.ShowSizeMarkers = false;
            this.btnPrevious.Size = new System.Drawing.Size(45, 45);
            this.btnPrevious.TabIndex = 2;
            this.btnPrevious.ToolTipText = "";
            this.btnPrevious.WaitOnLoad = false;
            this.btnPrevious.Zoom = 0;
            this.btnPrevious.ZoomSpeed = 10;
            this.btnPrevious.MouseLeave += new System.EventHandler(this.btnPrevious_MouseLeave);
            this.btnPrevious.MouseHover += new System.EventHandler(this.btnPrevious_MouseHover);
            // 
            // btnPlay
            // 
            this.btnPlay.ActiveImage = null;
            this.btnPlay.AllowAnimations = true;
            this.btnPlay.AllowBuffering = false;
            this.btnPlay.AllowToggling = false;
            this.btnPlay.AllowZooming = true;
            this.btnPlay.AllowZoomingOnFocus = false;
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPlay.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnPlay.ErrorImage")));
            this.btnPlay.FadeWhenInactive = false;
            this.btnPlay.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnPlay.Image = global::MusicApp.Properties.Resources.play;
            this.btnPlay.ImageActive = null;
            this.btnPlay.ImageLocation = null;
            this.btnPlay.ImageMargin = 0;
            this.btnPlay.ImageSize = new System.Drawing.Size(54, 54);
            this.btnPlay.ImageZoomSize = new System.Drawing.Size(55, 55);
            this.btnPlay.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnPlay.InitialImage")));
            this.btnPlay.Location = new System.Drawing.Point(923, 21);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Rotation = 0;
            this.btnPlay.ShowActiveImage = true;
            this.btnPlay.ShowCursorChanges = true;
            this.btnPlay.ShowImageBorders = true;
            this.btnPlay.ShowSizeMarkers = false;
            this.btnPlay.Size = new System.Drawing.Size(55, 55);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.ToolTipText = "";
            this.btnPlay.WaitOnLoad = false;
            this.btnPlay.Zoom = 0;
            this.btnPlay.ZoomSpeed = 10;
            // 
            // btnSlider
            // 
            this.btnSlider.AllowCursorChanges = true;
            this.btnSlider.AllowHomeEndKeysDetection = false;
            this.btnSlider.AllowIncrementalClickMoves = true;
            this.btnSlider.AllowMouseDownEffects = false;
            this.btnSlider.AllowMouseHoverEffects = false;
            this.btnSlider.AllowScrollingAnimations = true;
            this.btnSlider.AllowScrollKeysDetection = true;
            this.btnSlider.AllowScrollOptionsMenu = true;
            this.btnSlider.AllowShrinkingOnFocusLost = false;
            this.btnSlider.BackColor = System.Drawing.Color.Transparent;
            this.btnSlider.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSlider.BackgroundImage")));
            this.btnSlider.BindingContainer = null;
            this.btnSlider.BorderRadius = 2;
            this.btnSlider.BorderThickness = 1;
            this.btnSlider.DrawThickBorder = false;
            this.btnSlider.DurationBeforeShrink = 2000;
            this.btnSlider.ElapsedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.btnSlider.LargeChange = 10;
            this.btnSlider.Location = new System.Drawing.Point(645, 86);
            this.btnSlider.Maximum = 100;
            this.btnSlider.Minimum = 0;
            this.btnSlider.MinimumSize = new System.Drawing.Size(0, 31);
            this.btnSlider.MinimumThumbLength = 18;
            this.btnSlider.Name = "btnSlider";
            this.btnSlider.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.btnSlider.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.btnSlider.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.btnSlider.ScrollBarBorderColor = System.Drawing.Color.White;
            this.btnSlider.ScrollBarColor = System.Drawing.Color.White;
            this.btnSlider.ShrinkSizeLimit = 3;
            this.btnSlider.Size = new System.Drawing.Size(612, 31);
            this.btnSlider.SliderColor = System.Drawing.Color.White;
            this.btnSlider.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.btnSlider.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.btnSlider.SmallChange = 1;
            this.btnSlider.TabIndex = 0;
            this.btnSlider.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.btnSlider.ThumbFillColor = System.Drawing.SystemColors.Control;
            this.btnSlider.ThumbLength = 60;
            this.btnSlider.ThumbMargin = 1;
            this.btnSlider.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.btnSlider.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.btnSlider.Value = 50;
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
            this.pnMenu.Size = new System.Drawing.Size(272, 920);
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
            // pageMain
            // 
            this.pageMain.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.pageMain.AllowTransitions = false;
            this.pageMain.Controls.Add(this.pageHome);
            this.pageMain.Controls.Add(this.pageFind);
            this.pageMain.Controls.Add(this.pageCollection);
            this.pageMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageMain.Location = new System.Drawing.Point(272, 0);
            this.pageMain.Multiline = true;
            this.pageMain.Name = "pageMain";
            this.pageMain.Page = this.pageHome;
            this.pageMain.PageIndex = 0;
            this.pageMain.PageName = "pageHome";
            this.pageMain.PageTitle = "Trang chủ";
            this.pageMain.SelectedIndex = 0;
            this.pageMain.Size = new System.Drawing.Size(1624, 920);
            this.pageMain.TabIndex = 2;
            animation1.AnimateOnlyDifferences = false;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.pageMain.Transition = animation1;
            this.pageMain.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // pageHome
            // 
            this.pageHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.pageHome.Controls.Add(this.button1);
            this.pageHome.Controls.Add(this.btnMore1);
            this.pageHome.Controls.Add(this.fpnSongs);
            this.pageHome.Controls.Add(this.lbSongs);
            this.pageHome.Controls.Add(this.fpnHistory);
            this.pageHome.Controls.Add(this.lbHistory);
            this.pageHome.Location = new System.Drawing.Point(4, 4);
            this.pageHome.Name = "pageHome";
            this.pageHome.Padding = new System.Windows.Forms.Padding(3);
            this.pageHome.Size = new System.Drawing.Size(1616, 887);
            this.pageHome.TabIndex = 0;
            this.pageHome.Text = "Trang chủ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.button1.Image = global::MusicApp.Properties.Resources.angle_right;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(1451, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 40);
            this.button1.TabIndex = 9;
            this.button1.Text = "Xem thêm";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnMore1
            // 
            this.btnMore1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnMore1.FlatAppearance.BorderSize = 0;
            this.btnMore1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMore1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMore1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.btnMore1.Image = global::MusicApp.Properties.Resources.angle_right;
            this.btnMore1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMore1.Location = new System.Drawing.Point(1451, 30);
            this.btnMore1.Name = "btnMore1";
            this.btnMore1.Size = new System.Drawing.Size(134, 40);
            this.btnMore1.TabIndex = 8;
            this.btnMore1.Text = "Xem thêm";
            this.btnMore1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMore1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMore1.UseVisualStyleBackColor = false;
            // 
            // fpnSongs
            // 
            this.fpnSongs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.fpnSongs.Location = new System.Drawing.Point(80, 502);
            this.fpnSongs.Name = "fpnSongs";
            this.fpnSongs.Size = new System.Drawing.Size(1505, 360);
            this.fpnSongs.TabIndex = 6;
            // 
            // lbSongs
            // 
            this.lbSongs.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSongs.ForeColor = System.Drawing.Color.White;
            this.lbSongs.Location = new System.Drawing.Point(45, 449);
            this.lbSongs.Name = "lbSongs";
            this.lbSongs.Size = new System.Drawing.Size(107, 36);
            this.lbSongs.TabIndex = 5;
            this.lbSongs.Text = "Bài hát";
            this.lbSongs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fpnHistory
            // 
            this.fpnHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.fpnHistory.Location = new System.Drawing.Point(80, 81);
            this.fpnHistory.Name = "fpnHistory";
            this.fpnHistory.Size = new System.Drawing.Size(1505, 293);
            this.fpnHistory.TabIndex = 4;
            // 
            // lbHistory
            // 
            this.lbHistory.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbHistory.ForeColor = System.Drawing.Color.White;
            this.lbHistory.Location = new System.Drawing.Point(45, 20);
            this.lbHistory.Name = "lbHistory";
            this.lbHistory.Size = new System.Drawing.Size(252, 36);
            this.lbHistory.TabIndex = 2;
            this.lbHistory.Text = "Mới phát gần đây";
            this.lbHistory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pageFind
            // 
            this.pageFind.Location = new System.Drawing.Point(4, 4);
            this.pageFind.Name = "pageFind";
            this.pageFind.Padding = new System.Windows.Forms.Padding(3);
            this.pageFind.Size = new System.Drawing.Size(1616, 887);
            this.pageFind.TabIndex = 1;
            this.pageFind.Text = "Tìm kiếm";
            this.pageFind.UseVisualStyleBackColor = true;
            // 
            // pageCollection
            // 
            this.pageCollection.Location = new System.Drawing.Point(4, 4);
            this.pageCollection.Name = "pageCollection";
            this.pageCollection.Padding = new System.Windows.Forms.Padding(3);
            this.pageCollection.Size = new System.Drawing.Size(1616, 887);
            this.pageCollection.TabIndex = 2;
            this.pageCollection.Text = "Thư viện";
            this.pageCollection.UseVisualStyleBackColor = true;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1896, 1055);
            this.Controls.Add(this.pageMain);
            this.Controls.Add(this.pnMenu);
            this.Controls.Add(this.pnPlay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusicApp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnPlay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pSong)).EndInit();
            this.pnMenu.ResumeLayout(false);
            this.pageMain.ResumeLayout(false);
            this.pageHome.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnPlay;
        private Panel pnMenu;
        private Label lbLogo;
        private Button btnHome;
        private Button btnCollection;
        private Button btnFind;
        private Bunifu.UI.WinForms.BunifuHSlider btnSlider;
        private Bunifu.UI.WinForms.BunifuImageButton btnPlay;
        private Bunifu.UI.WinForms.BunifuImageButton btnPrevious;
        private Bunifu.UI.WinForms.BunifuImageButton btnNext;
        private Bunifu.UI.WinForms.BunifuImageButton btnShuffle;
        private Bunifu.UI.WinForms.BunifuImageButton btnRepeat;
        private PictureBox pSong;
        private Label lbSongName;
        private Label lbArtist;
        private Label lbTimeStart;
        private Label lbTimeEnd;
        private Bunifu.UI.WinForms.BunifuImageButton btnHeart;
        private Bunifu.UI.WinForms.BunifuImageButton btnLyric;
        private Bunifu.UI.WinForms.BunifuImageButton btnVolume;
        private Bunifu.UI.WinForms.BunifuImageButton btnOther;
        private Bunifu.UI.WinForms.BunifuPages pageMain;
        private TabPage pageHome;
        private TabPage pageFind;
        private TabPage pageCollection;
        private Label lbHistory;
        private FlowLayoutPanel fpnHistory;
        private Label lbSongs;
        private FlowLayoutPanel fpnSongs;
        private Button btnMore1;
        private Button button1;
    }
}