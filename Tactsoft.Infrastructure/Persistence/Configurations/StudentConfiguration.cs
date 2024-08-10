using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tactsoft.SharedKernel.Core.Default;
using Tactsoft.SharedKernel.Entities;

namespace Tactsoft.Infrastructure.Persistence.Configurations;

public class StudentConfiguration : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.ToTable(nameof(Student));
        builder.HasKey(x => x.Id);
        builder.Property(x => x.FirstName).HasMaxLength(85);
        builder.Property(x => x.LastName).HasMaxLength(85);
        builder.Property(x => x.Email).HasMaxLength(85);
        builder.Property(x => x.MobileNumber).HasMaxLength(20);
        builder.Property(x => x.ZipCode).HasMaxLength(10);

        builder.HasData(new Student
        {
            Id = 1,
            FirstName = "John",
            LastName = "Doe",
            Email = "john.doe@example.com",
            DateOfBirth = new DateTime(1998, 3, 25),
            MobileNumber = "1234567890",
            Gender = Gender.Male,
            CountryId = 1,
            StateId = 1,
            CityId = 1,
            ZipCode = "12345",
            SSC = true,
            HSC = true,
            Bachelor = true,
            Masters = false,
            ProfilePhoto = "john_doe.jpg"
        },
                new Student
                {
                    Id = 2,
                    FirstName = "Jane",
                    LastName = "Smith",
                    Email = "jane.smith@example.com",
                    DateOfBirth = new DateTime(2000, 7, 10),
                    MobileNumber = "0987654321",
                    Gender = Gender.Female,
                    CountryId = 1,
                    StateId = 1,
                    CityId = 2,
                    ZipCode = "67890",
                    SSC = true,
                    HSC = true,
                    Bachelor = false,
                    Masters = false,
                    ProfilePhoto = string.Empty,
                    CreatedDate = DateTime.UtcNow,
                    ModifiedDate = DateTime.UtcNow
                },
                new Student
                {
                    Id = 3,
                    FirstName = "Michael",
                    LastName = "Johnson",
                    Email = "michael.johnson@example.com",
                    DateOfBirth = new DateTime(1995, 12, 15),
                    MobileNumber = "1122334455",
                    Gender = Gender.Male,
                    CountryId = 1,
                    StateId = 2,
                    CityId = 3,
                    ZipCode = "54321",
                    SSC = true,
                    HSC = true,
                    Bachelor = true,
                    Masters = true,
                    ProfilePhoto = string.Empty,
                    CreatedDate = DateTime.UtcNow,
                    ModifiedDate = DateTime.UtcNow
                },
                new Student
                {
                    Id = 4,
                    FirstName = "Emily",
                    LastName = "Davis",
                    Email = "emily.davis@example.com",
                    DateOfBirth = new DateTime(1997, 4, 18),
                    MobileNumber = "5566778899",
                    Gender = Gender.Female,
                    CountryId = 2,
                    StateId = 3,
                    CityId = 4,
                    ZipCode = "23456",
                    SSC = true,
                    HSC = true,
                    Bachelor = false,
                    Masters = false,
                    ProfilePhoto = string.Empty,
                    CreatedDate = DateTime.UtcNow,
                    ModifiedDate = DateTime.UtcNow
                },
                new Student
                {
                    Id = 5,
                    FirstName = "Daniel",
                    LastName = "Wilson",
                    Email = "daniel.wilson@example.com",
                    DateOfBirth = new DateTime(1999, 9, 9),
                    MobileNumber = "6677889900",
                    Gender = Gender.Male,
                    CountryId = 1,
                    StateId = 2,
                    CityId = 1,
                    ZipCode = "34567",
                    SSC = true,
                    HSC = false,
                    Bachelor = false,
                    Masters = false,
                    ProfilePhoto = string.Empty,
                    CreatedDate = DateTime.UtcNow,
                    ModifiedDate = DateTime.UtcNow
                },
                new Student
                {
                    Id = 6,
                    FirstName = "Sophia",
                    LastName = "Brown",
                    Email = "sophia.brown@example.com",
                    DateOfBirth = new DateTime(1996, 6, 20),
                    MobileNumber = "7788990011",
                    Gender = Gender.Female,
                    CountryId = 3,
                    StateId = 4,
                    CityId = 5,
                    ZipCode = "45678",
                    SSC = true,
                    HSC = true,
                    Bachelor = true,
                    Masters = false,
                    ProfilePhoto = string.Empty,
                    CreatedDate = DateTime.UtcNow,
                    ModifiedDate = DateTime.UtcNow
                },
                new Student
                {
                    Id = 7,
                    FirstName = "William",
                    LastName = "Taylor",
                    Email = "william.taylor@example.com",
                    DateOfBirth = new DateTime(1994, 2, 5),
                    MobileNumber = "8899001122",
                    Gender = Gender.Male,
                    CountryId = 2,
                    StateId = 3,
                    CityId = 4,
                    ZipCode = "56789",
                    SSC = true,
                    HSC = false,
                    Bachelor = false,
                    Masters = false,
                    ProfilePhoto = string.Empty,
                    CreatedDate = DateTime.UtcNow,
                    ModifiedDate = DateTime.UtcNow
                },
                new Student
                {
                    Id = 8,
                    FirstName = "Olivia",
                    LastName = "Martinez",
                    Email = "olivia.martinez@example.com",
                    DateOfBirth = new DateTime(1998, 11, 11),
                    MobileNumber = "9900112233",
                    Gender = Gender.Female,
                    CountryId = 3,
                    StateId = 4,
                    CityId = 5,
                    ZipCode = "67890",
                    SSC = true,
                    HSC = true,
                    Bachelor = true,
                    Masters = true,
                    ProfilePhoto = string.Empty,
                    CreatedDate = DateTime.UtcNow,
                    ModifiedDate = DateTime.UtcNow
                },
                new Student
                {
                    Id = 9,
                    FirstName = "James",
                    LastName = "Anderson",
                    Email = "james.anderson@example.com",
                    DateOfBirth = new DateTime(2001, 5, 1),
                    MobileNumber = "1231231234",
                    Gender = Gender.Male,
                    CountryId = 1,
                    StateId = 1,
                    CityId = 2,
                    ZipCode = "78901",
                    SSC = true,
                    HSC = true,
                    Bachelor = false,
                    Masters = false,
                    ProfilePhoto = string.Empty,
                    CreatedDate = DateTime.UtcNow,
                    ModifiedDate = DateTime.UtcNow
                },
                new Student
                {
                    Id = 10,
                    FirstName = "Ava",
                    LastName = "Clark",
                    Email = "ava.clark@example.com",
                    DateOfBirth = new DateTime(1993, 8, 30),
                    MobileNumber = "4564564567",
                    Gender = Gender.Female,
                    CountryId = 2,
                    StateId = 3,
                    CityId = 4,
                    ZipCode = "89012",
                    SSC = true,
                    HSC = true,
                    Bachelor = true,
                    Masters = true,
                    ProfilePhoto = string.Empty,
                    CreatedDate = DateTime.UtcNow,
                    ModifiedDate = DateTime.UtcNow
                }
            );
    }


}
