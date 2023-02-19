using ElsysConnect.Domain.Entities;
using Infra.Data.Mapping;
using Microsoft.EntityFrameworkCore;
using MyProject.Infra.Data.Mapping;

namespace Infra.Data.ContextDb
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        // DbSet para cada entidade mapeada
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<JobPosition> JobPositions { get; set; }
        public DbSet<RecruitmentPhase> RecruitmentPhases { get; set; }       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // aqui você pode adicionar os mappings de cada entidade
            modelBuilder.ApplyConfiguration(new CandidateMap());
            modelBuilder.ApplyConfiguration(new JobPositionMap());
            modelBuilder.ApplyConfiguration(new RecruitmentPhaseMap());            
        }
    }
}
