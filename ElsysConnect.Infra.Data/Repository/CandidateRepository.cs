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
            //var candidateRecruitmentPhases = await _dbConnection.QueryAsync<CandidateRecruitmentPhaseDto>(GetQueries.CandidatesRecruitmentPhases());
            var sql = @"               
            SELECT c.Id, c.Name as CandidateName, c.Email as CandidateEmail, c.Phone as CandidatePhone, jp.Title as JobPositionTitle, rp.Name as PhaseName, crp.Status
            FROM [ElsysConnectDb].[dbo].[CandidateRecruitmentPhase] crp
            LEFT JOIN Candidates c ON crp.CandidateId = c.Id
            LEFT JOIN JobPositionRecruitmentPhase jprp ON jprp.Id = crp.JobPositionRecruitmentPhaseId
            LEFT JOIN JobPositions jp ON jp.Id = jprp.JobPositionId
            LEFT JOIN RecruitmentPhases rp ON rp.Id = jprp.RecruitmentPhaseId
            ORDER BY c.Name, rp.Id";

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




