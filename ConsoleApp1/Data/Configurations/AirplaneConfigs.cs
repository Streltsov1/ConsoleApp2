using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class AirplaneConfigs : IEntityTypeConfiguration<Airplane>
    {
        public void Configure(EntityTypeBuilder<Airplane> builder)
        {
            builder.Property(x => x.Model).HasMaxLength(100);
            builder.Property(x => x.Type).HasMaxLength(100);
            builder.HasOne(x => x.Country).WithMany(x => x.Airplanes).HasForeignKey(x => x.CountryId);
        }
    }
}
