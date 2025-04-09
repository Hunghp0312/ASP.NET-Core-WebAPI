using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Domain;

public enum GenderType
{
    Male,
    Female,
    Other
}

public class Person
{
    [Key]
    public Guid Id { get; set; }
    [MaxLength(50)]
    public required string FirstName { get; set; }
    [MaxLength(50)]
    public required string LastName { get; set; }
    [NotMapped]
    public string FullName => $"{FirstName} {LastName}";
    public DateTime DateOfBirth { get; set; }
    public GenderType Gender { get; set; }
    public string BirthPlace { get; set; } = string.Empty;
    [SetsRequiredMembers]
    public Person(string firstName, string lastName, DateTime dateOfBirth, GenderType gender, string birthPlace)
    {
        Id = Guid.NewGuid();
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dateOfBirth;
        Gender = gender;
        BirthPlace = birthPlace;
    }

    public Person() { } // For EF Core
}
