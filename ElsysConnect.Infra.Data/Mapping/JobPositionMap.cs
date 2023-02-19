using ElsysConnect.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Mapping
{
    public class JobPositionMap : BaseEntityMap<JobPosition>, IEntityTypeConfiguration<JobPosition>
    {
        //public void Configure(EntityTypeBuilder<JobPosition> builder)
        //{
        //    base.Configure(builder);

        //    builder.Property(x => x.Title)
        //        .IsRequired()
        //        .HasColumnName("Title")
        //        .HasColumnType("varchar(100)");

        //    builder.ToTable("JobPositions");
        //}
    }

}
