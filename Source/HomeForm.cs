using MusicApp.Source;

namespace MusicApp
{
    public partial class HomeForm : Form
    {
        //private Form currentChildForm;

        public HomeForm()
        {
            InitializeComponent();
        }

        #region Effect when click menu
        private void btnHome_Click(object sender, EventArgs e)
        {
            // change color and image
            btnFind.BackColor = Color.FromArgb(40, 40, 40);
            btnFind.ForeColor = Color.FromArgb(179, 179, 179);
            btnFind.Image = global::MusicApp.Properties.Resources.search;

            btnCollection.BackColor = Color.FromArgb(40, 40, 40);
            btnCollection.ForeColor = Color.FromArgb(179, 179, 179);
            btnCollection.Image = global::MusicApp.Properties.Resources.folder;

            btnHome.BackColor = Color.FromArgb(25, 143, 15);
            btnHome.ForeColor = Color.White;
            btnHome.Image = global::MusicApp.Properties.Resources.home_white;

            ////Open child form
            //OpenChildForm(new MainForm());
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            // change color and image
            btnHome.BackColor = Color.FromArgb(40, 40, 40);
            btnHome.ForeColor = Color.FromArgb(179, 179, 179);
            btnHome.Image = global::MusicApp.Properties.Resources.home;

            btnCollection.BackColor = Color.FromArgb(40, 40, 40);
            btnCollection.ForeColor = Color.FromArgb(179, 179, 179);
            btnCollection.Image = global::MusicApp.Properties.Resources.folder;

            btnFind.BackColor = Color.FromArgb(25, 143, 15);
            btnFind.ForeColor = Color.White;
            btnFind.Image = global::MusicApp.Properties.Resources.search_white;

            //Open child form
        }

        private void btnCollection_Click(object sender, EventArgs e)
        {
            // change color and image
            btnHome.BackColor = Color.FromArgb(40, 40, 40);
            btnHome.ForeColor = Color.FromArgb(179, 179, 179);
            btnHome.Image = global::MusicApp.Properties.Resources.home;

            btnFind.BackColor = Color.FromArgb(40, 40, 40);
            btnFind.ForeColor = Color.FromArgb(179, 179, 179);
            btnFind.Image = global::MusicApp.Properties.Resources.search;

            btnCollection.BackColor = Color.FromArgb(25, 143, 15);
            btnCollection.ForeColor = Color.White;
            btnCollection.Image = global::MusicApp.Properties.Resources.folder_white;

            //Open child form
        }
        #endregion

        #region  Effect when hover menu

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

        //#region function to open child form
        //private void OpenChildForm(Form childForm)
        //{
        //    if (currentChildForm != null)
        //    {
        //        currentChildForm.Close();
        //    }
        //    currentChildForm = childForm;
        //    childForm.TopLevel = false;
        //    childForm.FormBorderStyle = FormBorderStyle.None;
        //    childForm.Dock = DockStyle.Fill;
        //    pnMain.Controls.Add(childForm);
        //    pnMain.Tag= childForm;
        //    childForm.BringToFront();
        //    childForm.Show();
        //}

        //#endregion


        int count = 0;
        private void btnHeart_Click(object sender, EventArgs e)
        {
            if (count == 0 ) 
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

        


    }
}