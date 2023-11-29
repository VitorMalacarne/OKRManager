namespace OkrManager.Models;

public abstract class Task
{
    protected int ID { get; set; }
    public string title { get; set; }
    public string description { get; set; }
    public DateTime startDate { get; set; }
    public DateTime endDate { get; set; }
}