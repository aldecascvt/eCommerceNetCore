using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace Commerce.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(200)]
        public string Title { get; set; }
        [Required, StringLength(500)]
        public string Description { get; set; }
        [Required, StringLength(50)]
        public string ISBN { get; set; }
        [Required, StringLength(150)]
        public string Author { get; set; }
        [Required, Range(1,10000)]
        public double ListPrice { get; set; }
        [Required, Range(1, 10000)]
        public double Price { get; set; }
        [Required, Range(1, 10000)]
        public double Price50 { get; set; }
        [Required, Range(1, 10000)]
        public double Price100 { get; set; }
        [StringLength(300)]
      
        public string? ImageUrl { get; set; }
        public int CategoryId { get; set; }
       
        public Category? Category { get; set; }
        public int CoverTypeId { get; set; }
        
        public CoverType? CoverType { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;

    }
}
