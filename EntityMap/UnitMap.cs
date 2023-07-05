﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ComplexManagment.Entities;
namespace ComplexManagment.EntityMap
{
    public class UnitMap : IEntityTypeConfiguration<Unit>
    {
        public void Configure(EntityTypeBuilder<Unit> builder)
        {
            builder.ToTable("Units");
            builder.HasKey(_ => _.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(_ => _.Name).HasMaxLength(50).IsRequired();
            builder.Property(_ => _.BlookId).IsRequired();
        }
    }
}
