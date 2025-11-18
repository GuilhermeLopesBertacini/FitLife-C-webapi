namespace FitLife.Domain.Entities
{
    public class Training
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public required string Title { get; set; }

        public string? Description { get; set; }

        public TrainingType Type { get; set; } = TrainingType.Other;

        public int? DurationMinutes { get; set; }

        public Guid? UserId { get; set; }

        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
    }

    public enum TrainingType
    {
        Strength,
        Cardio,
        Mobility,
        Other
    }
}
