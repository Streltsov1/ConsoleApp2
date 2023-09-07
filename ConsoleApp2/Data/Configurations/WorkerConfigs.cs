using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class WorkerConfigs : IEntityTypeConfiguration<Worker>
    {
        public void Configure(EntityTypeBuilder<Worker> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(100);
            builder.Property(x => x.Surname).HasMaxLength(100);
            builder.Property(x => x.Email).HasMaxLength(100);
            builder.Property(x => x.PhoneNumber).HasMaxLength(12);
            builder.HasOne(x => x.Position).WithMany(x => x.Workers).HasForeignKey(x => x.PositionId);
            builder.HasOne(x => x.Shop).WithMany(x => x.Workers).HasForeignKey(x => x.ShopId);
        }
    }
}
