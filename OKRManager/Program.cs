// See https://aka.ms/new-console-template for more information

using Microsoft.EntityFrameworkCore.Migrations.Operations;
using OkrManager.Models;
using OkrManager.Repositories;

    var user = new User
    {
        ID = 1,
        name = "Nome do Usuário",
        password = "Senha123",
        objectives = new List<Objective>()
    };
    var UserRepository = new Repository<User>();
    UserRepository.Create(user);

