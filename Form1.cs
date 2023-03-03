namespace DatabaseSQLApp
{
    public partial class Form1 : Form
    {
        // Connect a list of items to a controller
        BindingSource albumBindingSource = new BindingSource();




        public Form1()
        {
            InitializeComponent();
        }

        private void LoadAlbumButton_Click(object sender, EventArgs e)
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();

            // Connect the list to the grid view control
            albumBindingSource.DataSource = albumsDAO.GetAllAlbums();

            AlbumsDataGridView.DataSource = albumBindingSource;

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();

            // Connect the list to the grid view control
            albumBindingSource.DataSource = albumsDAO.searchTitles(AlbumSearchTextBox.Text);

            AlbumsDataGridView.DataSource = albumBindingSource;
        }

        private void AlbumsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // sender is the item that is sending this message
            DataGridView dataGridView = (DataGridView)sender;

            // Get the row number clicked
            int rowClicked = dataGridView.CurrentRow.Index;

            string? imageURL = dataGridView.Rows[rowClicked].Cells[4].Value.ToString();

            // If image can't be sourced, use default
            try
            {
                AlbumImage.Load(imageURL);
            }
            catch (Exception)
            {
                AlbumImage.Image = AlbumImage.InitialImage;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            // Add a new item to the database
            Album album = new Album()
            {
                AlbumName = txt_albumName.Text,
                Artist = txt_albumArtist.Text,
                Year = Int32.Parse(txt_albumYear.Text),
                ImageURL = txt_ImageURL.Text,
                Description = txt_Description.Text
            };

            AlbumsDAO albumsDAO = new AlbumsDAO();
            int result = albumsDAO.addOneElement(album);
            MessageBox.Show(result.ToString());
        }

    }
}