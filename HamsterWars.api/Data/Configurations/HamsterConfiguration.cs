namespace HamsterWars.api.Data.Configurations;

using HamsterWars.data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class HamsterConfiguration : IEntityTypeConfiguration<Hamster>
{
    public void Configure(EntityTypeBuilder<Hamster> builder)
    {
        builder.HasData(new HamsterStruct().Hamsters);
    }
}
