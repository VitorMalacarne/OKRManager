using System.ComponentModel.DataAnnotations;

namespace OkrManager.Models;

public class User
{
	
	private int _id;
	private string _name;
	private string _password;
	private List<Objective> _objectives;

	public int Id => _id;
	public string Name => _name;
	public string Password => _password;
	public List<Objective> Objectives => _objectives;

	// Construtor sem parâmetros para o EF Core
	private User()
	{
		
	}

	
	public User(int id, string name, string password)
	{
		_id = id;
		_name = name;
		_password = password;
		_objectives = new List<Objective>();
	}
	
	public void AddObjective(Objective objective)
	{
		_objectives.Add(objective);
	}
}
