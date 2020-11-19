using Microsoft.EntityFrameworkCore;
using NpraN.Model;
using System;

namespace NpraN.Data
{
    public class AppDbContext : DbContext 
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Grupo> Grupos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=.\SQLEXPRESS;Database=EFCoreDB;Integrated Security=True");
            optionsBuilder.LogTo(Console.WriteLine);

        }
    }
}
