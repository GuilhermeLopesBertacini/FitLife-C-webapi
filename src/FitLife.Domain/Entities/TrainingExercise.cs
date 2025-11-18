namespace FitLife.Domain.Entities
{
    public class TrainingExercise
  {
      public Guid Id {get; set; } = Guid.NewGuid();
      public Guid TrainingId { get; set; }
      public Guid ExerciseId { get; set; }
      public int Order { get; set; } // Ordem do exercício na rotina
      public int Sets { get; set; }
      public int Reps { get; set; }
      public decimal Weight { get; set; } // Peso utilizado, se aplicável
      public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
  }
}