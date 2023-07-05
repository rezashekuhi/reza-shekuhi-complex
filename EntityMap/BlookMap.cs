﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ComplexManagment.Entities;
namespace ComplexManagment.EntityMap
{
    public class BlookMap : IEntityTypeConfiguration<Blook>
    {
        public void Configure(EntityTypeBuilder<Blook> builder)
        {
            builder.ToTable("Blooks");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(_=>_.Name).HasMaxLength(50).IsRequired();
            builder.Property(_=>_.UnitCount).IsRequired();
            builder.HasOne(_=>_.Complex)
                .WithMany(_=>_.Blooks)
                .HasForeignKey(x => x.ComplexId)
                .OnDelete(DeleteBehavior.ClientNoAction);
                

        }
    }
}
