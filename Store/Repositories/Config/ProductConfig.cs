using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Config
{
	public class ProductConfig : IEntityTypeConfiguration<Product>
	{
		public void Configure(EntityTypeBuilder<Product> builder)
		{
			builder.HasKey(p => p.ProductId);
			builder.Property(p=> p.ProductName).IsRequired();
			builder.Property(p => p.ProductPrice).IsRequired();

			builder.HasData(
				new Product() { ProductId = 1, CategoryId = 2, ProductName = "Computer", ProductPrice = 45_000 },
				new Product() { ProductId = 2, CategoryId = 2, ProductName = "Keybord", ProductPrice = 5_000 },
				new Product() { ProductId = 3, CategoryId = 2, ProductName = "Mouse", ProductPrice = 2_000 },
				new Product() { ProductId = 4, CategoryId = 2, ProductName = "Monitor", ProductPrice = 15_000 },
				new Product() { ProductId = 5, CategoryId = 2, ProductName = "Deck", ProductPrice = 3_000 },
				new Product() { ProductId = 6, CategoryId = 1, ProductName = "History", ProductPrice = 300 },
				new Product() { ProductId = 7, CategoryId = 1, ProductName = "Hamlet", ProductPrice = 150 }
			);
		}
	}

}
