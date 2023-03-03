namespace DatabaseSQLApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            LoadAlbumButton = new Button();
            AlbumsDataGridView = new DataGridView();
            SearchButton = new Button();
            AlbumSearchTextBox = new TextBox();
            AlbumImage = new PictureBox();
            AddAlbumGroupBox = new GroupBox();
            AddButton = new Button();
            txt_Description = new TextBox();
            txt_ImageURL = new TextBox();
            txt_albumYear = new TextBox();
            txt_albumArtist = new TextBox();
            txt_albumName = new TextBox();
            DescriptionLabel = new Label();
            ImageURLLabel = new Label();
            YearLabel = new Label();
            ArtistLabel = new Label();
            AlbumNameLabel = new Label();
            dataGridView2 = new DataGridView();
            TracksGroupBox = new GroupBox();
            AlbumsGroupBox = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)AlbumsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AlbumImage).BeginInit();
            AddAlbumGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            TracksGroupBox.SuspendLayout();
            AlbumsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // LoadAlbumButton
            // 
            LoadAlbumButton.Location = new Point(202, 11);
            LoadAlbumButton.Name = "LoadAlbumButton";
            LoadAlbumButton.Size = new Size(144, 29);
            LoadAlbumButton.TabIndex = 0;
            LoadAlbumButton.Text = "Load Albums";
            LoadAlbumButton.UseVisualStyleBackColor = true;
            LoadAlbumButton.Click += LoadAlbumButton_Click;
            // 
            // AlbumsDataGridView
            // 
            AlbumsDataGridView.AllowUserToResizeColumns = false;
            AlbumsDataGridView.AllowUserToResizeRows = false;
            AlbumsDataGridView.Location = new Point(205, 46);
            AlbumsDataGridView.Name = "AlbumsDataGridView";
            AlbumsDataGridView.RowTemplate.Height = 25;
            AlbumsDataGridView.Size = new Size(889, 190);
            AlbumsDataGridView.TabIndex = 1;
            AlbumsDataGridView.CellClick += AlbumsDataGridView_CellClick;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(604, 12);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(75, 23);
            SearchButton.TabIndex = 2;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // AlbumSearchTextBox
            // 
            AlbumSearchTextBox.Location = new Point(430, 12);
            AlbumSearchTextBox.Name = "AlbumSearchTextBox";
            AlbumSearchTextBox.Size = new Size(168, 23);
            AlbumSearchTextBox.TabIndex = 3;
            // 
            // AlbumImage
            // 
            AlbumImage.InitialImage = (Image)resources.GetObject("AlbumImage.InitialImage");
            AlbumImage.Location = new Point(8, 46);
            AlbumImage.Name = "AlbumImage";
            AlbumImage.Size = new Size(190, 190);
            AlbumImage.SizeMode = PictureBoxSizeMode.Zoom;
            AlbumImage.TabIndex = 4;
            AlbumImage.TabStop = false;
            // 
            // AddAlbumGroupBox
            // 
            AddAlbumGroupBox.Controls.Add(AddButton);
            AddAlbumGroupBox.Controls.Add(txt_Description);
            AddAlbumGroupBox.Controls.Add(txt_ImageURL);
            AddAlbumGroupBox.Controls.Add(txt_albumYear);
            AddAlbumGroupBox.Controls.Add(txt_albumArtist);
            AddAlbumGroupBox.Controls.Add(txt_albumName);
            AddAlbumGroupBox.Controls.Add(DescriptionLabel);
            AddAlbumGroupBox.Controls.Add(ImageURLLabel);
            AddAlbumGroupBox.Controls.Add(YearLabel);
            AddAlbumGroupBox.Controls.Add(ArtistLabel);
            AddAlbumGroupBox.Controls.Add(AlbumNameLabel);
            AddAlbumGroupBox.Location = new Point(3, 251);
            AddAlbumGroupBox.Name = "AddAlbumGroupBox";
            AddAlbumGroupBox.Size = new Size(276, 255);
            AddAlbumGroupBox.TabIndex = 5;
            AddAlbumGroupBox.TabStop = false;
            AddAlbumGroupBox.Text = "Add Album";
            // 
            // AddButton
            // 
            AddButton.Location = new Point(106, 190);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(129, 51);
            AddButton.TabIndex = 10;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // txt_Description
            // 
            txt_Description.Location = new Point(97, 157);
            txt_Description.Name = "txt_Description";
            txt_Description.Size = new Size(152, 23);
            txt_Description.TabIndex = 9;
            // 
            // txt_ImageURL
            // 
            txt_ImageURL.Location = new Point(97, 126);
            txt_ImageURL.Name = "txt_ImageURL";
            txt_ImageURL.Size = new Size(152, 23);
            txt_ImageURL.TabIndex = 8;
            // 
            // txt_albumYear
            // 
            txt_albumYear.Location = new Point(97, 95);
            txt_albumYear.Name = "txt_albumYear";
            txt_albumYear.Size = new Size(152, 23);
            txt_albumYear.TabIndex = 7;
            // 
            // txt_albumArtist
            // 
            txt_albumArtist.Location = new Point(97, 64);
            txt_albumArtist.Name = "txt_albumArtist";
            txt_albumArtist.Size = new Size(152, 23);
            txt_albumArtist.TabIndex = 6;
            // 
            // txt_albumName
            // 
            txt_albumName.Location = new Point(97, 33);
            txt_albumName.Name = "txt_albumName";
            txt_albumName.Size = new Size(152, 23);
            txt_albumName.TabIndex = 5;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Location = new Point(8, 162);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(67, 15);
            DescriptionLabel.TabIndex = 4;
            DescriptionLabel.Text = "Description";
            // 
            // ImageURLLabel
            // 
            ImageURLLabel.AutoSize = true;
            ImageURLLabel.Location = new Point(8, 131);
            ImageURLLabel.Name = "ImageURLLabel";
            ImageURLLabel.Size = new Size(64, 15);
            ImageURLLabel.TabIndex = 3;
            ImageURLLabel.Text = "Image URL";
            // 
            // YearLabel
            // 
            YearLabel.AutoSize = true;
            YearLabel.Location = new Point(8, 100);
            YearLabel.Name = "YearLabel";
            YearLabel.Size = new Size(29, 15);
            YearLabel.TabIndex = 2;
            YearLabel.Text = "Year";
            // 
            // ArtistLabel
            // 
            ArtistLabel.AutoSize = true;
            ArtistLabel.Location = new Point(8, 69);
            ArtistLabel.Name = "ArtistLabel";
            ArtistLabel.Size = new Size(35, 15);
            ArtistLabel.TabIndex = 1;
            ArtistLabel.Text = "Artist";
            // 
            // AlbumNameLabel
            // 
            AlbumNameLabel.AutoSize = true;
            AlbumNameLabel.Location = new Point(8, 38);
            AlbumNameLabel.Name = "AlbumNameLabel";
            AlbumNameLabel.Size = new Size(78, 15);
            AlbumNameLabel.TabIndex = 0;
            AlbumNameLabel.Text = "Album Name";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(6, 22);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(550, 223);
            dataGridView2.TabIndex = 7;
            // 
            // TracksGroupBox
            // 
            TracksGroupBox.Controls.Add(dataGridView2);
            TracksGroupBox.Location = new Point(286, 251);
            TracksGroupBox.Name = "TracksGroupBox";
            TracksGroupBox.Size = new Size(565, 255);
            TracksGroupBox.TabIndex = 8;
            TracksGroupBox.TabStop = false;
            TracksGroupBox.Text = "Tracks";
            // 
            // AlbumsGroupBox
            // 
            AlbumsGroupBox.Controls.Add(LoadAlbumButton);
            AlbumsGroupBox.Controls.Add(AlbumSearchTextBox);
            AlbumsGroupBox.Controls.Add(SearchButton);
            AlbumsGroupBox.Location = new Point(3, 3);
            AlbumsGroupBox.Name = "AlbumsGroupBox";
            AlbumsGroupBox.Size = new Size(1099, 241);
            AlbumsGroupBox.TabIndex = 9;
            AlbumsGroupBox.TabStop = false;
            AlbumsGroupBox.Text = "Albums";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1106, 509);
            Controls.Add(AddAlbumGroupBox);
            Controls.Add(AlbumImage);
            Controls.Add(AlbumsDataGridView);
            Controls.Add(TracksGroupBox);
            Controls.Add(AlbumsGroupBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Database Viewer";
            ((System.ComponentModel.ISupportInitialize)AlbumsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)AlbumImage).EndInit();
            AddAlbumGroupBox.ResumeLayout(false);
            AddAlbumGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            TracksGroupBox.ResumeLayout(false);
            AlbumsGroupBox.ResumeLayout(false);
            AlbumsGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button LoadAlbumButton;
        private DataGridView AlbumsDataGridView;
        private Button SearchButton;
        private TextBox AlbumSearchTextBox;
        private PictureBox AlbumImage;
        private GroupBox AddAlbumGroupBox;
        private Button AddButton;
        private TextBox txt_Description;
        private TextBox txt_ImageURL;
        private TextBox txt_albumYear;
        private TextBox txt_albumArtist;
        private TextBox txt_albumName;
        private Label DescriptionLabel;
        private Label ImageURLLabel;
        private Label YearLabel;
        private Label ArtistLabel;
        private Label AlbumNameLabel;
        private DataGridView dataGridView2;
        private GroupBox TracksGroupBox;
        private GroupBox AlbumsGroupBox;
    }
}