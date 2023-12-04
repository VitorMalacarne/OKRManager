using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OkrManager.Models;

public class Objective : Task
{
    
    private int _id;
    private List<KeyResult> _keyResults;
    private User _relatedUser;

    public int Id => _id;
    public List<KeyResult> KeyResults => _keyResults;
    public User RelatedUser => _relatedUser;
    
    private Objective()
    {

    }

    public Objective(int id, string title, string description, DateTime startDate, DateTime endDate, bool status, User relatedUser)
    {
        _id = id;
        Title = title;
        Description = description;
        StartDate = startDate;
        EndDate = endDate;
        Status = status;
        _relatedUser = relatedUser;
        _keyResults = new List<KeyResult>();
    }
}