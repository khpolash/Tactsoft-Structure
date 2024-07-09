using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static Tactsoft.SharedKernel.Entities.Identities.IdentityModel;

namespace Tactsoft.Infrastructure.Persistence.Configurations.IdentityModelConfiguration;

public class UserRoleConfiguration : IEntityTypeConfiguration<UserRole>
{
    public void Configure(EntityTypeBuilder<UserRole> builder) { builder.ToTable(nameof(UserRole)); }
}
