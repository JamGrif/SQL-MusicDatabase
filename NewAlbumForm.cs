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
    public partial class NewAlbumForm : Form
    {
        private MusicForm ParentMusicForm;

        // Holds whether each TextBox is empty or not
        public bool[] TextBoxEmpty = new bool[5] { 
            true,   // Album Name
            true,   // Artist
            true,   // Year
            true,   // Image URL
            true    // Description
        };

        public NewAlbumForm(MusicForm parentMusicForm)
        {
            InitializeComponent();

            this.ParentMusicForm = parentMusicForm;
        }

        /// <summary>
        /// Insert a new element to the album table with data from TextBoxes
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
                TextVisibilityTimer.Start();
            }
        }

        private void NewAlbumForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Remove reference to this form in parent
            ParentMusicForm.albumForm = null;
        }

        

        private void SetButtonState()
        {
            if (TextBoxEmpty[0] ||
                TextBoxEmpty[1] ||
                TextBoxEmpty[2] ||
                TextBoxEmpty[3] ||
                TextBoxEmpty[4])
            {
                AddAlbumButton.Enabled = false;
            }
            else
            {
                AddAlbumButton.Enabled = true;
            }
        }

        private void txt_albumName_TextChanged(object sender, EventArgs e)
        {
            TextBoxEmpty[0] = string.IsNullOrEmpty(txt_albumName.Text) ? true : false;

            SetButtonState();
        }

        private void txt_albumArtist_TextChanged(object sender, EventArgs e)
        {
            TextBoxEmpty[1] = string.IsNullOrEmpty(txt_albumArtist.Text) ? true : false;

            SetButtonState();
        }

        private void txt_albumYear_TextChanged(object sender, EventArgs e)
        {
            TextBoxEmpty[2] = string.IsNullOrEmpty(txt_albumYear.Text) ? true : false;

            SetButtonState();
        }

        private void txt_ImageURL_TextChanged(object sender, EventArgs e)
        {
            TextBoxEmpty[3] = string.IsNullOrEmpty(txt_ImageURL.Text) ? true : false;

            SetButtonState();
        }

        private void txt_Description_TextChanged(object sender, EventArgs e)
        {
            TextBoxEmpty[4] = string.IsNullOrEmpty(txt_Description.Text) ? true : false;

            SetButtonState();
        }

        private void TextVisibilityTimer_Tick(object sender, EventArgs e)
        {
            FailLabel.Visible = false;
            SuccessLabel.Visible = false;

            TextVisibilityTimer.Stop();
        }
    }


}
