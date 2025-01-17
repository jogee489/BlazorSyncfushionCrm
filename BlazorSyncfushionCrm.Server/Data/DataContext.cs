using BlazorSyncfushionCrm.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazorSyncfushionCrm.Server.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder
                .UseSqlServer("Server=.\\SQLExpress;Database=blazorcrm;Trusted_Connection=true;TrustServerCertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().HasData(
                new Contact
                {
                    Id = 1,
                    FirstName = "Peter",
                    LastName = "Parker",
                    NickName = "Spiderman",
                    Place = "New York",
                    DateOfBirth = new DateTime(2001, 8, 1)
                },
                new Contact
                {
                    Id = 2,
                    FirstName = "Bruce",
                    LastName = "Wayne",
                    NickName = "Batman",
                    Place = "Gotham",
                    DateOfBirth = new DateTime(1970, 5, 29)
                }
            );

            modelBuilder.Entity<Note>().HasData(
                new Note { Id = 1, ContactId = 1, Text = "With great power comes great responsibility" },
                new Note { Id = 2, ContactId = 2, Text = "I'm Batman" }
            );
        }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Note> Notes { get; set; }
    }
}
