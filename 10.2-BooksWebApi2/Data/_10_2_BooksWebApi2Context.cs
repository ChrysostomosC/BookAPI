using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using _10._2_BooksWebApi2.Models;

namespace _10._2_BooksWebApi2.Data
{
    public class _10_2_BooksWebApi2Context : DbContext
    {
        public _10_2_BooksWebApi2Context (DbContextOptions<_10_2_BooksWebApi2Context> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Data Source=localhost;Initial Catalog=BooksWebApi2;Integrated Security=True;Trust Server Certificate=True");
        }

        public DbSet<_10._2_BooksWebApi2.Models.Book> Book { get; set; } = default!;
    }
}
