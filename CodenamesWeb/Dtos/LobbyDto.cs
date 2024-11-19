namespace CodenamesWeb.Dtos
{
    public class LobbyDto
    {
        public string LobbyId { get; set; }
        public int PlayersCount { get; set; }
        public int MaxPlayersCount { get; set; } = 12;

        public LobbyDto(string id, int playersCount, int maxPlayersCount)
        {
            LobbyId = id;
            PlayersCount = playersCount;
            MaxPlayersCount = maxPlayersCount;
        }
        public LobbyDto(string id, int playersCount)
        {
            LobbyId = id;
            PlayersCount = playersCount;
        }

    }
}
