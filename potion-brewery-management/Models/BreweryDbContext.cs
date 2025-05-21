using Microsoft.EntityFrameworkCore;
using potion_brewery_management.Models;

public class BreweryDbContext : DbContext {
    public DbSet<Ingredient> Ingredients { get; set; }
    public DbSet<Recipe> Recipes { get; set; }
    public DbSet<RecipeIngredient> RecipeIngredients { get; set; }
    public DbSet<BrewedPotion> BrewedPotions { get; set; }

    public BreweryDbContext() { }
    public BreweryDbContext(DbContextOptions<BreweryDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        modelBuilder.Entity<RecipeIngredient>()
            .HasOne(ri => ri.Recipe)
            .WithMany(r => r.RecipeIngredients)
            .HasForeignKey(ri => ri.RecipeId);

        modelBuilder.Entity<RecipeIngredient>()
            .HasOne(ri => ri.Ingredient)
            .WithMany(i => i.RecipeIngredients)
            .HasForeignKey(ri => ri.IngredientId);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        optionsBuilder.UseSqlServer("Server=SAMUELS_LAPTOP\\SQLEXPRESS;Database=PotionBreweryDB;Integrated Security=True;TrustServerCertificate=True");
    }
}
