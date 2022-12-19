using DesafioDuett.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DesafioDuett.Data.Map
{
    public class FruitMap : IEntityTypeConfiguration<Fruit>
    {
        public void Configure(EntityTypeBuilder<Fruit> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Description).IsRequired().HasMaxLength(255);
            builder.Property(x => x.ValueA).IsRequired();
            builder.Property(x => x.ValueB).IsRequired();
            builder.HasData(
                new Fruit {Id = 1, Description = "Banana", ValueA = 10, ValueB = 5 },
                new Fruit {Id = 2, Description = "Maça", ValueA = 8, ValueB = 4 },
                new Fruit {Id = 3, Description = "Laranja", ValueA = 6, ValueB = 2 }
            );
        }
    }
}
