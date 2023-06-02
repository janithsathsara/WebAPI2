using Microsoft.EntityFrameworkCore;
using WebAPI2.Models;

namespace WebAPI2.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Villa> Villas { get; set; }
    }
   
}


//using System.Data.Entity;
//
//namespace CatalogueAPI
//{
//    public class CatalogueDbContext : DbContext
//    {
//        public DbSet<Product> Products { get; set; }
//
//        public CatalogueDbContext(string connectionString)
//            : base(connectionString)
//        {
//        }
//    }
//}


