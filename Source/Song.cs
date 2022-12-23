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
        public Song()
        {
            InitializeComponent();
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
        public String NameSong
        {
            get { return txtGenre.Text; }
            set { txtGenre.Text = value; }
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

        private void Song_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(80, 80, 80);
        }

        private void Song_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(24, 24, 24);
        }
    }
}
