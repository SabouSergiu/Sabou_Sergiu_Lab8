using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sabou_Sergiu_Lab8.Models;

namespace Sabou_Sergiu_Lab8.Data
{
    public class Sabou_Sergiu_Lab8Context : DbContext
    {
        public Sabou_Sergiu_Lab8Context (DbContextOptions<Sabou_Sergiu_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Sabou_Sergiu_Lab8.Models.Book> Book { get; set; }

        public DbSet<Sabou_Sergiu_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Sabou_Sergiu_Lab8.Models.Category> Category { get; set; }
    }
}
