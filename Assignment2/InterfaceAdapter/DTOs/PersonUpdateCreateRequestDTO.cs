

using Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace InterfaceAdapters.DTOs;

public class PersonUpdateCreateRequestDTO
{
    [Required]
    [MaxLength(50,ErrorMessage = "Maximum FirstName length is 50 characters.")]
    public required string FirstName { get; set; }
    [Required]
    [MaxLength(50, ErrorMessage = "Maximum LastName length is 50 characters.")]
    public required string LastName { get; set; }
    [Required]
    public DateTime DateOfBirth { get; set; }
    [Required]
    public GenderType Gender { get; set; }
    [Required]
    [MaxLength(50, ErrorMessage = "Maximum LastName length is 50 characters.")]
    public required string BirthPlace { get; set; } 
}
