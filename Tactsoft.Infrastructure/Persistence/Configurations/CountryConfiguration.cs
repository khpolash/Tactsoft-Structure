using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tactsoft.SharedKernel.Entities;

namespace Tactsoft.Infrastructure.Persistence.Configurations;

public class CountryConfiguration : IEntityTypeConfiguration<Country>
{
    public void Configure(EntityTypeBuilder<Country> builder)
    {
        builder.ToTable(nameof(Country));
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).HasMaxLength(85);
        builder.Property(x => x.Code).HasMaxLength(10);
        builder.Property(x => x.CapitalCity).HasMaxLength(85);
        builder.HasData(
            new Country { Id = 1, Name = "United States", Code = "US", CapitalCity = "Washington, D.C.", CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new Country { Id = 2, Name = "Canada", Code = "CA", CapitalCity = "Ottawa", CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new Country { Id = 3, Name = "United Kingdom", Code = "GB", CapitalCity = "London", CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new Country { Id = 4, Name = "Australia", Code = "AU", CapitalCity = "Canberra", CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new Country { Id = 5, Name = "Germany", Code = "DE", CapitalCity = "Berlin", CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new Country { Id = 6, Name = "France", Code = "FR", CapitalCity = "Paris", CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new Country { Id = 7, Name = "Japan", Code = "JP", CapitalCity = "Tokyo", CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new Country { Id = 8, Name = "China", Code = "CN", CapitalCity = "Beijing", CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new Country { Id = 9, Name = "India", Code = "IN", CapitalCity = "New Delhi", CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new Country { Id = 10, Name = "Brazil", Code = "BR", CapitalCity = "Brasília", CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow }
       );
    }
}
