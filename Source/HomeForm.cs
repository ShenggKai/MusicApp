using MusicApp.Source;
using System.Text;
using Windows.UI.Input;

namespace MusicApp
{
    public partial class HomeForm : Form //form 1
    {
        // can change from another form
        public static HomeForm instance;
        public Label SongName;
        public Label Artist;
        public PictureBox SongPicture;
        public FlowLayoutPanel fpnlist;
        public FlowLayoutPanel fpnCmt;
        public Label timeEnd;

        public HomeForm()
        {
            InitializeComponent();

            //can change from another form
            instance = this;
            fpnlist = fpnPlaylist;

            SongName = lbSongName;
            Artist= lbArtist;
            SongPicture = pSong;
            timeEnd = lbTimeEnd;
            fpnCmt = fpnComment;
        }

        #region  Effect when hover button
        // shuffle button
        private void btnShuffle_MouseHover(object sender, EventArgs e)
        {
            btnShuffle.Image = global::MusicApp.Properties.Resources.shuffle_white;
        }

        private void btnShuffle_MouseLeave(object sender, EventArgs e)
        {
            btnShuffle.Image = global::MusicApp.Properties.Resources.shuffle_gray;
        }

        // previous button
        private void btnPrevious_MouseHover(object sender, EventArgs e)
        {
            btnPrevious.Image = global::MusicApp.Properties.Resources.left;
        }

        private void btnPrevious_MouseLeave(object sender, EventArgs e)
        {
            btnPrevious.Image = global::MusicApp.Properties.Resources.left_gray;
        }

        // next button
        private void btnNext_MouseHover(object sender, EventArgs e)
        {
            btnNext.Image = global::MusicApp.Properties.Resources.right;
        }

        private void btnNext_MouseLeave(object sender, EventArgs e)
        {
            btnNext.Image = global::MusicApp.Properties.Resources.right_gray;
        }

        // repeat button
        private void btnRepeat_MouseHover(object sender, EventArgs e)
        {
            btnRepeat.Image = global::MusicApp.Properties.Resources.repeat_white;
        }

        private void btnRepeat_MouseLeave(object sender, EventArgs e)
        {
            btnRepeat.Image = global::MusicApp.Properties.Resources.repeat_gray;
        }

        // heart button
        private void btnHeart_MouseHover(object sender, EventArgs e)
        {
            btnHeart.Image = global::MusicApp.Properties.Resources.heart_white;
        }

        private void btnHeart_MouseLeave(object sender, EventArgs e)
        {
            btnHeart.Image = global::MusicApp.Properties.Resources.heart_gray;
        }

        // Lyric button
        private void btnLyric_MouseHover(object sender, EventArgs e)
        {
            btnLyric.Image = global::MusicApp.Properties.Resources.lyric_white;
        }

        private void btnLyric_MouseLeave(object sender, EventArgs e)
        {
            btnLyric.Image = global::MusicApp.Properties.Resources.lyric_gray;
        }

        // volume button
        private void btnVolume_MouseHover(object sender, EventArgs e)
        {
            btnVolume.Image = global::MusicApp.Properties.Resources.volume_white;
        }

        private void btnVolume_MouseLeave(object sender, EventArgs e)
        {
            btnVolume.Image = global::MusicApp.Properties.Resources.volume_gray;
        }

        // other button
        private void btnOther_MouseHover(object sender, EventArgs e)
        {
            btnOther.Image = global::MusicApp.Properties.Resources.dots_white;
        }

        private void btnOther_MouseLeave(object sender, EventArgs e)
        {
            btnOther.Image = global::MusicApp.Properties.Resources.dots_gray;
        }

        #endregion

        #region temp
        int count = 0;
        private void btnHeart_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                btnHeart.Image = global::MusicApp.Properties.Resources.heart_green;

                count = 1;
            }
            else
            {
                btnHeart.Image = global::MusicApp.Properties.Resources.heart_gray;

                count = 0;
            }
        }

        private void HomeForm_Shown(object sender, EventArgs e)
        {
            //add fake songs data
        }
        #endregion

        //#region change to default
        //private void changeHome()
        //{
        //    btnHome.BackColor = Color.FromArgb();
        //}

        //#endregion

        #region when click menu
        private void btnHome_Click(object sender, EventArgs e)
        {
            ppageMain.SetPage(0);
            btnHome.Focus();
        }

        private void btnGenre_Click(object sender, EventArgs e)
        {
            ppageMain.SetPage(1);
            btnGenre.Focus();
        }

        private void btnCollection_Click(object sender, EventArgs e)
        {
            ppageMain.SetPage(2);
            btnCollection.Focus();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            ppageMain.SetPage(3);
            btnHistory.Focus();
        }
        #endregion

        #region when click button
        private void btnComment_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();
            try
            {
                using (PopupComment pu = new PopupComment())
                {
                    formBackground.StartPosition = FormStartPosition.Manual;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = .50d;
                    formBackground.BackColor = Color.Black;
                    formBackground.WindowState = FormWindowState.Maximized;
                    formBackground.TopMost = true;
                    formBackground.Location = this.Location;
                    formBackground.ShowInTaskbar = false;
                    formBackground.Show();

                    pu.Owner= formBackground;
                    pu.ShowDialog();

                    formBackground.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                formBackground.Dispose();
            }
        }

        private void pBack_Click(object sender, EventArgs e)
        {
            ppageMain.SetPage(0);
        }

        private void btnMore2_Click(object sender, EventArgs e)
        {
            ppageMain.PageIndex = 3;
        }

        private void btnAddList_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();

            try
            {
                using (InputPlaylist popup = new InputPlaylist())
                {
                    formBackground.StartPosition = FormStartPosition.Manual;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = .50d;
                    formBackground.BackColor = Color.Black;
                    formBackground.WindowState = FormWindowState.Maximized;
                    formBackground.TopMost = true;
                    formBackground.Location = this.Location;
                    formBackground.ShowInTaskbar = false;
                    formBackground.Show();

                    popup.Owner = formBackground;
                    popup.ShowDialog();

                    formBackground.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                formBackground.Dispose();
            }
        }
        #endregion

        #region click songs info
        private void song1_InfoClick_1(object sender, EventArgs e)
        {
            ppageMain.SetPage(4);
            pInforSong.Image = song1.ImageSong;
            txtNameSong.Text = song1.NameSong;
            txtInfoArtist.Text = song1.Artist;
            txtYear.Text = "2020";
            txtInfoGenre.Text = song1.Genre;
            txtComposer.Text = "Nguyen Bao Trong";
        }

        #endregion

        public void UpDate()
        {
            float rat5, rat4, rat3, rat2, rat1;
            rat5 = float.Parse(txtFiveStar.Text);
            rat4 = float.Parse(txtFourStar.Text);
            rat3 = float.Parse(txtThreeStar.Text);
            rat2 = float.Parse(txtTwoStar.Text);
            rat1 = float.Parse(txtOneStar.Text);

            float kq = (rat5 + rat4 + rat3 + rat2 + rat1)/5;
            txtRattingPoint.Text = Convert.ToString(kq);
        }

        private void song2_InfoClick(object sender, EventArgs e)
        {
            ppageMain.SetPage(4);
            pInforSong.Image = song2.ImageSong;
            txtNameSong.Text = song2.NameSong;
            txtInfoArtist.Text = song2.Artist;
            txtYear.Text = "2020";
            txtInfoGenre.Text = song2.Genre;
            txtComposer.Text = "Soobin Hoàng Son";
        }

        private void song3_InfoClick(object sender, EventArgs e)
        {
            ppageMain.SetPage(4);
            pInforSong.Image = song3.ImageSong;
            txtNameSong.Text = song3.NameSong;
            txtInfoArtist.Text = song3.Artist;
            txtInfoGenre.Text = song3.Genre;
            txtYear.Text = "2020";
            txtComposer.Text = "Khac Anh";
        }

        private void song4_InfoClick(object sender, EventArgs e)
        {
            ppageMain.SetPage(4);
            pInforSong.Image = song4.ImageSong;
            txtNameSong.Text = song4.NameSong;
            txtInfoArtist.Text = song4.Artist;
            txtInfoGenre.Text = song4.Genre;
            txtYear.Text = "2020";
            txtComposer.Text = "SUGA, RM, J-Hope, Pdogg, Candace Sosa,...";
        }

        private void song5_InfoClick(object sender, EventArgs e)
        {
            ppageMain.SetPage(4);
            pInforSong.Image = song5.ImageSong;
            txtNameSong.Text = song5.NameSong;
            txtInfoArtist.Text = song5.Artist;
            txtInfoGenre.Text = song5.Genre;
            txtYear.Text = "2020";
            txtComposer.Text = "Justin Bieber, Ludacris, Christina Milian";
        }

        private void song6_InfoClick(object sender, EventArgs e)
        {
            ppageMain.SetPage(4);
            pInforSong.Image = song6.ImageSong;
            txtNameSong.Text = song6.NameSong;
            txtInfoArtist.Text = song6.Artist;
            txtInfoGenre.Text = song6.Genre;
            txtYear.Text = "2020";
            txtComposer.Text = "John Mcdaid, Ed Sheeran, Fred Again";
        }

        private void song7_InfoClick(object sender, EventArgs e)
        {
            ppageMain.SetPage(4);
            pInforSong.Image = song7.ImageSong;
            txtNameSong.Text = song7.NameSong;
            txtInfoArtist.Text = song7.Artist;
            txtInfoGenre.Text = song7.Genre;
            txtYear.Text = "2020";
            txtComposer.Text = "Imagine Dragons";
        }

        private void song8_Load(object sender, EventArgs e)
        {
            ppageMain.SetPage(4);
            pInforSong.Image = song8.ImageSong;
            txtNameSong.Text = song8.NameSong;
            txtInfoArtist.Text = song8.Artist;
            txtInfoGenre.Text = song8.Genre;
            txtYear.Text = "2020";
            txtComposer.Text = "Vu";
        }

        private void song9_InfoClick(object sender, EventArgs e)
        {
            ppageMain.SetPage(4);
            pInforSong.Image = song9.ImageSong;
            txtNameSong.Text = song9.NameSong;
            txtInfoArtist.Text = song9.Artist;
            txtInfoGenre.Text = song9.Genre;
            txtYear.Text = "2020";
            txtComposer.Text = "Son Tung M-TP";
        }

        private void song10_InfoClick(object sender, EventArgs e)
        {
            ppageMain.SetPage(4);
            pInforSong.Image = song10.ImageSong;
            txtNameSong.Text = song10.NameSong;
            txtInfoArtist.Text = song10.Artist;
            txtInfoGenre.Text = song10.Genre;
            txtYear.Text = "2020";
            txtComposer.Text = "Son Tung M-TP";
        }

        private void genre1_PicClick(object sender, EventArgs e)
        {
            ppageMain.SetPage(5);
        }
    }
}