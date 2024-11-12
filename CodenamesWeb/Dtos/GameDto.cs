namespace CodenamesWeb.Dtos
{
    public class GameDto
    {
        public int Id { get; set; }
        public int PlayersCount { get; set; }
        public int MaxPlayersCount { get; set; } = 12;

        public GameDto(int id, int playersCount, int maxPlayersCount)
        {
            Id = id;
            PlayersCount = playersCount;
            MaxPlayersCount = maxPlayersCount;
        }
        public GameDto(int id, int playersCount)
        {
            Id = id;
            PlayersCount = playersCount;
        }

    }
}
