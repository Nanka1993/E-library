using E_library.Models;
using Microsoft.EntityFrameworkCore;

namespace E_library.Database
{
    public sealed class LibraryContext : DbContext
    {
        private const string ConnectionString =
            (@"Server=LAPTOP-G8GTO9EJ\NANKA;Database=E-library;Trusted_Connection=True;");

        private const string ConnectionStringA = (@"Server=.\;Database=E-library;Trusted_Connection=True;");


        public DbSet<Magazine> Magazines { get; set; }
        public DbSet<Dissertation> Dissertations { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<SynopsisOfThesis> SynopsisOfThesises { get; set; }
        public DbSet<Article> Articles { get; set; }


        public LibraryContext()
        {
            Database.EnsureCreated();
        }

        public LibraryContext(DbContextOptions options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Magazine>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<Dissertation>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<Book>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<SynopsisOfThesis>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<Article>()
                .HasKey(x => x.Id);
        }
    }
}