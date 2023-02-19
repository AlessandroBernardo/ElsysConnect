using ElsysConnect.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class JobPositionMap : IEntityTypeConfiguration<JobPosition>
{
    public void Configure(EntityTypeBuilder<JobPosition> builder)
    {
        builder.ToTable("JobPositions");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Title)
            .HasMaxLength(100)
            .IsRequired();

        builder.HasMany(x => x.Candidates)
            .WithMany(x => x.JobPositions)
            .UsingEntity<JobPositionCandidate>(
                j => j.HasOne(jpc => jpc.Candidate)
                    .WithMany(c => c.JobPositionCandidates)
                    .HasForeignKey(jpc => jpc.CandidateId),
                j => j.HasOne(jpc => jpc.JobPosition)
                    .WithMany(jp => jp.JobPositionCandidates)
                    .HasForeignKey(jpc => jpc.JobPositionId),
                j =>
                {
                    j.HasKey(jpc => new { jpc.CandidateId, jpc.JobPositionId });
                    j.ToTable("JobPositionCandidates");
                });

        builder.HasMany(x => x.RecruitmentPhases)
            .WithMany(x => x.JobPositions)
            .UsingEntity<JobPositionPhase>(
                j => j.HasOne(jpp => jpp.RecruitmentPhase)
                    .WithMany(rp => rp.JobPositionPhases)
                    .HasForeignKey(jpp => jpp.RecruitmentPhaseId),
                j => j.HasOne(jpp => jpp.JobPosition)
                    .WithMany(jp => jp.JobPositionPhases)
                    .HasForeignKey(jpp => jpp.JobPositionId),
                j =>
                {
                    j.HasKey(jpp => new { jpp.RecruitmentPhaseId, jpp.JobPositionId });
                    j.ToTable("JobPositionPhases");
                });

        builder.Property(x => x.ClosingDate)
            .HasColumnType("datetime2");
    }
}
