namespace FitLife.Domain.Entities
{
    public class Habit
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid UserId { get; set; }

        public required string Title { get; set; }

        public string Description { get; set; } = string.Empty;

        public HabitFrequency Frequency { get; set; } = HabitFrequency.Daily;

        public bool IsActive { get; set; } = true;

        public int Streak { get; set; } = 0;

        public DateTimeOffset? LastCompletedAt { get; set; }

        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
    }

    public enum HabitFrequency
    {
        Daily,
        Weekly,
        Custom
    }
}