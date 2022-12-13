using MusicApp.Source;

namespace MusicApp
{
    public partial class HomeForm : Form
    {
        private Form currentChildForm;

        public HomeForm()
        {
            InitializeComponent();
            OpenChildForm(new MainForm());
        }

        #region Effect when click menu
        private void btnHome_Click(object sender, EventArgs e)
        {
            // change color and image
            btnFind.BackColor = Color.FromArgb(40, 40, 40);
            btnFind.ForeColor = Color.FromArgb(179, 179, 179);
            btnFind.Image = global::MusicApp.Properties.Resources.search;

            btnCollection.BackColor = Color.FromArgb(40, 40, 40);
            btnCollection.ForeColor = Color.FromArgb(179, 179, 179);
            btnCollection.Image = global::MusicApp.Properties.Resources.folder;

            btnHome.BackColor = Color.FromArgb(25, 143, 15);
            btnHome.ForeColor = Color.White;
            btnHome.Image = global::MusicApp.Properties.Resources.home_white;

            //Open child form
            OpenChildForm(new MainForm());
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            // change color and image
            btnHome.BackColor = Color.FromArgb(40, 40, 40);
            btnHome.ForeColor = Color.FromArgb(179, 179, 179);
            btnHome.Image = global::MusicApp.Properties.Resources.home;

            btnCollection.BackColor = Color.FromArgb(40, 40, 40);
            btnCollection.ForeColor = Color.FromArgb(179, 179, 179);
            btnCollection.Image = global::MusicApp.Properties.Resources.folder;

            btnFind.BackColor = Color.FromArgb(25, 143, 15);
            btnFind.ForeColor = Color.White;
            btnFind.Image = global::MusicApp.Properties.Resources.search_white;

            //Open child form
        }

        private void btnCollection_Click(object sender, EventArgs e)
        {
            // change color and image
            btnHome.BackColor = Color.FromArgb(40, 40, 40);
            btnHome.ForeColor = Color.FromArgb(179, 179, 179);
            btnHome.Image = global::MusicApp.Properties.Resources.home;

            btnFind.BackColor = Color.FromArgb(40, 40, 40);
            btnFind.ForeColor = Color.FromArgb(179, 179, 179);
            btnFind.Image = global::MusicApp.Properties.Resources.search;

            btnCollection.BackColor = Color.FromArgb(25, 143, 15);
            btnCollection.ForeColor = Color.White;
            btnCollection.Image = global::MusicApp.Properties.Resources.folder_white;

            //Open child form
        }
        #endregion

        #region function to open child form
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnMain.Controls.Add(childForm);
            pnMain.Tag= childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        #endregion
    }
}