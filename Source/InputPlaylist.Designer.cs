namespace MusicApp.Source
{
    partial class InputPlaylist
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputPlaylist));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.pnPlaylist = new Bunifu.UI.WinForms.BunifuPanel();
            this.pPlaylist = new System.Windows.Forms.PictureBox();
            this.btnAdd = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.pnLine = new System.Windows.Forms.Panel();
            this.txtAdd = new System.Windows.Forms.Label();
            this.btnClose = new Bunifu.UI.WinForms.BunifuImageButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnPlaylist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pPlaylist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnPlaylist
            // 
            this.pnPlaylist.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.pnPlaylist.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnPlaylist.BackgroundImage")));
            this.pnPlaylist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnPlaylist.BorderColor = System.Drawing.Color.Transparent;
            this.pnPlaylist.BorderRadius = 30;
            this.pnPlaylist.BorderThickness = 0;
            this.pnPlaylist.Controls.Add(this.pPlaylist);
            this.pnPlaylist.Controls.Add(this.btnAdd);
            this.pnPlaylist.Controls.Add(this.txtboxName);
            this.pnPlaylist.Controls.Add(this.pnLine);
            this.pnPlaylist.Controls.Add(this.txtAdd);
            this.pnPlaylist.Controls.Add(this.btnClose);
            this.pnPlaylist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPlaylist.Location = new System.Drawing.Point(0, 0);
            this.pnPlaylist.Margin = new System.Windows.Forms.Padding(0);
            this.pnPlaylist.Name = "pnPlaylist";
            this.pnPlaylist.ShowBorders = true;
            this.pnPlaylist.Size = new System.Drawing.Size(734, 273);
            this.pnPlaylist.TabIndex = 1;
            // 
            // pPlaylist
            // 
            this.pPlaylist.BackColor = System.Drawing.Color.Transparent;
            this.pPlaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pPlaylist.Image = global::MusicApp.Properties.Resources.music;
            this.pPlaylist.Location = new System.Drawing.Point(35, 31);
            this.pPlaylist.Name = "pPlaylist";
            this.pPlaylist.Size = new System.Drawing.Size(212, 212);
            this.pPlaylist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pPlaylist.TabIndex = 5;
            this.pPlaylist.TabStop = false;
            this.pPlaylist.Click += new System.EventHandler(this.pPlaylist_Click);
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
            this.btnAdd.ButtonText = "Tạo mới";
            this.btnAdd.ButtonTextMarginLeft = 0;
            this.btnAdd.ColorContrastOnClick = 45;
            this.btnAdd.ColorContrastOnHover = 45;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnAdd.CustomizableEdges = borderEdges1;
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
            this.btnAdd.Location = new System.Drawing.Point(287, 172);
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
            this.btnAdd.TabIndex = 4;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.TextMarginLeft = 0;
            this.btnAdd.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAdd.UseDefaultRadiusAndThickness = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtboxName
            // 
            this.txtboxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.txtboxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtboxName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.txtboxName.Location = new System.Drawing.Point(287, 97);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.PlaceholderText = "Nhập tên Playlist";
            this.txtboxName.Size = new System.Drawing.Size(390, 32);
            this.txtboxName.TabIndex = 3;
            this.txtboxName.Validating += new System.ComponentModel.CancelEventHandler(this.txtboxName_Validating);
            // 
            // pnLine
            // 
            this.pnLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.pnLine.Location = new System.Drawing.Point(287, 132);
            this.pnLine.Name = "pnLine";
            this.pnLine.Size = new System.Drawing.Size(390, 1);
            this.pnLine.TabIndex = 2;
            // 
            // txtAdd
            // 
            this.txtAdd.BackColor = System.Drawing.Color.Transparent;
            this.txtAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtAdd.ForeColor = System.Drawing.Color.White;
            this.txtAdd.Location = new System.Drawing.Point(377, 20);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(227, 38);
            this.txtAdd.TabIndex = 1;
            this.txtAdd.Text = "Tạo playlist mới";
            this.txtAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.btnClose.TabIndex = 0;
            this.btnClose.ToolTipText = "";
            this.btnClose.WaitOnLoad = false;
            this.btnClose.Zoom = 0;
            this.btnClose.ZoomSpeed = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "(*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            this.openFileDialog.Title = "Chọn ảnh playlist";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // InputPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(734, 273);
            this.Controls.Add(this.pnPlaylist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InputPlaylist";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tạo playlist mới";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.pnPlaylist.ResumeLayout(false);
            this.pnPlaylist.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pPlaylist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuPanel pnPlaylist;
        private Bunifu.UI.WinForms.BunifuImageButton btnClose;
        private Label txtAdd;
        private Panel pnLine;
        private TextBox txtboxName;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAdd;
        private PictureBox pPlaylist;
        private OpenFileDialog openFileDialog;
        private ErrorProvider errorProvider1;
    }
}