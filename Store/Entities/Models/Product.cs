namespace Entities.Models;
//buraya verileri ekleyerek Model/Product.cs dosyasını siliyoruz
public class Product
{
    public int ProductId { get; set; }
    public string? ProductName { get; set; } = string.Empty;
    public decimal ProductPrice { get; set; }
}
