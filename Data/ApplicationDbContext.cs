using Microsoft.EntityFrameworkCore;
using WebShopBrodova.Models;
namespace WebShopBrodova.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
            
    }
    public DbSet<TypeBoat> TypesOfBoats { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TypeBoat>().HasData(
            new
            {
                Id  = 1,
                Name = "Motor boats",
                DisplayOrder = 1,
                ImageUrl = "https://as1.ftcdn.net/v2/jpg/01/24/27/30/1000_F_124273079_ZHuBjV9p2Im0LZYcKH82C6bcaQrjRxtq.jpg"
            },
            new
            {
                Id = 2,
                Name = "Sailing boats",
                DisplayOrder = 2,
                ImageUrl = "https://www.bavariayachts.com/fileadmin/_processed_/2/7/csm_bavaria-sy-cruiserline-overview-cruiser37_8a9c47d54f.jpg"
            }
            );
    }
}
