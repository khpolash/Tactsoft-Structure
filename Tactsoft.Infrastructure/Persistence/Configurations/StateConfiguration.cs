using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tactsoft.SharedKernel.Entities;

namespace Tactsoft.Infrastructure.Persistence.Configurations;

public class StateConfiguration : IEntityTypeConfiguration<State>
{
    public void Configure(EntityTypeBuilder<State> builder)
    {
        builder.ToTable(nameof(State));
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).HasMaxLength(85);
        builder.HasData(
            // States for United States
            new State { Id = 1, Name = "California", CountryId = 1, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new State { Id = 2, Name = "Texas", CountryId = 1, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new State { Id = 3, Name = "New York", CountryId = 1, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new State { Id = 4, Name = "Florida", CountryId = 1, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new State { Id = 5, Name = "Illinois", CountryId = 1, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },

            // States for Canada
            new State { Id = 6, Name = "Ontario", CountryId = 2, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new State { Id = 7, Name = "Quebec", CountryId = 2, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new State { Id = 8, Name = "British Columbia", CountryId = 2, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new State { Id = 9, Name = "Alberta", CountryId = 2, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new State { Id = 10, Name = "Manitoba", CountryId = 2, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },

            // States for United Kingdom
            new State { Id = 11, Name = "England", CountryId = 3, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new State { Id = 12, Name = "Scotland", CountryId = 3, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new State { Id = 13, Name = "Wales", CountryId = 3, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new State { Id = 14, Name = "Northern Ireland", CountryId = 3, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new State { Id = 15, Name = "Cornwall", CountryId = 3, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },

            // States for Australia
            new State { Id = 16, Name = "New South Wales", CountryId = 4, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new State { Id = 17, Name = "Victoria", CountryId = 4, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new State { Id = 18, Name = "Queensland", CountryId = 4, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new State { Id = 19, Name = "Western Australia", CountryId = 4, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new State { Id = 20, Name = "South Australia", CountryId = 4, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },

            // States for Germany
            new State { Id = 21, Name = "Bavaria", CountryId = 5, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new State { Id = 22, Name = "Baden-Württemberg", CountryId = 5, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new State { Id = 23, Name = "North Rhine-Westphalia", CountryId = 5, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new State { Id = 24, Name = "Hesse", CountryId = 5, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new State { Id = 25, Name = "Saxony", CountryId = 5, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },

            // States for France
            new State { Id = 26, Name = "Île-de-France", CountryId = 6, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new State { Id = 27, Name = "Provence-Alpes-Côte d'Azur", CountryId = 6, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new State { Id = 28, Name = "Auvergne-Rhône-Alpes", CountryId = 6, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new State { Id = 29, Name = "Nouvelle-Aquitaine", CountryId = 6, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new State { Id = 30, Name = "Occitanie", CountryId = 6, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },

            // States for Japan
            new State { Id = 31, Name = "Tokyo", CountryId = 7, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new State { Id = 32, Name = "Osaka", CountryId = 7, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new State { Id = 33, Name = "Hokkaido", CountryId = 7, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new State { Id = 34, Name = "Fukuoka", CountryId = 7, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new State { Id = 35, Name = "Aichi", CountryId = 7, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },

            // States for China
            new State { Id = 36, Name = "Beijing", CountryId = 8, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new State { Id = 37, Name = "Shanghai", CountryId = 8, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new State { Id = 38, Name = "Guangdong", CountryId = 8, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new State { Id = 39, Name = "Sichuan", CountryId = 8, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new State { Id = 40, Name = "Zhejiang", CountryId = 8, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },

            // States for India
            new State { Id = 41, Name = "Maharashtra", CountryId = 9, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new State { Id = 42, Name = "Karnataka", CountryId = 9, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new State { Id = 43, Name = "Tamil Nadu", CountryId = 9, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new State { Id = 44, Name = "Uttar Pradesh", CountryId = 9, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new State { Id = 45, Name = "Gujarat", CountryId = 9, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },

            // States for Brazil
            new State { Id = 46, Name = "São Paulo", CountryId = 10, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new State { Id = 47, Name = "Rio de Janeiro", CountryId = 10, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new State { Id = 48, Name = "Minas Gerais", CountryId = 10, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new State { Id = 49, Name = "Bahia", CountryId = 10, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new State { Id = 50, Name = "Paraná", CountryId = 10, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow }

        );
    }
}
