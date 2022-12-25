namespace MusicApp.Source
{
    partial class PopupComment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopupComment));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties13 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties14 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties15 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties16 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.pnComment = new Bunifu.UI.WinForms.BunifuPanel();
            this.btnRatting = new Bunifu.UI.WinForms.BunifuRating();
            this.btnAdd = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pUser = new System.Windows.Forms.PictureBox();
            this.tboxCmt = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.pnLine = new System.Windows.Forms.Panel();
            this.btnClose = new Bunifu.UI.WinForms.BunifuImageButton();
            this.lbCmt = new System.Windows.Forms.Label();
            this.openFileDialogCmt = new System.Windows.Forms.OpenFileDialog();
            this.pnComment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pUser)).BeginInit();
            this.SuspendLayout();
            // 
            // pnComment
            // 
            this.pnComment.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.pnComment.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnComment.BackgroundImage")));
            this.pnComment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnComment.BorderColor = System.Drawing.Color.Transparent;
            this.pnComment.BorderRadius = 30;
            this.pnComment.BorderThickness = 0;
            this.pnComment.Controls.Add(this.btnRatting);
            this.pnComment.Controls.Add(this.btnAdd);
            this.pnComment.Controls.Add(this.pUser);
            this.pnComment.Controls.Add(this.tboxCmt);
            this.pnComment.Controls.Add(this.txtboxName);
            this.pnComment.Controls.Add(this.pnLine);
            this.pnComment.Controls.Add(this.btnClose);
            this.pnComment.Controls.Add(this.lbCmt);
            this.pnComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnComment.Location = new System.Drawing.Point(0, 0);
            this.pnComment.Margin = new System.Windows.Forms.Padding(0);
            this.pnComment.Name = "pnComment";
            this.pnComment.ShowBorders = true;
            this.pnComment.Size = new System.Drawing.Size(729, 589);
            this.pnComment.TabIndex = 0;
            // 
            // btnRatting
            // 
            this.btnRatting.BackColor = System.Drawing.Color.Transparent;
            this.btnRatting.DisabledEmptyFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnRatting.DisabledRatedFillColor = System.Drawing.Color.DarkGray;
            this.btnRatting.EmptyBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnRatting.EmptyFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnRatting.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRatting.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.btnRatting.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.btnRatting.InnerRadius = 2F;
            this.btnRatting.Location = new System.Drawing.Point(351, 170);
            this.btnRatting.Name = "btnRatting";
            this.btnRatting.OuterRadius = 10F;
            this.btnRatting.RatedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.btnRatting.RatedFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.btnRatting.ReadOnly = false;
            this.btnRatting.RightClickToClear = true;
            this.btnRatting.Size = new System.Drawing.Size(151, 22);
            this.btnRatting.Spacing = 10;
            this.btnRatting.TabIndex = 10;
            this.btnRatting.Text = "bunifuRating2";
            this.btnRatting.Value = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.AllowAnimations = true;
            this.btnAdd.AllowMouseEffects = true;
            this.btnAdd.AllowToggling = false;
            this.btnAdd.AnimationSpeed = 200;
            this.btnAdd.AutoGenerateColors = false;
            this.btnAdd.AutoRoundBorders = false;
            this.btnAdd.AutoSizeLeftIcon = true;
            this.btnAdd.AutoSizeRightIcon = true;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAdd.ButtonText = "Đăng";
            this.btnAdd.ButtonTextMarginLeft = 0;
            this.btnAdd.ColorContrastOnClick = 45;
            this.btnAdd.ColorContrastOnHover = 45;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnAdd.CustomizableEdges = borderEdges4;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdd.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAdd.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnAdd.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnAdd.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 14.4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.IconLeft = null;
            this.btnAdd.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAdd.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAdd.IconMarginLeft = 11;
            this.btnAdd.IconPadding = 10;
            this.btnAdd.IconRight = null;
            this.btnAdd.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAdd.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAdd.IconSize = 25;
            this.btnAdd.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnAdd.IdleBorderRadius = 0;
            this.btnAdd.IdleBorderThickness = 0;
            this.btnAdd.IdleFillColor = System.Drawing.Color.Empty;
            this.btnAdd.IdleIconLeftImage = null;
            this.btnAdd.IdleIconRightImage = null;
            this.btnAdd.IndicateFocus = false;
            this.btnAdd.Location = new System.Drawing.Point(231, 499);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAdd.OnDisabledState.BorderRadius = 40;
            this.btnAdd.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAdd.OnDisabledState.BorderThickness = 0;
            this.btnAdd.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAdd.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAdd.OnDisabledState.IconLeftImage = null;
            this.btnAdd.OnDisabledState.IconRightImage = null;
            this.btnAdd.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(196)))), ((int)(((byte)(125)))));
            this.btnAdd.onHoverState.BorderRadius = 40;
            this.btnAdd.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAdd.onHoverState.BorderThickness = 0;
            this.btnAdd.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(196)))), ((int)(((byte)(125)))));
            this.btnAdd.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAdd.onHoverState.IconLeftImage = null;
            this.btnAdd.onHoverState.IconRightImage = null;
            this.btnAdd.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(148)))), ((int)(((byte)(20)))));
            this.btnAdd.OnIdleState.BorderRadius = 40;
            this.btnAdd.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAdd.OnIdleState.BorderThickness = 0;
            this.btnAdd.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(148)))), ((int)(((byte)(20)))));
            this.btnAdd.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAdd.OnIdleState.IconLeftImage = null;
            this.btnAdd.OnIdleState.IconRightImage = null;
            this.btnAdd.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(148)))), ((int)(((byte)(20)))));
            this.btnAdd.OnPressedState.BorderRadius = 40;
            this.btnAdd.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAdd.OnPressedState.BorderThickness = 0;
            this.btnAdd.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(148)))), ((int)(((byte)(20)))));
            this.btnAdd.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAdd.OnPressedState.IconLeftImage = null;
            this.btnAdd.OnPressedState.IconRightImage = null;
            this.btnAdd.Size = new System.Drawing.Size(390, 60);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.TextMarginLeft = 0;
            this.btnAdd.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAdd.UseDefaultRadiusAndThickness = true;
            // 
            // pUser
            // 
            this.pUser.BackColor = System.Drawing.Color.Transparent;
            this.pUser.Image = global::MusicApp.Properties.Resources.user;
            this.pUser.Location = new System.Drawing.Point(30, 98);
            this.pUser.Name = "pUser";
            this.pUser.Size = new System.Drawing.Size(150, 150);
            this.pUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pUser.TabIndex = 7;
            this.pUser.TabStop = false;
            this.pUser.Click += new System.EventHandler(this.pUser_Click);
            // 
            // tboxCmt
            // 
            this.tboxCmt.AcceptsReturn = false;
            this.tboxCmt.AcceptsTab = false;
            this.tboxCmt.AnimationSpeed = 200;
            this.tboxCmt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tboxCmt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tboxCmt.AutoSizeHeight = true;
            this.tboxCmt.BackColor = System.Drawing.Color.Transparent;
            this.tboxCmt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tboxCmt.BackgroundImage")));
            this.tboxCmt.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.tboxCmt.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tboxCmt.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.tboxCmt.BorderColorIdle = System.Drawing.Color.Silver;
            this.tboxCmt.BorderRadius = 20;
            this.tboxCmt.BorderThickness = 0;
            this.tboxCmt.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tboxCmt.DefaultFont = new System.Drawing.Font("Segoe UI", 14.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tboxCmt.DefaultText = "";
            this.tboxCmt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.tboxCmt.ForeColor = System.Drawing.Color.White;
            this.tboxCmt.HideSelection = true;
            this.tboxCmt.IconLeft = null;
            this.tboxCmt.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.tboxCmt.IconPadding = 10;
            this.tboxCmt.IconRight = null;
            this.tboxCmt.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.tboxCmt.Lines = new string[0];
            this.tboxCmt.Location = new System.Drawing.Point(211, 222);
            this.tboxCmt.MaxLength = 32767;
            this.tboxCmt.MinimumSize = new System.Drawing.Size(1, 1);
            this.tboxCmt.Modified = false;
            this.tboxCmt.Multiline = true;
            this.tboxCmt.Name = "tboxCmt";
            stateProperties13.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties13.FillColor = System.Drawing.Color.Empty;
            stateProperties13.ForeColor = System.Drawing.Color.Empty;
            stateProperties13.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tboxCmt.OnActiveState = stateProperties13;
            stateProperties14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties14.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.tboxCmt.OnDisabledState = stateProperties14;
            stateProperties15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties15.FillColor = System.Drawing.Color.Empty;
            stateProperties15.ForeColor = System.Drawing.Color.Empty;
            stateProperties15.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tboxCmt.OnHoverState = stateProperties15;
            stateProperties16.BorderColor = System.Drawing.Color.Silver;
            stateProperties16.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            stateProperties16.ForeColor = System.Drawing.Color.White;
            stateProperties16.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tboxCmt.OnIdleState = stateProperties16;
            this.tboxCmt.Padding = new System.Windows.Forms.Padding(3);
            this.tboxCmt.PasswordChar = '\0';
            this.tboxCmt.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.tboxCmt.PlaceholderText = "Nhập bình luận";
            this.tboxCmt.ReadOnly = false;
            this.tboxCmt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxCmt.SelectedText = "";
            this.tboxCmt.SelectionLength = 0;
            this.tboxCmt.SelectionStart = 0;
            this.tboxCmt.ShortcutsEnabled = true;
            this.tboxCmt.Size = new System.Drawing.Size(430, 247);
            this.tboxCmt.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.tboxCmt.TabIndex = 6;
            this.tboxCmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tboxCmt.TextMarginBottom = 0;
            this.tboxCmt.TextMarginLeft = 20;
            this.tboxCmt.TextMarginTop = 14;
            this.tboxCmt.TextPlaceholder = "Nhập bình luận";
            this.tboxCmt.UseSystemPasswordChar = false;
            this.tboxCmt.WordWrap = true;
            // 
            // txtboxName
            // 
            this.txtboxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.txtboxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxName.Font = new System.Drawing.Font("Segoe UI", 14.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtboxName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.txtboxName.Location = new System.Drawing.Point(231, 98);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.PlaceholderText = "Nhập tên";
            this.txtboxName.Size = new System.Drawing.Size(390, 32);
            this.txtboxName.TabIndex = 5;
            // 
            // pnLine
            // 
            this.pnLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.pnLine.Location = new System.Drawing.Point(231, 132);
            this.pnLine.Name = "pnLine";
            this.pnLine.Size = new System.Drawing.Size(390, 1);
            this.pnLine.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.ActiveImage = null;
            this.btnClose.AllowAnimations = true;
            this.btnClose.AllowBuffering = false;
            this.btnClose.AllowToggling = false;
            this.btnClose.AllowZooming = true;
            this.btnClose.AllowZoomingOnFocus = false;
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClose.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnClose.ErrorImage")));
            this.btnClose.FadeWhenInactive = false;
            this.btnClose.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnClose.Image = global::MusicApp.Properties.Resources.close;
            this.btnClose.ImageActive = null;
            this.btnClose.ImageLocation = null;
            this.btnClose.ImageMargin = 0;
            this.btnClose.ImageSize = new System.Drawing.Size(21, 21);
            this.btnClose.ImageZoomSize = new System.Drawing.Size(22, 22);
            this.btnClose.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.btnClose.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnClose.InitialImage")));
            this.btnClose.Location = new System.Drawing.Point(677, 30);
            this.btnClose.Name = "btnClose";
            this.btnClose.Rotation = 0;
            this.btnClose.ShowActiveImage = true;
            this.btnClose.ShowCursorChanges = true;
            this.btnClose.ShowImageBorders = true;
            this.btnClose.ShowSizeMarkers = false;
            this.btnClose.Size = new System.Drawing.Size(22, 22);
            this.btnClose.TabIndex = 1;
            this.btnClose.ToolTipText = "";
            this.btnClose.WaitOnLoad = false;
            this.btnClose.Zoom = 0;
            this.btnClose.ZoomSpeed = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbCmt
            // 
            this.lbCmt.BackColor = System.Drawing.Color.Transparent;
            this.lbCmt.Font = new System.Drawing.Font("Segoe UI Semibold", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCmt.ForeColor = System.Drawing.Color.White;
            this.lbCmt.Location = new System.Drawing.Point(231, 30);
            this.lbCmt.Name = "lbCmt";
            this.lbCmt.Size = new System.Drawing.Size(390, 38);
            this.lbCmt.TabIndex = 0;
            this.lbCmt.Text = "Bình luận";
            this.lbCmt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialogCmt
            // 
            this.openFileDialogCmt.Filter = "(*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            this.openFileDialogCmt.Title = "Chọn ảnh đại diện";
            // 
            // PopupComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(729, 589);
            this.Controls.Add(this.pnComment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PopupComment";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PopupComment";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.pnComment.ResumeLayout(false);
            this.pnComment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel pnComment;
        private Label lbCmt;
        private Bunifu.UI.WinForms.BunifuImageButton btnClose;
        private TextBox txtboxName;
        private Panel pnLine;
        private PictureBox pUser;
        private Bunifu.UI.WinForms.BunifuTextBox tboxCmt;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAdd;
        private Bunifu.UI.WinForms.BunifuRating btnRatting;
        private OpenFileDialog openFileDialogCmt;
    }
}