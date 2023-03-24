using DatabaseSQLApp.src;
using System.Media;

namespace DatabaseSQLApp
{
    public partial class NewAlbumForm : Form
    {
        private readonly MusicForm ParentMusicForm;

        /// <summary>
        /// Used when accessing TextBoxEmpty[]
        /// </summary>
        private enum TextBoxID
        {
            AlbumName = 0,
            Artist = 1,
            Year = 2,
            ImageUrl = 3,
            Description = 4
        }

        // Holds whether each TextBox is empty or not
        public bool[] TextBoxEmpty = new bool[5] {
            true,
            true,
            true,
            true,
            true
        };

        public NewAlbumForm(MusicForm parentMusicForm)
        {
            InitializeComponent();

            this.ParentMusicForm = parentMusicForm;
        }

        /// <summary>
        /// Remove reference to this form in MusicForm
        /// Invoked when NewAlbumForm is closing
        /// </summary>
        private void NewAlbumForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ParentMusicForm.albumForm = null;
        }

        /// <summary>
        /// Insert a new element to the album table with data from TextBox
        /// "Add" Button
        /// </summary>
        private void AddAlbumButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Reset the status labels
                SuccessLabel.Visible = false;
                FailLabel.Visible = false;
                TextVisibilityTimer.Stop();

                // Add new album from TextBox data
                Album album = new Album()
                {
                    Name = txt_albumName.Text,
                    Artist = txt_albumArtist.Text,
                    Year = Int32.Parse(txt_albumYear.Text),
                    ImageURL = txt_ImageURL.Text,
                    Description = txt_Description.Text
                };
                MusicDAO.AddNewAlbum(album);

                // Reload album data to show new addition in AlbumDataGridView
                ParentMusicForm.RefreshAlbumData();

                txt_albumName.Clear();
                txt_albumArtist.Clear();
                txt_albumYear.Clear();
                txt_ImageURL.Clear();
                txt_Description.Clear();

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
                    AddAlbumButton.Enabled = false;
                    return;
                }
            }
            AddAlbumButton.Enabled = true;
        }

        /// <summary>
        /// Check if txt_albumName is empty
        /// </summary>
        private void txt_albumName_TextChanged(object sender, EventArgs e)
        {
            SetButtonState(TextBoxID.AlbumName, txt_albumName.Text);
        }

        /// <summary>
        /// Check if txt_albumArtist is empty
        /// txt_albumArtist TextBox Event
        /// </summary>
        private void txt_albumArtist_TextChanged(object sender, EventArgs e)
        {
            SetButtonState(TextBoxID.Artist, txt_albumArtist.Text);
        }

        /// <summary>
        /// Check if txt_albumYear is empty
        /// txt_albumYear TextBox Event
        /// </summary>
        private void txt_albumYear_TextChanged(object sender, EventArgs e)
        {
            SetButtonState(TextBoxID.Year, txt_albumYear.Text);
        }

        /// <summary>
        /// Check if txt_ImageURL is empty
        /// txt_ImageURL TextBox Event
        /// </summary>
        private void txt_ImageURL_TextChanged(object sender, EventArgs e)
        {
            SetButtonState(TextBoxID.ImageUrl, txt_ImageURL.Text);
        }

        /// <summary>
        /// Check if txt_Description is empty
        /// txt_Description TextBox Event
        /// </summary>
        private void txt_Description_TextChanged(object sender, EventArgs e)
        {
            SetButtonState(TextBoxID.Description, txt_Description.Text);
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
    }
}
