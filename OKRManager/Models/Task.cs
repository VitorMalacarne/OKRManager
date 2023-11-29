using System.ComponentModel.DataAnnotations;

namespace OkrManager.Models;

public class Task
{
    [Key]
    public int Id { get; set; }
    public string title { get; set; }
    public string description { get; set; }
    public DateTime startDate { get; set; }
    public DateTime endDate { get; set; }
    public bool status { get; set; }
}