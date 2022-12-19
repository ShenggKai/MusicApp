using System.ComponentModel;

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
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation3 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation2 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
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
            this.btnMore2 = new System.Windows.Forms.Button();
            this.btnMore1 = new System.Windows.Forms.Button();
            this.fpnSongs = new System.Windows.Forms.FlowLayoutPanel();
            this.lbSongs = new System.Windows.Forms.Label();
            this.fpnHistory = new System.Windows.Forms.FlowLayoutPanel();
            this.lbHistory = new System.Windows.Forms.Label();
            this.pageFind = new System.Windows.Forms.TabPage();
            this.pnFind = new System.Windows.Forms.Panel();
            this.txboxFind = new Bunifu.UI.WinForms.BunifuTextBox();
            this.pageGenre = new Bunifu.UI.WinForms.BunifuPages();
            this.tabpageGenre = new System.Windows.Forms.TabPage();
            this.fpnGenre = new System.Windows.Forms.FlowLayoutPanel();
            this.genre1 = new MusicApp.Source.Genre();
            this.genre2 = new MusicApp.Source.Genre();
            this.genre3 = new MusicApp.Source.Genre();
            this.genre4 = new MusicApp.Source.Genre();
            this.genre5 = new MusicApp.Source.Genre();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pageCollection = new System.Windows.Forms.TabPage();
            this.pageLike = new Bunifu.UI.WinForms.BunifuPages();
            this.tabpagePlaylist = new System.Windows.Forms.TabPage();
            this.fpnPlaylist = new System.Windows.Forms.FlowLayoutPanel();
            this.liked1 = new MusicApp.Source.Liked();
            this.playlist1 = new MusicApp.Source.Playlist();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnAddList = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pageAllSong = new System.Windows.Forms.TabPage();
            this.tabulateSongs = new Tabulate.Tabulate();
            this.pnPlay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pSong)).BeginInit();
            this.pnMenu.SuspendLayout();
            this.pageMain.SuspendLayout();
            this.pageHome.SuspendLayout();
            this.pageFind.SuspendLayout();
            this.pnFind.SuspendLayout();
            this.pageGenre.SuspendLayout();
            this.tabpageGenre.SuspendLayout();
            this.fpnGenre.SuspendLayout();
            this.pageCollection.SuspendLayout();
            this.pageLike.SuspendLayout();
            this.tabpagePlaylist.SuspendLayout();
            this.fpnPlaylist.SuspendLayout();
            this.pageAllSong.SuspendLayout();
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
            this.btnShuffle.ImageSize = new System.Drawing.Size(39, 39);
            this.btnShuffle.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.btnShuffle.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnShuffle.InitialImage")));
            this.btnShuffle.Location = new System.Drawing.Point(723, 26);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Rotation = 0;
            this.btnShuffle.ShowActiveImage = true;
            this.btnShuffle.ShowCursorChanges = true;
            this.btnShuffle.ShowImageBorders = true;
            this.btnShuffle.ShowSizeMarkers = false;
            this.btnShuffle.Size = new System.Drawing.Size(40, 40);
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
            this.btnRepeat.ImageSize = new System.Drawing.Size(39, 39);
            this.btnRepeat.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.btnRepeat.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnRepeat.InitialImage")));
            this.btnRepeat.Location = new System.Drawing.Point(1133, 26);
            this.btnRepeat.Name = "btnRepeat";
            this.btnRepeat.Rotation = 0;
            this.btnRepeat.ShowActiveImage = true;
            this.btnRepeat.ShowCursorChanges = true;
            this.btnRepeat.ShowImageBorders = true;
            this.btnRepeat.ShowSizeMarkers = false;
            this.btnRepeat.Size = new System.Drawing.Size(40, 40);
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
            this.btnNext.ImageSize = new System.Drawing.Size(39, 39);
            this.btnNext.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.btnNext.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnNext.InitialImage")));
            this.btnNext.Location = new System.Drawing.Point(1033, 26);
            this.btnNext.Name = "btnNext";
            this.btnNext.Rotation = 0;
            this.btnNext.ShowActiveImage = true;
            this.btnNext.ShowCursorChanges = true;
            this.btnNext.ShowImageBorders = true;
            this.btnNext.ShowSizeMarkers = false;
            this.btnNext.Size = new System.Drawing.Size(40, 40);
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
            this.btnPrevious.ImageSize = new System.Drawing.Size(39, 39);
            this.btnPrevious.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.btnPrevious.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnPrevious.InitialImage")));
            this.btnPrevious.Location = new System.Drawing.Point(823, 26);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Rotation = 0;
            this.btnPrevious.ShowActiveImage = true;
            this.btnPrevious.ShowCursorChanges = true;
            this.btnPrevious.ShowImageBorders = true;
            this.btnPrevious.ShowSizeMarkers = false;
            this.btnPrevious.Size = new System.Drawing.Size(40, 40);
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
            this.btnPlay.ImageSize = new System.Drawing.Size(49, 49);
            this.btnPlay.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.btnPlay.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnPlay.InitialImage")));
            this.btnPlay.Location = new System.Drawing.Point(923, 21);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Rotation = 0;
            this.btnPlay.ShowActiveImage = true;
            this.btnPlay.ShowCursorChanges = true;
            this.btnPlay.ShowImageBorders = true;
            this.btnPlay.ShowSizeMarkers = false;
            this.btnPlay.Size = new System.Drawing.Size(50, 50);
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
            this.btnSlider.AllowIncrementalClickMoves = false;
            this.btnSlider.AllowMouseDownEffects = false;
            this.btnSlider.AllowMouseHoverEffects = false;
            this.btnSlider.AllowScrollingAnimations = true;
            this.btnSlider.AllowScrollKeysDetection = true;
            this.btnSlider.AllowScrollOptionsMenu = false;
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
            this.pageMain.Controls.Add(this.pageAllSong);
            this.pageMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageMain.Location = new System.Drawing.Point(272, 0);
            this.pageMain.Multiline = true;
            this.pageMain.Name = "pageMain";
            this.pageMain.Page = this.pageCollection;
            this.pageMain.PageIndex = 2;
            this.pageMain.PageName = "pageCollection";
            this.pageMain.PageTitle = "Thư viện";
            this.pageMain.SelectedIndex = 0;
            this.pageMain.Size = new System.Drawing.Size(1624, 920);
            this.pageMain.TabIndex = 2;
            animation3.AnimateOnlyDifferences = false;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.pageMain.Transition = animation3;
            this.pageMain.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // pageHome
            // 
            this.pageHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.pageHome.Controls.Add(this.btnMore2);
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
            // btnMore2
            // 
            this.btnMore2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnMore2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMore2.FlatAppearance.BorderSize = 0;
            this.btnMore2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMore2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMore2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.btnMore2.Image = global::MusicApp.Properties.Resources.angle_right;
            this.btnMore2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMore2.Location = new System.Drawing.Point(1451, 445);
            this.btnMore2.Name = "btnMore2";
            this.btnMore2.Size = new System.Drawing.Size(134, 40);
            this.btnMore2.TabIndex = 9;
            this.btnMore2.Text = "Xem thêm";
            this.btnMore2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMore2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMore2.UseVisualStyleBackColor = false;
            this.btnMore2.Click += new System.EventHandler(this.btnMore2_Click);
            // 
            // btnMore1
            // 
            this.btnMore1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnMore1.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.pageFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.pageFind.Controls.Add(this.pnFind);
            this.pageFind.Controls.Add(this.pageGenre);
            this.pageFind.Location = new System.Drawing.Point(4, 4);
            this.pageFind.Name = "pageFind";
            this.pageFind.Padding = new System.Windows.Forms.Padding(3);
            this.pageFind.Size = new System.Drawing.Size(1616, 887);
            this.pageFind.TabIndex = 1;
            this.pageFind.Text = "Tìm kiếm";
            // 
            // pnFind
            // 
            this.pnFind.BackColor = System.Drawing.Color.Transparent;
            this.pnFind.Controls.Add(this.txboxFind);
            this.pnFind.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnFind.Location = new System.Drawing.Point(3, 3);
            this.pnFind.Name = "pnFind";
            this.pnFind.Size = new System.Drawing.Size(1610, 85);
            this.pnFind.TabIndex = 3;
            // 
            // txboxFind
            // 
            this.txboxFind.AcceptsReturn = false;
            this.txboxFind.AcceptsTab = false;
            this.txboxFind.AnimationSpeed = 200;
            this.txboxFind.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txboxFind.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txboxFind.AutoSizeHeight = false;
            this.txboxFind.BackColor = System.Drawing.Color.Transparent;
            this.txboxFind.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txboxFind.BackgroundImage")));
            this.txboxFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.txboxFind.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.txboxFind.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.txboxFind.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.txboxFind.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.txboxFind.BorderRadius = 40;
            this.txboxFind.BorderThickness = 0;
            this.txboxFind.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txboxFind.DefaultFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txboxFind.DefaultText = "";
            this.txboxFind.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.txboxFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.txboxFind.HideSelection = true;
            this.txboxFind.IconLeft = global::MusicApp.Properties.Resources.search_black;
            this.txboxFind.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txboxFind.IconPadding = 10;
            this.txboxFind.IconRight = null;
            this.txboxFind.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txboxFind.Lines = new string[0];
            this.txboxFind.Location = new System.Drawing.Point(390, 15);
            this.txboxFind.MaxLength = 32767;
            this.txboxFind.MinimumSize = new System.Drawing.Size(1, 1);
            this.txboxFind.Modified = false;
            this.txboxFind.Multiline = false;
            this.txboxFind.Name = "txboxFind";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txboxFind.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txboxFind.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txboxFind.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            stateProperties4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txboxFind.OnIdleState = stateProperties4;
            this.txboxFind.Padding = new System.Windows.Forms.Padding(3);
            this.txboxFind.PasswordChar = '\0';
            this.txboxFind.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.txboxFind.PlaceholderText = "Tìm kiếm bài hát, nghệ sĩ, lời bài hát, ...";
            this.txboxFind.ReadOnly = false;
            this.txboxFind.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txboxFind.SelectedText = "";
            this.txboxFind.SelectionLength = 0;
            this.txboxFind.SelectionStart = 0;
            this.txboxFind.ShortcutsEnabled = true;
            this.txboxFind.Size = new System.Drawing.Size(850, 50);
            this.txboxFind.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txboxFind.TabIndex = 0;
            this.txboxFind.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txboxFind.TextMarginBottom = 0;
            this.txboxFind.TextMarginLeft = 15;
            this.txboxFind.TextMarginTop = 0;
            this.txboxFind.TextPlaceholder = "Tìm kiếm bài hát, nghệ sĩ, lời bài hát, ...";
            this.txboxFind.UseSystemPasswordChar = false;
            this.txboxFind.WordWrap = true;
            // 
            // pageGenre
            // 
            this.pageGenre.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.pageGenre.AllowTransitions = false;
            this.pageGenre.Controls.Add(this.tabpageGenre);
            this.pageGenre.Controls.Add(this.tabPage2);
            this.pageGenre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageGenre.Location = new System.Drawing.Point(3, 3);
            this.pageGenre.Multiline = true;
            this.pageGenre.Name = "pageGenre";
            this.pageGenre.Page = this.tabpageGenre;
            this.pageGenre.PageIndex = 0;
            this.pageGenre.PageName = "tabpageGenre";
            this.pageGenre.PageTitle = "Thể loại";
            this.pageGenre.SelectedIndex = 0;
            this.pageGenre.Size = new System.Drawing.Size(1610, 881);
            this.pageGenre.TabIndex = 2;
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
            this.pageGenre.Transition = animation1;
            this.pageGenre.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // tabpageGenre
            // 
            this.tabpageGenre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.tabpageGenre.Controls.Add(this.fpnGenre);
            this.tabpageGenre.Location = new System.Drawing.Point(4, 4);
            this.tabpageGenre.Name = "tabpageGenre";
            this.tabpageGenre.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageGenre.Size = new System.Drawing.Size(1602, 848);
            this.tabpageGenre.TabIndex = 0;
            this.tabpageGenre.Text = "Thể loại";
            // 
            // fpnGenre
            // 
            this.fpnGenre.BackColor = System.Drawing.Color.Transparent;
            this.fpnGenre.Controls.Add(this.genre1);
            this.fpnGenre.Controls.Add(this.genre2);
            this.fpnGenre.Controls.Add(this.genre3);
            this.fpnGenre.Controls.Add(this.genre4);
            this.fpnGenre.Controls.Add(this.genre5);
            this.fpnGenre.Location = new System.Drawing.Point(143, 134);
            this.fpnGenre.Name = "fpnGenre";
            this.fpnGenre.Size = new System.Drawing.Size(1444, 666);
            this.fpnGenre.TabIndex = 0;
            // 
            // genre1
            // 
            this.genre1.BackColor = System.Drawing.Color.Transparent;
            this.genre1.Image = ((System.Drawing.Image)(resources.GetObject("genre1.Image")));
            this.genre1.Label = "Nhạc Việt";
            this.genre1.Location = new System.Drawing.Point(0, 0);
            this.genre1.Margin = new System.Windows.Forms.Padding(0, 0, 100, 82);
            this.genre1.Name = "genre1";
            this.genre1.Size = new System.Drawing.Size(261, 292);
            this.genre1.TabIndex = 0;
            // 
            // genre2
            // 
            this.genre2.BackColor = System.Drawing.Color.Transparent;
            this.genre2.Image = ((System.Drawing.Image)(resources.GetObject("genre2.Image")));
            this.genre2.Label = "Nhạc Hàn";
            this.genre2.Location = new System.Drawing.Point(361, 0);
            this.genre2.Margin = new System.Windows.Forms.Padding(0, 0, 100, 82);
            this.genre2.Name = "genre2";
            this.genre2.Size = new System.Drawing.Size(261, 292);
            this.genre2.TabIndex = 1;
            // 
            // genre3
            // 
            this.genre3.BackColor = System.Drawing.Color.Transparent;
            this.genre3.Image = ((System.Drawing.Image)(resources.GetObject("genre3.Image")));
            this.genre3.Label = "Nhạc Âu Mĩ";
            this.genre3.Location = new System.Drawing.Point(722, 0);
            this.genre3.Margin = new System.Windows.Forms.Padding(0, 0, 100, 82);
            this.genre3.Name = "genre3";
            this.genre3.Size = new System.Drawing.Size(261, 292);
            this.genre3.TabIndex = 2;
            // 
            // genre4
            // 
            this.genre4.BackColor = System.Drawing.Color.Transparent;
            this.genre4.Image = ((System.Drawing.Image)(resources.GetObject("genre4.Image")));
            this.genre4.Label = "Nhạc không lời";
            this.genre4.Location = new System.Drawing.Point(1083, 0);
            this.genre4.Margin = new System.Windows.Forms.Padding(0, 0, 100, 82);
            this.genre4.Name = "genre4";
            this.genre4.Size = new System.Drawing.Size(261, 292);
            this.genre4.TabIndex = 3;
            // 
            // genre5
            // 
            this.genre5.BackColor = System.Drawing.Color.Transparent;
            this.genre5.Image = ((System.Drawing.Image)(resources.GetObject("genre5.Image")));
            this.genre5.Label = "Nhạc Trịnh";
            this.genre5.Location = new System.Drawing.Point(0, 374);
            this.genre5.Margin = new System.Windows.Forms.Padding(0, 0, 100, 82);
            this.genre5.Name = "genre5";
            this.genre5.Size = new System.Drawing.Size(261, 292);
            this.genre5.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1602, 848);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // pageCollection
            // 
            this.pageCollection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.pageCollection.Controls.Add(this.pageLike);
            this.pageCollection.Controls.Add(this.btnAddList);
            this.pageCollection.Location = new System.Drawing.Point(4, 4);
            this.pageCollection.Name = "pageCollection";
            this.pageCollection.Padding = new System.Windows.Forms.Padding(3);
            this.pageCollection.Size = new System.Drawing.Size(1616, 887);
            this.pageCollection.TabIndex = 2;
            this.pageCollection.Text = "Thư viện";
            // 
            // pageLike
            // 
            this.pageLike.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.pageLike.AllowTransitions = false;
            this.pageLike.Controls.Add(this.tabpagePlaylist);
            this.pageLike.Controls.Add(this.tabPage3);
            this.pageLike.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pageLike.Location = new System.Drawing.Point(3, 91);
            this.pageLike.Multiline = true;
            this.pageLike.Name = "pageLike";
            this.pageLike.Page = this.tabpagePlaylist;
            this.pageLike.PageIndex = 0;
            this.pageLike.PageName = "tabpagePlaylist";
            this.pageLike.PageTitle = "playlist";
            this.pageLike.SelectedIndex = 0;
            this.pageLike.Size = new System.Drawing.Size(1610, 793);
            this.pageLike.TabIndex = 1;
            animation2.AnimateOnlyDifferences = false;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.pageLike.Transition = animation2;
            this.pageLike.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // tabpagePlaylist
            // 
            this.tabpagePlaylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.tabpagePlaylist.Controls.Add(this.fpnPlaylist);
            this.tabpagePlaylist.Location = new System.Drawing.Point(4, 4);
            this.tabpagePlaylist.Name = "tabpagePlaylist";
            this.tabpagePlaylist.Padding = new System.Windows.Forms.Padding(3);
            this.tabpagePlaylist.Size = new System.Drawing.Size(1602, 760);
            this.tabpagePlaylist.TabIndex = 0;
            this.tabpagePlaylist.Text = "playlist";
            // 
            // fpnPlaylist
            // 
            this.fpnPlaylist.AllowDrop = true;
            this.fpnPlaylist.AutoScroll = true;
            this.fpnPlaylist.BackColor = System.Drawing.Color.Red;
            this.fpnPlaylist.Controls.Add(this.liked1);
            this.fpnPlaylist.Controls.Add(this.playlist1);
            this.fpnPlaylist.Location = new System.Drawing.Point(63, 0);
            this.fpnPlaylist.Name = "fpnPlaylist";
            this.fpnPlaylist.Size = new System.Drawing.Size(1555, 787);
            this.fpnPlaylist.TabIndex = 0;
            // 
            // liked1
            // 
            this.liked1.BackColor = System.Drawing.Color.Transparent;
            this.liked1.Location = new System.Drawing.Point(0, 0);
            this.liked1.Margin = new System.Windows.Forms.Padding(0, 0, 50, 60);
            this.liked1.Name = "liked1";
            this.liked1.Size = new System.Drawing.Size(261, 292);
            this.liked1.TabIndex = 0;
            // 
            // playlist1
            // 
            this.playlist1.BackColor = System.Drawing.Color.Transparent;
            this.playlist1.Location = new System.Drawing.Point(311, 0);
            this.playlist1.Margin = new System.Windows.Forms.Padding(0, 0, 50, 60);
            this.playlist1.Name = "playlist1";
            this.playlist1.Size = new System.Drawing.Size(261, 292);
            this.playlist1.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1602, 760);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnAddList
            // 
            this.btnAddList.AllowAnimations = true;
            this.btnAddList.AllowMouseEffects = true;
            this.btnAddList.AllowToggling = false;
            this.btnAddList.AnimationSpeed = 200;
            this.btnAddList.AutoGenerateColors = false;
            this.btnAddList.AutoRoundBorders = false;
            this.btnAddList.AutoSizeLeftIcon = false;
            this.btnAddList.AutoSizeRightIcon = false;
            this.btnAddList.BackColor = System.Drawing.Color.Transparent;
            this.btnAddList.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnAddList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddList.BackgroundImage")));
            this.btnAddList.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddList.ButtonText = "Tạo playlist";
            this.btnAddList.ButtonTextMarginLeft = 0;
            this.btnAddList.ColorContrastOnClick = 45;
            this.btnAddList.ColorContrastOnHover = 45;
            this.btnAddList.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnAddList.CustomizableEdges = borderEdges1;
            this.btnAddList.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddList.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddList.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnAddList.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnAddList.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAddList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddList.ForeColor = System.Drawing.Color.White;
            this.btnAddList.IconLeft = null;
            this.btnAddList.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddList.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddList.IconLeftPadding = new System.Windows.Forms.Padding(0);
            this.btnAddList.IconMarginLeft = 11;
            this.btnAddList.IconPadding = 0;
            this.btnAddList.IconRight = global::MusicApp.Properties.Resources.plus;
            this.btnAddList.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddList.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddList.IconRightPadding = new System.Windows.Forms.Padding(0, 0, 22, 0);
            this.btnAddList.IconSize = 20;
            this.btnAddList.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnAddList.IdleBorderRadius = 0;
            this.btnAddList.IdleBorderThickness = 0;
            this.btnAddList.IdleFillColor = System.Drawing.Color.Empty;
            this.btnAddList.IdleIconLeftImage = null;
            this.btnAddList.IdleIconRightImage = global::MusicApp.Properties.Resources.plus;
            this.btnAddList.IndicateFocus = false;
            this.btnAddList.Location = new System.Drawing.Point(70, 30);
            this.btnAddList.Name = "btnAddList";
            this.btnAddList.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(148)))), ((int)(((byte)(20)))));
            this.btnAddList.OnDisabledState.BorderRadius = 30;
            this.btnAddList.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddList.OnDisabledState.BorderThickness = 0;
            this.btnAddList.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(148)))), ((int)(((byte)(20)))));
            this.btnAddList.OnDisabledState.ForeColor = System.Drawing.Color.White;
            this.btnAddList.OnDisabledState.IconLeftImage = null;
            this.btnAddList.OnDisabledState.IconRightImage = null;
            this.btnAddList.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(196)))), ((int)(((byte)(125)))));
            this.btnAddList.onHoverState.BorderRadius = 30;
            this.btnAddList.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddList.onHoverState.BorderThickness = 0;
            this.btnAddList.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(196)))), ((int)(((byte)(125)))));
            this.btnAddList.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAddList.onHoverState.IconLeftImage = null;
            this.btnAddList.onHoverState.IconRightImage = null;
            this.btnAddList.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(148)))), ((int)(((byte)(20)))));
            this.btnAddList.OnIdleState.BorderRadius = 30;
            this.btnAddList.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddList.OnIdleState.BorderThickness = 0;
            this.btnAddList.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(148)))), ((int)(((byte)(20)))));
            this.btnAddList.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAddList.OnIdleState.IconLeftImage = null;
            this.btnAddList.OnIdleState.IconRightImage = global::MusicApp.Properties.Resources.plus;
            this.btnAddList.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(148)))), ((int)(((byte)(20)))));
            this.btnAddList.OnPressedState.BorderRadius = 30;
            this.btnAddList.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddList.OnPressedState.BorderThickness = 0;
            this.btnAddList.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(148)))), ((int)(((byte)(20)))));
            this.btnAddList.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAddList.OnPressedState.IconLeftImage = null;
            this.btnAddList.OnPressedState.IconRightImage = null;
            this.btnAddList.Size = new System.Drawing.Size(189, 55);
            this.btnAddList.TabIndex = 0;
            this.btnAddList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddList.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddList.TextMarginLeft = 0;
            this.btnAddList.TextPadding = new System.Windows.Forms.Padding(23, 0, 0, 0);
            this.btnAddList.UseDefaultRadiusAndThickness = true;
            // 
            // pageAllSong
            // 
            this.pageAllSong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.pageAllSong.Controls.Add(this.tabulateSongs);
            this.pageAllSong.Location = new System.Drawing.Point(4, 4);
            this.pageAllSong.Name = "pageAllSong";
            this.pageAllSong.Padding = new System.Windows.Forms.Padding(3);
            this.pageAllSong.Size = new System.Drawing.Size(1616, 887);
            this.pageAllSong.TabIndex = 3;
            this.pageAllSong.Text = "Tất cả bài";
            // 
            // tabulateSongs
            // 
            this.tabulateSongs.Columns.Add(((Tabulate.Column)(resources.GetObject("tabulateSongs.Columns"))));
            this.tabulateSongs.Columns.Add(((Tabulate.Column)(resources.GetObject("tabulateSongs.Columns1"))));
            this.tabulateSongs.Columns.Add(((Tabulate.Column)(resources.GetObject("tabulateSongs.Columns2"))));
            this.tabulateSongs.Columns.Add(((Tabulate.Column)(resources.GetObject("tabulateSongs.Columns3"))));
            this.tabulateSongs.Columns.Add(((Tabulate.Column)(resources.GetObject("tabulateSongs.Columns4"))));
            this.tabulateSongs.Columns.Add(((Tabulate.Column)(resources.GetObject("tabulateSongs.Columns5"))));
            this.tabulateSongs.EnableRowSelection = false;
            this.tabulateSongs.EnableSelection = true;
            this.tabulateSongs.HTMLFooter = "";
            this.tabulateSongs.HTMLHeader = "<button type=\"button\" class=\"btn btn-primary\">Primary</button>\r\n<button type=\"but" +
    "ton\" class=\"btn btn-secondary\">Secondary</button>\r\n<br>\r\n<br>";
            this.tabulateSongs.InjectCSS = "";
            this.tabulateSongs.InjectJS = "";
            this.tabulateSongs.LoaderDelay = 1000;
            this.tabulateSongs.LoaderImage = ((System.Drawing.Image)(resources.GetObject("tabulateSongs.LoaderImage")));
            this.tabulateSongs.Location = new System.Drawing.Point(7, 19);
            this.tabulateSongs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabulateSongs.Name = "tabulateSongs";
            this.tabulateSongs.ScrollbarsEnabled = false;
            this.tabulateSongs.Size = new System.Drawing.Size(1600, 860);
            this.tabulateSongs.TabIndex = 0;
            this.tabulateSongs.TableBordered = true;
            this.tabulateSongs.TableCompact = false;
            this.tabulateSongs.TableConfiguration = ((Tabulate.TableConfig)(resources.GetObject("tabulateSongs.TableConfiguration")));
            this.tabulateSongs.TableHoverEffect = true;
            this.tabulateSongs.TableStriped = true;
            this.tabulateSongs.Theme = Tabulate.Tabulate.theme.paper;
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
            this.Shown += new System.EventHandler(this.HomeForm_Shown);
            this.pnPlay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pSong)).EndInit();
            this.pnMenu.ResumeLayout(false);
            this.pageMain.ResumeLayout(false);
            this.pageHome.ResumeLayout(false);
            this.pageFind.ResumeLayout(false);
            this.pnFind.ResumeLayout(false);
            this.pageGenre.ResumeLayout(false);
            this.tabpageGenre.ResumeLayout(false);
            this.fpnGenre.ResumeLayout(false);
            this.pageCollection.ResumeLayout(false);
            this.pageLike.ResumeLayout(false);
            this.tabpagePlaylist.ResumeLayout(false);
            this.fpnPlaylist.ResumeLayout(false);
            this.pageAllSong.ResumeLayout(false);
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
        private Button btnMore2;
        private TabPage pageAllSong;
        private Tabulate.Tabulate tabulateSongs;
        private Bunifu.UI.WinForms.BunifuTextBox txboxFind;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddList;
        private Bunifu.UI.WinForms.BunifuPages pageGenre;
        private TabPage tabpageGenre;
        private TabPage tabPage2;
        private Panel pnFind;
        private FlowLayoutPanel fpnGenre;
        private Source.Genre genre1;
        private Source.Genre genre2;
        private Source.Genre genre3;
        private Source.Genre genre4;
        private Source.Genre genre5;
        private Bunifu.UI.WinForms.BunifuPages pageLike;
        private TabPage tabpagePlaylist;
        private TabPage tabPage3;
        private FlowLayoutPanel fpnPlaylist;
        private Source.Liked liked1;
        private Source.Playlist playlist1;
    }
}