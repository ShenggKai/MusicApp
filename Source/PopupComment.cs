using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicApp.Source
{
    public partial class PopupComment : Form
    {
        public static PopupComment instance;

        public PopupComment()
        {
            InitializeComponent();
            instance= this;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pUser_Click(object sender, EventArgs e)
        {
            openFileDialogCmt.ShowDialog();
            pUser.ImageLocation = openFileDialogCmt.FileName;
        }

        private bool ValidateName()
        {
            bool bStatus = true;

            if (txtboxName.Text == "")
            {
                errorProvider1.SetError(txtboxName, "required");
                bStatus = false;
            }
            else
            {
                errorProvider1.SetError(txtboxName, "");
            }
            return bStatus;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool bValidName = ValidateName();
            if (bValidName) 
            {
                Comment cmt = new Comment();
                cmt.NameUser = txtboxName.Text;
                cmt.ImageUser = pUser.Image;
                cmt.Ratting = btnRatting.Value;
                cmt.TextCmt = tboxCmt.Text;

                HomeForm.instance.fpnCmt.Controls.Add(cmt);
                this.Close();

                Update();
            }
        }

        private void txtboxName_Validated(object sender, EventArgs e)
        {
            ValidateName();
        }
    }
}
