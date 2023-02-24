using System;
using System.Collections.Generic;
using System.Text;

namespace ElsysConnect.Infra.Data.Repository.Queries.Candidates
{
    public class GetQueries
    {
        public static string CandidatesRecruitmentPhases()
        {
            return $@"SELECT c.Name, c.Email, c.Phone, jp.Title, rp.Name as 'PhaseName', crp.Status
                      FROM [ElsysConnectDb].[dbo].[CandidateRecruitmentPhase] crp
                      left join Candidates c on crp.CandidateId = c.Id
                      left join JobPositionRecruitmentPhase jprp on jprp.Id = crp.JobPositionRecruitmentPhaseId
                      left join JobPositions jp on jp.Id = jprp.JobPositionId
                      left join RecruitmentPhases rp on rp.Id = jprp.RecruitmentPhaseId
                      order by c.Name";
        }
    }
}
