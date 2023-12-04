// See https://aka.ms/new-console-template for more information

using Microsoft.EntityFrameworkCore.Migrations.Operations;
using OkrManager.Models;
using OkrManager.Repositories;

var userRepository = new Repository<User>();
var useraux = (userRepository.GetById(2));
var user = new User(useraux.Id, useraux.Name, useraux.Password);

Console.WriteLine(user.Name);
Console.WriteLine(user.Password);


