using ElsysConnect.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Mapping
{
    public class CandidatePhaseMap : IEntityTypeConfiguration<CandidatePhase>
    {
        public void Configure(EntityTypeBuilder<CandidatePhase> builder)
        {
            builder.ToTable("CandidatePhases");

            builder.HasKey(cp => new { cp.CandidateId, cp.RecruitmentPhaseId });

            builder.Property(cp => cp.CandidateId)
                .HasColumnName("CandidateId")
                .IsRequired();

            builder.Property(cp => cp.RecruitmentPhaseId)
                .HasColumnName("RecruitmentPhaseId")
                .IsRequired();

            builder.Property(cp => cp.Status)
                .HasColumnName("Status")
                .IsRequired()
                .HasMaxLength(20);

            builder.HasOne(cp => cp.Candidate)
                .WithMany(c => c.CandidatePhases)
                .HasForeignKey(cp => cp.CandidateId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(cp => cp.RecruitmentPhase)
                .WithMany(rp => rp.CandidatePhases)
                .HasForeignKey(cp => cp.RecruitmentPhaseId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
