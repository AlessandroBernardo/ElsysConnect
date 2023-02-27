using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace ElsysConnect.Infra.Data.Repository.Queries.Candidates
{
    public class GetQueries    {

        //private readonly IConfiguration _configuration;

        //public GetQueries()
        //{

        //}

        //public GetQueries(IConfiguration configuration)
        //{
        //    _configuration = configuration;
        //}
  
        public static string CandidatesRecruitmentPhases()
        {
            //var connectionString = _configuration.GetConnectionString("ConnectionDefault");
            //string catalog = new SqlConnectionStringBuilder(connectionString).InitialCatalog;

            return $@"SELECT c.Id, c.Name as CandidateName, c.Email as CandidateEmail, c.Phone as CandidatePhone, jp.Title as JobPositionTitle, rp.Name as PhaseName, crp.Status
            FROM ElsysConnectDbMigrationTeste.[dbo].[CandidateRecruitmentPhase] crp
            LEFT JOIN Candidates c ON crp.CandidateId = c.Id
            LEFT JOIN JobPositionRecruitmentPhase jprp ON jprp.Id = crp.JobPositionRecruitmentPhaseId
            LEFT JOIN JobPositions jp ON jp.Id = jprp.JobPositionId
            LEFT JOIN RecruitmentPhases rp ON rp.Id = jprp.RecruitmentPhaseId
            ORDER BY c.Name, rp.Id";
        }
    }
}
