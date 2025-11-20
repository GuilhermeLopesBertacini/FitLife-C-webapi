namespace FitLife.Domain.Entities
{
    public class Exercise
  {
      public Guid Id { get; set; } = Guid.NewGuid();
      public required string Name { get; set; }
      public string Description { get; set; } = string.Empty;
      public string PrimaryMuscle { get; set; } = string.Empty;
      public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
  }
}