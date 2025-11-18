namespace FitLife.Domain.Entities
{
    public class NutritionEntry
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public Guid UserId { get; set; }

        public DateTimeOffset RecordedAt { get; set; } = DateTimeOffset.UtcNow;

        public MealType Type { get; set; } = MealType.Other;

        public int? Calories { get; set; }

        public decimal? ProteinGrams { get; set; }
        public decimal? CarbsGrams { get; set; }
        public decimal? FatGrams { get; set; }

        public string? Description { get; set; }

        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
    }

    public enum MealType
    {
        Breakfast,
        Lunch,
        Dinner,
        Snack,
        Other
    }
}
