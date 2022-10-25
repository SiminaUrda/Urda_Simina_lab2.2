using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Urda_Simina_lab2._2.Models;

namespace Urda_Simina_lab2._2.Data
{
    public class Urda_Simina_lab2_2Context : DbContext
    {
        public Urda_Simina_lab2_2Context (DbContextOptions<Urda_Simina_lab2_2Context> options)
            : base(options)
        {
        }

        public DbSet<Urda_Simina_lab2._2.Models.Book> Book { get; set; } = default!;

        public DbSet<Urda_Simina_lab2._2.Models.Publisher> Publisher { get; set; }

        public DbSet<Urda_Simina_lab2._2.Models.Author> Author { get; set; }
    }
}
