using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSQLApp
{
    internal class AlbumsDAO
    {
        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=music;";

        public List<Album> GetAllAlbums()
        {
            // Start with an empty list
            List<Album> returnThese = new List<Album>();

            // Connect to the mysql server
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            // Define the sql statement to fetch all albums
            MySqlCommand command = new MySqlCommand("SELECT * FROM ALBUMS", connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Album a = new Album
                    {
                        ID = reader.GetInt32(0),
                        AlbumName = reader.GetString(1),
                        Artist = reader.GetString(2),
                        Year = reader.GetInt32(3),
                        ImageURL = reader.GetString(4),
                        Description = reader.GetString(5)
                    };
                    returnThese.Add(a);
                }
            }
            connection.Close();


            return returnThese;
        }

        public List<Album> searchTitles(string searchTerm)
        {
            // Start with an empty list
            List<Album> returnThese = new List<Album>();

            // Connect to the mysql server
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            // Define the sql statement to fetch all albums
            string searchWildPhrase = "%" + searchTerm + "%";

            MySqlCommand command = new MySqlCommand();
            command.CommandText = "SELECT * FROM ALBUMS WHERE ALBUM_TITLE LIKE @search";
            command.Parameters.AddWithValue("@search", searchWildPhrase);
            command.Connection = connection;

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Album a = new Album
                    {
                        ID = reader.GetInt32(0),
                        AlbumName = reader.GetString(1),
                        Artist = reader.GetString(2),
                        Year = reader.GetInt32(3),
                        ImageURL = reader.GetString(4),
                        Description = reader.GetString(5)
                    };
                    returnThese.Add(a);
                }
            }
            connection.Close();


            return returnThese;
        }

        public int addOneElement(Album album)
        {
            // Connect to the mysql server
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            // Define the sql statement to fetch all albums
            MySqlCommand command = new MySqlCommand("INSERT INTO `albums`(`ALBUM_TITLE`, `ARTIST`, `YEAR`, `IMAGE_NAME`, `DESCRIPTION`) " +
                "VALUES (@albumtitle, @artist, @year, @imageURL, @description)", connection);

            command.Parameters.AddWithValue("@albumtitle", album.AlbumName);
            command.Parameters.AddWithValue("@artist", album.Artist);
            command.Parameters.AddWithValue("@year", album.Year);
            command.Parameters.AddWithValue("@imageURL", album.ImageURL);
            command.Parameters.AddWithValue("@description", album.Description);

            int newRows = command.ExecuteNonQuery();

            connection.Close();

            return newRows;
        }
    }
}
