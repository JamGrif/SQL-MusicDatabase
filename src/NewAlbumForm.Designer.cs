namespace DatabaseSQLApp
{
    partial class NewAlbumForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewAlbumForm));
            AddAlbumButton = new Button();
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
            EnterNewLabel = new Label();
            SuccessLabel = new Label();
            FailLabel = new Label();
            TextVisibilityTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // AddAlbumButton
            // 
            AddAlbumButton.Enabled = false;
            AddAlbumButton.Location = new Point(113, 213);
            AddAlbumButton.Name = "AddAlbumButton";
            AddAlbumButton.Size = new Size(130, 50);
            AddAlbumButton.TabIndex = 21;
            AddAlbumButton.Text = "Add Album";
            AddAlbumButton.UseVisualStyleBackColor = true;
            AddAlbumButton.Click += AddAlbumButton_Click;
            // 
            // txt_Description
            // 
            txt_Description.Location = new Point(149, 175);
            txt_Description.Name = "txt_Description";
            txt_Description.Size = new Size(152, 23);
            txt_Description.TabIndex = 20;
            txt_Description.TextChanged += txt_Description_TextChanged;
            // 
            // txt_ImageURL
            // 
            txt_ImageURL.Location = new Point(149, 144);
            txt_ImageURL.Name = "txt_ImageURL";
            txt_ImageURL.Size = new Size(152, 23);
            txt_ImageURL.TabIndex = 19;
            txt_ImageURL.TextChanged += txt_ImageURL_TextChanged;
            // 
            // txt_albumYear
            // 
            txt_albumYear.Location = new Point(149, 113);
            txt_albumYear.Name = "txt_albumYear";
            txt_albumYear.Size = new Size(152, 23);
            txt_albumYear.TabIndex = 18;
            txt_albumYear.TextChanged += txt_albumYear_TextChanged;
            // 
            // txt_albumArtist
            // 
            txt_albumArtist.Location = new Point(149, 82);
            txt_albumArtist.Name = "txt_albumArtist";
            txt_albumArtist.Size = new Size(152, 23);
            txt_albumArtist.TabIndex = 17;
            txt_albumArtist.TextChanged += txt_albumArtist_TextChanged;
            // 
            // txt_albumName
            // 
            txt_albumName.Location = new Point(149, 51);
            txt_albumName.Name = "txt_albumName";
            txt_albumName.Size = new Size(152, 23);
            txt_albumName.TabIndex = 16;
            txt_albumName.TextChanged += txt_albumName_TextChanged;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Location = new Point(60, 180);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(67, 15);
            DescriptionLabel.TabIndex = 15;
            DescriptionLabel.Text = "Description";
            // 
            // ImageURLLabel
            // 
            ImageURLLabel.AutoSize = true;
            ImageURLLabel.Location = new Point(60, 149);
            ImageURLLabel.Name = "ImageURLLabel";
            ImageURLLabel.Size = new Size(64, 15);
            ImageURLLabel.TabIndex = 14;
            ImageURLLabel.Text = "Image URL";
            // 
            // YearLabel
            // 
            YearLabel.AutoSize = true;
            YearLabel.Location = new Point(60, 118);
            YearLabel.Name = "YearLabel";
            YearLabel.Size = new Size(29, 15);
            YearLabel.TabIndex = 13;
            YearLabel.Text = "Year";
            // 
            // ArtistLabel
            // 
            ArtistLabel.AutoSize = true;
            ArtistLabel.Location = new Point(60, 87);
            ArtistLabel.Name = "ArtistLabel";
            ArtistLabel.Size = new Size(35, 15);
            ArtistLabel.TabIndex = 12;
            ArtistLabel.Text = "Artist";
            // 
            // AlbumNameLabel
            // 
            AlbumNameLabel.AutoSize = true;
            AlbumNameLabel.Location = new Point(60, 56);
            AlbumNameLabel.Name = "AlbumNameLabel";
            AlbumNameLabel.Size = new Size(78, 15);
            AlbumNameLabel.TabIndex = 11;
            AlbumNameLabel.Text = "Album Name";
            // 
            // EnterNewLabel
            // 
            EnterNewLabel.AutoSize = true;
            EnterNewLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            EnterNewLabel.Location = new Point(26, 5);
            EnterNewLabel.Name = "EnterNewLabel";
            EnterNewLabel.Size = new Size(332, 37);
            EnterNewLabel.TabIndex = 23;
            EnterNewLabel.Text = "Enter new album details:";
            // 
            // SuccessLabel
            // 
            SuccessLabel.AutoSize = true;
            SuccessLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            SuccessLabel.ForeColor = Color.LimeGreen;
            SuccessLabel.Location = new Point(24, 273);
            SuccessLabel.Name = "SuccessLabel";
            SuccessLabel.Size = new Size(348, 25);
            SuccessLabel.TabIndex = 24;
            SuccessLabel.Text = "Successfully added album to database";
            SuccessLabel.Visible = false;
            // 
            // FailLabel
            // 
            FailLabel.AutoSize = true;
            FailLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            FailLabel.ForeColor = Color.Tomato;
            FailLabel.Location = new Point(47, 273);
            FailLabel.Name = "FailLabel";
            FailLabel.Size = new Size(295, 25);
            FailLabel.TabIndex = 25;
            FailLabel.Text = "Failed to add album to database";
            FailLabel.Visible = false;
            // 
            // TextVisibilityTimer
            // 
            TextVisibilityTimer.Interval = 3000;
            TextVisibilityTimer.Tick += TextVisibilityTimer_Tick;
            // 
            // NewAlbumForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 311);
            Controls.Add(FailLabel);
            Controls.Add(SuccessLabel);
            Controls.Add(EnterNewLabel);
            Controls.Add(AddAlbumButton);
            Controls.Add(txt_Description);
            Controls.Add(txt_ImageURL);
            Controls.Add(txt_albumYear);
            Controls.Add(txt_albumArtist);
            Controls.Add(txt_albumName);
            Controls.Add(DescriptionLabel);
            Controls.Add(ImageURLLabel);
            Controls.Add(YearLabel);
            Controls.Add(ArtistLabel);
            Controls.Add(AlbumNameLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "NewAlbumForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New Album";
            FormClosing += NewAlbumForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddAlbumButton;
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
        private Label EnterNewLabel;
        private Label SuccessLabel;
        private Label FailLabel;
        private System.Windows.Forms.Timer TextVisibilityTimer;
    }
}