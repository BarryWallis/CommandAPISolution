using System.ComponentModel.DataAnnotations;

namespace CommandAPI.Models;

public record Command()
{
    [Key]
    [Required]
    public int Id { get; init; }

    [Required]
    [MaxLength(250)]
    public string HowTo { getl init; }

    [Required]
    public string Platform { get; init; }

    [Required]
    public string HowTo { get; init; }
}
