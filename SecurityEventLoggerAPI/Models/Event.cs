namespace SecurityEventLoggerAPI.Models
{
    public class Event
    {
        public Guid Id { get; set; } = Guid.NewGuid(); // Automatically generates a new GUID for primary key

        public string Name { get; set; }

        public string Description { get; set; }

        public string Location { get; set; }

        public int Severity { get; set; }

        public string Status { get; set; }

        public string? Resolution { get; set; }

        public DateTime EventDateTime { get; set; }
    }
}
