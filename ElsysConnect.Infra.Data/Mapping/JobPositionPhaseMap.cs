using ElsysConnect.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Mapping
{
    public class JobPositionPhaseMap : IEntityTypeConfiguration<JobPositionPhase>
    {
        public void Configure(EntityTypeBuilder<JobPositionPhase> builder)
        {
            builder.HasKey(jp => new { jp.JobPositionId, jp.RecruitmentPhaseId });

            builder.HasOne(jp => jp.JobPosition)
                   .WithMany(j => j.RecruitmentPhases)
                   .HasForeignKey(jp => jp.JobPositionId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(jp => jp.RecruitmentPhase)
                   .WithMany(rp => rp.JobPositions)
                   .HasForeignKey(jp => jp.RecruitmentPhaseId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.ToTable("JobPositionPhase");
        }
    }
}
