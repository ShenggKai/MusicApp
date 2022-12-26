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

        //Auto click button 'Trang Chu' when the form start
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges8 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges9 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges10 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges11 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
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
            this.btnHistory = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.btnCollection = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.btnGenre = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.btnHome = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.lbLogo = new System.Windows.Forms.Label();
            this.ppageMain = new Bunifu.UI.WinForms.BunifuPages();
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
            this.song31 = new MusicApp.Source.Song();
            this.song32 = new MusicApp.Source.Song();
            this.song33 = new MusicApp.Source.Song();
            this.song34 = new MusicApp.Source.Song();
            this.song35 = new MusicApp.Source.Song();
            this.song36 = new MusicApp.Source.Song();
            this.song37 = new MusicApp.Source.Song();
            this.song38 = new MusicApp.Source.Song();
            this.song39 = new MusicApp.Source.Song();
            this.song40 = new MusicApp.Source.Song();
            this.pnHeader = new System.Windows.Forms.Panel();
            this.txtTime = new System.Windows.Forms.Label();
            this.txtGenre = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.Label();
            this.txboxFind = new Bunifu.UI.WinForms.BunifuTextBox();
            this.pageGenre = new System.Windows.Forms.TabPage();
            this.genre4 = new MusicApp.Source.Genre();
            this.genre3 = new MusicApp.Source.Genre();
            this.genre2 = new MusicApp.Source.Genre();
            this.genre5 = new MusicApp.Source.Genre();
            this.genre1 = new MusicApp.Source.Genre();
            this.pageCollection = new System.Windows.Forms.TabPage();
            this.fpnPlaylist = new System.Windows.Forms.FlowLayoutPanel();
            this.liked1 = new MusicApp.Source.Liked();
            this.playlist1 = new MusicApp.Source.Playlist();
            this.btnAddList = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pageHistory = new System.Windows.Forms.TabPage();
            this.pageInfo = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fpnComment = new System.Windows.Forms.FlowLayoutPanel();
            this.comment1 = new MusicApp.Source.Comment();
            this.txtOneStar = new System.Windows.Forms.Label();
            this.txtTwoStar = new System.Windows.Forms.Label();
            this.txtThreeStar = new System.Windows.Forms.Label();
            this.txtFourStar = new System.Windows.Forms.Label();
            this.txtFiveStar = new System.Windows.Forms.Label();
            this.btnOneStar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnTwoStar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnThreeStar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.BtnFourStar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnFiveStar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnComment = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.line = new Bunifu.UI.WinForms.BunifuSeparator();
            this.txtRattingPoint = new System.Windows.Forms.Label();
            this.pBack = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbGenre = new System.Windows.Forms.Label();
            this.lbYear = new System.Windows.Forms.Label();
            this.lbArtirst = new System.Windows.Forms.Label();
            this.txtInfoGenre = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.Label();
            this.txtInfoArtist = new System.Windows.Forms.Label();
            this.txtComposer = new System.Windows.Forms.Label();
            this.lbComposer = new System.Windows.Forms.Label();
            this.txtNameSong = new System.Windows.Forms.Label();
            this.pInforSong = new System.Windows.Forms.PictureBox();
            this.pageVpop = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.song41 = new MusicApp.Source.Song();
            this.song42 = new MusicApp.Source.Song();
            this.song43 = new MusicApp.Source.Song();
            this.song48 = new MusicApp.Source.Song();
            this.song50 = new MusicApp.Source.Song();
            this.song52 = new MusicApp.Source.Song();
            this.song53 = new MusicApp.Source.Song();
            this.song56 = new MusicApp.Source.Song();
            this.song59 = new MusicApp.Source.Song();
            this.song61 = new MusicApp.Source.Song();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.pageKpop = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.song44 = new MusicApp.Source.Song();
            this.song46 = new MusicApp.Source.Song();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pageUS = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.song45 = new MusicApp.Source.Song();
            this.song47 = new MusicApp.Source.Song();
            this.song51 = new MusicApp.Source.Song();
            this.song55 = new MusicApp.Source.Song();
            this.song57 = new MusicApp.Source.Song();
            this.song60 = new MusicApp.Source.Song();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pageKL = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.song49 = new MusicApp.Source.Song();
            this.song54 = new MusicApp.Source.Song();
            this.song58 = new MusicApp.Source.Song();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pageTrinh = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.song62 = new MusicApp.Source.Song();
            this.pnPlay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pSong)).BeginInit();
            this.pnMenu.SuspendLayout();
            this.ppageMain.SuspendLayout();
            this.pageHome.SuspendLayout();
            this.fpnSongs.SuspendLayout();
            this.pnHeader.SuspendLayout();
            this.pageGenre.SuspendLayout();
            this.pageCollection.SuspendLayout();
            this.fpnPlaylist.SuspendLayout();
            this.pageInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.fpnComment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pInforSong)).BeginInit();
            this.pageVpop.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.pageKpop.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pageUS.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pageKL.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pageTrinh.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.lbTimeEnd.Size = new System.Drawing.Size(63, 26);
            this.lbTimeEnd.TabIndex = 10;
            this.lbTimeEnd.Text = "4:50";
            this.lbTimeEnd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbTimeStart
            // 
            this.lbTimeStart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTimeStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.lbTimeStart.Location = new System.Drawing.Point(571, 86);
            this.lbTimeStart.Name = "lbTimeStart";
            this.lbTimeStart.Size = new System.Drawing.Size(59, 26);
            this.lbTimeStart.TabIndex = 9;
            this.lbTimeStart.Text = "0:00";
            this.lbTimeStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbArtist
            // 
            this.lbArtist.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbArtist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.lbArtist.Location = new System.Drawing.Point(135, 79);
            this.lbArtist.Name = "lbArtist";
            this.lbArtist.Size = new System.Drawing.Size(440, 24);
            this.lbArtist.TabIndex = 8;
            this.lbArtist.Text = "Emcee L, Badbies";
            this.lbArtist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbSongName
            // 
            this.lbSongName.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSongName.ForeColor = System.Drawing.Color.White;
            this.lbSongName.Location = new System.Drawing.Point(135, 33);
            this.lbSongName.Name = "lbSongName";
            this.lbSongName.Size = new System.Drawing.Size(543, 34);
            this.lbSongName.TabIndex = 7;
            this.lbSongName.Text = "Sinh Ra Đã Là Thứ Đối Lập Nhau";
            this.lbSongName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.btnSlider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSlider.DrawThickBorder = true;
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
            this.btnSlider.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thick;
            this.btnSlider.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.btnSlider.SmallChange = 1;
            this.btnSlider.TabIndex = 0;
            this.btnSlider.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.btnSlider.ThumbFillColor = System.Drawing.SystemColors.Control;
            this.btnSlider.ThumbLength = 60;
            this.btnSlider.ThumbMargin = 1;
            this.btnSlider.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.btnSlider.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.btnSlider.Value = 0;
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnMenu.Controls.Add(this.btnHistory);
            this.pnMenu.Controls.Add(this.btnCollection);
            this.pnMenu.Controls.Add(this.btnGenre);
            this.pnMenu.Controls.Add(this.btnHome);
            this.pnMenu.Controls.Add(this.lbLogo);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(272, 898);
            this.pnMenu.TabIndex = 1;
            // 
            // btnHistory
            // 
            this.btnHistory.AllowAnimations = false;
            this.btnHistory.AllowMouseEffects = true;
            this.btnHistory.AllowToggling = false;
            this.btnHistory.AnimationSpeed = 200;
            this.btnHistory.AutoGenerateColors = false;
            this.btnHistory.AutoRoundBorders = false;
            this.btnHistory.AutoSizeLeftIcon = false;
            this.btnHistory.AutoSizeRightIcon = false;
            this.btnHistory.BackColor = System.Drawing.Color.Transparent;
            this.btnHistory.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnHistory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHistory.BackgroundImage")));
            this.btnHistory.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnHistory.ButtonText = "Lịch Sử";
            this.btnHistory.ButtonTextMarginLeft = 0;
            this.btnHistory.ColorContrastOnClick = 45;
            this.btnHistory.ColorContrastOnHover = 45;
            this.btnHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnHistory.CustomizableEdges = borderEdges1;
            this.btnHistory.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnHistory.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnHistory.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnHistory.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistory.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnHistory.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.btnHistory.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistory.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnHistory.IconLeftPadding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnHistory.IconMarginLeft = 11;
            this.btnHistory.IconPadding = 0;
            this.btnHistory.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHistory.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnHistory.IconRightPadding = new System.Windows.Forms.Padding(0);
            this.btnHistory.IconSize = 45;
            this.btnHistory.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnHistory.IdleBorderRadius = 1;
            this.btnHistory.IdleBorderThickness = 1;
            this.btnHistory.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnHistory.IdleIconLeftImage = global::MusicApp.Properties.Resources.time_past;
            this.btnHistory.IdleIconRightImage = null;
            this.btnHistory.IndicateFocus = false;
            this.btnHistory.Location = new System.Drawing.Point(0, 326);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnHistory.OnDisabledState.BorderRadius = 1;
            this.btnHistory.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnHistory.OnDisabledState.BorderThickness = 0;
            this.btnHistory.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnHistory.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnHistory.OnDisabledState.IconLeftImage = null;
            this.btnHistory.OnDisabledState.IconRightImage = null;
            this.btnHistory.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnHistory.onHoverState.BorderRadius = 1;
            this.btnHistory.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnHistory.onHoverState.BorderThickness = 0;
            this.btnHistory.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnHistory.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnHistory.onHoverState.IconLeftImage = global::MusicApp.Properties.Resources.time_past_white;
            this.btnHistory.onHoverState.IconRightImage = null;
            this.btnHistory.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnHistory.OnIdleState.BorderRadius = 1;
            this.btnHistory.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnHistory.OnIdleState.BorderThickness = 0;
            this.btnHistory.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnHistory.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.btnHistory.OnIdleState.IconLeftImage = global::MusicApp.Properties.Resources.time_past;
            this.btnHistory.OnIdleState.IconRightImage = null;
            this.btnHistory.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(143)))), ((int)(((byte)(15)))));
            this.btnHistory.OnPressedState.BorderRadius = 1;
            this.btnHistory.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnHistory.OnPressedState.BorderThickness = 0;
            this.btnHistory.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(143)))), ((int)(((byte)(15)))));
            this.btnHistory.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnHistory.OnPressedState.IconLeftImage = global::MusicApp.Properties.Resources.time_past_full;
            this.btnHistory.OnPressedState.IconRightImage = null;
            this.btnHistory.Size = new System.Drawing.Size(272, 80);
            this.btnHistory.TabIndex = 9;
            this.btnHistory.Tag = "";
            this.btnHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistory.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnHistory.TextMarginLeft = 0;
            this.btnHistory.TextPadding = new System.Windows.Forms.Padding(73, 0, 0, 0);
            this.btnHistory.UseDefaultRadiusAndThickness = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnCollection
            // 
            this.btnCollection.AllowAnimations = false;
            this.btnCollection.AllowMouseEffects = true;
            this.btnCollection.AllowToggling = false;
            this.btnCollection.AnimationSpeed = 200;
            this.btnCollection.AutoGenerateColors = false;
            this.btnCollection.AutoRoundBorders = false;
            this.btnCollection.AutoSizeLeftIcon = false;
            this.btnCollection.AutoSizeRightIcon = false;
            this.btnCollection.BackColor = System.Drawing.Color.Transparent;
            this.btnCollection.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCollection.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCollection.BackgroundImage")));
            this.btnCollection.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnCollection.ButtonText = "Thư Viện";
            this.btnCollection.ButtonTextMarginLeft = 0;
            this.btnCollection.ColorContrastOnClick = 45;
            this.btnCollection.ColorContrastOnHover = 45;
            this.btnCollection.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnCollection.CustomizableEdges = borderEdges2;
            this.btnCollection.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCollection.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCollection.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCollection.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCollection.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCollection.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnCollection.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCollection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.btnCollection.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCollection.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnCollection.IconLeftPadding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnCollection.IconMarginLeft = 11;
            this.btnCollection.IconPadding = 0;
            this.btnCollection.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCollection.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnCollection.IconRightPadding = new System.Windows.Forms.Padding(0);
            this.btnCollection.IconSize = 45;
            this.btnCollection.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCollection.IdleBorderRadius = 1;
            this.btnCollection.IdleBorderThickness = 1;
            this.btnCollection.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCollection.IdleIconLeftImage = global::MusicApp.Properties.Resources.music_library;
            this.btnCollection.IdleIconRightImage = null;
            this.btnCollection.IndicateFocus = false;
            this.btnCollection.Location = new System.Drawing.Point(0, 246);
            this.btnCollection.Name = "btnCollection";
            this.btnCollection.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCollection.OnDisabledState.BorderRadius = 1;
            this.btnCollection.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnCollection.OnDisabledState.BorderThickness = 0;
            this.btnCollection.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCollection.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCollection.OnDisabledState.IconLeftImage = null;
            this.btnCollection.OnDisabledState.IconRightImage = null;
            this.btnCollection.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCollection.onHoverState.BorderRadius = 1;
            this.btnCollection.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnCollection.onHoverState.BorderThickness = 0;
            this.btnCollection.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCollection.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnCollection.onHoverState.IconLeftImage = global::MusicApp.Properties.Resources.music_library_white;
            this.btnCollection.onHoverState.IconRightImage = null;
            this.btnCollection.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCollection.OnIdleState.BorderRadius = 1;
            this.btnCollection.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnCollection.OnIdleState.BorderThickness = 0;
            this.btnCollection.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCollection.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.btnCollection.OnIdleState.IconLeftImage = global::MusicApp.Properties.Resources.music_library;
            this.btnCollection.OnIdleState.IconRightImage = null;
            this.btnCollection.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(143)))), ((int)(((byte)(15)))));
            this.btnCollection.OnPressedState.BorderRadius = 1;
            this.btnCollection.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnCollection.OnPressedState.BorderThickness = 0;
            this.btnCollection.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(143)))), ((int)(((byte)(15)))));
            this.btnCollection.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnCollection.OnPressedState.IconLeftImage = global::MusicApp.Properties.Resources.music_library_full;
            this.btnCollection.OnPressedState.IconRightImage = null;
            this.btnCollection.Size = new System.Drawing.Size(272, 80);
            this.btnCollection.TabIndex = 8;
            this.btnCollection.Tag = "";
            this.btnCollection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCollection.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCollection.TextMarginLeft = 0;
            this.btnCollection.TextPadding = new System.Windows.Forms.Padding(73, 0, 0, 0);
            this.btnCollection.UseDefaultRadiusAndThickness = true;
            this.btnCollection.Click += new System.EventHandler(this.btnCollection_Click);
            // 
            // btnGenre
            // 
            this.btnGenre.AllowAnimations = false;
            this.btnGenre.AllowMouseEffects = true;
            this.btnGenre.AllowToggling = false;
            this.btnGenre.AnimationSpeed = 200;
            this.btnGenre.AutoGenerateColors = false;
            this.btnGenre.AutoRoundBorders = false;
            this.btnGenre.AutoSizeLeftIcon = false;
            this.btnGenre.AutoSizeRightIcon = false;
            this.btnGenre.BackColor = System.Drawing.Color.Transparent;
            this.btnGenre.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnGenre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGenre.BackgroundImage")));
            this.btnGenre.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnGenre.ButtonText = "Thể Loại";
            this.btnGenre.ButtonTextMarginLeft = 0;
            this.btnGenre.ColorContrastOnClick = 45;
            this.btnGenre.ColorContrastOnHover = 45;
            this.btnGenre.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnGenre.CustomizableEdges = borderEdges3;
            this.btnGenre.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGenre.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnGenre.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnGenre.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnGenre.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGenre.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnGenre.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGenre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.btnGenre.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenre.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnGenre.IconLeftPadding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnGenre.IconMarginLeft = 11;
            this.btnGenre.IconPadding = 0;
            this.btnGenre.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenre.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnGenre.IconRightPadding = new System.Windows.Forms.Padding(0);
            this.btnGenre.IconSize = 45;
            this.btnGenre.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnGenre.IdleBorderRadius = 1;
            this.btnGenre.IdleBorderThickness = 1;
            this.btnGenre.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnGenre.IdleIconLeftImage = global::MusicApp.Properties.Resources.genre;
            this.btnGenre.IdleIconRightImage = null;
            this.btnGenre.IndicateFocus = false;
            this.btnGenre.Location = new System.Drawing.Point(0, 166);
            this.btnGenre.Name = "btnGenre";
            this.btnGenre.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnGenre.OnDisabledState.BorderRadius = 1;
            this.btnGenre.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnGenre.OnDisabledState.BorderThickness = 0;
            this.btnGenre.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnGenre.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnGenre.OnDisabledState.IconLeftImage = null;
            this.btnGenre.OnDisabledState.IconRightImage = null;
            this.btnGenre.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnGenre.onHoverState.BorderRadius = 1;
            this.btnGenre.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnGenre.onHoverState.BorderThickness = 0;
            this.btnGenre.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnGenre.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnGenre.onHoverState.IconLeftImage = global::MusicApp.Properties.Resources.genre_white;
            this.btnGenre.onHoverState.IconRightImage = null;
            this.btnGenre.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnGenre.OnIdleState.BorderRadius = 1;
            this.btnGenre.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnGenre.OnIdleState.BorderThickness = 0;
            this.btnGenre.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnGenre.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.btnGenre.OnIdleState.IconLeftImage = global::MusicApp.Properties.Resources.genre;
            this.btnGenre.OnIdleState.IconRightImage = null;
            this.btnGenre.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(143)))), ((int)(((byte)(15)))));
            this.btnGenre.OnPressedState.BorderRadius = 1;
            this.btnGenre.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnGenre.OnPressedState.BorderThickness = 0;
            this.btnGenre.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(143)))), ((int)(((byte)(15)))));
            this.btnGenre.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnGenre.OnPressedState.IconLeftImage = global::MusicApp.Properties.Resources.genre_full;
            this.btnGenre.OnPressedState.IconRightImage = null;
            this.btnGenre.Size = new System.Drawing.Size(272, 80);
            this.btnGenre.TabIndex = 7;
            this.btnGenre.Tag = "";
            this.btnGenre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenre.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnGenre.TextMarginLeft = 0;
            this.btnGenre.TextPadding = new System.Windows.Forms.Padding(73, 0, 0, 0);
            this.btnGenre.UseDefaultRadiusAndThickness = true;
            this.btnGenre.Click += new System.EventHandler(this.btnGenre_Click);
            // 
            // btnHome
            // 
            this.btnHome.AllowAnimations = false;
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
            this.btnHome.DisabledBorderColor = System.Drawing.Color.Yellow;
            this.btnHome.DisabledFillColor = System.Drawing.Color.Blue;
            this.btnHome.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.btnHome.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnHome.IconLeftPadding = new System.Windows.Forms.Padding(15, 0, 0, 0);
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
            this.btnHome.OnDisabledState.BorderColor = System.Drawing.Color.Yellow;
            this.btnHome.OnDisabledState.BorderRadius = 1;
            this.btnHome.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Dash;
            this.btnHome.OnDisabledState.BorderThickness = 0;
            this.btnHome.OnDisabledState.FillColor = System.Drawing.Color.Blue;
            this.btnHome.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnHome.OnDisabledState.IconLeftImage = null;
            this.btnHome.OnDisabledState.IconRightImage = null;
            this.btnHome.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnHome.onHoverState.BorderRadius = 1;
            this.btnHome.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnHome.onHoverState.BorderThickness = 0;
            this.btnHome.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnHome.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnHome.onHoverState.IconLeftImage = global::MusicApp.Properties.Resources.home_white;
            this.btnHome.onHoverState.IconRightImage = null;
            this.btnHome.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnHome.OnIdleState.BorderRadius = 1;
            this.btnHome.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnHome.OnIdleState.BorderThickness = 0;
            this.btnHome.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnHome.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.btnHome.OnIdleState.IconLeftImage = global::MusicApp.Properties.Resources.home;
            this.btnHome.OnIdleState.IconRightImage = null;
            this.btnHome.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(143)))), ((int)(((byte)(15)))));
            this.btnHome.OnPressedState.BorderRadius = 1;
            this.btnHome.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnHome.OnPressedState.BorderThickness = 0;
            this.btnHome.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(143)))), ((int)(((byte)(15)))));
            this.btnHome.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnHome.OnPressedState.IconLeftImage = global::MusicApp.Properties.Resources.home_full;
            this.btnHome.OnPressedState.IconRightImage = null;
            this.btnHome.Size = new System.Drawing.Size(272, 80);
            this.btnHome.TabIndex = 6;
            this.btnHome.Tag = "";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnHome.TextMarginLeft = 0;
            this.btnHome.TextPadding = new System.Windows.Forms.Padding(73, 0, 0, 0);
            this.btnHome.UseDefaultRadiusAndThickness = true;
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
            // ppageMain
            // 
            this.ppageMain.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.ppageMain.AllowTransitions = false;
            this.ppageMain.Controls.Add(this.pageHome);
            this.ppageMain.Controls.Add(this.pageGenre);
            this.ppageMain.Controls.Add(this.pageCollection);
            this.ppageMain.Controls.Add(this.pageHistory);
            this.ppageMain.Controls.Add(this.pageInfo);
            this.ppageMain.Controls.Add(this.pageVpop);
            this.ppageMain.Controls.Add(this.pageKpop);
            this.ppageMain.Controls.Add(this.pageUS);
            this.ppageMain.Controls.Add(this.pageKL);
            this.ppageMain.Controls.Add(this.pageTrinh);
            this.ppageMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ppageMain.Location = new System.Drawing.Point(272, 0);
            this.ppageMain.Multiline = true;
            this.ppageMain.Name = "ppageMain";
            this.ppageMain.Page = this.pageTrinh;
            this.ppageMain.PageIndex = 9;
            this.ppageMain.PageName = "pageTrinh";
            this.ppageMain.PageTitle = "Nhạc Trịnh";
            this.ppageMain.SelectedIndex = 0;
            this.ppageMain.Size = new System.Drawing.Size(1630, 898);
            this.ppageMain.TabIndex = 2;
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
            this.ppageMain.Transition = animation1;
            this.ppageMain.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // pageHome
            // 
            this.pageHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.pageHome.Controls.Add(this.fpnSongs);
            this.pageHome.Controls.Add(this.pnHeader);
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
            this.fpnSongs.Controls.Add(this.song31);
            this.fpnSongs.Controls.Add(this.song32);
            this.fpnSongs.Controls.Add(this.song33);
            this.fpnSongs.Controls.Add(this.song34);
            this.fpnSongs.Controls.Add(this.song35);
            this.fpnSongs.Controls.Add(this.song36);
            this.fpnSongs.Controls.Add(this.song37);
            this.fpnSongs.Controls.Add(this.song38);
            this.fpnSongs.Controls.Add(this.song39);
            this.fpnSongs.Controls.Add(this.song40);
            this.fpnSongs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpnSongs.Location = new System.Drawing.Point(3, 181);
            this.fpnSongs.Name = "fpnSongs";
            this.fpnSongs.Size = new System.Drawing.Size(1616, 681);
            this.fpnSongs.TabIndex = 8;
            // 
            // song1
            // 
            this.song1.Artist = "TIA, Lê Thiện Hiếu";
            this.song1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.song1.Genre = "Nhạc Việt";
            this.song1.ImageSong = global::MusicApp.Properties.Resources.AiDuaEmVe;
            this.song1.Location = new System.Drawing.Point(0, 0);
            this.song1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.song1.Name = "song1";
            this.song1.NameSong = "Ai Đưa Em Về";
            this.song1.Number = "1";
            this.song1.Size = new System.Drawing.Size(1620, 90);
            this.song1.TabIndex = 0;
            this.song1.Time = "03:53";
            this.song1.InfoClick += new System.EventHandler(this.song1_InfoClick_1);
            // 
            // song2
            // 
            this.song2.Artist = "SOOBIN";
            this.song2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.song2.Genre = "Nhạc Việt";
            this.song2.ImageSong = global::MusicApp.Properties.Resources.AnhDaQuenVoiCoDon;
            this.song2.Location = new System.Drawing.Point(0, 93);
            this.song2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.song2.Name = "song2";
            this.song2.NameSong = "Anh Đã Quen Với Cô Đơn";
            this.song2.Number = "2";
            this.song2.Size = new System.Drawing.Size(1620, 90);
            this.song2.TabIndex = 1;
            this.song2.Time = "03:55";
            this.song2.InfoClick += new System.EventHandler(this.song2_InfoClick);
            // 
            // song3
            // 
            this.song3.Artist = "Anh Quân Idol";
            this.song3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.song3.Genre = "Nhạc Việt";
            this.song3.ImageSong = global::MusicApp.Properties.Resources.AnhMetRoi;
            this.song3.Location = new System.Drawing.Point(0, 186);
            this.song3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.song3.Name = "song3";
            this.song3.NameSong = "Anh Mệt Rồi";
            this.song3.Number = "3";
            this.song3.Size = new System.Drawing.Size(1620, 90);
            this.song3.TabIndex = 2;
            this.song3.Time = "04:56";
            this.song3.InfoClick += new System.EventHandler(this.song3_InfoClick);
            // 
            // song4
            // 
            this.song4.Artist = "BTS";
            this.song4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.song4.Genre = "Nhạc Hàn";
            this.song4.ImageSong = global::MusicApp.Properties.Resources.AnswerLoveMyself;
            this.song4.Location = new System.Drawing.Point(0, 279);
            this.song4.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.song4.Name = "song4";
            this.song4.NameSong = "Answer: Love Myself";
            this.song4.Number = "4";
            this.song4.Size = new System.Drawing.Size(1620, 90);
            this.song4.TabIndex = 3;
            this.song4.Time = "03:54";
            this.song4.InfoClick += new System.EventHandler(this.song4_InfoClick);
            // 
            // song5
            // 
            this.song5.Artist = "Justin Bieber, Ludacris";
            this.song5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.song5.Genre = "Nhạc Âu Mỹ";
            this.song5.ImageSong = global::MusicApp.Properties.Resources.Baby;
            this.song5.Location = new System.Drawing.Point(0, 372);
            this.song5.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.song5.Name = "song5";
            this.song5.NameSong = "Baby";
            this.song5.Number = "5";
            this.song5.Size = new System.Drawing.Size(1620, 90);
            this.song5.TabIndex = 4;
            this.song5.Time = "03:39";
            this.song5.InfoClick += new System.EventHandler(this.song5_InfoClick);
            // 
            // song6
            // 
            this.song6.Artist = "Shaun";
            this.song6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.song6.Genre = "Nhạc Hàn";
            this.song6.ImageSong = global::MusicApp.Properties.Resources.BadHabits;
            this.song6.Location = new System.Drawing.Point(0, 465);
            this.song6.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.song6.Name = "song6";
            this.song6.NameSong = "Bad Habits";
            this.song6.Number = "6";
            this.song6.Size = new System.Drawing.Size(1620, 90);
            this.song6.TabIndex = 5;
            this.song6.Time = "03:33";
            this.song6.InfoClick += new System.EventHandler(this.song6_InfoClick);
            // 
            // song7
            // 
            this.song7.Artist = "Imagine Dragons";
            this.song7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.song7.Genre = "Nhạc Âu Mỹ";
            this.song7.ImageSong = global::MusicApp.Properties.Resources.Bones;
            this.song7.Location = new System.Drawing.Point(0, 558);
            this.song7.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.song7.Name = "song7";
            this.song7.NameSong = "Bones";
            this.song7.Number = "7";
            this.song7.Size = new System.Drawing.Size(1620, 90);
            this.song7.TabIndex = 6;
            this.song7.Time = "02:45";
            this.song7.InfoClick += new System.EventHandler(this.song7_InfoClick);
            // 
            // song8
            // 
            this.song8.Artist = "Vũ";
            this.song8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.song8.Genre = "Nhạc Việt";
            this.song8.ImageSong = global::MusicApp.Properties.Resources.BuocQuaMuaCoDon;
            this.song8.Location = new System.Drawing.Point(0, 651);
            this.song8.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.song8.Name = "song8";
            this.song8.NameSong = "Bước Qua Mùa Cô Đơn";
            this.song8.Number = "8";
            this.song8.Size = new System.Drawing.Size(1620, 90);
            this.song8.TabIndex = 7;
            this.song8.Time = "04:38";
            this.song8.Load += new System.EventHandler(this.song8_Load);
            // 
            // song9
            // 
            this.song9.Artist = "An Coong";
            this.song9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.song9.Genre = "Nhạc không lời";
            this.song9.ImageSong = global::MusicApp.Properties.Resources.ChungTaCuaHienTaiCover;
            this.song9.Location = new System.Drawing.Point(0, 744);
            this.song9.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.song9.Name = "song9";
            this.song9.NameSong = "Chúng Ta Của Hiện Tại (Piano cover)";
            this.song9.Number = "9";
            this.song9.Size = new System.Drawing.Size(1620, 90);
            this.song9.TabIndex = 8;
            this.song9.Time = "05:03";
            this.song9.InfoClick += new System.EventHandler(this.song9_InfoClick);
            // 
            // song10
            // 
            this.song10.Artist = "MONSTAR";
            this.song10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.song10.Genre = "Nhạc Việt";
            this.song10.ImageSong = global::MusicApp.Properties.Resources.CoHenVoiThanhXuan;
            this.song10.Location = new System.Drawing.Point(0, 837);
            this.song10.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.song10.Name = "song10";
            this.song10.NameSong = "Có Hẹn Với Thanh Xuân";
            this.song10.Number = "10";
            this.song10.Size = new System.Drawing.Size(1620, 90);
            this.song10.TabIndex = 9;
            this.song10.Time = "03:38";
            this.song10.InfoClick += new System.EventHandler(this.song10_InfoClick);
            // 
            // song11
            // 
            this.song11.Artist = "Katy Perry, Tee";
            this.song11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.song11.Genre = "Nhạc Âu Mỹ";
            this.song11.ImageSong = global::MusicApp.Properties.Resources.DarkHorse;
            this.song11.Location = new System.Drawing.Point(0, 930);
            this.song11.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.song11.Name = "song11";
            this.song11.NameSong = "Dark Horse";
            this.song11.Number = "11";
            this.song11.Size = new System.Drawing.Size(1620, 90);
            this.song11.TabIndex = 10;
            this.song11.Time = "03:35";
            // 
            // song12
            // 
            this.song12.Artist = "Only C, Lou Hoàng";
            this.song12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.song12.Genre = "Nhạc Việt";
            this.song12.ImageSong = global::MusicApp.Properties.Resources.DemNgayXaEm;
            this.song12.Location = new System.Drawing.Point(0, 1023);
            this.song12.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.song12.Name = "song12";
            this.song12.NameSong = "Đếm Ngày Xa Em";
            this.song12.Number = "12";
            this.song12.Size = new System.Drawing.Size(1620, 90);
            this.song12.TabIndex = 11;
            this.song12.Time = "04:23";
            // 
            // song13
            // 
            this.song13.Artist = "Sơn Tùng M-TP";
            this.song13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.song13.Genre = "Nhạc Việt";
            this.song13.ImageSong = global::MusicApp.Properties.Resources.EmCuaNgayHomQua;
            this.song13.Location = new System.Drawing.Point(0, 1116);
            this.song13.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.song13.Name = "song13";
            this.song13.NameSong = "Em Của Ngày Hôm Qua";
            this.song13.Number = "13";
            this.song13.Size = new System.Drawing.Size(1620, 90);
            this.song13.TabIndex = 12;
            this.song13.Time = "03:45";
            // 
            // song14
            // 
            this.song14.Artist = "An Coong";
            this.song14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.song14.Genre = "Nhạc không lời";
            this.song14.ImageSong = global::MusicApp.Properties.Resources.EndlessLove1;
            this.song14.Location = new System.Drawing.Point(0, 1209);
            this.song14.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.song14.Name = "song14";
            this.song14.NameSong = "Endless Love (The Myth OST)";
            this.song14.Number = "14";
            this.song14.Size = new System.Drawing.Size(1620, 90);
            this.song14.TabIndex = 13;
            this.song14.Time = "04:43";
            // 
            // song15
            // 
            this.song15.Artist = "Alan Walker";
            this.song15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.song15.Genre = "Nhạc Âu Mỹ";
            this.song15.ImageSong = global::MusicApp.Properties.Resources.Faded;
            this.song15.Location = new System.Drawing.Point(0, 1302);
            this.song15.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.song15.Name = "song15";
            this.song15.NameSong = "Faded";
            this.song15.Number = "15";
            this.song15.Size = new System.Drawing.Size(1620, 90);
            this.song15.TabIndex = 14;
            this.song15.Time = "03:32";
            // 
            // song16
            // 
            this.song16.Artist = "LadyKillah All Star";
            this.song16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.song16.Genre = "Nhạc Việt";
            this.song16.ImageSong = global::MusicApp.Properties.Resources.ForeverLove;
            this.song16.Location = new System.Drawing.Point(0, 1395);
            this.song16.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.song16.Name = "song16";
            this.song16.NameSong = "Forever Love";
            this.song16.Number = "16";
            this.song16.Size = new System.Drawing.Size(1620, 90);
            this.song16.TabIndex = 15;
            this.song16.Time = "07:29";
            // 
            // song17
            // 
            this.song17.Artist = "Joji";
            this.song17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.song17.Genre = "Nhạc Âu Mỹ";
            this.song17.ImageSong = global::MusicApp.Properties.Resources.GlimpseOfUs1;
            this.song17.Location = new System.Drawing.Point(0, 1488);
            this.song17.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.song17.Name = "song17";
            this.song17.NameSong = "Glimpse of Us";
            this.song17.Number = "17";
            this.song17.Size = new System.Drawing.Size(1620, 90);
            this.song17.TabIndex = 16;
            this.song17.Time = "03:53";
            // 
            // song18
            // 
            this.song18.Artist = "Kenny G";
            this.song18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.song18.Genre = "Nhạc không lời";
            this.song18.ImageSong = global::MusicApp.Properties.Resources.GoingHome1;
            this.song18.Location = new System.Drawing.Point(0, 1581);
            this.song18.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.song18.Name = "song18";
            this.song18.NameSong = "Going Home";
            this.song18.Number = "18";
            this.song18.Size = new System.Drawing.Size(1620, 90);
            this.song18.TabIndex = 17;
            this.song18.Time = "05:35";
            // 
            // song19
            // 
            this.song19.Artist = "Sơn Tùng M-TP";
            this.song19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.song19.Genre = "Nhạc Việt";
            this.song19.ImageSong = global::MusicApp.Properties.Resources.HayTraoChoAnh;
            this.song19.Location = new System.Drawing.Point(0, 1674);
            this.song19.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.song19.Name = "song19";
            this.song19.NameSong = "Hãy Trao Cho Anh";
            this.song19.Number = "19";
            this.song19.Size = new System.Drawing.Size(1620, 90);
            this.song19.TabIndex = 18;
            this.song19.Time = "04:05";
            // 
            // song20
            // 
            this.song20.Artist = "Hayd";
            this.song20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.song20.Genre = "Nhạc Âu Mỹ";
            this.song20.ImageSong = global::MusicApp.Properties.Resources.HeadInTheCloud1;
            this.song20.Location = new System.Drawing.Point(0, 1767);
            this.song20.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.song20.Name = "song20";
            this.song20.NameSong = "Head In The Clouds";
            this.song20.Number = "20";
            this.song20.Size = new System.Drawing.Size(1620, 90);
            this.song20.TabIndex = 19;
            this.song20.Time = "03:04";
            // 
            // song21
            // 
            this.song21.Artist = "Lil Z Poet";
            this.song21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.song21.Genre = "Nhạc Việt";
            this.song21.ImageSong = global::MusicApp.Properties.Resources.HoaVangNayTan21;
            this.song21.Location = new System.Drawing.Point(0, 1860);
            this.song21.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.song21.Name = "song21";
            this.song21.NameSong = "Hoa Vàng Nay Tàn";
            this.song21.Number = "21";
            this.song21.Size = new System.Drawing.Size(1620, 90);
            this.song21.TabIndex = 20;
            this.song21.Time = "03:51";
            // 
            // song22
            // 
            this.song22.Artist = "BIGBANG";
            this.song22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.song22.Genre = "Nhạc Hàn";
            this.song22.ImageSong = global::MusicApp.Properties.Resources.IfYou1;
            this.song22.Location = new System.Drawing.Point(0, 1953);
            this.song22.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.song22.Name = "song22";
            this.song22.NameSong = "If You";
            this.song22.Number = "22";
            this.song22.Size = new System.Drawing.Size(1620, 90);
            this.song22.TabIndex = 21;
            this.song22.Time = "04:24";
            // 
            // song23
            // 
            this.song23.Artist = "P!nk, Nate Ruess";
            this.song23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.song23.Genre = "Nhạc Âu Mỹ";
            this.song23.ImageSong = global::MusicApp.Properties.Resources.JustGiveMeAReason;
            this.song23.Location = new System.Drawing.Point(0, 2046);
            this.song23.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.song23.Name = "song23";
            this.song23.NameSong = "Just Give Me A Reason";
            this.song23.Number = "23";
            this.song23.Size = new System.Drawing.Size(1620, 90);
            this.song23.TabIndex = 22;
            this.song23.Time = "04:02";
            // 
            // song24
            // 
            this.song24.Artist = "Lil Z Poet";
            this.song24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.song24.Genre = "Nhạc Việt";
            this.song24.ImageSong = global::MusicApp.Properties.Resources.KeDienTinVaoTinhYeu;
            this.song24.Location = new System.Drawing.Point(0, 2139);
            this.song24.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.song24.Name = "song24";
            this.song24.NameSong = "Kẻ Điên Tin Vào Tình Yêu";
            this.song24.Number = "24";
            this.song24.Size = new System.Drawing.Size(1620, 90);
            this.song24.TabIndex = 23;
            this.song24.Time = "04:36";
            // 
            // song25
            // 
            this.song25.Artist = "Yiruma";
            this.song25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.song25.Genre = "Nhạc không lời";
            this.song25.ImageSong = global::MusicApp.Properties.Resources.KissTheRain;
            this.song25.Location = new System.Drawing.Point(0, 2232);
            this.song25.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.song25.Name = "song25";
            this.song25.NameSong = "Kiss The Rain";
            this.song25.Number = "25";
            this.song25.Size = new System.Drawing.Size(1620, 90);
            this.song25.TabIndex = 24;
            this.song25.Time = "04:14";
            // 
            // song26
            // 
            this.song26.Artist = "Lệ Quyên";
            this.song26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.song26.Genre = "Nhạc Trịnh";
            this.song26.ImageSong = global::MusicApp.Properties.Resources.MuaHong;
            this.song26.Location = new System.Drawing.Point(0, 2325);
            this.song26.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.song26.Name = "song26";
            this.song26.NameSong = "Mưa Hồng";
            this.song26.Number = "26";
            this.song26.Size = new System.Drawing.Size(1620, 90);
            this.song26.TabIndex = 25;
            this.song26.Time = "04:38";
            // 
            // song27
            // 
            this.song27.Artist = "Only C";
            this.song27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.song27.Genre = "Nhạc Việt";
            this.song27.ImageSong = global::MusicApp.Properties.Resources.NguoiDangThuongLaAnh;
            this.song27.Location = new System.Drawing.Point(0, 2418);
            this.song27.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.song27.Name = "song27";
            this.song27.NameSong = "Người Đáng Thương Là Anh";
            this.song27.Number = "27";
            this.song27.Size = new System.Drawing.Size(1620, 90);
            this.song27.TabIndex = 26;
            this.song27.Time = "05:12";
            // 
            // song28
            // 
            this.song28.Artist = "SOOBIN";
            this.song28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.song28.Genre = "Nhạc Việt";
            this.song28.ImageSong = global::MusicApp.Properties.Resources.SayGoodBye;
            this.song28.Location = new System.Drawing.Point(0, 2511);
            this.song28.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.song28.Name = "song28";
            this.song28.NameSong = "Say Goodbye";
            this.song28.Number = "28";
            this.song28.Size = new System.Drawing.Size(1620, 90);
            this.song28.TabIndex = 27;
            this.song28.Time = "04:06";
            // 
            // song29
            // 
            this.song29.Artist = "Wiz Khalifa, Charlie Puth";
            this.song29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.song29.Genre = "Nhạc Âu Mỹ";
            this.song29.ImageSong = global::MusicApp.Properties.Resources.SeeYouAgain;
            this.song29.Location = new System.Drawing.Point(0, 2604);
            this.song29.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.song29.Name = "song29";
            this.song29.NameSong = "See You Again";
            this.song29.Number = "29";
            this.song29.Size = new System.Drawing.Size(1620, 90);
            this.song29.TabIndex = 28;
            this.song29.Time = "03:49";
            // 
            // song30
            // 
            this.song30.Artist = "Emcee L (Da LAB), Badbies";
            this.song30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.song30.Genre = "Nhạc Việt";
            this.song30.ImageSong = global::MusicApp.Properties.Resources.srltdln;
            this.song30.Location = new System.Drawing.Point(0, 2697);
            this.song30.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.song30.Name = "song30";
            this.song30.NameSong = "Sinh Ra Là Thứ Đối Lập Nhau";
            this.song30.Number = "30";
            this.song30.Size = new System.Drawing.Size(1620, 90);
            this.song30.TabIndex = 29;
            this.song30.Time = "03:54";
            // 
            // song31
            // 
            this.song31.Artist = "Chanyeol, Punch";
            this.song31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.song31.Genre = "Nhạc Hàn";
            this.song31.ImageSong = global::MusicApp.Properties.Resources.StayWithMe;
            this.song31.Location = new System.Drawing.Point(0, 2790);
            this.song31.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.song31.Name = "song31";
            this.song31.NameSong = "Stay With Me";
            this.song31.Number = "31";
            this.song31.Size = new System.Drawing.Size(1620, 90);
            this.song31.TabIndex = 30;
            this.song31.Time = "03:13";
            // 
            // song32
            // 
            this.song32.Artist = "Ava Max";
            this.song32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.song32.Genre = "Nhạc Âu Mỹ";
            this.song32.ImageSong = global::MusicApp.Properties.Resources.SweetButPsycho;
            this.song32.Location = new System.Drawing.Point(0, 2883);
            this.song32.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.song32.Name = "song32";
            this.song32.NameSong = "Sweet But Psycho";
            this.song32.Number = "32";
            this.song32.Size = new System.Drawing.Size(1620, 90);
            this.song32.TabIndex = 31;
            this.song32.Time = "03:07";
            // 
            // song33
            // 
            this.song33.Artist = "Justatee, Phương Ly";
            this.song33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.song33.Genre = "Nhạc Việt";
            this.song33.ImageSong = global::MusicApp.Properties.Resources.ThangDien;
            this.song33.Location = new System.Drawing.Point(0, 2976);
            this.song33.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.song33.Name = "song33";
            this.song33.NameSong = "Thằng Điên";
            this.song33.Number = "33";
            this.song33.Size = new System.Drawing.Size(1620, 90);
            this.song33.TabIndex = 32;
            this.song33.Time = "03:55";
            // 
            // song34
            // 
            this.song34.Artist = "K.Will";
            this.song34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.song34.Genre = "Nhạc Hàn";
            this.song34.ImageSong = global::MusicApp.Properties.Resources.TheOnlyPerson;
            this.song34.Location = new System.Drawing.Point(0, 3069);
            this.song34.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.song34.Name = "song34";
            this.song34.NameSong = "The Only Person";
            this.song34.Number = "34";
            this.song34.Size = new System.Drawing.Size(1620, 90);
            this.song34.TabIndex = 33;
            this.song34.Time = "03:20";
            // 
            // song35
            // 
            this.song35.Artist = "Hồng Nhung";
            this.song35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.song35.Genre = "Nhạc Trịnh";
            this.song35.ImageSong = global::MusicApp.Properties.Resources.TuoiDaBuon;
            this.song35.Location = new System.Drawing.Point(0, 3162);
            this.song35.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.song35.Name = "song35";
            this.song35.NameSong = "Tuổi Đá Buồn";
            this.song35.Number = "35";
            this.song35.Size = new System.Drawing.Size(1620, 90);
            this.song35.TabIndex = 34;
            this.song35.Time = "05:57";
            // 
            // song36
            // 
            this.song36.Artist = "Davichi";
            this.song36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.song36.Genre = "Nhạc Hàn";
            this.song36.ImageSong = global::MusicApp.Properties.Resources.Turtle;
            this.song36.Location = new System.Drawing.Point(0, 3255);
            this.song36.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.song36.Name = "song36";
            this.song36.NameSong = "Turtle";
            this.song36.Number = "36";
            this.song36.Size = new System.Drawing.Size(1620, 90);
            this.song36.TabIndex = 35;
            this.song36.Time = "03:43";
            // 
            // song37
            // 
            this.song37.Artist = "Madihu, Vũ";
            this.song37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.song37.Genre = "Nhạc Việt";
            this.song37.ImageSong = global::MusicApp.Properties.Resources.ViAnhDauCoBiet;
            this.song37.Location = new System.Drawing.Point(0, 3348);
            this.song37.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.song37.Name = "song37";
            this.song37.NameSong = "Vì Anh Đâu Có Biết";
            this.song37.Number = "37";
            this.song37.Size = new System.Drawing.Size(1620, 90);
            this.song37.TabIndex = 36;
            this.song37.Time = "04:01";
            // 
            // song38
            // 
            this.song38.Artist = "Two Steps From Hell";
            this.song38.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.song38.Genre = "Nhạc không lời";
            this.song38.ImageSong = global::MusicApp.Properties.Resources.Victory;
            this.song38.Location = new System.Drawing.Point(0, 3441);
            this.song38.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.song38.Name = "song38";
            this.song38.NameSong = "Victory";
            this.song38.Number = "38";
            this.song38.Size = new System.Drawing.Size(1620, 90);
            this.song38.TabIndex = 37;
            this.song38.Time = "05:20";
            // 
            // song39
            // 
            this.song39.Artist = "Imagine Dragons";
            this.song39.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.song39.Genre = "Nhạc Âu Mỹ";
            this.song39.ImageSong = global::MusicApp.Properties.Resources.WhateverItTakes;
            this.song39.Location = new System.Drawing.Point(0, 3534);
            this.song39.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.song39.Name = "song39";
            this.song39.NameSong = "Whatever It Takes";
            this.song39.Number = "39";
            this.song39.Size = new System.Drawing.Size(1620, 90);
            this.song39.TabIndex = 38;
            this.song39.Time = "03:21";
            // 
            // song40
            // 
            this.song40.Artist = "Only C, Karik";
            this.song40.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.song40.Genre = "Nhạc Việt";
            this.song40.ImageSong = global::MusicApp.Properties.Resources.YeuDonPhuong;
            this.song40.Location = new System.Drawing.Point(0, 3627);
            this.song40.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.song40.Name = "song40";
            this.song40.NameSong = "Yêu Đơn Phương";
            this.song40.Number = "40";
            this.song40.Size = new System.Drawing.Size(1620, 90);
            this.song40.TabIndex = 39;
            this.song40.Time = "04:28";
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnHeader.Controls.Add(this.txtTime);
            this.pnHeader.Controls.Add(this.txtGenre);
            this.pnHeader.Controls.Add(this.txtTitle);
            this.pnHeader.Controls.Add(this.txtNumber);
            this.pnHeader.Controls.Add(this.txboxFind);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(3, 3);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(1616, 178);
            this.pnHeader.TabIndex = 7;
            // 
            // txtTime
            // 
            this.txtTime.ForeColor = System.Drawing.Color.White;
            this.txtTime.Image = global::MusicApp.Properties.Resources.clock;
            this.txtTime.Location = new System.Drawing.Point(1526, 124);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(32, 32);
            this.txtTime.TabIndex = 9;
            // 
            // txtGenre
            // 
            this.txtGenre.Font = new System.Drawing.Font("Segoe UI", 19.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGenre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.txtGenre.Location = new System.Drawing.Point(764, 124);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(139, 41);
            this.txtGenre.TabIndex = 8;
            this.txtGenre.Text = "Thể Loại";
            this.txtGenre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 19.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.txtTitle.Location = new System.Drawing.Point(88, 124);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(128, 39);
            this.txtTitle.TabIndex = 8;
            this.txtTitle.Text = "Tiêu Đề";
            this.txtTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("Segoe UI", 19.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.txtNumber.Location = new System.Drawing.Point(23, 124);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(21, 39);
            this.txtNumber.TabIndex = 8;
            this.txtNumber.Text = "#";
            this.txtNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.txboxFind.DefaultFont = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.txboxFind.Size = new System.Drawing.Size(850, 60);
            this.txboxFind.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txboxFind.TabIndex = 7;
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
            this.pageGenre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.pageGenre.Controls.Add(this.genre4);
            this.pageGenre.Controls.Add(this.genre3);
            this.pageGenre.Controls.Add(this.genre2);
            this.pageGenre.Controls.Add(this.genre5);
            this.pageGenre.Controls.Add(this.genre1);
            this.pageGenre.Location = new System.Drawing.Point(4, 4);
            this.pageGenre.Name = "pageGenre";
            this.pageGenre.Padding = new System.Windows.Forms.Padding(3);
            this.pageGenre.Size = new System.Drawing.Size(1622, 865);
            this.pageGenre.TabIndex = 1;
            this.pageGenre.Text = "Thể loại";
            // 
            // genre4
            // 
            this.genre4.BackColor = System.Drawing.Color.Transparent;
            this.genre4.Image = global::MusicApp.Properties.Resources.NhacKLoi;
            this.genre4.Label = "Nhạc không lời";
            this.genre4.Location = new System.Drawing.Point(1226, 107);
            this.genre4.Margin = new System.Windows.Forms.Padding(0);
            this.genre4.Name = "genre4";
            this.genre4.Size = new System.Drawing.Size(261, 292);
            this.genre4.TabIndex = 2;
            this.genre4.PicClick += new System.EventHandler(this.genre4_PicClick);
            // 
            // genre3
            // 
            this.genre3.BackColor = System.Drawing.Color.Transparent;
            this.genre3.Image = ((System.Drawing.Image)(resources.GetObject("genre3.Image")));
            this.genre3.Label = "Nhạc Âu Mĩ";
            this.genre3.Location = new System.Drawing.Point(865, 107);
            this.genre3.Margin = new System.Windows.Forms.Padding(0);
            this.genre3.Name = "genre3";
            this.genre3.Size = new System.Drawing.Size(261, 292);
            this.genre3.TabIndex = 2;
            this.genre3.PicClick += new System.EventHandler(this.genre3_PicClick);
            // 
            // genre2
            // 
            this.genre2.BackColor = System.Drawing.Color.Transparent;
            this.genre2.Image = ((System.Drawing.Image)(resources.GetObject("genre2.Image")));
            this.genre2.Label = "Nhạc Hàn";
            this.genre2.Location = new System.Drawing.Point(504, 107);
            this.genre2.Margin = new System.Windows.Forms.Padding(0);
            this.genre2.Name = "genre2";
            this.genre2.Size = new System.Drawing.Size(261, 292);
            this.genre2.TabIndex = 1;
            this.genre2.PicClick += new System.EventHandler(this.genre2_PicClick);
            // 
            // genre5
            // 
            this.genre5.BackColor = System.Drawing.Color.Transparent;
            this.genre5.Image = ((System.Drawing.Image)(resources.GetObject("genre5.Image")));
            this.genre5.Label = "Nhạc Trịnh";
            this.genre5.Location = new System.Drawing.Point(143, 499);
            this.genre5.Margin = new System.Windows.Forms.Padding(0);
            this.genre5.Name = "genre5";
            this.genre5.Size = new System.Drawing.Size(261, 292);
            this.genre5.TabIndex = 0;
            this.genre5.PicClick += new System.EventHandler(this.genre5_PicClick);
            // 
            // genre1
            // 
            this.genre1.BackColor = System.Drawing.Color.Transparent;
            this.genre1.Image = ((System.Drawing.Image)(resources.GetObject("genre1.Image")));
            this.genre1.Label = "Nhạc Việt";
            this.genre1.Location = new System.Drawing.Point(143, 107);
            this.genre1.Margin = new System.Windows.Forms.Padding(0);
            this.genre1.Name = "genre1";
            this.genre1.Size = new System.Drawing.Size(261, 292);
            this.genre1.TabIndex = 0;
            this.genre1.PicClick += new System.EventHandler(this.genre1_PicClick);
            // 
            // pageCollection
            // 
            this.pageCollection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.pageCollection.Controls.Add(this.fpnPlaylist);
            this.pageCollection.Controls.Add(this.btnAddList);
            this.pageCollection.Location = new System.Drawing.Point(4, 4);
            this.pageCollection.Name = "pageCollection";
            this.pageCollection.Size = new System.Drawing.Size(1622, 865);
            this.pageCollection.TabIndex = 2;
            this.pageCollection.Text = "Thư viện";
            // 
            // fpnPlaylist
            // 
            this.fpnPlaylist.AllowDrop = true;
            this.fpnPlaylist.AutoScroll = true;
            this.fpnPlaylist.Controls.Add(this.liked1);
            this.fpnPlaylist.Controls.Add(this.playlist1);
            this.fpnPlaylist.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fpnPlaylist.Location = new System.Drawing.Point(0, 94);
            this.fpnPlaylist.Name = "fpnPlaylist";
            this.fpnPlaylist.Size = new System.Drawing.Size(1622, 771);
            this.fpnPlaylist.TabIndex = 1;
            // 
            // liked1
            // 
            this.liked1.BackColor = System.Drawing.Color.Transparent;
            this.liked1.Location = new System.Drawing.Point(50, 0);
            this.liked1.Margin = new System.Windows.Forms.Padding(50, 0, 0, 50);
            this.liked1.Name = "liked1";
            this.liked1.Size = new System.Drawing.Size(261, 292);
            this.liked1.TabIndex = 0;
            // 
            // playlist1
            // 
            this.playlist1.BackColor = System.Drawing.Color.Transparent;
            this.playlist1.Image = ((System.Drawing.Image)(resources.GetObject("playlist1.Image")));
            this.playlist1.Location = new System.Drawing.Point(361, 0);
            this.playlist1.Margin = new System.Windows.Forms.Padding(50, 0, 0, 50);
            this.playlist1.Name = "playlist1";
            this.playlist1.Size = new System.Drawing.Size(261, 292);
            this.playlist1.TabIndex = 1;
            this.playlist1.Title = "Danh sách phát số 1";
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
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.btnAddList.CustomizableEdges = borderEdges5;
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
            // pageHistory
            // 
            this.pageHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.pageHistory.Location = new System.Drawing.Point(4, 4);
            this.pageHistory.Name = "pageHistory";
            this.pageHistory.Padding = new System.Windows.Forms.Padding(3);
            this.pageHistory.Size = new System.Drawing.Size(1622, 865);
            this.pageHistory.TabIndex = 4;
            this.pageHistory.Text = "Lịch sử";
            // 
            // pageInfo
            // 
            this.pageInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.pageInfo.Controls.Add(this.pictureBox1);
            this.pageInfo.Controls.Add(this.fpnComment);
            this.pageInfo.Controls.Add(this.txtOneStar);
            this.pageInfo.Controls.Add(this.txtTwoStar);
            this.pageInfo.Controls.Add(this.txtThreeStar);
            this.pageInfo.Controls.Add(this.txtFourStar);
            this.pageInfo.Controls.Add(this.txtFiveStar);
            this.pageInfo.Controls.Add(this.btnOneStar);
            this.pageInfo.Controls.Add(this.btnTwoStar);
            this.pageInfo.Controls.Add(this.btnThreeStar);
            this.pageInfo.Controls.Add(this.BtnFourStar);
            this.pageInfo.Controls.Add(this.btnFiveStar);
            this.pageInfo.Controls.Add(this.btnComment);
            this.pageInfo.Controls.Add(this.line);
            this.pageInfo.Controls.Add(this.txtRattingPoint);
            this.pageInfo.Controls.Add(this.pBack);
            this.pageInfo.Controls.Add(this.label1);
            this.pageInfo.Controls.Add(this.lbGenre);
            this.pageInfo.Controls.Add(this.lbYear);
            this.pageInfo.Controls.Add(this.lbArtirst);
            this.pageInfo.Controls.Add(this.txtInfoGenre);
            this.pageInfo.Controls.Add(this.txtYear);
            this.pageInfo.Controls.Add(this.txtInfoArtist);
            this.pageInfo.Controls.Add(this.txtComposer);
            this.pageInfo.Controls.Add(this.lbComposer);
            this.pageInfo.Controls.Add(this.txtNameSong);
            this.pageInfo.Controls.Add(this.pInforSong);
            this.pageInfo.Location = new System.Drawing.Point(4, 4);
            this.pageInfo.Name = "pageInfo";
            this.pageInfo.Padding = new System.Windows.Forms.Padding(3);
            this.pageInfo.Size = new System.Drawing.Size(1622, 865);
            this.pageInfo.TabIndex = 5;
            this.pageInfo.Text = "Thông Tin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MusicApp.Properties.Resources.star_green;
            this.pictureBox1.Location = new System.Drawing.Point(191, 442);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // fpnComment
            // 
            this.fpnComment.AllowDrop = true;
            this.fpnComment.AutoScroll = true;
            this.fpnComment.Controls.Add(this.comment1);
            this.fpnComment.Location = new System.Drawing.Point(442, 430);
            this.fpnComment.Margin = new System.Windows.Forms.Padding(0);
            this.fpnComment.Name = "fpnComment";
            this.fpnComment.Size = new System.Drawing.Size(1202, 435);
            this.fpnComment.TabIndex = 9;
            // 
            // comment1
            // 
            this.comment1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.comment1.ImageUser = ((System.Drawing.Image)(resources.GetObject("comment1.ImageUser")));
            this.comment1.Location = new System.Drawing.Point(0, 0);
            this.comment1.Margin = new System.Windows.Forms.Padding(0);
            this.comment1.Name = "comment1";
            this.comment1.NameUser = "ShengKai";
            this.comment1.Ratting = 5;
            this.comment1.Size = new System.Drawing.Size(1170, 124);
            this.comment1.TabIndex = 0;
            this.comment1.TextCmt = "Bài hát hay";
            // 
            // txtOneStar
            // 
            this.txtOneStar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOneStar.ForeColor = System.Drawing.Color.White;
            this.txtOneStar.Location = new System.Drawing.Point(245, 806);
            this.txtOneStar.Name = "txtOneStar";
            this.txtOneStar.Size = new System.Drawing.Size(15, 27);
            this.txtOneStar.TabIndex = 8;
            this.txtOneStar.Text = "1";
            this.txtOneStar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTwoStar
            // 
            this.txtTwoStar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTwoStar.ForeColor = System.Drawing.Color.White;
            this.txtTwoStar.Location = new System.Drawing.Point(245, 736);
            this.txtTwoStar.Name = "txtTwoStar";
            this.txtTwoStar.Size = new System.Drawing.Size(15, 27);
            this.txtTwoStar.TabIndex = 8;
            this.txtTwoStar.Text = "0";
            this.txtTwoStar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtThreeStar
            // 
            this.txtThreeStar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtThreeStar.ForeColor = System.Drawing.Color.White;
            this.txtThreeStar.Location = new System.Drawing.Point(245, 666);
            this.txtThreeStar.Name = "txtThreeStar";
            this.txtThreeStar.Size = new System.Drawing.Size(15, 27);
            this.txtThreeStar.TabIndex = 8;
            this.txtThreeStar.Text = "0";
            this.txtThreeStar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFourStar
            // 
            this.txtFourStar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFourStar.ForeColor = System.Drawing.Color.White;
            this.txtFourStar.Location = new System.Drawing.Point(245, 596);
            this.txtFourStar.Name = "txtFourStar";
            this.txtFourStar.Size = new System.Drawing.Size(15, 27);
            this.txtFourStar.TabIndex = 8;
            this.txtFourStar.Text = "0";
            this.txtFourStar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFiveStar
            // 
            this.txtFiveStar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFiveStar.ForeColor = System.Drawing.Color.White;
            this.txtFiveStar.Location = new System.Drawing.Point(245, 526);
            this.txtFiveStar.Name = "txtFiveStar";
            this.txtFiveStar.Size = new System.Drawing.Size(15, 27);
            this.txtFiveStar.TabIndex = 8;
            this.txtFiveStar.Text = "1";
            this.txtFiveStar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOneStar
            // 
            this.btnOneStar.AllowAnimations = true;
            this.btnOneStar.AllowMouseEffects = true;
            this.btnOneStar.AllowToggling = false;
            this.btnOneStar.AnimationSpeed = 200;
            this.btnOneStar.AutoGenerateColors = false;
            this.btnOneStar.AutoRoundBorders = false;
            this.btnOneStar.AutoSizeLeftIcon = false;
            this.btnOneStar.AutoSizeRightIcon = false;
            this.btnOneStar.BackColor = System.Drawing.Color.Transparent;
            this.btnOneStar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnOneStar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOneStar.BackgroundImage")));
            this.btnOneStar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnOneStar.ButtonText = "1 sao";
            this.btnOneStar.ButtonTextMarginLeft = 0;
            this.btnOneStar.ColorContrastOnClick = 45;
            this.btnOneStar.ColorContrastOnHover = 45;
            this.btnOneStar.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            this.btnOneStar.CustomizableEdges = borderEdges6;
            this.btnOneStar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnOneStar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnOneStar.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnOneStar.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnOneStar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnOneStar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOneStar.ForeColor = System.Drawing.Color.White;
            this.btnOneStar.IconLeft = null;
            this.btnOneStar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOneStar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnOneStar.IconLeftPadding = new System.Windows.Forms.Padding(0);
            this.btnOneStar.IconMarginLeft = 11;
            this.btnOneStar.IconPadding = 0;
            this.btnOneStar.IconRight = null;
            this.btnOneStar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOneStar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnOneStar.IconRightPadding = new System.Windows.Forms.Padding(0, 0, 13, 0);
            this.btnOneStar.IconSize = 0;
            this.btnOneStar.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnOneStar.IdleBorderRadius = 0;
            this.btnOneStar.IdleBorderThickness = 0;
            this.btnOneStar.IdleFillColor = System.Drawing.Color.Empty;
            this.btnOneStar.IdleIconLeftImage = null;
            this.btnOneStar.IdleIconRightImage = null;
            this.btnOneStar.IndicateFocus = false;
            this.btnOneStar.Location = new System.Drawing.Point(127, 793);
            this.btnOneStar.Name = "btnOneStar";
            this.btnOneStar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(148)))), ((int)(((byte)(20)))));
            this.btnOneStar.OnDisabledState.BorderRadius = 20;
            this.btnOneStar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnOneStar.OnDisabledState.BorderThickness = 0;
            this.btnOneStar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(148)))), ((int)(((byte)(20)))));
            this.btnOneStar.OnDisabledState.ForeColor = System.Drawing.Color.White;
            this.btnOneStar.OnDisabledState.IconLeftImage = null;
            this.btnOneStar.OnDisabledState.IconRightImage = null;
            this.btnOneStar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(196)))), ((int)(((byte)(125)))));
            this.btnOneStar.onHoverState.BorderRadius = 20;
            this.btnOneStar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnOneStar.onHoverState.BorderThickness = 0;
            this.btnOneStar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(196)))), ((int)(((byte)(125)))));
            this.btnOneStar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnOneStar.onHoverState.IconLeftImage = null;
            this.btnOneStar.onHoverState.IconRightImage = null;
            this.btnOneStar.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(148)))), ((int)(((byte)(20)))));
            this.btnOneStar.OnIdleState.BorderRadius = 20;
            this.btnOneStar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnOneStar.OnIdleState.BorderThickness = 0;
            this.btnOneStar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(148)))), ((int)(((byte)(20)))));
            this.btnOneStar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnOneStar.OnIdleState.IconLeftImage = null;
            this.btnOneStar.OnIdleState.IconRightImage = null;
            this.btnOneStar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(148)))), ((int)(((byte)(20)))));
            this.btnOneStar.OnPressedState.BorderRadius = 20;
            this.btnOneStar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnOneStar.OnPressedState.BorderThickness = 0;
            this.btnOneStar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(148)))), ((int)(((byte)(20)))));
            this.btnOneStar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnOneStar.OnPressedState.IconLeftImage = null;
            this.btnOneStar.OnPressedState.IconRightImage = null;
            this.btnOneStar.Size = new System.Drawing.Size(98, 50);
            this.btnOneStar.TabIndex = 7;
            this.btnOneStar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOneStar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnOneStar.TextMarginLeft = 0;
            this.btnOneStar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnOneStar.UseDefaultRadiusAndThickness = true;
            // 
            // btnTwoStar
            // 
            this.btnTwoStar.AllowAnimations = true;
            this.btnTwoStar.AllowMouseEffects = true;
            this.btnTwoStar.AllowToggling = false;
            this.btnTwoStar.AnimationSpeed = 200;
            this.btnTwoStar.AutoGenerateColors = false;
            this.btnTwoStar.AutoRoundBorders = false;
            this.btnTwoStar.AutoSizeLeftIcon = false;
            this.btnTwoStar.AutoSizeRightIcon = false;
            this.btnTwoStar.BackColor = System.Drawing.Color.Transparent;
            this.btnTwoStar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnTwoStar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTwoStar.BackgroundImage")));
            this.btnTwoStar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTwoStar.ButtonText = "2 sao";
            this.btnTwoStar.ButtonTextMarginLeft = 0;
            this.btnTwoStar.ColorContrastOnClick = 45;
            this.btnTwoStar.ColorContrastOnHover = 45;
            this.btnTwoStar.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges7.BottomLeft = true;
            borderEdges7.BottomRight = true;
            borderEdges7.TopLeft = true;
            borderEdges7.TopRight = true;
            this.btnTwoStar.CustomizableEdges = borderEdges7;
            this.btnTwoStar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTwoStar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnTwoStar.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnTwoStar.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnTwoStar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnTwoStar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTwoStar.ForeColor = System.Drawing.Color.White;
            this.btnTwoStar.IconLeft = null;
            this.btnTwoStar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTwoStar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnTwoStar.IconLeftPadding = new System.Windows.Forms.Padding(0);
            this.btnTwoStar.IconMarginLeft = 11;
            this.btnTwoStar.IconPadding = 0;
            this.btnTwoStar.IconRight = null;
            this.btnTwoStar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTwoStar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnTwoStar.IconRightPadding = new System.Windows.Forms.Padding(0, 0, 13, 0);
            this.btnTwoStar.IconSize = 0;
            this.btnTwoStar.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnTwoStar.IdleBorderRadius = 0;
            this.btnTwoStar.IdleBorderThickness = 0;
            this.btnTwoStar.IdleFillColor = System.Drawing.Color.Empty;
            this.btnTwoStar.IdleIconLeftImage = null;
            this.btnTwoStar.IdleIconRightImage = null;
            this.btnTwoStar.IndicateFocus = false;
            this.btnTwoStar.Location = new System.Drawing.Point(127, 723);
            this.btnTwoStar.Name = "btnTwoStar";
            this.btnTwoStar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(148)))), ((int)(((byte)(20)))));
            this.btnTwoStar.OnDisabledState.BorderRadius = 20;
            this.btnTwoStar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTwoStar.OnDisabledState.BorderThickness = 0;
            this.btnTwoStar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(148)))), ((int)(((byte)(20)))));
            this.btnTwoStar.OnDisabledState.ForeColor = System.Drawing.Color.White;
            this.btnTwoStar.OnDisabledState.IconLeftImage = null;
            this.btnTwoStar.OnDisabledState.IconRightImage = null;
            this.btnTwoStar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(196)))), ((int)(((byte)(125)))));
            this.btnTwoStar.onHoverState.BorderRadius = 20;
            this.btnTwoStar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTwoStar.onHoverState.BorderThickness = 0;
            this.btnTwoStar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(196)))), ((int)(((byte)(125)))));
            this.btnTwoStar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnTwoStar.onHoverState.IconLeftImage = null;
            this.btnTwoStar.onHoverState.IconRightImage = null;
            this.btnTwoStar.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(148)))), ((int)(((byte)(20)))));
            this.btnTwoStar.OnIdleState.BorderRadius = 20;
            this.btnTwoStar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTwoStar.OnIdleState.BorderThickness = 0;
            this.btnTwoStar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(148)))), ((int)(((byte)(20)))));
            this.btnTwoStar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnTwoStar.OnIdleState.IconLeftImage = null;
            this.btnTwoStar.OnIdleState.IconRightImage = null;
            this.btnTwoStar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(148)))), ((int)(((byte)(20)))));
            this.btnTwoStar.OnPressedState.BorderRadius = 20;
            this.btnTwoStar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnTwoStar.OnPressedState.BorderThickness = 0;
            this.btnTwoStar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(148)))), ((int)(((byte)(20)))));
            this.btnTwoStar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnTwoStar.OnPressedState.IconLeftImage = null;
            this.btnTwoStar.OnPressedState.IconRightImage = null;
            this.btnTwoStar.Size = new System.Drawing.Size(98, 50);
            this.btnTwoStar.TabIndex = 7;
            this.btnTwoStar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTwoStar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnTwoStar.TextMarginLeft = 0;
            this.btnTwoStar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnTwoStar.UseDefaultRadiusAndThickness = true;
            // 
            // btnThreeStar
            // 
            this.btnThreeStar.AllowAnimations = true;
            this.btnThreeStar.AllowMouseEffects = true;
            this.btnThreeStar.AllowToggling = false;
            this.btnThreeStar.AnimationSpeed = 200;
            this.btnThreeStar.AutoGenerateColors = false;
            this.btnThreeStar.AutoRoundBorders = false;
            this.btnThreeStar.AutoSizeLeftIcon = false;
            this.btnThreeStar.AutoSizeRightIcon = false;
            this.btnThreeStar.BackColor = System.Drawing.Color.Transparent;
            this.btnThreeStar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnThreeStar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThreeStar.BackgroundImage")));
            this.btnThreeStar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnThreeStar.ButtonText = "3 sao";
            this.btnThreeStar.ButtonTextMarginLeft = 0;
            this.btnThreeStar.ColorContrastOnClick = 45;
            this.btnThreeStar.ColorContrastOnHover = 45;
            this.btnThreeStar.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges8.BottomLeft = true;
            borderEdges8.BottomRight = true;
            borderEdges8.TopLeft = true;
            borderEdges8.TopRight = true;
            this.btnThreeStar.CustomizableEdges = borderEdges8;
            this.btnThreeStar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThreeStar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnThreeStar.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnThreeStar.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnThreeStar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnThreeStar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnThreeStar.ForeColor = System.Drawing.Color.White;
            this.btnThreeStar.IconLeft = null;
            this.btnThreeStar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThreeStar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnThreeStar.IconLeftPadding = new System.Windows.Forms.Padding(0);
            this.btnThreeStar.IconMarginLeft = 11;
            this.btnThreeStar.IconPadding = 0;
            this.btnThreeStar.IconRight = null;
            this.btnThreeStar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThreeStar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnThreeStar.IconRightPadding = new System.Windows.Forms.Padding(0, 0, 13, 0);
            this.btnThreeStar.IconSize = 0;
            this.btnThreeStar.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnThreeStar.IdleBorderRadius = 0;
            this.btnThreeStar.IdleBorderThickness = 0;
            this.btnThreeStar.IdleFillColor = System.Drawing.Color.Empty;
            this.btnThreeStar.IdleIconLeftImage = null;
            this.btnThreeStar.IdleIconRightImage = null;
            this.btnThreeStar.IndicateFocus = false;
            this.btnThreeStar.Location = new System.Drawing.Point(127, 653);
            this.btnThreeStar.Name = "btnThreeStar";
            this.btnThreeStar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(148)))), ((int)(((byte)(20)))));
            this.btnThreeStar.OnDisabledState.BorderRadius = 20;
            this.btnThreeStar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnThreeStar.OnDisabledState.BorderThickness = 0;
            this.btnThreeStar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(148)))), ((int)(((byte)(20)))));
            this.btnThreeStar.OnDisabledState.ForeColor = System.Drawing.Color.White;
            this.btnThreeStar.OnDisabledState.IconLeftImage = null;
            this.btnThreeStar.OnDisabledState.IconRightImage = null;
            this.btnThreeStar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(196)))), ((int)(((byte)(125)))));
            this.btnThreeStar.onHoverState.BorderRadius = 20;
            this.btnThreeStar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnThreeStar.onHoverState.BorderThickness = 0;
            this.btnThreeStar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(196)))), ((int)(((byte)(125)))));
            this.btnThreeStar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnThreeStar.onHoverState.IconLeftImage = null;
            this.btnThreeStar.onHoverState.IconRightImage = null;
            this.btnThreeStar.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(148)))), ((int)(((byte)(20)))));
            this.btnThreeStar.OnIdleState.BorderRadius = 20;
            this.btnThreeStar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnThreeStar.OnIdleState.BorderThickness = 0;
            this.btnThreeStar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(148)))), ((int)(((byte)(20)))));
            this.btnThreeStar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnThreeStar.OnIdleState.IconLeftImage = null;
            this.btnThreeStar.OnIdleState.IconRightImage = null;
            this.btnThreeStar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(148)))), ((int)(((byte)(20)))));
            this.btnThreeStar.OnPressedState.BorderRadius = 20;
            this.btnThreeStar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnThreeStar.OnPressedState.BorderThickness = 0;
            this.btnThreeStar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(148)))), ((int)(((byte)(20)))));
            this.btnThreeStar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnThreeStar.OnPressedState.IconLeftImage = null;
            this.btnThreeStar.OnPressedState.IconRightImage = null;
            this.btnThreeStar.Size = new System.Drawing.Size(98, 50);
            this.btnThreeStar.TabIndex = 7;
            this.btnThreeStar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThreeStar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnThreeStar.TextMarginLeft = 0;
            this.btnThreeStar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnThreeStar.UseDefaultRadiusAndThickness = true;
            // 
            // BtnFourStar
            // 
            this.BtnFourStar.AllowAnimations = true;
            this.BtnFourStar.AllowMouseEffects = true;
            this.BtnFourStar.AllowToggling = false;
            this.BtnFourStar.AnimationSpeed = 200;
            this.BtnFourStar.AutoGenerateColors = false;
            this.BtnFourStar.AutoRoundBorders = false;
            this.BtnFourStar.AutoSizeLeftIcon = false;
            this.BtnFourStar.AutoSizeRightIcon = false;
            this.BtnFourStar.BackColor = System.Drawing.Color.Transparent;
            this.BtnFourStar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.BtnFourStar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnFourStar.BackgroundImage")));
            this.BtnFourStar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnFourStar.ButtonText = "4 sao";
            this.BtnFourStar.ButtonTextMarginLeft = 0;
            this.BtnFourStar.ColorContrastOnClick = 45;
            this.BtnFourStar.ColorContrastOnHover = 45;
            this.BtnFourStar.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges9.BottomLeft = true;
            borderEdges9.BottomRight = true;
            borderEdges9.TopLeft = true;
            borderEdges9.TopRight = true;
            this.BtnFourStar.CustomizableEdges = borderEdges9;
            this.BtnFourStar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnFourStar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnFourStar.DisabledFillColor = System.Drawing.Color.Empty;
            this.BtnFourStar.DisabledForecolor = System.Drawing.Color.Empty;
            this.BtnFourStar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.BtnFourStar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnFourStar.ForeColor = System.Drawing.Color.White;
            this.BtnFourStar.IconLeft = null;
            this.BtnFourStar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFourStar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.BtnFourStar.IconLeftPadding = new System.Windows.Forms.Padding(0);
            this.BtnFourStar.IconMarginLeft = 11;
            this.BtnFourStar.IconPadding = 0;
            this.BtnFourStar.IconRight = null;
            this.BtnFourStar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnFourStar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.BtnFourStar.IconRightPadding = new System.Windows.Forms.Padding(0, 0, 13, 0);
            this.BtnFourStar.IconSize = 0;
            this.BtnFourStar.IdleBorderColor = System.Drawing.Color.Empty;
            this.BtnFourStar.IdleBorderRadius = 0;
            this.BtnFourStar.IdleBorderThickness = 0;
            this.BtnFourStar.IdleFillColor = System.Drawing.Color.Empty;
            this.BtnFourStar.IdleIconLeftImage = null;
            this.BtnFourStar.IdleIconRightImage = null;
            this.BtnFourStar.IndicateFocus = false;
            this.BtnFourStar.Location = new System.Drawing.Point(127, 583);
            this.BtnFourStar.Name = "BtnFourStar";
            this.BtnFourStar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(148)))), ((int)(((byte)(20)))));
            this.BtnFourStar.OnDisabledState.BorderRadius = 20;
            this.BtnFourStar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnFourStar.OnDisabledState.BorderThickness = 0;
            this.BtnFourStar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(148)))), ((int)(((byte)(20)))));
            this.BtnFourStar.OnDisabledState.ForeColor = System.Drawing.Color.White;
            this.BtnFourStar.OnDisabledState.IconLeftImage = null;
            this.BtnFourStar.OnDisabledState.IconRightImage = null;
            this.BtnFourStar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(196)))), ((int)(((byte)(125)))));
            this.BtnFourStar.onHoverState.BorderRadius = 20;
            this.BtnFourStar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnFourStar.onHoverState.BorderThickness = 0;
            this.BtnFourStar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(196)))), ((int)(((byte)(125)))));
            this.BtnFourStar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.BtnFourStar.onHoverState.IconLeftImage = null;
            this.BtnFourStar.onHoverState.IconRightImage = null;
            this.BtnFourStar.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(148)))), ((int)(((byte)(20)))));
            this.BtnFourStar.OnIdleState.BorderRadius = 20;
            this.BtnFourStar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnFourStar.OnIdleState.BorderThickness = 0;
            this.BtnFourStar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(148)))), ((int)(((byte)(20)))));
            this.BtnFourStar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.BtnFourStar.OnIdleState.IconLeftImage = null;
            this.BtnFourStar.OnIdleState.IconRightImage = null;
            this.BtnFourStar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(148)))), ((int)(((byte)(20)))));
            this.BtnFourStar.OnPressedState.BorderRadius = 20;
            this.BtnFourStar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnFourStar.OnPressedState.BorderThickness = 0;
            this.BtnFourStar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(148)))), ((int)(((byte)(20)))));
            this.BtnFourStar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.BtnFourStar.OnPressedState.IconLeftImage = null;
            this.BtnFourStar.OnPressedState.IconRightImage = null;
            this.BtnFourStar.Size = new System.Drawing.Size(98, 50);
            this.BtnFourStar.TabIndex = 7;
            this.BtnFourStar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnFourStar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnFourStar.TextMarginLeft = 0;
            this.BtnFourStar.TextPadding = new System.Windows.Forms.Padding(0);
            this.BtnFourStar.UseDefaultRadiusAndThickness = true;
            // 
            // btnFiveStar
            // 
            this.btnFiveStar.AllowAnimations = true;
            this.btnFiveStar.AllowMouseEffects = true;
            this.btnFiveStar.AllowToggling = false;
            this.btnFiveStar.AnimationSpeed = 200;
            this.btnFiveStar.AutoGenerateColors = false;
            this.btnFiveStar.AutoRoundBorders = false;
            this.btnFiveStar.AutoSizeLeftIcon = false;
            this.btnFiveStar.AutoSizeRightIcon = false;
            this.btnFiveStar.BackColor = System.Drawing.Color.Transparent;
            this.btnFiveStar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnFiveStar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFiveStar.BackgroundImage")));
            this.btnFiveStar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFiveStar.ButtonText = "5 sao";
            this.btnFiveStar.ButtonTextMarginLeft = 0;
            this.btnFiveStar.ColorContrastOnClick = 45;
            this.btnFiveStar.ColorContrastOnHover = 45;
            this.btnFiveStar.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges10.BottomLeft = true;
            borderEdges10.BottomRight = true;
            borderEdges10.TopLeft = true;
            borderEdges10.TopRight = true;
            this.btnFiveStar.CustomizableEdges = borderEdges10;
            this.btnFiveStar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFiveStar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnFiveStar.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnFiveStar.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnFiveStar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnFiveStar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFiveStar.ForeColor = System.Drawing.Color.White;
            this.btnFiveStar.IconLeft = null;
            this.btnFiveStar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiveStar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnFiveStar.IconLeftPadding = new System.Windows.Forms.Padding(0);
            this.btnFiveStar.IconMarginLeft = 11;
            this.btnFiveStar.IconPadding = 0;
            this.btnFiveStar.IconRight = null;
            this.btnFiveStar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFiveStar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnFiveStar.IconRightPadding = new System.Windows.Forms.Padding(0, 0, 13, 0);
            this.btnFiveStar.IconSize = 0;
            this.btnFiveStar.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnFiveStar.IdleBorderRadius = 0;
            this.btnFiveStar.IdleBorderThickness = 0;
            this.btnFiveStar.IdleFillColor = System.Drawing.Color.Empty;
            this.btnFiveStar.IdleIconLeftImage = null;
            this.btnFiveStar.IdleIconRightImage = null;
            this.btnFiveStar.IndicateFocus = false;
            this.btnFiveStar.Location = new System.Drawing.Point(127, 513);
            this.btnFiveStar.Name = "btnFiveStar";
            this.btnFiveStar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(148)))), ((int)(((byte)(20)))));
            this.btnFiveStar.OnDisabledState.BorderRadius = 20;
            this.btnFiveStar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFiveStar.OnDisabledState.BorderThickness = 0;
            this.btnFiveStar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(148)))), ((int)(((byte)(20)))));
            this.btnFiveStar.OnDisabledState.ForeColor = System.Drawing.Color.White;
            this.btnFiveStar.OnDisabledState.IconLeftImage = null;
            this.btnFiveStar.OnDisabledState.IconRightImage = null;
            this.btnFiveStar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(196)))), ((int)(((byte)(125)))));
            this.btnFiveStar.onHoverState.BorderRadius = 20;
            this.btnFiveStar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFiveStar.onHoverState.BorderThickness = 0;
            this.btnFiveStar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(196)))), ((int)(((byte)(125)))));
            this.btnFiveStar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnFiveStar.onHoverState.IconLeftImage = null;
            this.btnFiveStar.onHoverState.IconRightImage = null;
            this.btnFiveStar.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(148)))), ((int)(((byte)(20)))));
            this.btnFiveStar.OnIdleState.BorderRadius = 20;
            this.btnFiveStar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFiveStar.OnIdleState.BorderThickness = 0;
            this.btnFiveStar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(148)))), ((int)(((byte)(20)))));
            this.btnFiveStar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnFiveStar.OnIdleState.IconLeftImage = null;
            this.btnFiveStar.OnIdleState.IconRightImage = null;
            this.btnFiveStar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(148)))), ((int)(((byte)(20)))));
            this.btnFiveStar.OnPressedState.BorderRadius = 20;
            this.btnFiveStar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFiveStar.OnPressedState.BorderThickness = 0;
            this.btnFiveStar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(148)))), ((int)(((byte)(20)))));
            this.btnFiveStar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnFiveStar.OnPressedState.IconLeftImage = null;
            this.btnFiveStar.OnPressedState.IconRightImage = null;
            this.btnFiveStar.Size = new System.Drawing.Size(98, 50);
            this.btnFiveStar.TabIndex = 7;
            this.btnFiveStar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFiveStar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFiveStar.TextMarginLeft = 0;
            this.btnFiveStar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnFiveStar.UseDefaultRadiusAndThickness = true;
            // 
            // btnComment
            // 
            this.btnComment.AllowAnimations = true;
            this.btnComment.AllowMouseEffects = true;
            this.btnComment.AllowToggling = false;
            this.btnComment.AnimationSpeed = 200;
            this.btnComment.AutoGenerateColors = false;
            this.btnComment.AutoRoundBorders = false;
            this.btnComment.AutoSizeLeftIcon = false;
            this.btnComment.AutoSizeRightIcon = false;
            this.btnComment.BackColor = System.Drawing.Color.Transparent;
            this.btnComment.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnComment.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnComment.BackgroundImage")));
            this.btnComment.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnComment.ButtonText = "Viết bình luận";
            this.btnComment.ButtonTextMarginLeft = 0;
            this.btnComment.ColorContrastOnClick = 45;
            this.btnComment.ColorContrastOnHover = 45;
            this.btnComment.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges11.BottomLeft = true;
            borderEdges11.BottomRight = true;
            borderEdges11.TopLeft = true;
            borderEdges11.TopRight = true;
            this.btnComment.CustomizableEdges = borderEdges11;
            this.btnComment.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnComment.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnComment.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnComment.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnComment.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnComment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnComment.ForeColor = System.Drawing.Color.White;
            this.btnComment.IconLeft = null;
            this.btnComment.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComment.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnComment.IconLeftPadding = new System.Windows.Forms.Padding(0);
            this.btnComment.IconMarginLeft = 11;
            this.btnComment.IconPadding = 0;
            this.btnComment.IconRight = global::MusicApp.Properties.Resources.plus;
            this.btnComment.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnComment.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnComment.IconRightPadding = new System.Windows.Forms.Padding(0, 0, 13, 0);
            this.btnComment.IconSize = 20;
            this.btnComment.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnComment.IdleBorderRadius = 0;
            this.btnComment.IdleBorderThickness = 0;
            this.btnComment.IdleFillColor = System.Drawing.Color.Empty;
            this.btnComment.IdleIconLeftImage = null;
            this.btnComment.IdleIconRightImage = global::MusicApp.Properties.Resources.plus;
            this.btnComment.IndicateFocus = false;
            this.btnComment.Location = new System.Drawing.Point(454, 357);
            this.btnComment.Name = "btnComment";
            this.btnComment.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(148)))), ((int)(((byte)(20)))));
            this.btnComment.OnDisabledState.BorderRadius = 30;
            this.btnComment.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnComment.OnDisabledState.BorderThickness = 0;
            this.btnComment.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(148)))), ((int)(((byte)(20)))));
            this.btnComment.OnDisabledState.ForeColor = System.Drawing.Color.White;
            this.btnComment.OnDisabledState.IconLeftImage = null;
            this.btnComment.OnDisabledState.IconRightImage = null;
            this.btnComment.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(196)))), ((int)(((byte)(125)))));
            this.btnComment.onHoverState.BorderRadius = 30;
            this.btnComment.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnComment.onHoverState.BorderThickness = 0;
            this.btnComment.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(196)))), ((int)(((byte)(125)))));
            this.btnComment.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnComment.onHoverState.IconLeftImage = null;
            this.btnComment.onHoverState.IconRightImage = null;
            this.btnComment.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(148)))), ((int)(((byte)(20)))));
            this.btnComment.OnIdleState.BorderRadius = 30;
            this.btnComment.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnComment.OnIdleState.BorderThickness = 0;
            this.btnComment.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(148)))), ((int)(((byte)(20)))));
            this.btnComment.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnComment.OnIdleState.IconLeftImage = null;
            this.btnComment.OnIdleState.IconRightImage = global::MusicApp.Properties.Resources.plus;
            this.btnComment.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(148)))), ((int)(((byte)(20)))));
            this.btnComment.OnPressedState.BorderRadius = 30;
            this.btnComment.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnComment.OnPressedState.BorderThickness = 0;
            this.btnComment.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(148)))), ((int)(((byte)(20)))));
            this.btnComment.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnComment.OnPressedState.IconLeftImage = null;
            this.btnComment.OnPressedState.IconRightImage = null;
            this.btnComment.Size = new System.Drawing.Size(189, 55);
            this.btnComment.TabIndex = 7;
            this.btnComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComment.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnComment.TextMarginLeft = 0;
            this.btnComment.TextPadding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnComment.UseDefaultRadiusAndThickness = true;
            this.btnComment.Click += new System.EventHandler(this.btnComment_Click);
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.Color.Transparent;
            this.line.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("line.BackgroundImage")));
            this.line.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.line.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.line.LineColor = System.Drawing.SystemColors.ButtonShadow;
            this.line.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.line.LineThickness = 2;
            this.line.Location = new System.Drawing.Point(405, 412);
            this.line.Margin = new System.Windows.Forms.Padding(0);
            this.line.Name = "line";
            this.line.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Vertical;
            this.line.Size = new System.Drawing.Size(23, 473);
            this.line.TabIndex = 6;
            // 
            // txtRattingPoint
            // 
            this.txtRattingPoint.Font = new System.Drawing.Font("Segoe UI Semibold", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtRattingPoint.ForeColor = System.Drawing.Color.White;
            this.txtRattingPoint.Location = new System.Drawing.Point(96, 430);
            this.txtRattingPoint.Name = "txtRattingPoint";
            this.txtRattingPoint.Size = new System.Drawing.Size(89, 50);
            this.txtRattingPoint.TabIndex = 5;
            this.txtRattingPoint.Text = "5";
            this.txtRattingPoint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pBack
            // 
            this.pBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBack.Image = global::MusicApp.Properties.Resources.back;
            this.pBack.Location = new System.Drawing.Point(23, 20);
            this.pBack.Name = "pBack";
            this.pBack.Size = new System.Drawing.Size(30, 30);
            this.pBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBack.TabIndex = 4;
            this.pBack.TabStop = false;
            this.pBack.Click += new System.EventHandler(this.pBack_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(51, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bình Luận và Đánh Giá";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbGenre
            // 
            this.lbGenre.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbGenre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.lbGenre.Location = new System.Drawing.Point(728, 270);
            this.lbGenre.Name = "lbGenre";
            this.lbGenre.Size = new System.Drawing.Size(115, 33);
            this.lbGenre.TabIndex = 2;
            this.lbGenre.Text = "Thể loại:";
            this.lbGenre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbYear
            // 
            this.lbYear.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.lbYear.Location = new System.Drawing.Point(728, 215);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(193, 33);
            this.lbYear.TabIndex = 2;
            this.lbYear.Text = "Năm phát hành:";
            this.lbYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbArtirst
            // 
            this.lbArtirst.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbArtirst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.lbArtirst.Location = new System.Drawing.Point(728, 160);
            this.lbArtirst.Name = "lbArtirst";
            this.lbArtirst.Size = new System.Drawing.Size(121, 33);
            this.lbArtirst.TabIndex = 2;
            this.lbArtirst.Text = "Trình bày:";
            this.lbArtirst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtInfoGenre
            // 
            this.txtInfoGenre.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtInfoGenre.ForeColor = System.Drawing.Color.White;
            this.txtInfoGenre.Location = new System.Drawing.Point(986, 270);
            this.txtInfoGenre.Name = "txtInfoGenre";
            this.txtInfoGenre.Size = new System.Drawing.Size(191, 35);
            this.txtInfoGenre.TabIndex = 2;
            this.txtInfoGenre.Text = "Nhạc Việt";
            this.txtInfoGenre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtYear.ForeColor = System.Drawing.Color.White;
            this.txtYear.Location = new System.Drawing.Point(986, 215);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(78, 33);
            this.txtYear.TabIndex = 2;
            this.txtYear.Text = "2020";
            this.txtYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtInfoArtist
            // 
            this.txtInfoArtist.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtInfoArtist.ForeColor = System.Drawing.Color.White;
            this.txtInfoArtist.Location = new System.Drawing.Point(986, 160);
            this.txtInfoArtist.Name = "txtInfoArtist";
            this.txtInfoArtist.Size = new System.Drawing.Size(628, 33);
            this.txtInfoArtist.TabIndex = 2;
            this.txtInfoArtist.Text = "Emcee L, Badbies";
            this.txtInfoArtist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtComposer
            // 
            this.txtComposer.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtComposer.ForeColor = System.Drawing.Color.White;
            this.txtComposer.Location = new System.Drawing.Point(986, 105);
            this.txtComposer.Name = "txtComposer";
            this.txtComposer.Size = new System.Drawing.Size(628, 33);
            this.txtComposer.TabIndex = 2;
            this.txtComposer.Text = "Emcee L";
            this.txtComposer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbComposer
            // 
            this.lbComposer.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbComposer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.lbComposer.Location = new System.Drawing.Point(728, 105);
            this.lbComposer.Name = "lbComposer";
            this.lbComposer.Size = new System.Drawing.Size(115, 33);
            this.lbComposer.TabIndex = 2;
            this.lbComposer.Text = "Sáng tác:";
            this.lbComposer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNameSong
            // 
            this.txtNameSong.Font = new System.Drawing.Font("Segoe UI Semibold", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNameSong.ForeColor = System.Drawing.Color.White;
            this.txtNameSong.Location = new System.Drawing.Point(728, 23);
            this.txtNameSong.Name = "txtNameSong";
            this.txtNameSong.Size = new System.Drawing.Size(682, 46);
            this.txtNameSong.TabIndex = 1;
            this.txtNameSong.Text = "Sinh Ra Đã Là Thứ Đối Lập Nhau";
            this.txtNameSong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pInforSong
            // 
            this.pInforSong.Image = global::MusicApp.Properties.Resources.srltdln;
            this.pInforSong.Location = new System.Drawing.Point(363, 23);
            this.pInforSong.Name = "pInforSong";
            this.pInforSong.Size = new System.Drawing.Size(280, 280);
            this.pInforSong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pInforSong.TabIndex = 0;
            this.pInforSong.TabStop = false;
            // 
            // pageVpop
            // 
            this.pageVpop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.pageVpop.Controls.Add(this.flowLayoutPanel1);
            this.pageVpop.Controls.Add(this.panel6);
            this.pageVpop.Location = new System.Drawing.Point(4, 4);
            this.pageVpop.Name = "pageVpop";
            this.pageVpop.Padding = new System.Windows.Forms.Padding(3);
            this.pageVpop.Size = new System.Drawing.Size(1622, 865);
            this.pageVpop.TabIndex = 6;
            this.pageVpop.Text = "Nhạc Việt";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AllowDrop = true;
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.song41);
            this.flowLayoutPanel1.Controls.Add(this.song42);
            this.flowLayoutPanel1.Controls.Add(this.song43);
            this.flowLayoutPanel1.Controls.Add(this.song48);
            this.flowLayoutPanel1.Controls.Add(this.song50);
            this.flowLayoutPanel1.Controls.Add(this.song52);
            this.flowLayoutPanel1.Controls.Add(this.song53);
            this.flowLayoutPanel1.Controls.Add(this.song56);
            this.flowLayoutPanel1.Controls.Add(this.song59);
            this.flowLayoutPanel1.Controls.Add(this.song61);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 110);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1616, 752);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // song41
            // 
            this.song41.Artist = "TIA, Lê Thiện Hiếu";
            this.song41.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.song41.Genre = "Nhạc Việt";
            this.song41.ImageSong = global::MusicApp.Properties.Resources.AiDuaEmVe;
            this.song41.Location = new System.Drawing.Point(0, 0);
            this.song41.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.song41.Name = "song41";
            this.song41.NameSong = "Ai Đưa Em Về";
            this.song41.Number = "1";
            this.song41.Size = new System.Drawing.Size(1620, 90);
            this.song41.TabIndex = 1;
            this.song41.Time = "03:53";
            // 
            // song42
            // 
            this.song42.Artist = "SOOBIN";
            this.song42.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.song42.Genre = "Nhạc Việt";
            this.song42.ImageSong = global::MusicApp.Properties.Resources.AnhDaQuenVoiCoDon;
            this.song42.Location = new System.Drawing.Point(0, 93);
            this.song42.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.song42.Name = "song42";
            this.song42.NameSong = "Anh Đã Quen Với Cô Đơn";
            this.song42.Number = "2";
            this.song42.Size = new System.Drawing.Size(1620, 90);
            this.song42.TabIndex = 2;
            this.song42.Time = "03:55";
            // 
            // song43
            // 
            this.song43.Artist = "Anh Quân Idol";
            this.song43.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.song43.Genre = "Nhạc Việt";
            this.song43.ImageSong = global::MusicApp.Properties.Resources.AnhMetRoi;
            this.song43.Location = new System.Drawing.Point(0, 186);
            this.song43.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.song43.Name = "song43";
            this.song43.NameSong = "Anh Mệt Rồi";
            this.song43.Number = "3";
            this.song43.Size = new System.Drawing.Size(1620, 90);
            this.song43.TabIndex = 3;
            this.song43.Time = "04:56";
            // 
            // song48
            // 
            this.song48.Artist = "Vũ";
            this.song48.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.song48.Genre = "Nhạc Việt";
            this.song48.ImageSong = global::MusicApp.Properties.Resources.BuocQuaMuaCoDon;
            this.song48.Location = new System.Drawing.Point(0, 279);
            this.song48.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.song48.Name = "song48";
            this.song48.NameSong = "Bước Qua Mùa Cô Đơn";
            this.song48.Number = "4";
            this.song48.Size = new System.Drawing.Size(1620, 90);
            this.song48.TabIndex = 8;
            this.song48.Time = "04:38";
            // 
            // song50
            // 
            this.song50.Artist = "MONSTAR";
            this.song50.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.song50.Genre = "Nhạc Việt";
            this.song50.ImageSong = global::MusicApp.Properties.Resources.CoHenVoiThanhXuan;
            this.song50.Location = new System.Drawing.Point(0, 372);
            this.song50.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.song50.Name = "song50";
            this.song50.NameSong = "Có Hẹn Với Thanh Xuân";
            this.song50.Number = "5";
            this.song50.Size = new System.Drawing.Size(1620, 90);
            this.song50.TabIndex = 10;
            this.song50.Time = "03:38";
            // 
            // song52
            // 
            this.song52.Artist = "Only C, Lou Hoàng";
            this.song52.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.song52.Genre = "Nhạc Việt";
            this.song52.ImageSong = global::MusicApp.Properties.Resources.DemNgayXaEm;
            this.song52.Location = new System.Drawing.Point(0, 465);
            this.song52.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.song52.Name = "song52";
            this.song52.NameSong = "Đếm Ngày Xa Em";
            this.song52.Number = "6";
            this.song52.Size = new System.Drawing.Size(1620, 90);
            this.song52.TabIndex = 12;
            this.song52.Time = "04:23";
            // 
            // song53
            // 
            this.song53.Artist = "Sơn Tùng M-TP";
            this.song53.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.song53.Genre = "Nhạc Việt";
            this.song53.ImageSong = global::MusicApp.Properties.Resources.EmCuaNgayHomQua;
            this.song53.Location = new System.Drawing.Point(0, 558);
            this.song53.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.song53.Name = "song53";
            this.song53.NameSong = "Em Của Ngày Hôm Qua";
            this.song53.Number = "7";
            this.song53.Size = new System.Drawing.Size(1620, 90);
            this.song53.TabIndex = 13;
            this.song53.Time = "03:45";
            // 
            // song56
            // 
            this.song56.Artist = "LadyKillah All Star";
            this.song56.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.song56.Genre = "Nhạc Việt";
            this.song56.ImageSong = global::MusicApp.Properties.Resources.ForeverLove;
            this.song56.Location = new System.Drawing.Point(0, 651);
            this.song56.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.song56.Name = "song56";
            this.song56.NameSong = "Forever Love";
            this.song56.Number = "8";
            this.song56.Size = new System.Drawing.Size(1620, 90);
            this.song56.TabIndex = 16;
            this.song56.Time = "07:29";
            // 
            // song59
            // 
            this.song59.Artist = "Sơn Tùng M-TP";
            this.song59.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.song59.Genre = "Nhạc Việt";
            this.song59.ImageSong = global::MusicApp.Properties.Resources.HayTraoChoAnh;
            this.song59.Location = new System.Drawing.Point(0, 744);
            this.song59.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.song59.Name = "song59";
            this.song59.NameSong = "Hãy Trao Cho Anh";
            this.song59.Number = "9";
            this.song59.Size = new System.Drawing.Size(1620, 90);
            this.song59.TabIndex = 19;
            this.song59.Time = "04:05";
            // 
            // song61
            // 
            this.song61.Artist = "Lil Z Poet";
            this.song61.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.song61.Genre = "Nhạc Việt";
            this.song61.ImageSong = global::MusicApp.Properties.Resources.HoaVangNayTan21;
            this.song61.Location = new System.Drawing.Point(0, 837);
            this.song61.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.song61.Name = "song61";
            this.song61.NameSong = "Hoa Vàng Nay Tàn";
            this.song61.Number = "10";
            this.song61.Size = new System.Drawing.Size(1620, 90);
            this.song61.TabIndex = 21;
            this.song61.Time = "03:51";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.label22);
            this.panel6.Controls.Add(this.label23);
            this.panel6.Controls.Add(this.label24);
            this.panel6.Controls.Add(this.label25);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1616, 107);
            this.panel6.TabIndex = 9;
            // 
            // label22
            // 
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Image = global::MusicApp.Properties.Resources.clock;
            this.label22.Location = new System.Drawing.Point(1526, 46);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(32, 32);
            this.label22.TabIndex = 9;
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Segoe UI", 19.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.label23.Location = new System.Drawing.Point(764, 46);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(139, 41);
            this.label23.TabIndex = 8;
            this.label23.Text = "Thể Loại";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label24
            // 
            this.label24.Font = new System.Drawing.Font("Segoe UI", 19.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.label24.Location = new System.Drawing.Point(88, 46);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(128, 39);
            this.label24.TabIndex = 8;
            this.label24.Text = "Tiêu Đề";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label25
            // 
            this.label25.Font = new System.Drawing.Font("Segoe UI", 19.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.label25.Location = new System.Drawing.Point(23, 46);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(21, 39);
            this.label25.TabIndex = 8;
            this.label25.Text = "#";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pageKpop
            // 
            this.pageKpop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.pageKpop.Controls.Add(this.flowLayoutPanel2);
            this.pageKpop.Controls.Add(this.panel1);
            this.pageKpop.Location = new System.Drawing.Point(4, 4);
            this.pageKpop.Name = "pageKpop";
            this.pageKpop.Padding = new System.Windows.Forms.Padding(3);
            this.pageKpop.Size = new System.Drawing.Size(1622, 865);
            this.pageKpop.TabIndex = 7;
            this.pageKpop.Text = "Nhạc Hàn";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AllowDrop = true;
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.Controls.Add(this.song44);
            this.flowLayoutPanel2.Controls.Add(this.song46);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 110);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1616, 752);
            this.flowLayoutPanel2.TabIndex = 11;
            // 
            // song44
            // 
            this.song44.Artist = "BTS";
            this.song44.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.song44.Genre = "Nhạc Hàn";
            this.song44.ImageSong = global::MusicApp.Properties.Resources.AnswerLoveMyself;
            this.song44.Location = new System.Drawing.Point(0, 0);
            this.song44.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.song44.Name = "song44";
            this.song44.NameSong = "Answer: Love Myself";
            this.song44.Number = "1";
            this.song44.Size = new System.Drawing.Size(1620, 90);
            this.song44.TabIndex = 4;
            this.song44.Time = "03:54";
            // 
            // song46
            // 
            this.song46.Artist = "Shaun";
            this.song46.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.song46.Genre = "Nhạc Hàn";
            this.song46.ImageSong = global::MusicApp.Properties.Resources.BadHabits;
            this.song46.Location = new System.Drawing.Point(0, 93);
            this.song46.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.song46.Name = "song46";
            this.song46.NameSong = "Bad Habits";
            this.song46.Number = "2";
            this.song46.Size = new System.Drawing.Size(1620, 90);
            this.song46.TabIndex = 6;
            this.song46.Time = "03:33";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1616, 107);
            this.panel1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Image = global::MusicApp.Properties.Resources.clock;
            this.label2.Location = new System.Drawing.Point(1526, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 32);
            this.label2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 19.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.label3.Location = new System.Drawing.Point(764, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 41);
            this.label3.TabIndex = 8;
            this.label3.Text = "Thể Loại";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 19.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.label4.Location = new System.Drawing.Point(88, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 39);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tiêu Đề";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 19.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.label5.Location = new System.Drawing.Point(23, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 39);
            this.label5.TabIndex = 8;
            this.label5.Text = "#";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pageUS
            // 
            this.pageUS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.pageUS.Controls.Add(this.flowLayoutPanel3);
            this.pageUS.Controls.Add(this.panel2);
            this.pageUS.Location = new System.Drawing.Point(4, 4);
            this.pageUS.Name = "pageUS";
            this.pageUS.Padding = new System.Windows.Forms.Padding(3);
            this.pageUS.Size = new System.Drawing.Size(1622, 865);
            this.pageUS.TabIndex = 8;
            this.pageUS.Text = "Nhạc Âu Mĩ";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AllowDrop = true;
            this.flowLayoutPanel3.AutoScroll = true;
            this.flowLayoutPanel3.Controls.Add(this.song45);
            this.flowLayoutPanel3.Controls.Add(this.song47);
            this.flowLayoutPanel3.Controls.Add(this.song51);
            this.flowLayoutPanel3.Controls.Add(this.song55);
            this.flowLayoutPanel3.Controls.Add(this.song57);
            this.flowLayoutPanel3.Controls.Add(this.song60);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 110);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(1616, 752);
            this.flowLayoutPanel3.TabIndex = 11;
            // 
            // song45
            // 
            this.song45.Artist = "Justin Bieber, Ludacris";
            this.song45.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.song45.Genre = "Nhạc Âu Mỹ";
            this.song45.ImageSong = global::MusicApp.Properties.Resources.Baby;
            this.song45.Location = new System.Drawing.Point(0, 0);
            this.song45.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.song45.Name = "song45";
            this.song45.NameSong = "Baby";
            this.song45.Number = "1";
            this.song45.Size = new System.Drawing.Size(1620, 90);
            this.song45.TabIndex = 5;
            this.song45.Time = "03:39";
            // 
            // song47
            // 
            this.song47.Artist = "Imagine Dragons";
            this.song47.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.song47.Genre = "Nhạc Âu Mỹ";
            this.song47.ImageSong = global::MusicApp.Properties.Resources.Bones;
            this.song47.Location = new System.Drawing.Point(0, 93);
            this.song47.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.song47.Name = "song47";
            this.song47.NameSong = "Bones";
            this.song47.Number = "2";
            this.song47.Size = new System.Drawing.Size(1620, 90);
            this.song47.TabIndex = 7;
            this.song47.Time = "02:45";
            // 
            // song51
            // 
            this.song51.Artist = "Katy Perry, Tee";
            this.song51.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.song51.Genre = "Nhạc Âu Mỹ";
            this.song51.ImageSong = global::MusicApp.Properties.Resources.DarkHorse;
            this.song51.Location = new System.Drawing.Point(0, 186);
            this.song51.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.song51.Name = "song51";
            this.song51.NameSong = "Dark Horse";
            this.song51.Number = "3";
            this.song51.Size = new System.Drawing.Size(1620, 90);
            this.song51.TabIndex = 11;
            this.song51.Time = "03:35";
            // 
            // song55
            // 
            this.song55.Artist = "Alan Walker";
            this.song55.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.song55.Genre = "Nhạc Âu Mỹ";
            this.song55.ImageSong = global::MusicApp.Properties.Resources.Faded;
            this.song55.Location = new System.Drawing.Point(0, 279);
            this.song55.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.song55.Name = "song55";
            this.song55.NameSong = "Faded";
            this.song55.Number = "4";
            this.song55.Size = new System.Drawing.Size(1620, 90);
            this.song55.TabIndex = 15;
            this.song55.Time = "03:32";
            // 
            // song57
            // 
            this.song57.Artist = "Joji";
            this.song57.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.song57.Genre = "Nhạc Âu Mỹ";
            this.song57.ImageSong = global::MusicApp.Properties.Resources.GlimpseOfUs1;
            this.song57.Location = new System.Drawing.Point(0, 372);
            this.song57.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.song57.Name = "song57";
            this.song57.NameSong = "Glimpse of Us";
            this.song57.Number = "5";
            this.song57.Size = new System.Drawing.Size(1620, 90);
            this.song57.TabIndex = 17;
            this.song57.Time = "03:53";
            // 
            // song60
            // 
            this.song60.Artist = "Hayd";
            this.song60.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.song60.Genre = "Nhạc Âu Mỹ";
            this.song60.ImageSong = global::MusicApp.Properties.Resources.HeadInTheCloud1;
            this.song60.Location = new System.Drawing.Point(0, 465);
            this.song60.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.song60.Name = "song60";
            this.song60.NameSong = "Head In The Clouds";
            this.song60.Number = "6";
            this.song60.Size = new System.Drawing.Size(1620, 90);
            this.song60.TabIndex = 20;
            this.song60.Time = "03:04";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1616, 107);
            this.panel2.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Image = global::MusicApp.Properties.Resources.clock;
            this.label6.Location = new System.Drawing.Point(1526, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 32);
            this.label6.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 19.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.label7.Location = new System.Drawing.Point(764, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 41);
            this.label7.TabIndex = 8;
            this.label7.Text = "Thể Loại";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 19.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.label8.Location = new System.Drawing.Point(88, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 39);
            this.label8.TabIndex = 8;
            this.label8.Text = "Tiêu Đề";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI", 19.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.label9.Location = new System.Drawing.Point(23, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 39);
            this.label9.TabIndex = 8;
            this.label9.Text = "#";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pageKL
            // 
            this.pageKL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.pageKL.Controls.Add(this.flowLayoutPanel4);
            this.pageKL.Controls.Add(this.panel3);
            this.pageKL.Location = new System.Drawing.Point(4, 4);
            this.pageKL.Name = "pageKL";
            this.pageKL.Padding = new System.Windows.Forms.Padding(3);
            this.pageKL.Size = new System.Drawing.Size(1622, 865);
            this.pageKL.TabIndex = 9;
            this.pageKL.Text = "Nhạc không lời";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AllowDrop = true;
            this.flowLayoutPanel4.AutoScroll = true;
            this.flowLayoutPanel4.Controls.Add(this.song49);
            this.flowLayoutPanel4.Controls.Add(this.song54);
            this.flowLayoutPanel4.Controls.Add(this.song58);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 110);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(1616, 752);
            this.flowLayoutPanel4.TabIndex = 11;
            // 
            // song49
            // 
            this.song49.Artist = "An Coong";
            this.song49.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.song49.Genre = "Nhạc không lời";
            this.song49.ImageSong = global::MusicApp.Properties.Resources.ChungTaCuaHienTaiCover;
            this.song49.Location = new System.Drawing.Point(0, 0);
            this.song49.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.song49.Name = "song49";
            this.song49.NameSong = "Chúng Ta Của Hiện Tại (Piano cover)";
            this.song49.Number = "1";
            this.song49.Size = new System.Drawing.Size(1620, 90);
            this.song49.TabIndex = 9;
            this.song49.Time = "05:03";
            // 
            // song54
            // 
            this.song54.Artist = "An Coong";
            this.song54.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.song54.Genre = "Nhạc không lời";
            this.song54.ImageSong = global::MusicApp.Properties.Resources.EndlessLove1;
            this.song54.Location = new System.Drawing.Point(0, 93);
            this.song54.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.song54.Name = "song54";
            this.song54.NameSong = "Endless Love (The Myth OST)";
            this.song54.Number = "2";
            this.song54.Size = new System.Drawing.Size(1620, 90);
            this.song54.TabIndex = 14;
            this.song54.Time = "04:43";
            // 
            // song58
            // 
            this.song58.Artist = "Kenny G";
            this.song58.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.song58.Genre = "Nhạc không lời";
            this.song58.ImageSong = global::MusicApp.Properties.Resources.GoingHome1;
            this.song58.Location = new System.Drawing.Point(0, 186);
            this.song58.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.song58.Name = "song58";
            this.song58.NameSong = "Going Home";
            this.song58.Number = "3";
            this.song58.Size = new System.Drawing.Size(1620, 90);
            this.song58.TabIndex = 18;
            this.song58.Time = "05:35";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1616, 107);
            this.panel3.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Image = global::MusicApp.Properties.Resources.clock;
            this.label10.Location = new System.Drawing.Point(1526, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 32);
            this.label10.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Segoe UI", 19.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.label11.Location = new System.Drawing.Point(764, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 41);
            this.label11.TabIndex = 8;
            this.label11.Text = "Thể Loại";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Segoe UI", 19.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.label12.Location = new System.Drawing.Point(88, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 39);
            this.label12.TabIndex = 8;
            this.label12.Text = "Tiêu Đề";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Segoe UI", 19.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.label13.Location = new System.Drawing.Point(23, 46);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 39);
            this.label13.TabIndex = 8;
            this.label13.Text = "#";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pageTrinh
            // 
            this.pageTrinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.pageTrinh.Controls.Add(this.flowLayoutPanel5);
            this.pageTrinh.Controls.Add(this.panel4);
            this.pageTrinh.Location = new System.Drawing.Point(4, 4);
            this.pageTrinh.Name = "pageTrinh";
            this.pageTrinh.Padding = new System.Windows.Forms.Padding(3);
            this.pageTrinh.Size = new System.Drawing.Size(1622, 865);
            this.pageTrinh.TabIndex = 10;
            this.pageTrinh.Text = "Nhạc Trịnh";
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.AllowDrop = true;
            this.flowLayoutPanel5.AutoScroll = true;
            this.flowLayoutPanel5.Controls.Add(this.song62);
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 110);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(1616, 752);
            this.flowLayoutPanel5.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1616, 107);
            this.panel4.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Image = global::MusicApp.Properties.Resources.clock;
            this.label14.Location = new System.Drawing.Point(1526, 46);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 32);
            this.label14.TabIndex = 9;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Segoe UI", 19.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.label15.Location = new System.Drawing.Point(764, 46);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(139, 41);
            this.label15.TabIndex = 8;
            this.label15.Text = "Thể Loại";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Segoe UI", 19.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.label16.Location = new System.Drawing.Point(88, 46);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(128, 39);
            this.label16.TabIndex = 8;
            this.label16.Text = "Tiêu Đề";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Segoe UI", 19.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.label17.Location = new System.Drawing.Point(23, 46);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(21, 39);
            this.label17.TabIndex = 8;
            this.label17.Text = "#";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // song62
            // 
            this.song62.Artist = "Lệ Quyên";
            this.song62.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.song62.Genre = "Nhạc Trịnh";
            this.song62.ImageSong = global::MusicApp.Properties.Resources.MuaHong;
            this.song62.Location = new System.Drawing.Point(0, 0);
            this.song62.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.song62.Name = "song62";
            this.song62.NameSong = "Mưa Hồng";
            this.song62.Number = "1";
            this.song62.Size = new System.Drawing.Size(1620, 90);
            this.song62.TabIndex = 26;
            this.song62.Time = "04:38";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.ppageMain);
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
            this.ppageMain.ResumeLayout(false);
            this.pageHome.ResumeLayout(false);
            this.fpnSongs.ResumeLayout(false);
            this.pnHeader.ResumeLayout(false);
            this.pageGenre.ResumeLayout(false);
            this.pageCollection.ResumeLayout(false);
            this.fpnPlaylist.ResumeLayout(false);
            this.pageInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.fpnComment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pInforSong)).EndInit();
            this.pageVpop.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.pageKpop.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pageUS.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pageKL.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pageTrinh.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
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
        private Bunifu.UI.WinForms.BunifuPages ppageMain;
        private TabPage pageHome;
        private TabPage pageGenre;
        private TabPage pageCollection;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddList;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnHome;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnGenre;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnHistory;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnCollection;
        private Bunifu.UI.WinForms.BunifuTextBox txboxFind;
        private Panel pnHeader;
        private TabPage pageHistory;
        private Label txtNumber;
        private Label txtTitle;
        private Label txtGenre;
        private Label txtTime;
        private FlowLayoutPanel fpnSongs;
        private TabPage pageInfo;
        private FlowLayoutPanel fpnPlaylist;
        private Source.Liked liked1;
        private Source.Playlist playlist1;
        private Source.Song song1;
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
        private Source.Song song31;
        private Source.Song song32;
        private Source.Song song33;
        private Source.Song song34;
        private Source.Song song35;
        private Source.Song song36;
        private Source.Song song37;
        private Source.Song song38;
        private Source.Song song39;
        private Source.Song song40;
        private PictureBox pInforSong;
        private Label txtNameSong;
        private Label lbComposer;
        private Label lbGenre;
        private Label lbYear;
        private Label lbArtirst;
        private Label txtInfoGenre;
        private Label txtYear;
        private Label txtInfoArtist;
        private Label txtComposer;
        private PictureBox pBack;
        private Label label1;
        private Bunifu.UI.WinForms.BunifuSeparator line;
        private Label txtRattingPoint;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnComment;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnFiveStar;
        private Label txtOneStar;
        private Label txtTwoStar;
        private Label txtThreeStar;
        private Label txtFourStar;
        private Label txtFiveStar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnOneStar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnTwoStar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnThreeStar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BtnFourStar;
        private FlowLayoutPanel fpnComment;
        private Source.Comment comment1;
        private PictureBox pictureBox1;
        private TabPage pageVpop;
        private Panel panel6;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label25;
        private Source.Genre genre1;
        private Source.Genre genre4;
        private Source.Genre genre3;
        private Source.Genre genre2;
        private Source.Genre genre5;
        private TabPage pageKpop;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TabPage pageUS;
        private Panel panel2;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TabPage pageKL;
        private Panel panel3;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private TabPage pageTrinh;
        private Panel panel4;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private FlowLayoutPanel flowLayoutPanel1;
        private Source.Song song41;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel4;
        private FlowLayoutPanel flowLayoutPanel5;
        private Source.Song song42;
        private Source.Song song43;
        private Source.Song song48;
        private Source.Song song44;
        private Source.Song song46;
        private Source.Song song45;
        private Source.Song song47;
        private Source.Song song50;
        private Source.Song song52;
        private Source.Song song53;
        private Source.Song song56;
        private Source.Song song59;
        private Source.Song song61;
        private Source.Song song51;
        private Source.Song song55;
        private Source.Song song57;
        private Source.Song song60;
        private Source.Song song49;
        private Source.Song song54;
        private Source.Song song58;
        private Source.Song song62;
    }
}