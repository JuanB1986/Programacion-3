using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class MyContextDb : DbContext
    {
        public DbSet<User> Users { get; set; }

        public MyContextDb(DbContextOptions<MyContextDb> options) : base(options) { }

    }
}
