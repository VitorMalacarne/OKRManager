using System.ComponentModel.DataAnnotations;

namespace OkrManager.Models;

public class KeyResult : Task
{
    [Key]
    public int Id { get; set; }
    public List<SubTask> subTasks { get; set; }
}