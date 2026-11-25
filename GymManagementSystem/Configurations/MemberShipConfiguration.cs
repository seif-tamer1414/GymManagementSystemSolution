using GymManagementSystem.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace GymManagementSystem.Configurations
{
    public class MemberShipConfiguration : IEntityTypeConfiguration<MemberShip>
    {
        public void Configure(EntityTypeBuilder<MemberShip> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(x => x.CreatedAt).HasDefaultValueSql("GetDate()");
            builder.HasOne(m => m.Plan).WithMany(p => p.MemberShips).HasForeignKey(m => m.PlanId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
