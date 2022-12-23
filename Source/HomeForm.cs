using MusicApp.Source;

namespace MusicApp
{
    public partial class HomeForm : Form //form 1
    {
        public static HomeForm instance;
        public FlowLayoutPanel fpnlist;
        public HomeForm()
        {
            InitializeComponent();
            instance= this;
            fpnlist = fpnPlaylist;
        }

        #region change to default menu
        private void changeHome()
        {
            btnHome.BackColor = Color.FromArgb(40, 40, 40);
            btnHome.ForeColor = Color.FromArgb(179, 179, 179);
            btnHome.Image = global::MusicApp.Properties.Resources.home;
        }

        private void changeGenre()
        {
            btnGenre.BackColor = Color.FromArgb(40, 40, 40);
            btnGenre.ForeColor = Color.FromArgb(179, 179, 179);
            btnGenre.Image = global::MusicApp.Properties.Resources.genre;
        }

        private void changeCollection()
        {
            btnCollection.BackColor = Color.FromArgb(40, 40, 40);
            btnCollection.ForeColor = Color.FromArgb(179, 179, 179);
            btnCollection.Image = global::MusicApp.Properties.Resources.music_library;
        }

        private void changeHistory()
        {
            btnHistory.BackColor = Color.FromArgb(40, 40, 40);
            btnHistory.ForeColor = Color.FromArgb(179, 179, 179);
            btnHistory.Image = global::MusicApp.Properties.Resources.time_past;
        }
        #endregion

        #region Effect when click menu
        private void btnHome_Click(object sender, EventArgs e)
        {
            // change color and image
            changeGenre();
            changeCollection();
            changeHistory();

            btnHome.BackColor = Color.FromArgb(25, 143, 15);
            btnHome.ForeColor = Color.White;
            btnHome.Image = global::MusicApp.Properties.Resources.home_full;

            //navigation to trang chu
            pageMain.PageIndex = 0;
        }

        private void btnGenre_Click(object sender, EventArgs e)
        {
            // change color and image
            changeHome();
            changeCollection();
            changeHistory();

            btnGenre.BackColor = Color.FromArgb(25, 143, 15);
            btnGenre.ForeColor = Color.White;
            btnGenre.Image = global::MusicApp.Properties.Resources.genre_full;

            //navigation to genre
            pageMain.PageIndex = 1;
        }

        private void btnCollection_Click(object sender, EventArgs e)
        {
            // change color and image
            changeHome();
            changeGenre();
            changeHistory();

            btnCollection.BackColor = Color.FromArgb(25, 143, 15);
            btnCollection.ForeColor = Color.White;
            btnCollection.Image = global::MusicApp.Properties.Resources.music_library_full;

            //navigation to collection
            pageMain.PageIndex = 2;
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            changeHome();
            changeGenre();
            changeCollection();

            btnHistory.BackColor = Color.FromArgb(25, 143, 15);
            btnHistory.ForeColor = Color.White;
            btnHistory.Image = global::MusicApp.Properties.Resources.time_past_full;
        }
        #endregion

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

        #region effect when hover menu
        private void btnHome_MouseHover(object sender, EventArgs e)
        {
            btnHome.ForeColor = Color.White;
            btnHome.Image = global::MusicApp.Properties.Resources.home_white;
        }

        private void btnGenre_MouseHover(object sender, EventArgs e)
        {
            btnGenre.ForeColor= Color.White;
            btnGenre.Image = global::MusicApp.Properties.Resources.genre_white;
        }

        private void btnCollection_MouseHover(object sender, EventArgs e)
        {
            btnCollection.ForeColor= Color.White;
            btnCollection.Image = global::MusicApp.Properties.Resources.music_library_white;
        }

        private void btnHistory_MouseHover(object sender, EventArgs e)
        {
            btnHistory.ForeColor= Color.White;
            btnHistory.Image = global::MusicApp.Properties.Resources.time_past_white;
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

        #region when click button
        private void btnMore2_Click(object sender, EventArgs e)
        {
            pageMain.PageIndex = 3;
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

        private void btnHome_MouseLeave(object sender, EventArgs e)
        {
            changeHome();
        }

        private void btnGenre_MouseLeave(object sender, EventArgs e)
        {
            changeGenre();
        }

        private void btnCollection_MouseLeave(object sender, EventArgs e)
        {
            changeCollection();
        }

        private void btnHistory_MouseLeave(object sender, EventArgs e)
        {
            changeHistory();
        }
    }
}