using Microsoft.EntityFrameworkCore;
using Points.Shared.Models;
using SmartEnum.EFCore;

namespace Points.API.Models
{
    public class PointsDbContext : DbContext
    {
        public PointsDbContext(DbContextOptions<PointsDbContext> options) : base(options) { }

        public DbSet<Module> Modules => Set<Module>();
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
           
            modelBuilder.Entity<Module>().HasKey(b => b.Id);
            //modelBuilder.Entity<Module>().Property
            //    (p => p.Signal).HasConversion(
            //    p => p.Value, p => SignalType.FromValue(p));

            //modelBuilder.Entity<Module>().Property
            //    (p => p.Type).HasConversion(
            //    p => p.Value, p => ModuleType.FromValue(p));

            modelBuilder.Entity<Module>().HasData(new Module
            {
                Id = 1,
                Name = "750-550",

                MinCnts = 0,

                MaxCnts = 32764,

                Type = ModuleType.Analog,

                Signal = SignalType.Voltage,

                Channels = 2
            });
            modelBuilder.Entity<Module>().HasData(new Module
            {
                Id = 2,
                Name = "750-556",

                MinCnts = -32767,

                MaxCnts = 32767,

                Type = ModuleType.Analog,

                Signal = SignalType.Voltage,

                Channels = 2
            });
            modelBuilder.Entity<Module>().HasData(new Module
            {
                Id = 3,
                Name = "750-552",
                MinCnts = 0,
                MaxCnts = 32767,
                Type = ModuleType.Analog,
                Signal = SignalType.Current,
                Channels = 2
            });
            modelBuilder.Entity<Module>().HasData(new Module
            {
                Id = 4,
                Name = "750-400",

                MinCnts = 0,

                MaxCnts = 0,

                Type = ModuleType.Digital,

                Signal = SignalType.Current,

                Channels = 2
            });

            modelBuilder.ConfigureSmartEnum();
        }

    }
}
