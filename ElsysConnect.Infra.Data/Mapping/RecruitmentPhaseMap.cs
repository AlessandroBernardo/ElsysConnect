using ElsysConnect.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MyProject.Infra.Data.Mapping
{
    public class RecruitmentPhaseMap : BaseEntityMap<RecruitmentPhase>, IEntityTypeConfiguration<RecruitmentPhase>
    {
        public void Configure(EntityTypeBuilder<RecruitmentPhase> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("varchar(100)"); 
            builder.ToTable("RecruitmentPhases");
        }
    }
}
