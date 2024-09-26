using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Config;
using System.Reflection;

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
		//modelBuilder.Entity<Product>().HasData() bu satıra gerek yok 
		//bunu ProductConfig.cs dosyasında yapıyoruz
		//modelBuilder.Entity<Category>() buradaki ifadeyi de categoryconfige ekledim

		//burada config dosyalarının doğrudan tanımlanması için işlem yapacağız
		//modelBuilder.ApplyConfiguration(new ProductConfig());
		//modelBuilder.ApplyConfiguration(new CategoryConfig());

		//aşağıdaki ifade daha dinamiktir
		modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

	}

}
