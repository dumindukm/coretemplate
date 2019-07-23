using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MySample_Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MySample_DataService.Configurations
{
    public class EntityAConfig : IEntityTypeConfiguration<EntityA>
    {
        public void Configure(EntityTypeBuilder<EntityA> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.DisplayName)
                .HasMaxLength(150)
               .IsRequired();

            builder.ToTable("EntityA");
        }
    }
}
