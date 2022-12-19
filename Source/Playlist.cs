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
    public partial class Playlist : UserControl
    {
        public Playlist()
        {
            InitializeComponent();
        }

        public Image Image 
        { 
            get
            {
                return pPlaylist.Image;
            }

            set
            {
                pPlaylist.Image = value;
            }
        }

        public string Title 
        {
            get
            {
                return txtPlaylist.Text;
            }

            set
            {
                txtPlaylist.Text = value;
            }
        }
    }
}
