namespace DatabaseSQLApp
{
    /// <summary>
    /// Element in album table
    /// Field values taken from database
    /// </summary>
    public class Album
    {
        public int      ID { get; set; }
        public string   Name { get; set; }
        public string   Artist { get; set; }
        public int      Year { get; set; }
        public string   ImageURL { get; set; }
        public string   Description { get; set; }

        // Each element in track table that use this album as foreign key
        public List<Track> Tracks { get; set; }
    }
}
