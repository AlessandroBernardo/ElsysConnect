using ElsysConnect.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MyProject.Infra.Data.Mapping
{
    public class RecruitmentPhaseMap : IEntityTypeConfiguration<RecruitmentPhase>
    {
        public void Configure(EntityTypeBuilder<RecruitmentPhase> builder)
        {
            builder.ToTable("RecruitmentPhases");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.HasMany(p => p.JobPositionPhases)
                .WithOne(jp => jp.RecruitmentPhase)
                .HasForeignKey(jp => jp.RecruitmentPhaseId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(p => p.CandidatePhases)
                .WithOne(cp => cp.RecruitmentPhase)
                .HasForeignKey(cp => cp.RecruitmentPhaseId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
