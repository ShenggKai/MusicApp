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
    public partial class Genre : UserControl
    {
        public Genre()
        {
            InitializeComponent();
        }

        public Image Image
        {
            get
            {
                return pGenre.Image;
            }

            set
            {
                pGenre.Image = value;
            }
        }

        public string Text
        {
            get
            {
                return lbGenre.Text;
            }

            set
            {
                lbGenre.Text = value;
            }
        }
    }
}
