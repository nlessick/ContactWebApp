using Microsoft.EntityFrameworkCore;

namespace MultiPageWebApp.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options)
            : base(options)
        { }

        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().HasData(
                new Contact
                {
                    PhoneId = 1,
                    Name = "Dwayne Johnson",
                    PhoneNumber = "123-456-7890",
                    Address = "123 The Rock Ave",
                    Note = "If you smell, what the rock is cook'n"
                },
                new Contact
                {
                    PhoneId = 2,
                    Name = "Derek Jeter",
                    PhoneNumber = "222-222-2222",
                    Address = "1 Yankee Stadium St",
                    Note = "Greatest shortstop of all time"
                },
                new Contact
                {
                    PhoneId = 3,
                    Name = "Peyton Manning",
                    PhoneNumber = "181-181-1818",
                    Address = "18 Indianapolis Ln",
                    Note = "Omaha!"
                }
            );
        }
    }
}

