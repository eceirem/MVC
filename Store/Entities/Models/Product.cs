using System.ComponentModel.DataAnnotations;

namespace Entities.Models;
//buraya verileri ekleyerek Model/Product.cs dosyasını siliyoruz
public class Product
{
    public int ProductId { get; set; }
    [Required(ErrorMessage ="Product name is required.")]
    public string? ProductName { get; set; } = string.Empty;
	[Required(ErrorMessage = "Product price is required.")]    
	public decimal ProductPrice { get; set; }
}
