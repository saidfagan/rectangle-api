using Microsoft.EntityFrameworkCore;

namespace RectangleApi.Data;

public class RectangleContext : DbContext
{
    public DbSet<RectangleEntity> Rectangles { get; set; } = null!;

    public RectangleContext(DbContextOptions<RectangleContext> options)
        : base(options)
    {
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite("Data Source=Data/RectangleDatabase.db");
}