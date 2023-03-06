using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSQLApp.src
{
    /// <summary>
    /// Name of each column of album table in database
    /// </summary>
    public enum AlbumColumnName
    {
        ID = 0,
        Name = 1,
        Artist = 2,
        Year = 3,
        ImageURL = 4,
        Description = 5
    }

    // Name of each track of track table in database
    public enum TrackColumnName
    {
        ID = 0,
        Name = 1,
        Number = 2,
        VideoURL = 3,
        Lyrics = 4
    }

    /// <summary>
    /// Provides a layer of communication between the front end WinForms UI and the back end mySQL database  
    /// DAO - Data Access Object - Performs all the mySQL queries
    /// </summary>
    public static class MusicDAO
    {
        private static string databaseConnectionString = "datasource=localhost;port=3306;username=root;password=root;database=music;";

        /// <summary>
        /// Utility - Fills out an Album object with values taken from an element in album table in the database
        /// </summary>
        private static Album FillInAlbum(MySqlDataReader reader)
        {
            return new Album
            {
                ID = reader.GetInt32((int)AlbumColumnName.ID),
                Name = reader.GetString((int)AlbumColumnName.Name),
                Artist = reader.GetString((int)AlbumColumnName.Artist),
                Year = reader.GetInt32((int)AlbumColumnName.Year),
                ImageURL = reader.GetString((int)AlbumColumnName.ImageURL),
                Description = reader.GetString((int)AlbumColumnName.Description)
            };
        }

        /// <summary>
        /// Utility - Fills out a Track object with values taken from an element in albums table in the database
        /// </summary>
        private static Track FillInTrack(MySqlDataReader reader)
        {
            return new Track
            {
                ID = reader.GetInt32((int)TrackColumnName.ID),
                Name = reader.GetString((int)TrackColumnName.Name),
                number = reader.GetInt32((int)TrackColumnName.Number),
                VideoURL = reader.GetString((int)TrackColumnName.VideoURL),
                Lyrics = reader.GetString((int)TrackColumnName.Lyrics)
            };
        }

        /// <summary>
        /// Query the database and return all entries in the album table
        /// </summary>
        public static List<Album> GetAllAlbums()
        {
            // Establish connection with the database
            MySqlConnection databaseConnection = new MySqlConnection(databaseConnectionString);
            databaseConnection.Open();

            // Define the mySQL command
            MySqlCommand sqlCommand = new MySqlCommand()
            {
                CommandText = "SELECT * FROM ALBUMS",
                Connection = databaseConnection
            };

            List<Album> albumList = new List<Album>();
            using (MySqlDataReader reader = sqlCommand.ExecuteReader())
            {
                // Get each album in the albums table
                while (reader.Read())
                {
                    Album newAlbum = FillInAlbum(reader);

                    // Get each track that uses this album as a foreign key 
                    newAlbum.Tracks = GetAllTracksOfAlbum(newAlbum.ID);

                    albumList.Add(newAlbum);
                }
            }

            databaseConnection.Close();

            return albumList;
        }

        /// <summary>
        /// Query the album table and return all albums where ALBUM_TITLE are like specified string
        /// </summary>
        public static List<Album> SearchAlbumTitles(string searchTerm)
        {
            // Establish connection with the database
            MySqlConnection databaseConnection = new MySqlConnection(databaseConnectionString);
            databaseConnection.Open();

            // Define the mySQL command
            MySqlCommand sqlCommand = new MySqlCommand()
            {
                CommandText = "SELECT * FROM ALBUMS WHERE ALBUM_TITLE LIKE @search",
                Connection = databaseConnection
            };
            sqlCommand.Parameters.AddWithValue("@search", $"%{searchTerm}%"); // wild phrase

            List<Album> albumList = new List<Album>();
            using (MySqlDataReader reader = sqlCommand.ExecuteReader())
            {
                // Get each album in the albums table
                while (reader.Read())
                {
                    albumList.Add(FillInAlbum(reader));
                }
            }

            databaseConnection.Close();

            return albumList;
        }

        /// <summary>
        /// Insert a new element into the album table
        /// </summary>
        public static void AddNewAlbum(Album album)
        {
            // Establish connection with the database
            MySqlConnection databaseConnection = new MySqlConnection(databaseConnectionString);
            databaseConnection.Open();

            // Define the mySQL command
            MySqlCommand sqlCommand = new MySqlCommand()
            {
                CommandText = "INSERT INTO `albums`(`ALBUM_TITLE`, `ARTIST`, `YEAR`, `IMAGE_NAME`, `DESCRIPTION`) VALUES (@albumtitle, @artist, @year, @imageURL, @description)",
                Connection = databaseConnection
            };
            sqlCommand.Parameters.AddWithValue("@albumtitle", album.Name);
            sqlCommand.Parameters.AddWithValue("@artist", album.Artist);
            sqlCommand.Parameters.AddWithValue("@year", album.Year);
            sqlCommand.Parameters.AddWithValue("@imageURL", album.ImageURL);
            sqlCommand.Parameters.AddWithValue("@description", album.Description);

            sqlCommand.ExecuteNonQuery();

            databaseConnection.Close();
        }

        public static void AddNewTrack(Track track)
        {
            // Establish connection with the database
            MySqlConnection databaseConnection = new MySqlConnection(databaseConnectionString);
            databaseConnection.Open();

            // Define the mySQL command
            MySqlCommand sqlCommand = new MySqlCommand()
            {
                CommandText = "INSERT INTO `tracks`(`TRACK_TITLE`, `number`, `video_url`, `lyrics`, `albums_ID`) VALUES (@tracktitle, @number, @videourl, @lyrics, @albumsid)",
                Connection = databaseConnection
            };
            sqlCommand.Parameters.AddWithValue("@tracktitle", track.Name);
            sqlCommand.Parameters.AddWithValue("@number", track.number);
            sqlCommand.Parameters.AddWithValue("@videourl", track.VideoURL);
            sqlCommand.Parameters.AddWithValue("@lyrics", track.Lyrics);
            sqlCommand.Parameters.AddWithValue("@albumsid", track.albums_ID);

            sqlCommand.ExecuteNonQuery();

            databaseConnection.Close();
        }

        /// <summary>
        /// Query the database and return all tracks that have an albums_id foreign key of specified album ID
        /// </summary>
        public static List<Track> GetAllTracksOfAlbum(int albumID)
        {
            // Establish connection with the database
            MySqlConnection databaseConnection = new MySqlConnection(databaseConnectionString);
            databaseConnection.Open();

            // Define the mySQL command
            MySqlCommand sqlCommand = new MySqlCommand()
            {
                CommandText = "SELECT * FROM TRACKS WHERE albums_ID = @albumid",
                Connection = databaseConnection
            };
            sqlCommand.Parameters.AddWithValue("@albumid", albumID);

            List<Track> trackList = new List<Track>();
            using (MySqlDataReader reader = sqlCommand.ExecuteReader())
            {
                // Get each track that has a foreign key of albumID
                while (reader.Read())
                {
                    trackList.Add(FillInTrack(reader));
                }
            }

            databaseConnection.Close();

            return trackList;
        }

        /// <summary>
        /// Delete a track from the track table of specified ID
        /// </summary>
        public static void DeleteTrack(int trackID)
        {
            // Establish connection with the database
            MySqlConnection databaseConnection = new MySqlConnection(databaseConnectionString);
            databaseConnection.Open();

            // Define the mySQL command
            MySqlCommand sqlCommand = new MySqlCommand()
            {
                CommandText = "DELETE FROM tracks WHERE tracks.ID = @trackID",
                Connection = databaseConnection
            };
            sqlCommand.Parameters.AddWithValue("@trackID", trackID);

            sqlCommand.ExecuteNonQuery();

            databaseConnection.Close();
        }
    }
}
