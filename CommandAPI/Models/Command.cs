using System.ComponentModel.DataAnnotations;

namespace CommandAPI.Models;

public record Command()
{
    [Key]
    [Required]
    public int Id { get; init; } = 0;

    [Required]
    [MaxLength(250)]
    public string HowTo { get; init; } = string.Empty;

    [Required]
    public string Platform { get; init; } = string.Empty;

    [Required]
    public string CommandLine { get; init; } = string.Empty;
}
