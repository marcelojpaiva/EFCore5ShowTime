using System;
using NpraN.Data;
using NpraN.Model;
using System.Collections.Generic;

namespace NpraN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello EF Core 5!"); 

            var ctx = new AppDbContext();
            var jose = new Usuario { Nome = "José" };
            var maria = new Usuario { Nome = "Maria" };
            var joao = new Usuario { Nome = "João" };

            var grupo1 = new Grupo { Nome = "Grupo1", Usuarios = new List<Usuario> { jose, maria } };
            var grupo2 = new Grupo { Nome = "Grupo2", Usuarios = new List<Usuario> { jose, joao } };

            ctx.Usuarios.AddRange(jose, maria, joao);
            ctx.Grupos.AddRange(grupo1, grupo2);
            ctx.SaveChanges();
        }
    }
}
