﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Selu383.SP24.Api.Features.Hotels;

public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
{
    public void Configure(EntityTypeBuilder<Hotel> builder)
    {
        builder.Property(x => x.Name)
            .HasMaxLength(120)
            .IsRequired();

        builder.Property(x => x.Address)
            .IsRequired();

        builder.HasOne(x => x.City)
            .WithMany(x => x.Hotel)
            .HasForeignKey(x => x.CityId)
            .IsRequired();

        builder.HasMany(x => x.Rooms)
            .WithOne(x => x.Hotel);

    }
}