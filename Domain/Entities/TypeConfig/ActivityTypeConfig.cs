using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Entities.TypeConfig
{
    public class ActivityTypeConfig : IEntityTypeConfiguration<Activity>
    {
        public void Configure(EntityTypeBuilder<Activity> builder)
        {
            builder.ToTable("Activities");
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Title).HasColumnType("varchar(50)");
            builder.Property(a => a.Date).HasColumnType("dateTime");
            builder.Property(a => a.Description).HasColumnType("varchar(50)");
            builder.Property(a => a.Category).HasColumnType("varchar(50)");
            builder.Property(a => a.City).HasColumnType("varchar(50)");
            builder.Property(a => a.Venue).HasColumnType("varchar(50)");
        }
    }
}