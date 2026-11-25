using GymManagementSystem.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace GymManagementSystem.Configurations
{
    public class SessionConfiguration : IEntityTypeConfiguration<Session>
    {
        public void Configure(EntityTypeBuilder<Session> builder)
        {
           
            builder.Property(x => x.CreatedAt).HasDefaultValueSql("GetDate()");
            builder.HasOne(x => x.Trainer).WithMany(t => t.Sessions).HasForeignKey(s => s.TrainerId).OnDelete(DeleteBehavior.Restrict);
            builder.ToTable(t =>
            {
                t.HasCheckConstraint("SessionCapacityConstraint", "Capacity between 1 and 25");
                t.HasCheckConstraint("SessionEndDateStartDate", "EndTime > StartTime");
            });
        }
    }
}
