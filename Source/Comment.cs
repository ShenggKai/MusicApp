﻿using System;
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
    }
}
