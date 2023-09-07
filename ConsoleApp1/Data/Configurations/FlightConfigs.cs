using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class FlightConfigs : IEntityTypeConfiguration<Flights>
    {
        public void Configure(EntityTypeBuilder<Flights> builder)
        {
            builder.HasOne(x => x.Arrival).WithMany(x => x.Flights).HasForeignKey(x => x.ArrivalPlaceId);
            builder.HasMany(x => x.Airplanes).WithMany(x => x.Flights);
            builder.HasMany(x => x.Clients).WithMany(x => x.Flights);
        }
    }
}
