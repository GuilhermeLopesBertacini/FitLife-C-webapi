using Microsoft.EntityFrameworkCore;
using FitLife.Domain.Entities;

namespace FitLife.Persistence.Data
{
    public class FitLifeDbContext : DbContext
  {
      // constructor receives options object
      public FitLifeDbContext(DbContextOptions<FitLifeDbContext> options) : base(options)
      {
      }

      // each property represents a table of the given entity type
      public DbSet<Exercise> Exercises { get; set; } = null!;
      public DbSet<Habit> Habits { get; set; } = null!;
      public DbSet<NutritionEntry> NutritionEntries { get; set; } = null!;
      public DbSet<Training> Trainings { get; set; } = null!;
      public DbSet<TrainingExercise> TrainingExercises { get; set; } = null!;
      public DbSet<User> Users { get; set; } = null!;
  
      // personalize model creation mapping (optional)
      protected override void OnModelCreating(ModelBuilder modelBuilder)
      {
          base.OnModelCreating(modelBuilder);
      }
  }
}