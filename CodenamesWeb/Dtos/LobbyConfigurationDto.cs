namespace CodenamesWeb.Dtos
{
    public class LobbyConfigurationDto
    {
        public string LobbyId { get; set; }
        public string GameMode { get; set; }
        public int TeamCount { get; set; }
        public int WordCount { get; set; }
        public double TurnTimeInSeconds { get; set; }
    }
}
