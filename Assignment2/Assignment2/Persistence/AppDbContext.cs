using Microsoft.EntityFrameworkCore;
using Domain;

namespace WebApi.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Set up case sensitive collation for FirstName and LastName properties
            modelBuilder.Entity<Person>()
                .Property(p => p.FirstName)
                .UseCollation("Latin1_General_CS_AS");

            modelBuilder.Entity<Person>()
                .Property(p => p.LastName)
                .UseCollation("Latin1_General_CS_AS");

            modelBuilder.Entity<Person>().HasData(
                new Person
                {
                    Id = Guid.Parse("11111111-1111-1111-1111-111111111111"),
                    FirstName = "John",
                    LastName = "Smith",
                    DateOfBirth = new DateTime(1990, 5, 12),
                    Gender = GenderType.Male,
                    BirthPlace = "New York"
                },
                new Person
                {
                    Id = Guid.Parse("22222222-2222-2222-2222-222222222222"),
                    FirstName = "Jane",
                    LastName = "Johnson",
                    DateOfBirth = new DateTime(1985, 3, 24),
                    Gender = GenderType.Female,
                    BirthPlace = "Los Angeles"
                },
                new Person
                {
                    Id = Guid.Parse("33333333-3333-3333-3333-333333333333"),
                    FirstName = "Alex",
                    LastName = "Brown",
                    DateOfBirth = new DateTime(1992, 7, 8),
                    Gender = GenderType.Other,
                    BirthPlace = "Chicago"
                },
                new Person
                {
                    Id = Guid.Parse("44444444-4444-4444-4444-444444444444"),
                    FirstName = "Emily",
                    LastName = "Taylor",
                    DateOfBirth = new DateTime(1988, 1, 15),
                    Gender = GenderType.Female,
                    BirthPlace = "Houston"
                },
                new Person
                {
                    Id = Guid.Parse("55555555-5555-5555-5555-555555555555"),
                    FirstName = "Chris",
                    LastName = "Anderson",
                    DateOfBirth = new DateTime(1995, 9, 5),
                    Gender = GenderType.Male,
                    BirthPlace = "Phoenix"
                },
                new Person
                {
                    Id = Guid.Parse("66666666-6666-6666-6666-666666666666"),
                    FirstName = "Anna",
                    LastName = "Thomas",
                    DateOfBirth = new DateTime(1983, 12, 19),
                    Gender = GenderType.Female,
                    BirthPlace = "Seattle"
                },
                new Person
                {
                    Id = Guid.Parse("77777777-7777-7777-7777-777777777777"),
                    FirstName = "Michael",
                    LastName = "Jackson",
                    DateOfBirth = new DateTime(1979, 11, 30),
                    Gender = GenderType.Male,
                    BirthPlace = "Boston"
                },
                new Person
                {
                    Id = Guid.Parse("88888888-8888-8888-8888-888888888888"),
                    FirstName = "Laura",
                    LastName = "White",
                    DateOfBirth = new DateTime(1993, 6, 2),
                    Gender = GenderType.Female,
                    BirthPlace = "Denver"
                },
                new Person
                {
                    Id = Guid.Parse("99999999-9999-9999-9999-999999999999"),
                    FirstName = "David",
                    LastName = "Harris",
                    DateOfBirth = new DateTime(1987, 4, 10),
                    Gender = GenderType.Male,
                    BirthPlace = "Miami"
                },
                new Person
                {
                    Id = Guid.Parse("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                    FirstName = "Sophia",
                    LastName = "Martin",
                    DateOfBirth = new DateTime(1991, 8, 22),
                    Gender = GenderType.Female,
                    BirthPlace = "San Francisco"
                },
                new Person
                {
                    Id = Guid.Parse("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                    FirstName = "Matthew",
                    LastName = "Lee",
                    DateOfBirth = new DateTime(1989, 2, 17),
                    Gender = GenderType.Male,
                    BirthPlace = "Atlanta"
                },
                new Person
                {
                    Id = Guid.Parse("cccccccc-cccc-cccc-cccc-cccccccccccc"),
                    FirstName = "Chloe",
                    LastName = "Nguyen",
                    DateOfBirth = new DateTime(1996, 10, 4),
                    Gender = GenderType.Female,
                    BirthPlace = "Dallas"
                }
                );

        }

        public DbSet<Person> Persons { get; set; }
    }
}
