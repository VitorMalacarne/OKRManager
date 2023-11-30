using System.ComponentModel.DataAnnotations;

namespace OkrManager.Models;

public class SubTask : Task
{
    [Key]
    public int Id { get; set; }
}