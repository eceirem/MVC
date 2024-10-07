using System.ComponentModel.DataAnnotations;

namespace Entities.Models;
//buraya verileri ekleyerek Model/Product.cs dosyasını siliyoruz
public class Product
{
    public int ProductId { get; set; }
    public string? ProductName { get; set; } = string.Empty;
	public decimal ProductPrice { get; set; }

    public String? Summary { get; set; } = String.Empty;

    public String? ImageUrl { get; set; }
    public int? CategoryId { get; set; } //Foreign key 

	public Category? Category { get; set; } //navigation property

}
