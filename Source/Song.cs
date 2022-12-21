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

        public Image aImageSong
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

        public String aNameSong
        {
            get { return txtName.Text; }
            set { txtName.Text = value; }
        }

        public String aArtist
        {
            get { return txtArtist.Text; }
            set { txtArtist.Text = value; }
        }

        public String aNumber
        {
            get { return txtNum.Text; }
            set { txtNum.Text = value; }
        }

        public String aTime
        { 
            get { return txtTime.Text; }
            set { txtTime.Text = value; }
        }
    }
}
