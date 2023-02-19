
using ElsysConnect.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Mapping
{
    public class CandidateMap : IEntityTypeConfiguration<Candidate>
    {
        public void Configure(EntityTypeBuilder<Candidate> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Name).IsRequired();
            builder.Property(c => c.Email).IsRequired();
            builder.Property(c => c.Age).IsRequired();
            builder.Property(c => c.Phone).IsRequired();

            // relacionamento com CandidatePhase
            builder.HasMany(c => c.JobPositions)
        .WithMany(jp => jp.Candidates)
        .UsingEntity<JobPositionCandidate>(
             j => j.HasOne(jpc => jpc.JobPosition)
                   .WithMany()
                   .HasForeignKey(jpc => jpc.JobPositionId),
             j => j.HasOne(jpc => jpc.Candidate)
                   .WithMany()
                   .HasForeignKey(jpc => jpc.CandidateId),
             j =>
             {
                 j.HasKey(jpc => new { jpc.JobPositionId, jpc.CandidateId });
                 j.ToTable("JobPositionCandidates");
             });

            builder.ToTable("Candidates");
        }
    }
}
