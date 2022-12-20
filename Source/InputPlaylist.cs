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

            //no need to click text box to add input when load form
            this.ActiveControl = txtboxName;
            txtboxName.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void pPlaylist_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            pPlaylist.ImageLocation = openFileDialog.FileName;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Playlist pl = new Playlist();
            pl.Title = txtboxName.Text;
            pl.Image = pPlaylist.Image;

            HomeForm.instance.fpnlist.Controls.Add(pl);
            this.Close();
        }

    }
}
