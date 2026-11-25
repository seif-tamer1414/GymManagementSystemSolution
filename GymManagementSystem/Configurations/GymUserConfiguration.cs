using GymManagementSystem.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace GymManagementSystem.Configurations
{
    public class GymUserConfiguration<T> : IEntityTypeConfiguration<T> where T : GymUser
    {
        public void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(X => X.Name).HasColumnType("varchar").HasMaxLength(50);
            builder.Property(X => X.Phone).HasColumnType("varchar").HasMaxLength(11);
            builder.ComplexProperty(X => X.Address);
            builder.HasIndex(X => X.Email).IsUnique();
            builder.HasIndex(X => X.Phone).IsUnique();
            builder.ToTable(t =>
            {
                t.HasCheckConstraint("GymUser_Emailcheck", "Email LIKE '_%@_%._%'");
                t.HasCheckConstraint("GymUser_Phonecheck", "LEN(Phone) = 11 AND (Phone LIKE '010%' OR Phone LIKE '011%' OR Phone LIKE '012%' OR Phone LIKE '015%')");

            });
        }
    }
}
