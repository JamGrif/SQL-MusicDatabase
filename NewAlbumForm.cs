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

        public NewAlbumForm(MusicForm parnetMusicForm)
        {
            InitializeComponent();

            parentMusicForm = parnetMusicForm;

            ResultText.Visible = false;
        }

        private MusicForm parentMusicForm;

        /// <summary>
        /// Insert a new element to the album table with data from TextBoxes
        /// "Add" Button
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Add a new item to the database
                Album album = new Album()
                {
                    Name = txt_albumName.Text,
                    Artist = txt_albumArtist.Text,
                    Year = Int32.Parse(txt_albumYear.Text),
                    ImageURL = txt_ImageURL.Text,
                    Description = txt_Description.Text
                };

                MusicDAO.AddNewAlbum(album);

                parentMusicForm.RefreshAlbumData();

                txt_albumName.Clear();
                txt_albumArtist.Clear();
                txt_albumYear.Clear();
                txt_ImageURL.Clear();
                txt_Description.Clear();

                ResultText.Visible = true;
                ResultText.Text = "Successfully added to database";
                ResultText.ForeColor = Color.DarkGreen;
            }
            catch (Exception)
            {
                // Failed to insert album
                ResultText.Visible = true;
                ResultText.Text = "Failed to add to database";
                ResultText.ForeColor = Color.DarkRed;
            }
        }

        private void NewAlbumForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Remove reference to this form in parent
            parentMusicForm.albumForm = null;

        }
    }


}
