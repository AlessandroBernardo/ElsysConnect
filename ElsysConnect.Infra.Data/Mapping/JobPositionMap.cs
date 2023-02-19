using ElsysConnect.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Mapping
{
    public class JobPositionMap : IEntityTypeConfiguration<JobPosition>
    {
        public void Configure(EntityTypeBuilder<JobPosition> builder)
        {
            builder.HasKey(j => j.Id);
            builder.Property(j => j.Title).IsRequired();            

            builder.HasMany(j => j.JobPositionPhases)
                .WithOne(jp => jp.JobPosition)
                .HasForeignKey(jp => jp.JobPositionId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(j => j.Candidates)
                .WithMany(c => c.JobPositions)
                .UsingEntity<JobPositionCandidate>(
                    j => j.HasOne(jc => jc.JobPosition)
                          .WithMany(j => j.JobPositionCandidates)
                          .HasForeignKey(jc => jc.JobPositionId),
                    j => j.HasOne(jc => jc.Candidate)
                          .WithMany(c => c.JobPositionCandidates)
                          .HasForeignKey(jc => jc.CandidateId),
                    j =>
                    {
                        j.HasKey(jc => new { jc.JobPositionId, jc.CandidateId });
                        j.ToTable("JobPositionCandidates");
                    });

            builder.ToTable("JobPositions");
        }
    }
}
