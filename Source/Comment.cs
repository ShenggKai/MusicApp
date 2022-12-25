using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicApp.Source
{
    public partial class Comment : UserControl
    {
        public Comment()
        {
            InitializeComponent();
        }

        public Image ImageUser
        {
            get { return pUser.Image; }
            set { pUser.Image = value; }
        }

        public String NameUser
        {
            get { return txtUserName.Text; }
            set { txtUserName.Text = value; }
        }

        public String TextCmt
        {
            get { return txtCmt.Text; }
            set { txtCmt.Text = value;}
        }

        public int Ratting
        {
            get { return bunifuRating1.Value; }
            set { bunifuRating1.Value = value;}
        }

        private void Comment_Load(object sender, EventArgs e)
        {
            string TimeTemp = DateTime.Now.ToShortTimeString();
            string DayTemp = DateTime.Now.ToShortDateString();
            txtTime.Text = TimeTemp + ", " + DayTemp;
        }

        #region when hover
        private void pLike_MouseHover(object sender, EventArgs e)
        {
            pLike.Image = global::MusicApp.Properties.Resources.like_white;
        }

        private void pLike_MouseLeave(object sender, EventArgs e)
        {
            pLike.Image = global::MusicApp.Properties.Resources.like;
        }

        private void pUnlike_MouseLeave(object sender, EventArgs e)
        {
            pUnlike.Image = global::MusicApp.Properties.Resources.unlike;
        }

        private void pUnlike_MouseHover(object sender, EventArgs e)
        {
            pUnlike.Image = global::MusicApp.Properties.Resources.unlike_white;
        }

        #endregion

        private void pTrash_MouseHover(object sender, EventArgs e)
        {
            pTrash.Image = global::MusicApp.Properties.Resources.trash_white;
        }

        private void pTrash_MouseLeave(object sender, EventArgs e)
        {
            pTrash.Image = global::MusicApp.Properties.Resources.trash;
        }
    }
}
