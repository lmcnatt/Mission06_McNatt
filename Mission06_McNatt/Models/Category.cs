using System.ComponentModel.DataAnnotations;

namespace Mission06_McNatt.Models
{
    public class Category
    {
        [Key][Required] public int CategoryId { get; set; }
        [Required] public string CategoryName { get; set; }
    }
}
