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
    }
}
