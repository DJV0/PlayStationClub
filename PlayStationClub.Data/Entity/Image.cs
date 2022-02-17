namespace PlayStationClub.Data.Entity
{
    public class Image
    {
        public int Id { get; set; }
        public string FileName { get; set; }

        public int GameId { get; set; }
        public Game Game { get; set; }
    }
}
