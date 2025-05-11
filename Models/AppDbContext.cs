using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace NutriNyan.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Purpose> Purposes { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Water> Waters { get; set; } = null!;
        public DbSet<WaterEntry> WaterEntries { get; set; } = null!;
        public DbSet<Food> Foods { get; set; } = null!;
        public DbSet<Unit> Units { get; set; } = null!;
        public DbSet<NutritionLog> NutritionLogs { get; set; } = null!;
        public DbSet<Meal> Meals { get; set; } = null!;
        public DbSet<MealItem> MealItems { get; set; } = null!;
        public DbSet<Chat> Chats { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(u => u.TingkatAktivitas)
                .HasConversion<string>();

            modelBuilder.Entity<User>()
                .HasOne(u => u.Purpose)
                .WithMany(p => p.Users)
                .HasForeignKey(u => u.PurposeId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User>()
                .HasOne(u => u.Gender)
                .WithMany(p => p.Users)
                .HasForeignKey(u => u.GenderId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User>()
                .Property(u => u.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            modelBuilder.Entity<User>()
                .Property(u => u.UpdatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            modelBuilder.Entity<Water>()
                .Property(w => w.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            modelBuilder.Entity<Water>()
                .Property(w => w.UpdatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            modelBuilder.Entity<WaterEntry>()
                .Property(we => we.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            modelBuilder.Entity<WaterEntry>()
                .Property(we => we.UpdatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            modelBuilder.Entity<Food>()
                .HasOne(u => u.Unit)
                .WithMany(p => p.Foods)
                .HasForeignKey(u => u.UnitId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Food>()
                .Property(f => f.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            modelBuilder.Entity<Food>()
                .Property(f => f.UpdatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            modelBuilder.Entity<NutritionLog>()
                .Property(n => n.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            modelBuilder.Entity<NutritionLog>()
                .Property(n => n.UpdatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            modelBuilder.Entity<Meal>()
                .Property(m => m.MealType)
                .HasConversion<string>();

            modelBuilder.Entity<Meal>()
                .Property(m => m.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            modelBuilder.Entity<Meal>()
                .Property(m => m.UpdatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            modelBuilder.Entity<MealItem>()
                .Property(mi => mi.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            modelBuilder.Entity<MealItem>()
                .Property(mi => mi.UpdatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            modelBuilder.Entity<Chat>()
                .Property(c => c.Sender)
                .HasConversion<string>();

            modelBuilder.Entity<Chat>()
                .Property(c => c.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");
        }
    }
}
