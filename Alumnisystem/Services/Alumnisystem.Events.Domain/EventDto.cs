namespace Alumnisystem.Events.Domain.Dto
{
    public class EventDto
    {
        public DateOnly Date { get; set; }

        public Guid eventID { get; set; }

        public string? Name { get; set; }

        public string? Summary { get; set; }
    }
}