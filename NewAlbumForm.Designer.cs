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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewAlbumForm));
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
            ResultText = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.Location = new Point(113, 213);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(129, 51);
            AddButton.TabIndex = 21;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // txt_Description
            // 
            txt_Description.Location = new Point(149, 175);
            txt_Description.Name = "txt_Description";
            txt_Description.Size = new Size(152, 23);
            txt_Description.TabIndex = 20;
            // 
            // txt_ImageURL
            // 
            txt_ImageURL.Location = new Point(149, 144);
            txt_ImageURL.Name = "txt_ImageURL";
            txt_ImageURL.Size = new Size(152, 23);
            txt_ImageURL.TabIndex = 19;
            // 
            // txt_albumYear
            // 
            txt_albumYear.Location = new Point(149, 113);
            txt_albumYear.Name = "txt_albumYear";
            txt_albumYear.Size = new Size(152, 23);
            txt_albumYear.TabIndex = 18;
            // 
            // txt_albumArtist
            // 
            txt_albumArtist.Location = new Point(149, 82);
            txt_albumArtist.Name = "txt_albumArtist";
            txt_albumArtist.Size = new Size(152, 23);
            txt_albumArtist.TabIndex = 17;
            // 
            // txt_albumName
            // 
            txt_albumName.Location = new Point(149, 51);
            txt_albumName.Name = "txt_albumName";
            txt_albumName.Size = new Size(152, 23);
            txt_albumName.TabIndex = 16;
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
            // ResultText
            // 
            ResultText.AutoSize = true;
            ResultText.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ResultText.Location = new Point(74, 276);
            ResultText.Name = "ResultText";
            ResultText.Size = new Size(49, 25);
            ResultText.TabIndex = 22;
            ResultText.Text = "Text";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(26, 5);
            label1.Name = "label1";
            label1.Size = new Size(332, 37);
            label1.TabIndex = 23;
            label1.Text = "Enter new album details:";
            // 
            // NewAlbumForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 311);
            Controls.Add(label1);
            Controls.Add(ResultText);
            Controls.Add(AddButton);
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
            Name = "NewAlbumForm";
            Text = "New Album";
            FormClosing += NewAlbumForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private Label ResultText;
        private Label label1;
    }
}