namespace HamsterWars.api.Data;

using HamsterWars.api.Data.Configurations;
using HamsterWars.data;
using Microsoft.EntityFrameworkCore;

public class HamsterDbContext : DbContext
{
    public DbSet<Hamster> Hamsters { get; set; }
    public HamsterDbContext(DbContextOptions<HamsterDbContext> dbContextOptions) : base(dbContextOptions) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new HamsterConfiguration());
    }
}
