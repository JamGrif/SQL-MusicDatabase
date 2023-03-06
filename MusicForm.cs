using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;

// object sender - The actual object that sent the message (Button, TextBox, DataGridView, etc) - Must cast to specific winform type to use
// EventArgs e - Contains the event data about the event that triggered the function call

namespace DatabaseSQLApp
{
    public partial class MusicForm : Form
    {
        // Connect a list of items to a controller
        BindingSource albumBindingSource = new BindingSource();
        BindingSource tracksBindingSource = new BindingSource();

        public NewAlbumForm? albumForm = null;
        public NewTrackForm? trackForm = null;

        // Cache all albums in albums table
        List<Album> cacheAlbumsTable = new List<Album>();

        public int selctedAlbumIndex;

        public MusicForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Utility - Load the album table and reload any data in AlbumsDataGridView
        /// </summary>
        public void RefreshAlbumData()
        {
            cacheAlbumsTable = MusicDAO.GetAllAlbums();

            // Give album table data to the AlbumsDataGridView
            albumBindingSource.DataSource = cacheAlbumsTable;
            AlbumsDataGridView.DataSource = albumBindingSource;
        }

        /// <summary>
        /// Utility - Reload any data in TracksDataGridView
        /// </summary>
        public void RefreshTrackData()
        {
            tracksBindingSource.DataSource = cacheAlbumsTable[selctedAlbumIndex].Tracks;
            TracksDataGridView.DataSource = tracksBindingSource;
        }

        private void MusicForm_Load(object sender, EventArgs e)
        {
            //AlbumsGroupBox.Enabled = false;
            //TracksGroupBox.Enabled = false;
        }

        /// <summary>
        /// Store all elements in albums table and display them into AlbumsDataGridView
        /// "Load Albums" Button
        /// </summary>
        private void LoadAlbumsButton_Click(object sender, EventArgs e)
        {
            RefreshAlbumData();

            AlbumsGroupBox.Enabled = true;
        }

        /// <summary>
        /// Traverse through each album and display all elements where album title is like text in AlbumSearchTextBox
        /// "Search" Button
        /// </summary>
        private void SearchButton_Click(object sender, EventArgs e)
        {
            // Give all applicable albums data to the AlbumsDataGridView
            albumBindingSource.DataSource = MusicDAO.SearchAlbumTitles(AlbumSearchTextBox.Text);
            AlbumsDataGridView.DataSource = albumBindingSource;
        }

        /// <summary>
        /// Display each element in the albums table
        /// "Albums" DataGridView
        /// </summary>
        private void AlbumsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Treat sender as DataGridView
            DataGridView albumDataGridView = (DataGridView)sender;

            selctedAlbumIndex = albumDataGridView.CurrentRow.Index;

            string? imageURL = albumDataGridView.Rows[selctedAlbumIndex].Cells[(int)AlbumColumnName.ImageURL].Value.ToString();
            try
            {
                AlbumImage.Load(imageURL);
            }
            catch (Exception)
            {
                AlbumImage.Image = AlbumImage.InitialImage;
            }

            // Give tracks from track table that use the selected album as a foreign key to the TracksDataGridView
            tracksBindingSource.DataSource = cacheAlbumsTable[selctedAlbumIndex].Tracks;
            TracksDataGridView.DataSource = tracksBindingSource;

            TracksGroupBox.Enabled = true;
        }


        /// <summary>
        /// Delete the selected track in the TracksDataGridView from the tracks table
        /// "Delete Selected Track" button
        /// </summary>
        private void DeleteSelectedTrackButton_Click(object sender, EventArgs e)
        {
            int trackIndexClicked = TracksDataGridView.CurrentRow.Index;

            int trackID = (int)TracksDataGridView.Rows[trackIndexClicked].Cells[(int)TrackColumnName.ID].Value;
            MusicDAO.DeleteTrack(trackID);

            // Clear the data in TracksDataGridView
            tracksBindingSource.DataSource = null;
            TracksDataGridView.DataSource = null;
        }



        private void AddNewAlbumButton_Click(object sender, EventArgs e)
        {
            if (albumForm != null)
                return;

            albumForm = new NewAlbumForm(this);
            albumForm.Show();
        }


        private void AddNewTrackButton_Click(object sender, EventArgs e)
        {
            // Ensure NewTrackForm not already open
            if (trackForm != null)
                return;

            // Row index selected in the albums table
            int albumIndexClicked = AlbumsDataGridView.CurrentRow.Index;

            int albumID = (int)AlbumsDataGridView.Rows[albumIndexClicked].Cells[(int)AlbumColumnName.ID].Value;
            string? albumName = AlbumsDataGridView.Rows[albumIndexClicked].Cells[(int)AlbumColumnName.Name].Value.ToString();

            // Ensure an album is actually selected
            if (albumID <= 0)
                return;

            trackForm = new NewTrackForm(this, albumID, albumName);
            trackForm.Show();
        }

        private void PlayTrackButton_Click(object sender, EventArgs e)
        {
            try
            {
                int trackIndexClicked = TracksDataGridView.CurrentRow.Index;
                string? videoURL = TracksDataGridView.Rows[trackIndexClicked].Cells[(int)TrackColumnName.VideoURL].Value.ToString();

                if (webView != null && webView.CoreWebView2 != null)
                {
                    webView.CoreWebView2.Navigate(videoURL);
                }
            }
            catch (Exception)
            {
            }
        }
    }
}