using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public  class MyDbContext :DbContext        //Hay que instalar el paquete:Microsoft Entity Framework core
    {

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        public DbSet<Persona> Personas { get; set; }

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=mi_database.db"); //Hay que instalar: Microsoft.Entity.Frameworkcore.sqlite
        }*/

    }
}
