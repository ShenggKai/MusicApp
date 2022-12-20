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
    public partial class InputPlaylist : Form //form 2
    {
        public static InputPlaylist instance;
        public InputPlaylist()
        {
            InitializeComponent();
            instance = this;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Playlist pl = new Playlist();
            pl.Title = txtboxName.Text;

            HomeForm.instance.fpnlist.Controls.Add(pl);
            this.Close();
        }
    }
}
