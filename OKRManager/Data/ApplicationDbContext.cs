using Microsoft.EntityFrameworkCore;
using OkrManager.Models;
using Task = System.Threading.Tasks.Task;

namespace OKRManager.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<KeyResult> KeyResults { get; set; }
    public DbSet<Objective> Objective { get; set; }
    public DbSet<SubTask> SubTask { get; set; }
    public DbSet<User> User { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql("server=localhost;database=OKRManager;user=root;password=0f8jsiz6ik5y",
            new MySqlServerVersion("10.4.28-MariaDB"));
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>()
            .HasKey(u => u.Id); // Definindo a chave primária explicitamente

        modelBuilder.Entity<User>()
            .Property(u => u.Name)
            .IsRequired(); // Indicando que o campo Name é obrigatório

        modelBuilder.Entity<User>()
            .Property(u => u.Password)
            .IsRequired(); // Indicando que o campo Password é obrigatório

        // Configuração para mapear a relação entre User e Objective
        modelBuilder.Entity<User>()
            .HasMany(u => u.Objectives)
            .WithOne(o => o.RelatedUser)
            .HasForeignKey(o => o.Id)
            .OnDelete(DeleteBehavior.Cascade); 

        modelBuilder.Entity<Objective>()
            .HasKey(o => o.Id);
        
        modelBuilder.Entity<Objective>()
            .HasMany(o => o.KeyResults)
            .WithOne(kr => kr.RelatedObjective)
            .HasForeignKey(kr => kr.Id)
            .OnDelete(DeleteBehavior.Cascade);
        
        modelBuilder.Entity<KeyResult>()
            .HasKey(kr => kr.Id);
        modelBuilder.Entity<KeyResult>()
            .HasMany(kr => kr.SubTasks)
            .WithOne(st => st.RelatedKeyResult)
            .HasForeignKey(st => st.Id)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<SubTask>()
            .HasKey(st => st.Id);
        /*
        modelBuilder.Entity<Objective>()
            .HasIndex(o => o.RelatedUser);
        modelBuilder.Entity<KeyResult>()
           .HasIndex(kr => kr.RelatedObjective);
        modelBuilder.Entity<SubTask>()
           .HasIndex(st => st.RelatedKeyResult);*/

        
        /*
        modelBuilder.Entity<Objective>()
            .HasOne(o => o.RelatedUser)
            .WithMany(u => u.Objectives)
            .HasForeignKey(o => o.RelatedUser);
        
      

        modelBuilder.Entity<KeyResult>()
            .HasOne(kr => kr.RelatedObjective)
            .WithMany(o => o.KeyResults)
            .HasForeignKey(kr => kr.RelatedObjective);
        
       

        modelBuilder.Entity<SubTask>()
            .HasOne(st => st.RelatedKeyResult)
            .WithMany()
            .HasForeignKey(st => st.RelatedKeyResult);
        */

        base.OnModelCreating(modelBuilder);
    }


}