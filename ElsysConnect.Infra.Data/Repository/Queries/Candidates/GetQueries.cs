using System;
using System.Collections.Generic;
using System.Text;

namespace ElsysConnect.Infra.Data.Repository.Queries.Candidates
{
    public class GetQueries
    {
        public static string CandidatesRecruitmentPhases()
        {
            return $@"SELECT c.Id, c.Name as CandidateName, c.Email as CandidateEmail, c.Phone as CandidatePhone, jp.Title as JobPositionTitle, rp.Name as PhaseName, crp.Status
            FROM [ElsysConnectDb].[dbo].[CandidateRecruitmentPhase] crp
            LEFT JOIN Candidates c ON crp.CandidateId = c.Id
            LEFT JOIN JobPositionRecruitmentPhase jprp ON jprp.Id = crp.JobPositionRecruitmentPhaseId
            LEFT JOIN JobPositions jp ON jp.Id = jprp.JobPositionId
            LEFT JOIN RecruitmentPhases rp ON rp.Id = jprp.RecruitmentPhaseId
            ORDER BY c.Name, rp.Id";
        }
    }
}
