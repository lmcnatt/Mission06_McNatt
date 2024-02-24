using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_McNatt.Models
{
    public class Movie
    {
        [Key][Required] public int MovieId { get; set; }
        [ForeignKey("CategoryId")] public int? CategoryId { get; set; }
        public Category? Category { get; set; }
        [Required(ErrorMessage = "Enter a valid title")] public string Title { get; set;}
        [Required][Range(1888, int.MaxValue, ErrorMessage = "Enter a year after 1888")] public int Year { get; set;}
        public string? Director { get; set;}
        public string? Rating { get; set; }
        [Required(ErrorMessage = "Fill out the Edited field")] public bool Edited { get; set; }
        public string? LentTo { get; set; }
        [Required(ErrorMessage = "Fill out the Copied to Plex field")] public bool CopiedToPlex { get; set; }
        [MaxLength(25)] public string? Notes { get; set; }

    }
}
