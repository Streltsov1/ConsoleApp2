using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ClientConfigs : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(100);
            builder.Property(x => x.Surname).HasMaxLength(100);
            builder.Property(x => x.Email).HasMaxLength(100);
            builder.HasOne(x => x.Gender).WithMany(x => x.Clients).HasForeignKey(x => x.GenderId);
            builder.HasOne(x => x.Account).WithMany(x => x.Clients).HasForeignKey(x => x.AccountId);
        }
    }
}
