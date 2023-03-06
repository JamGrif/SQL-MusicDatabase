namespace DatabaseSQLApp
{
    partial class NewTrackForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewTrackForm));
            AddTrackButton = new Button();
            txt_trackLyrics = new TextBox();
            txt_trackVideoURL = new TextBox();
            txt_trackNumber = new TextBox();
            txt_trackTitle = new TextBox();
            LyricsLabel = new Label();
            VideoURLLabel = new Label();
            NumberLabel = new Label();
            TrackTitleLabel = new Label();
            EnterNewLabel = new Label();
            AddingToLabel = new Label();
            ResultText = new Label();
            SuspendLayout();
            // 
            // AddTrackButton
            // 
            AddTrackButton.Location = new Point(123, 215);
            AddTrackButton.Name = "AddTrackButton";
            AddTrackButton.Size = new Size(129, 51);
            AddTrackButton.TabIndex = 41;
            AddTrackButton.Text = "Add Track";
            AddTrackButton.UseVisualStyleBackColor = true;
            AddTrackButton.Click += AddTrackButton_Click;
            // 
            // txt_trackLyrics
            // 
            txt_trackLyrics.Location = new Point(161, 162);
            txt_trackLyrics.Name = "txt_trackLyrics";
            txt_trackLyrics.Size = new Size(152, 23);
            txt_trackLyrics.TabIndex = 40;
            // 
            // txt_trackVideoURL
            // 
            txt_trackVideoURL.Location = new Point(161, 131);
            txt_trackVideoURL.Name = "txt_trackVideoURL";
            txt_trackVideoURL.Size = new Size(152, 23);
            txt_trackVideoURL.TabIndex = 39;
            // 
            // txt_trackNumber
            // 
            txt_trackNumber.Location = new Point(161, 100);
            txt_trackNumber.Name = "txt_trackNumber";
            txt_trackNumber.Size = new Size(152, 23);
            txt_trackNumber.TabIndex = 38;
            // 
            // txt_trackTitle
            // 
            txt_trackTitle.Location = new Point(161, 69);
            txt_trackTitle.Name = "txt_trackTitle";
            txt_trackTitle.Size = new Size(152, 23);
            txt_trackTitle.TabIndex = 37;
            // 
            // LyricsLabel
            // 
            LyricsLabel.AutoSize = true;
            LyricsLabel.Location = new Point(72, 167);
            LyricsLabel.Name = "LyricsLabel";
            LyricsLabel.Size = new Size(36, 15);
            LyricsLabel.TabIndex = 36;
            LyricsLabel.Text = "Lyrics";
            // 
            // VideoURLLabel
            // 
            VideoURLLabel.AutoSize = true;
            VideoURLLabel.Location = new Point(72, 136);
            VideoURLLabel.Name = "VideoURLLabel";
            VideoURLLabel.Size = new Size(61, 15);
            VideoURLLabel.TabIndex = 35;
            VideoURLLabel.Text = "Video URL";
            // 
            // NumberLabel
            // 
            NumberLabel.AutoSize = true;
            NumberLabel.Location = new Point(72, 105);
            NumberLabel.Name = "NumberLabel";
            NumberLabel.Size = new Size(51, 15);
            NumberLabel.TabIndex = 34;
            NumberLabel.Text = "Number";
            // 
            // TrackTitleLabel
            // 
            TrackTitleLabel.AutoSize = true;
            TrackTitleLabel.Location = new Point(72, 74);
            TrackTitleLabel.Name = "TrackTitleLabel";
            TrackTitleLabel.Size = new Size(59, 15);
            TrackTitleLabel.TabIndex = 33;
            TrackTitleLabel.Text = "Track Title";
            // 
            // EnterNewLabel
            // 
            EnterNewLabel.AutoSize = true;
            EnterNewLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            EnterNewLabel.Location = new Point(36, 3);
            EnterNewLabel.Name = "EnterNewLabel";
            EnterNewLabel.Size = new Size(316, 37);
            EnterNewLabel.TabIndex = 42;
            EnterNewLabel.Text = "Enter new track details:";
            // 
            // AddingToLabel
            // 
            AddingToLabel.AutoSize = true;
            AddingToLabel.Location = new Point(93, 40);
            AddingToLabel.Name = "AddingToLabel";
            AddingToLabel.Size = new Size(186, 15);
            AddingToLabel.TabIndex = 43;
            AddingToLabel.Text = "Adding to album ALBUMNAME ...";
            // 
            // ResultText
            // 
            ResultText.AutoSize = true;
            ResultText.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ResultText.Location = new Point(12, 277);
            ResultText.Name = "ResultText";
            ResultText.Size = new Size(62, 25);
            ResultText.TabIndex = 44;
            ResultText.Text = "result";
            // 
            // NewTrackForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 311);
            Controls.Add(ResultText);
            Controls.Add(AddingToLabel);
            Controls.Add(EnterNewLabel);
            Controls.Add(AddTrackButton);
            Controls.Add(txt_trackLyrics);
            Controls.Add(txt_trackVideoURL);
            Controls.Add(txt_trackNumber);
            Controls.Add(txt_trackTitle);
            Controls.Add(LyricsLabel);
            Controls.Add(VideoURLLabel);
            Controls.Add(NumberLabel);
            Controls.Add(TrackTitleLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "NewTrackForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New Track";
            FormClosing += NewTrackForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddTrackButton;
        private TextBox txt_trackLyrics;
        private TextBox txt_trackVideoURL;
        private TextBox txt_trackNumber;
        private TextBox txt_trackTitle;
        private Label LyricsLabel;
        private Label VideoURLLabel;
        private Label NumberLabel;
        private Label TrackTitleLabel;
        private Label EnterNewLabel;
        private Label AddingToLabel;
        private Label ResultText;
    }
}