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
            DeleteSelectedTrackButton = new Button();
            AlbumsGroupBox = new GroupBox();
            AddNewAlbumButton = new Button();
            AddTrackButton = new Button();
            txt_trackLyrics = new TextBox();
            txt_trackVideoURL = new TextBox();
            txt_trackNumber = new TextBox();
            txt_trackTitle = new TextBox();
            LyricsLabel = new Label();
            VideoURLLabel = new Label();
            NumberLabel = new Label();
            TrackTitleLabel = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)AlbumsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AlbumImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TracksDataGridView).BeginInit();
            TracksGroupBox.SuspendLayout();
            AlbumsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // LoadAlbumsButton
            // 
            LoadAlbumsButton.Location = new Point(497, 5);
            LoadAlbumsButton.Name = "LoadAlbumsButton";
            LoadAlbumsButton.Size = new Size(144, 29);
            LoadAlbumsButton.TabIndex = 0;
            LoadAlbumsButton.Text = "Load Albums";
            LoadAlbumsButton.UseVisualStyleBackColor = true;
            LoadAlbumsButton.Click += LoadAlbumsButton_Click;
            // 
            // AlbumsDataGridView
            // 
            AlbumsDataGridView.AllowUserToResizeColumns = false;
            AlbumsDataGridView.AllowUserToResizeRows = false;
            AlbumsDataGridView.Location = new Point(205, 91);
            AlbumsDataGridView.Name = "AlbumsDataGridView";
            AlbumsDataGridView.RowTemplate.Height = 25;
            AlbumsDataGridView.Size = new Size(889, 190);
            AlbumsDataGridView.TabIndex = 1;
            AlbumsDataGridView.CellClick += AlbumsDataGridView_CellClick;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(613, 11);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(89, 34);
            SearchButton.TabIndex = 2;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // AlbumSearchTextBox
            // 
            AlbumSearchTextBox.Location = new Point(430, 22);
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
            TracksDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TracksDataGridView.Location = new Point(6, 22);
            TracksDataGridView.Name = "TracksDataGridView";
            TracksDataGridView.RowTemplate.Height = 25;
            TracksDataGridView.Size = new Size(550, 223);
            TracksDataGridView.TabIndex = 7;
            // 
            // TracksGroupBox
            // 
            TracksGroupBox.Controls.Add(DeleteSelectedTrackButton);
            TracksGroupBox.Controls.Add(TracksDataGridView);
            TracksGroupBox.Location = new Point(3, 296);
            TracksGroupBox.Name = "TracksGroupBox";
            TracksGroupBox.Size = new Size(565, 289);
            TracksGroupBox.TabIndex = 8;
            TracksGroupBox.TabStop = false;
            TracksGroupBox.Text = "Tracks";
            // 
            // DeleteSelectedTrackButton
            // 
            DeleteSelectedTrackButton.Location = new Point(6, 253);
            DeleteSelectedTrackButton.Name = "DeleteSelectedTrackButton";
            DeleteSelectedTrackButton.Size = new Size(144, 29);
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
            AlbumsGroupBox.Location = new Point(3, 40);
            AlbumsGroupBox.Name = "AlbumsGroupBox";
            AlbumsGroupBox.Size = new Size(1099, 249);
            AlbumsGroupBox.TabIndex = 9;
            AlbumsGroupBox.TabStop = false;
            AlbumsGroupBox.Text = "Albums";
            // 
            // AddNewAlbumButton
            // 
            AddNewAlbumButton.Location = new Point(740, 11);
            AddNewAlbumButton.Name = "AddNewAlbumButton";
            AddNewAlbumButton.Size = new Size(119, 33);
            AddNewAlbumButton.TabIndex = 11;
            AddNewAlbumButton.Text = "Add New Album...";
            AddNewAlbumButton.UseVisualStyleBackColor = true;
            AddNewAlbumButton.Click += AddNewAlbumButton_Click;
            // 
            // AddTrackButton
            // 
            AddTrackButton.Location = new Point(672, 462);
            AddTrackButton.Name = "AddTrackButton";
            AddTrackButton.Size = new Size(129, 51);
            AddTrackButton.TabIndex = 32;
            AddTrackButton.Text = "Add Track";
            AddTrackButton.UseVisualStyleBackColor = true;
            AddTrackButton.Click += AddTrackButton_Click;
            // 
            // txt_trackLyrics
            // 
            txt_trackLyrics.Location = new Point(710, 409);
            txt_trackLyrics.Name = "txt_trackLyrics";
            txt_trackLyrics.Size = new Size(152, 23);
            txt_trackLyrics.TabIndex = 30;
            // 
            // txt_trackVideoURL
            // 
            txt_trackVideoURL.Location = new Point(710, 378);
            txt_trackVideoURL.Name = "txt_trackVideoURL";
            txt_trackVideoURL.Size = new Size(152, 23);
            txt_trackVideoURL.TabIndex = 29;
            // 
            // txt_trackNumber
            // 
            txt_trackNumber.Location = new Point(710, 347);
            txt_trackNumber.Name = "txt_trackNumber";
            txt_trackNumber.Size = new Size(152, 23);
            txt_trackNumber.TabIndex = 28;
            // 
            // txt_trackTitle
            // 
            txt_trackTitle.Location = new Point(710, 316);
            txt_trackTitle.Name = "txt_trackTitle";
            txt_trackTitle.Size = new Size(152, 23);
            txt_trackTitle.TabIndex = 27;
            // 
            // LyricsLabel
            // 
            LyricsLabel.AutoSize = true;
            LyricsLabel.Location = new Point(621, 414);
            LyricsLabel.Name = "LyricsLabel";
            LyricsLabel.Size = new Size(36, 15);
            LyricsLabel.TabIndex = 25;
            LyricsLabel.Text = "Lyrics";
            // 
            // VideoURLLabel
            // 
            VideoURLLabel.AutoSize = true;
            VideoURLLabel.Location = new Point(621, 383);
            VideoURLLabel.Name = "VideoURLLabel";
            VideoURLLabel.Size = new Size(61, 15);
            VideoURLLabel.TabIndex = 24;
            VideoURLLabel.Text = "Video URL";
            // 
            // NumberLabel
            // 
            NumberLabel.AutoSize = true;
            NumberLabel.Location = new Point(621, 352);
            NumberLabel.Name = "NumberLabel";
            NumberLabel.Size = new Size(51, 15);
            NumberLabel.TabIndex = 23;
            NumberLabel.Text = "Number";
            // 
            // TrackTitleLabel
            // 
            TrackTitleLabel.AutoSize = true;
            TrackTitleLabel.Location = new Point(621, 321);
            TrackTitleLabel.Name = "TrackTitleLabel";
            TrackTitleLabel.Size = new Size(59, 15);
            TrackTitleLabel.TabIndex = 22;
            TrackTitleLabel.Text = "Track Title";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(616, 292);
            label1.Name = "label1";
            label1.Size = new Size(233, 15);
            label1.TabIndex = 33;
            label1.Text = "adds new track to currently selected album";
            // 
            // MusicForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1104, 591);
            Controls.Add(label1);
            Controls.Add(AddTrackButton);
            Controls.Add(txt_trackLyrics);
            Controls.Add(txt_trackVideoURL);
            Controls.Add(txt_trackNumber);
            Controls.Add(txt_trackTitle);
            Controls.Add(LyricsLabel);
            Controls.Add(VideoURLLabel);
            Controls.Add(NumberLabel);
            Controls.Add(TrackTitleLabel);
            Controls.Add(LoadAlbumsButton);
            Controls.Add(AlbumImage);
            Controls.Add(AlbumsDataGridView);
            Controls.Add(TracksGroupBox);
            Controls.Add(AlbumsGroupBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MusicForm";
            Text = "Music";
            Load += MusicForm_Load;
            ((System.ComponentModel.ISupportInitialize)AlbumsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)AlbumImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)TracksDataGridView).EndInit();
            TracksGroupBox.ResumeLayout(false);
            AlbumsGroupBox.ResumeLayout(false);
            AlbumsGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private Button AddTrackButton;
        private TextBox txt_trackLyrics;
        private TextBox txt_trackVideoURL;
        private TextBox txt_trackNumber;
        private TextBox txt_trackTitle;
        private Label LyricsLabel;
        private Label VideoURLLabel;
        private Label NumberLabel;
        private Label TrackTitleLabel;
        private Label label1;
    }
}