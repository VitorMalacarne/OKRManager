using Microsoft.EntityFrameworkCore;
using OkrManager.Models;
using Task = System.Threading.Tasks.Task;

namespace OKRManager.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<KeyResult> KeyResults { get; set; }
    public DbSet<Objective> Objectives { get; set; }
    public DbSet<SubTask> SubTasks { get; set; }
    public DbSet<Task> Tasks { get; set; }
    public DbSet<User> Users { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql("server=localhost;database=MeuBanco;user=root;password=",
            new MySqlServerVersion("10.4.28-MariaDB"));
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Task>().HasKey(t => t.Id);

        base.OnModelCreating(modelBuilder);
    }
    
}