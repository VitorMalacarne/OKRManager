using System.ComponentModel.DataAnnotations;

namespace OkrManager.Models;

public class Objective : Task
{
    [Key]
    public int Id { get; set; }
    public List<KeyResult> keyResults { get; set; }
}