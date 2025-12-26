using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace demoWeb.Models;

public class Product
{
    [Key]
    
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Product name is required")]
    public string Name { get; set; }
    
    [Required(ErrorMessage =  "Fill product price")]
    public double Price { get; set; }
    
    [Required(ErrorMessage = "Fill product quantity")]
    public string Quantity { get; set; }
    
    [Required(ErrorMessage = "Select category")]
    public int CategoryId { get; set; }
    
    [ForeignKey("CategoryId")]
    public Category Category { get; set; }
    
}