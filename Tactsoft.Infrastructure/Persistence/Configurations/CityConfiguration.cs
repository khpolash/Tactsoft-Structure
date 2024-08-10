using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tactsoft.SharedKernel.Entities;

namespace Tactsoft.Infrastructure.Persistence.Configurations;

public class CityConfiguration : IEntityTypeConfiguration<City>
{
    public void Configure(EntityTypeBuilder<City> builder)
    {
        builder.ToTable(nameof(City));
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).HasMaxLength(85);
        builder.HasData(

            // Cities for California
            new City { Id = 1, Name = "Los Angeles", StateId = 1, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 2, Name = "San Francisco", StateId = 1, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 3, Name = "San Diego", StateId = 1, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 4, Name = "Sacramento", StateId = 1, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 5, Name = "San Jose", StateId = 1, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },

            // Cities for Texas
            new City { Id = 6, Name = "Houston", StateId = 2, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 7, Name = "Dallas", StateId = 2, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 8, Name = "Austin", StateId = 2, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 9, Name = "San Antonio", StateId = 2, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 10, Name = "Fort Worth", StateId = 2, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },

            // Cities for New York
            new City { Id = 11, Name = "New York City", StateId = 3, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 12, Name = "Buffalo", StateId = 3, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 13, Name = "Rochester", StateId = 3, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 14, Name = "Yonkers", StateId = 3, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 15, Name = "Syracuse", StateId = 3, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },

            // Cities for Florida
            new City { Id = 16, Name = "Miami", StateId = 4, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 17, Name = "Orlando", StateId = 4, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 18, Name = "Tampa", StateId = 4, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 19, Name = "Jacksonville", StateId = 4, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 20, Name = "Fort Lauderdale", StateId = 4, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },

            // Cities for Illinois
            new City { Id = 21, Name = "Chicago", StateId = 5, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 22, Name = "Aurora", StateId = 5, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 23, Name = "Naperville", StateId = 5, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 24, Name = "Rockford", StateId = 5, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 25, Name = "Joliet", StateId = 5, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },

            // Cities for Ontario
            new City { Id = 26, Name = "Toronto", StateId = 6, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 27, Name = "Ottawa", StateId = 6, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 28, Name = "Mississauga", StateId = 6, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 29, Name = "Brampton", StateId = 6, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 30, Name = "Hamilton", StateId = 6, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },

            // Cities for Quebec
            new City { Id = 31, Name = "Montreal", StateId = 7, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 32, Name = "Quebec City", StateId = 7, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 33, Name = "Laval", StateId = 7, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 34, Name = "Gatineau", StateId = 7, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 35, Name = "Longueuil", StateId = 7, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },

            // Cities for British Columbia
            new City { Id = 36, Name = "Vancouver", StateId = 8, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 37, Name = "Victoria", StateId = 8, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 38, Name = "Surrey", StateId = 8, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 39, Name = "Burnaby", StateId = 8, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 40, Name = "Richmond", StateId = 8, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },

            // Cities for Alberta
            new City { Id = 41, Name = "Calgary", StateId = 9, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 42, Name = "Edmonton", StateId = 9, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 43, Name = "Red Deer", StateId = 9, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 44, Name = "Lethbridge", StateId = 9, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 45, Name = "St. Albert", StateId = 9, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },

            // Cities for Manitoba
            new City { Id = 46, Name = "Winnipeg", StateId = 10, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 47, Name = "Brandon", StateId = 10, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 48, Name = "Steinbach", StateId = 10, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 49, Name = "Thompson", StateId = 10, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 50, Name = "Portage la Prairie", StateId = 10, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },

            // Cities for England
            new City { Id = 51, Name = "London", StateId = 11, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 52, Name = "Manchester", StateId = 11, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 53, Name = "Birmingham", StateId = 11, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 54, Name = "Liverpool", StateId = 11, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 55, Name = "Leeds", StateId = 11, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },

            // Cities for Scotland
            new City { Id = 56, Name = "Edinburgh", StateId = 12, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 57, Name = "Glasgow", StateId = 12, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 58, Name = "Aberdeen", StateId = 12, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 59, Name = "Dundee", StateId = 12, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 60, Name = "Inverness", StateId = 12, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },

            // Cities for Wales
            new City { Id = 61, Name = "Cardiff", StateId = 13, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 62, Name = "Swansea", StateId = 13, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 63, Name = "Newport", StateId = 13, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 64, Name = "Wrexham", StateId = 13, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 65, Name = "Barry", StateId = 13, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },

            // Cities for Northern Ireland
            new City { Id = 66, Name = "Belfast", StateId = 14, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 67, Name = "Derry", StateId = 14, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 68, Name = "Lisburn", StateId = 14, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 69, Name = "Newry", StateId = 14, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 70, Name = "Armagh", StateId = 14, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },

            // Cities for Cornwall
            new City { Id = 71, Name = "Truro", StateId = 15, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 72, Name = "Falmouth", StateId = 15, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 73, Name = "Penzance", StateId = 15, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 74, Name = "Newquay", StateId = 15, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 75, Name = "St Ives", StateId = 15, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },

            // Cities for New South Wales
            new City { Id = 76, Name = "Sydney", StateId = 16, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 77, Name = "Newcastle", StateId = 16, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 78, Name = "Wollongong", StateId = 16, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 79, Name = "Dubbo", StateId = 16, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 80, Name = "Tamworth", StateId = 16, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },

            // Cities for Victoria
            new City { Id = 81, Name = "Melbourne", StateId = 17, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 82, Name = "Geelong", StateId = 17, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 83, Name = "Ballarat", StateId = 17, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 84, Name = "Bendigo", StateId = 17, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 85, Name = "Shepparton", StateId = 17, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },

            // Cities for Queensland
            new City { Id = 86, Name = "Brisbane", StateId = 18, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 87, Name = "Gold Coast", StateId = 18, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 88, Name = "Townsville", StateId = 18, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 89, Name = "Cairns", StateId = 18, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 90, Name = "Toowoomba", StateId = 18, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },

            // Cities for Western Australia
            new City { Id = 91, Name = "Perth", StateId = 19, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 92, Name = "Fremantle", StateId = 19, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 93, Name = "Bunbury", StateId = 19, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 94, Name = "Albany", StateId = 19, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 95, Name = "Kalgoorlie", StateId = 19, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },

            // Cities for South Australia
            new City { Id = 96, Name = "Adelaide", StateId = 20, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 97, Name = "Mount Gambier", StateId = 20, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 98, Name = "Whyalla", StateId = 20, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 99, Name = "Port Augusta", StateId = 20, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 100, Name = "Port Lincoln", StateId = 20, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },

            // Cities for New South Wales
            new City { Id = 101, Name = "Sydney", StateId = 16, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 102, Name = "Newcastle", StateId = 16, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 103, Name = "Wollongong", StateId = 16, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 104, Name = "Dubbo", StateId = 16, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 105, Name = "Tamworth", StateId = 16, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },

            // Cities for Victoria
            new City { Id = 106, Name = "Melbourne", StateId = 17, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 107, Name = "Geelong", StateId = 17, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 108, Name = "Ballarat", StateId = 17, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 109, Name = "Bendigo", StateId = 17, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 110, Name = "Shepparton", StateId = 17, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },

            // Cities for Queensland
            new City { Id = 111, Name = "Brisbane", StateId = 18, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 112, Name = "Gold Coast", StateId = 18, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 113, Name = "Townsville", StateId = 18, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 114, Name = "Cairns", StateId = 18, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 115, Name = "Toowoomba", StateId = 18, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },

            // Cities for Western Australia
            new City { Id = 116, Name = "Perth", StateId = 19, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 117, Name = "Fremantle", StateId = 19, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 118, Name = "Bunbury", StateId = 19, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 119, Name = "Albany", StateId = 19, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 120, Name = "Kalgoorlie", StateId = 19, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },

            // Cities for South Australia
            new City { Id = 121, Name = "Adelaide", StateId = 20, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 122, Name = "Mount Gambier", StateId = 20, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 123, Name = "Whyalla", StateId = 20, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 124, Name = "Port Augusta", StateId = 20, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow },
            new City { Id = 125, Name = "Port Lincoln", StateId = 20, CreatedDate = DateTime.UtcNow, ModifiedDate = DateTime.UtcNow }


        );
    }
}
