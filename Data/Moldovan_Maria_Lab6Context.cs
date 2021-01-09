using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Moldovan_Maria_Lab6.Models;

namespace Moldovan_Maria_Lab6.Data
{
    public class Moldovan_Maria_Lab6Context : DbContext
    {
        public Moldovan_Maria_Lab6Context (DbContextOptions<Moldovan_Maria_Lab6Context> options)
            : base(options)
        {
        }

        public DbSet<Moldovan_Maria_Lab6.Models.Book> Book { get; set; }
    }
}
