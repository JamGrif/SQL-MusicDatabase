namespace DatabaseSQLApp.src
{
    /// <summary>
    /// Element in track table
    /// Field values taken from database
    /// </summary>
    public class Track
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int number { get; set; }
        public string VideoURL { get; set; }
        public string Lyrics { get; set; }

        public int albums_ID { get; set; }
    }
}