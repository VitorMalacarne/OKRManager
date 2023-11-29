using System.ComponentModel.DataAnnotations;

namespace OkrManager.Models;

public class User
{
	[Key]
    public int ID { get; set; }
	public string name{ get; set; }
	public string password { get; set; }
	public List<Objective> objectives { get; set; }


}