using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicApp.Source
{
    public partial class Song : UserControl
    {
        public static Song instance;
        public event EventHandler InfoClick;

        public Song()
        {
            InitializeComponent();
            instance = this;
        }

        #region custom attribute
        [Category("aMusic")]
        public Image ImageSong
        {
            get
            {
                return pSong.Image;
            }
            set
            {
                pSong.Image = value;
            }
        }

        [Category("aMusic")]
        public String Genre
        {
            get { return txtGenre.Text; }
            set { txtGenre.Text = value; }
        }

        [Category("aMusic")]
        public String NameSong
        {
            get { return txtName.Text; }
            set { txtName.Text = value; }
        }

        [Category("aMusic")]
        public String Artist
        {
            get { return txtArtist.Text; }
            set { txtArtist.Text = value; }
        }

        [Category("aMusic")]
        public String Number
        {
            get { return txtNum.Text; }
            set { txtNum.Text = value; }
        }

        [Category("aMusic")]
        public String Time
        { 
            get { return txtTime.Text; }
            set { txtTime.Text = value; }
        }
        #endregion

        #region effect when hover
        private void pInfor_MouseHover(object sender, EventArgs e)
        {
            pInfor.Image = global::MusicApp.Properties.Resources.info_white;
        }

        private void pInfor_MouseLeave(object sender, EventArgs e)
        {
            pInfor.Image = global::MusicApp.Properties.Resources.info;
        }

        private void pDown_MouseHover(object sender, EventArgs e)
        {
            pDown.Image = global::MusicApp.Properties.Resources.download_white;
        }

        private void pDown_MouseLeave(object sender, EventArgs e)
        {
            pDown.Image = global::MusicApp.Properties.Resources.download;
        }
        #endregion

        #region effect when click
        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when user clicks button")]

        protected void pInfor_Click(object sender, EventArgs e)
        {
            if (this.InfoClick != null)
                InfoClick.Invoke(this, e);
        }

        private void Song_Click(object sender, EventArgs e)
        {
            HomeForm.instance.SongName.Text = txtName.Text;
            HomeForm.instance.Artist.Text = txtArtist.Text;
            HomeForm.instance.SongPicture.Image = pSong.Image;
        }
        #endregion

    }
}
