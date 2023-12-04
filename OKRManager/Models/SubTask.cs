using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OkrManager.Models;

public class SubTask : Task
{
    
    private int _id;
    private int _priority;
    private KeyResult _relatedKeyResult;

    public int Id => _id;
    public int Priority => _priority;
    public KeyResult  RelatedKeyResult => _relatedKeyResult;

    // Construtor sem parâmetros para o EF Core
    private SubTask()
    {

    }

    public SubTask(int id, string title, string description, DateTime startDate, DateTime endDate, bool status, int priority, KeyResult  relatedKeyResult)
    {
        _id = id;
        Title = title;
        Description = description;
        StartDate = startDate;
        EndDate = endDate;
        Status = status;
        _priority = priority;
        _relatedKeyResult = relatedKeyResult;
    }
}