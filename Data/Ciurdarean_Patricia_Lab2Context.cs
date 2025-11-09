using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Ciurdarean_Patricia_Lab2.Models;

namespace Ciurdarean_Patricia_Lab2.Data
{
    public class Ciurdarean_Patricia_Lab2Context : IdentityDbContext<IdentityUser>
    {
        public Ciurdarean_Patricia_Lab2Context(DbContextOptions<Ciurdarean_Patricia_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Book> Book { get; set; } = default!;
        public DbSet<Publisher> Publisher { get; set; } = default!;
        public DbSet<Author> Author { get; set; } = default!;
        public DbSet<Category> Category { get; set; } = default!;
        public DbSet<Member> Member { get; set; } = default!;
        public DbSet<Borrowing> Borrowing { get; set; } = default!;
    }
}
