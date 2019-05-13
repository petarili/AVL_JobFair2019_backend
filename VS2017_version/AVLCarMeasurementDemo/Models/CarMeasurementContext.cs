using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AVLCarMeasurementDemo.Models
{
  public class CarMeasurementContext: DbContext
  {

    public CarMeasurementContext(DbContextOptions<CarMeasurementContext> options) : base(options) { }

    public DbSet<ChannelChartConfiguration> ChannelChartConfigurations { get; set; }

    public DbSet<ChannelType> ChannelTypes { get; set; }

    public DbSet<Measurement> Measurements { get; set; }

    public DbSet<UnitUnderTest> UnitUnderTests { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Measurement>().OwnsOne(c => c.ChannelType);
      modelBuilder.Entity<Measurement>().OwnsOne(c => c.UnitUnderTest);
      modelBuilder.Entity<ChannelChartConfiguration>().OwnsOne(c => c.ChannelType);
    }

  }
}
