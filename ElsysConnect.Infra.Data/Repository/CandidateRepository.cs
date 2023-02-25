using Dapper;
using ElsysConnect.Domain.Entities;
using ElsysConnect.Domain.Entities.Dtos;
using ElsysConnect.Domain.Interfaces;
using ElsysConnect.Infra.Data.Repository.Queries.Candidates;
using Infra.Data.ContextDb;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElsysConnect.Infra.Data.Repository
{
    public class CandidateRepository : BaseRepository<Candidate>, ICandidateRepository
    {

        private readonly IDbConnection _dbConnection;

        public CandidateRepository(IDbConnection dbConnection) : base(dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<IEnumerable<CandidateRecruitmentPhaseDto>> GetCandidatesRecruitmentPhases()
        {
            var sql = GetQueries.CandidatesRecruitmentPhases();            

            var candidatesWithPhases = await _dbConnection.QueryAsync<CandidateRecruitmentPhaseDto, PhasesDto, CandidateRecruitmentPhaseDto>(sql,
                (candidate, phase) =>
                {
                    if (candidate != null)
                    {
                        if (candidate.PhasesDTOs == null)
                        {
                            candidate.PhasesDTOs = new List<PhasesDto>();
                        }
                        candidate.PhasesDTOs.Add(phase);
                    }
                    return candidate;
                },
                splitOn: "PhaseName"
              );
           return candidatesWithPhases
              .GroupBy(c => c.Id)
              .Select(g =>
              {
                  var candidate = g.First();
                  if (candidate != null && candidate.PhasesDTOs != null)
                  {
                      candidate.PhasesDTOs = g.Select(c => c.PhasesDTOs.Single()).ToList();
                  }
                  return candidate;
              });
        }
    }
}




