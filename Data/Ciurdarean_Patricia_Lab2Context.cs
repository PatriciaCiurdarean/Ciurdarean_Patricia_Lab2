using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ciurdarean_Patricia_Lab2.Models;

namespace Ciurdarean_Patricia_Lab2.Data
{
    public class Ciurdarean_Patricia_Lab2Context : DbContext
    {
        public Ciurdarean_Patricia_Lab2Context (DbContextOptions<Ciurdarean_Patricia_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Ciurdarean_Patricia_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Ciurdarean_Patricia_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Ciurdarean_Patricia_Lab2.Models.Author> Author { get; set; } = default!;
        public DbSet<Ciurdarean_Patricia_Lab2.Models.Category> Category { get; set; } = default!;



}
}
