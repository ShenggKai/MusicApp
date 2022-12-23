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
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation4 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation3 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
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
            this.lbLogo = new System.Windows.Forms.Label();
            this.pageMain = new Bunifu.UI.WinForms.BunifuPages();
            this.pageHome = new System.Windows.Forms.TabPage();
            this.fpnSongs = new System.Windows.Forms.FlowLayoutPanel();
            this.song1 = new MusicApp.Source.Song();
            this.song2 = new MusicApp.Source.Song();
            this.song3 = new MusicApp.Source.Song();
            this.song4 = new MusicApp.Source.Song();
            this.song5 = new MusicApp.Source.Song();
            this.song6 = new MusicApp.Source.Song();
            this.song7 = new MusicApp.Source.Song();
            this.song8 = new MusicApp.Source.Song();
            this.song9 = new MusicApp.Source.Song();
            this.song10 = new MusicApp.Source.Song();
            this.song11 = new MusicApp.Source.Song();
            this.song12 = new MusicApp.Source.Song();
            this.song13 = new MusicApp.Source.Song();
            this.song14 = new MusicApp.Source.Song();
            this.song15 = new MusicApp.Source.Song();
            this.song16 = new MusicApp.Source.Song();
            this.song17 = new MusicApp.Source.Song();
            this.song18 = new MusicApp.Source.Song();
            this.song19 = new MusicApp.Source.Song();
            this.song20 = new MusicApp.Source.Song();
            this.song21 = new MusicApp.Source.Song();
            this.song22 = new MusicApp.Source.Song();
            this.song23 = new MusicApp.Source.Song();
            this.song24 = new MusicApp.Source.Song();
            this.song25 = new MusicApp.Source.Song();
            this.song26 = new MusicApp.Source.Song();
            this.song27 = new MusicApp.Source.Song();
            this.song28 = new MusicApp.Source.Song();
            this.song29 = new MusicApp.Source.Song();
            this.song30 = new MusicApp.Source.Song();
            this.lbSongs = new System.Windows.Forms.Label();
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
            this.btnHome = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.pnPlay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pSong)).BeginInit();
            this.pnMenu.SuspendLayout();
            this.pageMain.SuspendLayout();
            this.pageHome.SuspendLayout();
            this.fpnSongs.SuspendLayout();
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
            this.pnPlay.Location = new System.Drawing.Point(0, 898);
            this.pnPlay.Name = "pnPlay";
            this.pnPlay.Size = new System.Drawing.Size(1902, 135);
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
            this.pnMenu.Controls.Add(this.btnHome);
            this.pnMenu.Controls.Add(this.lbLogo);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(272, 898);
            this.pnMenu.TabIndex = 1;
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
            this.pageMain.Page = this.pageFind;
            this.pageMain.PageIndex = 1;
            this.pageMain.PageName = "pageFind";
            this.pageMain.PageTitle = "Tìm kiếm";
            this.pageMain.SelectedIndex = 0;
            this.pageMain.Size = new System.Drawing.Size(1630, 898);
            this.pageMain.TabIndex = 2;
            animation4.AnimateOnlyDifferences = false;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.pageMain.Transition = animation4;
            this.pageMain.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // pageHome
            // 
            this.pageHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.pageHome.Controls.Add(this.fpnSongs);
            this.pageHome.Controls.Add(this.lbSongs);
            this.pageHome.Location = new System.Drawing.Point(4, 4);
            this.pageHome.Name = "pageHome";
            this.pageHome.Padding = new System.Windows.Forms.Padding(3);
            this.pageHome.Size = new System.Drawing.Size(1622, 865);
            this.pageHome.TabIndex = 0;
            this.pageHome.Text = "Trang chủ";
            // 
            // fpnSongs
            // 
            this.fpnSongs.AllowDrop = true;
            this.fpnSongs.AutoScroll = true;
            this.fpnSongs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.fpnSongs.Controls.Add(this.song1);
            this.fpnSongs.Controls.Add(this.song2);
            this.fpnSongs.Controls.Add(this.song3);
            this.fpnSongs.Controls.Add(this.song4);
            this.fpnSongs.Controls.Add(this.song5);
            this.fpnSongs.Controls.Add(this.song6);
            this.fpnSongs.Controls.Add(this.song7);
            this.fpnSongs.Controls.Add(this.song8);
            this.fpnSongs.Controls.Add(this.song9);
            this.fpnSongs.Controls.Add(this.song10);
            this.fpnSongs.Controls.Add(this.song11);
            this.fpnSongs.Controls.Add(this.song12);
            this.fpnSongs.Controls.Add(this.song13);
            this.fpnSongs.Controls.Add(this.song14);
            this.fpnSongs.Controls.Add(this.song15);
            this.fpnSongs.Controls.Add(this.song16);
            this.fpnSongs.Controls.Add(this.song17);
            this.fpnSongs.Controls.Add(this.song18);
            this.fpnSongs.Controls.Add(this.song19);
            this.fpnSongs.Controls.Add(this.song20);
            this.fpnSongs.Controls.Add(this.song21);
            this.fpnSongs.Controls.Add(this.song22);
            this.fpnSongs.Controls.Add(this.song23);
            this.fpnSongs.Controls.Add(this.song24);
            this.fpnSongs.Controls.Add(this.song25);
            this.fpnSongs.Controls.Add(this.song26);
            this.fpnSongs.Controls.Add(this.song27);
            this.fpnSongs.Controls.Add(this.song28);
            this.fpnSongs.Controls.Add(this.song29);
            this.fpnSongs.Controls.Add(this.song30);
            this.fpnSongs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fpnSongs.Location = new System.Drawing.Point(3, 82);
            this.fpnSongs.Name = "fpnSongs";
            this.fpnSongs.Size = new System.Drawing.Size(1616, 780);
            this.fpnSongs.TabIndex = 6;
            // 
            // song1
            // 
            this.song1.Artist = "Tia Hải Châu, Lê Thiện Hiếu";
            this.song1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.song1.ImageSong = global::MusicApp.Properties.Resources.AiDuaEmVe;
            this.song1.Location = new System.Drawing.Point(3, 3);
            this.song1.Name = "song1";
            this.song1.NameSong = "Ai Đưa Em Về";
            this.song1.Number = "1";
            this.song1.Size = new System.Drawing.Size(1610, 90);
            this.song1.TabIndex = 0;
            this.song1.Time = "03:54";
            // 
            // song2
            // 
            this.song2.Artist = "Anh Quân Idol";
            this.song2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.song2.ImageSong = ((System.Drawing.Image)(resources.GetObject("song2.ImageSong")));
            this.song2.Location = new System.Drawing.Point(3, 99);
            this.song2.Name = "song2";
            this.song2.NameSong = "Anh Mệt Rồi";
            this.song2.Number = "2";
            this.song2.Size = new System.Drawing.Size(1610, 90);
            this.song2.TabIndex = 1;
            this.song2.Time = "03:54";
            // 
            // song3
            // 
            this.song3.Artist = "BTS";
            this.song3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.song3.ImageSong = global::MusicApp.Properties.Resources.AnswerLoveMyself;
            this.song3.Location = new System.Drawing.Point(3, 195);
            this.song3.Name = "song3";
            this.song3.NameSong = "Answer: Love Myself";
            this.song3.Number = "3";
            this.song3.Size = new System.Drawing.Size(1610, 90);
            this.song3.TabIndex = 2;
            this.song3.Time = "04:11";
            // 
            // song4
            // 
            this.song4.Artist = "Shaun";
            this.song4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.song4.ImageSong = global::MusicApp.Properties.Resources.BadHabits;
            this.song4.Location = new System.Drawing.Point(3, 291);
            this.song4.Name = "song4";
            this.song4.NameSong = "Bad Habits";
            this.song4.Number = "4";
            this.song4.Size = new System.Drawing.Size(1610, 90);
            this.song4.TabIndex = 3;
            this.song4.Time = "03:33";
            // 
            // song5
            // 
            this.song5.Artist = "An Coong";
            this.song5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.song5.ImageSong = global::MusicApp.Properties.Resources.EndlessLove;
            this.song5.Location = new System.Drawing.Point(3, 387);
            this.song5.Name = "song5";
            this.song5.NameSong = "Endless Love (The Myth OST)";
            this.song5.Number = "5";
            this.song5.Size = new System.Drawing.Size(1610, 90);
            this.song5.TabIndex = 4;
            this.song5.Time = "04:43";
            // 
            // song6
            // 
            this.song6.Artist = "Joji";
            this.song6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.song6.ImageSong = global::MusicApp.Properties.Resources.GlimpseOfUs;
            this.song6.Location = new System.Drawing.Point(3, 483);
            this.song6.Name = "song6";
            this.song6.NameSong = "Glimpse of Us";
            this.song6.Number = "6";
            this.song6.Size = new System.Drawing.Size(1610, 90);
            this.song6.TabIndex = 5;
            this.song6.Time = "03:53";
            // 
            // song7
            // 
            this.song7.Artist = "Kenny G";
            this.song7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.song7.ImageSong = global::MusicApp.Properties.Resources.GoingHome;
            this.song7.Location = new System.Drawing.Point(3, 579);
            this.song7.Name = "song7";
            this.song7.NameSong = "Going Home";
            this.song7.Number = "7";
            this.song7.Size = new System.Drawing.Size(1610, 90);
            this.song7.TabIndex = 6;
            this.song7.Time = "05:35";
            // 
            // song8
            // 
            this.song8.Artist = "Hayd";
            this.song8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.song8.ImageSong = global::MusicApp.Properties.Resources.HeadInTheCloud;
            this.song8.Location = new System.Drawing.Point(3, 675);
            this.song8.Name = "song8";
            this.song8.NameSong = "Head In The Clouds";
            this.song8.Number = "8";
            this.song8.Size = new System.Drawing.Size(1610, 90);
            this.song8.TabIndex = 7;
            this.song8.Time = "03:04";
            // 
            // song9
            // 
            this.song9.Artist = "Lil Z Poet";
            this.song9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.song9.ImageSong = global::MusicApp.Properties.Resources.HoaVangNayTan2;
            this.song9.Location = new System.Drawing.Point(3, 771);
            this.song9.Name = "song9";
            this.song9.NameSong = "Hoa Vàng Nay Tàn";
            this.song9.Number = "9";
            this.song9.Size = new System.Drawing.Size(1610, 90);
            this.song9.TabIndex = 8;
            this.song9.Time = "03:51";
            // 
            // song10
            // 
            this.song10.Artist = "BIGBANG";
            this.song10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.song10.ImageSong = global::MusicApp.Properties.Resources.IfYou;
            this.song10.Location = new System.Drawing.Point(3, 867);
            this.song10.Name = "song10";
            this.song10.NameSong = "If You";
            this.song10.Number = "10";
            this.song10.Size = new System.Drawing.Size(1610, 90);
            this.song10.TabIndex = 9;
            this.song10.Time = "04:24";
            // 
            // song11
            // 
            this.song11.Artist = "BIGBANG";
            this.song11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.song11.ImageSong = global::MusicApp.Properties.Resources.IfYou;
            this.song11.Location = new System.Drawing.Point(3, 963);
            this.song11.Name = "song11";
            this.song11.NameSong = "If You";
            this.song11.Number = "10";
            this.song11.Size = new System.Drawing.Size(1610, 90);
            this.song11.TabIndex = 10;
            this.song11.Time = "04:24";
            // 
            // song12
            // 
            this.song12.Artist = "BIGBANG";
            this.song12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.song12.ImageSong = global::MusicApp.Properties.Resources.IfYou;
            this.song12.Location = new System.Drawing.Point(3, 1059);
            this.song12.Name = "song12";
            this.song12.NameSong = "If You";
            this.song12.Number = "10";
            this.song12.Size = new System.Drawing.Size(1610, 90);
            this.song12.TabIndex = 11;
            this.song12.Time = "04:24";
            // 
            // song13
            // 
            this.song13.Artist = "BIGBANG";
            this.song13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.song13.ImageSong = global::MusicApp.Properties.Resources.IfYou;
            this.song13.Location = new System.Drawing.Point(3, 1155);
            this.song13.Name = "song13";
            this.song13.NameSong = "If You";
            this.song13.Number = "10";
            this.song13.Size = new System.Drawing.Size(1610, 90);
            this.song13.TabIndex = 12;
            this.song13.Time = "04:24";
            // 
            // song14
            // 
            this.song14.Artist = "BIGBANG";
            this.song14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.song14.ImageSong = global::MusicApp.Properties.Resources.IfYou;
            this.song14.Location = new System.Drawing.Point(3, 1251);
            this.song14.Name = "song14";
            this.song14.NameSong = "If You";
            this.song14.Number = "10";
            this.song14.Size = new System.Drawing.Size(1610, 90);
            this.song14.TabIndex = 13;
            this.song14.Time = "04:24";
            // 
            // song15
            // 
            this.song15.Artist = "BIGBANG";
            this.song15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.song15.ImageSong = global::MusicApp.Properties.Resources.IfYou;
            this.song15.Location = new System.Drawing.Point(3, 1347);
            this.song15.Name = "song15";
            this.song15.NameSong = "If You";
            this.song15.Number = "10";
            this.song15.Size = new System.Drawing.Size(1610, 90);
            this.song15.TabIndex = 14;
            this.song15.Time = "04:24";
            // 
            // song16
            // 
            this.song16.Artist = "BIGBANG";
            this.song16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.song16.ImageSong = global::MusicApp.Properties.Resources.IfYou;
            this.song16.Location = new System.Drawing.Point(3, 1443);
            this.song16.Name = "song16";
            this.song16.NameSong = "If You";
            this.song16.Number = "10";
            this.song16.Size = new System.Drawing.Size(1610, 90);
            this.song16.TabIndex = 15;
            this.song16.Time = "04:24";
            // 
            // song17
            // 
            this.song17.Artist = "BIGBANG";
            this.song17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.song17.ImageSong = global::MusicApp.Properties.Resources.IfYou;
            this.song17.Location = new System.Drawing.Point(3, 1539);
            this.song17.Name = "song17";
            this.song17.NameSong = "If You";
            this.song17.Number = "10";
            this.song17.Size = new System.Drawing.Size(1610, 90);
            this.song17.TabIndex = 16;
            this.song17.Time = "04:24";
            // 
            // song18
            // 
            this.song18.Artist = "BIGBANG";
            this.song18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.song18.ImageSong = global::MusicApp.Properties.Resources.IfYou;
            this.song18.Location = new System.Drawing.Point(3, 1635);
            this.song18.Name = "song18";
            this.song18.NameSong = "If You";
            this.song18.Number = "10";
            this.song18.Size = new System.Drawing.Size(1610, 90);
            this.song18.TabIndex = 17;
            this.song18.Time = "04:24";
            // 
            // song19
            // 
            this.song19.Artist = "BIGBANG";
            this.song19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.song19.ImageSong = global::MusicApp.Properties.Resources.IfYou;
            this.song19.Location = new System.Drawing.Point(3, 1731);
            this.song19.Name = "song19";
            this.song19.NameSong = "If You";
            this.song19.Number = "10";
            this.song19.Size = new System.Drawing.Size(1610, 90);
            this.song19.TabIndex = 18;
            this.song19.Time = "04:24";
            // 
            // song20
            // 
            this.song20.Artist = "BIGBANG";
            this.song20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.song20.ImageSong = global::MusicApp.Properties.Resources.IfYou;
            this.song20.Location = new System.Drawing.Point(3, 1827);
            this.song20.Name = "song20";
            this.song20.NameSong = "If You";
            this.song20.Number = "10";
            this.song20.Size = new System.Drawing.Size(1610, 90);
            this.song20.TabIndex = 19;
            this.song20.Time = "04:24";
            // 
            // song21
            // 
            this.song21.Artist = "BIGBANG";
            this.song21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.song21.ImageSong = global::MusicApp.Properties.Resources.IfYou;
            this.song21.Location = new System.Drawing.Point(3, 1923);
            this.song21.Name = "song21";
            this.song21.NameSong = "If You";
            this.song21.Number = "10";
            this.song21.Size = new System.Drawing.Size(1610, 90);
            this.song21.TabIndex = 20;
            this.song21.Time = "04:24";
            // 
            // song22
            // 
            this.song22.Artist = "BIGBANG";
            this.song22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.song22.ImageSong = global::MusicApp.Properties.Resources.IfYou;
            this.song22.Location = new System.Drawing.Point(3, 2019);
            this.song22.Name = "song22";
            this.song22.NameSong = "If You";
            this.song22.Number = "10";
            this.song22.Size = new System.Drawing.Size(1610, 90);
            this.song22.TabIndex = 21;
            this.song22.Time = "04:24";
            // 
            // song23
            // 
            this.song23.Artist = "BIGBANG";
            this.song23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.song23.ImageSong = global::MusicApp.Properties.Resources.IfYou;
            this.song23.Location = new System.Drawing.Point(3, 2115);
            this.song23.Name = "song23";
            this.song23.NameSong = "If You";
            this.song23.Number = "10";
            this.song23.Size = new System.Drawing.Size(1610, 90);
            this.song23.TabIndex = 22;
            this.song23.Time = "04:24";
            // 
            // song24
            // 
            this.song24.Artist = "BIGBANG";
            this.song24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.song24.ImageSong = global::MusicApp.Properties.Resources.IfYou;
            this.song24.Location = new System.Drawing.Point(3, 2211);
            this.song24.Name = "song24";
            this.song24.NameSong = "If You";
            this.song24.Number = "10";
            this.song24.Size = new System.Drawing.Size(1610, 90);
            this.song24.TabIndex = 23;
            this.song24.Time = "04:24";
            // 
            // song25
            // 
            this.song25.Artist = "BIGBANG";
            this.song25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.song25.ImageSong = global::MusicApp.Properties.Resources.IfYou;
            this.song25.Location = new System.Drawing.Point(3, 2307);
            this.song25.Name = "song25";
            this.song25.NameSong = "If You";
            this.song25.Number = "10";
            this.song25.Size = new System.Drawing.Size(1610, 90);
            this.song25.TabIndex = 24;
            this.song25.Time = "04:24";
            // 
            // song26
            // 
            this.song26.Artist = "BIGBANG";
            this.song26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.song26.ImageSong = global::MusicApp.Properties.Resources.IfYou;
            this.song26.Location = new System.Drawing.Point(3, 2403);
            this.song26.Name = "song26";
            this.song26.NameSong = "If You";
            this.song26.Number = "10";
            this.song26.Size = new System.Drawing.Size(1610, 90);
            this.song26.TabIndex = 25;
            this.song26.Time = "04:24";
            // 
            // song27
            // 
            this.song27.Artist = "BIGBANG";
            this.song27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.song27.ImageSong = global::MusicApp.Properties.Resources.IfYou;
            this.song27.Location = new System.Drawing.Point(3, 2499);
            this.song27.Name = "song27";
            this.song27.NameSong = "If You";
            this.song27.Number = "10";
            this.song27.Size = new System.Drawing.Size(1610, 90);
            this.song27.TabIndex = 26;
            this.song27.Time = "04:24";
            // 
            // song28
            // 
            this.song28.Artist = "BIGBANG";
            this.song28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.song28.ImageSong = global::MusicApp.Properties.Resources.IfYou;
            this.song28.Location = new System.Drawing.Point(3, 2595);
            this.song28.Name = "song28";
            this.song28.NameSong = "If You";
            this.song28.Number = "10";
            this.song28.Size = new System.Drawing.Size(1610, 90);
            this.song28.TabIndex = 27;
            this.song28.Time = "04:24";
            // 
            // song29
            // 
            this.song29.Artist = "BIGBANG";
            this.song29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.song29.ImageSong = global::MusicApp.Properties.Resources.IfYou;
            this.song29.Location = new System.Drawing.Point(3, 2691);
            this.song29.Name = "song29";
            this.song29.NameSong = "If You";
            this.song29.Number = "10";
            this.song29.Size = new System.Drawing.Size(1610, 90);
            this.song29.TabIndex = 28;
            this.song29.Time = "04:24";
            // 
            // song30
            // 
            this.song30.Artist = "BIGBANG";
            this.song30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.song30.ImageSong = global::MusicApp.Properties.Resources.IfYou;
            this.song30.Location = new System.Drawing.Point(3, 2787);
            this.song30.Name = "song30";
            this.song30.NameSong = "If You";
            this.song30.Number = "10";
            this.song30.Size = new System.Drawing.Size(1610, 90);
            this.song30.TabIndex = 29;
            this.song30.Time = "04:24";
            // 
            // lbSongs
            // 
            this.lbSongs.AutoSize = true;
            this.lbSongs.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSongs.ForeColor = System.Drawing.Color.White;
            this.lbSongs.Location = new System.Drawing.Point(48, 22);
            this.lbSongs.Name = "lbSongs";
            this.lbSongs.Size = new System.Drawing.Size(220, 46);
            this.lbSongs.TabIndex = 5;
            this.lbSongs.Text = "Tất cả bài hát";
            this.lbSongs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pageFind
            // 
            this.pageFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.pageFind.Controls.Add(this.pnFind);
            this.pageFind.Controls.Add(this.pageGenre);
            this.pageFind.Location = new System.Drawing.Point(4, 4);
            this.pageFind.Name = "pageFind";
            this.pageFind.Padding = new System.Windows.Forms.Padding(3);
            this.pageFind.Size = new System.Drawing.Size(1622, 865);
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
            this.pnFind.Size = new System.Drawing.Size(1616, 85);
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
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txboxFind.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txboxFind.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txboxFind.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            stateProperties8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            stateProperties8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txboxFind.OnIdleState = stateProperties8;
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
            this.pageGenre.Page = this.tabPage2;
            this.pageGenre.PageIndex = 1;
            this.pageGenre.PageName = "tabPage2";
            this.pageGenre.PageTitle = "tabPage2";
            this.pageGenre.SelectedIndex = 0;
            this.pageGenre.Size = new System.Drawing.Size(1616, 859);
            this.pageGenre.TabIndex = 2;
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
            this.pageGenre.Transition = animation3;
            this.pageGenre.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // tabpageGenre
            // 
            this.tabpageGenre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.tabpageGenre.Controls.Add(this.fpnGenre);
            this.tabpageGenre.Location = new System.Drawing.Point(4, 4);
            this.tabpageGenre.Name = "tabpageGenre";
            this.tabpageGenre.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageGenre.Size = new System.Drawing.Size(1608, 826);
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
            this.tabPage2.Size = new System.Drawing.Size(1608, 826);
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
            this.pageCollection.Size = new System.Drawing.Size(1622, 865);
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
            this.pageLike.Location = new System.Drawing.Point(3, 117);
            this.pageLike.Multiline = true;
            this.pageLike.Name = "pageLike";
            this.pageLike.Page = this.tabpagePlaylist;
            this.pageLike.PageIndex = 0;
            this.pageLike.PageName = "tabpagePlaylist";
            this.pageLike.PageTitle = "playlist";
            this.pageLike.SelectedIndex = 0;
            this.pageLike.Size = new System.Drawing.Size(1616, 745);
            this.pageLike.TabIndex = 1;
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
            this.pageLike.Transition = animation1;
            this.pageLike.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // tabpagePlaylist
            // 
            this.tabpagePlaylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.tabpagePlaylist.Controls.Add(this.fpnPlaylist);
            this.tabpagePlaylist.Location = new System.Drawing.Point(4, 4);
            this.tabpagePlaylist.Name = "tabpagePlaylist";
            this.tabpagePlaylist.Padding = new System.Windows.Forms.Padding(3);
            this.tabpagePlaylist.Size = new System.Drawing.Size(1608, 712);
            this.tabpagePlaylist.TabIndex = 0;
            this.tabpagePlaylist.Text = "playlist";
            // 
            // fpnPlaylist
            // 
            this.fpnPlaylist.AllowDrop = true;
            this.fpnPlaylist.AutoScroll = true;
            this.fpnPlaylist.BackColor = System.Drawing.Color.Transparent;
            this.fpnPlaylist.Controls.Add(this.liked1);
            this.fpnPlaylist.Controls.Add(this.playlist1);
            this.fpnPlaylist.Location = new System.Drawing.Point(63, 0);
            this.fpnPlaylist.Name = "fpnPlaylist";
            this.fpnPlaylist.Size = new System.Drawing.Size(1578, 787);
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
            this.playlist1.Image = ((System.Drawing.Image)(resources.GetObject("playlist1.Image")));
            this.playlist1.Location = new System.Drawing.Point(311, 0);
            this.playlist1.Margin = new System.Windows.Forms.Padding(0, 0, 50, 60);
            this.playlist1.Name = "playlist1";
            this.playlist1.Size = new System.Drawing.Size(261, 292);
            this.playlist1.TabIndex = 1;
            this.playlist1.Title = "Danh sách phát số 1";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1608, 712);
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
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnAddList.CustomizableEdges = borderEdges3;
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
            this.btnAddList.Click += new System.EventHandler(this.btnAddList_Click);
            // 
            // pageAllSong
            // 
            this.pageAllSong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.pageAllSong.Controls.Add(this.tabulateSongs);
            this.pageAllSong.Location = new System.Drawing.Point(4, 4);
            this.pageAllSong.Name = "pageAllSong";
            this.pageAllSong.Padding = new System.Windows.Forms.Padding(3);
            this.pageAllSong.Size = new System.Drawing.Size(1622, 865);
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
            this.tabulateSongs.HTMLHeader = "<button type=\"button\" class=\"btn btn-secondary\">Thêm bài hát</button>\r\n<br>\r\n<br>" +
    "";
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
            // btnHome
            // 
            this.btnHome.AllowAnimations = true;
            this.btnHome.AllowMouseEffects = true;
            this.btnHome.AllowToggling = false;
            this.btnHome.AnimationSpeed = 200;
            this.btnHome.AutoGenerateColors = false;
            this.btnHome.AutoRoundBorders = false;
            this.btnHome.AutoSizeLeftIcon = false;
            this.btnHome.AutoSizeRightIcon = false;
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHome.BackgroundImage")));
            this.btnHome.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnHome.ButtonText = "Trang Chủ";
            this.btnHome.ButtonTextMarginLeft = 0;
            this.btnHome.ColorContrastOnClick = 45;
            this.btnHome.ColorContrastOnHover = 45;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnHome.CustomizableEdges = borderEdges4;
            this.btnHome.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnHome.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnHome.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnHome.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.btnHome.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnHome.IconLeftPadding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnHome.IconMarginLeft = 11;
            this.btnHome.IconPadding = 0;
            this.btnHome.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnHome.IconRightPadding = new System.Windows.Forms.Padding(0);
            this.btnHome.IconSize = 45;
            this.btnHome.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnHome.IdleBorderRadius = 1;
            this.btnHome.IdleBorderThickness = 1;
            this.btnHome.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnHome.IdleIconLeftImage = global::MusicApp.Properties.Resources.home;
            this.btnHome.IdleIconRightImage = null;
            this.btnHome.IndicateFocus = false;
            this.btnHome.Location = new System.Drawing.Point(0, 86);
            this.btnHome.Name = "btnHome";
            this.btnHome.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnHome.OnDisabledState.BorderRadius = 1;
            this.btnHome.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnHome.OnDisabledState.BorderThickness = 0;
            this.btnHome.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnHome.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnHome.OnDisabledState.IconLeftImage = null;
            this.btnHome.OnDisabledState.IconRightImage = null;
            this.btnHome.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnHome.onHoverState.BorderRadius = 1;
            this.btnHome.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnHome.onHoverState.BorderThickness = 0;
            this.btnHome.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnHome.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnHome.onHoverState.IconLeftImage = null;
            this.btnHome.onHoverState.IconRightImage = null;
            this.btnHome.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnHome.OnIdleState.BorderRadius = 1;
            this.btnHome.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnHome.OnIdleState.BorderThickness = 0;
            this.btnHome.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnHome.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.btnHome.OnIdleState.IconLeftImage = global::MusicApp.Properties.Resources.home;
            this.btnHome.OnIdleState.IconRightImage = null;
            this.btnHome.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnHome.OnPressedState.BorderRadius = 1;
            this.btnHome.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnHome.OnPressedState.BorderThickness = 0;
            this.btnHome.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnHome.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnHome.OnPressedState.IconLeftImage = null;
            this.btnHome.OnPressedState.IconRightImage = null;
            this.btnHome.Size = new System.Drawing.Size(272, 80);
            this.btnHome.TabIndex = 6;
            this.btnHome.Tag = "";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnHome.TextMarginLeft = 0;
            this.btnHome.TextPadding = new System.Windows.Forms.Padding(70, 0, 0, 0);
            this.btnHome.UseDefaultRadiusAndThickness = true;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
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
            this.pageHome.PerformLayout();
            this.fpnSongs.ResumeLayout(false);
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
        private Label lbSongs;
        private FlowLayoutPanel fpnSongs;
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
        private Source.Song song2;
        private Source.Song song3;
        private Source.Song song4;
        private Source.Song song5;
        private Source.Song song6;
        private Source.Song song7;
        private Source.Song song8;
        private Source.Song song9;
        private Source.Song song10;
        private Source.Song song11;
        private Source.Song song12;
        private Source.Song song13;
        private Source.Song song14;
        private Source.Song song15;
        private Source.Song song16;
        private Source.Song song17;
        private Source.Song song18;
        private Source.Song song19;
        private Source.Song song20;
        private Source.Song song21;
        private Source.Song song22;
        private Source.Song song23;
        private Source.Song song24;
        private Source.Song song25;
        private Source.Song song26;
        private Source.Song song27;
        private Source.Song song28;
        private Source.Song song29;
        private Source.Song song30;
        private Source.Song song1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnHome;
    }
}