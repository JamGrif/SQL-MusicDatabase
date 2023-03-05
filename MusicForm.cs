using System.Windows.Forms;

// object sender - The actual object that sent the message (Button, TextBox, DataGridView, etc) - Must cast to specific winform type to use
// EventArgs e - Contains the event data about the event that triggered the function call

namespace DatabaseSQLApp
{
    public partial class MusicForm : Form
    {
        // Connect a list of items to a controller
        BindingSource albumBindingSource = new BindingSource();
        BindingSource tracksBindingSource = new BindingSource();

        // Cache all albums in albums table
        List<Album> cacheAlbumsTable = new List<Album>();

        public MusicForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Utility - Load the current album table and reload any data in the AlbumsDataGridView
        /// </summary>
        public void RefreshAlbumData()
        {
            cacheAlbumsTable = MusicDAO.GetAllAlbums();

            // Give album table data to the AlbumsDataGridView
            albumBindingSource.DataSource = cacheAlbumsTable;
            AlbumsDataGridView.DataSource = albumBindingSource;
        }


        private void MusicForm_Load(object sender, EventArgs e)
        {
            AlbumsGroupBox.Enabled = false;
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

            int albumIndexClicked = albumDataGridView.CurrentRow.Index;

            string? imageURL = albumDataGridView.Rows[albumIndexClicked].Cells[(int)AlbumColumnName.ImageURL].Value.ToString();
            try
            {
                AlbumImage.Load(imageURL);
            }
            catch (Exception)
            {
                AlbumImage.Image = AlbumImage.InitialImage;
            }

            // Give tracks from track table that use the selected album as a foreign key to the TracksDataGridView
            tracksBindingSource.DataSource = cacheAlbumsTable[albumIndexClicked].Tracks;
            TracksDataGridView.DataSource = tracksBindingSource;
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

        public NewAlbumForm? albumForm = null;

        private void AddNewAlbumButton_Click(object sender, EventArgs e)
        {
            if (albumForm != null)
                return;

            albumForm = new NewAlbumForm(this);
            albumForm.Show();
        }



        private void AddTrackButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Row index selected in the albums table
                int albumIndexClicked = AlbumsDataGridView.CurrentRow.Index;

                int albumID = (int)AlbumsDataGridView.Rows[albumIndexClicked].Cells[(int)AlbumColumnName.ID].Value;

                Track t = new Track()
                {
                    Name = txt_trackTitle.Text,
                    number = int.Parse(txt_trackNumber.Text),
                    VideoURL = txt_trackVideoURL.Text,
                    Lyrics = txt_trackLyrics.Text,

                    albums_ID = albumID,
                };

                MusicDAO.AddNewTrack(t);

            }
            catch (Exception)
            {
                MessageBox.Show("doodood");
            }


        }
    }
}