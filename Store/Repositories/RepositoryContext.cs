using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repositories;
//buraya verileri ekleyerek Model/RepositoryContext.cs dosyasını siliyoruz


public class RepositoryContext : DbContext
{
	public DbSet<Product> Products { get; set; }
	public DbSet<Category> Categories { get; set; }

	//DbContextOptions ifadesi ile gelmeyen bir talep newleme isteği geçersiz bir istektir
	//veritabanına ne zaman ihtiyaç olursa o zaman tanımlanmalı dbcontext
	//bu options ifadesi base'e gitmeli, yani dbcontext'e 
	public RepositoryContext(DbContextOptions<RepositoryContext> options)
	: base(options)
	{

	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);
		//eğer veri yoksa veritabanına buradaki verileri insert girecek, veri varsa da buraya bakmayacak
		//buranın geçerli olması için yeni bir migration oluşturulacak ProductSeedData
		modelBuilder.Entity<Product>()
			.HasData(
				new Product() { ProductId = 1, ProductName = "Computer", ProductPrice = 45_000 },
				new Product() { ProductId = 2, ProductName = "Keybord", ProductPrice = 5_000 },
				new Product() { ProductId = 3, ProductName = "Mouse", ProductPrice = 2_000 },
				new Product() { ProductId = 4, ProductName = "Monitor", ProductPrice = 15_000 },
				new Product() { ProductId = 5, ProductName = "Deck", ProductPrice = 3_000 }
			);

		modelBuilder.Entity<Category>()
			.HasData(
			new Category() { CategoryId=1,CategoryName="Book"},
			new Category() { CategoryId = 2, CategoryName = "Electronic" }
			);
	}
	
}
