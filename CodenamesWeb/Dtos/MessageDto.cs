using CodenamesWeb.Enums;

namespace CodenamesWeb.Dtos
{
    public class MessageDto
    {
        public string Id { get; set; } = new Guid().ToString();
        public UserDto From { get; set; }
        public string Text { get; set; }
        public int Count { get; set; }
        public ColorStyle Color { get; set; }

    }
}
