
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

            builder.HasMany(c => c.CandidatePhases)
                .WithOne(cp => cp.Candidate)
                .HasForeignKey(cp => cp.CandidateId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(c => c.JobPositionCandidates)
                .WithOne(jpc => jpc.Candidate)
                .HasForeignKey(jpc => jpc.CandidateId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.ToTable("Candidates");
        }
    }

}
