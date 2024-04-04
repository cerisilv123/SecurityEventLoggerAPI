namespace SecurityEventLoggerAPI.Models
{
    public class Category
    {
        public Guid Id { get; set; } = Guid.NewGuid(); // Automatically generates a new GUID for primary key

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
