using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseSQLApp
{
    public partial class NewTrackForm : Form
    {
        public NewTrackForm(MusicForm parentMusicForm, int selectedAlbumID, string selectedAlbumName)
        {
            InitializeComponent();

            this.ParentMusicForm = parentMusicForm;
            this.SelectedAlbumID = selectedAlbumID;

            AddingToLabel.Text = $"Adding to album {selectedAlbumName}...";

            ResultText.Visible = false;
        }

        private MusicForm ParentMusicForm;
        private int SelectedAlbumID;


        private void AddTrackButton_Click(object sender, EventArgs e)
        {
            try
            {
                ResultText.Visible = true;

                Track t = new Track()
                {
                    Name = txt_trackTitle.Text,
                    number = int.Parse(txt_trackNumber.Text),
                    VideoURL = txt_trackVideoURL.Text,
                    Lyrics = txt_trackLyrics.Text,

                    albums_ID = SelectedAlbumID,
                };

                MusicDAO.AddNewTrack(t);

                ResultText.Text = "Successfully added track to database";
                ResultText.ForeColor = Color.DarkGreen;

                ParentMusicForm.RefreshAlbumData();
                ParentMusicForm.RefreshTrackData();
            }
            catch (Exception)
            {
                ResultText.Text = "Failed to add album to database";
                ResultText.ForeColor = Color.DarkRed;
            }
        }

        private void NewTrackForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Remove reference to this form in parent
            ParentMusicForm.trackForm = null;
        }
    }
}
