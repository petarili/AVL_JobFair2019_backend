using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AVLCarMeasurementDemo.Models
{
    public class CarMeasurementContext : DbContext
    {

        public CarMeasurementContext(DbContextOptions<CarMeasurementContext> options) : base(options) { }

        public DbSet<Measurement> Measurements { get; set; }

        public DbSet<ChannelType> ChannelTypes { get; set; }

        public DbSet<UnitUnderTest> UnitsUnderTest { get; set; }

        public DbSet<ChannelChartConfiguration> ChannelChartConfigurations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Measurement>().OwnsMany(c => c.CT);
            //modelBuilder.Entity<Measurement>().OwnsOne(c => c.UUT);
            modelBuilder.Entity<ChannelChartConfiguration>().OwnsOne(c => c.ChannelType);
        }

    }
}
