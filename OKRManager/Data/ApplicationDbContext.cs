using Microsoft.EntityFrameworkCore;
using OkrManager.Models;
using Task = System.Threading.Tasks.Task;

namespace OKRManager.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<KeyResult> KeyResults { get; set; }
    public DbSet<Objective> Objectives { get; set; }
    public DbSet<SubTask> SubTasks { get; set; }
    public DbSet<User> Users { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql("server=localhost;database=MeuBanco;user=root;password=0f8jsiz6ik5y",
            new MySqlServerVersion("10.4.28-MariaDB"));
    }
    
}