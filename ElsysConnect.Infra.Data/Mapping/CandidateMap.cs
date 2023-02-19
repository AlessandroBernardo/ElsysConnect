
using ElsysConnect.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Mapping
{
    //public class CandidateMap : IEntityTypeConfiguration<Candidate>
    //{
        //public void Configure(EntityTypeBuilder<Candidate> builder)
        //{
        //    builder.HasKey(c => c.Id);
        //    builder.Property(c => c.Name)
        //        .IsRequired()
        //        .HasColumnName("Name")
        //        .HasColumnType("varchar(50)");
        //    builder.Property(c => c.Email)
        //        .IsRequired()
        //        .HasColumnName("Email")
        //        .HasColumnType("varchar(100)");
        //    builder.Property(c => c.Age)
        //        .IsRequired()
        //        .HasColumnName("Age")
        //        .HasColumnType("int(3)");
        //    builder.Property(c => c.Phone)
        //        .IsRequired()
        //        .HasColumnName("Phone")
        //        .HasColumnType("varchar(16)"); 


        //    builder.ToTable("Candidates");
        //}
    //}

}
