using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace commerceRazor.Model
{
    public class Category
    {
        [Key]
        public int Id { get; set; }        
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [Range(1, 100, ErrorMessage = "Display order must be in range of 1-50")]
        public int DisplayOrder { get; set; }
    }
}
