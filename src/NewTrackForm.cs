using DatabaseSQLApp.src;
using System.Media;

namespace DatabaseSQLApp
{
    public partial class NewTrackForm : Form
    {
        private readonly MusicForm ParentMusicForm;
        private readonly int SelectedAlbumID;

        public NewTrackForm(MusicForm parentMusicForm, int selectedAlbumID, string selectedAlbumName)
        {
            InitializeComponent();

            this.ParentMusicForm = parentMusicForm;
            this.SelectedAlbumID = selectedAlbumID;

            AddingToLabel.Text = $"Adding to album {selectedAlbumName}...";
        }

        /// <summary>
        /// Used when accessing TextBoxEmpty[]
        /// </summary>
        private enum TextBoxID
        {
            Name = 0,
            Number = 1,
            VideoURL = 2,
            Lyrics = 3
        }

        // Holds whether each TextBox is empty or not
        public bool[] TextBoxEmpty = new bool[4] {
            true,
            true,
            true,
            true
        };

        /// <summary>
        /// Remove reference to this form in MusicForm
        /// Invoked when NewAlbumForm is closing 
        /// </summary>
        private void NewTrackForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ParentMusicForm.trackForm = null;
        }

        /// <summary>
        /// Insert a new element to the track table with data from TextBox
        /// "Add" Button
        /// </summary>
        private void AddTrackButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Reset the status labels
                SuccessLabel.Visible = false;
                FailLabel.Visible = false;
                TextVisibilityTimer.Stop();

                Track t = new Track()
                {
                    Name = txt_trackTitle.Text,
                    Number = int.Parse(txt_trackNumber.Text),
                    VideoURL = txt_trackVideoURL.Text,
                    Lyrics = txt_trackLyrics.Text,

                    albums_ID = SelectedAlbumID,
                };
                MusicDAO.AddNewTrack(t);

                ParentMusicForm.RefreshAlbumData();
                ParentMusicForm.RefreshTrackData();

                txt_trackTitle.Clear();
                txt_trackNumber.Clear();
                txt_trackVideoURL.Clear();
                txt_trackLyrics.Clear();

                SuccessLabel.Visible = true;
            }
            catch (Exception)
            {
                FailLabel.Visible = true;
                SystemSounds.Exclamation.Play();
            }
            finally
            {
                TextVisibilityTimer.Start();
            }
        }

        /// <summary>
        /// Hide status text and stop timer on first tick
        /// </summary>
        private void TextVisibilityTimer_Tick(object sender, EventArgs e)
        {
            FailLabel.Visible = false;
            SuccessLabel.Visible = false;

            TextVisibilityTimer.Stop();
        }

        /// <summary>
        /// Enable Add Album button if all TextBox objects contain text
        /// </summary>
        private void SetButtonState(TextBoxID ID, string TextToCheck)
        {
            TextBoxEmpty[(int)ID] = string.IsNullOrEmpty(TextToCheck) ? true : false;

            // If any TextBox is empty, disable AddAlbum button
            for (int i = 0; i < TextBoxEmpty.Length; i++)
            {
                if (TextBoxEmpty[i])
                {
                    AddTrackButton.Enabled = false;
                    return;
                }
            }
            AddTrackButton.Enabled = true;
        }

        /// <summary>
        /// Check if txt_trackTitle is empty or not
        /// </summary>
        private void txt_trackTitle_TextChanged(object sender, EventArgs e)
        {
            SetButtonState(TextBoxID.Name, txt_trackTitle.Text);
        }

        /// <summary>
        /// Check if txt_trackNumber is empty or not
        /// </summary>
        private void txt_trackNumber_TextChanged(object sender, EventArgs e)
        {
            SetButtonState(TextBoxID.Number, txt_trackNumber.Text);
        }

        /// <summary>
        /// Check if txt_VideoURL is empty or not
        /// </summary>
        private void txt_trackVideoURL_TextChanged(object sender, EventArgs e)
        {
            SetButtonState(TextBoxID.VideoURL, txt_trackVideoURL.Text);
        }
        
        /// <summary>
        /// Check if txt_traclLyrics is empty or not
        /// </summary>
        private void txt_trackLyrics_TextChanged(object sender, EventArgs e)
        {
            SetButtonState(TextBoxID.Lyrics, txt_trackLyrics.Text);
        }
    }
}
