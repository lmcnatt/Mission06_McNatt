﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_McNatt.Models
{
    public class Movie
    {
        [Key][Required] public int MovieId { get; set; }
        [ForeignKey("CategoryId")] public int? CategoryId { get; set; }
        public Category? Category { get; set; }
        [Required] public string Title { get; set;}
        [Required][Range(1888, Int32.MaxValue, ErrorMessage = "Enter a year after 1888")] public int Year { get; set;}
        public string? Director { get; set;}
        [Required] public string Rating { get; set; }
        [Required] public bool Edited { get; set; }
        public string? LentTo { get; set; }
        [Required] public bool CopiedToPlex { get; set; }
        [MaxLength(25)] public string? Notes { get; set; }

    }
}
