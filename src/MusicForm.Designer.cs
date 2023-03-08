namespace DatabaseSQLApp
{
    partial class MusicForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicForm));
            LoadAlbumsButton = new Button();
            AlbumsDataGridView = new DataGridView();
            SearchButton = new Button();
            AlbumSearchTextBox = new TextBox();
            AlbumImage = new PictureBox();
            TracksDataGridView = new DataGridView();
            TracksGroupBox = new GroupBox();
            AddNewTrackButton = new Button();
            PlayTrackButton = new Button();
            DeleteSelectedTrackButton = new Button();
            AlbumsGroupBox = new GroupBox();
            AddNewAlbumButton = new Button();
            webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)AlbumsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AlbumImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TracksDataGridView).BeginInit();
            TracksGroupBox.SuspendLayout();
            AlbumsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView).BeginInit();
            SuspendLayout();
            // 
            // LoadAlbumsButton
            // 
            LoadAlbumsButton.Location = new Point(497, 9);
            LoadAlbumsButton.Name = "LoadAlbumsButton";
            LoadAlbumsButton.Size = new Size(150, 30);
            LoadAlbumsButton.TabIndex = 0;
            LoadAlbumsButton.Text = "Load Albums";
            LoadAlbumsButton.UseVisualStyleBackColor = true;
            LoadAlbumsButton.Click += LoadAlbumsButton_Click;
            // 
            // AlbumsDataGridView
            // 
            AlbumsDataGridView.AllowUserToAddRows = false;
            AlbumsDataGridView.AllowUserToDeleteRows = false;
            AlbumsDataGridView.AllowUserToResizeColumns = false;
            AlbumsDataGridView.AllowUserToResizeRows = false;
            AlbumsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            AlbumsDataGridView.Location = new Point(205, 91);
            AlbumsDataGridView.MultiSelect = false;
            AlbumsDataGridView.Name = "AlbumsDataGridView";
            AlbumsDataGridView.ReadOnly = true;
            AlbumsDataGridView.RowHeadersVisible = false;
            AlbumsDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            AlbumsDataGridView.RowTemplate.Height = 25;
            AlbumsDataGridView.Size = new Size(889, 190);
            AlbumsDataGridView.TabIndex = 1;
            AlbumsDataGridView.CellClick += AlbumsDataGridView_CellClick;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(380, 15);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(150, 30);
            SearchButton.TabIndex = 2;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // AlbumSearchTextBox
            // 
            AlbumSearchTextBox.Location = new Point(535, 20);
            AlbumSearchTextBox.Name = "AlbumSearchTextBox";
            AlbumSearchTextBox.Size = new Size(168, 23);
            AlbumSearchTextBox.TabIndex = 3;
            // 
            // AlbumImage
            // 
            AlbumImage.InitialImage = (Image)resources.GetObject("AlbumImage.InitialImage");
            AlbumImage.Location = new Point(8, 91);
            AlbumImage.Name = "AlbumImage";
            AlbumImage.Size = new Size(190, 190);
            AlbumImage.SizeMode = PictureBoxSizeMode.Zoom;
            AlbumImage.TabIndex = 4;
            AlbumImage.TabStop = false;
            // 
            // TracksDataGridView
            // 
            TracksDataGridView.AllowUserToAddRows = false;
            TracksDataGridView.AllowUserToDeleteRows = false;
            TracksDataGridView.AllowUserToResizeColumns = false;
            TracksDataGridView.AllowUserToResizeRows = false;
            TracksDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            TracksDataGridView.Location = new Point(6, 22);
            TracksDataGridView.MultiSelect = false;
            TracksDataGridView.Name = "TracksDataGridView";
            TracksDataGridView.ReadOnly = true;
            TracksDataGridView.RowHeadersVisible = false;
            TracksDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            TracksDataGridView.RowTemplate.Height = 25;
            TracksDataGridView.Size = new Size(699, 223);
            TracksDataGridView.TabIndex = 1;
            // 
            // TracksGroupBox
            // 
            TracksGroupBox.Controls.Add(AddNewTrackButton);
            TracksGroupBox.Controls.Add(PlayTrackButton);
            TracksGroupBox.Controls.Add(DeleteSelectedTrackButton);
            TracksGroupBox.Controls.Add(TracksDataGridView);
            TracksGroupBox.Enabled = false;
            TracksGroupBox.Location = new Point(3, 296);
            TracksGroupBox.Name = "TracksGroupBox";
            TracksGroupBox.Size = new Size(1091, 289);
            TracksGroupBox.TabIndex = 8;
            TracksGroupBox.TabStop = false;
            TracksGroupBox.Text = "Tracks";
            // 
            // AddNewTrackButton
            // 
            AddNewTrackButton.Location = new Point(10, 250);
            AddNewTrackButton.Name = "AddNewTrackButton";
            AddNewTrackButton.Size = new Size(150, 30);
            AddNewTrackButton.TabIndex = 11;
            AddNewTrackButton.Text = "Add New Track...";
            AddNewTrackButton.UseVisualStyleBackColor = true;
            AddNewTrackButton.Click += AddNewTrackButton_Click;
            // 
            // PlayTrackButton
            // 
            PlayTrackButton.Location = new Point(370, 250);
            PlayTrackButton.Name = "PlayTrackButton";
            PlayTrackButton.Size = new Size(150, 30);
            PlayTrackButton.TabIndex = 10;
            PlayTrackButton.Text = "Play Track";
            PlayTrackButton.UseVisualStyleBackColor = true;
            PlayTrackButton.Click += PlayTrackButton_Click;
            // 
            // DeleteSelectedTrackButton
            // 
            DeleteSelectedTrackButton.Location = new Point(190, 250);
            DeleteSelectedTrackButton.Name = "DeleteSelectedTrackButton";
            DeleteSelectedTrackButton.Size = new Size(150, 30);
            DeleteSelectedTrackButton.TabIndex = 10;
            DeleteSelectedTrackButton.Text = "Delete Selected Track";
            DeleteSelectedTrackButton.UseVisualStyleBackColor = true;
            DeleteSelectedTrackButton.Click += DeleteSelectedTrackButton_Click;
            // 
            // AlbumsGroupBox
            // 
            AlbumsGroupBox.Controls.Add(AddNewAlbumButton);
            AlbumsGroupBox.Controls.Add(AlbumSearchTextBox);
            AlbumsGroupBox.Controls.Add(SearchButton);
            AlbumsGroupBox.Enabled = false;
            AlbumsGroupBox.Location = new Point(3, 40);
            AlbumsGroupBox.Name = "AlbumsGroupBox";
            AlbumsGroupBox.Size = new Size(1099, 249);
            AlbumsGroupBox.TabIndex = 9;
            AlbumsGroupBox.TabStop = false;
            AlbumsGroupBox.Text = "Albums";
            // 
            // AddNewAlbumButton
            // 
            AddNewAlbumButton.Location = new Point(200, 15);
            AddNewAlbumButton.Name = "AddNewAlbumButton";
            AddNewAlbumButton.Size = new Size(150, 30);
            AddNewAlbumButton.TabIndex = 11;
            AddNewAlbumButton.Text = "Add New Album...";
            AddNewAlbumButton.UseVisualStyleBackColor = true;
            AddNewAlbumButton.Click += AddNewAlbumButton_Click;
            // 
            // webView
            // 
            webView.AllowExternalDrop = true;
            webView.CreationProperties = null;
            webView.DefaultBackgroundColor = Color.White;
            webView.Location = new Point(769, 318);
            webView.Name = "webView";
            webView.Size = new Size(308, 223);
            webView.Source = new Uri("https://www.microsoft.com", UriKind.Absolute);
            webView.TabIndex = 11;
            webView.Visible = false;
            webView.ZoomFactor = 1D;
            // 
            // MusicForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1104, 591);
            Controls.Add(webView);
            Controls.Add(LoadAlbumsButton);
            Controls.Add(AlbumImage);
            Controls.Add(AlbumsDataGridView);
            Controls.Add(TracksGroupBox);
            Controls.Add(AlbumsGroupBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MusicForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Music";
            Load += MusicForm_Load;
            ((System.ComponentModel.ISupportInitialize)AlbumsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)AlbumImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)TracksDataGridView).EndInit();
            TracksGroupBox.ResumeLayout(false);
            AlbumsGroupBox.ResumeLayout(false);
            AlbumsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)webView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button LoadAlbumsButton;
        private DataGridView AlbumsDataGridView;
        private Button SearchButton;
        private TextBox AlbumSearchTextBox;
        private PictureBox AlbumImage;
        private DataGridView TracksDataGridView;
        private GroupBox TracksGroupBox;
        private GroupBox AlbumsGroupBox;
        private Button DeleteSelectedTrackButton;
        private Button AddNewAlbumButton;
        private Button AddNewTrackButton;
        private Button PlayTrackButton;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
    }
}