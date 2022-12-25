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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace MusicApp.Source
{
    public partial class Comment : UserControl
    {
        bool liked = false;
        bool unliked = false;

        public Comment()
        {
            InitializeComponent();
        }

        #region custom attribute
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
        #endregion

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
            if (!liked)
            {
                pLike.Image = global::MusicApp.Properties.Resources.like;
            }
        }

        private void pUnlike_MouseLeave(object sender, EventArgs e)
        {
            if (!unliked)
            {
                pUnlike.Image = global::MusicApp.Properties.Resources.unlike;
            }            
        }

        private void pUnlike_MouseHover(object sender, EventArgs e)
        {
            pUnlike.Image = global::MusicApp.Properties.Resources.unlike_white;
        }

        private void pTrash_MouseHover(object sender, EventArgs e)
        {
            pTrash.Image = global::MusicApp.Properties.Resources.trash_white;
        }

        private void pTrash_MouseLeave(object sender, EventArgs e)
        {
            pTrash.Image = global::MusicApp.Properties.Resources.trash;
        }

        #endregion

        #region effect when click
        private void pLike_Click(object sender, EventArgs e)
        {
            pLike.Image = global::MusicApp.Properties.Resources.like_green;

            pUnlike.Image = global::MusicApp.Properties.Resources.unlike;

            liked = true;
            unliked = false;
        }

        private void pUnlike_Click(object sender, EventArgs e)
        {
            pUnlike.Image = global::MusicApp.Properties.Resources.unlike_green;

            pLike.Image = global::MusicApp.Properties.Resources.like;

            unliked = true;
            liked = false;
        }

        #endregion

        private void pTrash_Click(object sender, EventArgs e)
        {
            const string message =
        "Xác nhận xóa bình luận?";
            const string caption = "MusicApp";
            var result = MessageBox.Show(message, caption,
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                this.Controls.Clear();
                this.Dispose();
            }
        }
    }
}
