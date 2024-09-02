using Microsoft.EntityFrameworkCore;

namespace StoreApp.Models
{
    public class RepositoryContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        //DbContextOptions ifadesi ile gelmeyen bir talep newleme isteği geçersiz bir istektir
        //veritabanına ne zaman ihtiyaç olursa o zaman tanımlanmalı dbcontext
        //bu options ifadesi base'e gitmeli, yani dbcontext'e 
        public RepositoryContext(DbContextOptions<RepositoryContext> options)
        :base(options)
        {
            
        }
    }
}
