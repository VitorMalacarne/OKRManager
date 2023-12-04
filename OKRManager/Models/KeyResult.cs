using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OkrManager.Models;

public class KeyResult : Task
{
    
    private int _id;
    private List<SubTask> _subTasks;
    private Objective _relatedObjective;

    public int Id => _id;
    public List<SubTask> SubTasks => _subTasks;
    public Objective RelatedObjective => _relatedObjective;

    // Construtor sem parâmetros para o EF Core
    private KeyResult()
    {

    }

    public KeyResult(int id, string title, string description, DateTime startDate, DateTime endDate, bool status, Objective relatedObjective)
    {
        _id = id;
        Title = title;
        Description = description;
        StartDate = startDate;
        EndDate = endDate;
        Status = status;
        _relatedObjective = relatedObjective;
        _subTasks = new List<SubTask>();
    }
}