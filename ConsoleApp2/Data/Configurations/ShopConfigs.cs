using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Data.Configurations
{
    public class ShopConfigs : IEntityTypeConfiguration<Shop>
    {
        public void Configure(EntityTypeBuilder<Shop> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(100);
            builder.Property(x => x.Address).HasMaxLength(100);
            builder.HasOne(x => x.City)
                   .WithMany(x => x.Shops)
                   .HasForeignKey(x => x.CityId);
            builder.HasMany(x => x.Products).WithMany(x => x.Shops);
            builder.Property(x => x.ParkingArea).IsRequired(false);
        }
    }
}
