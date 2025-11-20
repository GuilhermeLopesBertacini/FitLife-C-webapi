namespace FitLife.Domain.Entities
{
    public class TrainingExercise
  {
      public Guid Id {get; set; } = Guid.NewGuid();
      public Guid TrainingId { get; set; }
      public Guid ExerciseId { get; set; }
      public int Order { get; set; } // Exercise order in training sequence
      public int Sets { get; set; }
      public int Reps { get; set; }
      public decimal Weight { get; set; } // Weight used for the exercise
      public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
  }
}