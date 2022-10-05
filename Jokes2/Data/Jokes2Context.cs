using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Jokes2.Models;

namespace Jokes2.Data
{
    public class Jokes2Context : DbContext
    {
        public Jokes2Context (DbContextOptions<Jokes2Context> options)
            : base(options)
        {
        }

        public DbSet<Jokes2.Models.Jokes> Jokes { get; set; } = default!;
    }
}
